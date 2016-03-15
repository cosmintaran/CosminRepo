using System.Collections.Generic;
using System.Linq;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.EditorInput;
using System;
namespace TestObjectARX
{
    public class TableHelper
    {
        Point3d insertionPoint;
        Document m_doc;
        Database m_db;
        const float m_rowHeigh = 0.1334f;
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
            const int nrColoane = 3;
            int nrRanduri = vertexCoords.Count+2;
            bool isLayerExist = false;
            ObjectId obTs = ObjectId.Null;
            Color layerColor = Color.FromColorIndex(ColorMethod.ByAci, 7);
            isLayerExist = LayerHelper.CreateLayer(m_doc, "tabelInventar", layerColor);
            TextHelper.CreateTextStyle(m_doc, "Arial", "arial.shx");
            CreateTableStyle("Inventar", "Arial", LineWeight.LineWeight018, out obTs);

            PromptPointResult insertionPoint = m_doc.Editor.GetPoint("\nSelecteaza punctul de insertie al tabelului");
            if (insertionPoint.Status == PromptStatus.OK)
            {

                Table invTable = new Table();
                if (isLayerExist)
                    invTable.Layer = "tabelInventar";

                if (obTs == ObjectId.Null)
                    invTable.TableStyle = m_db.Tablestyle;
                else
                    invTable.TableStyle = obTs;
                invTable.NumColumns = nrColoane;
                invTable.NumRows = nrRanduri;
                invTable.SetColumnWidth(0, 3);
                invTable.SetColumnWidth(1, 8);
                invTable.SetColumnWidth(2, 8);
                invTable.SetRowHeight(0, 0.9);
                invTable.SetRowHeight(1, 0.9);
                invTable.Position = insertionPoint.Value;

                /*********** Tabel Title **************/
                invTable.SetTextHeight(0, 0, 0.755);
                invTable.SetTextString(0, 0, "Inventar de coordonate");
                invTable.SetAlignment(0, 0, CellAlignment.MiddleCenter);

                /*********** Table Header *************/
                string[] header = { "Nr.\ncrt.", "X[m]", "Y[m]" };
                for (int i = 0; i < nrColoane; i++)
                {
                    invTable.SetTextHeight(1, i, 0.7);
                    invTable.SetTextString(1, i, header[i].ToString());
                    invTable.SetAlignment(1, i, CellAlignment.MiddleCenter);
                }
                int contor = 2;
                foreach (var entry in vertexCoords)
                {
                   
                    invTable.SetRowHeight(contor, 0.8);

                    invTable.SetTextHeight(contor, 0, 0.8);
                    invTable.SetTextHeight(contor, 1, 0.8);
                    invTable.SetTextHeight(contor, 2, 0.8);

                    invTable.SetTextString(contor, 0, (contor-1).ToString());
                    invTable.SetTextString(contor, 1, entry.Value.Position.Y.ToString("#.###"));
                    invTable.SetTextString(contor, 2, entry.Value.Position.X.ToString("#.###"));

                    invTable.SetAlignment(contor, 0, CellAlignment.MiddleCenter);
                    invTable.SetAlignment(contor, 1, CellAlignment.MiddleCenter);
                    invTable.SetAlignment(contor, 2, CellAlignment.MiddleCenter);
                    contor++;
                }

                using (Transaction tran = m_db.TransactionManager.StartTransaction())
                {
                    BlockTable blkTb = tran.GetObject(m_db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord blkTbRec = tran.GetObject(blkTb[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    blkTbRec.AppendEntity(invTable);
                    tran.AddNewlyCreatedDBObject(invTable, true);

                    tran.Commit();
                }
                using (Transaction tran = m_db.TransactionManager.StartTransaction())
                {
                    ObjectId tableID = invTable.ObjectId;
                    DBObjectCollection entitySet = new DBObjectCollection();
                    invTable.Explode(entitySet);

                    BlockTableRecord table = (BlockTableRecord)tran.GetObject(m_db.CurrentSpaceId, OpenMode.ForWrite);
                    foreach (DBObject obj in entitySet)
                    {
                        if (obj is Entity)
                        {
                            table.AppendEntity((Entity)obj);
                            tran.AddNewlyCreatedDBObject(obj, true);
                        }
                    }
                    tran.Commit();
                }

                using (Transaction tran = m_db.TransactionManager.StartTransaction())
                {
                    //BlockTable bTB = tran.GetObject(invTable.ObjectId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord bTBR = tran.GetObject(invTable.ObjectId, OpenMode.ForWrite) as BlockTableRecord;
                    invTable.Erase();
                    //bTBR.Erase(true);
                    tran.Commit();
                }

            }
        }

        public void DrawSupUtilTabel(List<Incapere> camera, string titluTabel)
        {
            const double inaltimeText = 0.2;
            const int colorIndex = 7; //alb
            const int nrColoane = 3;
            int nrRanduri = camera.Count() + 2;
            bool existLayer = false;
            ObjectId obTs = ObjectId.Null;
            string[] header = { "Nr.\nincapere", "Destinatie incapere", "Supraf.Utila\n [mp]" };
            Color layerColor = Color.FromColorIndex(ColorMethod.ByAci, colorIndex);
            existLayer = LayerHelper.CreateLayer(m_doc, "Plansa", layerColor);
            TextHelper.CreateTextStyle(m_doc, "Arial", "arial.shx");
            CreateTableStyle("Apartamentare", "Arial", LineWeight.LineWeight018,out obTs);
            PromptPointResult insertionPoint = m_doc.Editor.GetPoint("\nSelecteaza punctul de insertie al tabelului");
            if (insertionPoint.Status == PromptStatus.OK)
            {

                Table supTable = new Table();
                if (existLayer)
                    supTable.Layer = "Plansa";

                if (obTs == ObjectId.Null)
                    supTable.TableStyle = m_db.Tablestyle;
                else
                    supTable.TableStyle = obTs;

                supTable.NumColumns = nrColoane;
                supTable.NumRows = nrRanduri;
                supTable.SetColumnWidth(0, 1.92);
                supTable.SetColumnWidth(1, 5.35);
                supTable.SetColumnWidth(2, 3.5);
                supTable.SetRowHeight(0, 0.5);
                supTable.SetRowHeight(1, 0.9);
                supTable.Position = insertionPoint.Value;

                /*********** Tabel Title **************/
                supTable.SetTextHeight(0, 0, inaltimeText+0.05);
                supTable.SetTextString(0, 0, titluTabel);
                supTable.SetAlignment(0, 0, CellAlignment.MiddleCenter);

                /*********** Table Header *************/
                for (int i = 0; i < nrColoane; i++)
                {
                    supTable.SetTextHeight(1, i, 0.22);
                    supTable.SetTextString(1, i, header[i].ToString());
                    supTable.SetAlignment(1, i, CellAlignment.MiddleCenter);
                }

                Incapere[] inc = camera.ToArray();
                for (int i = 0; i < inc.Length; i++)
                {
                    supTable.SetRowHeight(i + 2, 0.35);

                    supTable.SetTextHeight(i+2, 0, 0.2);
                    supTable.SetTextHeight(i+2, 1, 0.2);
                    supTable.SetTextHeight(i+2, 2, 0.2);

                    supTable.SetTextString(i+2, 0, inc[i].NrIncapere.ToString());
                    supTable.SetTextString(i+2, 1, inc[i].DestinatieIncapere.ToString());
                    supTable.SetTextString(i+2, 2, Math.Round(inc[i].SuprafataIncapere,2).ToString());

                    supTable.SetAlignment(i+2, 0, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i+2, 1, CellAlignment.MiddleCenter);
                    supTable.SetAlignment(i+2, 2, CellAlignment.MiddleCenter);
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

        private void CreateTableStyle(string tableStyleName, string textStyleName, LineWeight lineWeight, out ObjectId tsObjID)
        {

            using (Transaction tr = m_db.TransactionManager.StartTransaction())
            {
                tsObjID = ObjectId.Null;
                DBDictionary dbDic = tr.GetObject(m_db.TableStyleDictionaryId, OpenMode.ForRead) as DBDictionary;
                if (dbDic.Contains(tableStyleName))
                {
                    tsObjID = dbDic.GetAt(tableStyleName);
                }
                else
                {
                    TableStyle newTs = new TableStyle();
                    TextStyleTable test = tr.GetObject(m_db.TextStyleTableId, OpenMode.ForRead) as TextStyleTable;
                    //if (test.Has(textStyleName))
                        //newTs.SetTextStyle(m_db.TextStyleTableId, textStyleName);
                    newTs.SetGridLineWeight(lineWeight, (int)GridLineType.AllGridLines, (int)GridLineType.AllGridLines);
                    tsObjID = newTs.PostTableStyleToDatabase(m_db, tableStyleName);
                    tr.AddNewlyCreatedDBObject(newTs, true);
                }

                tr.Commit();
            }

        }
    }
}
