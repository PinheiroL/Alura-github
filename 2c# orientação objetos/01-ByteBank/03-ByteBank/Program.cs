using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Lucas";
            cliente.Profissao = "Vendedor";
            cliente.CPF = "111.222.333-44";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Saldo);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();
        }
    }
}
