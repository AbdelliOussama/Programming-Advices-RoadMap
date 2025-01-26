using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRun_Practise
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Task task1 = Task.Run(() => UploadFileToDrive("File1"));

            Task task2 = Task.Run(() => UploadFileToDrive("File2"));

            await Task.WhenAll(task1, task2);

            Console.WriteLine("All Files Were Uploaded Succesfully");

            Console.ReadKey();

            
        }

        public static void UploadFileToDrive(string filePath)
        {
            Console.WriteLine("File Started Uploading");
            Thread.Sleep(6000);

            Console.WriteLine($"{filePath}  Uploaded Succesfully");
        }
    }
}
