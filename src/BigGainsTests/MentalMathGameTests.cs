//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the Mental Math game manager
//---------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // Test the Mental Math game manager
    //---------------------------------------------------------------
    [TestClass]
    public class MentalMathGameTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(88, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the low boundry scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void BoundryLowScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(60000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the upper boundry scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void BoundryUpperScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(400);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager for wrong 
        //answers
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoringWrongAnswer()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(-1);
            game.calculateScore();
            Assert.AreEqual(-50, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests that the run game method works as intended
        //---------------------------------------------------------------
        [TestMethod]
        public void RunGame()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.stopwatch.Start();
            game.stopwatch.Stop();
            game.runGame();
            Assert.AreEqual(0, game.stopwatch.ElapsedMilliseconds);
        }
        //---------------------------------------------------------------
        //Tests the random method returning a value
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomTimeValueReturn()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            Assert.AreNotEqual(null, game.randomTime());
        }
        //---------------------------------------------------------------
        //Tests the random method returning a value inbetween the range
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomTimeRange()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            long test = game.randomTime();
            bool range = (test >= 2 || test <= 10);
            Assert.IsTrue(range);
        }
    }
}
