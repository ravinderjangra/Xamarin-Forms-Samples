using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace XamarinFormsSQLite.iOS
{
    public class FileAccessHelper
    {
        public static string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryFolder = System.IO.Path.Combine(docFolder, "..", "Library");

            if (!System.IO.Directory.Exists(libraryFolder))
            {
                System.IO.Directory.CreateDirectory(libraryFolder);
            }

            return System.IO.Path.Combine(libraryFolder, filename);
        }
    }
}