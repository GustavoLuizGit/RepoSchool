using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBrasileirao
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void cmdSair_Click(object sender, EventArgs e)
        {
            Alterar at = new Alterar();
            at.ShowDialog();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            cmdPesquisar.Visible = false;
        }

        private void cmdPesquisaNome_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            cmdPesquisar.Visible = true;
            PesquisaPorNome pn = new PesquisaPorNome();
            pn.ShowDialog();
        }

        private void PesquisaData_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            cmdPesquisar.Enabled = true;
            PesquisaData pd = new PesquisaData();
            pd.ShowDialog();
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            Adicionar ad = new Adicionar();
            ad.ShowDialog();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            Excluir ex = new Excluir();
            ex.ShowDialog();
        }
    }
}
