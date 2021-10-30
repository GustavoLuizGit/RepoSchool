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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private BrasileiraoClass dados = new BrasileiraoClass();
        void carregaTimes()
        {
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "idTime";
            comboBox1.DataSource = dados.ListarDados().Tables[0];
        }
        private void Excluir_Load(object sender, EventArgs e)
        {
            carregaTimes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.IdTime = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            txtEpico.Text = dados.TituloEpico;
            txtFundacao.Text = dados.Fundacao;
            txtTitulos.Text = dados.QuantidadeTitulos;

        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            dados.Excluir();
            MessageBox.Show("Registro excluido com sucesso!");
            txtEpico.Clear();
            txtFundacao.Clear();
            txtTitulos.Clear();
            carregaTimes();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
