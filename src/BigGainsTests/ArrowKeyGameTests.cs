//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the arrow key game manager
//---------------------------------------------------------------
using GainsProject.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    //Tests the arrow key game manager
    //---------------------------------------------------------------
    [TestClass]
    public class ArrowKeyGameTests
    {
        #region Negative Score Tests

        //---------------------------------------------------------------
        //Tests the low boundary of negative score calculation,
        // for every 100ms before an arrow flashes, score goes down by 25
        //So 401ms before arrow flashes, score should be 0
        //---------------------------------------------------------------
        [TestMethod]
        public void negativeScoreCalculationLowBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(699);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(0, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the low boundary of negative score calculation,
        // for every 100ms before an arrow flashes, score goes down by 25
        //So 300ms before arrow flashes, score should be 25
        //---------------------------------------------------------------
        [TestMethod]
        public void negativeScoreCalculationLowBoundaryTest2()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(700);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(25, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the low boundary of negative score calculation,
        // for every 100ms before an arrow flashes, score goes down by 25
        //So 200ms before arrow flashes, score should be 50
        //---------------------------------------------------------------
        [TestMethod]
        public void negativeScoreCalculationLowBoundaryTest3()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(800);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(50, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the low boundary of negative score calculation,
        // for every 100ms before an arrow flashes, score goes down by 25
        //So 100ms before arrow flashes, score should be 75
        //---------------------------------------------------------------
        [TestMethod]
        public void negativeScoreCalculationLowBoundaryTest4()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(900);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(75, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the low boundary of negative score calculation,
        // for every 100ms before an arrow flashes, score goes down by 25
        //So 1ms before arrow flashes, score should be 75
        //---------------------------------------------------------------
        [TestMethod]
        public void negativeScoreCalculationHighBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(999);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(75, game.getScore());
        }

        #endregion

        #region Perfect Score Tests

        //---------------------------------------------------------------
        //Tests the lower boundary of perfect score calculation
        // 200ms buffer for perfect score
        //---------------------------------------------------------------
        [TestMethod]
        public void perfectScoreCalculationLowBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1000);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the middle boundary of perfect score calculation
        // 200ms buffer for perfect score
        //---------------------------------------------------------------
        [TestMethod]
        public void perfectScoreCalculationMiddleBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1100);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the high boundary of perfect score calculation
        // 200ms buffer for perfect score
        //---------------------------------------------------------------
        [TestMethod]
        public void perfectScoreCalculationHighBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1200);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }

        #endregion

        #region Positive Score Tests

        //---------------------------------------------------------------
        //Tests the low boundary of score calculation, for every 10ms
        // after perfect score boundary, score goes down by 1
        // starting 1ms after the perfect score boundary
        //Perfect is within 200ms, so 201ms should be perfect-1
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationLowBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1201);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the low boundary of score calculation, for every 10ms
        // after perfect score boundary, score goes down by 1
        // starting 1ms after the perfect score boundary
        //Perfect is within 200ms, so 210ms should still be perfect-1
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationLowBoundaryTest2()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1210);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the middle boundary of score calculation, for every 10ms
        // after perfect score boundary, score goes down by 1
        // starting 1ms after the perfect score boundary
        //Perfect is within 200ms, so 1700ms should be perfect-50
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationMiddleBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1700);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(65, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the high boundary of score calculation, for every 10ms
        // after perfect score boundary, score goes down by 1
        // starting 1ms after the perfect score boundary
        //Perfect is 200ms, so 2190 should be perfect-99
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationHighBoundaryTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(2190);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(16, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the high boundary of score calculation, for every 10ms
        // after perfect score boundary, score goes down by 1
        // starting 1ms after the perfect score boundary
        //Perfect is 200ms, so 2191 should be perfect-perfect
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationHighBoundaryTest2()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(2191);
            game.setClickedButton(Keys.Left);
            game.calculateScore();
            Assert.AreEqual(15, game.getScore());
        }

        #endregion

        #region Wrong Button Score Tests

        //---------------------------------------------------------------
        //Tests the score calculation with a wrong button
        //Score should be -50 no matter when the wrong button is pressed
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationWrongButtonBeforeTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(900);
            game.setClickedButton(Keys.Right);
            game.calculateScore();
            Assert.AreEqual(-50, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the score calculation with a wrong button
        //Score should be -50 no matter when the wrong button is pressed
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationWrongButtonTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1000);
            game.setClickedButton(Keys.Right);
            game.calculateScore();
            Assert.AreEqual(-50, game.getScore());
        }

        //---------------------------------------------------------------
        //Tests the score calculation with a wrong button
        //Score should be -50 no matter when the wrong button is pressed
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreCalculationWrongButtonAfterTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setTime(1201);
            game.setClickedButton(Keys.Right);
            game.calculateScore();
            Assert.AreEqual(-50, game.getScore());
        }

        #endregion

        #region Total Score Tests

        //---------------------------------------------------------------
        //Tests updating the total score from its initial state
        //---------------------------------------------------------------
        [TestMethod]
        public void totalScoreOneUpdateTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.updateTotalScore(100);
            Assert.AreEqual(100, game.getTotalScore());
        }

        //---------------------------------------------------------------
        //Tests updating the total score from its initial state multiple
        // times. Total should be cumulative score
        //---------------------------------------------------------------
        [TestMethod]
        public void totalScoreThreeUpdateTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.updateTotalScore(100);
            game.updateTotalScore(200);
            game.updateTotalScore(300);
            Assert.AreEqual(600, game.getTotalScore());
        }

        //---------------------------------------------------------------
        //Tests the value of the total score after calculating the score
        //Calculating score should set the score and update total score
        //---------------------------------------------------------------
        [TestMethod]
        public void totalScoreCalculateTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.setTimeUntilClick(1000);
            game.setButtonToClick(Keys.Left);
            game.setClickedButton(Keys.Left);

            // Perfect, score is 100
            game.setTime(1200);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());

            // 1ms after perfect, score is 100
            game.setTime(1201);
            game.calculateScore();
            Assert.AreEqual(100, game.getScore());

            // Total score is 100 + 100
            Assert.AreEqual(200, game.getTotalScore());
        }

        #endregion

        #region Constant Tests

        //---------------------------------------------------------------
        //Tests that the constant RANDOM_TIME_MIN is 500
        //---------------------------------------------------------------
        [TestMethod]
        public void randomTimeMinTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            var randomMin = game.getRandomTimeMin();
            Assert.AreEqual(500, randomMin);
        }


        //---------------------------------------------------------------
        //Tests that the constant RANDOM_TIME_MAX is 2000
        //---------------------------------------------------------------
        [TestMethod]
        public void randomTimeMaxTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            var randomMax = game.getRandomTimeMax();
            Assert.AreEqual(2000, randomMax);
        }


        //---------------------------------------------------------------
        //Tests that the constant MAX_TIME_TO_CLICK is 1200
        //---------------------------------------------------------------
        [TestMethod]
        public void maxTimeToClickTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            var maxTime = game.getMaxTimeToClick();
            Assert.AreEqual(1200, maxTime);
        }

        //---------------------------------------------------------------
        //Tests that the constant MAX_CLICKS is 10
        //---------------------------------------------------------------
        [TestMethod]
        public void maxClicksTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            var maxClicks = game.getMaxClicks();
            Assert.AreEqual(10, maxClicks);
        }

        #endregion

        #region GameIsLiveTests

        //---------------------------------------------------------------
        //Tests that the game is not over after less than MAX_CLICKS
        //---------------------------------------------------------------
        [TestMethod]
        public void gameNotOverMaxClicksTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.start();
            game.runGame();

            Assert.IsTrue(game.isGameLive());

            var maxClicks = game.getMaxClicks() - 1;
            for (var i = 0; i < maxClicks; i++)
            {
                game.calculateScore();
            }

            Assert.IsTrue(game.isGameLive());
        }

        //---------------------------------------------------------------
        //Tests that the game is over after MAX_CLICKS
        //---------------------------------------------------------------
        [TestMethod]
        public void gameOverMaxClicksTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.start();
            game.runGame();

            Assert.IsTrue(game.isGameLive());

            var maxClicks = game.getMaxClicks();
            for (var i = 0; i < maxClicks; i++)
            {
                game.calculateScore();
            }

            Assert.IsFalse(game.isGameLive());
        }


        #endregion


        //---------------------------------------------------------------
        //Tests that the runGame method sets the time to the current
        // stopwatch value, and stops the stopwatch
        //---------------------------------------------------------------
        [TestMethod]
        public void runGameTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.stopwatch.Start();
            game.runGame();
            Assert.IsFalse(game.stopwatch.IsRunning);
            Assert.AreEqual(game.getTime(),
                            game.stopwatch.ElapsedMilliseconds);
        }

        //---------------------------------------------------------------
        //Tests that the random time is within bounds
        //---------------------------------------------------------------
        [TestMethod]
        public void randomBetweenRange()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            var randomMin = game.getRandomTimeMin();
            var randomMax = game.getRandomTimeMax();
            var randTime = game.randomTime();
            Assert.IsTrue(randomMin <= randTime);
            Assert.IsTrue(randTime < randomMax);
        }
    }
}
