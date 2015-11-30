
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Colors;
using System.Collections.Generic;
using System;

namespace TestObjectARX
{
    [assembly: CommandClass(typeof(TestObjectARX.CommandClass))]

    public class CommandClass
    {
        /************************************************************************************************************************/
        [CommandMethod("coopct")]
        public void CooPct()
        {
            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;
            Editor ed = acDoc.Editor;

            Dictionary<DBText, DBPoint> vertexPoly = new Dictionary<DBText, DBPoint>();

            string sLayerNamePct = "pctContur";
            string sLayerNameTxt = "nrContur";
            string filePath = acDoc.Name;
            int nrPct = 1;
            PromptEntityResult pResult = ed.GetEntity("Select Polyline ");
            if (pResult.Status == PromptStatus.OK)
            {
                using (Transaction trans = acCurDb.TransactionManager.StartTransaction())
                {
                    BlockTable blkTb = trans.GetObject(acCurDb.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord blkTbRec = trans.GetObject(blkTb[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                    DBObject obj = trans.GetObject(pResult.ObjectId, OpenMode.ForRead);
                    Polyline poly = (Polyline)obj;
                    if (poly != null)
                    {
                        LayerHelper.CreateLayer(acDoc, sLayerNamePct, Color.FromColorIndex(ColorMethod.ByAci, 3));
                        LayerHelper.CreateLayer(acDoc, sLayerNameTxt, Color.FromColorIndex(ColorMethod.ByAci, 1));
                        for (int i = 0; i < poly.NumberOfVertices; i++)
                        {
                            vertexPoly.Add(new DBText(), new DBPoint(poly.GetPoint3dAt(i)));
                        }
                    }
                    foreach (var pct in vertexPoly)
                    {
                        pct.Value.Layer = sLayerNamePct;
                        blkTbRec.AppendEntity(pct.Value);
                        trans.AddNewlyCreatedDBObject(pct.Value, true);
                        pct.Key.SetDatabaseDefaults();
                        pct.Key.Layer = sLayerNameTxt;
                        pct.Key.TextString = nrPct.ToString();
                        pct.Key.Height = 1.5;
                        pct.Key.Position = pct.Value.Position;
                        nrPct++;
                        blkTbRec.AppendEntity(pct.Key);
                        trans.AddNewlyCreatedDBObject(pct.Key, true);
                    }
                    acCurDb.Pdmode = 32;
                    acCurDb.Pdsize = 0.25;
                    trans.Commit();
                }
            }

            CSVHelper write = new CSVHelper(filePath);
            write.WriteCoordTable(vertexPoly);
            PromptPointResult pickPoint = ed.GetPoint("Pick Table Insertion Point");
            Point3d insertionPoint = pickPoint.Value;
        }

        /*************************************Suprafete Utile Releveu***************************************/

        [CommandMethod("SupUtil")]

        public void SupUtil()
        {
            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;
            Editor ed = acDoc.Editor;
            List<Incapere> incapere;
            PromptIntegerOptions scaraOpt = new PromptIntegerOptions("Scara planului 1: ");
            PromptIntegerResult scaraResult = ed.GetInteger(scaraOpt);
            SelecteazaIncapere(out incapere, ed, acCurDb);
            TableHelper tb = new TableHelper(acDoc);
            tb.DrawSupUtilTabel(incapere, "Releveu parter");
        }
        private void SelecteazaIncapere(out List<Incapere> incapere, Editor ed, Database acCurDb)
        {
            //int nrIncapere = 1;
            bool selectez = true;
            incapere = new List<Incapere>();
            while (selectez)
            {
                PromptEntityResult select = ed.GetEntity("Selecteaza Incapere");
                if (select.Status == PromptStatus.OK)
                {
                    using (Transaction trans = acCurDb.TransactionManager.StartTransaction())
                    {
                        Incapere camera = new Incapere();
                        DBObject obj = trans.GetObject(select.ObjectId, OpenMode.ForRead);
                        if (obj.GetType() == typeof(Polyline))
                        {
                            Polyline poly = (Polyline)obj;
                            camera.SuprafataIncapere = poly.Area;
                            PromptResult result;
                            PromptStringOptions interogare;
                            interogare = new PromptStringOptions("\nNr. Incapere: ");
                            result = ed.GetString(interogare);
                            camera.NrIncapere = result.StringResult;
                            interogare = new PromptStringOptions("\nDestinatie Incapere: ");
                            result = ed.GetString(interogare);
                            camera.DestinatieIncapere = result.StringResult;
                            incapere.Add(camera);
                        }
                        else
                        { ed.WriteMessage("\nEntitatea selectata nu este o polilinie"); }
                        trans.Commit();
                    }
                }
                else
                { selectez = false; }
            }
        }

    }//end of Class

}//end of NameSpace
