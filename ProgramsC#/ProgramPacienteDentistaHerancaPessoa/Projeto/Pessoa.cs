using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto
{
    class Pessoa
    {
        protected string cpf;
        private string nome;
        private int idade;

        public string Cpf { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string MostraPessoa()
        {
            return "Nome :" + nome + "\nCpf : " + cpf + "\nidade : " + idade;
        }

        
    }
}
