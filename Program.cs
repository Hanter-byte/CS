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
            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();

            conta.titular.nome = "João";
            conta.titular.cpf = "123.345.532-20";
            conta.titular.profissao = "Developer";

            conta.saldo = 100;
            conta.numeroAgencia = 563;
            conta.numero = 5634527;

            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.cpf);
            Console.WriteLine(conta.titular.profissao);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.numeroAgencia);









        }
    }
}