using System;
using System.Collections.Generic;
using System.Text;
using Autodesk.AutoCAD.DatabaseServices;
using System.IO;
namespace TestObjectARX
{
    class CSVHelper
    {
        string filePath;
        public CSVHelper(string filePath)
        {
            this.filePath = ((filePath.Remove(filePath.Length - 4)) + "_Inventar.csv");
        }

        public CSVHelper()
        {
            this.filePath = @"C:\Inventar.csv";
        }

        public void WriteCoordTable(Dictionary<DBText,DBPoint> vertexPoly, string separator = ",")
        {
            using (StreamWriter write = new StreamWriter(filePath))
            {
                write.WriteLine("Nr.crt,X[m],Y[m]");
                foreach (var pct in vertexPoly)
                {
                    StringBuilder toWrite = new StringBuilder();
                    toWrite.Append(pct.Key.TextString);
                    toWrite.Append(separator);
                    toWrite.Append(Math.Round(pct.Value.Position.X,3).ToString("#.000"));
                    toWrite.Append(separator);
                    toWrite.Append(Math.Round(pct.Value.Position.Y, 3).ToString("#.000"));
                    write.WriteLine(toWrite);
                }
            }
        }
    }
}
