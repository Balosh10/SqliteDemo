using System;
using System.IO;
using SQLite.Droid.Services;
using SQLite.Services;
using Xamarin.Forms

[assembly:Dependency(typeof(FileHelper))]
namespace SQLite.Droid.Services
{
    public class FileHelper : IFileHelpers
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}

