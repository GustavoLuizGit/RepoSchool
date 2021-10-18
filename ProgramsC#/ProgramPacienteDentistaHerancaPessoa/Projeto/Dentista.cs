using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto
{
    class Dentista : Pessoa
    {
        private string procedimento;
        private string numero;
        private string especializacao;

        public Dentista(string nome, string procedimento):base(nome)
        {
            this.procedimento = procedimento;   
        }

        
        public string Numero { get => numero; set => numero = value; }
        public string Especializacao { get => especializacao; set => especializacao = value; }

        public string MostraDentita()
        {
            return MostraPessoa() + "\nProcedimento : " + procedimento + "\nNumero de telefone : " + numero + "\nEspecialização : " + especializacao;
        }
    }
}
