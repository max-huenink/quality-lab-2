using System;
using GainsProject.Domain;
namespace GainsProject.Application
{
    public class ChaseTheButtonGameManager : BaseGame
    {
        //Constants
        public const int MIN_RANDOM = 20;
        public const int MAX_RANDOM = 1000;
        public const int BASE_SCORE_CALCULATION = 200;
        public const int MAX_SCORE = 1000;
        public const int MAX_SCORE_TIME = 1000;
        public const int ZERO_SCORE_TIME = 10000;
        public const int SCORE_DIVISOR = -9;

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
            long time = this.getTime();
            if (time <= MAX_SCORE_TIME)
            {
                this.setScore(MAX_SCORE);
                return;
            }
            else if (time > ZERO_SCORE_TIME)
            {
                this.setScore(0);
                return;
            }
            this.setScore((time - ZERO_SCORE_TIME) / SCORE_DIVISOR);

        }
    }
}
