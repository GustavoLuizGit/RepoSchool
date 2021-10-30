using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoBrasileirao
{
    public partial class PesquisaPorNome : Form
    {
        public PesquisaPorNome()
        {
            InitializeComponent();
        }
        private BrasileiraoClass dados = new BrasileiraoClass();
        private void cmdPesquisa_Click(object sender, EventArgs e)
        {
            dados.Nome = txtNome.Text;
            dados.ListarDadosPorNome();
            dataGridView1.DataSource = dados.ListarDadosPorNome().Tables[0];
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
