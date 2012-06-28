using WcfServiceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Service.Tests
{
    
    
    /// <summary>
    ///This is a test class for IService1IntegrationTest and is intended
    ///to contain all IService1IntegrationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Service1IntegrationTest
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


        internal virtual IService1 CreateIService1()
        {
            IService1 target = new Service1();
            return target;
        }

        /// <summary>
        ///A test for GetData
        ///</summary>
        [TestMethod()]
        public void GetDataIntegrationTest()
        {
            var target = CreateIService1(); 
            const int value = 0;
            var expected = string.Format("You entered: {0}", value);
            var actual = target.GetData(value);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetDataUsingDataContract
        ///</summary>
        [TestMethod()]
        public void GetDataUsingDataContractIntegrationTest()
        {
            var target = CreateIService1();
            var composite = new CompositeType {BoolValue = true};
            var expected = new CompositeType {StringValue = "Hello Suffix"};
            var actual = target.GetDataUsingDataContract(composite);
            Assert.AreEqual(expected.StringValue, actual.StringValue);
        }


        [TestMethod]
        public void FailOnPurpose()
        {
            Assert.Fail();
        }
    }
}
