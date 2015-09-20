using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RosterDb_Test
{
    [TestClass()]
    public class RosterDb_Test_Functions : SqlDatabaseTestClass
    {

        public RosterDb_Test_Functions()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RosterDb_Test_Functions));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction test_fn_generate_emailsTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction test_fn_get_newid_nvarcharTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction test_fn_generate_address_book_entriesTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_fn_hash_emailTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition2;
            this.test_fn_generate_emailsTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.test_fn_get_newid_nvarcharTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.test_fn_generate_address_book_entriesTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_fn_hash_emailTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_fn_generate_emailsTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            expectedSchemaCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            test_fn_get_newid_nvarcharTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            test_fn_generate_address_book_entriesTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            expectedSchemaCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_fn_hash_emailTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // test_fn_generate_emailsTest_TestAction
            // 
            test_fn_generate_emailsTest_TestAction.Conditions.Add(rowCountCondition1);
            test_fn_generate_emailsTest_TestAction.Conditions.Add(expectedSchemaCondition3);
            resources.ApplyResources(test_fn_generate_emailsTest_TestAction, "test_fn_generate_emailsTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 4;
            // 
            // expectedSchemaCondition3
            // 
            expectedSchemaCondition3.Enabled = true;
            expectedSchemaCondition3.Name = "expectedSchemaCondition3";
            resources.ApplyResources(expectedSchemaCondition3, "expectedSchemaCondition3");
            expectedSchemaCondition3.Verbose = false;
            // 
            // test_fn_get_newid_nvarcharTest_TestAction
            // 
            test_fn_get_newid_nvarcharTest_TestAction.Conditions.Add(expectedSchemaCondition2);
            resources.ApplyResources(test_fn_get_newid_nvarcharTest_TestAction, "test_fn_get_newid_nvarcharTest_TestAction");
            // 
            // expectedSchemaCondition2
            // 
            expectedSchemaCondition2.Enabled = true;
            expectedSchemaCondition2.Name = "expectedSchemaCondition2";
            resources.ApplyResources(expectedSchemaCondition2, "expectedSchemaCondition2");
            expectedSchemaCondition2.Verbose = false;
            // 
            // test_fn_generate_address_book_entriesTest_TestAction
            // 
            test_fn_generate_address_book_entriesTest_TestAction.Conditions.Add(rowCountCondition2);
            test_fn_generate_address_book_entriesTest_TestAction.Conditions.Add(expectedSchemaCondition4);
            resources.ApplyResources(test_fn_generate_address_book_entriesTest_TestAction, "test_fn_generate_address_book_entriesTest_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 4;
            // 
            // expectedSchemaCondition4
            // 
            expectedSchemaCondition4.Enabled = true;
            expectedSchemaCondition4.Name = "expectedSchemaCondition4";
            resources.ApplyResources(expectedSchemaCondition4, "expectedSchemaCondition4");
            expectedSchemaCondition4.Verbose = false;
            // 
            // dbo_fn_hash_emailTest_TestAction
            // 
            dbo_fn_hash_emailTest_TestAction.Conditions.Add(emptyResultSetCondition2);
            resources.ApplyResources(dbo_fn_hash_emailTest_TestAction, "dbo_fn_hash_emailTest_TestAction");
            // 
            // emptyResultSetCondition2
            // 
            emptyResultSetCondition2.Enabled = true;
            emptyResultSetCondition2.Name = "emptyResultSetCondition2";
            emptyResultSetCondition2.ResultSet = 1;
            // 
            // test_fn_generate_emailsTestData
            // 
            this.test_fn_generate_emailsTestData.PosttestAction = null;
            this.test_fn_generate_emailsTestData.PretestAction = null;
            this.test_fn_generate_emailsTestData.TestAction = test_fn_generate_emailsTest_TestAction;
            // 
            // test_fn_get_newid_nvarcharTestData
            // 
            this.test_fn_get_newid_nvarcharTestData.PosttestAction = null;
            this.test_fn_get_newid_nvarcharTestData.PretestAction = null;
            this.test_fn_get_newid_nvarcharTestData.TestAction = test_fn_get_newid_nvarcharTest_TestAction;
            // 
            // test_fn_generate_address_book_entriesTestData
            // 
            this.test_fn_generate_address_book_entriesTestData.PosttestAction = null;
            this.test_fn_generate_address_book_entriesTestData.PretestAction = null;
            this.test_fn_generate_address_book_entriesTestData.TestAction = test_fn_generate_address_book_entriesTest_TestAction;
            // 
            // dbo_fn_hash_emailTestData
            // 
            this.dbo_fn_hash_emailTestData.PosttestAction = null;
            this.dbo_fn_hash_emailTestData.PretestAction = null;
            this.dbo_fn_hash_emailTestData.TestAction = dbo_fn_hash_emailTest_TestAction;
            // 
            // RosterDb_Test_Functions
            // 
            this.TestInitializeAction = testInitializeAction;
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
        public void test_fn_generate_emailsTest()
        {
            SqlDatabaseTestActions testActions = this.test_fn_generate_emailsTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        [TestMethod()]
        public void test_fn_get_newid_nvarcharTest()
        {
            SqlDatabaseTestActions testActions = this.test_fn_get_newid_nvarcharTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void test_fn_generate_address_book_entriesTest()
        {
            SqlDatabaseTestActions testActions = this.test_fn_generate_address_book_entriesTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void dbo_fn_hash_emailTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_fn_hash_emailTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions test_fn_generate_emailsTestData;
        private SqlDatabaseTestActions test_fn_get_newid_nvarcharTestData;
        private SqlDatabaseTestActions test_fn_generate_address_book_entriesTestData;
        private SqlDatabaseTestActions dbo_fn_hash_emailTestData;
    }
}
