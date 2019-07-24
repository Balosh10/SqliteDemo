using System;
using System.IO;
using System.Runtime.CompilerServices;
using SQLite.iOS.Services;
using SQLite.Services;

[assembly: Dependency(typeof(FileHelper))]
namespace SQLite.iOS.Services
{
    public class FileHelper : IFileHelpers
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "DataBase");
            if (!Directory.Exists(libFolder))
                Directory.CreateDirectory(libFolder);

            return Path.Combine(docFolder,fileName);
        }
    }
}
