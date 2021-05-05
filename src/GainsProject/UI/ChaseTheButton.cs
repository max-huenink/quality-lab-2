//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a chase the button game 
//          for the user to play
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
using System.Linq;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //GUI side of the chase the button game
    //---------------------------------------------------------------
    public partial class ChaseTheButton : UserControl
    {
        //Constants
        private const int Y_CORD_DIVISOR = 3;
        private const int Y_CORD_MULTIPLIER = 2;
        private const int NUMBER_OF_BUTTONS = 5;
        private const int MAX_BACKGROUND_CLICKS = 100;
        private int buttonNumber = 0;
        private int backgroundClicks = 0;
        //Chase the button game manager object -> Application layer connection
        private ChaseTheButtonGameManager game =
            new ChaseTheButtonGameManager();
        //Game name and the score save manager to save scores
        private const string GAME_NAME = "ChaseTheButton.txt";
        ScoreSaveManager scoreSaveManager =
            ScoreSaveManager.getScoreSaveManager();
        NameClass name = new NameClass(); 
        //Bool to see if the game has been saved
        private bool gameSaved = false;
        private readonly IGameEnd gameEnd;

        //---------------------------------------------------------------
        //Constructor that initializes gameEnd which shows the game end
        // screen when the game finishes
        //---------------------------------------------------------------
        public ChaseTheButton(IGameEnd gameEnd)
        {
            InitializeComponent();
            this.gameEnd = gameEnd;
        }

        //---------------------------------------------------------------
        //GUI element logic when the start button is clicked
        //---------------------------------------------------------------
        public void SwitchToGameState()
        {
            //Hide and show GUI elements
            StartButton.Hide();
            richTextBox1.Hide();
        }

        //---------------------------------------------------------------
        //GUI logic when the start button is clicked. Also shows and
        //places the ChseButton in a random spot
        //---------------------------------------------------------------
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Hide GUI elements
            SwitchToGameState();
            //start the game!
            game.start();
            //Show the button in a new position.
            moveButton();
            //start the stopwatch
            game.stopwatch.Start();
        }
        //---------------------------------------------------------------
        //Hides the ChaseButton, sets its cords to random cords, then
        //shows the button
        //---------------------------------------------------------------
        private void moveButton()
        {
            //Hide the button
            ChaseButton.Hide();
            //Calculate random cords
            int xCord = game.randomTime();
            int yCord = game.randomY();
            //Move and show the button
            ChaseButton.Location = new System.Drawing.Point(xCord, yCord);
            ChaseButton.Show();
        }
        //---------------------------------------------------------------
        //If the background is clicked while the game is live, add
        //a penalty.
        //---------------------------------------------------------------
        private void Content_Click(object sender, EventArgs e)
        {
            if(game.isGameLive() && backgroundClicks <= MAX_BACKGROUND_CLICKS)
            {
                backgroundClicks++;
            }
        }
        //---------------------------------------------------------------
        //When the chase button is clicked, add a button click, and
        //see if the 5th button has been clicked. If it has, then
        //wrap up the game.
        //---------------------------------------------------------------
        private void ChaseButton_Click(object sender, EventArgs e)
        {
            buttonNumber++;
            //Is this the 5th button?
            if (buttonNumber != NUMBER_OF_BUTTONS)
            {
                moveButton();
                return;
            }
            //Stop time, add penalties, calculate score then display the score
            game.stopwatch.Stop();
            game.setTime(game.stopwatch.ElapsedMilliseconds + backgroundClicks * 
                MAX_BACKGROUND_CLICKS);
            game.calculateScore();
            //Store the score and collect the user's name

            ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
            scoreSave.addScore((int)game.getScore(), name.getName());
            //End the game.
            game.endGame();

            gameEnd?.GameFinished(name.getName(), game.getScore(),
                game.getGameRunTime());

            ChaseButton.Hide();
            ScoreShow.Text = ("Score: " + game.getScore());
            ScoreShow.Show();
        }
    }
}
