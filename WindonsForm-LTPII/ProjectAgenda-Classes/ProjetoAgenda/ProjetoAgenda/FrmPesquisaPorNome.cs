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

namespace ProjetoAgenda
{
    public partial class FrmPesquisaPorNome : Form
    {
        public FrmPesquisaPorNome()
        {
            InitializeComponent();
        }
        private DadosAgenda dados = new DadosAgenda();
        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.Nome = txtNome.Text;
            dados.ListarDadosPorNome();
            dgvMostra.DataSource = dados.ListarDadosPorNome().Tables[0];
        }
    }
}
