using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2021
{
    public partial class FrmCalcularSituacao : Form
    {
        public FrmCalcularSituacao()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            Matricula x = new Matricula();
            x.IdMatricula = Convert.ToInt32(textBox1.Text);
            x.CalcularSituacaoporIdMatricula();
        }
    }
}
