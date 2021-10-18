using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class TEndereco
    {
        private string bairro;
        private string cidade;
        private string rua;
        private int numero;

        public TEndereco()
        {

        }

        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }

        public string MostrarEnd()
        {
            string aux;
            aux = "Nome da rua : " + rua + "\nNúmero da casa : " + numero + "\nNome do bairro : " + bairro + "\nNome da cidade : " + cidade;
            return aux; 
        }
    }
}
