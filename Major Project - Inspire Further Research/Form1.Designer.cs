namespace Major_Project___Inspire_Further_Research
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Border = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oars = new System.Windows.Forms.ImageList(this.components);
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Waka = new System.Windows.Forms.PictureBox();
            this.SuperBigRock = new System.Windows.Forms.PictureBox();
            this.Rock2 = new System.Windows.Forms.PictureBox();
            this.Rock3 = new System.Windows.Forms.PictureBox();
            this.Rock1 = new System.Windows.Forms.PictureBox();
            this.SmallRock = new System.Windows.Forms.PictureBox();
            this.BigRock = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.Life3 = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Waka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperBigRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).BeginInit();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.Transparent;
            this.Border.Location = new System.Drawing.Point(-2, -1);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(447, 548);
            this.Border.TabIndex = 0;
            this.Border.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Beige;
            this.pictureBox2.Location = new System.Drawing.Point(443, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 548);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lives";
            // 
            // oars
            // 
            this.oars.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("oars.ImageStream")));
            this.oars.TransparentColor = System.Drawing.Color.Transparent;
            this.oars.Images.SetKeyName(0, "15DegOar.png");
            this.oars.Images.SetKeyName(1, "BrokenOarFlip.png");
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.Color.Beige;
            this.Life1.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources._15DegOar;
            this.Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Life1.Location = new System.Drawing.Point(451, 71);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(29, 103);
            this.Life1.TabIndex = 3;
            this.Life1.TabStop = false;
            // 
            // Waka
            // 
            this.Waka.BackColor = System.Drawing.Color.Transparent;
            this.Waka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Waka.BackgroundImage")));
            this.Waka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Waka.Location = new System.Drawing.Point(181, 394);
            this.Waka.Name = "Waka";
            this.Waka.Size = new System.Drawing.Size(75, 99);
            this.Waka.TabIndex = 6;
            this.Waka.TabStop = false;
            // 
            // SuperBigRock
            // 
            this.SuperBigRock.BackColor = System.Drawing.Color.Transparent;
            this.SuperBigRock.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.SuperBigRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SuperBigRock.Location = new System.Drawing.Point(46, 107);
            this.SuperBigRock.Name = "SuperBigRock";
            this.SuperBigRock.Size = new System.Drawing.Size(100, 61);
            this.SuperBigRock.TabIndex = 7;
            this.SuperBigRock.TabStop = false;
            // 
            // Rock2
            // 
            this.Rock2.BackColor = System.Drawing.Color.Transparent;
            this.Rock2.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.Rock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock2.Location = new System.Drawing.Point(272, 27);
            this.Rock2.Name = "Rock2";
            this.Rock2.Size = new System.Drawing.Size(52, 33);
            this.Rock2.TabIndex = 8;
            this.Rock2.TabStop = false;
            // 
            // Rock3
            // 
            this.Rock3.BackColor = System.Drawing.Color.Transparent;
            this.Rock3.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.Rock3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock3.Location = new System.Drawing.Point(37, 47);
            this.Rock3.Name = "Rock3";
            this.Rock3.Size = new System.Drawing.Size(50, 28);
            this.Rock3.TabIndex = 9;
            this.Rock3.TabStop = false;
            // 
            // Rock1
            // 
            this.Rock1.BackColor = System.Drawing.Color.Transparent;
            this.Rock1.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.Rock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rock1.Location = new System.Drawing.Point(262, 107);
            this.Rock1.Name = "Rock1";
            this.Rock1.Size = new System.Drawing.Size(62, 43);
            this.Rock1.TabIndex = 10;
            this.Rock1.TabStop = false;
            // 
            // SmallRock
            // 
            this.SmallRock.BackColor = System.Drawing.Color.Transparent;
            this.SmallRock.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.SmallRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SmallRock.Location = new System.Drawing.Point(77, 252);
            this.SmallRock.Name = "SmallRock";
            this.SmallRock.Size = new System.Drawing.Size(34, 26);
            this.SmallRock.TabIndex = 11;
            this.SmallRock.TabStop = false;
            // 
            // BigRock
            // 
            this.BigRock.BackColor = System.Drawing.Color.Transparent;
            this.BigRock.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources.CropRock;
            this.BigRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BigRock.Location = new System.Drawing.Point(272, 186);
            this.BigRock.Name = "BigRock";
            this.BigRock.Size = new System.Drawing.Size(73, 53);
            this.BigRock.TabIndex = 12;
            this.BigRock.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-2, 524);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(492, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.Color.Beige;
            this.Life2.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources._15DegOar;
            this.Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Life2.Location = new System.Drawing.Point(451, 204);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(29, 103);
            this.Life2.TabIndex = 14;
            this.Life2.TabStop = false;
            // 
            // Life3
            // 
            this.Life3.BackColor = System.Drawing.Color.Beige;
            this.Life3.BackgroundImage = global::Major_Project___Inspire_Further_Research.Properties.Resources._15DegOar;
            this.Life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Life3.Location = new System.Drawing.Point(451, 356);
            this.Life3.Name = "Life3";
            this.Life3.Size = new System.Drawing.Size(29, 103);
            this.Life3.TabIndex = 15;
            this.Life3.TabStop = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(484, 540);
            this.Controls.Add(this.Life3);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BigRock);
            this.Controls.Add(this.SmallRock);
            this.Controls.Add(this.Rock1);
            this.Controls.Add(this.Rock3);
            this.Controls.Add(this.Rock2);
            this.Controls.Add(this.SuperBigRock);
            this.Controls.Add(this.Waka);
            this.Controls.Add(this.Life1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Waka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperBigRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Border;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList oars;
        private System.Windows.Forms.PictureBox Life1;
        private System.Windows.Forms.PictureBox Waka;
        private System.Windows.Forms.PictureBox SuperBigRock;
        private System.Windows.Forms.PictureBox Rock2;
        private System.Windows.Forms.PictureBox Rock3;
        private System.Windows.Forms.PictureBox Rock1;
        private System.Windows.Forms.PictureBox SmallRock;
        private System.Windows.Forms.PictureBox BigRock;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox Life2;
        private System.Windows.Forms.PictureBox Life3;
        private System.Windows.Forms.Timer MoveTimer;
    }
}

