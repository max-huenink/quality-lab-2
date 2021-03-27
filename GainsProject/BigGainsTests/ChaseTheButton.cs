using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    [TestClass]
    public class ChaseTheButtonTests
    {
        [TestMethod]
        public void ScoringValid()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(888, game.getScore());
        }
        [TestMethod]
        public void LowerScoreTest()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(20000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        [TestMethod]
        public void UpperScoreTest()
        {
            ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
            game.setTime(1000);
            game.calculateScore();
            Assert.AreEqual(1000, game.getScore());
        }
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
