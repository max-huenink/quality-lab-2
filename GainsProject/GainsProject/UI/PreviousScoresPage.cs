//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: UI page for displaying scores
//---------------------------------------------------------------
using GainsProject.Application;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //--------------------------------------------------------------------
    //this is a windows form class that will display previous scores
    //--------------------------------------------------------------------
    public partial class PreviousScoresPage : UserControl
    {
        ScoreDisplay scoreDisplay;
        ScoreSave scoreSave;
        public PreviousScoresPage()
        {
            InitializeComponent();
            //score save object will not be created here and is
            //only here for testing/demoing
            scoreSave = new ScoreSave("GameScore.txt");
            //score display contains all of the logic for displaying
            scoreDisplay = new ScoreDisplay(scoreSave);
            //Load all of the score relevant data onto the screen
            this.totalGamesHere.Text = scoreDisplay.getNumGames().ToString();
            this.avgScoreHere.Text = scoreDisplay.getAvgGamePoints().ToString();
            updateScorePage();
        }
        //---------------------------------------------------------------
        //get the strings to put in the labels for displaying scores
        //---------------------------------------------------------------
        private void updateScorePage()
        {
            this.timeStampHere.Text = scoreDisplay.getTime();
            this.tagHere.Text = scoreDisplay.getTag();
            this.scoreHere.Text = scoreDisplay.getScore();
        }
        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void TimeStamp_Click(object sender, EventArgs e)
        {
            scoreDisplay.setTimeSorted();
            updateScorePage();
        }
        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void Tag_Click(object sender, EventArgs e)
        {
            scoreDisplay.setTagSorted();
            updateScorePage();
        }
        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void Score_Click(object sender, EventArgs e)
        {
            scoreDisplay.setScoreSorted();
            updateScorePage();
        }
    }
}
