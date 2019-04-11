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
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int i = 0;
        int neg = -10;
        bool Collide = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Reset();
            Run();            
        }        

        private void Reset()
        {
            int WakaL = Waka.Left;
            int WakaW = Waka.Left + Waka.Width;
            int WakaT = Waka.Top;
            int WakaH = Waka.Top + Waka.Height;            
            Life1.Image = oars.Images[0];
            Life2.Image = oars.Images[0];
            Life3.Image = oars.Images[0];
            Waka.Top = Border.Height - Waka.Height;
            Rock1.Top = neg - Rock1.Height;
            Rock2.Top = neg - Rock2.Height;
            Rock3.Top = neg - Rock3.Height;
            SuperBigRock.Top = neg - SuperBigRock.Height;
            BigRock.Top = neg - BigRock.Height;
            SmallRock.Top = neg - SmallRock.Height;
        }

        private void Run()
        {

        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            CheckCollision();
        }

        private void CheckCollision()
        {
            RockCol();

        }

        private void RockCol()
        {
            if (WakaL >= Rock1.Left && WakaL <= Rock1.Left + Rock1.Width && Rock1.Top + Rock1.Height )Collide = true;
           
        }

        private void LifeLost()
        {
            i++;
            switch(i)
            {
                case 1:
                    Life3.Image = oars.Images[1];

                    break;
                case 2:
                    Life2.Image = oars.Images[1];

                    break;
                case 3:
                    Life1.Image = oars.Images[1];

                    break;
                default:
                    break;




            }
        }



    }
}
