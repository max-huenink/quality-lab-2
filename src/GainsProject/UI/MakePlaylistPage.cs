﻿//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: The UI to create a playlist of games
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //The UI to allow the user to create a playlist
    //---------------------------------------------------------------
    public partial class MakePlaylistPage : UserControl, IGamePlaylist
        , IGameEnd
    {
        private MakePlaylistPageManager playlistManager;
        private bool listOver;
        private int round;
        private readonly GameSelectManager manager;
        private readonly GameSelectManager pManager;
        private (string Name, Func<Control> GameControlCreator) selectedGame;
        private Func<Control> sg;
        //---------------------------------------------------------------
        //default constructor
        //---------------------------------------------------------------
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
        //parameterized constructor for when the list gets replayed
        //---------------------------------------------------------------
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
        //---------------------------------------------------------------
        //Creates buttons for each game in the games list
        //---------------------------------------------------------------
        private void CreateGameButtons()
        {
            List<Button> btnList = new List<Button>();
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
                        pManager.AddGameToList(game.Name
                            , game.GameControlCreator);
                    }
                    else
                    {
                        GameSelector.Controls.Add(gameBtn);
                        playlistManager.remove(game);
                        pManager.RemoveGameFromList(game.Name
                            , game.GameControlCreator);
                        if(!playlistManager.isEmpty() && selectedGame == game)
                        {
                            (string Name, Func<Control> GameControlCreator) 
                            temp = playlistManager.getFirstGame();
                            foreach(var g in pManager.GetListOfGames())
                            {
                                if(temp == g)
                                {
                                    selectedGame = g;
                                }
                            }
                        }
                    }
                };
                GameSelector.Controls.Add(gameBtn);
                if (playlistManager.contains(game.Name))
                    GamePlaylist.Controls.Add(gameBtn);
                btnList.Add(gameBtn);
            }
            // Center the GameSelector horizontally and vertically
            AlignGameSelector(GameSelector);

            AlignGamePlaylist(GamePlaylist);

            // Find max width and make every button have that width
            var maxWidth = btnList.Max(b => b.Width);
            foreach (var btn in btnList)
            {
                btn.Width = maxWidth;
            }
        }

        //---------------------------------------------------------------
        //Aligns the control on the screen horizontally and vertically
        //---------------------------------------------------------------
        private void AlignGameSelector(Control ctrl)
        {
            // Compute center x
            var pageWidth = Size.Width;
            var ctrlWidth = ctrl.Size.Width;
            var x = (pageWidth - ctrlWidth) / 8;

            // Compute center y
            var pageHeight = Size.Height;
            var ctrlHeight = ctrl.Size.Height;
            var y = (pageHeight - ctrlHeight) / 3 * 2;

            // Senter control
            ctrl.Location = new Point(x, y);
        }

        //---------------------------------------------------------------
        //Aligns the control on the screen horizontally and vertically
        //---------------------------------------------------------------
        private void AlignGamePlaylist(Control ctrl)
        {
            // Compute center x
            var pageWidth = Size.Width;
            var ctrlWidth = ctrl.Size.Width;
            var x = (pageWidth - ctrlWidth) / 16 * 13;

            // Compute center y
            var pageHeight = Size.Height;
            var ctrlHeight = ctrl.Size.Height;
            var y = (pageHeight - ctrlHeight) / 20 * 9;

            // Senter control
            ctrl.Location = new Point(x, y);
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
            PlayGame();
        }

        //---------------------------------------------------------------
        //Stops playing the selected game and goes back to game selection
        // using a new SingleGameSelect
        //---------------------------------------------------------------
        public void Exit()
        {
            showUserControl(new MakePlaylistPage());
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
                sg = () => new PlayAgainPage(playlistManager.getPlaylist()
                    , ++ round);
            else
            {
                pManager.PlayedGame(sg);
            }
            showUserControl(sg?.Invoke());
        }
        //---------------------------------------------------------------
        //Method for when the start button is clicked
        //---------------------------------------------------------------
        private void startButton_Click(object sender, EventArgs e)
        {
            playlistManager.validatePlaylist(pManager);
            PlayGame();
        }
    }
}
