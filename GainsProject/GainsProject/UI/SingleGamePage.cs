//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a list of games to play, only plays the
//           selected game
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
    public partial class SingleGamePage : UserControl, IGamePlaylist
    {
        private readonly GameSelectManager manager;
        private Control selectedGame;

        //---------------------------------------------------------------
        //Default constructor that initializes components,
        // GameSelectManager, and game select buttons
        //---------------------------------------------------------------
        public SingleGamePage()
        {
            InitializeComponent();

            manager = GameSelectManager.CreateAndPopulateManager(this);
            CreateGameButtons();
        }

        //---------------------------------------------------------------
        //Creates buttons for each game in the games list
        //---------------------------------------------------------------
        private void CreateGameButtons()
        {
            foreach (var game in manager.GetListOfGames())
            {
                Button gameBtn = new Button
                {
                    Name = game.Name,
                    Text = game.Name,
                    Anchor = AnchorStyles.None,
                    AutoSize = true,
                };
                gameBtn.Click += (sender, e) => { selectedGame = game.GameControl; PlayGame(); };
                GameSelector.Controls.Add(gameBtn);
            }
        }

        //---------------------------------------------------------------
        //Plays the selected game again
        //---------------------------------------------------------------
        public void NextGame()
        {
            PlayGame();
        }

        //---------------------------------------------------------------
        //Stops playing the selected game and goes back to game selection
        // using a new SingleGameSelect
        //---------------------------------------------------------------
        public void Exit()
        {
            selectedGame = new SingleGamePage();
            PlayGame();
        }

        //---------------------------------------------------------------
        //Passes control from the game select page to the selected game
        // Params: Control control - the control to show
        //---------------------------------------------------------------
        private void showUserControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }

        //---------------------------------------------------------------
        //Plays the selected game
        //---------------------------------------------------------------
        private void PlayGame()
        {
            showUserControl(selectedGame);
        }
    }
}
