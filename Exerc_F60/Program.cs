using System;
using System.Globalization;

namespace ExercF_60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account count;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                count = new Account(numero, titular, depositoInicial);
            }
            else
            {
                count = new Account(numero, titular);
            }

            Console.Write("Entre com um valor para Depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            count.Deposito(quantia);
            Console.Write("Dados da conta Atualizados: ");
            Console.WriteLine(count);

            Console.Write("Entre com um valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            count.Saque(quantia);
            Console.Write("Dados da conta Atualizados: ");
            Console.WriteLine(count);

        }
    }
}
