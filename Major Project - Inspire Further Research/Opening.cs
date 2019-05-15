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
         //error
        public static string Hardness;
        public Opening()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            Hardness = "1";
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            Hardness = "2";
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            Hardness = "3";
            o.Show();
        }

        private void Opening_Load(object sender, EventArgs e)
        {

        }
    }
}
