using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;
namespace BigGainsTests
{
    [TestClass]
    public class ChaseTheArrowTests
    {
        [TestMethod]
        public void ScoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(900, game.getScore());
        }
        [TestMethod]
        public void LowerScoreTest()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(20000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        [TestMethod]
        public void UpperScoreTest()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(1000);
            game.calculateScore();
            Assert.AreEqual(1000, game.getScore());
        }
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
