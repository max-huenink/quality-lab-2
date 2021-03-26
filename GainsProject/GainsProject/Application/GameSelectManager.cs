//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To manage game selection
//---------------------------------------------------------------
using GainsProject.Domain;
using GainsProject.Domain.Interfaces;
using GainsProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Manages game selection
    //---------------------------------------------------------------
    public class GameSelectManager
    {
        private Random rnd;
        private GameSelectData data;

        //---------------------------------------------------------------
        //Default constructor, initializes members
        //---------------------------------------------------------------
        public GameSelectManager()
        {
            rnd = new Random();
            data = new GameSelectData();
        }

        // Getter for game list
        public List<(string Name, Control GameControl)> GetListOfGames()
        {
            return data.GetListOfGames();
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Control gameControl - the control for the game
        //---------------------------------------------------------------
        public void AddGameToList(string name, Control gameControl)
        {
            data.AddGameToList(name, gameControl);
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games played this session
        // Params: Control game - the control for the game
        //---------------------------------------------------------------
        public void PlayedGame(Control game)
        {
            data.PlayedGame(game);
        }

        //---------------------------------------------------------------
        //Gets a random game that hasn't been played yet
        // Returns a Control
        //---------------------------------------------------------------
        public Control GetRandomUnplayedGame()
        {
            Control game = null;
            var games = data.GetListOfGames().Where(g => !data.GetGamesPlayed().Contains(g.GameControl)).ToArray();
            if (games.Length > 0)
            {
                var indx = rnd.Next(0, games.Length);
                game = games[indx].GameControl;
            }
            return game;
        }

        //TODO: Find out how to not duplicate (or later, triplicate, this list creation)
        // factory?


        //---------------------------------------------------------------
        //Creates and returns a new game select manager with games
        // already populated
        //---------------------------------------------------------------
        public static GameSelectManager CreateAndPopulateManager()
        {
            var manager = new GameSelectManager();
            manager.AddGameToList("Example Game", new ExampleGame());
            manager.AddGameToList("Mental Math Game", new MentalMathGame());
            manager.AddGameToList("Picture Drawing", new PictureDrawing());
            return manager;
        }

        //---------------------------------------------------------------
        //Creates and returns a new game select manager with games
        // already populated, with an IGamePlaylist
        //---------------------------------------------------------------
        public static GameSelectManager CreateAndPopulateManager(IGamePlaylist playlist)
        {
            var manager = new GameSelectManager();
            manager.AddGameToList("Example Game", new ExampleGame(playlist));
            manager.AddGameToList("Mental Math Game", new MentalMathGame (playlist));
            manager.AddGameToList("Picture Drawing Game", new PictureDrawing(playlist));
            return manager;
        }
    }
}
