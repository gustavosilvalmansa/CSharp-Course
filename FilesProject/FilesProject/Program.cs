using System;
using System.IO;

namespace FilesProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string SourcePath = @"C:\projetos\FilesProject\file.txt";
            string TargetPath = @"C:\projetos\FilesProject\file2.txt";
            try { 
                FileInfo fileInfo = new FileInfo(SourcePath);
                fileInfo.CopyTo(TargetPath);

            }
            catch (IOException ioEx)
            {
                Console.WriteLine($"An error occurred: {ioEx.Message}");
            }
            /*
            string filePath = "file.txt";
            // Write to a file
            File.WriteAllText(filePath, "Hello, World!");
            // Read from a file
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            // Append to a file
            File.AppendAllText(filePath, "\nAppended text.");
            content = File.ReadAllText(filePath);
            Console.WriteLine(content);
            // Delete the file
            File.Delete(filePath);
            Console.WriteLine("File deleted.");
            */
        }
    }
}