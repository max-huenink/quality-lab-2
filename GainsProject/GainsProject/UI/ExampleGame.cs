//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display an example game for the user to play
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
using System.Linq;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //GUI side of the Example game
    //---------------------------------------------------------------
    public partial class ExampleGame : UserControl
    {
        public const int TIME_BUFFER = 20;
        //Game manager object to to the business logic
        private ExampleGameManager game = new ExampleGameManager();
        //Game name and the score save manager to save scores
        private const string GAME_NAME = "ExampleGame.txt";
        ScoreSaveManager scoreSaveManager = ScoreSaveManager.getScoreSaveManager();
        private bool nextGame;
        //Bool to see if the game has been saved
        private bool gameSaved = false;
        public ExampleGame()
        {
            InitializeComponent();
            gameSaved = false;
        }

        //---------------------------------------------------------------
        //Constructor that initializes the next game button, which calls
        // the NextGame method of ISelectGame when clicked
        //---------------------------------------------------------------
        public ExampleGame(IGamePlaylist selectGame)
        {
            InitializeComponent();
            nextGameBtn.Click += (sender, e) => selectGame.NextGame();
            exitGameBtn.Click += (sender, e) => selectGame.Exit();
            nextGame = true;
        }

        //---------------------------------------------------------------
        //When the start button is clicked, The screen turns red, then
        //after a random ammount of time, the screen switched to green.
        //Once the screen turns green, the stopwatch starts.
        //---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            //Change background to red
            this.BackColor = System.Drawing.Color.Red;
            //Clean up leftover form elements
            richTextBox1.Hide();
            Startbutton.Hide();
            //Stay red for a random amount of time
            System.Threading.Thread.Sleep(game.randomTime());
            this.BackColor = System.Drawing.Color.Green;
            //Game is live!
            game.start();
            //Start the timer
            game.stopwatch.Start();
        }
        //---------------------------------------------------------------
        //If the screen is clicked durring the game, the stopwatch is 
        //stopped, and the time diffrence is calculated. The score is
        //then displayed to the user
        //---------------------------------------------------------------
        private void ExampleGame_Click(object sender, EventArgs e)
        {
            //If the game is live, then calculate the time
            if (game.isGameLive())
            {
                game.stopwatch.Stop();
                game.runGame();
                //If the user clicked too early
                if (game.getTime() < TIME_BUFFER)
                {
                    MessageBox.Show("Too early!\nScore:-100");
                    label1.Text = ("You clicked too early!");
                }
                //If the user did not click too early
                else
                {
                    //calculate the score
                    game.calculateScore();
                    MessageBox.Show("Nice it took: " + game.getTime() + " milliseconds\nScore: "
                        + game.getScore());
                    //Display the user's score
                    label1.Text = ("Score: " + game.getScore());
                    SaveButton.Show();
                    NameEnter.Show();
                }
                //Game over!
                game.endGame();
                if (nextGame)
                {
                    nextGameBtn.Show();
                    exitGameBtn.Show();
                }
            }
        }
        //When the save game button is clicked
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(!gameSaved)
            {
                string specialChar = " \\|!#$%&/()=?»«@£§€{}.-;'<>_,";
                string compareString = NameEnter.Text;
                bool hasSpecial = false;
                foreach (char character in specialChar)
                {
                    if (compareString.Contains(character))
                    {
                        hasSpecial = true;
                    }
                }
                if (hasSpecial)
                {
                    NameEnter.Text = "No Special chars";
                }
                else
                {
                    ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
                    scoreSave.addScore((int)game.getScore(), NameEnter.Text);
                    NameEnter.Hide();
                    SaveButton.Hide();
                }

            }
        }
    }
}
