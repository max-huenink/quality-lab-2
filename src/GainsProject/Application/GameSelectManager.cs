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
        public List<(string Name, Func<Control> GameControlCreator)>
            getListOfGames()
        {
            return data.getListOfGames();
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void addGameToList(string name
            , Func<Control> gameControlCreator)
        {
            data.addGameToList(name, gameControlCreator);
        }

        //---------------------------------------------------------------
        //Removes a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void removeGameFromList(string name,
                                       Func<Control> gameControlCreator)
        {
            data.removeGameFromList(name, gameControlCreator);
        }
        //---------------------------------------------------------------
        // Resets the list for games that have been played
        //---------------------------------------------------------------
        public void refreshGamesPlayed()
        {
            data.refreshPlayedGames();
        }

        //---------------------------------------------------------------
        //Adds a game creator to the list of game creators used
        // in this session
        // Params: Func<Control> gameCreator - A function that creates
        //          the game control
        //---------------------------------------------------------------
        public void playedGame(Func<Control> gameCreator)
        {
            data.playedGame(gameCreator);
        }

        //---------------------------------------------------------------
        //Gets a random game that hasn't been played yet
        // Returns a Func<Control>
        //---------------------------------------------------------------
        public Func<Control> getRandomUnplayedGame()
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
        public Func<Control> getFirstUnplayedGame()
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
                .getListOfGames()
                .Select(g => g.GameControlCreator)
                .Where(c => !data.getGamesPlayed().Contains(c))
                .ToArray();
        }

        //---------------------------------------------------------------
        //Creates and returns a new game select manager with games
        // already populated, with an IGamePlaylist
        //---------------------------------------------------------------
        public static GameSelectManager createAndPopulateManager(IGameEnd
            gameEnd)
        {
            var manager = new GameSelectManager();
            manager.addGameToList("Example Game",
                                  () => new ExampleGame(gameEnd));
            manager.addGameToList("Arrow Key Game",
                                  () => new ArrowKeyGame(gameEnd));
            manager.addGameToList("Mental Math Game",
                                  () => new MentalMathGame(gameEnd));
            manager.addGameToList("Picture Drawing Game",
                                  () => new PictureDrawing(gameEnd));
            manager.addGameToList("Chase the button",
                                  () => new ChaseTheButton(gameEnd));
            manager.addGameToList("Dizzy Buttons",
                                  () => new DizzyButtonsGame(gameEnd));
            manager.addGameToList("Spot The Scenery",
                                  () => new SpotTheSceneryGame(gameEnd));
            return manager;
        }
    }
}
