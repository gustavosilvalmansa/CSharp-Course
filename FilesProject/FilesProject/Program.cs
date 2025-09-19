using System;
using System.IO;

namespace FilesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"C:\projetos\FilesProject\";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(SourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                Directory.CreateDirectory(SourcePath + @"newfolder");


            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}