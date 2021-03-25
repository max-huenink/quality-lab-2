﻿//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the mental math game and manage the data
//---------------------------------------------------------------
using System;
using GainsProject.Domain;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Runs the mental math game and manages the data
    //---------------------------------------------------------------
    public class MentalMathGameManager : BaseGame
    {
        //Constants
        public const int WRONG_ANSWER = -10;
        public const int MAX_SCORE = 100;
        public const int MAX_SCORE_TIME = 1000;
        public const int ZERO_SCORE_TIME = 10000;
        public const int SCORE_DIVISOR = -90;
        public const int RANDOM_TIME_MAX = 10;
        public const int RANDOM_TIME_MIN = 2;
        //Seeded random
        Random rnd = new Random();
        //---------------------------------------------------------------
        //Sets the time then resets the stopwatch
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
        //---------------------------------------------------------------
        //Calculates the score based on the time. Then adds the current 
        //score to the new calculation so multiple problems can be done
        //---------------------------------------------------------------
        public override void calculateScore()
        {
            //Get the answer time
            long time = this.getTime();
            //If the answer was wrong
            if (time <= 0)
            {
                setScore(WRONG_ANSWER + getScore());
                return;
            }
            //Lower than the max score time
            if(time <= MAX_SCORE_TIME)
            {
                setScore(MAX_SCORE + getScore());
                return;
            }
            //Any time after ten seconds
            if (time >= ZERO_SCORE_TIME)
                return;
            //If the time was not worth 100, or 0 points, invert the time
            long inverse = time - ZERO_SCORE_TIME;
            setScore((inverse / SCORE_DIVISOR) + getScore()); ;
        }
        //---------------------------------------------------------------
        //Gives a random number for the math problems from 2-9
        //---------------------------------------------------------------
        public override int randomTime()
        {
            int time = rnd.Next(RANDOM_TIME_MIN, RANDOM_TIME_MAX);
            return time;
        }
    }
}