using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CBR.DailyInfo proxy = new CBR.DailyInfo();
            DataSet ds = proxy.GetCursOnDate(dateTimePicker1.Value);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
