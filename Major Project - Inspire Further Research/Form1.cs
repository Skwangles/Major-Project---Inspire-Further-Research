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
        Opening Open = new Opening();
        Random rand = new Random();
        int i = 0;
        int neg = -20;
        int distance;
        bool Collide = false;
        string Which = "";
        int RockS;
        int WakaS;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Hardness = Open.Hardness;
            switch (Hardness)
            {
                case"1": //Based on difficulty. Changes rock speed
                    RockS = 4;
                    WakaS = 4;
                    distance = 100;
                    break;
                case"2":
                    RockS = 6;
                    WakaS = 4;
                    distance = 250;
                    break;
                case"3":
                    RockS = 8;
                    WakaS = 4;
                    distance = 200;
                    break;
                default:
                    break;
            }
            Reset();
            Run();
        }

        private void Reset()
        {

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
            RockCol();  // checks if the waka collides with  each rock.

        }

        private void Collided()
        {
            Waka.Top += 5;
            LifeLost();
            switch (Which)
            {
                case "1":
                    Rock1.Top = neg;

                    break;
                case "2":

                    Rock2.Top = neg;

                    break;
                case "3":
                    Rock3.Top = neg;
                    break;
                case "S":
                    SmallRock.Top = neg;
                    break;
                case "B":
                    BigRock.Top = neg;
                    break;
                case "G":
                    SuperBigRock.Top = neg;
                    break;
                default:
                    break;
            }
            Collide = false;
            Which = "";
        }

        private void RockCol() // Checks each rock. And Minus' a life and removes the rocks, then moves waka back 10.
        {
            if (Waka.Left >= Rock1.Left && Waka.Left <= (Rock1.Left + Rock1.Width) && Rock1.Top + Rock1.Height >= Waka.Top && Rock1.Top <= Waka.Top)
            {
                Collide = true;
                Which = "1";
                Collided();
            } // rock 1
            if (Waka.Left >= Rock2.Left && Waka.Left <= (Rock2.Left + Rock2.Width) && Rock2.Top + Rock2.Height >= Waka.Top && Rock2.Top <= Waka.Top)
            {
                Collide = true;
                Which = "2";
                Collided();
            } // Rock 2
            if (Waka.Left >= SmallRock.Left && Waka.Left <= (SmallRock.Left + SmallRock.Width) && SmallRock.Top + SmallRock.Height >= Waka.Top && SmallRock.Top <= Waka.Top)
            {
                Collide = true;
                Which = "S";
                Collided();
            } //Rock Smallrock
            if (Waka.Left >= Rock3.Left && Waka.Left <= (Rock3.Left + Rock3.Width) && Rock3.Top + Rock3.Height >= Waka.Top && Rock3.Top <= Waka.Top)
            {
                Collide = true;
                Which = "3";
                Collided();
            } //Rock 3
            if (Waka.Left >= BigRock.Left && Waka.Left <= (BigRock.Left + BigRock.Width) && BigRock.Top + BigRock.Height >= Waka.Top && BigRock.Top <= Waka.Top)
            {
                Collide = true;
                Which = "B";
                Collided();
            } // BigRcok
            if (Waka.Left >= SuperBigRock.Left && Waka.Left <= (SuperBigRock.Left + SuperBigRock.Width) && SuperBigRock.Top + SuperBigRock.Height >= Waka.Top && SuperBigRock.Top <= Waka.Top)
            {
                Collide = true;
                Which = "G";
                Collided();
            } //Super Big Rock
        }

        private void LifeLost()
        {
            i++;
            switch (i)
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
