using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Resources.Interfaces;
using System.Reflection;
using System.Data.OleDb;
using System.Diagnostics;


namespace Resources
{
    class ExcelConnector
    {
        OleDbConnection m_Connection=null;
        OleDbCommand m_Command=null;
        OleDbDataAdapter m_Adapter = null;

        public bool ConnectToExcel(string excelFilePath)
        {
            Debug.WriteLine("Connecting to excel file....." );
            bool isSucceded = false;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFilePath + @";Extended Properties=""Excel 12.0 Macro;HDR=Yes"";";
            try
            {
                m_Connection = new OleDbConnection(connectionString);
                m_Connection.Open();
                isSucceded = true;
            }

            catch (Exception ex) { throw new Exception("Error connecting to Excel File", ex); }
            Debug.WriteLine("Connection succeded.....");
            return isSucceded;
        }

        public bool CloseExcelConnection()
        {
            bool isSucceded = false;
            try
            {
                if (m_Connection != null)
                    m_Connection.Close();
                isSucceded = true;
            }
            catch (Exception ex) { throw new Exception("Error closing excel file connection", ex); }
            return isSucceded;
        }

        public bool ExecuteQuery(string sqlString, out DataTable dtTemp)
        {
            dtTemp = new DataTable();
            bool isSucceded = false;
            try
            {
                m_Command = new OleDbCommand(sqlString, m_Connection);
                m_Adapter.SelectCommand = m_Command;
                m_Adapter.Fill(dtTemp);
                isSucceded = true;
            }
            catch(Exception ex) { throw new Exception("Error executing query", ex); }
            return isSucceded;
        }

    }
}
