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
        SqlConnection cn = new SqlConnection();
        public FrmAlterar()
        {
            InitializeComponent();
        }
        private int codigoAgenda =0 ;

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;

            cd.CommandText = "Update DadosAgenda set Telefone = '" + txtTelefone.Text + "',Cidade = '" + txtCidade.Text + "'Where Codigo =" + codigoAgenda.ToString();

            MessageBox.Show("Registro alterado com sucesso!");

            txtCidade.Clear();
            txtTelefone.Clear();

        }

        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select *from DadosAgenda", cn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            comboBox1.DisplayMember = "Nome";      //mostrar os nomes para o usuario
            comboBox1.ValueMember = "Codigo";      //guardar o codigo do nome para dps alterar no banco de dados
            comboBox1.DataSource = ds.Tables[0];   //combo box recebe as tabelas criada
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigoAgenda = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            SqlCommand cd = new SqlCommand();
            cd.CommandText = $"Select * from DadosAgenda where Codigo = {codigoAgenda}";
            cd.Connection = cn;
            cn.Open();

            SqlDataReader dr = cd.ExecuteReader();

            if (dr.Read())
            {
                txtTelefone.Text = dr["Telefone"].ToString();
                txtCidade.Text = dr["Cidade"].ToString();
            }
            cn.Close();
        }
    }
}
