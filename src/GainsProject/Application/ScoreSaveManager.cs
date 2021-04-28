//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: The class holds a list of all the ScoreSave objects,
// one for each game
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GainsProject.Domain;

namespace GainsProject.Application
{
    //--------------------------------------------------------------------
    // This is a class that uses that lazy singleton implementation
    // to make sure multiple score saves are not created for each game
    //--------------------------------------------------------------------
    public class ScoreSaveManager
    {
        //This object is static so everytime a class want it, it will be the same
        private static ScoreSaveManager scoreSaveManager;
        private List<ScoreSave> scoreSaveList;
        // game names
        private static readonly string[] gameNames = { "testGame1.txt", 
            "SpotTheScenery.txt", "PictureDrawing.txt",
            "DizzyButtons.txt", "ChaseTheButton.txt", "ExampleGame.txt",
            "MentalMathGame.txt", "ArrowKeyGame.txt", "SpotTheScenery.txt"};
        //private default constructor
        private ScoreSaveManager()
        {
            scoreSaveList = new List<ScoreSave>();
            foreach (string gameName in gameNames)
            {
                scoreSaveList.Add(new ScoreSave(gameName));
            }
        }
        //--------------------------------------------------------------------
        // This method gets the ScoreSave that matches with the name of the
        // game that is requesting it
        //--------------------------------------------------------------------
        public ScoreSave getScoreSave(string gameToGet)
        {
            int count = 0;
            foreach (string gameName in gameNames)
            {
                if(gameName == gameToGet)
                {
                    return scoreSaveList[count];
                }
                count++;
            }
            return null;
        }
        //--------------------------------------------------------------------
        // This method makes a ScoreSaveManager object if it is null so it can 
        // only be created once, then it returns the scoreSaveManager
        // regardless of whether it was just made or not.
        //--------------------------------------------------------------------
        public static ScoreSaveManager getScoreSaveManager()
        {
            if(scoreSaveManager == null)
            {
                scoreSaveManager = new ScoreSaveManager();
            }
            return scoreSaveManager;
        }
        //--------------------------------------------------------------------
        //This is a getter for game names.
        //--------------------------------------------------------------------
        public static string[] getGameNames()
        {
            return gameNames;
        }
    }
}
