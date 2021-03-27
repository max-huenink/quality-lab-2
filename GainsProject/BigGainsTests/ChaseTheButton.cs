//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the Chase the button game manager
//---------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // Test the Chase the button game manager
    //---------------------------------------------------------------
    [TestClass]
    public class ChaseTheButtonTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoringValid()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(888, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the lower bound scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void LowerScoreTest()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(20000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the upper bound scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void UpperScoreTest()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(1000);
            game.calculateScore();
            Assert.AreEqual(1000, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests that the run game method works as intended
        //---------------------------------------------------------------
        [TestMethod]
        public void runGame()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.stopwatch.Start();
            game.stopwatch.Stop();
            game.runGame();
            Assert.AreEqual(0, game.stopwatch.ElapsedMilliseconds);
        }
    }
}
