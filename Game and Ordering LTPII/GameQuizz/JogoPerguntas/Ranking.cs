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
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }
        List<Pessoa> rank = new List<Pessoa>();
        Pessoa x = new Pessoa();
        internal List<Pessoa> Rank { get => rank; set => rank = value; }
        int i = 0;
        private void Ranking_Load(object sender, EventArgs e)
        {
            rank = rank.OrderByDescending(o => o.Pontos).ToList();
            foreach (var item in rank)
            {
                PessoassQueJogaram.Items.Add(item.Nome);
                if (i == 0)
                {
                    lblPrimeiro.Text = item.Nome;
                    progressBar1.Value = item.Pontos;
                    label0.Text = item.Pontos.ToString();
                }
                if (i == 1)
                {
                    lblSegundo.Text = item.Nome;
                    progressBar2.Value = item.Pontos;
                    label1.Text = item.Pontos.ToString();
                }
                if (i == 2)
                {
                    lblterceiro.Text = item.Nome;
                    progressBar3.Value = item.Pontos;
                    label2.Text = item.Pontos.ToString();
                }
                i++;
            }
        }

    }
}
