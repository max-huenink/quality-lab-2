﻿//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To show final score and prompt user to go to the next
//          game or exit.
//---------------------------------------------------------------
using GainsProject.Domain.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Shows the final score and prompt user to go to the next game
    // or exit.
    //---------------------------------------------------------------
    public partial class GameEndPage : UserControl
    {
        //---------------------------------------------------------------
        //Default constructor that initializes the page
        //---------------------------------------------------------------
        public GameEndPage(IGamePlaylist playlist)
        {
            InitializeComponent();
            centerLabelHorizontally(playAgainLbl);
            setupClickEvents(playlist);
        }


        //---------------------------------------------------------------
        //Initializes click events for next game and exit to go to the
        // proper screen
        //---------------------------------------------------------------
        private void setupClickEvents(IGamePlaylist playlist)
        {
            nextGameBtn.Click += (sender, e) => playlist.nextGame();
            exitBtn.Click += (sender, e) => playlist.exit();
        }

        //---------------------------------------------------------------
        //Sets the player name on screen
        //---------------------------------------------------------------
        public void setPlayerName(string name)
        {
            nameLbl.Text = string.Format(nameLbl.Text, name);
            centerLabelHorizontally(nameLbl);
        }

        //---------------------------------------------------------------
        //Sets the player score on screen
        //---------------------------------------------------------------
        public void setPlayerScore(long score)
        {
            scoreLbl.Text = string.Format(scoreLbl.Text, $"{score:n0}");
            centerLabelHorizontally(scoreLbl);
        }

        //---------------------------------------------------------------
        //Sets the game time on screen
        //---------------------------------------------------------------
        public void setGameTime(TimeSpan time)
        {
            gameTimeLbl.Text = string.Format(gameTimeLbl.Text,
                                             $@"{time:mm\:ss\.fff}");
            centerLabelHorizontally(gameTimeLbl);
        }

        //---------------------------------------------------------------
        //Changes the next game button text to reflect replaying a single
        // game
        //---------------------------------------------------------------
        public void setSingleGameMode()
        {
            nextGameBtn.Text = "Replay game";
        }

        //---------------------------------------------------------------
        //Centers the label on the screen
        //---------------------------------------------------------------
        private void centerLabelHorizontally(Label lbl)
        {
            int x = computeXCoordinateForCentering(lbl.Size.Width);
            var loc = lbl.Location;
            lbl.Location = new Point(x, loc.Y);
        }

        //---------------------------------------------------------------
        //Returns the new x coordinate of the label based on half the
        // difference of the page width and the label's width
        //---------------------------------------------------------------
        private int computeXCoordinateForCentering(int itemWidth)
        {
            var pageWidth = Size.Width;
            return (pageWidth - itemWidth) / 2;
        }
    }
}
