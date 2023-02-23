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
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); //listar pastas dentro do diretorio
                Console.WriteLine("FOLDERS: ");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
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
