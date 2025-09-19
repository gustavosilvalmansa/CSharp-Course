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

                //Playing with Paths
                Console.WriteLine("PATHS");
                Console.WriteLine(Path.GetFileName(SourcePath));
                Console.WriteLine(Path.GetFileNameWithoutExtension(SourcePath));
                Console.WriteLine(Path.GetDirectoryName(SourcePath));
                Console.WriteLine(Path.GetExtension(SourcePath));
                Console.WriteLine(Path.GetFullPath(SourcePath));
                Console.WriteLine(Path.GetTempPath());
                Console.WriteLine(Path.GetRandomFileName());
                Console.WriteLine(Path.Combine(SourcePath, "newfolder"));



            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}