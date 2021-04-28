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
        public void NegativeScoreCalculationLowBoundaryTest()
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
        public void NegativeScoreCalculationLowBoundaryTest2()
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
        public void NegativeScoreCalculationLowBoundaryTest3()
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
        public void NegativeScoreCalculationLowBoundaryTest4()
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
        public void NegativeScoreCalculationHighBoundaryTest()
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
        public void PerfectScoreCalculationLowBoundaryTest()
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
        public void PerfectScoreCalculationMiddleBoundaryTest()
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
        public void PerfectScoreCalculationHighBoundaryTest()
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
        public void ScoreCalculationLowBoundaryTest()
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
        public void ScoreCalculationLowBoundaryTest2()
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
        public void ScoreCalculationMiddleBoundaryTest()
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
        public void ScoreCalculationHighBoundaryTest()
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
        public void ScoreCalculationHighBoundaryTest2()
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
        public void ScoreCalculationWrongButtonBeforeTest()
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
        public void ScoreCalculationWrongButtonTest()
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
        public void ScoreCalculationWrongButtonAfterTest()
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
        public void TotalScoreOneUpdateTest()
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
        public void TotalScoreThreeUpdateTest()
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
        public void TotalScoreCalculateTest()
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

        //---------------------------------------------------------------
        //Tests that the runGame method sets the time to the current
        // stopwatch value, and stops the stopwatch
        //---------------------------------------------------------------
        [TestMethod]
        public void RunGameTest()
        {
            ArrowKeyGameManager game = new ArrowKeyGameManager();
            game.stopwatch.Start();
            game.runGame();
            Assert.IsFalse(game.stopwatch.IsRunning);
            Assert.AreEqual(game.getTime(), game.stopwatch.ElapsedMilliseconds);
        }
    }
}
