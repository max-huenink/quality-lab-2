using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsProject
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
            this.score = newScore;
            this.dt = newDt;
            this.playerTag = newPlayerTag;
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
