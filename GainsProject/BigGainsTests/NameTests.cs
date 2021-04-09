//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the Name storage class
//---------------------------------------------------------------
using System;
using GainsProject.Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BigGainsTests
{
    [TestClass]
    public class NameTests
    {    
        //---------------------------------------------------------------
        //Method to test setter and getter
        //---------------------------------------------------------------
        [TestMethod]
        public void NameTest()
        {
            NameClass nameTest = new NameClass();
            nameTest.setName("IAN");
            Assert.AreEqual("IAN", nameTest.getName());
        }
        //---------------------------------------------------------------
        //second Method to test setter and getter
        //---------------------------------------------------------------
        [TestMethod]
        public void NameTest2()
        {
            NameClass nameTest = new NameClass();
            nameTest.setName("IAN");
            nameTest.setName("$$$");
            Assert.AreEqual("$$$", nameTest.getName());
        }
    }
}
