using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Trab
{
    class Estoque
    {
        private string nome_prod;
        private int quantidade;
        private string nome_estoque ;

        public Estoque(string nome_estoque)
        {
            this.nome_estoque = nome_estoque;
        }

        public string Nome_prod { get => nome_prod; set => nome_prod = value.ToUpper(); }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public string Mostra()
        {
            string aux = " ";
            aux += "Nome da empresa : "+ nome_estoque +"\nNome do produto : " + Nome_prod + "\n Qunatidade : " + Quantidade;
            return aux;
        }
    }
}
