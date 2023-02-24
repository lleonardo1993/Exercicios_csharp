using System;
using System.IO;

namespace Pathh
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            // função pega o separador do path \
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);

            // função pega o diretorio do path 
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));

            // função pega o separador do path ;
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);

            // função pega o nome do arquivo
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));

            // função pega o nome do arquivo sem extensao
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));

            // função pega só a extensao
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));

            // função pega todo o caminho do arquivo
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            // função pega a pasta temporaria do sistema
            Console.WriteLine("GetTempPath:" + Path.GetTempPath());
        }
    }
}
