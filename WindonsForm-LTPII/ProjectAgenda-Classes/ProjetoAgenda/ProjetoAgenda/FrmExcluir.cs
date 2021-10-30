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
    public partial class FrmExcluir : Form
    {
        public FrmExcluir()
        {
            InitializeComponent();
        }

        private DadosAgenda dados = new DadosAgenda();
        private void carregarAgenda()
        {
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = dados.ListarDados().Tables[0];
        }
        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            carregarAgenda();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.Codigo = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            txtTelefone.Text = dados.Telefone;
            txtCidade.Text = dados.Cidade;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
        
            dados.Excluir();
            MessageBox.Show("Registro excluido com sucesso!");
            txtCidade.Clear();
            txtTelefone.Clear();
            carregarAgenda();
        }
    }
}
