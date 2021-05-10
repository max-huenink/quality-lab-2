//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display an example game for the user to play
//---------------------------------------------------------------
using System;
using System.Diagnostics;
using GainsProject.Domain.Interfaces;

namespace GainsProject.Domain
{
    //---------------------------------------------------------------
    //Abstract base class for all games
    //---------------------------------------------------------------
    public abstract class BaseGame : IGame
    {
        //Long varuble used to calculate reaction time
        private long time;
        //Long var used to store the score
        private long score;
        //Boolean to keep track of wether or not the game is live
        private bool isLive;
        //Stopwatch varuble to measure reaction time
        public Stopwatch stopwatch = new Stopwatch();
        public Stopwatch totalRunTime = new Stopwatch();

        //Dafault constructor, covered in unit test
        public BaseGame()
        {
            time = -1;
            score = 0;
            isLive = false;
        }

        //setter for time
        public void setTime(long time)
        {
            this.time = time;
        }

        //setter for score
        public void setScore(long score)
        {
            this.score = score;
        }

        //Sets the isLive attribute to true
        public void start()
        {
            isLive = true;
            totalRunTime.Restart();
        }

        //Stops the game
        public void endGame()
        {
            isLive = false;
            totalRunTime.Stop();
        }

        //getter for time
        public long getTime()
        {
            return time;
        }

        //getter for score
        public long getScore()
        {
            return score;
        }

        //getter for IsLive
        public bool isGameLive()
        {
            return isLive;
        }

        //getter for total run time stopwatch
        public Stopwatch getTotalRunTimeStopwatch()
        {
            return totalRunTime;
        }

        //getter for total game run time
        public TimeSpan getGameRunTime()
        {
            return totalRunTime.Elapsed;
        }

        //---------------------------------------------------------------
        //Gives a random number of milliseconds based on the game
        //*ABSTRACT METHOD*
        //---------------------------------------------------------------
        public abstract int randomTime();

        //---------------------------------------------------------------
        //Method for game-spesific features to be run in*ABSTRACT METHOD*
        //---------------------------------------------------------------
        public abstract void runGame();

        //---------------------------------------------------------------
        //Calculates the score based on the time *ABSTRACT METHOD*
        //---------------------------------------------------------------
        public abstract void calculateScore();
    }
}
