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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        CadastroForm FC = new CadastroForm();
        private void mnuCadastro_Click(object sender, EventArgs e)
        {
            FC.ShowDialog();
        }
        
        private void mnuPesquisa_Click(object sender, EventArgs e)
        {
            PesquisaForm FP = new PesquisaForm();
            FP.Lista = FC.Lista;
            FP.ShowDialog();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
