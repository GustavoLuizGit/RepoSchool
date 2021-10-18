using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class frmRestoDeDivisao : Form
    {
        public frmRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txt_dividendo.Text);
            int divisor = Convert.ToInt32(txt_divisor.Text);
            int resto = dividendo % divisor;
            txt_resto.Text = resto.ToString();
        }
    }
}
