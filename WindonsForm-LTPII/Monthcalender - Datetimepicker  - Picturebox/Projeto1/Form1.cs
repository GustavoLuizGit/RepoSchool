using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdok_Click(object sender, EventArgs e)
        {
            lblDateTimePicker.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            DateTime di, df;
            di = monthCalendar1.SelectionStart;
            df = monthCalendar1.SelectionEnd;
            lblMonthCalender.Text = "Data Inicial : " + di.ToString("dd/MM/yyyy") + "Data Final : " + df.ToString("dd/MM/yyyy");
            //lblMonthCalender.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");
        }
    }
}
