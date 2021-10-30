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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }
        private BrasileiraoClass dados = new BrasileiraoClass();

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            dados.TituloEpico = txtEpico.Text;
            dados.QuantidadeTitulos = txtTitulos.Text;
            dados.Fundacao = txtFundacao.Text;
            dados.Alterar();
            MessageBox.Show("Registro alterado com sucesso!");
            txtEpico.Clear();
            txtFundacao.Clear();
            txtFundacao.Clear();
        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "idTime";
            comboBox1.DataSource = dados.ListarDados().Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.IdTime = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            txtEpico.Text = dados.TituloEpico;
            txtFundacao.Text = dados.Fundacao;
            txtTitulos.Text = dados.QuantidadeTitulos;
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
