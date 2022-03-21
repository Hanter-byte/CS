# Versões antigas
--

            int valorTranferirInt;
            String valorTranferirString;
            string minhaConta;
            string contaRecebe;

            ContaCorrente um = new ContaCorrente();
            // um.titular.nome = "João";
            um.saldo = 100;

            ContaCorrente dois = new ContaCorrente();
            //dois.titular.nome = "Sabrina";
            dois.saldo = 100;


            Console.Write("Sua conta: ");
            minhaConta = Console.ReadLine();

            if (minhaConta != "um" && minhaConta != "dois")
            {

                Console.WriteLine("Conta invalida!");

            }
            else
            {

                Console.Write("Conta que recebera: ");
                contaRecebe = Console.ReadLine();

                Console.Write("Valor da transferencia: ");
                valorTranferirString = Console.ReadLine();
                valorTranferirInt = Int32.Parse(valorTranferirString);
                
            }

            Console.WriteLine(um.titular + " " + um.saldo);
            Console.WriteLine(dois.titular + " " + dois.saldo);