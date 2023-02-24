using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryDirectoriInfo_200
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder";


            try
            {
                //listar pastas dentro do diretorio

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); 
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                //listar arquivos dentro do diretorio

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); 
                Console.WriteLine("FILES: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //criar pasta dentro de diretorio

                Directory.CreateDirectory(path + "\\newfolder");
                Console.WriteLine("Pasta criada!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
