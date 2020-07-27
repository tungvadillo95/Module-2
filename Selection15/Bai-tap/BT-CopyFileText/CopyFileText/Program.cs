using System;
using System.IO;

namespace CopyFileText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter source file: ");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Enter destination file: ");
            string targetPath = Console.ReadLine();

            FileInfo source = new FileInfo(sourcePath);
            FileInfo target = new FileInfo(targetPath);
            try
            {
                CopyFileUsingFileInfo(source, target);
                Console.WriteLine("Copy Completed");
                using(StreamReader sr = File.OpenText(targetPath))
                {
                    string arr = sr.ReadToEnd();
                    Console.WriteLine($"File content: {arr}");
                    Console.WriteLine($"Number of characters in file: {arr.Length}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Cannot Copy");
                Console.Error.WriteLine(e.Message);
            }
        }
        private static void CopyFileUsingFileInfo(FileInfo source, FileInfo target)
        {
            source.CopyTo(target.FullName, false);
        }
    }
}
