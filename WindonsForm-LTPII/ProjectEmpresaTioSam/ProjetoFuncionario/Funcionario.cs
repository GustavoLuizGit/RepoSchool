using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario
{
    class Funcionario
    {
        string nome;
        double salario;
        string dataAdimissao;
        
        public Funcionario() { }
        public void gravarDados(string nome, double salario, string dataAdimissao)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.DataAdimissao = dataAdimissao;
        }

        public void multiplicarSalario()
        {
            Salario = Salario * 3;   
        }
        string aux;

        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
        public string DataAdimissao { get => dataAdimissao; set => dataAdimissao = value; }

        public string mostraDados()
        {
            aux = "\nNome :" + Nome + "\nSalario" + Salario + "\nData Admissão : " + DataAdimissao + "\n-------------------------------";
            return aux;
        }
        
    }
}
