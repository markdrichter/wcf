using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.Schema.UnitTesting;
using Microsoft.Data.Schema.UnitTesting.Conditions;

namespace Database.Tests.Smoke
{
    [TestClass()]
    public class DatabaseDeploy : DatabaseTestClass
    {

        public DatabaseDeploy()
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
        public void Deploy()
        {
            DatabaseTestActions testActions = this.DeployData;
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
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Deploy_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDeploy));
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Deploy_PretestAction;
            Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition LookForDatabase;
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction Deploy_PosttestAction;
            Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            this.DeployData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            Deploy_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            Deploy_PretestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            LookForDatabase = new Microsoft.Data.Schema.UnitTesting.Conditions.ScalarValueCondition();
            Deploy_PosttestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            emptyResultSetCondition1 = new Microsoft.Data.Schema.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // Deploy_TestAction
            // 
            resources.ApplyResources(Deploy_TestAction, "Deploy_TestAction");
            // 
            // Deploy_PretestAction
            // 
            Deploy_PretestAction.Conditions.Add(LookForDatabase);
            resources.ApplyResources(Deploy_PretestAction, "Deploy_PretestAction");
            // 
            // LookForDatabase
            // 
            LookForDatabase.ColumnNumber = 1;
            LookForDatabase.Enabled = true;
            LookForDatabase.ExpectedValue = "1";
            LookForDatabase.Name = "LookForDatabase";
            LookForDatabase.NullExpected = false;
            LookForDatabase.ResultSet = 1;
            LookForDatabase.RowNumber = 1;
            // 
            // Deploy_PosttestAction
            // 
            Deploy_PosttestAction.Conditions.Add(emptyResultSetCondition1);
            resources.ApplyResources(Deploy_PosttestAction, "Deploy_PosttestAction");
            // 
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 1;
            // 
            // DeployData
            // 
            this.DeployData.PosttestAction = Deploy_PosttestAction;
            this.DeployData.PretestAction = Deploy_PretestAction;
            this.DeployData.TestAction = Deploy_TestAction;
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

        private DatabaseTestActions DeployData;
    }
}
