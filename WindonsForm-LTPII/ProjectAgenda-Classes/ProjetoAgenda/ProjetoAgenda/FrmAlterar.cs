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
    public partial class FrmAlterar : Form
    {
        public FrmAlterar()
        {
            InitializeComponent();
        }
        private DadosAgenda dados = new DadosAgenda();

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            dados.Telefone = txtTelefone.Text;
            dados.Cidade = txtCidade.Text;
            dados.Alterar();
            MessageBox.Show("Registro alterado com sucesso!");
            txtCidade.Clear();
            txtTelefone.Clear();
        }

        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nome";    
            comboBox1.ValueMember = "Codigo";     
            comboBox1.DataSource = dados.ListarDados().Tables[0];   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.Codigo = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            txtTelefone.Text = dados.Telefone;
            txtCidade.Text = dados.Cidade;
        }
    }
}
