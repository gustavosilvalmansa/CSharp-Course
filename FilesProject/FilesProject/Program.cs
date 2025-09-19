using System;
using System.IO;

namespace FilesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\projetos\FilesProject\file.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied: {ex.Message}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"I/O error: {ex.Message}");
            }
            finally
            {
                sr?.Close();
            }

        }
    }
}