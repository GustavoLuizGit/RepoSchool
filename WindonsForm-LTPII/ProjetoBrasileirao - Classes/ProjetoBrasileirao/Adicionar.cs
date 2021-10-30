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
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
        }

        private BrasileiraoClass dados = new BrasileiraoClass();
        private void button1_Click(object sender, EventArgs e)
        {
            dados.Nome = txtNome.Text;
            dados.Fundacao = txtFundacao.Text;
            dados.TituloEpico = txtTituloHistorico.Text;
            dados.QuantidadeTitulos = txtTitulos.Text;
            dados.Inserir();
            MessageBox.Show("Registro incluido com sucesso");
            txtNome.Clear();
            txtFundacao.Clear();
            txtTituloHistorico.Clear();
            txtTitulos.Clear();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
