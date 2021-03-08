//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the exmaple game class and base game class
//---------------------------------------------------------------
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    //Test class for the game classes
    //---------------------------------------------------------------
    [TestClass]
    public class GameTests : ScoreSave
    {
        //---------------------------------------------------------------
        //Tests parts of the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void BaseGameTest1()
        {
            ExampleGameManager game = new ExampleGameManager();
            Assert.AreEqual(0, game.getScore());
            Assert.AreEqual(-1, game.getTime());
            Assert.AreEqual(false, game.isGameLive());
        }
        //---------------------------------------------------------------
        //Tests parts of the base game class
        //---------------------------------------------------------------
        [TestMethod]
        public void BaseGameTest2()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setScore(45);
            game.start();
            game.setTime(843);
            Assert.AreEqual(45, game.getScore());
            Assert.AreEqual(843, game.getTime());
            Assert.AreEqual(true, game.isGameLive());
        }
        //---------------------------------------------------------------
        //Tests parts of the example game 
        //---------------------------------------------------------------
        [TestMethod]
        public void ExampleGameTest1()
        {
            ExampleGameManager game = new ExampleGameManager();
            game.setTime(500);
            game.calculateScore();
            Assert.AreEqual(700,game.getScore() );
        }
        //---------------------------------------------------------------
        //Tests the ScoreSave class 
        //---------------------------------------------------------------
        [TestMethod]
        public void ScoreSaveTest1()
        {
            ScoreSave save = new ScoreSave();
            save.addScore(5, "nickLol");
            Assert.AreEqual(5, save.getSaveDataList()[0].getScore());
            save.writeFile();
        }
    }
}
