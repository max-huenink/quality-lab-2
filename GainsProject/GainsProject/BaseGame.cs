//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display an example game for the user to play
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsProject
{
    //---------------------------------------------------------------
    //Abstract base class for all games
    //---------------------------------------------------------------
    public abstract class BaseGame
    {
        //Long varuble used to calculate reaction time
        private long time;
        //Long var used to store the score
        private long score;
        //Boolean to keep track of wether or not the game is live
        private bool isLive;
        //Stopwatch varuble to measure reaction time
        public Stopwatch stopwatch = new Stopwatch();
        //Dafault constructor
        public BaseGame()
        {
            time = -1;
            score = 0;
            isLive = false;
        }
        //setter for time
        public void setTime(long time){ this.time = time; }
        //setter for score
        public void setScore(long score) { this.score = score; }
        //Sets the isLive attribute to true
        public void start() { isLive = true; }
        //Stops the game
        public void endGame() { isLive = false; }
        //getter for time
        public long getTime() { return this.time; }
        //getter for score
        public long getScore() { return this.score; }
        //getter for IsLive
        public bool isGameLive() { return this.isLive; }
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
