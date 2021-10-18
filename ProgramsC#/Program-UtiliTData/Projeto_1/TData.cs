using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_1
{
    class TData
    {
        private int dia;
        private int mes;
        private int ano;

        public int Ano { get => ano; set => ano = value; }
        public int Mes { get => mes; set => mes = (value > 0 && value < 13) ? value : 0; }
        public int Dia { get => dia; set => dia = (value > 0 && value < 32) ? value : 0; }

        public TData()
        {
            
        }
        public string dataF1()
        {
            string aux;
            string aux_dia;
            string aux_mes;
            if (dia<10)
            {
                aux_dia = "0" + dia;
            }
            else
            {
                aux_dia = "" + dia;
            }
            if (mes<10)
            {
                aux_mes = "0" + mes;
            }
            else
            {
                aux_mes = "" + mes;
            }
            aux = aux_dia + "/" + aux_mes + "/" + ano; 
            return aux;
        }

        public string dataF2()
        {
            string aux;
            string aux_dia;
            string aux_mes="(mes não existe)";
            switch (Mes)
            {
                case 1:
                    aux_mes = "janeiro";
                    break;
                case 2:
                    aux_mes = "fevereiro";
                    break;
                case 3:
                    aux_mes = "março";
                    break;
                case 4:
                    aux_mes = "abril";
                    break;
                case 5:
                    aux_mes = "maio";
                    break;
                case 6:
                    aux_mes = "junho";
                    break;
                case 7:
                    aux_mes = "julho";
                    break;
                case 8:
                    aux_mes = "agosto";
                    break;
                case 9:
                    aux_mes = "setembro";
                    break;
                case 10:
                    aux_mes = "outubro";
                    break;
                case 11:
                    aux_mes = "novembro";
                    break;
                case 12:
                    aux_mes = "dezenbro";
                    break;
            }
            if (dia < 10)
            {
                aux_dia = "0" + dia;
            }
            else
            {
                aux_dia = "" + dia;
            }
            aux = aux_dia + " de " + aux_mes + " de " + ano;
            return aux;
        }
    }
}
