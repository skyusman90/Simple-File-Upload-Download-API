﻿namespace FTPFileApp.Helper
{
    public static class Common
    {
        public static string GetCurrentDirectory()
        {
            var result = Directory.GetCurrentDirectory();
            return result;
        }

        public static string GetStaticContentDirectory()
        {
            var result = Path.Combine(Directory.GetCurrentDirectory(), "Uploads\\StaticContent\\");
            if (!Directory.Exists(result))
            {
                Directory.CreateDirectory(result);
            }
            return result;
        }

        public static string GetFilePath(string fileName)
        {
            var _getStaticContentDirectory = GetStaticContentDirectory();
            var result = Path.Combine(_getStaticContentDirectory, fileName);
            return result;
        }
    }
}
