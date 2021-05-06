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
        //---------------------------------------------------------------
        //Parameterized contructor, takes a list of the games list to 
        //initialize the GameSelectManager to one that was already used.
        //        // Params: a list that contains
        //          string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public GameSelectManager(List<(string Name,
                                       Func<Control> GameControlCreator)
                                     > gamelist)
        {
            rnd = new Random();
            data = new GameSelectData();
            foreach (var g in gamelist)
            {
                data.AddGameToList(g.Name, g.GameControlCreator);
            }
        }

        // Getter for game list
        public List<(string Name, Func<Control> GameControlCreator)>
            GetListOfGames()
        {
            return data.GetListOfGames();
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void AddGameToList(string name
            , Func<Control> gameControlCreator)
        {
            data.AddGameToList(name, gameControlCreator);
        }

        //---------------------------------------------------------------
        //Removes a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void RemoveGameFromList(string name,
                                       Func<Control> gameControlCreator)
        {
            data.RemoveGameFromList(name, gameControlCreator);
        }
        //---------------------------------------------------------------
        // Resets the list for games that have been played
        //---------------------------------------------------------------
        public void RefreshGamesPlayed()
        {
            data.refreshPlayedGames();
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
            var unplayedGames = getUnplayedGameControls();
            if (unplayedGames.Length > 0)
            {
                var indx = rnd.Next(0, unplayedGames.Length);
                gameCreator = unplayedGames[indx];
            }
            return gameCreator;
        }

        //---------------------------------------------------------------
        // Gets the first index of the list that has not been played
        //Returns a Func<Control>
        //---------------------------------------------------------------
        public Func<Control> GetFirstUnplayedGame()
        {
            var unplayedGames = getUnplayedGameControls();
            Func<Control> gameCreator = null;
            if (unplayedGames.Length > 0)
            {
                gameCreator = unplayedGames[0];
            }
            return gameCreator;
        }

        //---------------------------------------------------------------
        //Gets the Func<Control> for all unplayed games
        //---------------------------------------------------------------
        private Func<Control>[] getUnplayedGameControls()
        {
            return data
                .GetListOfGames()
                .Select(g => g.GameControlCreator)
                .Where(c => !data.GetGamesPlayed().Contains(c))
                .ToArray();
        }

        //---------------------------------------------------------------
        //Creates and returns a new game select manager with games
        // already populated, with an IGamePlaylist
        //---------------------------------------------------------------
        public static GameSelectManager CreateAndPopulateManager(IGameEnd 
            gameEnd)
        {
            var manager = new GameSelectManager();
            manager.AddGameToList("Example Game",
                                  () => new ExampleGame(gameEnd));
            manager.AddGameToList("Arrow Key Game",
                                  () => new ArrowKeyGame(gameEnd));
            manager.AddGameToList("Mental Math Game",
                                  () => new MentalMathGame(gameEnd));
            manager.AddGameToList("Picture Drawing Game",
                                  () => new PictureDrawing(gameEnd));
            manager.AddGameToList("Chase the button",
                                  () => new ChaseTheButton(gameEnd));
            manager.AddGameToList("Dizzy Buttons",
                                  () => new DizzyButtonsGame(gameEnd));
            manager.AddGameToList("Spot The Scenery",
                                  () => new SpotTheSceneryGame(gameEnd));
            return manager;
        }
    }
}
