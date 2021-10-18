using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdmatriz_Click(object sender, EventArgs e)
        {
            dgvmatriz.RowCount = (int)nudlinhas.Value;
            dgvmatriz.ColumnCount = (int)nudcolunas.Value;

            for(int i=0; i < (int)nudcolunas.Value; i++)
            {
                dgvmatriz.Columns[i].Width = 50;
            }

            for (int i = 0; i < (int)nudlinhas.Value; i++)
            {
                for (int j = 0; j < (int)nudcolunas.Value; j++)
                {
                    dgvmatriz.Rows[i].Cells[j].Value = 0;
                }
            }

            
        }

        private void cmdSoma_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 0; i < (int)nudlinhas.Value; i++)
            {
                for (int j = 0; j < (int)nudcolunas.Value; j++)
                {
                    soma += Convert.ToInt32(dgvmatriz.Rows[i].Cells[j].Value); 
                }
            }
            lblsoma.Text = soma.ToString();
           
        }
    }
}
