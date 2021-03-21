//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To play available games in a random order
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Displayes a list of games to play, switching between games
    // after a game has been selected by implementing ISelectGame
    //---------------------------------------------------------------
    public partial class RandomGamesPage : UserControl, IGamePlaylist
    {
        private readonly GameSelectManager manager;

        //---------------------------------------------------------------
        //Default constructor that initializes components,
        // GameSelectManager, and game select buttons
        //---------------------------------------------------------------
        public RandomGamesPage()
        {
            InitializeComponent();

            manager = GameSelectManager.CreateAndPopulateManager(this);
            NextGame();
        }

        //---------------------------------------------------------------
        //Goes to a random unplayed game when the current game calls this
        // method, through ISelectGame
        //---------------------------------------------------------------
        public void NextGame()
        {
            var game = manager.GetRandomUnplayedGame();
            // If all games have been played, recreate the game manager
            PlayGame(game);
        }

        //---------------------------------------------------------------
        //Stops going through the random playlist, goes to a blank screen
        //---------------------------------------------------------------
        public void Exit()
        {
            PlayGame(null);
        }

        //---------------------------------------------------------------
        //Passes control from the game select page to the selected game
        // Params: Control control - the control to show
        //---------------------------------------------------------------
        private void showUserControl(Control control)
        {
            Content.Controls.Clear();

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();

                Content.Controls.Add(control);
            }
        }

        //---------------------------------------------------------------
        //Plays the specified game, adding to the game select manager's
        // played game list, and showing the list of games if there are
        // no games left.
        // Params: Control gameControl - the control to play
        //---------------------------------------------------------------
        private void PlayGame(Control gameControl)
        {
            if (gameControl != null)
            {
                manager.PlayedGame(gameControl);
            }
            showUserControl(gameControl);
        }
    }
}
