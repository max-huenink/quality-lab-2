//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a mental math game for the user to play
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
using System.Linq;
namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //GUI side of the mental math game
    //---------------------------------------------------------------
    public partial class MentalMathGame : UserControl
    {
        //Mental math game manager object
        private static MentalMathGameManager mmgame = new MentalMathGameManager();
        //question counter
        private int questionNumber = 0;
        //Game name and the score save manager to save scores
        private const string GAME_NAME = "MentalMathGame.txt";
        ScoreSaveManager scoreSaveManager = ScoreSaveManager.getScoreSaveManager();
        //Name object
        NameClass name = new NameClass();
        //Bool to see if the game has been saved
        private bool gameSaved = false;
        private int random1 = mmgame.randomTime();
        private int random2 = mmgame.randomTime();
        //correct answer
        private int ans = 0;
        private readonly IGameEnd gameEnd;
        //---------------------------------------------------------------
        //Constructor that initializes gameEnd which shows the game end
        // screen when the game finishes
        //---------------------------------------------------------------
        public MentalMathGame(IGameEnd gameEnd)
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
            ansBox.Show();
            SubmitButton.Show();
            ScoreBox.Show();
            //Move control to the textbox
            this.ActiveControl = ansBox;
        }
        //---------------------------------------------------------------
        //GUI logic when the start button is clicked
        //---------------------------------------------------------------
        private void StartButton_Click(object sender, EventArgs e)
        {
            //clear out prev score
            mmgame.setScore(0);
            SwitchToGameState();
            //start the game!
            mmgame.start();
            //Show the calculation
            label1.Text = (random1 + " + " + random2);
            ans = random1 + random2;
            //start the stopwatch
            mmgame.stopwatch.Start();
        }
        //---------------------------------------------------------------
        //When the submit button is clicked, calculate answer, and score
        //accordingly
        //---------------------------------------------------------------
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Make sure the game is live
            if(!(mmgame.isGameLive()))
            {
                return;
            }
            //If the game is live, stop time
            mmgame.stopwatch.Stop();
            //store the time and reset the stopwatch
            mmgame.runGame();
            //Is the answer correct?
            if (ans.ToString() == ansBox.Text)
            {
                mmgame.calculateScore();
            }
            else
            //Wrong answer!
            {
                mmgame.setTime(-1);
                mmgame.calculateScore();
            }
            //Question complete
            questionNumber++;
            //If not the final question
            if(questionNumber != 10)
            {
                //New numbers, and new text for the label
                random1 = mmgame.randomTime();
                random2 = mmgame.randomTime();
                label1.Text = (random1 + " + " + random2);
                ans = random1 + random2;
                //Clear the answer box
                ansBox.Clear();
                //start time
                mmgame.stopwatch.Start();
                ScoreBox.Text = "Score: " + mmgame.getScore();
                //Move control to the textbox
                this.ActiveControl = ansBox;
            }
            //All done!
            else
            {
                //Score save to save the score
                ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
                scoreSave.addScore((int)mmgame.getScore(), name.getName());
                //End the game
                mmgame.endGame();
                //Change labels
                ScoreLabel.Text = "All done! Score: " + mmgame.getScore();
                label1.Hide();
                ansBox.Hide();
                SubmitButton.Hide();
                ScoreBox.Hide();

                gameEnd?.GameFinished(name.getName(), mmgame.getScore(), mmgame.getGameRunTime());
            }
        }

    }
}
