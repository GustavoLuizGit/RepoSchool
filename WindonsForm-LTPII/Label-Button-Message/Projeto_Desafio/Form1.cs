using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desafio
{
    public partial class Form1 : Form
    {
        int calorpao = 0;
        int calorcarne = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void cmdpao_Click(object sender, EventArgs e)
        {
            
            lblmostra.Text = "Uma fatia de pão integral possui 200 calorias.";
            listin.Items.Add("Pão");
            calorpao = calorpao + 200; 
        }

        private void cmdCarne_Click(object sender, EventArgs e)
        {
            lblmostra.Text = "Uma porção de carne de hamburguer possui 350 calorias.";
            listin.Items.Add("Carne");
            calorcarne = calorcarne + 350;
        }

        private void txtsenha_Validating(object sender, CancelEventArgs e)
        {
            if (txtsenha.Text == "123")
                MessageBox.Show("Senha Incorreta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calorias.Text = "Total de calorias : " + (calorpao + calorcarne);
        }
    }
}
