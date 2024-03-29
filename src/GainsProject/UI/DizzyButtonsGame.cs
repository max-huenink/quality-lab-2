﻿//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: This is the ui class for the dizzy buttons game
// that has buttons bounce around at varied speeds. One of the
// buttons is green and once click points will be awarded and 
// the another random button will turn green.
//---------------------------------------------------------------
using System;
using System.Linq;
using System.Windows.Forms;
using GainsProject.Application;
using GainsProject.Domain.Interfaces;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    // this class is the ui class for the dizzy buttons game
    //---------------------------------------------------------------
    public partial class DizzyButtonsGame : UserControl
    {
        private DizzyButtonsGameManager dbGameManager;
        private const string GAME_NAME = "DizzyButtons.txt";
        ScoreSaveManager scoreSaveManager = ScoreSaveManager.getScoreSaveManager();
        NameClass name = new NameClass();
        private readonly IGameEnd gameEnd;

        //---------------------------------------------------------------
        // parameterized constructor for if the game is made with
        // a playlist
        //---------------------------------------------------------------
        public DizzyButtonsGame(IGameEnd gameEnd)
        {
            InitializeComponent();
            dbGameManager = new DizzyButtonsGameManager();
            this.gameEnd = gameEnd;
        }

        //---------------------------------------------------------------
        // makes the labels and start button at the begining invisible
        // and starts the timer
        //---------------------------------------------------------------
        private void startButton_Click(object sender, EventArgs e)
        {
            dbGameManager.start();
            this.timer1.Enabled = true;
            startButton.Visible = false;
            startButton.Enabled = false;
            instructionsLabel.Visible = false;
        }

        //---------------------------------------------------------------
        // calls the tick method in the manager class, checks if the
        // game is done, and sets up the end of the game
        //---------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dbGameManager.getIsFinished())
            {
                dbGameManager.endGame();
                timer1.Enabled = false;
                gameOverLabel.Visible = true;
                finalScoreLabel.Text = dbGameManager.getScore().ToString();
                finalScoreLabel.Visible = true;
                ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
                scoreSave.addScore((int)dbGameManager.getScore(), name.getName());

                gameEnd?.gameFinished(name.getName(), dbGameManager.getScore(), dbGameManager.getGameRunTime());
            }
            for (int i = 0; i < dbGameManager.getToAdd().Count; i++)
            {
                Controls.Add(dbGameManager.getToAdd().Pop());
            }
            for (int i = 0; i < dbGameManager.getToDelete().Count; i++)
            {
                Button temp = dbGameManager.getToDelete().Pop();
                Controls.Remove(temp);
                temp.Dispose();
            }
            dbGameManager.tick();
            scoreHere.Text = dbGameManager.getScore().ToString();
        }

        //---------------------------------------------------------------
        // if the player misses and clicks on the background they loose
        // points
        //---------------------------------------------------------------
        private void DizzyButtonsGame_MouseClick(object sender, MouseEventArgs e)
        {
            dbGameManager.minusScore();
        }
    }
}
