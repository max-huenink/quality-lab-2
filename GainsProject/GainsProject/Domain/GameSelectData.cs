//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To contain data for game selection
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GainsProject.Domain
{
    //---------------------------------------------------------------
    //Contains data for game selection
    //---------------------------------------------------------------
    public class GameSelectData
    {
        private List<(string Name, Func<Control> GameControlCreator)> gameList;
        private List<Func<Control>> gameCreatorsUsedThisSession;

        //---------------------------------------------------------------
        //Default constructor, initializes members
        //---------------------------------------------------------------
        public GameSelectData()
        {
            gameList = new List<(string Name, Func<Control> GameControlCreator)>();
            gameCreatorsUsedThisSession = new List<Func<Control>>();
        }

        // Getter for game list
        public List<(string Name, Func<Control> GameControlCreator)> GetListOfGames()
        {
            return gameList;
        }

        // Getter for played game list
        public List<Func<Control>> GetGamesPlayed()
        {
            return gameCreatorsUsedThisSession;
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Func<Control> gameControlCreator - A function that
        //          creates the game control
        //---------------------------------------------------------------
        public void AddGameToList(string name, Func<Control> gameControlCreator)
        {
            gameList.Add((name, gameControlCreator));
        }

        //---------------------------------------------------------------
        //Adds a game creator to the list of game creators used
        // in this session
        //         Func<Control> gameCreator - A function that creates
        //          the game control
        //---------------------------------------------------------------
        public void PlayedGame(Func<Control> gameCreator)
        {
            gameCreatorsUsedThisSession.Add(gameCreator);
        }
    }
}
