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
    public partial class FrmPesquisaCidade : Form
    {
        public FrmPesquisaCidade()
        {
            InitializeComponent();
        }
        private DadosAgenda dados = new DadosAgenda();
        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dados.Cidade = txtCidade.Text;
            dados.ListarDadosPorCidade();
            dgvMostra.DataSource = dados.ListarDadosPorCidade().Tables[0];
        }

    }
}
