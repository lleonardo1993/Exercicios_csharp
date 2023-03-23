using Exerc_234_Func_Select.Entities;

namespace Exerc_234_Func_Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));


            List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // passando expressao lambda in line

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

    }
}