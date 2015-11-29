using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;

namespace TestObjectARX
{
    public class TableHelper
    {
        Point3d insertionPoint;

        public TableHelper () { insertionPoint = new Point3d(0.0, 0.0, 0.0); }

        public TableHelper (Point3d insertionPoint) { this.insertionPoint = insertionPoint; }

        public void CreateCoordTable (Dictionary<DBText, DBPoint> vertexCoords)
        {
            List<Line3d> tableLines = new List<Line3d>();

        }

    }
}
