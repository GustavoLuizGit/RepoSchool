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
    public partial class PesquisaForm : Form
    {
        public PesquisaForm()
        {
            InitializeComponent();
        }
        private List<Cadastro> lista = null;

        internal List<Cadastro> Lista { get => lista; set => lista = value; }
        private Bitmap img1, img2;

        private int flag = 1;

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            foreach (Cadastro item in Lista)
            {
                if (item.Nome == txtnome.Text)
                {
                    img1 = item.Img1;
                    img2 = item.Img2;
                    timer1.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag ==1)
            {
                pictureBox1.Image = img1;
                flag = 2;
            }
            else
            {
                pictureBox1.Image = img2;
                flag = 1;
            }
        }

        
    }
}
