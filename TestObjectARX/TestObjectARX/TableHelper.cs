using System.Collections.Generic;
using System.Linq;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.EditorInput;
namespace TestObjectARX
{
    public class TableHelper
    {
        Point3d insertionPoint;
        Document m_doc;
        Database m_db;
        const float rowHeigh = 0.1334f;
        public TableHelper(Document doc)
        {
            this.m_doc = doc;
            this.m_db = this.m_doc.Database;
            insertionPoint = new Point3d(0.0, 0.0, 0.0);
        }

        public TableHelper(Document doc, Point3d insertionPoint)
        {
            this.m_doc = doc;
            this.m_db = this.m_doc.Database;
            this.insertionPoint = insertionPoint;
        }

        public void DrawCoordTable(Dictionary<DBText, DBPoint> vertexCoords)
        {
            List<Line3d> tableLines = new List<Line3d>();

        }

        public void DrawSupUtilTabel(List<Incapere> camera, string titluTabel)
        {
            const double inaltimeText = 0.2;
            const int colorIndex = 7; //alb
            const int nrColoane = 3;
            int nrRanduri = camera.Count() + 4;
            bool existLayer = false;
            string[] header = { "Nr.crt", "Destinatie incapere", "Supraf.Utila [mp]" };
            Color layerColor = Color.FromColorIndex(ColorMethod.ByAci, colorIndex);
            existLayer = LayerHelper.CreateLayer(m_doc, "Plansa", layerColor);
            TextHelper.CreateTextStyle(m_doc, "Arial", "arial.shx");
            PromptPointResult insertionPoint = m_doc.Editor.GetPoint("\nSelecteaza punctul de insertie al tabelului");
            if (insertionPoint.Status == PromptStatus.OK)
            {

                Table supTable = new Table();
                if (existLayer)
                    supTable.Layer = "Plansa";
                supTable.TableStyle = m_db.Tablestyle;
                supTable.NumColumns = nrColoane;
                supTable.NumRows = nrRanduri;
                //supTable.SetColumnWidth(0.6);
                supTable.SetRowHeight(0.25);
                supTable.Position = insertionPoint.Value;
                /*********** Tabel Title **************/
                supTable.SetTextHeight(0, 0, 0.22);
                supTable.SetTextString(0, 0, titluTabel);
                supTable.SetAlignment(0, 0, CellAlignment.MiddleCenter);
                /*********** Table Header *************/
                for (int i = 0; i < nrColoane; i++)
                {
                    supTable.SetTextHeight(1, i, 0.2);
                    supTable.SetTextString(1, i, header[i].ToString());
                    supTable.SetAlignment(1, i, CellAlignment.MiddleCenter);
                }

                Incapere[] inc = camera.ToArray();
                for (int i = 2; i < inc.Length; i++)
                {
                    supTable.SetTextHeight(i, 0, 0.2);
                    supTable.SetTextHeight(i, 1, 0.2);
                    supTable.SetTextHeight(i, 2, 0.2);

                    supTable.SetTextString(i, 0, inc[i].NrIncapere.ToString());
                    supTable.SetTextString(i, 1, inc[i].DestinatieIncapere.ToString());
                    supTable.SetTextString(i, 2, inc[i].SuprafataIncapere.ToString());

                    supTable.SetAlignment(i, 0, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i, 1, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i, 2, CellAlignment.MiddleCenter);
                }
                supTable.GenerateLayout();

                using (Transaction tran = m_db.TransactionManager.StartTransaction())
                {
                    BlockTable blkTb = tran.GetObject(m_db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord blkTbRec = tran.GetObject(blkTb[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    blkTbRec.AppendEntity(supTable);
                    tran.AddNewlyCreatedDBObject(supTable, true);
                    tran.Commit();
                }

            }

        }

        private void CreateTableStyle(string tableStyleName, string textStyleName, LineWeight lineWeight)
        {

            using (Transaction tr = m_db.TransactionManager.StartTransaction())
            {
                ObjectId tsObjID = ObjectId.Null;
                DBDictionary dbDic = tr.GetObject(m_db.TableStyleDictionaryId, OpenMode.ForRead) as DBDictionary;
                if (dbDic.Contains(tableStyleName))
                {
                    tsObjID = dbDic.GetAt(tableStyleName);
                }
                else
                {
                    TableStyle newTs = new TableStyle();
                    TextStyleTable test = tr.GetObject(m_db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                    if (test.Has(textStyleName))
                        newTs.SetTextStyle(m_db.TextStyleTableId, textStyleName);
                    newTs.SetGridLineWeight(lineWeight, (int)GridLineType.AllGridLines, (int)GridLineType.AllGridLines);
                }

                tr.Commit();
            }

        }
    }
}
