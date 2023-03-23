using Exerc_232_exemplo_RemoveAll_.Entities;

namespace Exerc_232_exemplo_RemoveAll_


{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.10));
            list.Add(new Product("Mouse", 50.40));
            list.Add(new Product("Tablet", 350.30));
            list.Add(new Product("HD Case", 90.20));


            list.RemoveAll(ProductTest);

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}