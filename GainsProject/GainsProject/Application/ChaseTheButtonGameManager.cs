using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsProject.Domain
{
    class ChaseTheButtonGameManager : BaseGame
    {
        //Constants
        public const int MIN_RANDOM = 20;
        public const int MAX_RANDOM = 1000;
        public const int BASE_SCORE_CALCULATION = 200;
        public const int MAX_SCORE = 1000;

        //---------------------------------------------------------------
        //Sets the time then resets the stopwatch
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
        //---------------------------------------------------------------
        //Gives a random number of cordinates from 
        //---------------------------------------------------------------
        public override int randomTime()
        {
            Random rnd = new Random();
            int time = rnd.Next(MIN_RANDOM, MAX_RANDOM);
            return time;
        }
        //---------------------------------------------------------------
        //Calculates the score based on the time
        //---------------------------------------------------------------
        public override void calculateScore()
        {

        }
    }
}
