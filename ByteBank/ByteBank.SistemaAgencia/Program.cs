using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(8484, 46548);

            new ContaCorrente(123456, 1651651);

            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta_2 = new ContaCorrente(456, 1651651);

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");

            }
            else
            {
                Console.WriteLine("Não são iguais");
            }



            Console.ReadLine();
        }
    }
}
