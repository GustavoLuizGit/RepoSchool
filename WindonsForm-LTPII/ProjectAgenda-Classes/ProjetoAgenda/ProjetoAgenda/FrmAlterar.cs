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
using System.IO;

namespace ProjetoAgenda
{
    public partial class FrmAlterar : Form
    {
        public FrmAlterar()
        {
            InitializeComponent();
        }
        private DadosAgenda dados = new DadosAgenda();

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            dados.Telefone = txtTelefone.Text;
            dados.Cidade = txtCidade.Text;
            dados.Alterar();
            MessageBox.Show("Registro alterado com sucesso!");
            txtCidade.Clear();
            txtTelefone.Clear();
        }

        private void FrmAlterar_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Nome";    
            comboBox1.ValueMember = "Codigo";     
            comboBox1.DataSource = dados.ListarDados().Tables[0];   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.Codigo = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            if(!(dados.Foto is null))
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(dados.Foto, 0, dados.Foto.Length);
                pictureBox1.Image = Image.FromStream(ms);
            }
            txtTelefone.Text = dados.Telefone;
            txtCidade.Text = dados.Cidade;
        }

        private void cmdImg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                cmdImg.Visible = false;
            }
            else
            {
               
            }
        }

        private void ConverteFoto()
        {
            if (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] fotoArray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(fotoArray, 0, fotoArray.Length);
                dados.Foto = fotoArray;
            }
        }
    }
}
