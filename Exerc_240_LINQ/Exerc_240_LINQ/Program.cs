using Exerc_240_LINQ.Entities;


namespace Exerc_240_LINQ
{
    internal class Program
    {

        // função auxiliar impressão na tela foreach

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };


            List<Product> products = new List<Product>()
            {

                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // consulta com price menor q 900 da categoria = 1
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900 ", r1);
            // consulta where pegando valor da categoria.name, select pega o valor do where e só o valor do name
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);
            // consulta nome do obj que começa com 'c' e, utilizando obj anonymous.
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);
            // consulta ordenando por preço e por nome
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);
            // consulta pulando os 2 primeiros elementos com Skip, e pegou 4 elementos com Take.
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);
            // pegando primeiro elemento da lista
            var r6 = products.First();
            Console.WriteLine("First test 1 " + r6);
            // pega o primeiro elemento ou insere um null
            var r7 = products.FirstOrDefault();
            Console.WriteLine("First or default test 1 " + r7);
            // consulta o valor do Price > 3000.00, insere null se não tiver valor
            var r8 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("First or default test 2 " + r8);
            // consulta valor por Id, SingleOrdefault(), caso não existe o id retorna null
            var r9 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("SingleOrDefault " + r9);
            // consulta passando valor que não existe, retorno null
            var t1 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("SingleOrDefault tes2 null, " + t1);
            Console.WriteLine();
            // pegando valor max da consulta
            var t2 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + t2);
            // pegando valor min da consulta
            var t3 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + t3);
            // Soma dos preços da categoria 1
            var t4 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Pices: " + t4);
            // Média dos preços da categoria 1
            var t5 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average Prices: " + t5);
            // Atribuindo um valor default com DefaultIfEmpty, se o valor for null atribui um valor default no método DefaultIfEmpty
            var t6 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average Prices: " + t6);
            // Soma dos preços da categoria 1, passando uma função anonima no método Aggregate ( passando 0.0 no aggregate como valor inicial em caso de exception)
            var t7 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate Sum: " + t7);

            Console.WriteLine();

            // 
            var t8 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in t8)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
