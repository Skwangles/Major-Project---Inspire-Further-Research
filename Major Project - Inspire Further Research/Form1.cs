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
        int x;
        int y;
        int a = 0;
        bool LeftK;
        bool RightK;
        bool Up;
        bool Down;
        int ShrinkBox = 15;
        int i = 0;
        int distance;
        int totaldistance;
        bool Collide = false;
        string Which = "";
        int RockS;
        int WakaS;
        Bitmap UnBrokenOar = (Bitmap)Properties.Resources._15DegOar;
        Bitmap SnappedOar = (Bitmap)Properties.Resources.BrokenOarFlip;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string Hardness = Opening.Hardness;

            switch (Hardness)
            {
                case "1": //Based on difficulty. Changes rock speed
                    RockS = 6;
                    WakaS = 4;

                    totaldistance = 1000; //Is made small to test end animation quickly.
                    break;
                case "2":
                    RockS = 8;
                    WakaS = 6;

                    totaldistance = 12500;
                    break;
                case "3":
                    RockS = 10;
                    WakaS = 8;

                    totaldistance = 15000;
                    break;
                default:
                    break;
            }
            progressBar1.Maximum = totaldistance;
            Reset();
            Run();
        }

        private void Reset()
        { //resets game. For another play
            HideShowRocks("S");
            NZLand.Location = new Point(-2, -556);
            OOLlbl.Hide();
            progressBar1.Value = 0;
            Life1.BackgroundImage = UnBrokenOar;
            Life2.BackgroundImage = UnBrokenOar;
            Life3.BackgroundImage = UnBrokenOar;
            Waka.Top = Border.Height - Waka.Height;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock1pb.Top = y;
            Rock1pb.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock2pb.Top = y;
            Rock2pb.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock3pb.Top = y;
            Rock3pb.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock4pb.Top = y;
            Rock4pb.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock5pb.Top = y;
            Rock5pb.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock6pb.Top = y;
            Rock6pb.Left = x;
        }

        private void Run() //starts game, timer
        {
            MoveTimer.Start();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            distance += 10;
            Bound(); //Makes sure all objects are in bounds
            MoveWaka(); //Moves Waka
            RockMove();//Moves rocks.
            CheckCollision(); //checks collision


            if (distance > totaldistance)
            {
                MoveTimer.Stop();
                OOLlbl.Text = "The voyage to New Zealand" + Environment.NewLine + " is complete.";
                OOLlbl.Show();
                distance = 0;
                EndAnimation();
            }
            progressBar1.Value = distance;

        }

        protected void EndAnimation()
        {

            EndTimer.Start();
            HideShowRocks("H");



        }

        private void HideShowRocks(string s)
        {
            switch (s) {
                case "H":
                    Rock1pb.Hide();
                    Rock2pb.Hide();
                    Rock3pb.Hide();
                    Rock4pb.Hide();
                    Rock5pb.Hide();
                    Rock6pb.Hide();
                    break;
                case "S":
                    Rock1pb.Show();
                    Rock2pb.Show();
                    Rock3pb.Show();
                    Rock4pb.Show();
                    Rock5pb.Show();
                    Rock6pb.Show();
                    break;

            }
        }
        private void Bound()
        {            
            if (Rock1pb.Top > Border.Height)
            {
                Rando(0,Border.Width,-(Border.Width),0);
                Rock1pb.Top = y;
                Rock1pb.Left = x;
            }
            if (Rock2pb.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock2pb.Top = y;
                Rock2pb.Left = x;
            }
            if (Rock3pb.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock3pb.Top = y;
                Rock3pb.Left = x;
            }
            if (Rock4pb.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock4pb.Top = y;
                Rock4pb.Left = x;
            }
            if (Rock5pb.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock5pb.Top = y;
                Rock5pb.Left = x;
            }
            if (Rock6pb.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock6pb.Top = y;
                Rock6pb.Left = x;
            }
            if (Waka.Left < 0) Waka.Left = 0;
            if (Waka.Left > Border.Width - Waka.Width) Waka.Left = Border.Width - Waka.Width;
            if (Waka.Top < 0) Waka.Top = 0;
            if (Waka.Top  > Border.Height - Waka.Height) Waka.Top = Border.Height - Waka.Height;
        }
        
        private void Rando(int lx, int rx, int ly, int ry)
        {
            x = rand.Next(lx, rx); //Gets a random poistion for each rock above the screen. in an area equal to the size of play area.
            y = rand.Next(ly, ry);
        }


        private void RockMove()
        {
            Rock1pb.Top += RockS;
            Rock2pb.Top += RockS;
            Rock3pb.Top += RockS;
            Rock4pb.Top += RockS;
            Rock5pb.Top += RockS;
            Rock6pb.Top += RockS;

        }


        private void MoveWaka()
        {
            if (LeftK && RightK)
            { }
            else
            {
                if (LeftK) Waka.Left -= WakaS;
                if (RightK) Waka.Left += WakaS;
            }

            if (Up && Down)
            { }
            else
            {
                if (Up) Waka.Top -= WakaS;
                if (Down) Waka.Top += WakaS;
            }


        }


        private void CheckCollision()
        {
            RockCol();  // checks if the waka collides with  each rock.

        }

        private void Collided() //the sub which uses the process that is involved with a rock collision
        {
            Waka.Top += 20;
            LifeLost();
            Collide = false;

        }

        private void RockCol() // Checks each rock. And Minus' a life and removes the rocks, then moves waka back 10.
        {
            if (Waka.Left  + (Waka.Width) >= Rock1pb.Left && Waka.Left <= (Rock1pb.Left + Rock1pb.Width) && Rock1pb.Top + Rock1pb.Height >= Waka.Top && Rock1pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock1pb.Top = y;
                Rock1pb.Left = x;
                Collided();
            } // rock 1
            if (Waka.Left  +  Waka.Width >= Rock2pb.Left && Waka.Left  <= (Rock2pb.Left + Rock4pb.Width) && Rock2pb.Top + Rock2pb.Height >= Waka.Top && Rock2pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock2pb.Top = y;
                Rock2pb.Left = x;
                Collided();
            } // Rock 2
            if (Waka.Left  + Waka.Width >= Rock4pb.Left && Waka.Left  <= (Rock4pb.Left + Rock4pb.Width) && Rock4pb.Top + Rock4pb.Height >= Waka.Top && Rock4pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock4pb.Top = y;
                Rock4pb.Left = x;
                Collided();
            } //Rock Smallrock
            if (Waka.Left  + Waka.Width >= Rock3pb.Left && Waka.Left  <= (Rock3pb.Left + Rock3pb.Width) && Rock3pb.Top + Rock3pb.Height >= Waka.Top && Rock3pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock3pb.Top = y;
                Rock3pb.Left = x;
                Collided();
            } //Rock 3
            if (Waka.Left + Waka.Width  >= Rock5pb.Left && Waka.Left <= (Rock5pb.Left + Rock5pb.Width) && Rock5pb.Top + Rock5pb.Height >= Waka.Top && Rock5pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock5pb.Top = y;
                Rock5pb.Left = x;
                Collided();
            } // BigRcok
            if (Waka.Left + Waka.Width >= Rock6pb.Left && Waka.Left  <= (Rock6pb.Left + Rock6pb.Width) && Rock6pb.Top + Rock6pb.Height >= Waka.Top && Rock6pb.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock6pb.Top = y;
                Rock6pb.Left = x;
                Collided();
            } //Super Big Rock
        }

        private void LifeLost()
        {
            i++;
            switch (i)
            {
                case 1:
                    Life3.BackgroundImage = SnappedOar;

                    break;
                case 2:
                    Life2.BackgroundImage = SnappedOar;

                    break;
                case 3:
                    Life1.BackgroundImage = SnappedOar;

                    break;
                default:
                    break;
            }
            if (i >= 3)
            {
                MoveTimer.Stop();
                OOLlbl.Text = "Your Waka Sank " + Environment.NewLine + "Too Many Rock Collisions";
                OOLlbl.Show();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftK = true;
                    break;
                case (char)Keys.Right:
                    RightK = true;
                    break;
                case (char)Keys.Up:
                    Up = true;
                    break;
                case (char)Keys.Down:
                    Down = true;
                    break;
                default:
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.Left:
                    LeftK = false;
                    break;
                case (char)Keys.Right:
                    RightK = false;
                    break;
                case (char)Keys.Up:
                    Up = false;
                    break;
                case (char)Keys.Down:
                    Down = false;
                    break;
                default:
                    break;
            }
        }

        private void Rock5_Click(object sender, EventArgs e)
        {

        }

        private void EndTimer_Tick(object sender, EventArgs e)
        {

            a++;
            if (a < 100)
            {
                NZLand.Top+=5;
            }
            else
            {
                EndTimer.Stop();
                //now change background to beige.
            }

        }
    }
}
