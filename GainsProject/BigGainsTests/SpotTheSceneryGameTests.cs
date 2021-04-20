//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the spot the scenery game
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GainsProject.Application;
namespace BigGainsTests
{
    //---------------------------------------------------------------
    // this class tests the testable logic for the spot the scenery
    // game
    //---------------------------------------------------------------
    [TestClass]
    public class SpotTheSceneryGameTests
    {
        //---------------------------------------------------------------
        // this method tests the score calculation for better than a 
        // perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void greaterThanPerfectTest1()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME - 1);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), SpotTheSceneryGameManager.PERFECT_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for better than a 
        // perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void greaterThanPerfectTest2()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME - 1000);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), SpotTheSceneryGameManager.PERFECT_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for a perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void perfectTest1()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), SpotTheSceneryGameManager.PERFECT_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for worse than a 
        // perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void lessThanPerfectTest1()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME + 1);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), SpotTheSceneryGameManager.PERFECT_SCORE - 
                (game.getTime() - SpotTheSceneryGameManager.PERFECT_TIME) / 
                SpotTheSceneryGameManager.SCORE_DECAY);
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for worse than a 
        // perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void lessThanPerfectTest2()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME + 1000);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            double test = SpotTheSceneryGameManager.PERFECT_SCORE -
                (game.getTime() - SpotTheSceneryGameManager.PERFECT_TIME) /
                SpotTheSceneryGameManager.SCORE_DECAY;
            Console.WriteLine(test);
            Assert.AreNotEqual(game.getScore(), test);
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for missed scenes
        //---------------------------------------------------------------
        [TestMethod]
        public void missedScenesTest1()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS - 2);
            game.setNumWrong(2);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), (int)(SpotTheSceneryGameManager.PERFECT_SCORE * 
                ((double)game.getNumRight() - (double)game.getNumWrong()) / 
                (double)game.getNumRight()));
        }
        //---------------------------------------------------------------
        // this method tests the score calculation for missed scenes
        //---------------------------------------------------------------
        [TestMethod]
        public void missedScenesTest2()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS - 1);
            game.setNumWrong(1);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), SpotTheSceneryGameManager.PERFECT_SCORE *
                ((double)game.getNumRight() - (double)game.getNumWrong()) /
                (double)game.getNumRight());
        }
        //---------------------------------------------------------------
        // this method tests that the game runs
        //---------------------------------------------------------------
        [TestMethod]
        public void RunGameTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.stopwatch.Start();
            game.runGame();
            Assert.IsFalse(game.stopwatch.IsRunning);
            Assert.AreEqual(game.getTime(), game.stopwatch.ElapsedMilliseconds);
        }
    }
}
