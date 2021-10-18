using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeo03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdComemoracao_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.SelectionStart.ToString("dd/MM")=="12/10")
                pictureBox1.Image = Properties.Resources.gustavo;

            if (monthCalendar1.SelectionStart.ToString("dd/MM") == "25/12")
                pictureBox1.Image = Properties.Resources.natal;

            if (monthCalendar1.SelectionStart.ToString("dd/MM") == "07/09")
                pictureBox1.Image = Properties.Resources.independencia;

          
        }
    }
}
