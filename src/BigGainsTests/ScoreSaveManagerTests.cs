//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: This class tests the ScoreSaveManagerTest
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GainsProject.Application;

namespace BigGainsTests
{
    //--------------------------------------------------------------------
    //this class tests the ScoreSaveManager
    //--------------------------------------------------------------------
    [TestClass]
    public class ScoreSaveManagerTests
    {
        //--------------------------------------------------------------------
        //this method is the test getScoreSave
        //--------------------------------------------------------------------
        [TestMethod]
        public void getScoreSave1()
        {
            string[] gameNames = ScoreSaveManager.getGameNames();
            //please don't instantiate a ScoreSave object
            //I am only doing it for test case
            ScoreSave scoreSave = new ScoreSave(gameNames[1]);
            ScoreSaveManager scoreSaveManager = 
                ScoreSaveManager.getScoreSaveManager();
            ScoreSave compareTooScoreSave = scoreSaveManager.getScoreSave(gameNames[1]);
            Assert.AreEqual(scoreSave.getNumGames(), compareTooScoreSave.getNumGames());
        }
        //--------------------------------------------------------------------
        //this method is the test getScoreSave
        //--------------------------------------------------------------------
        [TestMethod]
        public void getScoreSave2()
        {
            string[] gameNames = ScoreSaveManager.getGameNames();
            //please don't instantiate a ScoreSave object
            //I am only doing it for test case
            ScoreSave scoreSave = new ScoreSave(gameNames[0]);
            ScoreSaveManager scoreSaveManager =
                ScoreSaveManager.getScoreSaveManager();
            ScoreSave test = scoreSaveManager.getScoreSave("SpotTheScenery.txt");
            ScoreSave compareTooScoreSave = scoreSaveManager.getScoreSave(gameNames[0]);
            compareTooScoreSave.addScore(5, "Nick");
            Assert.AreNotEqual(scoreSave.getNumGames(), compareTooScoreSave.getNumGames());
        }
    }
}
