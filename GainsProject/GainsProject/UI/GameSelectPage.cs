//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a list of games to play, switches between
//           games after a game has been selected
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Displayes a list of games to play, switching between games
    // after a game has been selected by implementing ISelectGame
    //---------------------------------------------------------------
    public partial class GameSelectPage : UserControl, ISelectGame
    {
        private readonly GameSelectManager manager;

        //---------------------------------------------------------------
        //Default constructor that initializes components,
        // GameSelectManager, and game select buttons
        //---------------------------------------------------------------
        public GameSelectPage()
        {
            InitializeComponent();

            manager = new GameSelectManager();
            PopulateGameList();
            CreateGameButtons();
        }

        //---------------------------------------------------------------
        //Populates the list of games in the game select manager
        //---------------------------------------------------------------
        private void PopulateGameList()
        {
            manager.AddGameToList("Example Game", new ExampleGame(this));
            manager.AddGameToList("Mental Math Game", new MentalMathGame(this));
            manager.AddGameToList("Example Game 3", new ExampleGame(this));
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
                gameBtn.Click += (sender, e) => PlayGame(game.GameControl);
                GameSelector.Controls.Add(gameBtn);
            }
        }

        //---------------------------------------------------------------
        //Goes to a random unplayed game when the current game calls this
        // method, through ISelectGame
        //---------------------------------------------------------------
        public void NextGame()
        {
            var game = manager.GetRandomUnplayedGame();
            PlayGame(game);
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
                showUserControl(gameControl);
            }
            else
            {
                showUserControl(new GameSelectPage());
            }
        }
    }
}
