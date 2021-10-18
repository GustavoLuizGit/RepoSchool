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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        Funcionario F1;
        List<Funcionario> list = new List<Funcionario>();

        private void cmdAddFunc_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            cmdAddFunc.Visible = false;
            cmdMostrar.Visible = false;
            button1.Visible = false;
        }

        private void cmdGravar_Click(object sender, EventArgs e)
        {
            F1 = new Funcionario();
            F1.gravarDados(txtName.Text, Convert.ToDouble(txtSalario.Text), dtp1.Text);
            panel1.Visible = false;
            cmdAddFunc.Visible = true;
            cmdMostrar.Visible = true;
            button1.Visible = true;
            txtName.Text = null;
            txtSalario.Text = null;
            list.Add(F1);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            cmdAddFunc.Visible = false;
            cmdMostrar.Visible = false;
            panel2.Visible = true;
            panel1.Visible = false;
            foreach (Funcionario item in list)
            {
                labelmostra.Text += item.mostraDados();
            }
        }

        private void cmdFechar_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            cmdAddFunc.Visible = true;
            cmdMostrar.Visible = true;
            panel2.Visible = false;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            txtName.Text = null;
            txtSalario.Text = null;
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true ;
            //int i = 0;
            //foreach (Funcionario item in list)
            //{
            //    if(i==0)
            //    {
            //        nome = item.Nome;
            //        maior = item.Salario;
            //        i++;
            //    }
            //    else if (maior<item.Salario)
            //    {
            //        nome = item.Nome;
            //        maior = item.Salario;
            //    }
            //}
            int auxi=0;
            double maior = list[0].Salario;
            for (int i = 1; i < list.Count; i++)
            {
                if(list[i].Salario>maior)
                {
                    maior = list[i].Salario;
                    auxi = i;
                }
            }
            labelmaiorSalario.Text = list[auxi].mostraDados();
        }

        private void cmdFecharMaior_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            cmdAddFunc.Visible = true;
            cmdMostrar.Visible = true;
            panel3.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
