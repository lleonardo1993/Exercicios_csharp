using Exec_233_Action_ForEach.Entities;

namespace Exec_233_Action_ForEach
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

            list.ForEach(UpdatePrice);

            foreach(Product product in list)
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
        }


        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}