//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the spot the scenery game
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using GainsProject.Application;
using System.Threading;
namespace BigGainsTests
{
    //---------------------------------------------------------------
    // this class tests the logic for the spot the scenery
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
            Assert.AreEqual(game.getScore(),
                SpotTheSceneryGameManager.PERFECT_SCORE);
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
            Assert.AreEqual(game.getScore(),
                SpotTheSceneryGameManager.PERFECT_SCORE);
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
            Assert.AreEqual(game.getScore(),
                SpotTheSceneryGameManager.PERFECT_SCORE);
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
            game.totalRunTime.Start();
            Thread.Sleep(SpotTheSceneryGameManager.PERFECT_TIME + 1000);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), 980);
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
            Assert.AreNotEqual(game.getScore(), test);
        }

        //---------------------------------------------------------------
        // this method tests the score calculation for worse than a 
        // perfect time
        //---------------------------------------------------------------
        [TestMethod]
        public void worstScoreTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME);
            game.setNumRight(0);
            game.setNumWrong(SpotTheSceneryGameManager.NUM_ROUNDS);
            game.calculateScore();
            Assert.AreEqual(game.getScore(), 0);
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
            Assert.AreEqual(game.getScore(),
                (int)(SpotTheSceneryGameManager.PERFECT_SCORE *
                ((double)game.getNumRight() - (double)game.getNumWrong()) /
                (double)game.getNumRight()));
        }

        //---------------------------------------------------------------
        // This method tests for the worst possible score
        //---------------------------------------------------------------
        [TestMethod]
        public void missedScenesTest2()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.setTime(SpotTheSceneryGameManager.PERFECT_TIME);
            game.setNumRight(SpotTheSceneryGameManager.NUM_ROUNDS - 1);
            game.setNumWrong(1);
            game.calculateScore();
            Assert.AreEqual(game.getScore(),
                SpotTheSceneryGameManager.PERFECT_SCORE *
                ((double)game.getNumRight() - (double)game.getNumWrong()) /
                (double)game.getNumRight());
        }

        //---------------------------------------------------------------
        // this method tests that the game runs
        //---------------------------------------------------------------
        [TestMethod]
        public void runGameTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.stopwatch.Start();
            game.runGame();
            Assert.IsFalse(game.stopwatch.IsRunning);
            Assert.AreEqual(game.getTime(),
                game.stopwatch.ElapsedMilliseconds);
        }

        //---------------------------------------------------------------
        // this method tests the random time function
        //---------------------------------------------------------------
        [TestMethod]
        public void randomTimeTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            int time = game.randomTime();
            Assert.AreNotEqual(time, -1);
        }

        //---------------------------------------------------------------
        // this method tests the new round method
        //---------------------------------------------------------------
        [TestMethod]
        public void newRoundTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.fillPictureManager();
            Assert.AreEqual(game.hasNextRound(), true);
            while (game.hasNextRound())
            {
                game.newRound();
                Assert.AreNotEqual(game.getCurrDescriptor(),
                    "notAreakDescriptor");
                Assert.AreNotEqual(game.getCurrPictures()[0], null);
            }
            Assert.AreEqual(game.getCurrRound(),
                SpotTheSceneryGameManager.NUM_ROUNDS);
            Assert.AreEqual(game.hasNextRound(), false);
        }

        //---------------------------------------------------------------
        // this method tests picture clicked
        //---------------------------------------------------------------
        [TestMethod]
        public void pictureClickedTest()
        {
            SpotTheSceneryGameManager game = new SpotTheSceneryGameManager();
            game.fillPictureManager();
            game.newRound();
            while (game.getNumRight() == 0 || game.getNumWrong() == 0)
            {
                game.pictureClicked(1);
                game.newRound();
            }
            Assert.AreNotEqual(game.getNumRight(), 0);
            Assert.AreNotEqual(game.getNumWrong(), 0);
        }
    }
}
