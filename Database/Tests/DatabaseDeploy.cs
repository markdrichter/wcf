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

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Schema.UnitTesting.DatabaseTestAction CheckUsersView_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseDeploy));
            Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition;
            this.CheckUsersViewData = new Microsoft.Data.Schema.UnitTesting.DatabaseTestActions();
            CheckUsersView_TestAction = new Microsoft.Data.Schema.UnitTesting.DatabaseTestAction();
            notEmptyResultSetCondition = new Microsoft.Data.Schema.UnitTesting.Conditions.NotEmptyResultSetCondition();
            // 
            // CheckUsersView_TestAction
            // 
            CheckUsersView_TestAction.Conditions.Add(notEmptyResultSetCondition);
            resources.ApplyResources(CheckUsersView_TestAction, "CheckUsersView_TestAction");
            // 
            // notEmptyResultSetCondition
            // 
            notEmptyResultSetCondition.Enabled = true;
            notEmptyResultSetCondition.Name = "notEmptyResultSetCondition";
            notEmptyResultSetCondition.ResultSet = 1;
            // 
            // CheckUsersViewData
            // 
            this.CheckUsersViewData.PosttestAction = null;
            this.CheckUsersViewData.PretestAction = null;
            this.CheckUsersViewData.TestAction = CheckUsersView_TestAction;
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


        [TestMethod()]
        public void CheckUsersView()
        {
            DatabaseTestActions testActions = this.CheckUsersViewData;
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
        private DatabaseTestActions CheckUsersViewData;
    }
}
