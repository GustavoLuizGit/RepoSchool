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
    public partial class PesquisaPorNome : Form
    {
        public PesquisaPorNome()
        {
            InitializeComponent();
        }

        private void cmdPesquisa_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            string sql = $"Select * from Times where nome LIKE '{txtNome.Text}%' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
