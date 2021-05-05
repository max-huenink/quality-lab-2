//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: This class tests the dizzy buttons game manager
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GainsProject.Application;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // this class tests the logic for the dizzy buttons game manager
    //---------------------------------------------------------------
    [TestClass]
    public class DizzyButtonsGameTests
    {
        //---------------------------------------------------------------
        // this method tests button events work
        //---------------------------------------------------------------
        [TestMethod]
        public void addButtonClickedTest1()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            List<Button> list = game.getButtonList();
            game.setButtonDefaults(list[0]);
            game.onButtonClick(list[0], new System.EventArgs());
            Assert.AreEqual(game.getScore(), 0 - DizzyButtonsGameManager.MINUS_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests button events work
        //---------------------------------------------------------------
        [TestMethod]
        public void addButtonClickedTest2()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            List<Button> list = game.getButtonList();
            game.setIsIt(list[1]);
            game.setScore(10000000);
            game.onButtonClick(list[1], new System.EventArgs());
            Assert.AreEqual(game.getScore(), 1000);
        }
        //---------------------------------------------------------------
        // this method tests the tick method
        //---------------------------------------------------------------
        [TestMethod]
        public void tickTest1()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            game.tick();
            Assert.IsFalse(game.getIsFinished());
        }
        //---------------------------------------------------------------
        // this method tests the tick method
        //---------------------------------------------------------------
        [TestMethod]
        public void tickTest2()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            while(!game.getIsFinished())
            {
                game.tick();
            }
            Assert.IsTrue(game.getIsFinished());
        }
        //---------------------------------------------------------------
        // this method tests the minus score method
        //---------------------------------------------------------------
        [TestMethod]
        public void minusScoreTest1()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            game.minusScore();
            Assert.AreEqual(game.getScore(), 0 - DizzyButtonsGameManager.MINUS_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests the minus score method
        //---------------------------------------------------------------
        [TestMethod]
        public void minusScoreTest2()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            Assert.AreNotEqual(game.getScore(), 0 - DizzyButtonsGameManager.MINUS_SCORE);
        }
        //---------------------------------------------------------------
        // this method tests that the calculate score method does nothing
        //---------------------------------------------------------------
        [TestMethod]
        public void addButtonTest()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            Assert.AreEqual(game.getButtonList().Count, DizzyButtonsGameManager.NUM_BUTTONS);
        }
        //---------------------------------------------------------------
        // this method tests that the game runs
        //---------------------------------------------------------------
        [TestMethod]
        public void RunGameTest()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            game.stopwatch.Start();
            game.runGame();
            Assert.IsTrue(game.stopwatch.IsRunning);
        }
        //---------------------------------------------------------------
        // this method tests the random time function
        //---------------------------------------------------------------
        [TestMethod]
        public void randomTimeTest()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            Assert.AreEqual(game.randomTime(), 0);
        }
        //---------------------------------------------------------------
        // this method tests that the calculate score method does nothing
        //---------------------------------------------------------------
        [TestMethod]
        public void inheritedCalculateScoreTest()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            game.calculateScore();
            Assert.AreEqual(game.getScore(), 0);
        }
        //---------------------------------------------------------------
        // this method tests that the to add and remove stacks are filled
        //---------------------------------------------------------------
        [TestMethod]
        public void toRemoveAndAddTest()
        {
            DizzyButtonsGameManager game = new DizzyButtonsGameManager();
            Assert.AreNotEqual(game.getToAdd(), null);
            Assert.AreNotEqual(game.getToDelete(), null);
        }
    }
}
