//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: Hold info for scores grouped together
//---------------------------------------------------------------
using System;

namespace GainsProject.Domain
{
    //--------------------------------------------------------------------
    //this is a struct for holding save data for games
    //--------------------------------------------------------------------
    public struct SaveData
    {
        int score;
        DateTime dt;
        string playerTag;
        //default constructor
        public SaveData(int newScore, DateTime newDt, string newPlayerTag)
        {
            score = newScore;
            dt = newDt;
            playerTag = newPlayerTag;
        }
        //getter for score
        public int getScore()
        {
            return score;
        }
        //getting for dt
        public DateTime getDt()
        {
            return dt;
        }
        //getting for playerTag
        public string getPlayerTag()
        {
            return playerTag;
        }
    }
}
