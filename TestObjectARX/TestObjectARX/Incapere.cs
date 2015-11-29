using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.DatabaseServices;
namespace TestObjectARX
{
   public class Incapere
    {
       public string NrIncapere { get; set; }
       public string DestinatieIncapere { get; set; }
       public double SuprafataIncapere { get; set; }
       public ObjectId PolyID { get; set; }
       public string PolyName { get; set; }
    }
}
