using System;
using System.ComponentModel;
using System.Net;

namespace LiteCode.Network
{
    public class Net
    {
        public static bool IsConnectionAvailable()
        {
            try
            {
                Dns.GetHostEntry("microsoft.net");
                return true;
            }
            catch 
            {
                return false; 
            }
        }

        //<summary><summary>
        //Обычный Метод Скачивания
        //<summary><summary>

        public static void Download(string adress, string path)
        {
            WebClient client = new WebClient();

            client.DownloadFile(adress, path);
            client.DownloadFileCompleted += DownloadCompleted;
            client.DownloadProgressChanged += DownloadChanged;
        }

        private static void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine($"Percentage : {e.ProgressPercentage}%" + " - Downloaded");
        }

        private static void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine($"LiteCode - Network : Download file completed, AsyncCompletedEventArgs : {e}");
        }

        //<summary><summary>
        //Асинхронный Метод Скачивания
        //<summary><summary>

        public static void AsyncDownload(Uri adress, string path)
        {
            WebClient client = new WebClient();

            client.DownloadFileAsync(adress, path);
            client.DownloadFileCompleted += AsyncDownloadCompleted;
            client.DownloadProgressChanged += AsyncDownloadChanged;
        }

        private static void AsyncDownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.WriteLine($"Percentage : {e.ProgressPercentage}%" + " - Downloaded");
        }

        private static void AsyncDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Console.WriteLine($"LiteCode - Network : Download file completed, AsyncCompletedEventArgs : {e}");
        }
    }
}
