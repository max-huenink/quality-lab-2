using Microsoft.VisualStudio.TestTools.UnitTesting;
using GainsProject.Application;
using System;

namespace BigGainsTests
{
    [TestClass]
    public class PictureDrawingManagerTests
    {
        //---------------------------------------------------------------
        //Tests the scoring in the picture drawing game manager
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringValid()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.setTime(2000);
            game.calculateScore();
            Assert.AreEqual(true, game.getScore() < 1000 && game.getScore() >= 0);
        }
        //---------------------------------------------------------------
        //Tests the low boundry scoring in the picture drawing game 
        // manager
        //---------------------------------------------------------------
        [TestMethod]
        public void boundryLowScoringValid()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.setTime(6000);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the upper boundry scoring in the picture drawing game 
        //manager
        //---------------------------------------------------------------
        [TestMethod]
        public void boundryUpperScoringValid()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.runGame();
            game.calculateScore();
            Assert.AreEqual(1000, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests the scoring in the picture drawing manager for  
        //incorrect paintings
        //---------------------------------------------------------------
        [TestMethod]
        public void scoringWrongAnswer()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.runGame();
            game.calculateScore();
            Assert.AreNotEqual(999, game.getScore());
        }
        //---------------------------------------------------------------
        //Tests that the game can run in the picture drawing game
        //---------------------------------------------------------------
        [TestMethod]
        public void runGame()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.stopwatch.Start();
            game.stopwatch.Stop();
            game.runGame();
            Assert.AreEqual(0, game.stopwatch.ElapsedMilliseconds);
        }
        [TestMethod]
        public void incrementIncorrectAnswer()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.incorrectAnswer();
            Assert.AreEqual("1", game.getIncorrectPictures());
        }
        [TestMethod]
        public void checkPaintingsSame()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.runGame();
            game.fillDrawingArray(game.getPictureArray());
            Assert.AreEqual(true, game.checkPainting());
        }

        [TestMethod]
        public void useKeyToChangeColor()
        {
            PictureDrawingManager game = new PictureDrawingManager();
            game.runGame();
            game.setColorWithKey(System.Windows.Forms.Keys.D1);

            Assert.AreEqual(0, game.getColor());
        }
    }
}
