using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    public partial class MakePlaylistPage : UserControl, IGamePlaylist, IGameEnd
    {
        MakePlaylistPageManager playlistManager;
        public MakePlaylistPage()
        {
            InitializeComponent();

            manager = GameSelectManager.CreateAndPopulateManager(this);
            CreateGameButtons();
            playlistManager = new MakePlaylistPageManager();
            pManager = new GameSelectManager();
        }

        private readonly GameSelectManager manager;
        private readonly GameSelectManager pManager;
        private Func<Control> selectedGame;
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
                gameBtn.Click += (sender, e) =>
                {
                    if(GameSelector.Contains(gameBtn))
                    {
                        GamePlaylist.Controls.Add(gameBtn);
                        if(playlistManager.isEmpty())
                            selectedGame = game.GameControlCreator;
                        playlistManager.add(game);
                        pManager.AddGameToList(game.Name, game.GameControlCreator);
                    }
                    else
                    {
                        GameSelector.Controls.Add(gameBtn);
                        playlistManager.remove(game);
                        pManager.RemoveGameFromList(game.Name, game.GameControlCreator);
                        if(playlistManager.isEmpty() && selectedGame == game.GameControlCreator)
                        {
                            (string Name, Func<Control> GameControlCreator) temp = playlistManager.getFirstGame();
                            foreach(var g in pManager.GetListOfGames())
                            {
                                if(temp == g)
                                {
                                    selectedGame = g.GameControlCreator;
                                }
                            }
                        }
                    }
                    //PlayGame();
                };
                GameSelector.Controls.Add(gameBtn);
            }
        }

        //---------------------------------------------------------------
        //Displays the game end screen with the player's name and score
        //---------------------------------------------------------------
        public void GameFinished(string name, long score, TimeSpan timeSpan)
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
            selectedGame = () => new MakePlaylistPage();
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
            showUserControl(selectedGame?.Invoke());
            playlistManager.remove(selectedGame);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            PlayGame();
        }
    }
}
