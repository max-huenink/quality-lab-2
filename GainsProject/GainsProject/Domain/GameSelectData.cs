//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To contain data for game selection
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GainsProject.Domain
{
    //---------------------------------------------------------------
    //Contains data for game selection
    //---------------------------------------------------------------
    public class GameSelectData
    {
        private List<(string Name, Control GameControl)> gameList;
        private List<Control> gamesPlayedThisSession;

        //---------------------------------------------------------------
        //Default constructor, initializes members
        //---------------------------------------------------------------
        public GameSelectData()
        {
            gameList = new List<(string Name, Control GameControl)>();
            gamesPlayedThisSession = new List<Control>();
        }

        // Getter for game list
        public List<(string Name, Control GameControl)> GetListOfGames()
        {
            return gameList;
        }

        // Getter for played game list
        public List<Control> GetGamesPlayed()
        {
            return gamesPlayedThisSession;
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games
        // Params: string name - the name of the game
        //         Control gameControl - the control for the game
        //---------------------------------------------------------------
        public void AddGameToList(string name, Control gameControl)
        {
            gameList.Add((name, gameControl));
        }

        //---------------------------------------------------------------
        //Adds a game to the list of games played this session
        // Params: Control game - the control for the game
        //---------------------------------------------------------------
        public void PlayedGame(Control game)
        {
            gamesPlayedThisSession.Add(game);
        }
    }
}
