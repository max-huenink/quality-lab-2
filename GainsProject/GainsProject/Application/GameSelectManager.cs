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
        public List<(string Name, Func<Control> GameControlCreator)> GetListOfGames()
        {
            return data.GetListOfGames();
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void AddGameToList(string name, Func<Control> gameControlCreator)
        {
            data.AddGameToList(name, gameControlCreator);
        }

        //---------------------------------------------------------------
        //Removes a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void RemoveGameFromList(string name, Func<Control> gameControlCreator)
        {
            data.RemoveGameFromList(name, gameControlCreator);
        }

        //---------------------------------------------------------------
        //Adds a game creator to the list of game creators used
        // in this session
        // Params: Func<Control> gameCreator - A function that creates
        //          the game control
        //---------------------------------------------------------------
        public void PlayedGame(Func<Control> gameCreator)
        {
            data.PlayedGame(gameCreator);
        }

        //---------------------------------------------------------------
        //Gets a random game that hasn't been played yet
        // Returns a Func<Control>
        //---------------------------------------------------------------
        public Func<Control> GetRandomUnplayedGame()
        {
            Func<Control> gameCreator = null;
            var games = data.GetListOfGames()
                .Where(g =>
                    !data.GetGamesPlayed()
                    .Contains(g.GameControlCreator))
                .ToArray();
            if (games.Length > 0)
            {
                var indx = rnd.Next(0, games.Length);
                gameCreator = games[indx].GameControlCreator;
            }
            return gameCreator;
        }

        //---------------------------------------------------------------
        //Creates and returns a new game select manager with games
        // already populated, with an IGamePlaylist
        //---------------------------------------------------------------
        public static GameSelectManager CreateAndPopulateManager(IGameEnd gameEnd)
        {
            var manager = new GameSelectManager();
            manager.AddGameToList("Example Game", () => new ExampleGame(gameEnd));
            manager.AddGameToList("Arrow Key Game", () => new ArrowKeyGame(gameEnd));
            manager.AddGameToList("Mental Math Game", () => new MentalMathGame (gameEnd));
            manager.AddGameToList("Picture Drawing Game", () => new PictureDrawing(gameEnd));
            manager.AddGameToList("Chase the button", () => new ChaseTheButton(gameEnd));
            manager.AddGameToList("Dizzy Buttons", () => new DizzyButtonsGame(gameEnd));
            return manager;
        }
    }
}
