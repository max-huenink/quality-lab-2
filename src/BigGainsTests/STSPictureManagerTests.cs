//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: to test the STSPictureManager
//---------------------------------------------------------------
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using GainsProject.Domain;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // This class tests the STSPictureManager class
    //---------------------------------------------------------------
    [TestClass]
    public class STSPictureManagerTests
    {
        //---------------------------------------------------------------
        // This method tests that the descriptors gets filled
        //---------------------------------------------------------------
        [TestMethod]
        public void testFillDescriptors1()
        {
            SpotTheSceneryPictureDescriptor stspd
                = new SpotTheSceneryPictureDescriptor();
            stspd.fillDescriptors();
            Assert.AreEqual(stspd.getDescriptors()["artic_bear"][0], "a bear");
        }

        //---------------------------------------------------------------
        // This method tests that the descriptors gets filled
        //---------------------------------------------------------------
        [TestMethod]
        public void testFillDescriptors2()
        {
            SpotTheSceneryPictureDescriptor stspd
                = new SpotTheSceneryPictureDescriptor();
            Assert.AreEqual(stspd.getDescriptors().Count, 0);
        }

        //---------------------------------------------------------------
        // This method tests that the picture list gets filled
        //---------------------------------------------------------------
        [TestMethod]
        public void testFillPictureList1()
        {
            SpotTheSceneryPictureDescriptor stspd
                = new SpotTheSceneryPictureDescriptor();
            stspd.fillPictureList();
            Assert.AreNotEqual(stspd.getPictureList()[0], null);
        }

        //---------------------------------------------------------------
        // This method tests that the picture list gets filled
        //---------------------------------------------------------------
        [TestMethod]
        public void testFillPictureList2()
        {
            SpotTheSceneryPictureDescriptor stspd
                = new SpotTheSceneryPictureDescriptor();
            Assert.AreEqual(stspd.getPictureList().Count, 0);
        }
    }
}
