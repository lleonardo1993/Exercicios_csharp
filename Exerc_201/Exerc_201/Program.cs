using Exerc_201.Entities;
using System;
using System.Globalization;
using System.IO;

namespace Exerc_201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: "); // digite o local do arquivo
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath); // faz a leitura do arquivo

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath); // pega o diretorio do arquivo
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath); // cria um arquivo summary.csv

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
