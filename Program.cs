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

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta2 = new ContaCorrente(834, 8323383);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


        }
    }
}