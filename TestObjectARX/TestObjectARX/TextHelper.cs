using System;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices;


namespace TestObjectARX
{
    public static class TextHelper
    {
        public static bool CreateTextStyle(Document doc, string styleName, string fontName)
        {
            Database db = doc.Database;
            bool isSucceded = false;
            using (Transaction tr = db.TransactionManager.StartTransaction())
            {
                TextStyleTable newTextStyle = tr.GetObject(db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                if (!newTextStyle.Has(styleName))
                {
                    try
                    {
                        newTextStyle.UpgradeOpen();
                        TextStyleTableRecord newTextStyleRec = new TextStyleTableRecord();
                        newTextStyleRec.FileName = fontName;
                        newTextStyleRec.Name = styleName;
                        newTextStyle.Add(newTextStyleRec);
                        tr.AddNewlyCreatedDBObject(newTextStyleRec, true);
                        tr.Commit();
                        isSucceded = true;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    Editor ed = doc.Editor;
                    ed.WriteMessage("\nA text style with this name already exists\n");
                }
            }

            return isSucceded;
        }

    }
}
