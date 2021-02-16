/* Title:           Work Task DLL
 * Date:            1-30-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the dll for Work Task */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace WorkTaskDLL
{
    public class WorkTaskClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        WorkTaskDataSet aWorkTaskDataSet;
        WorkTaskDataSetTableAdapters.worktaskTableAdapter aWorkTaskTableAdapter;

        InsertWorkTaskEntryTableAdapters.QueriesTableAdapter aInsertWorkTaskTableAdapter;

        FindWorkTaskByTaskIDDataSet aFindWorkTaskByWorkTaskIDDataSet;
        FindWorkTaskByTaskIDDataSetTableAdapters.FindWorkTaskByWorkTaskIDTableAdapter aFindWorkTaskByWorkTaskIDTableAdapter;

        FindWorkTaskByWorkTaskDataSet aFindWorkTaskByWorkTaskDataSet;
        FindWorkTaskByWorkTaskDataSetTableAdapters.FindWorkTaskByWorkTaskTableAdapter aFindWorkTaskByWorkTaskTableAdapter;

        FindSortedWorkTaskDataSet aFindSortedWorkTaksDataSet;
        FindSortedWorkTaskDataSetTableAdapters.FindSortedWorkTaskTableAdapter aFindSortedWorkTaskTableAdapter;

        FindWorkTaskHoursDataSet aFindWorkTaskHoursDataSet;
        FindWorkTaskHoursDataSetTableAdapters.FindWorkTaskHoursTableAdapter aFindWorkTaskHoursTableAdapter;

        UpdateWorkTaskEntryTableAdapters.QueriesTableAdapter aUpdateWorkTaskTableAdapter;

        FindWorkTaskByTaskKeywordDataSet aFindWorkTaskByTaskKeywordDataSet;
        FindWorkTaskByTaskKeywordDataSetTableAdapters.FindWorkTaskByTaskKeywordTableAdapter aFindWorkTaskByTaskKeywordTableAdapter;

        UpdateWorkTaskActiveEntryTableAdapters.QueriesTableAdapter aUpdateWorkTaskActiveTableAdapter;

        UpdateWorkTaskProductionRateEntryTableAdapters.QueriesTableAdapter aUpdateWorkTaskProductivityRateTableAdapter;

        WorkTaskImportDataSet aWorkTaskImportDataSet;
        WorkTaskImportDataSetTableAdapters.worktaskimportTableAdapter aWorkTaskImportTableAdapter;

        InsertWorkTaskImportEntryTableAdapters.QueriesTableAdapter aInsertWorkTaskImportTableAdapter;

        FindSortedWorkTaskImportDataSet aFindSortedWorkTaskImportDataSet;
        FindSortedWorkTaskImportDataSetTableAdapters.FindSortedWorkTaskImportTableAdapter aFindSortedWorkTaskImportTableAdapter;

        FindWorkTaskImportByLaborCodeDataSet aFindWorkTaskImportByLaborCodeDataSet;
        FindWorkTaskImportByLaborCodeDataSetTableAdapters.FindWorkTaskImportByLaborCodeTableAdapter aFindWorkTaskImportByLaborCodeTableAdapter;

        FindWorkTaskIMportByLaborTypeDataSet aFindWorkTaskImportByLaborTypeDataSet;
        FindWorkTaskIMportByLaborTypeDataSetTableAdapters.FindWorkTaskImportByLaborTypeTableAdapter aFindWorkTaskImportByLaborTypeTableAdapter;

        ProductivityWorkTaskDataSet aProductivityWorkTaskDataSet;
        ProductivityWorkTaskDataSetTableAdapters.productivityworktaskTableAdapter aProductivityWorkTaskTableAdapter;

        InsertProductivityWorkTaskTableAdapters.QueriesTableAdapter aInsertProductivityWorkTaskTableAdapter;

        FindProductivityWorkTaskByBusinessLineDataSet aFindProductivityWorkTaskByBusinessLineDataSet;
        FindProductivityWorkTaskByBusinessLineDataSetTableAdapters.FindProductivityWorkTaskByBusinessLineTableAdapter aFindProductivityWorkTaskByBusinessLineTableAdapter;

        FindProductivityWorkTaskByWorkTaskIDDataSet aFindProductivityWorkTaskByWorkTaskIDDataSet;
        FindProductivityWorkTaskByWorkTaskIDDataSetTableAdapters.FindProductivityWorkTaskByWorkTaskIDTableAdapter aFindProductivityWorkTaskByWorkTaskIDTableAdapter;

        public FindProductivityWorkTaskByWorkTaskIDDataSet FindProductivityWorkTaskByWorkTaskID(int intWorkTaskID, int intBusinessLineID, int intDepartmentID)
        {
            try
            {
                aFindProductivityWorkTaskByWorkTaskIDDataSet = new FindProductivityWorkTaskByWorkTaskIDDataSet();
                aFindProductivityWorkTaskByWorkTaskIDTableAdapter = new FindProductivityWorkTaskByWorkTaskIDDataSetTableAdapters.FindProductivityWorkTaskByWorkTaskIDTableAdapter();
                aFindProductivityWorkTaskByWorkTaskIDTableAdapter.Fill(aFindProductivityWorkTaskByWorkTaskIDDataSet.FindProductivityWorkTaskByWorkTaskID, intWorkTaskID, intBusinessLineID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Productivity Work Task By Work Task ID " + Ex.Message);
            }

            return aFindProductivityWorkTaskByWorkTaskIDDataSet;
        }
        public FindProductivityWorkTaskByBusinessLineDataSet FindProductivityWorkTaskByBusinessLine(int intBusinessLineID, int intDepartmentID)
        {
            try
            {
                aFindProductivityWorkTaskByBusinessLineDataSet = new FindProductivityWorkTaskByBusinessLineDataSet();
                aFindProductivityWorkTaskByBusinessLineTableAdapter = new FindProductivityWorkTaskByBusinessLineDataSetTableAdapters.FindProductivityWorkTaskByBusinessLineTableAdapter();
                aFindProductivityWorkTaskByBusinessLineTableAdapter.Fill(aFindProductivityWorkTaskByBusinessLineDataSet.FindProductivityWorkTaskByBusinessLine, intBusinessLineID, intDepartmentID);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Productivity Work Task By Business Line " + ex.Message);
            }

            return aFindProductivityWorkTaskByBusinessLineDataSet;
        }
        public bool InsertProductivityWorkTask(int intWorkTaskID, int intBusinessLineID, int intDepartmentID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductivityWorkTaskTableAdapter = new InsertProductivityWorkTaskTableAdapters.QueriesTableAdapter();
                aInsertProductivityWorkTaskTableAdapter.InsertProductivityWorkTask(intWorkTaskID, intBusinessLineID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Productivity Work Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductivityWorkTaskDataSet GetProductivityWorkTaskInfo()
        {
            try
            {
                aProductivityWorkTaskDataSet = new ProductivityWorkTaskDataSet();
                aProductivityWorkTaskTableAdapter = new ProductivityWorkTaskDataSetTableAdapters.productivityworktaskTableAdapter();
                aProductivityWorkTaskTableAdapter.Fill(aProductivityWorkTaskDataSet.productivityworktask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Productivity Work Task Info " + Ex.Message);
            }

            return aProductivityWorkTaskDataSet;
        }
        private void UpdateProductivityWorkTaskDB(ProductivityWorkTaskDataSet aProductivityWorkTaskDataSet)
        {
            try
            {
                aProductivityWorkTaskTableAdapter = new ProductivityWorkTaskDataSetTableAdapters.productivityworktaskTableAdapter();
                aProductivityWorkTaskTableAdapter.Update(aProductivityWorkTaskDataSet.productivityworktask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Productivity Work Task DB " + Ex.Message);
            }
        }
        public FindWorkTaskIMportByLaborTypeDataSet FindWorkTaskImportByLaborType(string strLaborType)
        {
            try
            {
                aFindWorkTaskImportByLaborTypeDataSet = new FindWorkTaskIMportByLaborTypeDataSet();
                aFindWorkTaskImportByLaborTypeTableAdapter = new FindWorkTaskIMportByLaborTypeDataSetTableAdapters.FindWorkTaskImportByLaborTypeTableAdapter();
                aFindWorkTaskImportByLaborTypeTableAdapter.Fill(aFindWorkTaskImportByLaborTypeDataSet.FindWorkTaskImportByLaborType, strLaborType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Import By Labor Type " + Ex.Message);
            }

            return aFindWorkTaskImportByLaborTypeDataSet;
        }
        public FindWorkTaskImportByLaborCodeDataSet FindWorkTaskImportByLaborCode(string strLaborCode)
        {
            try
            {
                aFindWorkTaskImportByLaborCodeDataSet = new FindWorkTaskImportByLaborCodeDataSet();
                aFindWorkTaskImportByLaborCodeTableAdapter = new FindWorkTaskImportByLaborCodeDataSetTableAdapters.FindWorkTaskImportByLaborCodeTableAdapter();
                aFindWorkTaskImportByLaborCodeTableAdapter.Fill(aFindWorkTaskImportByLaborCodeDataSet.FindWorkTaskImportByLaborCode, strLaborCode);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Import By Labor Code " + Ex.Message);
            }

            return aFindWorkTaskImportByLaborCodeDataSet;
        }
        public FindSortedWorkTaskImportDataSet FindSortedWorkTaskImport()
        {
            try
            {
                aFindSortedWorkTaskImportDataSet = new FindSortedWorkTaskImportDataSet();
                aFindSortedWorkTaskImportTableAdapter = new FindSortedWorkTaskImportDataSetTableAdapters.FindSortedWorkTaskImportTableAdapter();
                aFindSortedWorkTaskImportTableAdapter.Fill(aFindSortedWorkTaskImportDataSet.FindSortedWorkTaskImport);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Find Sorted Work Task Import " + Ex.Message);                
            }

            return aFindSortedWorkTaskImportDataSet;
        }
        public bool InsertWorkTaskImport(int intWorkTaskID, string strLaborCode, string strLaborType, string strItemFunction, string strItemDescription, string strUnitOfMessage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkTaskImportTableAdapter = new InsertWorkTaskImportEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkTaskImportTableAdapter.InsertWorkTaskImport(intWorkTaskID, strLaborCode, strLaborType, strItemFunction, strItemDescription, strUnitOfMessage);                                                                                                                                                       
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Work Task Import " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WorkTaskImportDataSet GetWorkTaskImportInfo()
        {
            try
            {
                aWorkTaskImportDataSet = new WorkTaskImportDataSet();
                aWorkTaskImportTableAdapter = new WorkTaskImportDataSetTableAdapters.worktaskimportTableAdapter();
                aWorkTaskImportTableAdapter.Fill(aWorkTaskImportDataSet.worktaskimport);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Work Task Import Info " + Ex.Message);
            }

            return aWorkTaskImportDataSet;
        }
        public void UpdateWorkTaskImportDB(WorkTaskImportDataSet aWorkTaskImportDataSet)
        {
            try
            {
                aWorkTaskImportTableAdapter = new WorkTaskImportDataSetTableAdapters.worktaskimportTableAdapter();
                aWorkTaskImportTableAdapter.Update(aWorkTaskImportDataSet.worktaskimport);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Import DB " + Ex.Message);
            }
        }
        public bool UpdateWorkTaskProductivityRate(int intWorkTaskID, decimal decProductivityRate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWorkTaskProductivityRateTableAdapter = new UpdateWorkTaskProductionRateEntryTableAdapters.QueriesTableAdapter();
                aUpdateWorkTaskProductivityRateTableAdapter.UpdateWorkTaskProductionRate(intWorkTaskID, decProductivityRate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Productivity Rate " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool UpdateWorkTaskActive(int intWorkTaskID, bool blnActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWorkTaskActiveTableAdapter = new UpdateWorkTaskActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateWorkTaskActiveTableAdapter.UpdateWorkTaskActive(intWorkTaskID, blnActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindWorkTaskByTaskKeywordDataSet FindWorkTaskByTaskKeyword(string strWorkTask)
        {
            try
            {
                aFindWorkTaskByTaskKeywordDataSet = new FindWorkTaskByTaskKeywordDataSet();
                aFindWorkTaskByTaskKeywordTableAdapter = new FindWorkTaskByTaskKeywordDataSetTableAdapters.FindWorkTaskByTaskKeywordTableAdapter();
                aFindWorkTaskByTaskKeywordTableAdapter.Fill(aFindWorkTaskByTaskKeywordDataSet.FindWorkTaskByTaskKeyword, strWorkTask);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task By Task Key Word " + Ex.Message);
            }

            return aFindWorkTaskByTaskKeywordDataSet;
        }
        public bool UpdateWorkTask(int intWorkTaskID, string strWorkTask, decimal decTaskCost)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWorkTaskTableAdapter = new UpdateWorkTaskEntryTableAdapters.QueriesTableAdapter();
                aUpdateWorkTaskTableAdapter.UpdateWorkTask(intWorkTaskID, strWorkTask, decTaskCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task " + Ex.Message);
            }

            return blnFatalError;
        }
        public FindWorkTaskHoursDataSet FindWorkTaskHours(string strWorkTask, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindWorkTaskHoursDataSet = new FindWorkTaskHoursDataSet();
                aFindWorkTaskHoursTableAdapter = new FindWorkTaskHoursDataSetTableAdapters.FindWorkTaskHoursTableAdapter();
                aFindWorkTaskHoursTableAdapter.Fill(aFindWorkTaskHoursDataSet.FindWorkTaskHours, strWorkTask, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Hours " + Ex.Message);
            }

            return aFindWorkTaskHoursDataSet;
        }
        public FindSortedWorkTaskDataSet FindSortedWorkTask()
        {
            try
            {
                aFindSortedWorkTaksDataSet = new FindSortedWorkTaskDataSet();
                aFindSortedWorkTaskTableAdapter = new FindSortedWorkTaskDataSetTableAdapters.FindSortedWorkTaskTableAdapter();
                aFindSortedWorkTaskTableAdapter.Fill(aFindSortedWorkTaksDataSet.FindSortedWorkTask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Sorted Work Task " + Ex.Message);
            }

            return aFindSortedWorkTaksDataSet;
        }
        public FindWorkTaskByWorkTaskDataSet FindWorkTaskByWorkTask(string strWorkTask)
        {
            try
            {
                aFindWorkTaskByWorkTaskDataSet = new FindWorkTaskByWorkTaskDataSet();
                aFindWorkTaskByWorkTaskTableAdapter = new FindWorkTaskByWorkTaskDataSetTableAdapters.FindWorkTaskByWorkTaskTableAdapter();
                aFindWorkTaskByWorkTaskTableAdapter.Fill(aFindWorkTaskByWorkTaskDataSet.FindWorkTaskByWorkTask, strWorkTask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task By Work Task " + Ex.Message);
            }

            return aFindWorkTaskByWorkTaskDataSet;
        }
        public FindWorkTaskByTaskIDDataSet FindWorkTaskByWorkTaskID(int intWorkTaskID)
        {
            try
            {
                aFindWorkTaskByWorkTaskIDDataSet = new FindWorkTaskByTaskIDDataSet();
                aFindWorkTaskByWorkTaskIDTableAdapter = new FindWorkTaskByTaskIDDataSetTableAdapters.FindWorkTaskByWorkTaskIDTableAdapter();
                aFindWorkTaskByWorkTaskIDTableAdapter.Fill(aFindWorkTaskByWorkTaskIDDataSet.FindWorkTaskByWorkTaskID, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task By Work Task ID " + Ex.Message);
            }

            return aFindWorkTaskByWorkTaskIDDataSet;
        }
        public bool InsertWorkTask(string strWorkTask, decimal decTaskCost)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkTaskTableAdapter = new InsertWorkTaskEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkTaskTableAdapter.InsertWorkTask(strWorkTask, decTaskCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Work Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }

        public WorkTaskDataSet GetWorkTaskInfo()
        {
            try
            {
                aWorkTaskDataSet = new WorkTaskDataSet();
                aWorkTaskTableAdapter = new WorkTaskDataSetTableAdapters.worktaskTableAdapter();
                aWorkTaskTableAdapter.Fill(aWorkTaskDataSet.worktask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Work Task Info " + Ex.Message);
            }

            return aWorkTaskDataSet;
        }
        public void UpdateWorkTaskDB(WorkTaskDataSet aWorkTaskDataSet)
        {
            try
            {
                aWorkTaskTableAdapter = new WorkTaskDataSetTableAdapters.worktaskTableAdapter();
                aWorkTaskTableAdapter.Update(aWorkTaskDataSet.worktask);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task DB " + Ex.Message);
            }
        }
    }
}
