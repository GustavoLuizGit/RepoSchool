using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class Cliente
    {
        private TCPF objeto_cpf;
        private string nome;
        private TData data;

        public Cliente()
        {
            objeto_cpf = new TCPF();
            Data = new TData();
        }

        public string Nome { get => nome; set => nome = value; }
        public TCPF Objeto_cpf { get => objeto_cpf; set => objeto_cpf = value; }
        public TData Data { get => data; set => data = value; }

        //não é necessario mais
        //public bool ValidaCPFCliente(string aux)
        //{
        //    return objeto_cpf.ValidaCpf(aux);
        //}
    }
}
