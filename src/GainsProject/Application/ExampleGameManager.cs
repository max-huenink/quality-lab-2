//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the example game and manage the data
//---------------------------------------------------------------
using System;
using GainsProject.Domain;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Runs the Example game and manages the data
    //---------------------------------------------------------------
    public class ExampleGameManager : BaseGame
    {
        //Constants
        private const int RANDOM_TIME_MIN = 1000;
        private const int RANDOM_TIME_MAX = 10000;
        private const int BASE_SCORE_CALCULATION = 200;
        private const int MAX_SCORE = 1000;
        private const int TOO_EARLY_SCORE = -100;
        private const int TIME_BUFFER = 20;

        //---------------------------------------------------------------
        //Sets the time then resets the stopwatch
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        //---------------------------------------------------------------
        //Gives a random number of milliseconds from 1000-10000
        //---------------------------------------------------------------
        public override int randomTime()
        {
            Random rnd = new Random();
            int time = rnd.Next(RANDOM_TIME_MIN, RANDOM_TIME_MAX);
            return time;
        }

        //---------------------------------------------------------------
        //Calculates the score based on the time
        //---------------------------------------------------------------
        public override void calculateScore()
        {
            //Cheating check
            if (getTime() < TIME_BUFFER)
            {
                setScore(TOO_EARLY_SCORE);
                return;
            }
            //If the user was quicker than the base point
            if (getTime() < BASE_SCORE_CALCULATION)
            {
                //Set to full points
                setScore(MAX_SCORE);
                return;
            }
            //If the user took longer than 200, subtract it from 1200 to
            //get the score
            long score = BASE_SCORE_CALCULATION + MAX_SCORE - getTime();
            //If the score is negative, set to zero
            if (score < 0)
                score = 0;
            setScore(score);
        }
    }
}
