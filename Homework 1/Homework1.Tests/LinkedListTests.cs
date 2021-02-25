using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework1;
namespace Homework1.Tests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public  void IsEmptyTest1()
        {
            LinkedList<int> testList = new LinkedList<int>();
            Assert.IsTrue(testList.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyTest2()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.First = new LinkedListNode<int>();
            Assert.IsFalse(testList.IsEmpty());
        }
        [TestMethod]
        public void AddToHead()
        {
            LinkedList<int> testList = new LinkedList<int>();
            int testInt = 10;
            testList.AddToHead(testInt);
            Assert.AreNotEqual(testList.First, null);
            Assert.AreEqual(testList.First.Data, testInt);
        }
        [TestMethod]
        public void AddToTail()
        {
            LinkedList<int> testList = new LinkedList<int>();
            int testInt = 10;
            testList.AddToTail(testInt);
            Assert.AreNotEqual(testList.First, null);
            Assert.AreEqual(testList.First.Data, testInt);
        }
        [TestMethod]
        public void FindDoesExistTest()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.AddToHead(4);
            testList.AddToHead(9);
            testList.AddToHead(5);
            testList.AddToHead(6);
            testList.AddToHead(7);
            Assert.IsTrue(testList.Find(5) == 2);
        }

        [TestMethod]
        public void FindDoesNotExistTest()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.AddToHead(4);
            testList.AddToHead(9);
            testList.AddToHead(5);
            testList.AddToHead(6);
            testList.AddToHead(7);
            Assert.IsTrue(testList.Find(8) == -1);
        }
        [TestMethod]

        public void CreateListTest()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.CreateList(5);
            Assert.AreEqual(testList.First.Data, 5);
        }
    }

}
