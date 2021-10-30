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

        private int codigoAgenda;
        
        private void FrmExcluir_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from DadosAgenda",cn);   // ja passa pelo construtor o comando select

            DataSet ds = new DataSet();

            da.Fill(ds);  //preenche o banco de dados virtual(ds) com o comando feito pelo da;

            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Codigo";
            comboBox1.DataSource = ds.Tables[0];      // preenche o combobox com a tabela, no entanto a gente pede pra so mostrar on ome
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoAgenda = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();
            SqlCommand cd = new SqlCommand();
            cd.CommandText = "Select * from DadosAgenda where Codigo = " + codigoAgenda.ToString();
            cd.Connection = cn;

            SqlDataReader dr = cd.ExecuteReader();  //dr = a pesquisa feita pelo select 

            if (dr.Read()) //se tiver algo na tabela lida o if vai ser verdadeiro
            {
                txtTelefone.Text = dr["Telefone"].ToString();
                txtCidade.Text = dr["Cidade"].ToString();
            }
            cn.Close();


        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Delete DadosAgenda where codigo = {codigoAgenda.ToString()}";
            cd.Connection = cn;
            cd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
