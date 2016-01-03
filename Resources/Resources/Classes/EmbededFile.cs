using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ProiectDeDiploma.Classes
{
   static class EmmbededFile
    {

       public static string Read(string resourcesName)
        {
            string content = null;
            var assambly = Assembly.GetExecutingAssembly();
            using (Stream stream = assambly.GetManifestResourceStream(resourcesName))
            using (StreamReader reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }
                return content;
        } 


    }
}
