using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

public class Program
{
    private static string ROOTFOLDER = @"D:\FromFolder";
    private static string DESTINATIONFOLDER = @"D:\ToFolder";

    static void Main(string[] args)
    {
		string[] folders = new string[]{
			"Store A",
			"Store B",
			"Store C",
		};
		Console.WriteLine("Start copy");
		List<Task> tasks = new List<Task>();
		foreach (var folder in folders)
		{
			tasks.Add(Task.Factory.StartNew(() =>
			{
				var files = Directory.EnumerateFiles(Path.Combine(ROOTFOLDER, folder), "*");
				foreach (var file in files)
				{
					File.Copy(file, Path.Combine(DESTINATIONFOLDER, Path.GetFileName(file)));
					Console.WriteLine(file + " is copied successfully.");
				}
			}));
		}

		Task.WhenAll(tasks.ToArray());
		Console.ReadLine();
	}
}