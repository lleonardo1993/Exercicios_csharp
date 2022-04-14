using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_82
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[,] matrix = new double[2, 3];

            // mat.Length mostra o tamanho da matrix.
            Console.WriteLine(matrix.Length);
            
            // mat.Rank mostra quanto a é a primeira posição da matrix.(quantida de linhas).
            Console.WriteLine("------------------");
            Console.WriteLine(matrix.Rank);

            // mat.GetLenght mostra a quantidade de linhas na primeira dimensão da matrix.
            Console.WriteLine("------------------");
            Console.WriteLine(matrix.GetLength(0));

            // mat.GetLenght mostra a quantidade de linhas na Segunda dimensão da matrix.
            Console.WriteLine("------------------");
            Console.WriteLine(matrix.GetLength(1));

            // Exercicio
            Console.WriteLine("Exercicio");
            Console.WriteLine("============================================================");
            Console.WriteLine();
           
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            // Primeiro for, percorre as linhas da matrix
            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                // Segundo for, percorre as colunas da matrix
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.Write("Main diagonal : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " " );
            }
            Console.WriteLine();
            // Estrutura basica para se percorrer uma matrix inteira, linhas e colunas.
            // For para percorrer as linha
            int count = 0;
            for (int i = 0; i <n; i++) { 
                // For para percorrer as colunas
                for (int j = 0; j < n; j++)
                {
                    if(mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers :" + count);
           
        }
    }
}
