//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To show final score and prompt user to go to the next
//          game or exit.
//---------------------------------------------------------------
using GainsProject.Domain.Interfaces;
using System;
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
            setupClickEvents(playlist);
        }

        //---------------------------------------------------------------
        //Initializes click events for next game and exit to go to the
        // proper screen
        //---------------------------------------------------------------
        private void setupClickEvents(IGamePlaylist playlist)
        {
            nextGameBtn.Click += (sender, e) => playlist.NextGame();
            exitBtn.Click += (sender, e) => playlist.Exit();
        }

        //---------------------------------------------------------------
        //Sets the player name on screen
        //---------------------------------------------------------------
        public GameEndPage setPlayerName(string name)
        {
            nameLbl.Text = string.Format(nameLbl.Text, name);
            return this;
        }

        //---------------------------------------------------------------
        //Sets the player score on screen
        //---------------------------------------------------------------
        public GameEndPage setPlayerScore(int score)
        {
            scoreLbl.Text = string.Format(scoreLbl.Text, $"{score:n0}");
            return this;
        }

        //---------------------------------------------------------------
        //Changes the next game button text to reflect replaying a single
        // game
        //---------------------------------------------------------------
        public GameEndPage setSingleGameMode()
        {
            nextGameBtn.Text = "Replay game";
            return this;
        }
    }
}
