using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    [TestClass]
    class PictureDrawingGameTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the picture drawing game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(88, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the low boundry scoring in the picture drawing game 
        // manager
        //---------------------------------------------------------------
        [TestMethod]
        public void boundryLowScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(60000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the upper boundry scoring in the picture drawing game 
        //manager
        //---------------------------------------------------------------
        [TestMethod]
        public void boundryUpperScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(400);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the scoring in the picture drawing manager for  
        //incorrect paintings
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringWrongAnswer()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(-1);
            game.calculateScore();
            Assert.AreEqual(-10, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests that the game can run in the picture drawing game
        //---------------------------------------------------------------
        [TestMethod]
        public void runGame()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.stopwatch.Start();
            game.stopwatch.Stop();
            game.runGame();
            Assert.AreEqual(0, game.stopwatch.ElapsedMilliseconds);
        }
    }
}
