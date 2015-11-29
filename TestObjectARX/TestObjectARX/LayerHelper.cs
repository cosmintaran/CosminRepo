using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.EditorInput;

namespace TestObjectARX
{
    static class LayerHelper
    {
        public static bool CreateLayer(Document doc, string layerName, Color layerColor)
        {
            bool isLayerCreated = false;
            Database acCurDb = doc.Database;
            Editor ed = doc.Editor;

            using (Transaction trans = acCurDb.TransactionManager.StartTransaction())
                {
                    LayerTable layTb = (LayerTable)trans.GetObject(acCurDb.LayerTableId, OpenMode.ForRead);
                    if (layTb.Has(layerName) == false)
                    {
                        using (LayerTableRecord layTbRec = new LayerTableRecord())
                        {
                            layTbRec.Color = layerColor;
                            layTbRec.Name = layerName;
                            layTb.UpgradeOpen();
                            layTb.Add(layTbRec);
                            trans.AddNewlyCreatedDBObject(layTbRec, true);
                            trans.Commit();
                            isLayerCreated = true;
                        }
                    }
                }

            return isLayerCreated;
        }
    }
}
