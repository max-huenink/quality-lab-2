//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: This class tests the score display manager's logic
//---------------------------------------------------------------

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using GainsProject.Application;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // this class tests the logic for the score display manager
    //---------------------------------------------------------------
    [TestClass]
    public class ScoreDisplayTests
    {
        //---------------------------------------------------------------
        // this method tests the time sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void timeScortedTest1()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setScoreSorted();
            sd.setTimeSorted();
            bool timeSorted = false;
            if(scoreSave.getSaveDataList()[0].getDt() < 
                scoreSave.getSaveDataList()[1].getDt())
            {
                timeSorted = true;
            }
            Assert.IsFalse(sd.reverseScore);
            Assert.IsTrue(timeSorted);
        }
        //---------------------------------------------------------------
        // this method tests the time sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void timeScortedTest2()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setTimeSorted();
            bool timeSorted = false;
            if (scoreSave.getSaveDataList()[scoreSave.getSaveDataList().Count - 1].getDt() <
                scoreSave.getSaveDataList()[1].getDt())
            {
                timeSorted = true;
            }
            Assert.IsTrue(sd.reverseScore);
            Assert.IsFalse(timeSorted);
        }
        //---------------------------------------------------------------
        // this method tests the tag sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void tagScortedTest1()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setTagSorted();
            bool tagSorted = false;
            if(String.Compare(scoreSave.getSaveDataList()[0].getPlayerTag(), 
                scoreSave.getSaveDataList()[1].getPlayerTag(), 
                comparisonType: StringComparison.OrdinalIgnoreCase) == -1 ||
                String.Compare(scoreSave.getSaveDataList()[0].getPlayerTag(),
                scoreSave.getSaveDataList()[1].getPlayerTag(),
                comparisonType: StringComparison.OrdinalIgnoreCase) == 0)
            {
                tagSorted = true;
            }
            Assert.IsFalse(sd.reverseScore);
            Assert.IsTrue(tagSorted);
        }
        //---------------------------------------------------------------
        // this method tests the tag sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void tagScortedTest2()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setTagSorted();
            sd.setTagSorted();
            bool tagSorted = false;
            if (String.Compare(scoreSave.getSaveDataList()[0].getPlayerTag(),
                scoreSave.getSaveDataList()[1].getPlayerTag(),
                comparisonType: StringComparison.OrdinalIgnoreCase) == -1 ||
                String.Compare(scoreSave.getSaveDataList()[0].getPlayerTag(),
                scoreSave.getSaveDataList()[1].getPlayerTag(),
                comparisonType: StringComparison.OrdinalIgnoreCase) == 0)
            {
                tagSorted = true;
            }
            Assert.IsTrue(sd.reverseScore);
        }
        //---------------------------------------------------------------
        // this method tests the score sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreScortedTest1()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setScoreSorted();
            sd.setScoreSorted();
            sd.setScoreSorted();
            bool scoreSorted = false;
            if (scoreSave.getSaveDataList()[0].getScore() <=
                scoreSave.getSaveDataList()[1].getScore())
            {
                scoreSorted = true;
            }
            Assert.IsFalse(sd.reverseScore);
            Assert.IsTrue(scoreSorted);
        }
        //---------------------------------------------------------------
        // this method tests the score sorted method
        //---------------------------------------------------------------
        [TestMethod]
        public void scoreScortedTest2()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            sd.setScoreSorted();
            sd.setScoreSorted();
            bool scoreSorted = false;
            if (scoreSave.getSaveDataList()[0].getScore() <
                scoreSave.getSaveDataList()[1].getScore())
            {
                scoreSorted = true;
            }
            Assert.IsTrue(sd.reverseScore);
        }
        //---------------------------------------------------------------
        // this method tests the get score string method
        //---------------------------------------------------------------
        [TestMethod]
        public void getScoreTest()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            string scoreString = sd.getScore();
            string dtString = sd.getTime();
            string tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
            sd.setTimeSorted();
            scoreString = sd.getScore();
            dtString = sd.getTime();
            tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
            sd.setTagSorted();
            scoreString = sd.getScore();
            dtString = sd.getTime();
            tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
            sd.setTagSorted();
            scoreString = sd.getScore();
            dtString = sd.getTime();
            tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
            sd.setScoreSorted();
            scoreString = sd.getScore();
            dtString = sd.getTime();
            tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
            sd.setScoreSorted();
            scoreString = sd.getScore();
            dtString = sd.getTime();
            tagString = sd.getTag();
            Assert.AreNotEqual(scoreString, null);
        }
        //---------------------------------------------------------------
        // this method tests get num games
        //---------------------------------------------------------------
        [TestMethod]
        public void getNumGamesTest()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            Assert.AreNotEqual(0, sd.getNumGames());
        }
        //---------------------------------------------------------------
        // this method tests avg points
        //---------------------------------------------------------------
        [TestMethod]
        public void getAvgGamePointsTest()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            addScores();
            ScoreDisplay sd = new ScoreDisplay(scoreSave);
            Assert.AreNotEqual(0, sd.getAvgGamePoints());
        }
        //---------------------------------------------------------------
        // this method makes sure there are at least 5 save data points
        // for the test methods
        //---------------------------------------------------------------
        public void addScores()
        {
            ScoreSaveManager ssm = ScoreSaveManager.getScoreSaveManager();
            ScoreSave scoreSave = ssm.getScoreSave("testGame1.txt");
            if (scoreSave.getNumGames() < 5)
            {
                Random random = new Random();
                for(int i = 0; i < 5; i++)
                {
                    scoreSave.addScore(random.Next(0, 1000), ("Test" + i));
                    Thread.Sleep(1000);
                }
                scoreSave.addScore(1231, "beans");
            }
            scoreSave.addScore(1231, "beans");
            scoreSave.addScore(3467, "zzzzz");
            scoreSave.addScore(0, "yheg");
        }
    }
}
