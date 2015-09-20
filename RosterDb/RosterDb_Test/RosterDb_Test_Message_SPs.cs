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
    public class RosterDb_Test_Message_SPs : SqlDatabaseTestClass
    {

        public RosterDb_Test_Message_SPs()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RosterDb_Test_Message_SPs));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            this.dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookaction_register_request_message_senderTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            emptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            // 
            // dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestA" +
                    "ction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition7);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition7);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition8);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition8);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition9);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition9);
            dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction.Conditions.Add(expectedSchemaCondition2);
            resources.ApplyResources(dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_Tes" +
                    "tAction");
            // 
            // rowCountCondition7
            // 
            rowCountCondition7.Enabled = true;
            rowCountCondition7.Name = "rowCountCondition7";
            rowCountCondition7.ResultSet = 1;
            rowCountCondition7.RowCount = 1;
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
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 2;
            rowCountCondition8.RowCount = 1;
            // 
            // scalarValueCondition8
            // 
            scalarValueCondition8.ColumnNumber = 1;
            scalarValueCondition8.Enabled = true;
            scalarValueCondition8.ExpectedValue = "1";
            scalarValueCondition8.Name = "scalarValueCondition8";
            scalarValueCondition8.NullExpected = false;
            scalarValueCondition8.ResultSet = 1;
            scalarValueCondition8.RowNumber = 1;
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 3;
            rowCountCondition9.RowCount = 1;
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
            // expectedSchemaCondition2
            // 
            expectedSchemaCondition2.Enabled = true;
            expectedSchemaCondition2.Name = "expectedSchemaCondition2";
            resources.ApplyResources(expectedSchemaCondition2, "expectedSchemaCondition2");
            expectedSchemaCondition2.Verbose = false;
            // 
            // dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction
            // 
            dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction.Conditions.Add(rowCountCondition4);
            dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction, "dbo_companyname_roster_addressbookaction_register_request_message_senderTest_Test" +
                    "Action");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 1;
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "1";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_Tes" +
                    "tAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction.Conditions.Add(inconclusiveCondition5);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_me" +
                    "ssage_handlerTest_TestAction");
            // 
            // inconclusiveCondition5
            // 
            inconclusiveCondition5.Enabled = true;
            inconclusiveCondition5.Name = "inconclusiveCondition5";
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction.Conditions.Add(rowCountCondition3);
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction, "dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_me" +
                    "ssage_senderTest_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 1;
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
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction.Conditions.Add(inconclusiveCondition7);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_req" +
                    "uest_message_handlerTest_TestAction");
            // 
            // inconclusiveCondition7
            // 
            inconclusiveCondition7.Enabled = true;
            inconclusiveCondition7.Name = "inconclusiveCondition7";
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction, "dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_req" +
                    "uest_message_senderTest_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "1";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction.Conditions.Add(inconclusiveCondition9);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_" +
                    "TestAction");
            // 
            // inconclusiveCondition9
            // 
            inconclusiveCondition9.Enabled = true;
            inconclusiveCondition9.Name = "inconclusiveCondition9";
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition5);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition5);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition1);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition2);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(emptyResultSetCondition3);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition6);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition6);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(rowCountCondition10);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(scalarValueCondition10);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction, "dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTes" +
                    "t_TestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 1;
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "1";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 2;
            // 
            // emptyResultSetCondition2
            // 
            emptyResultSetCondition2.Enabled = true;
            emptyResultSetCondition2.Name = "emptyResultSetCondition2";
            emptyResultSetCondition2.ResultSet = 3;
            // 
            // emptyResultSetCondition3
            // 
            emptyResultSetCondition3.Enabled = true;
            emptyResultSetCondition3.Name = "emptyResultSetCondition3";
            emptyResultSetCondition3.ResultSet = 4;
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction
            // 
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction, "dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest" +
                    "_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_reply_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookaction_register_reply_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_request_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookaction_register_request_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookaction_register_request_message_senderTestData
            // 
            this.dbo_companyname_roster_addressbookaction_register_request_message_senderTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_request_message_senderTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookaction_register_request_message_senderTestData.TestAction = dbo_companyname_roster_addressbookaction_register_request_message_senderTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookentryaction_saved_reply_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData
            // 
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTestData.TestAction = dbo_companyname_roster_addressbookentryaction_saveonaddressbookcreated_request_message_senderTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData
            // 
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTestData.TestAction = dbo_companyname_roster_addressbookentryaction_saveonaddressbookentryxmlparsed_request_message_senderTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookentryxmlaction_parse_reply_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData
            // 
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTestData.TestAction = dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_handlerTest_TestAction;
            // 
            // dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData
            // 
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData.PosttestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData.PretestAction = null;
            this.dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTestData.TestAction = dbo_companyname_roster_addressbookentryxmlaction_parse_request_message_senderTest_TestAction;
            // 
            // rowCountCondition6
            // 
            rowCountCondition6.Enabled = true;
            rowCountCondition6.Name = "rowCountCondition6";
            rowCountCondition6.ResultSet = 5;
            rowCountCondition6.RowCount = 1;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 1;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "1";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 5;
            scalarValueCondition6.RowNumber = 1;
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 6;
            rowCountCondition10.RowCount = 1;
            // 
            // scalarValueCondition10
            // 
            scalarValueCondition10.ColumnNumber = 1;
            scalarValueCondition10.Enabled = true;
            scalarValueCondition10.ExpectedValue = "1";
            scalarValueCondition10.Name = "scalarValueCondition10";
            scalarValueCondition10.NullExpected = false;
            scalarValueCondition10.ResultSet = 6;
            scalarValueCondition10.RowNumber = 1;
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
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
    }
}
