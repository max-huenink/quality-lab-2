//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the SaveData struct
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GainsProject.Domain;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // Test the SaveData struct
    //---------------------------------------------------------------
    [TestClass]
    public class SaveDataTests
    {
        [TestMethod]
        //---------------------------------------------------------------
        //Make sure the the constructor works as well as the getters
        //along with it.
        //---------------------------------------------------------------
        public void testConstructorAndGetters()
        {
            DateTime dt = DateTime.Now;
            SaveData saveData = new SaveData(5, dt, "Nick");
            Assert.AreEqual(5, saveData.getScore());
            Assert.AreEqual(dt, saveData.getDt());
            Assert.AreEqual("Nick", saveData.getPlayerTag());
        }
    }
}
