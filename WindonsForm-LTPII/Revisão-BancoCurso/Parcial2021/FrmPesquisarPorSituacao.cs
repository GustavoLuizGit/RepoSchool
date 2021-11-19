using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2021
{
    public partial class FrmPesquisarPorSituacao : Form
    {
        public FrmPesquisarPorSituacao()
        {
            InitializeComponent();
        }

        private void cmdpesquisar_Click(object sender, EventArgs e)
        {
            Matricula x = new Matricula();
            if (rbAprovado.Checked == true)
                x.Situacao = "Aprovado";
            else if (rbFinal.Checked == true)
                x.Situacao = "Final";
            else
                x.Situacao = "Reprovado";
            dataGridView1.DataSource = x.PesquisarMatriculaSituacao().Tables[0];
        }

       
    }
}
