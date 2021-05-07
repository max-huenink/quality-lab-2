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
using System.Threading;
using System.Threading.Tasks;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //GUI side of the Example game
    //---------------------------------------------------------------
    public partial class ExampleGame : UserControl
    {
        //Time buffer constant
        public const int TIME_BUFFER = 20;
        //Game manager object to to the business logic
        private ExampleGameManager game = new ExampleGameManager();
        NameClass nameClass = new NameClass();
        //Game name and the score save manager to save scores
        private const string GAME_NAME = "ExampleGame.txt";
        ScoreSaveManager scoreSaveManager =
            ScoreSaveManager.getScoreSaveManager();
        //Bool to see if the game has been saved
        private CancellationTokenSource cts;

        private readonly IGameEnd gameEnd;

        //---------------------------------------------------------------
        //Constructor that initializes gameEnd which shows the game end
        // screen when the game finishes
        //---------------------------------------------------------------
        public ExampleGame(IGameEnd gameEnd)
        {
            InitializeComponent();
            this.gameEnd = gameEnd;
        }

        //---------------------------------------------------------------
        //When the start button is clicked, The screen turns red, then
        //after a random ammount of time, the screen switched to green.
        //Once the screen turns green, the stopwatch starts.
        //---------------------------------------------------------------
        private async void button1_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            //Change background to red
            this.BackColor = System.Drawing.Color.Red;
            //Clean up leftover form elements
            richTextBox1.Hide();
            Startbutton.Hide();
            //Game is live!
            game.start();
            //Stay red for a random amount of time
            await Task.Run(async () => await
                Task.Delay(game.randomTime()), cts.Token);
            this.BackColor = System.Drawing.Color.Green;
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
                cts.Cancel();
                game.stopwatch.Stop();
                game.runGame();
                //If the user clicked too early
                if (game.getTime() < TIME_BUFFER)
                {
                    label1.Text = ("You clicked too early!");
                }
                //If the user did not click too early
                else
                {
                    //calculate the score
                    game.calculateScore();
                    //Display the user's score
                    label1.Text = ("Score: " + game.getScore());
                }
                //Game over!
                //Store the score into a file
                ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
                scoreSave.addScore((int)game.getScore(), nameClass.getName());
                game.endGame();
                gameEnd?.gameFinished(nameClass.getName(), game.getScore(),
                    game.getGameRunTime());
            }
        }
    }
}
