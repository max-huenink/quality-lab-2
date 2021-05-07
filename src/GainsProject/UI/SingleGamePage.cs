//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a list of games to play, only plays the
//           selected game
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Displays a list of games to play, switching between games
    // after a game has been selected by implementing ISelectGame
    //---------------------------------------------------------------
    public partial class SingleGamePage : UserControl, IGamePlaylist, IGameEnd
    {
        private readonly GameSelectManager manager;
        private Func<Control> selectedGame;

        //---------------------------------------------------------------
        //Default constructor that initializes components,
        // GameSelectManager, and game select buttons
        //---------------------------------------------------------------
        public SingleGamePage()
        {
            InitializeComponent();

            manager = GameSelectManager.createAndPopulateManager(this);
            createGameButtons();
        }

        //---------------------------------------------------------------
        //Creates buttons for each game in the games list
        //---------------------------------------------------------------
        private void createGameButtons()
        {
            List<Button> btnList = new List<Button>();
            foreach (var game in manager.getListOfGames())
            {
                Button gameBtn = new Button
                {
                    Name = game.Name,
                    Text = game.Name,
                    Anchor = AnchorStyles.None,
                    Font = new Font("SansSerif", 20),
                    //BackColor = Color.Tomato,
                    AutoSize = true,
                };
                gameBtn.Click += (sender, e) =>
                {
                    selectedGame = game.GameControlCreator;
                    playGame();
                };
                // Add button to list of buttons
                btnList.Add(gameBtn);
                // Add button to GameSelector
                GameSelector.Controls.Add(gameBtn);
            }

            // Center the GameSelector horizontally and vertically
            centerControl(GameSelector);

            // Find max width and make every button have that width
            var maxWidth = btnList.Max(b => b.Width);
            foreach (var btn in btnList)
            {
                btn.Width = maxWidth;
            }
        }

        //---------------------------------------------------------------
        //Centers the control on the screen horizontally and vertically
        //---------------------------------------------------------------
        private void centerControl(Control ctrl)
        {
            // Compute center x
            var pageWidth = Size.Width;
            var ctrlWidth = ctrl.Size.Width;
            var x = (pageWidth - ctrlWidth) / 2;

            // Compute center y
            var pageHeight = Size.Height;
            var ctrlHeight = ctrl.Size.Height;
            var y = (pageHeight - ctrlHeight) / 2;

            // Senter control
            ctrl.Location = new Point(x, y);
        }

        //---------------------------------------------------------------
        //Displays the game end screen with the player's name and score
        //---------------------------------------------------------------
        public void gameFinished(string name, long score, TimeSpan timeSpan)
        {
            var gep = new GameEndPage(this);
            gep.setPlayerName(name);
            gep.setPlayerScore(score);
            gep.setGameTime(timeSpan);
            gep.setSingleGameMode();
            showUserControl(gep);
        }

        //---------------------------------------------------------------
        //Plays the selected game again
        //---------------------------------------------------------------
        public void nextGame()
        {
            playGame();
        }

        //---------------------------------------------------------------
        //Stops playing the selected game and goes back to game selection
        // using a new SingleGameSelect
        //---------------------------------------------------------------
        public void exit()
        {
            selectedGame = () => new SingleGamePage();
            playGame();
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
        private void playGame()
        {
            showUserControl(selectedGame?.Invoke());
        }
    }
}
