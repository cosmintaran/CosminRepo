using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Resources.Interfaces;


namespace Resources
{
    class ExcelHelper : IExcel
    {
        private readonly Excel.Application ExcelApp;
        private Excel.Worksheet Ws;
        private Excel.Workbook Wb;
        private bool excelIsVisible;
        private int index;
        private bool wbStatus;
        private bool excelAppStatus;


        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelHelper"/> class.
        /// </summary>
        /// <param name="isVisible">if set to <c>true</c> [is visible].</param>
        public ExcelHelper(bool isVisible = false)
        {
            try
            {
                this.excelIsVisible = isVisible;
                ExcelApp = new Excel.Application();
                ExcelApp.Visible = this.excelIsVisible;
                excelAppStatus = true;
            }
            catch (Exception)
            { throw new Exception("Excel is missing or is not properly installed"); }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="ExcelHelper"/> class.
        /// </summary>
        ~ExcelHelper()
        {
            if (wbStatus == true)
                CloseWorkbook();
            if (excelAppStatus == true)
            {
                Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        /// <summary>
        /// Adds the worksheet.
        /// </summary>
        /// <param name="l_Wb">The l_ wb.</param>
        /// <param name="sheetName">Name of the sheet.</param>
        private void AddWorksheet(string sheetName)
        {
            try
            {
                Ws = (Excel.Worksheet)Wb.Worksheets.Add();
                Ws.Name = sheetName;
            }
            catch (Exception)
            { throw new Exception("Error creating worksheet " + '"' + sheetName + '"'); }
        }

        /// <summary>
        /// Closes the current workbook.
        /// </summary>
        /// <returns></returns>
        public bool CloseWorkbook()
        {
            if (Wb != null)
            {
                try
                {
                    foreach (var sheet in Wb.Worksheets)
                        Marshal.FinalReleaseComObject(sheet);
                    Wb.Close(false, Type.Missing, Type.Missing);
                    Marshal.ReleaseComObject(Wb);
                    Wb = null;
                    wbStatus = false;
                }
                catch (Exception)
                {
                    return false;
                    throw new Exception("Exception Occurred while releasing Excel object");
                }
            }
            return true;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// Close Excel Application and the Workbook
        /// </summary>
        /// <returns>True or False</returns>
        public bool Dispose()
        {
            CloseWorkbook();
            if (excelAppStatus == true)
            {
                ExcelApp.Quit();
                excelAppStatus = false;
                Marshal.FinalReleaseComObject(ExcelApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return true;
        }

        /// <summary>
        /// Copies data from source sheet to the destination sheet.
        /// </summary>
        /// <param name="worksheetName1">The worksheet name1. -source</param>
        /// <param name="worksheetName2">The worksheet name2. -destination</param>
        /// <returns>true if opertion has succeded or false if the operation failed </returns>
        public bool CopyWorksheet(string worksheetName1, string worksheetName2)
        {
            bool hasCopied = false;
            Excel.Worksheet source = null;
            Excel.Worksheet dest = null;
            try
            {
                source = SetCurrentWorksheet(worksheetName1);
                source.UsedRange.Copy(Type.Missing);
                dest = SetCurrentWorksheet(worksheetName2);
                dest.UsedRange.PasteSpecial(Excel.XlPasteType.xlPasteAll, Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, Type.Missing, Type.Missing);
                //Wb.Save();
                Marshal.FinalReleaseComObject(source);
                Marshal.FinalReleaseComObject(dest);
                hasCopied = true;
            }
            catch (Exception)
            {
                CloseWorkbook();
                return false;
                throw new Exception("Error copy from worksheet");
            }
            return hasCopied;
        }

        /// <summary>
        /// Deletes the worksheet.
        /// </summary>
        /// <param name="sheetName">Name of the sheet that is intended to be removed </param>
        /// <returns>true if operation succeded or false if it fails</returns>
        public bool DeleteWorksheet(string sheetName)
        {
            bool isDeleted = false;
            if (IsWorksheetExist(sheetName))
            {
                try
                {
                    if (excelIsVisible != true)
                        ExcelApp.DisplayAlerts = false;
                    (Wb.Sheets[sheetName]).Delete();
                    ExcelApp.DisplayAlerts = true;
                    isDeleted = true;
                }
                catch (Exception)
                {
                    return false;
                    throw new Exception("Fail to delete worksheet " + sheetName);
                }
            }
            else
            {
                isDeleted = false;
                throw new Exception("Error deleting worksheet Worksheet sheetName dosen't exist");
            }

            return isDeleted;
        }

        /// <summary>
        /// Formats the worksheet.
        /// </summary>
        /// <param name="sheetToFormat">The sheet to format.</param>
        /// <param name="startColumnIndex">Start index of the column.</param>
        /// <param name="startRowIndex">Start index of the row.</param>
        /// <param name="endColumnIndex">End index of the column.</param>
        /// <param name="endRowIndex">End index of the row.</param>
        /// <param name="value">The value is a object type wich contains data about column format.</param>
        private void FormatWorksheet(Excel.Worksheet sheetToFormat, int startColumnIndex, int startRowIndex, int endColumnIndex, int endRowIndex, object value)
        {
            Excel.Range startCell = sheetToFormat.Cells[startRowIndex, startColumnIndex]; //Start Cell
            Excel.Range endCell = sheetToFormat.Cells[endRowIndex, endColumnIndex];     //End Cell
            Excel.Range range = sheetToFormat.get_Range(startCell, endCell);
            if (value is string)
                range.NumberFormat = value;
            if (value is Type)
            {
                if (value as Type == typeof(string))
                { range.NumberFormat = "@"; }
                else if (value as Type == typeof(int))
                { range.NumberFormat = "#"; }
                else if (value as Type == typeof(float) || value as Type == typeof(double) || value as Type == typeof(decimal))
                { range.NumberFormat = "0,00"; range.NumberFormatLocal = "0,00"; }
                else if (value as Type == typeof(DateTime))
                { range.NumberFormat = "dd.MM.yyy"; }
                else if (value as Type == typeof(char))
                { range.NumberFormat = "@"; }
                else
                { range.NumberFormat = "@"; } //convert to string for other data type so the data is preserved  
            }
            range.Value = range.Value;
        }

        /// <summary>
        /// Gets the number of sheets.
        /// </summary>
        /// <returns>Returns an integer with number of worksheets from current workbook. </returns>
        public int GetNumberOfSheets()
        {
            return Wb.Sheets.Count;
        }

        public List<string> GetSheetNames()
        {
            try
            {
                List<string> woNames = new List<string>();
                foreach (Excel.Worksheet ws in Wb.Worksheets)
                {
                    woNames.Add(ws.Name);
                }
                return woNames;
            }
            catch (Exception)
            {
                return new List<string>();
                throw new Exception("Error at ExcelHelper.GetSheetNames()");
            }
        }

        /// <summary>
        /// Determines whether a worksheet exist or not.
        /// </summary>
        /// <param name="worksheetName">Name of the worksheet.</param>
        /// <returns>true if worksheet exist or false if dosen't exist</returns>
        private bool IsWorksheetExist(string worksheetName)
        {
            bool isExist = false;

            if (Wb.Sheets != null)
                foreach (Excel.Worksheet sheet in Wb.Sheets)
                {
                    if (sheet.Name == worksheetName)
                    {
                        index = sheet.Index;
                        isExist = true;
                        break;
                    }
                }
            return isExist;
        }

        /// <summary>
        /// Create a new workbook.
        /// If already a instance of an workbook exist the method return false and a message to close the 
        /// current instance with or without saving. 
        /// </summary>
        /// <param name="numberOfSheets">The number of empty worksheets that workbook opens at start.</param>
        /// <returns>True or False</returns>
        public bool NewWorkbook(int numberOfSheets = 1) //Default number of sheets at start. It's mandatory to be at least 1
        {
            bool wasCreatedNewWorkbook = false;
            if (!(numberOfSheets < 1))
            {
                if (Wb == null)
                {
                    try
                    {
                        ExcelApp.SheetsInNewWorkbook = numberOfSheets;
                        Wb = ExcelApp.Workbooks.Add(Type.Missing);
                        wasCreatedNewWorkbook = true;
                        wbStatus = true;
                    }
                    catch (Exception)
                    {
                        return false;
                        throw new Exception("Excel is missing or is not properly installed");
                    }
                }
                else { throw new Exception("Please close the current Workbook"); }
            }
            else { throw new Exception("Number of sheets must be equal or greater than one"); }
            return wasCreatedNewWorkbook;
        }

        public bool OpenWorkbook(string fullFilePath, bool excelVisible = true)
        {
            //close old workbook             
            CloseWorkbook();
            try
            {
                //open new workbook
                Wb = ExcelApp.Workbooks.Open(fullFilePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                if (excelVisible)
                {
                    ExcelApp.Visible = true;
                    ExcelApp.WindowState = Excel.XlWindowState.xlMinimized;
                    wbStatus = true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw new Exception("Error at ExcelHelper.OpenWorbook()");
            }
        }

        public bool ReadWorksheet(string worksheetName, out object[,] myValues)
        {
            try
            {
                //open worksheet
                if (!GetSheetNames().Contains(worksheetName))
                {

                    myValues = new string[0, 0];
                    return false;
                    throw new Exception("Sheet '" + worksheetName + "' isn't part of workbook " + Wb.FullName);
                }
                Excel.Worksheet ws = (Excel.Worksheet)Wb.Worksheets[worksheetName];


                Excel.Range range = ws.UsedRange;
                myValues = (object[,])range.Cells.Value;
                Marshal.ReleaseComObject(ws);
                return true;
            }
            catch (Exception)
            {
                myValues = new string[0, 0];
                return false;
                throw new Exception("Error at ExcelHelper.ReadWorksheet()");
            }
        }

        public bool ReadWorksheet(string worksheetName, bool detectDataTypeBySecondRow, out DataTable result)
        {
            try
            {
                /*open worksheet*/
                if (!GetSheetNames().Contains(worksheetName))
                {
                    result = new DataTable();
                    return false;
                    throw new Exception("Error at ExcelHelper.ReadWorksheet() Sheet '" + worksheetName + "' isn't part of workbook " + Wb.FullName);
                }
                Excel.Worksheet ws = (Excel.Worksheet)Wb.Worksheets[worksheetName];

                /*create and fill datatable*/
                result = new DataTable();
                Excel.Range excelCell = ws.UsedRange;
                Object[,] values = (Object[,])excelCell.Value;
                int intRows = values.GetLength(0);
                int intCols = values.GetLength(1);

                if ((intRows == 0) | intCols == 0)
                {
                    return true; //no data
                }

                /*detect cell types and create columns*/
                if (detectDataTypeBySecondRow)
                {
                    for (int col = 1; col <= intCols; col++)
                    {
                        if (intRows > 1)
                        {
                            result.Columns.Add((String)values[1, col], values[2, col].GetType()); //detect cell type
                        }
                        else
                        {
                            result.Columns.Add((String)values[1, col], typeof(string));
                        }
                    }
                }
                else
                {
                    for (int col = 1; col <= intCols; col++)
                    {
                        result.Columns.Add((String)values[1, col], typeof(string));
                    }
                }

                /*fill datatable*/
                for (int row = 2; row <= intRows; row++)
                {
                    DataRow dr = result.NewRow();
                    for (int col = 1; col <= intCols; col++)
                    {
                        dr[(String)values[1, col]] = values[row, col];
                    }
                    result.Rows.Add(dr);
                }

                Marshal.ReleaseComObject(ws);
                return true;
            }
            catch (Exception)
            {
                result = new DataTable();
                return false;
                throw new Exception("Error at ExcelHelper.ReadWorksheet()");
            }
        }

        /// <summary>
        /// Tries if file is open.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>True or False</returns>
        private bool TryIfFileIsOpen(string filePath)
        {
            bool isOpen = false;
            try
            {
                if (File.Exists(filePath))
                {
                    Stream testFile = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                    testFile.Close();
                    isOpen = false;
                }
                else
                    isOpen = false;
            }
            catch (Exception)
            {
                return true;
            }
            return isOpen;
        }

        /// <summary>
        /// Saves an old workbook whith a different name.
        /// or a new created workbook</summary>
        /// <param name="filePath">The file path where user wishes to save the workbook</param>
        /// <returns>True if operation succeded or false if fails</returns>
        public bool SaveAsWorkbook(string filePath)
        {
            bool wasSaved = false;
            if (!TryIfFileIsOpen(filePath))
            {
                try
                {
                    if (filePath.EndsWith(".xlsx"))
                        Wb.SaveAs(filePath, Excel.XlFileFormat.xlOpenXMLWorkbook, Type.Missing, Type.Missing, false,
                                    false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    else
                    {
                        Wb.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, false,
                                 false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlUserResolution,
                                 Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    }
                    wasSaved = true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw ex;
                }
                finally
                {
                    Dispose();
                }
            }
            else
            { throw new Exception("File is in use Please close it"); }
            return wasSaved;
        }

        /// <summary>
        /// Saves an opened workbook.
        /// </summary>
        /// <returns>True or False</returns>
        public bool SaveWorkbook()
        {
            bool wasSaved = false;
            try
            {
                Wb.Save();
                wasSaved = true;
            }
            catch (Exception ex)
            {
                Dispose();
                return false;
                throw ex;
            }
            return wasSaved;
        }

        /// <summary>
        /// Sets the current worksheet.
        /// </summary>
        /// <param name="worksheetName">Name of the worksheet to be make current.</param>
        /// <returns>Excel Worksheet instance</returns>
        private Excel.Worksheet SetCurrentWorksheet(string worksheetName)
        {
            Excel.Worksheet l_Ws = null;
            if (IsWorksheetExist(worksheetName))
            {
                l_Ws = (Excel.Worksheet)Wb.Worksheets.get_Item(worksheetName);
            }
            else
            {
                return null;
                throw new Exception("Error Workbook or Worksheet is missing");
            }
            return l_Ws;
        }

        /// <summary>
        /// Writes the worksheet whit data from input DataTable.
        /// </summary>
        /// <param name="worksheetName">Name of the worksheet to be written.</param>
        /// <param name="input">A DataTable with information who needs to be written into a excel file</param>
        /// <param name="columnFormat">A Dictionary with name of column as a key and as a value an object with data types
        /// with whom user intend to format the column</param>
        public void WriteWorksheet(string worksheetName, DataTable input, Dictionary<string, object> columnFormat)
        {
            if (!IsWorksheetExist(worksheetName))
            {
                AddWorksheet(worksheetName);

                object[,] array = new object[input.Rows.Count, input.Columns.Count];
                //load datatable columns into a string array
                for (int i = 0; i < input.Columns.Count; i++)
                {
                    array[0, i] = input.Columns[i].ToString();
                }
                //load datatable rows in string array 
                for (int i = 1; i < input.Rows.Count; i++)
                {
                    for (int j = 0; j < input.Columns.Count; j++)
                    {
                        array[i, j] = input.Rows[i][j];
                    }
                }
                //set cell range where datatable will be write
                var startCell = (Excel.Range)Ws.Cells[1, 1];
                var endCell = (Excel.Range)Ws.Cells[input.Rows.Count, input.Columns.Count];
                var writeRange = Ws.Range[startCell, endCell];
                //write in worksheet
                Ws = SetCurrentWorksheet(worksheetName);
                /**************************************************************************************************************/
                const int startRowIndex = 2; //-First Row is table header - Excel tables are index 1 based 
                foreach (var x in columnFormat)
                {
                    int columnIndex = input.Columns.IndexOf(x.Key) + 1;
                    int rowIndex = input.Rows.Count;
                    FormatWorksheet(Ws, columnIndex, startRowIndex, columnIndex, rowIndex, x.Value);
                }
                /***************************************************************************************************************/
                writeRange.Value2 = array;
            }
            else
            { throw new Exception(" Error Worksheet worksheetName already exist"); }
        }

        /// <summary>
        /// Writes the worksheet.
        /// </summary>
        /// <param name="worksheetName">Name of the worksheet.</param>
        /// <param name="input">The input.</param>
        public void WriteWorksheet(string worksheetName, DataTable input)
        {
            if (!IsWorksheetExist(worksheetName))
            {
                AddWorksheet(worksheetName);

                object[,] array = new object[input.Rows.Count, input.Columns.Count];
                //load datatable columns into a string array
                for (int i = 0; i < input.Columns.Count; i++)
                {
                    array[0, i] = input.Columns[i].ToString();
                }
                //load datatable rows in string array 
                for (int i = 1; i < input.Rows.Count; i++)
                {
                    for (int j = 0; j < input.Columns.Count; j++)
                    {
                        array[i, j] = input.Rows[i][j];
                    }
                }
                //set cell range where datatable will be write
                var startCell = (Excel.Range)Ws.Cells[1, 1];
                var endCell = (Excel.Range)Ws.Cells[input.Rows.Count, input.Columns.Count];
                var writeRange = Ws.Range[startCell, endCell];
                //write in worksheet
                Ws = SetCurrentWorksheet(worksheetName);
                writeRange.Value2 = array;
            }
            else
            { throw new Exception("Worksheet worksheetName already exist"); }
        }

        /// <summary>
        /// Creates the pivot table.
        /// </summary>
        /// <param name="pivotTableName">Name of the pivot table.</param>
        /// <param name="worksheetName">Name of the worksheet.</param>
        /// <param name="formater">A dictionary whit Dictionary(string, Tuple(Excel.XlPivotFieldOrientation, Excel.XlConsolidationFunction)).</param>
        public void CreatePivotTable(string pivotTableName, string worksheetName, Dictionary<string, Tuple<Excel.XlPivotFieldOrientation, Excel.XlConsolidationFunction>> formater)
        {
            Ws = SetCurrentWorksheet(worksheetName);

            Excel.Range m_Range = Ws.UsedRange;

            if (!IsWorksheetExist(pivotTableName))
                AddWorksheet(pivotTableName);
            else
                Ws = SetCurrentWorksheet(pivotTableName);

            Excel.Range startPivot = (Excel.Range)Ws.Cells[1, 1];
            try
            {

                Excel.PivotCache m_PivotCache = Wb.PivotCaches().Add(Excel.XlPivotTableSourceType.xlDatabase, m_Range);
                Excel.PivotTable m_PivotTable =
                 (Excel.PivotTable)Ws.PivotTables().Add(PivotCache: m_PivotCache, TableDestination: startPivot, TableName: pivotTableName);
                foreach (string f in formater.Keys)
                {

                    Excel.PivotField m_PivotField =
                     (Excel.PivotField)m_PivotTable.PivotFields(f);
                    m_PivotField.Orientation = formater[f].Item1;
                    if (formater[f].Item2 != Excel.XlConsolidationFunction.xlUnknown)
                    {
                        m_PivotField.Function = formater[f].Item2;
                    }
                    m_PivotField.Name = " " + f;
                }
            }
            catch (Exception)
            {
                Dispose();
                throw new Exception("Error creating PivotTable");
            }

        }

    }

}

