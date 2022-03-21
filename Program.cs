using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCs
{
    public class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(839, 8327483);

            Console.WriteLine(conta.Numero);
            Console.Write(conta.Agencia);

        }
    }
}