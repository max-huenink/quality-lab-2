using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    [TestClass]
    public class UnitTest1
    {
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(5000);
            game.calculateScore();
            Assert.AreEqual(70, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager for wrong 
        //answers
        //---------------------------------------------------------------
        [TestMethod]
        public void scoring()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(-1);
            game.calculateScore();
            Assert.AreEqual(-50, game.getScore());
        }
        //---------------------------------------------------------------
        //
        //---------------------------------------------------------------
        [TestMethod]
        public void runGame()
        {

        }
    }
}
