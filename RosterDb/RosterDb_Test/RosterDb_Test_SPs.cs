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
    public class RosterDb_Test_SPs : SqlDatabaseTestClass
    {

        public RosterDb_Test_SPs()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_address_book_create_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RosterDb_Test_SPs));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_log_errorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_register_user_contact_listTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_create_address_bookTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_create_address_book_asyncTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_param_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_NULL_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_single_row_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_multy_row_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_address_book_entry_save_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_save_address_book_entryTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition16;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition17;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition18;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_save_address_book_entry_asyncTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            this.dbo_log_errorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_register_user_contact_listTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_create_address_bookTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_create_address_book_asyncTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_resolve_email_identificator_param_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_resolve_email_identificator_NULL_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_resolve_email_identificator_multy_row_TestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_save_address_book_entryTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_save_address_book_entry_asyncTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_address_book_create_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_log_errorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_register_user_contact_listTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_create_address_bookTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            emptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_create_address_book_asyncTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_resolve_email_identificator_param_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            emptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            dbo_resolve_email_identificator_NULL_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_resolve_email_identificator_single_row_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_resolve_email_identificator_multy_row_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            emptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_address_book_entry_save_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_save_address_book_entryTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition16 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition17 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition18 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_save_address_book_entry_asyncTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // dbo_address_book_create_request_message_handlerTest_TestAction
            // 
            dbo_address_book_create_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition3);
            dbo_address_book_create_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition2);
            dbo_address_book_create_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition6);
            dbo_address_book_create_request_message_handlerTest_TestAction.Conditions.Add(expectedSchemaCondition3);
            resources.ApplyResources(dbo_address_book_create_request_message_handlerTest_TestAction, "dbo_address_book_create_request_message_handlerTest_TestAction");
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "1";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "1";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 2;
            scalarValueCondition2.RowNumber = 1;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "1";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 3;
            scalarValueCondition6.RowNumber = 1;
            // 
            // expectedSchemaCondition3
            // 
            expectedSchemaCondition3.Enabled = true;
            expectedSchemaCondition3.Name = "expectedSchemaCondition3";
            resources.ApplyResources(expectedSchemaCondition3, "expectedSchemaCondition3");
            expectedSchemaCondition3.Verbose = false;
            // 
            // dbo_log_errorTest_TestAction
            // 
            dbo_log_errorTest_TestAction.Conditions.Add(scalarValueCondition4);
            dbo_log_errorTest_TestAction.Conditions.Add(scalarValueCondition5);
            dbo_log_errorTest_TestAction.Conditions.Add(expectedSchemaCondition4);
            resources.ApplyResources(dbo_log_errorTest_TestAction, "dbo_log_errorTest_TestAction");
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "0";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 2;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "Opt: 0|Err: 0|Svr: 0|Stt: 0|Ln : 0|Prc: NULL|Msg: NULL|";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // expectedSchemaCondition4
            // 
            expectedSchemaCondition4.Enabled = true;
            expectedSchemaCondition4.Name = "expectedSchemaCondition4";
            resources.ApplyResources(expectedSchemaCondition4, "expectedSchemaCondition4");
            expectedSchemaCondition4.Verbose = false;
            // 
            // dbo_register_user_contact_listTest_TestAction
            // 
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(dbo_register_user_contact_listTest_TestAction, "dbo_register_user_contact_listTest_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // dbo_create_address_bookTest_TestAction
            // 
            dbo_create_address_bookTest_TestAction.Conditions.Add(scalarValueCondition7);
            dbo_create_address_bookTest_TestAction.Conditions.Add(scalarValueCondition8);
            dbo_create_address_bookTest_TestAction.Conditions.Add(emptyResultSetCondition3);
            dbo_create_address_bookTest_TestAction.Conditions.Add(emptyResultSetCondition4);
            dbo_create_address_bookTest_TestAction.Conditions.Add(expectedSchemaCondition2);
            resources.ApplyResources(dbo_create_address_bookTest_TestAction, "dbo_create_address_bookTest_TestAction");
            // 
            // scalarValueCondition7
            // 
            scalarValueCondition7.ColumnNumber = 1;
            scalarValueCondition7.Enabled = true;
            scalarValueCondition7.ExpectedValue = "1";
            scalarValueCondition7.Name = "scalarValueCondition7";
            scalarValueCondition7.NullExpected = false;
            scalarValueCondition7.ResultSet = 1;
            scalarValueCondition7.RowNumber = 1;
            // 
            // scalarValueCondition8
            // 
            scalarValueCondition8.ColumnNumber = 1;
            scalarValueCondition8.Enabled = true;
            scalarValueCondition8.ExpectedValue = "1";
            scalarValueCondition8.Name = "scalarValueCondition8";
            scalarValueCondition8.NullExpected = false;
            scalarValueCondition8.ResultSet = 2;
            scalarValueCondition8.RowNumber = 1;
            // 
            // emptyResultSetCondition3
            // 
            emptyResultSetCondition3.Enabled = true;
            emptyResultSetCondition3.Name = "emptyResultSetCondition3";
            emptyResultSetCondition3.ResultSet = 3;
            // 
            // emptyResultSetCondition4
            // 
            emptyResultSetCondition4.Enabled = true;
            emptyResultSetCondition4.Name = "emptyResultSetCondition4";
            emptyResultSetCondition4.ResultSet = 4;
            // 
            // expectedSchemaCondition2
            // 
            expectedSchemaCondition2.Enabled = true;
            expectedSchemaCondition2.Name = "expectedSchemaCondition2";
            resources.ApplyResources(expectedSchemaCondition2, "expectedSchemaCondition2");
            expectedSchemaCondition2.Verbose = false;
            // 
            // dbo_create_address_book_asyncTest_TestAction
            // 
            dbo_create_address_book_asyncTest_TestAction.Conditions.Add(scalarValueCondition9);
            resources.ApplyResources(dbo_create_address_book_asyncTest_TestAction, "dbo_create_address_book_asyncTest_TestAction");
            // 
            // scalarValueCondition9
            // 
            scalarValueCondition9.ColumnNumber = 1;
            scalarValueCondition9.Enabled = true;
            scalarValueCondition9.ExpectedValue = "1";
            scalarValueCondition9.Name = "scalarValueCondition9";
            scalarValueCondition9.NullExpected = false;
            scalarValueCondition9.ResultSet = 1;
            scalarValueCondition9.RowNumber = 1;
            // 
            // dbo_resolve_email_identificator_param_Test_TestAction
            // 
            dbo_resolve_email_identificator_param_Test_TestAction.Conditions.Add(rowCountCondition1);
            dbo_resolve_email_identificator_param_Test_TestAction.Conditions.Add(rowCountCondition2);
            dbo_resolve_email_identificator_param_Test_TestAction.Conditions.Add(emptyResultSetCondition1);
            resources.ApplyResources(dbo_resolve_email_identificator_param_Test_TestAction, "dbo_resolve_email_identificator_param_Test_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 2;
            rowCountCondition2.RowCount = 1;
            // 
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 3;
            // 
            // dbo_resolve_email_identificator_NULL_Test_TestAction
            // 
            dbo_resolve_email_identificator_NULL_Test_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_resolve_email_identificator_NULL_Test_TestAction, "dbo_resolve_email_identificator_NULL_Test_TestAction");
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "0";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // dbo_resolve_email_identificator_single_row_Test_TestAction
            // 
            dbo_resolve_email_identificator_single_row_Test_TestAction.Conditions.Add(inconclusiveCondition10);
            resources.ApplyResources(dbo_resolve_email_identificator_single_row_Test_TestAction, "dbo_resolve_email_identificator_single_row_Test_TestAction");
            // 
            // inconclusiveCondition10
            // 
            inconclusiveCondition10.Enabled = true;
            inconclusiveCondition10.Name = "inconclusiveCondition10";
            // 
            // dbo_resolve_email_identificator_multy_row_Test_TestAction
            // 
            dbo_resolve_email_identificator_multy_row_Test_TestAction.Conditions.Add(inconclusiveCondition11);
            resources.ApplyResources(dbo_resolve_email_identificator_multy_row_Test_TestAction, "dbo_resolve_email_identificator_multy_row_Test_TestAction");
            // 
            // inconclusiveCondition11
            // 
            inconclusiveCondition11.Enabled = true;
            inconclusiveCondition11.Name = "inconclusiveCondition11";
            // 
            // dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction
            // 
            dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction.Conditions.Add(rowCountCondition3);
            dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction.Conditions.Add(emptyResultSetCondition2);
            dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction, "dbo_resolve_email_identificator_param_and_multy_row_Test_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 1;
            // 
            // emptyResultSetCondition2
            // 
            emptyResultSetCondition2.Enabled = true;
            emptyResultSetCondition2.Name = "emptyResultSetCondition2";
            emptyResultSetCondition2.ResultSet = 2;
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // dbo_address_book_entry_save_request_message_handlerTest_TestAction
            // 
            dbo_address_book_entry_save_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition8);
            dbo_address_book_entry_save_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition9);
            dbo_address_book_entry_save_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition10);
            dbo_address_book_entry_save_request_message_handlerTest_TestAction.Conditions.Add(expectedSchemaCondition5);
            resources.ApplyResources(dbo_address_book_entry_save_request_message_handlerTest_TestAction, "dbo_address_book_entry_save_request_message_handlerTest_TestAction");
            // 
            // emptyResultSetCondition8
            // 
            emptyResultSetCondition8.Enabled = true;
            emptyResultSetCondition8.Name = "emptyResultSetCondition8";
            emptyResultSetCondition8.ResultSet = 1;
            // 
            // emptyResultSetCondition9
            // 
            emptyResultSetCondition9.Enabled = true;
            emptyResultSetCondition9.Name = "emptyResultSetCondition9";
            emptyResultSetCondition9.ResultSet = 2;
            // 
            // emptyResultSetCondition10
            // 
            emptyResultSetCondition10.Enabled = true;
            emptyResultSetCondition10.Name = "emptyResultSetCondition10";
            emptyResultSetCondition10.ResultSet = 3;
            // 
            // expectedSchemaCondition5
            // 
            expectedSchemaCondition5.Enabled = true;
            expectedSchemaCondition5.Name = "expectedSchemaCondition5";
            resources.ApplyResources(expectedSchemaCondition5, "expectedSchemaCondition5");
            expectedSchemaCondition5.Verbose = false;
            // 
            // dbo_save_address_book_entryTest_TestAction
            // 
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition5);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition6);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition7);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition16);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition17);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition18);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(expectedSchemaCondition6);
            resources.ApplyResources(dbo_save_address_book_entryTest_TestAction, "dbo_save_address_book_entryTest_TestAction");
            // 
            // emptyResultSetCondition5
            // 
            emptyResultSetCondition5.Enabled = true;
            emptyResultSetCondition5.Name = "emptyResultSetCondition5";
            emptyResultSetCondition5.ResultSet = 1;
            // 
            // emptyResultSetCondition6
            // 
            emptyResultSetCondition6.Enabled = true;
            emptyResultSetCondition6.Name = "emptyResultSetCondition6";
            emptyResultSetCondition6.ResultSet = 2;
            // 
            // emptyResultSetCondition7
            // 
            emptyResultSetCondition7.Enabled = true;
            emptyResultSetCondition7.Name = "emptyResultSetCondition7";
            emptyResultSetCondition7.ResultSet = 3;
            // 
            // emptyResultSetCondition16
            // 
            emptyResultSetCondition16.Enabled = true;
            emptyResultSetCondition16.Name = "emptyResultSetCondition16";
            emptyResultSetCondition16.ResultSet = 4;
            // 
            // emptyResultSetCondition17
            // 
            emptyResultSetCondition17.Enabled = true;
            emptyResultSetCondition17.Name = "emptyResultSetCondition17";
            emptyResultSetCondition17.ResultSet = 5;
            // 
            // emptyResultSetCondition18
            // 
            emptyResultSetCondition18.Enabled = true;
            emptyResultSetCondition18.Name = "emptyResultSetCondition18";
            emptyResultSetCondition18.ResultSet = 6;
            // 
            // expectedSchemaCondition6
            // 
            expectedSchemaCondition6.Enabled = true;
            expectedSchemaCondition6.Name = "expectedSchemaCondition6";
            resources.ApplyResources(expectedSchemaCondition6, "expectedSchemaCondition6");
            expectedSchemaCondition6.Verbose = false;
            // 
            // dbo_save_address_book_entry_asyncTest_TestAction
            // 
            dbo_save_address_book_entry_asyncTest_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(dbo_save_address_book_entry_asyncTest_TestAction, "dbo_save_address_book_entry_asyncTest_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // dbo_log_errorTestData
            // 
            this.dbo_log_errorTestData.PosttestAction = null;
            this.dbo_log_errorTestData.PretestAction = null;
            this.dbo_log_errorTestData.TestAction = dbo_log_errorTest_TestAction;
            // 
            // dbo_register_user_contact_listTestData
            // 
            this.dbo_register_user_contact_listTestData.PosttestAction = null;
            this.dbo_register_user_contact_listTestData.PretestAction = null;
            this.dbo_register_user_contact_listTestData.TestAction = dbo_register_user_contact_listTest_TestAction;
            // 
            // dbo_create_address_bookTestData
            // 
            this.dbo_create_address_bookTestData.PosttestAction = null;
            this.dbo_create_address_bookTestData.PretestAction = null;
            this.dbo_create_address_bookTestData.TestAction = dbo_create_address_bookTest_TestAction;
            // 
            // dbo_create_address_book_asyncTestData
            // 
            this.dbo_create_address_book_asyncTestData.PosttestAction = null;
            this.dbo_create_address_book_asyncTestData.PretestAction = null;
            this.dbo_create_address_book_asyncTestData.TestAction = dbo_create_address_book_asyncTest_TestAction;
            // 
            // dbo_resolve_email_identificator_param_TestData
            // 
            this.dbo_resolve_email_identificator_param_TestData.PosttestAction = null;
            this.dbo_resolve_email_identificator_param_TestData.PretestAction = null;
            this.dbo_resolve_email_identificator_param_TestData.TestAction = dbo_resolve_email_identificator_param_Test_TestAction;
            // 
            // dbo_resolve_email_identificator_NULL_TestData
            // 
            this.dbo_resolve_email_identificator_NULL_TestData.PosttestAction = null;
            this.dbo_resolve_email_identificator_NULL_TestData.PretestAction = null;
            this.dbo_resolve_email_identificator_NULL_TestData.TestAction = dbo_resolve_email_identificator_NULL_Test_TestAction;
            // 
            // dbo_resolve_email_identificator_multy_row_TestData
            // 
            this.dbo_resolve_email_identificator_multy_row_TestData.PosttestAction = null;
            this.dbo_resolve_email_identificator_multy_row_TestData.PretestAction = null;
            this.dbo_resolve_email_identificator_multy_row_TestData.TestAction = dbo_resolve_email_identificator_multy_row_Test_TestAction;
            // 
            // dbo_save_address_book_entryTestData
            // 
            this.dbo_save_address_book_entryTestData.PosttestAction = null;
            this.dbo_save_address_book_entryTestData.PretestAction = null;
            this.dbo_save_address_book_entryTestData.TestAction = dbo_save_address_book_entryTest_TestAction;
            // 
            // dbo_save_address_book_entry_asyncTestData
            // 
            this.dbo_save_address_book_entry_asyncTestData.PosttestAction = null;
            this.dbo_save_address_book_entry_asyncTestData.PretestAction = null;
            this.dbo_save_address_book_entry_asyncTestData.TestAction = dbo_save_address_book_entry_asyncTest_TestAction;
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
        public void dbo_log_errorTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_log_errorTestData;
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
        public void dbo_register_user_contact_listTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_register_user_contact_listTestData;
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
        public void dbo_create_address_bookTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_create_address_bookTestData;
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
        public void dbo_create_address_book_asyncTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_create_address_book_asyncTestData;
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
        public void dbo_resolve_email_identificator_param_Test()
        {
            SqlDatabaseTestActions testActions = this.dbo_resolve_email_identificator_param_TestData;
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
        public void dbo_resolve_email_identificator_NULL_Test()
        {
            SqlDatabaseTestActions testActions = this.dbo_resolve_email_identificator_NULL_TestData;
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
        public void dbo_resolve_email_identificator_multy_row_Test()
        {
            SqlDatabaseTestActions testActions = this.dbo_resolve_email_identificator_multy_row_TestData;
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
        public void dbo_save_address_book_entryTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_save_address_book_entryTestData;
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
        public void dbo_save_address_book_entry_asyncTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_save_address_book_entry_asyncTestData;
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
        public void dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookaction_register_request_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookaction_register_request_message_senderTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookaction_register_request_message_senderTestData;
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
        public void dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData;
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
        public void dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData;
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
        public void dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData;
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
        public void dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData;
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
        public void dbo_prepare_address_book_entry_xml_for_savingTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_prepare_address_book_entry_xml_for_savingTestData;
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

private SqlDatabaseTestActions dbo_log_errorTestData;
private SqlDatabaseTestActions dbo_register_user_contact_listTestData;
private SqlDatabaseTestActions dbo_create_address_bookTestData;
private SqlDatabaseTestActions dbo_create_address_book_asyncTestData;
private SqlDatabaseTestActions dbo_resolve_email_identificator_param_TestData;
private SqlDatabaseTestActions dbo_resolve_email_identificator_NULL_TestData;
private SqlDatabaseTestActions dbo_resolve_email_identificator_multy_row_TestData;
private SqlDatabaseTestActions dbo_save_address_book_entryTestData;
private SqlDatabaseTestActions dbo_save_address_book_entry_asyncTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookaction_register_request_message_senderTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData;
private SqlDatabaseTestActions dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData;
private SqlDatabaseTestActions dbo_prepare_address_book_entry_xml_for_savingTestData;
    }
}
