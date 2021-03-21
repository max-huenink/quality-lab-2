using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;

namespace BigGainsTests
{
    [TestClass]
    public class MentalMathGameTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the mental math game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringValid()
        {
            MentalMathGameManager game = new MentalMathGameManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(64, game.getScore());
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
