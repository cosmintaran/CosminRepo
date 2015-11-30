using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Interop;
namespace TestObjectARX
{
    public class TableHelper
    {
        Point3d insertionPoint;
        Document doc;
        Database db;
        const float rowHeigh = 0.1334f;
        public TableHelper(Document doc)
        {
            this.doc = doc;
            this.db = this.doc.Database;
            insertionPoint = new Point3d(0.0, 0.0, 0.0);
        }

        public TableHelper(Document doc, Point3d insertionPoint)
        {
            this.doc = doc;
            this.db = this.doc.Database;
            this.insertionPoint = insertionPoint;
        }

        public void DrawCoordTable(Dictionary<DBText, DBPoint> vertexCoords)
        {
            List<Line3d> tableLines = new List<Line3d>();

        }

        public void DrawSupUtilTabel(List<Incapere> camera, string titluTabel)
        {
            const double inaltimeText = 0.002; //unitatea de masura metru
            const int colorIndex = 7; //alb
            const int nrColoane = 3;
            int nrRanduri = camera.Count();
            bool existLayer = false;
            string[] header = { "Nr.crt", "Destinatie incapere", "Supraf.Utila", "[mp]" };
            Color layerColor = Color.FromColorIndex(ColorMethod.ByAci, colorIndex);
            existLayer = LayerHelper.CreateLayer(doc, "Plansa", layerColor);
            PromptPointResult insertionPoint = doc.Editor.GetPoint("\nSelecteaza punctul de insertie al tabelului");
            if (insertionPoint.Status == PromptStatus.OK)
            {
                Table supTable = new Table();
                supTable.TableStyle = db.Tablestyle;
                supTable.NumColumns = nrColoane;
                supTable.NumRows = nrRanduri;
                supTable.Position = insertionPoint.Value;

                for (int i = 0; i < nrColoane; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        supTable.SetTextHeight(i, j, 0.0025);
                        supTable.SetTextString(i, j, titluTabel);
                        supTable.SetAlignment(i, j, CellAlignment.MiddleCenter);
                        if (i == 0)
                            break;
                    }
                }
                if (existLayer)
                    supTable.Layer = "Plansa";

                Incapere[] inc = camera.ToArray();
                for (int i = 0; i < inc.Length; i++)
                {
                    supTable.SetTextHeight(i, 0, 0.0025);
                    supTable.SetTextHeight(i, 1, 0.0025);
                    supTable.SetTextHeight(i, 2, 0.0025);

                    supTable.SetTextString(i, 0, inc[i].NrIncapere.ToString());
                    supTable.SetTextString(i, 1, inc[i].DestinatieIncapere.ToString());
                    supTable.SetTextString(i, 2, inc[i].SuprafataIncapere.ToString());

                    supTable.SetAlignment(i, 0, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i, 1, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i, 2, CellAlignment.MiddleCenter);
                }
                supTable.GenerateLayout();

                using (Transaction tran = db.TransactionManager.StartTransaction())
                {
                    BlockTable blkTb = tran.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord blkTbRec = tran.GetObject(blkTb[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    blkTbRec.AppendEntity(supTable);
                    tran.AddNewlyCreatedDBObject(supTable, true);
                    tran.Commit();
                }

            }

        }


        public void DrawTabelSuprafeteUtile(List<Incapere> incapere, string numeTabel)
        {
            bool existLayer = false;
            const int colorIndex = 7; //alb
            int noOfRows = incapere.Count() + 3;
            const int noOfColumns = 2;
            PromptPointResult insertionPoint = doc.Editor.GetPoint("\nSelecteaza punctul de insertie al tabelului");
            if (insertionPoint.Status == PromptStatus.OK)
            {
                Color layerColor = Color.FromColorIndex(ColorMethod.ByAci, colorIndex);
                existLayer = LayerHelper.CreateLayer(doc, "Plansa", layerColor);
                Incapere[] arrIncapere = incapere.ToArray();
                DBText[,] scrisTabel = new DBText[noOfRows,noOfColumns];
                for (int i = 0; i < incapere.Count(); i++)
                {
                    for (int j = 0; j < noOfColumns; j++)
                    {
                        scrisTabel[i, j] = new DBText();

                    }
                }
            }
        }
    }
}
