using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Cadastro : Form
    {
        List<Jogador> lista = new List<Jogador>();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void cmdCadastro_Click(object sender, EventArgs e)
        {
            Jogador j = new Jogador();
            j.Nome = txtNome.Text;
            lista.Add(j);
        }
    }
}
