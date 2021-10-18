using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtnumero.Text);
            if (num % 2 == 0 )
            {
                txtpar.BackColor = Color.Green;
                txtimpar.BackColor = Color.Red;
            }
            else
            {
                txtpar.BackColor = Color.Red;
                txtimpar.BackColor = Color.Green;
            }

            if (num > 0)
            {
                txtPosi.BackColor = Color.Green;
                txtNega.BackColor = Color.Red;
            }
            else if(num < 0 )
            {
                txtPosi.BackColor = Color.Red;
                txtNega.BackColor = Color.Green;
            }
            else
            {
                txtPosi.BackColor = Color.Blue;
                txtNega.BackColor = Color.Blue;
            }

            int resultado = 0;
            for ( int i = 2; i<=num/2; i++)
            {
                if(num % i ==0)
                {
                    resultado++;
                    break;
                }
            }

            if (resultado == 0 && num!=0 && num>0)
                txtprimo.BackColor = Color.Green;
            else
                txtprimo.BackColor = Color.Red;
        }

        
    }
}
