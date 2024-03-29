using System;
using System.Globalization;

namespace Exerc_F60
{
    internal class Account
    {

        public int Numero { get; set; }
        public string Titular { get; private set; }

        public double Saldo { get; private set; }

        public Account(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Account(int numero, string titular, double saldo) : this(numero, titular)
        {

            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;

        }

        public override string ToString()
        {
            return
                "Conta"
                + Titular
                + ", Titular:"
                + Numero
                + ", Saldo $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
