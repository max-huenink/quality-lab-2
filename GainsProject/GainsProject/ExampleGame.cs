//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run an example game for the user to play
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace GainsProject
{
    public partial class ExampleGame : UserControl
    {
        public const int RANDOM_TIME_MIN = 1000;
        public const int RANDOM_TIME_MAX = 5000;
        public const int BASE_SCORE_CALCULATION = 200;
        public const int MAX_SCORE = 1000;
        //Boolean to keep track of wether or not the game is live
        private bool canClick = false; 
        //Stopwatch varuble to measure reaction time
        private Stopwatch stopwatch = new Stopwatch();  
        //Long varuble used to calculate reaction time
        private long time = -1;
        public ExampleGame()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        //Calculates the score with a long var as an input
        //---------------------------------------------------------------
        public long Score(long time)
        {
            if (time < BASE_SCORE_CALCULATION)
                return MAX_SCORE;
            long score = BASE_SCORE_CALCULATION + MAX_SCORE - time; 
            return score;
        }
        //---------------------------------------------------------------
        //Gives a random number of milliseconds from 1000-5000
        //---------------------------------------------------------------
        public int randomTime()
        {
            Random rnd = new Random();
            int time = rnd.Next(RANDOM_TIME_MIN, RANDOM_TIME_MAX);
            return time;
        }
        //---------------------------------------------------------------
        //When the start button is clicked, The screen turns red, then
        //after a random ammount of time, the screen switched to green.
        //Once the screen turns green, the stopwatch starts.
        //---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
 
            this.BackColor = System.Drawing.Color.Red;
            //Clean up leftover form elements
            richTextBox1.Hide();
            Startbutton.Hide();
            //Stay red for a random amount of time
            System.Threading.Thread.Sleep(randomTime());
            this.BackColor = System.Drawing.Color.Green;
            //Game is live!
            canClick = true;
            //Start the timer
            stopwatch.Start();
        }
        //---------------------------------------------------------------
        //If the screen is clicked durring the game, the stopwatch is 
        //stopped, and the time diffrence is calculated. The score is
        //then displayed to the user
        //---------------------------------------------------------------
        private void ExampleGame_Click(object sender, EventArgs e)
        {
            //If the game is live, then calculate the time
            if (canClick)
            {
                stopwatch.Stop();
                time = stopwatch.ElapsedMilliseconds;
                //If the user clicked too early
                if (time == 0)
                {
                    MessageBox.Show("Too early!\nScore:-100");
                    label1.Text = ("You clicked too early!");
                }
                //If the user did not click too early
                else
                {
                    MessageBox.Show("Nice it took: " + time + " milliseconds\nScore: " + Score(time));
                    label1.Text = ("Score: " + Score(time));
                }
            }
            //Game over!
            canClick = false;
        }
    }
}
