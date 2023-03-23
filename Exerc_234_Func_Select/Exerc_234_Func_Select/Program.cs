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

            //recebe um produto retorna uma string
            Func<Product, string> func = NameUpper;// referencia da funcao

            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}