//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the chase the button game and manage the data
//---------------------------------------------------------------
using System;
using GainsProject.Domain;
using GainsProject.Application;
namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Runs the chase the button game and manages the data
    //---------------------------------------------------------------
    public class ChaseTheButtonGameManager : BaseGame
    {
        //Constants
        private const int MIN_RANDOM_X = 10;
        private const int MAX_RANDOM_X = 900;
        private const int MIN_RANDOM_Y = 10;
        private const int MAX_RANDOM_Y = 610;
        private const int BASE_SCORE_CALCULATION = 200;
        private const int MAX_SCORE = 1000;
        private const int MAX_SCORE_TIME = 1500;
        private const int ZERO_SCORE_TIME = 7500;
        private const int SCORE_DIVISOR = -6;
        //Seed the random number generator
        private Random rnd = new Random();
        //---------------------------------------------------------------
        //Sets the time then resets the stopwatch
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
        //---------------------------------------------------------------
        //Gives a random number of cordinates from 10 - 900 for the xcord
        //---------------------------------------------------------------
        public override int randomTime()
        {
            int time = rnd.Next(MIN_RANDOM_X, MAX_RANDOM_X);
            return time;
        }
        //---------------------------------------------------------------
        //Calculates the score based on the time
        //---------------------------------------------------------------
        public override void calculateScore()
        {
            //Get the time
            long time = this.getTime();
            //If it is lower than 1.5 seconds, give the max score
            if (time <= MAX_SCORE_TIME)
            {
                this.setScore(MAX_SCORE);
                return;
            }
            //If the time is longer than the zero score time
            else if (time > ZERO_SCORE_TIME)
            {
                //Set the score to zero
                this.setScore(0);
                return;
            }
            //If it falls inbetween, calculate the score
            this.setScore((time - ZERO_SCORE_TIME) / SCORE_DIVISOR);
        }
        //---------------------------------------------------------------
        //Gives a random number of cordinates from 10-610 for the y cord
        //---------------------------------------------------------------
        public  int randomY()
        {
            int time = rnd.Next(MIN_RANDOM_Y, MAX_RANDOM_Y);
            return time;
        }
    }
}
