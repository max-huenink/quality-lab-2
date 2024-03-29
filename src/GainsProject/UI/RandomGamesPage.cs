﻿//---------------------------------------------------------------
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
    //Displays a list of games to play, switching between games
    // after a game has been selected by implementing ISelectGame
    //---------------------------------------------------------------
    public partial class RandomGamesPage : UserControl, IGamePlaylist, IGameEnd
    {
        private readonly GameSelectManager manager;

        //---------------------------------------------------------------
        //Default constructor that initializes components,
        // GameSelectManager, and game select buttons
        //---------------------------------------------------------------
        public RandomGamesPage()
        {
            InitializeComponent();

            manager = GameSelectManager.createAndPopulateManager(this);
            nextGame();
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
            showUserControl(gep);
        }

        //---------------------------------------------------------------
        //Goes to a random unplayed game when the current game calls this
        // method, through ISelectGame
        //---------------------------------------------------------------
        public void nextGame()
        {
            var game = manager.getRandomUnplayedGame();
            // If all games have been played, recreate the game manager
            playGame(game);
        }

        //---------------------------------------------------------------
        //Stops going through the random playlist, goes to a blank screen
        //---------------------------------------------------------------
        public void exit()
        {
            Func<Control> gameModeSelectCreator = () => new GameModeSelect();
            playGame(gameModeSelectCreator);
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
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        private void playGame(Func<Control> gameControlCreator)
        {
            if (gameControlCreator == null)
            {
                // End of playlist prompt
                gameControlCreator = () => new PlayAgainPage();
            }
            else
            {
                // There is a game to play, mark it as played
                manager.playedGame(gameControlCreator);
            }

            showUserControl(gameControlCreator?.Invoke());
        }
    }
}
