using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Cosmetics_Store_Management_App.Controllers
{
    public static class FileHelper
    {
        public static Byte[] PathToBytes(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        public static Bitmap BytesToBitmap(Byte[] imageData)
        {
            using (var ms = new MemoryStream(imageData))
            {
                return new Bitmap(ms);
            }
        }
        public static bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    return false;
                }
            }
            catch (IOException)
            {
                return true;
            }
        }
    }
}
