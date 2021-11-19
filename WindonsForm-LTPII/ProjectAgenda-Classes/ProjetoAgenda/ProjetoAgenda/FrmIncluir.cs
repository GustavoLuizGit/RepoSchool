using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoAgenda
{
    public partial class FrmIncluir : Form
    {
        public FrmIncluir()
        {
            InitializeComponent();
        }

        private DadosAgenda dados = new DadosAgenda();

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            dados.Nome = txtNome.Text;
            dados.Telefone = txtTelefone.Text;
            dados.Cidade = txtCidade.Text;
            dados.Inserir();
            MessageBox.Show("Registro incluido com sucesso");
            txtNome.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
           
        }

        private void cmCarregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                cmCarregar.Visible = false;
                ConverteFoto();
            }
            else
                pictureBox1.Image = Properties.Resources.Planet9_3840x2160;

        }

        private void ConverteFoto()
        {
            if  (pictureBox1.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] fotoArray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(fotoArray, 0, fotoArray.Length);
                dados.Foto = fotoArray;
            }
        }

        private void FrmIncluir_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Planet9_3840x2160;
            ConverteFoto();
        }
    }
}
