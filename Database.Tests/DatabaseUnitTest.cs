using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace Database.Tests
{
    [TestClass()]
    public class DatabaseUnitTest : DatabaseTestClass
    {

        public DatabaseUnitTest()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        [TestMethod()]
        public void VerifyMyBankIAvailable()
        {
            DatabaseTestActions testActions = this.VerifyMyBankIAvailableData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            ExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            ExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            ExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction VerifyMyBankIAvailable_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseUnitTest));
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition LookForDatabaseName;
            this.VerifyMyBankIAvailableData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            VerifyMyBankIAvailable_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            LookForDatabaseName = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // VerifyMyBankIAvailableData
            // 
            this.VerifyMyBankIAvailableData.PosttestAction = null;
            this.VerifyMyBankIAvailableData.PretestAction = null;
            this.VerifyMyBankIAvailableData.TestAction = VerifyMyBankIAvailable_TestAction;
            // 
            // VerifyMyBankIAvailable_TestAction
            // 
            VerifyMyBankIAvailable_TestAction.Conditions.Add(LookForDatabaseName);
            resources.ApplyResources(VerifyMyBankIAvailable_TestAction, "VerifyMyBankIAvailable_TestAction");
            // 
            // LookForDatabaseName
            // 
            LookForDatabaseName.ColumnNumber = 1;
            LookForDatabaseName.Enabled = true;
            LookForDatabaseName.ExpectedValue = "1";
            LookForDatabaseName.Name = "LookForDatabaseName";
            LookForDatabaseName.NullExpected = false;
            LookForDatabaseName.ResultSet = 1;
            LookForDatabaseName.RowNumber = 1;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        private DatabaseTestActions VerifyMyBankIAvailableData;
    }
}
