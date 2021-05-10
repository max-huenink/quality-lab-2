//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: UI page for displaying scores
//---------------------------------------------------------------
using GainsProject.Application;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GainsProject.UI
{
    //--------------------------------------------------------------------
    //this is a windows form class that will display previous scores
    //--------------------------------------------------------------------
    public partial class PreviousScoresPage : UserControl
    {
        List<ScoreDisplay> scoreDisplayList;
        ScoreDisplay currScoreDisplay;
        private const int NUM_TEST_GAMES = 1;

        public PreviousScoresPage()
        {
            InitializeComponent();
            scoreDisplayList = new List<ScoreDisplay>();
            //Load all of the score relevant data onto the screen
            scorePageStart();
        }

        //---------------------------------------------------------------
        //updates the strings displaying scores and accompaning values
        //---------------------------------------------------------------
        private void updateScorePage()
        {
            this.timeStampHere.Text = currScoreDisplay.getTime();
            this.tagHere.Text = currScoreDisplay.getTag();
            this.scoreHere.Text = currScoreDisplay.getScore();
            this.totalGamesHere.Text = currScoreDisplay.getNumGames().ToString();
            this.avgScoreHere.Text = currScoreDisplay.getAvgGamePoints().ToString();
        }

        //---------------------------------------------------------------
        //fill the combobox, fill the list of scoreDisplays
        //---------------------------------------------------------------
        private void scorePageStart()
        {
            string[] gameList = ScoreSaveManager.getGameNames();
            ScoreSaveManager scoreSaveManager = ScoreSaveManager.getScoreSaveManager();
            for (int i = NUM_TEST_GAMES; i < gameList.Length; i++)
            {
                string rawName = gameList[i];
                rawName = rawName.Substring(0, rawName.Length - 4);
                rawName = string.Concat(rawName.Select(x => Char.IsUpper(x) ? " "
                + x : x.ToString())).TrimStart(' ');
                if (i == NUM_TEST_GAMES)
                {
                    this.selectGame.Text = rawName;
                }
                this.selectGame.Items.Add(rawName);
                ScoreDisplay temp = new ScoreDisplay(scoreSaveManager
                    .getScoreSave(gameList[i]));
                scoreDisplayList.Add(temp);
            }
            currScoreDisplay = scoreDisplayList[0];
            updateScorePage();
        }

        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void TimeStamp_Click(object sender, EventArgs e)
        {
            currScoreDisplay.setTimeSorted();
            updateScorePage();
        }

        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void Tag_Click(object sender, EventArgs e)
        {
            currScoreDisplay.setTagSorted();
            updateScorePage();
        }

        //---------------------------------------------------------------
        //let the scoreDisplay know what label was clicked
        //---------------------------------------------------------------
        private void Score_Click(object sender, EventArgs e)
        {
            currScoreDisplay.setScoreSorted();
            updateScorePage();
        }

        //---------------------------------------------------------------
        //An event for game select
        //---------------------------------------------------------------
        private void selectGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            currScoreDisplay = scoreDisplayList[this.selectGame.SelectedIndex];
            updateScorePage();
        }
    }
}
