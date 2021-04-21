using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GainsProject.UI
{
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
        public MakePlaylistPage(List<string> list, int count)
        {
            InitializeComponent();
            round = count;
            manager = GameSelectManager.CreateAndPopulateManager(this);
            playlistManager = new MakePlaylistPageManager();
            pManager = new GameSelectManager();
            listOver = false;
            pManager.RefreshGamesPlayed();
            foreach (var g in manager.GetListOfGames())
            {
                if(list.Contains(g.Name))
                {
                    pManager.AddGameToList(g.Name, g.GameControlCreator);
                    playlistManager.add(g);
                }

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
        private Func<Control> sg;
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
            //playlistManager.remove(selectedGame);
            //pManager.RemoveGameFromList(selectedGame.Name, selectedGame.GameControlCreator);
            //if(!playlistManager.isEmpty())
                //selectedGame = playlistManager.getFirstGame();
            //else
            //{
                //listOver = true;
           // }
            PlayGame();
        }

        //---------------------------------------------------------------
        //Stops playing the selected game and goes back to game selection
        // using a new SingleGameSelect
        //---------------------------------------------------------------
        public void Exit()
        {
            //sg = () => new MakePlaylistPage();
            showUserControl(new MakePlaylistPage());
            //PlayGame();
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

            sg = pManager.GetFirstUnplayedGame();
            if (sg == null)
                sg = () => new PlayAgainPage(playlistManager.getPlaylist(), ++ round);
            else
            {
                pManager.PlayedGame(sg);
                //selectedGame = playlistManager.getFirstGame();
            }
            showUserControl(sg?.Invoke());
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            playlistManager.validatePlaylist(pManager);
            PlayGame();
        }
    }
}
