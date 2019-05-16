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
        string CurrentDir = System.IO.Directory.GetCurrentDirectory() + @"Photos\";
        Random rand = new Random();
        int x;
        int y;
        bool LeftK;
        bool RightK;
        bool Up;
        bool Down;
        int i = 0;       
        int distance;
        bool Collide = false;
        string Which = "";
        int RockS;
        int WakaS;
        Bitmap UnBrokenOar = (Bitmap)Properties.Resources._15DegOar;
        Bitmap SnappedOar = (Bitmap)Properties.Resources.Oar;

    
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
                    RockS = 4;
                    WakaS = 4;
                    distance = 100;
                    break;
                case "2":
                    RockS = 6;
                    WakaS = 4;
                    distance = 250;
                    break;
                case "3":
                    RockS = 8;
                    WakaS = 4;
                    distance = 350;
                    break;
                default:
                    break;
            }
            Reset();
            Run();
        }

        private void Reset()
        { //resests game.
            OOLlbl.Hide();
            DistanceMeter.Maximum = distance;
            Life1.BackgroundImage = UnBrokenOar;
            Life2.BackgroundImage = UnBrokenOar;
            Life3.BackgroundImage = UnBrokenOar;
            Waka.Top = Border.Height - Waka.Height;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock1.Top = y;
            Rock1.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock2.Top = y;
            Rock2.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock3.Top = y;
            Rock3.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock4.Top = y;
            Rock4.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock5.Top = y;
            Rock5.Left = x;
            Rando(0, Border.Width, -(Border.Width), 0);
            Rock6.Top = y;
            Rock6.Left = x;
        }

        private void Run()
        {
            MoveTimer.Start();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Bound();
            MoveWaka();
            RockMove();
            CheckCollision(); //checks collision
        }
         
        private void Bound()
        {
            if (Rock1.Top > Border.Height)
            {
                Rando(0,Border.Width,-(Border.Width),0);
                Rock1.Top = y;
                Rock1.Left = x;
            }
            if (Rock2.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock2.Top = y;
                Rock2.Left = x;
            }
            if (Rock3.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock3.Top = y;
                Rock3.Left = x;
            }
            if (Rock4.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock4.Top = y;
                Rock4.Left = x;
            }
            if (Rock5.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock5.Top = y;
                Rock5.Left = x;
            }
            if (Rock6.Top > Border.Height)
            {
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock6.Top = y;
                Rock6.Left = x;
            }
            if (Waka.Left < 0) Waka.Left = 0;
            if (Waka.Left > Border.Width) Waka.Left = Border.Width;
            if (Waka.Top < 0) Waka.Top = 0;
            if (Waka.Top > Border.Height) Waka.Top = Border.Height;
        }
        
        private void Rando(int lx, int rx, int ly, int ry)
        {
            x = rand.Next(lx, rx); //Gets a random poistion for each rock above the screen. in an area equal to the size of play area.
            y = rand.Next(ly, ry);
        }


        private void RockMove()
        {
            Rock1.Top += RockS;
            Rock2.Top += RockS;
            Rock3.Top += RockS;
            Rock4.Top += RockS;
            Rock5.Top += RockS;
            Rock6.Top += RockS;

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
            Waka.Top += 5;
            LifeLost();
            Collide = false;

        }

        private void RockCol() // Checks each rock. And Minus' a life and removes the rocks, then moves waka back 10.
        {
            if (Waka.Left + 10 + (Waka.Width) >= Rock1.Left && Waka.Left + 10 <= (Rock1.Left + Rock1.Width) && Rock1.Top + Rock1.Height >= Waka.Top && Rock1.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock1.Top = y;
                Rock1.Left = x;
                Collided();
            } // rock 1
            if (Waka.Left - 10 +  Waka.Width >= Rock2.Left && Waka.Left + 10 <= (Rock2.Left + Rock4.Width) && Rock2.Top + Rock2.Height >= Waka.Top && Rock2.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock2.Top = y;
                Rock2.Left = x;
                Collided();
            } // Rock 2
            if (Waka.Left - 10 + Waka.Width >= Rock4.Left && Waka.Left +10 <= (Rock4.Left + Rock4.Width) && Rock4.Top + Rock4.Height >= Waka.Top && Rock4.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock4.Top = y;
                Rock4.Left = x;
                Collided();
            } //Rock Smallrock
            if (Waka.Left -10 + Waka.Width >= Rock3.Left && Waka.Left +10<= (Rock3.Left + Rock3.Width) && Rock3.Top + Rock3.Height >= Waka.Top && Rock3.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock3.Top = y;
                Rock3.Left = x;
                Collided();
            } //Rock 3
            if (Waka.Left + Waka.Width -10>= Rock5.Left && Waka.Left+10 <= (Rock5.Left + Rock5.Width) && Rock5.Top + Rock5.Height >= Waka.Top && Rock5.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock5.Top = y;
                Rock5.Left = x;
                Collided();
            } // BigRcok
            if (Waka.Left + Waka.Width -10>= Rock6.Left && Waka.Left +10<= (Rock6.Left + Rock6.Width) && Rock6.Top + Rock6.Height >= Waka.Top && Rock6.Top <= Waka.Top + Waka.Height)
            {
                Collide = true;
                Rando(0, Border.Width, -(Border.Width), 0);
                Rock6.Top = y;
                Rock6.Left = x;
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
    }
}
