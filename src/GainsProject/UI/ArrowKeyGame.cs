//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the arrow key game UI
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Enums;
using GainsProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Runs the arrow key game UI
    //---------------------------------------------------------------
    public partial class ArrowKeyGame : UserControl
    {
        private const int MIN_X_ARROW = 41;
        private const int MAX_X_ARROW = 857;
        private const int MIN_X_DIST = 122;
        private const int MIN_Y_ARROW = 43;
        private const int MAX_Y_ARROW = 531;
        private const int MIN_Y_DIST = 108;
        //Game name and the score save manager to save scores
        private const string GAME_NAME = "ArrowKeyGame.txt";
        ScoreSaveManager scoreSaveManager;
        //Name object
        NameClass name;
        private readonly Random rnd;
        private readonly ArrowKeyGameManager game;
        private CancellationTokenSource cts;
        private Difficulties difficulty;
        private readonly IGameEnd gameEnd;


        //---------------------------------------------------------------
        //Constructor that initializes gameEnd which shows the game end
        // screen when the game finishes
        //---------------------------------------------------------------
        public ArrowKeyGame(IGameEnd gameEnd)
        {
            InitializeComponent();
            rnd = new Random();
            cts = new CancellationTokenSource();
            game = new ArrowKeyGameManager();
            scoreSaveManager = ScoreSaveManager.getScoreSaveManager();
            name = new NameClass();
            this.gameEnd = gameEnd;
        }

        #region Show Hide UI Controls

        //---------------------------------------------------------------
        //Hides the instruction controls
        //---------------------------------------------------------------
        private void hideInstructions()
        {
            InstructionsLbl.Hide();
            EasyDifficultyBtn.Hide();
            MediumDifficultyBtn.Hide();
            HardDifficultBtn.Hide();
        }

        //---------------------------------------------------------------
        //Shows the game controls
        //---------------------------------------------------------------
        private void showGame()
        {
            LeftArrowLbl.Show();
            UpArrowLbl.Show();
            RightArrowLbl.Show();
            DownArrowLbl.Show();
            ScoreLbl.Show();
            TotalScoreLbl.Show();
        }

        #endregion

        #region Difficult Button Events

        //---------------------------------------------------------------
        //Starts the game with easy difficulty
        //---------------------------------------------------------------
        private void easyDifficultyBtn_Click(object sender, EventArgs e)
        {
            difficulty = Difficulties.Easy;
            gameStart();
        }

        //---------------------------------------------------------------
        //Starts the game with medium difficulty
        //---------------------------------------------------------------
        private void mediumDifficultyBtn_Click(object sender, EventArgs e)
        {
            difficulty = Difficulties.Medium;
            gameStart();
        }

        //---------------------------------------------------------------
        //Starts the game with hard difficulty
        //---------------------------------------------------------------
        private void hardDifficultBtn_Click(object sender, EventArgs e)
        {
            difficulty = Difficulties.Hard;
            gameStart();
        }

        #endregion

        #region Run UI updates

        //---------------------------------------------------------------
        //Runs the UI portion of the game
        //Sets and flashes random arrows, moving around per difficulty
        //---------------------------------------------------------------
        private async void gameStart()
        {
            hideInstructions();
            showGame();
            game.start();
            var keys = new Keys[]
            {
                Keys.Left, Keys.Up, Keys.Down, Keys.Right
            };
            while (game.isGameLive())
            {
                cts = new CancellationTokenSource();
                var buttonToClick = keys[rnd.Next(keys.Length)];
                var randomTime = game.randomTime();
                game.setButtonToClick(buttonToClick);
                game.setTimeUntilClick(randomTime);
                Label arrow = getArrowLabel(buttonToClick);
                await Task.Run(async () =>
                {
                    game.stopwatch.Start();
                    await Task.Delay(randomTime);
                    arrow.ForeColor = Color.SpringGreen;
                    await Task.Delay(game.getMaxTimeToClick());
                }, cts.Token);
                arrow.ForeColor = Color.Black;
                shuffleArrowPositions();
            }
            ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
            scoreSave.addScore((int)game.getTotalScore(), name.getName());

            // Call gameFinished if gameEnd is not null
            gameEnd?.gameFinished(name.getName(),
                                  game.getTotalScore(),
                                  game.getGameRunTime());
        }

        //---------------------------------------------------------------
        //Gets the Arrow label for the given key
        //---------------------------------------------------------------
        private Label getArrowLabel(Keys key)
        {
            Label arrow = null;
            if (key.HasFlag(Keys.Left))
            {
                arrow = LeftArrowLbl;
            }
            else if (key.HasFlag(Keys.Up))
            {
                arrow = UpArrowLbl;
            }
            else if (key.HasFlag(Keys.Down))
            {
                arrow = DownArrowLbl;
            }
            else if (key.HasFlag(Keys.Right))
            {
                arrow = RightArrowLbl;
            }
            return arrow;
        }

        //---------------------------------------------------------------
        //Moves the position of the arrows depending on the difficulty
        //Easy - no change
        //Medium - arrows swap positions
        //Hard - arrows move around the entire screen
        //---------------------------------------------------------------
        private void shuffleArrowPositions()
        {
            List<Point> arrowLocations = new List<Point>();
            Label[] labels = new Label[]
            {
                LeftArrowLbl, UpArrowLbl, DownArrowLbl, RightArrowLbl
            };
            if (difficulty == Difficulties.Medium)
            {
                arrowLocations = labels.Select(l => l.Location).ToList();
                foreach (var lbl in labels)
                {
                    var point = arrowLocations[rnd.Next(arrowLocations.Count)];
                    arrowLocations.Remove(point);
                    lbl.Location = point;
                }
            }
            else if (difficulty == Difficulties.Hard)
            {
                foreach (var lbl in labels)
                {
                    var x = rnd.Next(MIN_X_ARROW, MAX_X_ARROW);
                    var y = rnd.Next(MIN_Y_ARROW, MAX_Y_ARROW);
                    // Try new random x,y if the arrow is
                    //  overlapping any existing arrows
                    while (arrowLocations.Any(p =>
                        Math.Abs(p.X - x) <= MIN_X_DIST
                        && Math.Abs(p.Y - y) <= MIN_Y_DIST))
                    {
                        x = rnd.Next(MIN_X_ARROW, MAX_X_ARROW);
                        y = rnd.Next(MIN_Y_ARROW, MAX_Y_ARROW);
                    }
                    var point = new Point(x, y);
                    arrowLocations.Add(point);
                    lbl.Location = point;
                }
            }
        }

        #endregion

        //---------------------------------------------------------------
        //Keyup event is fired whenever a key is pressed
        //Cancels token running the button flashes
        //Sets the clicked button in game manager then
        // calculates and displays the score
        //---------------------------------------------------------------
        private void ArrowKeyGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (game.isGameLive())
            {
                cts.Cancel();
                game.setClickedButton(e.KeyCode);
                game.runGame();
                game.calculateScore();
                var score = game.getScore();
                var totalScore = game.getTotalScore();
                var plusOrMin = score >= 0 ? "+" : "";
                ScoreLbl.Text = $"{plusOrMin}{score.ToString("D3")}";
                TotalScoreLbl.Text = totalScore.ToString("D8");
            }
        }
    }
}
