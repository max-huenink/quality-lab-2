//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the arrow key game and manage the data
//---------------------------------------------------------------
using GainsProject.Domain;
using System;
using System.Windows.Forms;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Runs the arrow key game and manages the data
    //---------------------------------------------------------------
    public class ArrowKeyGameManager : BaseGame
    {
        #region Constants

        private const int RANDOM_TIME_MIN = 500;
        private const int RANDOM_TIME_MAX = 2000;

        private const int PERFECT_SCORE_TIME = 200;
        private const int BEFORE_CLICK_TIME = 100;
        private const int AFTER_CLICK_TIME = 10;

        private const int MAX_TIME_TO_CLICK = 1200;
        private const int MIN_TIME_TO_CLICK = -300;

        private const int MAX_SCORE_PER_CLICK = 100;
        private const int BEFORE_CLICK_MODIFIER = -25;
        private const int AFTER_CLICK_MODIFIER = -1;

        private const int WRONG_BUTTON_SCORE = -50;

        private const int MAX_CLICKS = 25;

        #endregion

        private int buttonClicks;
        private int timeUntilClick;
        private long totalScore;
        private Keys buttonToClick;
        private Keys clickedButton;
        private readonly Random rnd;

        public ArrowKeyGameManager()
        {
            rnd = new Random();
            buttonClicks = 0;
            totalScore = 0;
        }

        //---------------------------------------------------------------
        //Gets the max time until the user needs to click
        //---------------------------------------------------------------
        public int getMaxTimeToClick()
        {
            return MAX_TIME_TO_CLICK;
        }

        //---------------------------------------------------------------
        //Sets time until the button click will happen
        //---------------------------------------------------------------
        public void setTimeUntilClick(int time)
        {
            timeUntilClick = time;
        }

        //---------------------------------------------------------------
        //Sets the button that needs to be clicked
        //---------------------------------------------------------------
        public void setButtonToClick(Keys button)
        {
            buttonToClick = button;
        }

        //---------------------------------------------------------------
        //Sets the button that was clicked
        //---------------------------------------------------------------
        public void setClickedButton(Keys button)
        {
            clickedButton = button;
        }

        //---------------------------------------------------------------
        //Updates the total score, adding the passed score to it
        //---------------------------------------------------------------
        public void updateTotalScore(long score)
        {
            totalScore += score;
        }

        //---------------------------------------------------------------
        //Gets the total score
        //---------------------------------------------------------------
        public long getTotalScore()
        {
            return totalScore;
        }

        //---------------------------------------------------------------
        //Sets the time then resets the stopwatch
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }

        //---------------------------------------------------------------
        //Gives a random number of milliseconds from 500-2000
        //---------------------------------------------------------------
        public override int randomTime()
        {
            return rnd.Next(RANDOM_TIME_MIN, RANDOM_TIME_MAX);
        }

        //---------------------------------------------------------------
        //Calculates the score based on the time a button was clicked
        //---------------------------------------------------------------
        public override void calculateScore()
        {
            buttonClicks++;
            if (buttonClicks <= MAX_CLICKS)
            {
                var clickedAt = getTime();
                var score = scoreCalculator(clickedAt - timeUntilClick);
                updateTotalScore(score);
                setScore(score);

                if (buttonClicks >= MAX_CLICKS)
                {
                    endGame();
                }
            }
        }

        //---------------------------------------------------------------
        //Calculates the score based on the difference in the time
        // the button flashed and the key was clicked
        //---------------------------------------------------------------
        private long scoreCalculator(long timeClickDelta)
        {
            if (!buttonToClick.HasFlag(clickedButton))
            {
                return WRONG_BUTTON_SCORE;
            }
            else if (timeClickDelta >= 0 && timeClickDelta <= PERFECT_SCORE_TIME)
            {
                return MAX_SCORE_PER_CLICK;
            }
            else if (timeClickDelta >= 0 && timeClickDelta <= MAX_TIME_TO_CLICK)
            {
                // We know timeCLickDelta is at least PERFECT_SCORE_TIME, subtract it to make calculation easier
                timeClickDelta -= PERFECT_SCORE_TIME;
                var numberOfIntervals = Math.Ceiling(timeClickDelta / (double)AFTER_CLICK_TIME);
                return MAX_SCORE_PER_CLICK + AFTER_CLICK_MODIFIER * (long)numberOfIntervals;
            }
            else if (timeClickDelta < 0 && MIN_TIME_TO_CLICK <= timeClickDelta)
            {
                // We know timeClickDelta is negative, make it positive for easier calculation
                timeClickDelta *= -1;
                var numberOfIntervals = Math.Ceiling(timeClickDelta / (double)BEFORE_CLICK_TIME);
                return MAX_SCORE_PER_CLICK + BEFORE_CLICK_MODIFIER * (long)numberOfIntervals;
            }
            else
            {
                return 0;
            }
        }
    }
}
