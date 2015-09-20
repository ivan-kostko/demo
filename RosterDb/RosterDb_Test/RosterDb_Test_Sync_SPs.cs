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
    public class RosterDb_Test_Sync_SPs : SqlDatabaseTestClass
    {

        public RosterDb_Test_Sync_SPs()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_create_address_bookTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RosterDb_Test_Sync_SPs));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_log_errorTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_prepare_address_book_entry_xml_for_savingTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition15;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_register_user_contact_listTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_email_identificator_multyrowTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_resolve_single_email_idTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition17;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_save_address_book_entryTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition emptyResultSetCondition13;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition7;
            this.dbo_create_address_bookTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_log_errorTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_prepare_address_book_entry_xml_for_savingTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_register_user_contact_listTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_resolve_email_identificator_multyrowTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_resolve_single_email_idTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_save_address_book_entryTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_create_address_bookTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            emptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_log_errorTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            emptyResultSetCondition14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition15 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            dbo_register_user_contact_listTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            notEmptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            emptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_resolve_email_identificator_multyrowTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_resolve_single_email_idTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            rowCountCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            emptyResultSetCondition17 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            dbo_save_address_book_entryTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            emptyResultSetCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            emptyResultSetCondition13 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            expectedSchemaCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            notEmptyResultSetCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            rowCountCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            expectedSchemaCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            // 
            // dbo_create_address_bookTest_TestAction
            // 
            dbo_create_address_bookTest_TestAction.Conditions.Add(rowCountCondition3);
            dbo_create_address_bookTest_TestAction.Conditions.Add(scalarValueCondition3);
            dbo_create_address_bookTest_TestAction.Conditions.Add(rowCountCondition4);
            dbo_create_address_bookTest_TestAction.Conditions.Add(scalarValueCondition4);
            dbo_create_address_bookTest_TestAction.Conditions.Add(emptyResultSetCondition3);
            dbo_create_address_bookTest_TestAction.Conditions.Add(emptyResultSetCondition4);
            dbo_create_address_bookTest_TestAction.Conditions.Add(expectedSchemaCondition2);
            resources.ApplyResources(dbo_create_address_bookTest_TestAction, "dbo_create_address_bookTest_TestAction");
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
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 2;
            rowCountCondition4.RowCount = 1;
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 1;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "1";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 2;
            scalarValueCondition4.RowNumber = 1;
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
            // dbo_log_errorTest_TestAction
            // 
            dbo_log_errorTest_TestAction.Conditions.Add(rowCountCondition5);
            dbo_log_errorTest_TestAction.Conditions.Add(scalarValueCondition5);
            dbo_log_errorTest_TestAction.Conditions.Add(scalarValueCondition6);
            dbo_log_errorTest_TestAction.Conditions.Add(expectedSchemaCondition3);
            resources.ApplyResources(dbo_log_errorTest_TestAction, "dbo_log_errorTest_TestAction");
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
            scalarValueCondition5.ExpectedValue = "0";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 2;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "Opt: 0|Err: 0|Svr: 0|Stt: 0|Ln : 0|Prc: NULL|Msg: NULL|";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // expectedSchemaCondition3
            // 
            expectedSchemaCondition3.Enabled = true;
            expectedSchemaCondition3.Name = "expectedSchemaCondition3";
            resources.ApplyResources(expectedSchemaCondition3, "expectedSchemaCondition3");
            expectedSchemaCondition3.Verbose = false;
            // 
            // dbo_prepare_address_book_entry_xml_for_savingTest_TestAction
            // 
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(notEmptyResultSetCondition3);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(rowCountCondition8);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(scalarValueCondition8);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(emptyResultSetCondition14);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(emptyResultSetCondition15);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(notEmptyResultSetCondition4);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(rowCountCondition9);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(scalarValueCondition9);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(notEmptyResultSetCondition5);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(rowCountCondition12);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(scalarValueCondition10);
            dbo_prepare_address_book_entry_xml_for_savingTest_TestAction.Conditions.Add(expectedSchemaCondition7);
            resources.ApplyResources(dbo_prepare_address_book_entry_xml_for_savingTest_TestAction, "dbo_prepare_address_book_entry_xml_for_savingTest_TestAction");
            // 
            // notEmptyResultSetCondition3
            // 
            notEmptyResultSetCondition3.Enabled = true;
            notEmptyResultSetCondition3.Name = "notEmptyResultSetCondition3";
            notEmptyResultSetCondition3.ResultSet = 1;
            // 
            // rowCountCondition8
            // 
            rowCountCondition8.Enabled = true;
            rowCountCondition8.Name = "rowCountCondition8";
            rowCountCondition8.ResultSet = 1;
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
            // emptyResultSetCondition14
            // 
            emptyResultSetCondition14.Enabled = true;
            emptyResultSetCondition14.Name = "emptyResultSetCondition14";
            emptyResultSetCondition14.ResultSet = 2;
            // 
            // emptyResultSetCondition15
            // 
            emptyResultSetCondition15.Enabled = true;
            emptyResultSetCondition15.Name = "emptyResultSetCondition15";
            emptyResultSetCondition15.ResultSet = 3;
            // 
            // dbo_register_user_contact_listTest_TestAction
            // 
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(scalarValueCondition1);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(notEmptyResultSetCondition2);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(scalarValueCondition2);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(emptyResultSetCondition1);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(emptyResultSetCondition2);
            dbo_register_user_contact_listTest_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(dbo_register_user_contact_listTest_TestAction, "dbo_register_user_contact_listTest_TestAction");
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
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
            // notEmptyResultSetCondition2
            // 
            notEmptyResultSetCondition2.Enabled = true;
            notEmptyResultSetCondition2.Name = "notEmptyResultSetCondition2";
            notEmptyResultSetCondition2.ResultSet = 2;
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 2;
            rowCountCondition2.RowCount = 1;
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
            // emptyResultSetCondition1
            // 
            emptyResultSetCondition1.Enabled = true;
            emptyResultSetCondition1.Name = "emptyResultSetCondition1";
            emptyResultSetCondition1.ResultSet = 3;
            // 
            // emptyResultSetCondition2
            // 
            emptyResultSetCondition2.Enabled = true;
            emptyResultSetCondition2.Name = "emptyResultSetCondition2";
            emptyResultSetCondition2.ResultSet = 4;
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // dbo_resolve_email_identificator_multyrowTest_TestAction
            // 
            dbo_resolve_email_identificator_multyrowTest_TestAction.Conditions.Add(emptyResultSetCondition5);
            dbo_resolve_email_identificator_multyrowTest_TestAction.Conditions.Add(emptyResultSetCondition6);
            dbo_resolve_email_identificator_multyrowTest_TestAction.Conditions.Add(expectedSchemaCondition4);
            resources.ApplyResources(dbo_resolve_email_identificator_multyrowTest_TestAction, "dbo_resolve_email_identificator_multyrowTest_TestAction");
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
            // expectedSchemaCondition4
            // 
            expectedSchemaCondition4.Enabled = true;
            expectedSchemaCondition4.Name = "expectedSchemaCondition4";
            resources.ApplyResources(expectedSchemaCondition4, "expectedSchemaCondition4");
            expectedSchemaCondition4.Verbose = false;
            // 
            // dbo_resolve_single_email_idTest_TestAction
            // 
            dbo_resolve_single_email_idTest_TestAction.Conditions.Add(rowCountCondition10);
            dbo_resolve_single_email_idTest_TestAction.Conditions.Add(rowCountCondition11);
            dbo_resolve_single_email_idTest_TestAction.Conditions.Add(emptyResultSetCondition17);
            dbo_resolve_single_email_idTest_TestAction.Conditions.Add(expectedSchemaCondition8);
            resources.ApplyResources(dbo_resolve_single_email_idTest_TestAction, "dbo_resolve_single_email_idTest_TestAction");
            // 
            // rowCountCondition10
            // 
            rowCountCondition10.Enabled = true;
            rowCountCondition10.Name = "rowCountCondition10";
            rowCountCondition10.ResultSet = 1;
            rowCountCondition10.RowCount = 1;
            // 
            // rowCountCondition11
            // 
            rowCountCondition11.Enabled = true;
            rowCountCondition11.Name = "rowCountCondition11";
            rowCountCondition11.ResultSet = 2;
            rowCountCondition11.RowCount = 1;
            // 
            // emptyResultSetCondition17
            // 
            emptyResultSetCondition17.Enabled = true;
            emptyResultSetCondition17.Name = "emptyResultSetCondition17";
            emptyResultSetCondition17.ResultSet = 3;
            // 
            // expectedSchemaCondition8
            // 
            expectedSchemaCondition8.Enabled = true;
            expectedSchemaCondition8.Name = "expectedSchemaCondition8";
            resources.ApplyResources(expectedSchemaCondition8, "expectedSchemaCondition8");
            expectedSchemaCondition8.Verbose = false;
            // 
            // dbo_save_address_book_entryTest_TestAction
            // 
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition8);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition9);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition10);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition11);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition12);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(emptyResultSetCondition13);
            dbo_save_address_book_entryTest_TestAction.Conditions.Add(expectedSchemaCondition6);
            resources.ApplyResources(dbo_save_address_book_entryTest_TestAction, "dbo_save_address_book_entryTest_TestAction");
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
            // emptyResultSetCondition11
            // 
            emptyResultSetCondition11.Enabled = true;
            emptyResultSetCondition11.Name = "emptyResultSetCondition11";
            emptyResultSetCondition11.ResultSet = 4;
            // 
            // emptyResultSetCondition12
            // 
            emptyResultSetCondition12.Enabled = true;
            emptyResultSetCondition12.Name = "emptyResultSetCondition12";
            emptyResultSetCondition12.ResultSet = 5;
            // 
            // emptyResultSetCondition13
            // 
            emptyResultSetCondition13.Enabled = true;
            emptyResultSetCondition13.Name = "emptyResultSetCondition13";
            emptyResultSetCondition13.ResultSet = 6;
            // 
            // expectedSchemaCondition6
            // 
            expectedSchemaCondition6.Enabled = true;
            expectedSchemaCondition6.Name = "expectedSchemaCondition6";
            resources.ApplyResources(expectedSchemaCondition6, "expectedSchemaCondition6");
            expectedSchemaCondition6.Verbose = false;
            // 
            // dbo_create_address_bookTestData
            // 
            this.dbo_create_address_bookTestData.PosttestAction = null;
            this.dbo_create_address_bookTestData.PretestAction = null;
            this.dbo_create_address_bookTestData.TestAction = dbo_create_address_bookTest_TestAction;
            // 
            // dbo_log_errorTestData
            // 
            this.dbo_log_errorTestData.PosttestAction = null;
            this.dbo_log_errorTestData.PretestAction = null;
            this.dbo_log_errorTestData.TestAction = dbo_log_errorTest_TestAction;
            // 
            // dbo_prepare_address_book_entry_xml_for_savingTestData
            // 
            this.dbo_prepare_address_book_entry_xml_for_savingTestData.PosttestAction = null;
            this.dbo_prepare_address_book_entry_xml_for_savingTestData.PretestAction = null;
            this.dbo_prepare_address_book_entry_xml_for_savingTestData.TestAction = dbo_prepare_address_book_entry_xml_for_savingTest_TestAction;
            // 
            // dbo_register_user_contact_listTestData
            // 
            this.dbo_register_user_contact_listTestData.PosttestAction = null;
            this.dbo_register_user_contact_listTestData.PretestAction = null;
            this.dbo_register_user_contact_listTestData.TestAction = dbo_register_user_contact_listTest_TestAction;
            // 
            // dbo_resolve_email_identificator_multyrowTestData
            // 
            this.dbo_resolve_email_identificator_multyrowTestData.PosttestAction = null;
            this.dbo_resolve_email_identificator_multyrowTestData.PretestAction = null;
            this.dbo_resolve_email_identificator_multyrowTestData.TestAction = dbo_resolve_email_identificator_multyrowTest_TestAction;
            // 
            // dbo_resolve_single_email_idTestData
            // 
            this.dbo_resolve_single_email_idTestData.PosttestAction = null;
            this.dbo_resolve_single_email_idTestData.PretestAction = null;
            this.dbo_resolve_single_email_idTestData.TestAction = dbo_resolve_single_email_idTest_TestAction;
            // 
            // dbo_save_address_book_entryTestData
            // 
            this.dbo_save_address_book_entryTestData.PosttestAction = null;
            this.dbo_save_address_book_entryTestData.PretestAction = null;
            this.dbo_save_address_book_entryTestData.TestAction = dbo_save_address_book_entryTest_TestAction;
            // 
            // notEmptyResultSetCondition4
            // 
            notEmptyResultSetCondition4.Enabled = true;
            notEmptyResultSetCondition4.Name = "notEmptyResultSetCondition4";
            notEmptyResultSetCondition4.ResultSet = 4;
            // 
            // rowCountCondition9
            // 
            rowCountCondition9.Enabled = true;
            rowCountCondition9.Name = "rowCountCondition9";
            rowCountCondition9.ResultSet = 4;
            rowCountCondition9.RowCount = 1;
            // 
            // scalarValueCondition9
            // 
            scalarValueCondition9.ColumnNumber = 1;
            scalarValueCondition9.Enabled = true;
            scalarValueCondition9.ExpectedValue = "1";
            scalarValueCondition9.Name = "scalarValueCondition9";
            scalarValueCondition9.NullExpected = false;
            scalarValueCondition9.ResultSet = 4;
            scalarValueCondition9.RowNumber = 1;
            // 
            // notEmptyResultSetCondition5
            // 
            notEmptyResultSetCondition5.Enabled = true;
            notEmptyResultSetCondition5.Name = "notEmptyResultSetCondition5";
            notEmptyResultSetCondition5.ResultSet = 5;
            // 
            // rowCountCondition12
            // 
            rowCountCondition12.Enabled = true;
            rowCountCondition12.Name = "rowCountCondition12";
            rowCountCondition12.ResultSet = 5;
            rowCountCondition12.RowCount = 1;
            // 
            // scalarValueCondition10
            // 
            scalarValueCondition10.ColumnNumber = 1;
            scalarValueCondition10.Enabled = true;
            scalarValueCondition10.ExpectedValue = "1";
            scalarValueCondition10.Name = "scalarValueCondition10";
            scalarValueCondition10.NullExpected = false;
            scalarValueCondition10.ResultSet = 5;
            scalarValueCondition10.RowNumber = 1;
            // 
            // expectedSchemaCondition7
            // 
            expectedSchemaCondition7.Enabled = true;
            expectedSchemaCondition7.Name = "expectedSchemaCondition7";
            resources.ApplyResources(expectedSchemaCondition7, "expectedSchemaCondition7");
            expectedSchemaCondition7.Verbose = false;
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
        public void dbo_resolve_email_identificator_multyrowTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_resolve_email_identificator_multyrowTestData;
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
        public void dbo_resolve_single_email_idTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_resolve_single_email_idTestData;
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


        private SqlDatabaseTestActions dbo_create_address_bookTestData;
private SqlDatabaseTestActions dbo_log_errorTestData;
private SqlDatabaseTestActions dbo_prepare_address_book_entry_xml_for_savingTestData;
private SqlDatabaseTestActions dbo_register_user_contact_listTestData;
private SqlDatabaseTestActions dbo_resolve_email_identificator_multyrowTestData;
private SqlDatabaseTestActions dbo_resolve_single_email_idTestData;
private SqlDatabaseTestActions dbo_save_address_book_entryTestData;
    }
}
