using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFuncionario
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }
        DepartamentoClasse D1;

        List<DepartamentoClasse> list = new List<DepartamentoClasse>();
        private void cmdAddDepartamento_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cmdMostrar.Enabled = false;
            cmdAddDepartamento.Enabled = false;
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            D1 = new DepartamentoClasse();
            D1.Nome = txtName.Text;
            D1.Codigo = Convert.ToInt32(txtcodigo.Text);
            txtName.Text = null;
            txtcodigo.Text = null;
            panel1.Visible = false;
            cmdMostrar.Enabled = true;
            cmdAddDepartamento.Enabled = true;
            list.Add(D1);
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = null;
            txtName.Text = null;
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            cmdAddDepartamento.Visible = false;
            cmdMostrar.Visible = false;
            panel2.Visible = true;
            foreach (DepartamentoClasse item in list)
            {
                labelmostra.Text += "\nNome Departamento : " + D1.Nome + "\nCodigo Departamento : " + D1.Codigo + "\n---------------------";
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            cmdAddDepartamento.Enabled = true;
            cmdMostrar.Enabled = true;
        }
    }
}
