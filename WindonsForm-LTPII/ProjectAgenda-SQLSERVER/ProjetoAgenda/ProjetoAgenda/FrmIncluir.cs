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
    public partial class FrmIncluir : Form
    {
        public FrmIncluir()
        {
            InitializeComponent();
        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        { 
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            //cd.CommandText = "Insert into DadosAgenda (Nome, Telefone, Cidade) values ('" + txtNome.Text + " ', ' " + txtTelefone.Text + "','" + txtCidade.Text + "')";
            cd.CommandText = $"Insert into DadosAgenda (Nome, Telefone, Cidade) values ('{txtNome.Text}', '{txtTelefone.Text}', '{txtCidade.Text}')";
            cd.ExecuteNonQuery();

            MessageBox.Show("Registro incluido com sucesso");
            txtNome.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
           
        }
       
    }
}
