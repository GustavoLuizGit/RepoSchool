using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPerguntas
{
    
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
           
        }
        List<Pessoa> list = new List<Pessoa>();
        Pessoa P = null;
        Jogo j = null;
        private string nome;
        internal List<Pessoa> List { get => list; set => list = value; }

        private void cmdQuizz_Click(object sender, EventArgs e)
        {
            nome = txtName.Text;
            j = new Jogo(nome);
            j.ShowDialog();
            cmdSalvar.Enabled = true;
            cmdQuizz.Enabled = false;
        }
        private void cmdSalvar_Click_1(object sender, EventArgs e)
        {
            cmdQuizz.Enabled = true;
            cmdSalvar.Enabled = false;
            P = new Pessoa();
            P.Nome = nome;
            P.Pontos = j.Pontos;
            list.Add(P);
            txtName.Text = null;
        }

        private void mnuFechr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuRank_Click(object sender, EventArgs e)
        {
            Ranking r = new Ranking();
            r.Rank = list;
            r.ShowDialog();
        }

        private void mnuRegra_Click(object sender, EventArgs e)
        {
            Regra r1 = new Regra();
            r1.ShowDialog();
        }

    }
}
