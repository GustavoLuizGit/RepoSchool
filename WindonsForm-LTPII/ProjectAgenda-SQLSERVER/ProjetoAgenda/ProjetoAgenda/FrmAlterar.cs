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

            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Agenda;UID=sa;PWD=123;";
            cn.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Nome from DadosAgenda", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["Nome"].ToString());
            }
        }


 

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
