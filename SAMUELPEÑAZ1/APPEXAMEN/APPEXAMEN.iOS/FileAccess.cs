using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace APPEXAMEN.iOS
{
    class FileAccess
    {

        public static string GetLocalFilePath(string fileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(path, fileName);
        }

    }
}