using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto
{
    class Paciente : Pessoa
    {
        private string forma_pagamento;
        private string numero;
        private string ficha_num;
        public Paciente(string nome, string ficha_num):base(nome)
        {
            this.ficha_num = ficha_num;
        }

        public string Forma_pagamento { get => forma_pagamento; set => forma_pagamento = value; }
        public string Numero { get => numero; set => numero = value; }

        public string MostraPaciente()
        {
            return MostraPessoa() + "\nForma de Pagamento : " + forma_pagamento + "\nNúmero de telefone : " + numero + "\nFicha de número : " + ficha_num;
        }
    }
}
