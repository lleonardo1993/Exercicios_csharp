using System;
using System.IO;

namespace StreamWriter_198
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; //arquivo a ser modificado
            string targetPath = @"c:\temp\file1.txt"; // arquivo modificado

            try
            {
                string[] lines = File.ReadAllLines(sourcePath); //leitura do arquivo

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
