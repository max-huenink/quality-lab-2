//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the exmaple game class and base game class
//---------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;
using System.Threading.Tasks;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    //Test the base game class
    //---------------------------------------------------------------
    [TestClass]
    public class BaseGameTests
    {
        //NOTE: due to the base game class being abstract, a child of
        //Base game is used to test the functionality of base game
        //---------------------------------------------------------------
        //Tests the default constructor of the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void DefaultConstructortest()
        {
            ExampleGameManager game = new ExampleGameManager();
            //There are three tests to test the default constructor
            Assert.AreEqual(0, game.getScore());
            Assert.AreEqual(-1, game.getTime());
            Assert.AreEqual(false, game.isGameLive());
        }
        //---------------------------------------------------------------
        //Tests the getter and setter of score in the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void Score()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setScore(45);
            Assert.AreEqual(45, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the getter and setter of isLive in the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void IsLiveTestTrue()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.start();
            Assert.AreEqual(true, game.isGameLive());
        }
        //---------------------------------------------------------------
        //Tests the getter and setter of is live in the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void IsLiveTestFalse()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.start();
            game.endGame();
            Assert.AreEqual(false, game.isGameLive());
        }
        //---------------------------------------------------------------
        //Tests the getter and setter of time in the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void TimeTest()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setTime(843);
            Assert.AreEqual(843, game.getTime());
        }
        //---------------------------------------------------------------
        //Tests total runtime of the game
        //---------------------------------------------------------------
        [TestMethod]
        public async Task TotalTimeTest()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.start();
            await Task.Delay(1000);
            game.endGame();
            var sw = game.getTotalRunTimeStopwatch();
            Assert.AreEqual(sw.Elapsed, game.getGameRunTime());
        }

    }
    //---------------------------------------------------------------
    //Test the Example game manager class
    //---------------------------------------------------------------
    [TestClass]
    public class ExampleGameTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the example game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoringValid()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setTime(500);
            game.calculateScore();
            Assert.AreEqual(700, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the scoring in the example game manager if time is zero
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoringTooEarly()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setTime(0);
            game.calculateScore();
            Assert.AreEqual(-100, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the stopwatch reset in the example game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void RunGame()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.stopwatch.Start();
            game.stopwatch.Stop();
            game.runGame();
            Assert.AreEqual(0, game.stopwatch.ElapsedMilliseconds);
        }
    }
}
