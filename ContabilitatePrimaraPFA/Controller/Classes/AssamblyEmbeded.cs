namespace ContabilitatePrimaraPFA.Classes
{
    using System.IO;
    using System.Reflection;
    static class AssamblyEmbeded
    {
        public static string Read (string resourcesName)
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
