using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private Bitmap img1, img2;
        private Cadastro c;
        private List<Cadastro> lista = new List<Cadastro>();

        private void cmdimg2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img2 = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = img2;
            }
        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            c = new Cadastro();
            c.Nome = txtnome.Text;
            c.Img1 = img1;
            c.Img2 = img2;
            lista.Add(c);
            MessageBox.Show("Cadastrado com sucesso");
        }

        private void cmdimg1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                img1 = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = img1;
            }
        }

        internal List<Cadastro> Lista { get => lista; set => lista = value; }
    }
}
