using System.IO;
using LiteCodeLibrary.Additionals;

namespace LiteCodeLibrary.Threading
{
    public class FileSystem
    {
        #region Creating Region
        public static void CreateFile(string path, string name)
        {
            using (FileStream fs = File.Create(path + name))
            {

            }
        }

        public static void CreateFile(string path, string name, string type)
        {
            using (FileStream fs = File.Create(path + name + type))
            {

            }
        }

        public static void CreateFile(string path, string name, Enums.FileType fileType)
        {
            if(fileType == Enums.FileType.TextFile)
            {
                using (FileStream fs = File.Create(path + name + ".txt"))
                {

                }
            }
            else if (fileType == Enums.FileType.BatchFile)
            {
                using (FileStream fs = File.Create(path + name + ".bat"))
                {

                }
            }
            else if (fileType == Enums.FileType.BinaryFile)
            {
                using (FileStream fs = File.Create(path + name + ".bin"))
                {

                }
            }
            else if (fileType == Enums.FileType.LogFile)
            {
                using (FileStream fs = File.Create(path + name + ".log"))
                {

                }
            }
            else if (fileType == Enums.FileType.DllFile)
            {
                using (FileStream fs = File.Create(path + name + ".dll"))
                {

                }
            }
            else if (fileType == Enums.FileType.ExeFile)
            {
                using (FileStream fs = File.Create(path + name + ".exe"))
                {

                }
            }
        }
        #endregion

        #region Delete File
        public static void DeleteFile(string path)
        {
            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }

        public static void DeleteFile(string path, string name)
        {
            FileInfo fileInf = new FileInfo(path + name);

            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
        #endregion

        #region Move File
        public static void Move(string filePath, string outPath) 
        {
            FileInfo fileInf = new FileInfo(filePath);

            if (fileInf.Exists)
            {
                fileInf.MoveTo(outPath);
            }
        }
        #endregion
    }
}