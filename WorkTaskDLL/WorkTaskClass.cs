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

        WorkTaskDepartmentDataSet aWorkTaskDepartmentDataSet;
        WorkTaskDepartmentDataSetTableAdapters.worktaskdepartmentTableAdapter aWorkTaskDepartmentTableAdapter;

        InsertWorkTaskDepartmentEntryTableAdapters.QueriesTableAdapter aInsertWorkTaskDepartmentTableAdapter;

        UpdateWorkTaskDepartmentActiveEntryTableAdapters.QueriesTableAdapter aUpdateWorktTaskDepartmentActiveTableAdapter;

        FindWorkTaskDepartmentWorkTaskMatchDataSet aFindWorkTaskDepartmentWorkTaskMatchDataSet;
        FindWorkTaskDepartmentWorkTaskMatchDataSetTableAdapters.FindWorkTaskDepartmentWorkTaskMatchTableAdapter aFindWorkTaskDepartmentWorkTaskMatchTableAdapter;

        FindWorkTaskDepartmentByLOBDepartmentDataSet aFindWorkTaskDepartmentByLOBDepartmentDataSet;
        FindWorkTaskDepartmentByLOBDepartmentDataSetTableAdapters.FindWorkTaskDepartmentByLOBDepartmentTableAdapter aFindWorkTaskDepartmentByLOBDepartmentTableAdapter;

        FindWorkTaskDepartmentByDateMatchDataSet aFindWorkTaskDepartmentByDateMatchDataSet;
        FindWorkTaskDepartmentByDateMatchDataSetTableAdapters.FindWorkTaskDepartmentByDateMatchTableAdapter aFindWorkTaskDepartmentByDateMatchTableAdapter;

        WorkTaskSavedSheetDataSet aWorkTaskSavedSheetDataSet;
        WorkTaskSavedSheetDataSetTableAdapters.worktasksavedsheetTableAdapter aWorkTaskSavedSheetTableAdapter;

        InsertWorkTaskSavedSheetEntryTableAdapters.QueriesTableAdapter aInsertWorkTaskSavedSheetTableAdapter;

        FindWorkTaskSavedSheetByDateMatchDataSet aFindWorkTaskSavedSheetByDateMatchDataSet;
        FindWorkTaskSavedSheetByDateMatchDataSetTableAdapters.FindWorkTaskSavedSheetByDateMatchTableAdapter aFindWorkTaskSavedSheetByDateMatchTableAdapter;

        FindWorkTaskSavedSheetByEmployeeDataSet aFindWorkTaskSavedSheetByEmployeeDataSet;
        FindWorkTaskSavedSheetByEmployeeDataSetTableAdapters.FindWorkTaskSavedSheetByEmployeeTableAdapter aFindWorkTaskSavedSheetByEmployeeTableAdapter;

        WorkTaskSavedSheetTasksDataSet aWorkTaskSavedSheetTasksDataSet;
        WorkTaskSavedSheetTasksDataSetTableAdapters.worktasksavedsheettasksTableAdapter aWorkTaskSavedSheetTasksTableAdpater;

        InsertWorkTaskSavedSheetTaskEntryTableAdapters.QueriesTableAdapter aInsertWorkTaskSavedSheetTaskTableAdapter;

        FindWorkTaskUsageByDateTaskDataSet aFindWorkTaskUsageByDateTaskDataSet;
        FindWorkTaskUsageByDateTaskDataSetTableAdapters.FindWorkTaskUsageByDateTaskTableAdapter aFindWorkTaskUsageByDateTaskTableAdapter;

        FindWorkTaskIDTotalCountByDateDataSet aFindWorkTaskIDTotalCountByDateDataSet;
        FindWorkTaskIDTotalCountByDateDataSetTableAdapters.FindWorkTaskIDTotalCountByDateTableAdapter aFindWorkTaskIDTotalCountByDateTableAdapter;

        FindWorkTaskDepartmentByWorkTaskDataSet aFindWorkTaskDepartmentByWorkTaskDataSet;
        FindWorkTaskDepartmentByWorkTaskDataSetTableAdapters.FindWorkTaskDepartmentByWorkTaskTableAdapter aFindWorkTaskDepartmentByWorkTaskTableAdapter;

        FindWorkTaskByDepartmentDataSet aFindWorkTaskByDepartmentDataSet;
        FindWorkTaskByDepartmentDataSetTableAdapters.FindWorkTaskByDepartmentTableAdapter aFindWorkTaskByDepartmentTableAdapter;

        FindWorkTaskImportByWorkTaskIDDataSet aFindWorkTaskImportByWorkTaskIDDataSet;
        FindWorkTaskImportByWorkTaskIDDataSetTableAdapters.FindWorkTaskImportByWorkTaskIDTableAdapter aFindWorkTaskImportByWorkTaskIDTableAdapter;

        FindWorkTaskDepartmentForBusinessLineDataSet aFindWorkTaskDepartmentForBusinessLineDataSet;
        FindWorkTaskDepartmentForBusinessLineDataSetTableAdapters.FindWorkTaskDepartmentForBusinessLineTableAdapter aFindWorkTaskDepartmentForBusinessLineTableAdapter;

        public FindWorkTaskDepartmentForBusinessLineDataSet FindWorkTaskDepartmentForBusienssLine(int intBusinessLineID, int intWorkTaskID)
        {
            try
            {
                aFindWorkTaskDepartmentForBusinessLineDataSet = new FindWorkTaskDepartmentForBusinessLineDataSet();
                aFindWorkTaskDepartmentForBusinessLineTableAdapter = new FindWorkTaskDepartmentForBusinessLineDataSetTableAdapters.FindWorkTaskDepartmentForBusinessLineTableAdapter();
                aFindWorkTaskDepartmentForBusinessLineTableAdapter.Fill(aFindWorkTaskDepartmentForBusinessLineDataSet.FindWorkTaskDepartmentForBusinessLine, intBusinessLineID, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Department For Business Line " + Ex.Message);
            }

            return aFindWorkTaskDepartmentForBusinessLineDataSet;
        }
        public FindWorkTaskImportByWorkTaskIDDataSet FindWorkTaskImportByWorkTaskID(int intWorkTaskID)
        {
            try
            {
                aFindWorkTaskImportByWorkTaskIDDataSet = new FindWorkTaskImportByWorkTaskIDDataSet();
                aFindWorkTaskImportByWorkTaskIDTableAdapter = new FindWorkTaskImportByWorkTaskIDDataSetTableAdapters.FindWorkTaskImportByWorkTaskIDTableAdapter();
                aFindWorkTaskImportByWorkTaskIDTableAdapter.Fill(aFindWorkTaskImportByWorkTaskIDDataSet.FindWorkTaskImportByWorkTaskID, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Import By Work Task ID " + Ex.Message);
            }

            return aFindWorkTaskImportByWorkTaskIDDataSet;
        }
        public FindWorkTaskByDepartmentDataSet FindWorkTaskByDepartment(int intDepartmentID)
        {
            try
            {
                aFindWorkTaskByDepartmentDataSet = new FindWorkTaskByDepartmentDataSet();
                aFindWorkTaskByDepartmentTableAdapter = new FindWorkTaskByDepartmentDataSetTableAdapters.FindWorkTaskByDepartmentTableAdapter();
                aFindWorkTaskByDepartmentTableAdapter.Fill(aFindWorkTaskByDepartmentDataSet.FindWorkTaskByDepartment, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task by Department " + Ex.Message);
            }

            return aFindWorkTaskByDepartmentDataSet;
        }
        public FindWorkTaskDepartmentByWorkTaskDataSet FindWorkTaskDepartmentByWorkTask(int intWorkTaskID)
        {
            try
            {
                aFindWorkTaskDepartmentByWorkTaskDataSet = new FindWorkTaskDepartmentByWorkTaskDataSet();
                aFindWorkTaskDepartmentByWorkTaskTableAdapter = new FindWorkTaskDepartmentByWorkTaskDataSetTableAdapters.FindWorkTaskDepartmentByWorkTaskTableAdapter();
                aFindWorkTaskDepartmentByWorkTaskTableAdapter.Fill(aFindWorkTaskDepartmentByWorkTaskDataSet.FindWorkTaskDepartmentByWorkTask, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Department By Work Task " + Ex.Message);
            }

            return aFindWorkTaskDepartmentByWorkTaskDataSet;
        }
        public  FindWorkTaskIDTotalCountByDateDataSet FindWorkTaskIDTotalCountByDate(DateTime datTransactionID)
        {
            try
            {
                aFindWorkTaskIDTotalCountByDateDataSet = new FindWorkTaskIDTotalCountByDateDataSet();
                aFindWorkTaskIDTotalCountByDateTableAdapter = new FindWorkTaskIDTotalCountByDateDataSetTableAdapters.FindWorkTaskIDTotalCountByDateTableAdapter();
                aFindWorkTaskIDTotalCountByDateTableAdapter.Fill(aFindWorkTaskIDTotalCountByDateDataSet.FindWorkTaskIDTotalCountByDate, datTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task ID Total Count By Date " + Ex.Message);
            }

            return aFindWorkTaskIDTotalCountByDateDataSet;
        }
        public FindWorkTaskUsageByDateTaskDataSet FindWorkTaskUsageByDateTask(DateTime datTransactionDate, int intWorkTaskID)
        {
            try
            {
                aFindWorkTaskUsageByDateTaskDataSet = new FindWorkTaskUsageByDateTaskDataSet();
                aFindWorkTaskUsageByDateTaskTableAdapter = new FindWorkTaskUsageByDateTaskDataSetTableAdapters.FindWorkTaskUsageByDateTaskTableAdapter();
                aFindWorkTaskUsageByDateTaskTableAdapter.Fill(aFindWorkTaskUsageByDateTaskDataSet.FindWorkTaskUsageByDateTask, datTransactionDate, intWorkTaskID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Usage By Date Task " + Ex.Message);
            }

            return aFindWorkTaskUsageByDateTaskDataSet;
        }
        public bool InsertWorkTaskSavedSheetTask(int intWorkSheetID, int intWorkTaskID, int intBusinessLineID, int intDepartmentID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkTaskSavedSheetTaskTableAdapter = new InsertWorkTaskSavedSheetTaskEntryTableAdapters.QueriesTableAdapter();
                //aInsertWorkTaskSavedSheetTaskTableAdapter.InsertWorkTaskSavedSheetTask(intWorkSheetID, intWorkTaskID, )
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Work Taks Saved Sheet Task " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WorkTaskSavedSheetTasksDataSet GetWorkTaskSavedSheetTasksInfo()
        {
            try
            {
                aWorkTaskSavedSheetTasksDataSet = new WorkTaskSavedSheetTasksDataSet();
                aWorkTaskSavedSheetTasksTableAdpater = new WorkTaskSavedSheetTasksDataSetTableAdapters.worktasksavedsheettasksTableAdapter();
                aWorkTaskSavedSheetTasksTableAdpater.Fill(aWorkTaskSavedSheetTasksDataSet.worktasksavedsheettasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Work Task Saved Sheet Task Info " + Ex.Message);
            }

            return aWorkTaskSavedSheetTasksDataSet;
        }
        public void UpdateWorkTaskSavedSheetsDB(WorkTaskSavedSheetTasksDataSet aWorkTaskSavedSheetTasksDataSet)
        {
            try
            {
                aWorkTaskSavedSheetTasksTableAdpater = new WorkTaskSavedSheetTasksDataSetTableAdapters.worktasksavedsheettasksTableAdapter();
                aWorkTaskSavedSheetTasksTableAdpater.Update(aWorkTaskSavedSheetTasksDataSet.worktasksavedsheettasks);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Saved Sheet Task DB " + Ex.Message);
            }
        }
        public FindWorkTaskSavedSheetByEmployeeDataSet FindWorkTaskSavedSheetByEmployee(int intEmployeeID)
        {
            try
            {
                aFindWorkTaskSavedSheetByEmployeeDataSet = new FindWorkTaskSavedSheetByEmployeeDataSet();
                aFindWorkTaskSavedSheetByEmployeeTableAdapter = new FindWorkTaskSavedSheetByEmployeeDataSetTableAdapters.FindWorkTaskSavedSheetByEmployeeTableAdapter();
                aFindWorkTaskSavedSheetByEmployeeTableAdapter.Fill(aFindWorkTaskSavedSheetByEmployeeDataSet.FindWorkTaskSavedSheetByEmployee, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Saved Sheet By Employee " + Ex.Message);
            }

            return aFindWorkTaskSavedSheetByEmployeeDataSet;
        }
        public FindWorkTaskSavedSheetByDateMatchDataSet FindWorkTaskSavedSheetByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindWorkTaskSavedSheetByDateMatchDataSet = new FindWorkTaskSavedSheetByDateMatchDataSet();
                aFindWorkTaskSavedSheetByDateMatchTableAdapter = new FindWorkTaskSavedSheetByDateMatchDataSetTableAdapters.FindWorkTaskSavedSheetByDateMatchTableAdapter();
                aFindWorkTaskSavedSheetByDateMatchTableAdapter.Fill(aFindWorkTaskSavedSheetByDateMatchDataSet.FindWorkTaskSavedSheetByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Saved Sheet By Date Match " + Ex.Message);
            }

            return aFindWorkTaskSavedSheetByDateMatchDataSet;
        }
        public bool InsertWorkTaskSavedSheet(int intEmployeeID, string strSheetTitle, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkTaskSavedSheetTableAdapter = new InsertWorkTaskSavedSheetEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkTaskSavedSheetTableAdapter.InsertWorkTaskSavedSheet(intEmployeeID, strSheetTitle, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Work Task Saved Sheet " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WorkTaskSavedSheetDataSet GetWorkTaskSavedSheetInfo()
        {
            try
            {
                aWorkTaskSavedSheetDataSet = new WorkTaskSavedSheetDataSet();
                aWorkTaskSavedSheetTableAdapter = new WorkTaskSavedSheetDataSetTableAdapters.worktasksavedsheetTableAdapter();
                aWorkTaskSavedSheetTableAdapter.Fill(aWorkTaskSavedSheetDataSet.worktasksavedsheet);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Work Taks Saved Sheet Info " + Ex.Message);
            }

            return aWorkTaskSavedSheetDataSet;
        }
        public void UpdateWorkTaskSavedSheetDB(WorkTaskSavedSheetDataSet aWorkTaskSavedSheetDataSet)
        {
            try
            {
                aWorkTaskSavedSheetTableAdapter = new WorkTaskSavedSheetDataSetTableAdapters.worktasksavedsheetTableAdapter();
                aWorkTaskSavedSheetTableAdapter.Update(aWorkTaskSavedSheetDataSet.worktasksavedsheet);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Taks Saved Sheet DB " + Ex.Message);
            }
        }
        public FindWorkTaskDepartmentByLOBDepartmentDataSet FindWorkTaskDepartmentByLOBDepartment(int intBusinessLineID, int intDepartmentID)
        {
            try
            {
                aFindWorkTaskDepartmentByLOBDepartmentDataSet = new FindWorkTaskDepartmentByLOBDepartmentDataSet();
                aFindWorkTaskDepartmentByLOBDepartmentTableAdapter = new FindWorkTaskDepartmentByLOBDepartmentDataSetTableAdapters.FindWorkTaskDepartmentByLOBDepartmentTableAdapter();
                aFindWorkTaskDepartmentByLOBDepartmentTableAdapter.Fill(aFindWorkTaskDepartmentByLOBDepartmentDataSet.FindWorkTaskDepartmentByLOBDepartment, intBusinessLineID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Department By LOB Department " + Ex.Message);
            }

            return aFindWorkTaskDepartmentByLOBDepartmentDataSet;
        }
        public FindWorkTaskDepartmentByDateMatchDataSet FindWorkTaskDepartmentByDateMatch(DateTime datTransactionDate)
        {
            try
            {
                aFindWorkTaskDepartmentByDateMatchDataSet = new FindWorkTaskDepartmentByDateMatchDataSet();
                aFindWorkTaskDepartmentByDateMatchTableAdapter = new FindWorkTaskDepartmentByDateMatchDataSetTableAdapters.FindWorkTaskDepartmentByDateMatchTableAdapter();
                aFindWorkTaskDepartmentByDateMatchTableAdapter.Fill(aFindWorkTaskDepartmentByDateMatchDataSet.FindWorkTaskDepartmentByDateMatch, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Department By Date Match " + Ex.Message);
            }

            return aFindWorkTaskDepartmentByDateMatchDataSet;
        }
        public FindWorkTaskDepartmentWorkTaskMatchDataSet FindWorkTaskDepartmentWorkTaskMatch(int intWorkTaskID, int intBusinessLineID, int intDepartmentID)
        {
            try
            {
                aFindWorkTaskDepartmentWorkTaskMatchDataSet = new FindWorkTaskDepartmentWorkTaskMatchDataSet();
                aFindWorkTaskDepartmentWorkTaskMatchTableAdapter = new FindWorkTaskDepartmentWorkTaskMatchDataSetTableAdapters.FindWorkTaskDepartmentWorkTaskMatchTableAdapter();
                aFindWorkTaskDepartmentWorkTaskMatchTableAdapter.Fill(aFindWorkTaskDepartmentWorkTaskMatchDataSet.FindWorkTaskDepartmentWorkTaskMatch, intWorkTaskID, intBusinessLineID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Find Work Task Department Work Task Match " + Ex.Message);
            }

            return aFindWorkTaskDepartmentWorkTaskMatchDataSet;
        }
        public bool UpdateWorkTaskDepartmentActive(int intTransactionID, bool blnAssignmentActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateWorktTaskDepartmentActiveTableAdapter = new UpdateWorkTaskDepartmentActiveEntryTableAdapters.QueriesTableAdapter();
                aUpdateWorktTaskDepartmentActiveTableAdapter.UpdateWorkTaskActive(intTransactionID, blnAssignmentActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Department Active " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertWorkTaskDepartment(int intWorkTaskID, int intBusinessLineID, int intDepartmentID, int intEmployeeID, DateTime datTransactionDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertWorkTaskDepartmentTableAdapter = new InsertWorkTaskDepartmentEntryTableAdapters.QueriesTableAdapter();
                aInsertWorkTaskDepartmentTableAdapter.InsertWorkTaskDepartment(intWorkTaskID, intBusinessLineID, intDepartmentID, intEmployeeID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Insert Work Task Department " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public WorkTaskDepartmentDataSet GetWorkTaskDepartmentInfo()
        {
            try
            {
                aWorkTaskDepartmentDataSet = new WorkTaskDepartmentDataSet();
                aWorkTaskDepartmentTableAdapter = new WorkTaskDepartmentDataSetTableAdapters.worktaskdepartmentTableAdapter();
                aWorkTaskDepartmentTableAdapter.Fill(aWorkTaskDepartmentDataSet.worktaskdepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Get Work Task Department Info " + Ex.Message);
            }

            return aWorkTaskDepartmentDataSet;
        }
        public void UpdateWorkTaskDepartmentDB(WorkTaskDepartmentDataSet aWorkTaskDepartmentDataSet)
        {
            try
            {
                aWorkTaskDepartmentTableAdapter = new WorkTaskDepartmentDataSetTableAdapters.worktaskdepartmentTableAdapter();
                aWorkTaskDepartmentTableAdapter.Update(aWorkTaskDepartmentDataSet.worktaskdepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Work Task Class // Update Work Task Department DB " + Ex.Message);
            }
        }
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
