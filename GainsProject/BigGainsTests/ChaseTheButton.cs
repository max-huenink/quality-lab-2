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
            game.setTime(3000);
            game.calculateScore();
            Assert.AreEqual(833, game.getScore());
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
        //---------------------------------------------------------------
        //Tests the random x cord method returning a value
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomXValueReturn()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            Assert.AreNotEqual(null, game.randomTime());
        }
        //---------------------------------------------------------------
        //Tests the random x method returning a value inbetween the range
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomXRange()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            long test = game.randomTime();
            bool range = (test >= 10 || test <= 900);
            Assert.IsTrue(range);
        }
        //---------------------------------------------------------------
        //Tests the random y cord method returning a value
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomYValueReturn()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            Assert.AreNotEqual(null, game.randomY());
        }
        //---------------------------------------------------------------
        //Tests the random y method returning a value inbetween the range
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomYRange()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            long test = game.randomY();
            bool range = (test >= 10 || test <= 610);
            Assert.IsTrue(range);
        }
    }
}
