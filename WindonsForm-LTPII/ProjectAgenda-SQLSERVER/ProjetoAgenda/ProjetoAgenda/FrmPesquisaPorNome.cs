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
    public partial class FrmPesquisaPorNome : Form
    {
        public FrmPesquisaPorNome()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            string sql = $"Select * from DadosAgenda where Nome LIKE '{txtNome.Text}%' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dgvMostra.DataSource = ds.Tables[0];
        }
    }
}
