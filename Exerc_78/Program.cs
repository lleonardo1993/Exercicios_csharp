using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Add, adiciona o elemento na lista (Por padrão adiciona a o final da lista).
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // Insert, insere o elemento na posição desejada.
            list.Insert(2, "Marco");



            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // Count, Mostra o tamanho da Lista.
            Console.WriteLine("List count : " + list.Count);

            // Find, recebendo como parametro uma expressão lambda, Retornando a primeira ocorrência
            //que começa com a letra 'A'.
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A' : " + s1);

            // Find, recebendo como parametro uma expressão lambda, Retornando a ultima ocorrência
            //que começa com a letra 'A'.
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A' : " + s2);

            // FindIndex, retorna a posição do primeiro elemento que começa com a letra 'A'.
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos1);

            // FindIndex, retorna a posição do ultimo elemento que começa com a letra 'A'.
            int pos2 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A' : " + pos2);

            // FindAll, retorna todos os elementos que contém o tamanho no caso '5'.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("============================");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // Remove, remove um elemento da lista, Passando como parâmentro a string.
           // list.Remove("Alex");
            Console.WriteLine("-----------------------------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            // RemoveAll, remove todos os elementos que contém a string 'M', Passada como parâmetro.
            //list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            // RemoveAll, remove o elemento pela sua posição.
            //list.RemoveAt(3);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            
            // RemoveRange, Remove apartir da posição passada como argumento '2', quero remover '2' Elementos.
            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }



        }
    }
}
