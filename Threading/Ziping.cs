using System.IO.Compression;

namespace LiteCodeLibrary.Threading
{
    public static class Ziping
    {
        public static void UnarchiveZip(string archivePath, string extractPath)
        {
            ZipFile.ExtractToDirectory(archivePath, extractPath);
        }

        public static void ArchiveZip(string archivePath, string filesPath)
        {
            ZipFile.CreateFromDirectory(filesPath, archivePath);
        }

        public static void ArchiveOpen(string archivePath, ZipArchiveMode mainMode)
        {
            ZipFile.Open(archivePath, mainMode);
        }
    }
}
