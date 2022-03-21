using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoCs
{
    public class Cliente
    {
        private string _cpf;
        public string Nome { get; set; }  //"prop" digitação mais rapido;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escrevo minha lógica de validação de CPF;
                _cpf = value;
            }
        }
        public string Profissao { get; set; }

    }
}