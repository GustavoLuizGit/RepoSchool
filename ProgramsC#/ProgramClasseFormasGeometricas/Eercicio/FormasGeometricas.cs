using System;
using System.Collections.Generic;
using System.Text;

namespace Eercicio
{
    class FormasGeometricas
    {
        
        private double largura;
        private double altura;
        private string nomeForma;
        
        public FormasGeometricas(string nomeForma)
        {
            this.nomeForma = nomeForma;
        }
        
        public double Areatriangulo
        {
            get { return (double) (Largura * Altura) / 2; }
        }

        public double Altura { get => altura; set => altura = value>0?value:0; }
        public double Largura { get => largura; set => largura = value>0?value:0; }

        //inicio gravar
        public void Gravar(double largura, double altura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }
        //fim gravar
        //Mostrar
        public string Mostrar()
        {
            string aux = "";
            aux += "Nome da forma : " + nomeForma + "\nLargura : " + Largura.ToString("0.00") + "\naltura :" + Altura.ToString("0.00");
            aux += "\nResultado : " + Areatriangulo.ToString("0.00");
            return aux;
        }
        // Fim mostrar
    }
}
