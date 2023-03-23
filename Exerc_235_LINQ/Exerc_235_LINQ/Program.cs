namespace Exerc_235_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = { 1, 2, 3, 4, 5, 6, };

            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0) // expressao lambda, faz uma consulta no array filtrando somente os numeros pares.
                .Select(x => x * 10); // pega o valor da consulta e multiplica por 10.


            // Execute the query

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}