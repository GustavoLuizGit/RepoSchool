using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1
{
    abstract class Projeto
    {
        private string responsavel;
        private string nome_projeto;
        private double valor_hora;
        private int hora;

        public Projeto()
        {

        }
        public Projeto(string nomeprojeto)
        {
            this.nome_projeto = nomeprojeto;
        }

        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string Nome_projeto { get => nome_projeto; set => nome_projeto = value; }
        public double Valor_hora { set => valor_hora = value; }
        public int Hora { get => hora; set => hora = value; }

        virtual public double Calculo_Custo()
        {
            return (valor_hora * hora);
        }
    }
}
