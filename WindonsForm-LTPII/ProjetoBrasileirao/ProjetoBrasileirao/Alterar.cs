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
        private int idTimeaux;

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();

            cd.CommandText = "Update Times set quantidadeTitulos = '" + txtTitulos.Text + "',fundacao = '" + txtFundacao.Text + "',tituloEpico = '" + txtEpico.Text + "'Where idTime =" + idTimeaux.ToString();

            cd.Connection = cn;
            cd.ExecuteNonQuery();

            MessageBox.Show("Alterações feitas com sucesso!!");

            txtFundacao.Clear();
            txtTitulos.Clear();
            txtEpico.Clear();
        }

        private void Alterar_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select *from Times", cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "idTime";
            comboBox1.DataSource = ds.Tables[0];
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idTimeaux = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Select *from Times where idTime = {idTimeaux}";
            cd.Connection = cn;
            cn.Open();

            SqlDataReader dr = cd.ExecuteReader();

            if (dr.Read())
            {
                txtFundacao.Text = dr["fundacao"].ToString();
                txtTitulos.Text = dr["quantidadeTitulos"].ToString();
                txtEpico.Text = dr["tituloEpico"].ToString();
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
