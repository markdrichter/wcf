using Component_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Component_2.Test
{
    
    
    /// <summary>
    ///This is a test class for Class1Test and is intended
    ///to contain all Class1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Class1Test
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Class1 Constructor
        ///</summary>
        [TestMethod()]
        public void Class1ConstructorTest()
        {
            Class1 target = new Class1();
            Assert.IsInstanceOfType(target, typeof(Class1));
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            Class1 target = new Class1(); 
            const int expected = 10;
            int actual = target.Count();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetList
        ///</summary>
        [TestMethod()]
        public void GetListTest()
        {
            Class1 target = new Class1(); 
            IList<string> expected = new List<string>{"a","b","c"};
            IList<string> actual = target.GetList();
            Assert.AreEqual(expected[0], actual[0]);
        }
    }
}
