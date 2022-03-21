using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCs
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private int _numero;
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _numero = value;
                }
            }
        }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }
            }
        }
        private double _saldo; //Campo encapsulado;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    // return dentro do void para a execução do metodo;
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(int _agencia, int _numero) // Estanciando com valores pre definidos
        {
            Agencia = _agencia;
            Numero = _numero;
        }

        //Metodo com retorno
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo = this._saldo - valor;
                return true;
            }
        }

        //Metodo sem retorno
        public void Depositar(double valor)
        {
            this._saldo = this._saldo + valor;
        }

        //Metodo com retono
        public bool Tranferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                Console.WriteLine("Valor insuficiente!");
                // Se a condição for false, os códigos abraixo não seram executados;
                return false;
            }
            else
            {
                this._saldo = this._saldo - valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}