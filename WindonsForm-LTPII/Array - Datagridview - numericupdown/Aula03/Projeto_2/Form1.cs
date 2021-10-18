using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2
{
    public partial class Form1 : Form
    {
        Metodos m1 = new Metodos();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdvetor_Click(object sender, EventArgs e)
        {
            dgvmatriz.RowCount = 1;
            dgvmatriz.ColumnCount = (int)nudcolunas.Value;

            for (int i = 0; i < (int)nudcolunas.Value; i++)
            {
                dgvmatriz.Columns[i].Width = 50;
                dgvmatriz.Rows[0].Cells[i].Value = 0;
            }
        }

        private void cmdquicksort_Click(object sender, EventArgs e)
        {
            int[] A = new int[(int)nudcolunas.Value];
            for (int i = 0; i < (int)nudcolunas.Value; i++)
            {
                A[i] = Convert.ToInt32(dgvmatriz.Rows[0].Cells[i].Value);
            }
            m1.QuickSort(A, 0, (int)nudcolunas.Value - 1);

            for (int i = 0; i < (int)nudcolunas.Value; i++)
            {
                dgvmatriz.Rows[0].Cells[i].Value = A[i];    
            }
            
        }
    }
}
