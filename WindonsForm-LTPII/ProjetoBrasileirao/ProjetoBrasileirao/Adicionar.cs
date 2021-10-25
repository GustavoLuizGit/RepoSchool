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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into Times (nome, quantidadeTitulos, fundacao, tituloEpico) values ('{txtNome.Text}', '{txtTitulos.Text}', '{txtFundacao.Text}' , '{txtTituloHistorico.Text}')";

            cd.ExecuteNonQuery();

            MessageBox.Show("Time registrado com sucesso");
            txtNome.Clear();
            txtFundacao.Clear();
            txtTitulos.Clear();
            txtTituloHistorico.Clear();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
