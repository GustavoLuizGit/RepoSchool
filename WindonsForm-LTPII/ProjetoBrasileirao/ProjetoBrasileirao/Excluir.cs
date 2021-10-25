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

        private int idTimeaux;
        void carregaTimes()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Times", cn);   // ja passa pelo construtor o comando select

            DataSet ds = new DataSet();

            da.Fill(ds);  //preenche o banco de dados virtual(ds) com o comando feito pelo da;

            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "idTime";
            comboBox1.DataSource = ds.Tables[0];      // preenche o combobox com a tabela, no entanto a gente pede pra so mostrar on ome
            cn.Close();
        }
        private void Excluir_Load(object sender, EventArgs e)
        {
            carregaTimes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTimeaux = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();
            SqlCommand cd = new SqlCommand();
            cd.CommandText = "Select * from Times where idTime = " + idTimeaux.ToString();
            cd.Connection = cn;

            SqlDataReader dr = cd.ExecuteReader();  //dr = a pesquisa feita pelo select 

            if (dr.Read()) //se tiver algo na tabela lida o if vai ser verdadeiro
            {
                txtTitulos.Text = dr["quantidadeTitulos"].ToString();
                txtFundacao.Text = dr["fundacao"].ToString();
                txtEpico.Text = dr["tituloEpico"].ToString();
            }
            cn.Close();

        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Delete Times where idTime = {idTimeaux.ToString()}";
            cd.Connection = cn;
            cd.ExecuteNonQuery();
            MessageBox.Show("Time excluido com suucesso!!");
            carregaTimes();
            cn.Close();
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
