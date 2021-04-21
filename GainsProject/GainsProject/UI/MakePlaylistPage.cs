//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: The UI to create a playlist of games
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //The UI to allow the user to create a playlist
    //---------------------------------------------------------------
    public partial class MakePlaylistPage : UserControl, IGamePlaylist, IGameEnd
    {
        MakePlaylistPageManager playlistManager;
        bool listOver;
        int round;
        public MakePlaylistPage()
        {
            InitializeComponent();

            manager = GameSelectManager.CreateAndPopulateManager(this);
            playlistManager = new MakePlaylistPageManager();
            pManager = new GameSelectManager();
            listOver = false;
            CreateGameButtons();
            round = 1;
            Content.BackColor = System.Drawing.Color.Salmon;
        }
        //---------------------------------------------------------------
        //Creates the playlist page
        //---------------------------------------------------------------
        public MakePlaylistPage(System.Collections.Generic.List<(string Name, Func<Control> GameControlCreator)> list, int count)
        {
            InitializeComponent();
            round = count;
            manager = GameSelectManager.CreateAndPopulateManager(this);
            playlistManager = new MakePlaylistPageManager();
            pManager = new GameSelectManager();
            listOver = false;
            foreach (var g in list)
            {
                pManager.AddGameToList(g.Name, g.GameControlCreator);
                playlistManager.add(g);

            }
            if (!playlistManager.isEmpty())
                selectedGame = playlistManager.getFirstGame();
            CreateGameButtons();
            label2.Text = "Current\nPlaylist: ";
            startButton.Text = "Start Round: " + round;
            Content.BackColor = System.Drawing.Color.Salmon;
        }

        private readonly GameSelectManager manager;
        private readonly GameSelectManager pManager;
        private (string Name, Func<Control> GameControlCreator) selectedGame;
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
                    BackColor = System.Drawing.SystemColors.Control,
                };
                gameBtn.Click += (sender, e) =>
                {
                    if(GameSelector.Contains(gameBtn))
                    {
                        GamePlaylist.Controls.Add(gameBtn);
                        if(playlistManager.isEmpty())
                            selectedGame = game;
                        playlistManager.add(game);
                        pManager.AddGameToList(game.Name, game.GameControlCreator);
                    }
                    else
                    {
                        GameSelector.Controls.Add(gameBtn);
                        playlistManager.remove(game);
                        pManager.RemoveGameFromList(game.Name, game.GameControlCreator);
                        if(!playlistManager.isEmpty() && selectedGame == game)
                        {
                            (string Name, Func<Control> GameControlCreator) temp = playlistManager.getFirstGame();
                            foreach(var g in pManager.GetListOfGames())
                            {
                                if(temp == g)
                                {
                                    selectedGame = g;
                                }
                            }
                        }
                    }
                    //PlayGame();
                };
                    GameSelector.Controls.Add(gameBtn);
                if (playlistManager.contains(game.Name))
                    GamePlaylist.Controls.Add(gameBtn);
                //GameSelector.Controls.Add(gameBtn);
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
            showUserControl(gep);
        }

        //---------------------------------------------------------------
        //Plays the selected game again
        //---------------------------------------------------------------
        public void NextGame()
        {
            playlistManager.remove(selectedGame);
            pManager.RemoveGameFromList(selectedGame.Name, selectedGame.GameControlCreator);
            if(!playlistManager.isEmpty())
                selectedGame = playlistManager.getFirstGame();
            else
            {
                listOver = true;
            }
            PlayGame();
        }

        //---------------------------------------------------------------
        //Stops playing the selected game and goes back to game selection
        // using a new SingleGameSelect
        //---------------------------------------------------------------
        public void Exit()
        {
            selectedGame.GameControlCreator = () => new MakePlaylistPage();
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
            //pManager.PlayedGame(selectedGame.GameControlCreator);
            if (listOver)
                selectedGame.GameControlCreator = () => new PlayAgainPage(playlistManager.getPlaylist(), ++ round);
            else
            {
                selectedGame = playlistManager.getFirstGame();
            }
            showUserControl(selectedGame.GameControlCreator?.Invoke());
        }
        //---------------------------------------------------------------
        //Method for when the start button is clicked
        //---------------------------------------------------------------
        private void startButton_Click(object sender, EventArgs e)
        {
            playlistManager.validatePlaylist();
            PlayGame();
        }
    }
}
