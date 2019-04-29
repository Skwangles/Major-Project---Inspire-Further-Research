using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project___Inspire_Further_Research
{
    public partial class Opening : Form
    {
        Form New = new Form1();
        public string Hardness;
        public Opening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hardness = "1";
            New.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hardness = "2";
            New.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hardness = "3";
            New.ShowDialog();
        }
    }
}
