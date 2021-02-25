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
    }
}
