using System.IO.Compression;

namespace LiteCode.Threading
{
    public class Ziping
    {
        public static void UnarchiveZip(string archivePath, string extractPath)
        {
            ZipFile.ExtractToDirectory(archivePath, extractPath);
        }

        public static void ArchiveZip(string archivePath, string filesPath)
        {
            ZipFile.CreateFromDirectory(filesPath, archivePath);
        }
    }
}
