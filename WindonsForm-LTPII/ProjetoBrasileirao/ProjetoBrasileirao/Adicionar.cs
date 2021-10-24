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
        private Bitmap img1;
        private void cmdInserirImagem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = img1;
            }
            if(pictureBox2.Image!= ProjetoBrasileirao.Properties.Resources.x)
            {
                cmdInserirImagem.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();

            SqlCommand cd = new SqlCommand();
            cd.Connection = cn;
            cd.CommandText = $"Insert into Times (nome, foto, quantidadeTitulos, fundacao) values ('{txtNome.Text}', '{pictureBox2.Image}', '{txtTitulos.Text}', '{txtFundacao.Text}')";

            cd.ExecuteNonQuery();

            MessageBox.Show("Time registrado com sucesso");
            txtNome.Clear();
            txtFundacao.Clear();
            txtTitulos.Clear();
            pictureBox2.Image = ProjetoBrasileirao.Properties.Resources.x;
        }
    }
}
