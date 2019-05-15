namespace Major_Project___Inspire_Further_Research
{
    partial class Opening
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
            this.Normal = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Normal
            // 
            this.Normal.Location = new System.Drawing.Point(6, 5);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(438, 143);
            this.Normal.TabIndex = 0;
            this.Normal.Text = "Normal";
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medium
            // 
            this.Medium.Location = new System.Drawing.Point(6, 154);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(438, 143);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(6, 303);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(438, 143);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.button3_Click);
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Normal);
            this.Name = "Opening";
            this.Text = "Opening";
            this.Load += new System.EventHandler(this.Opening_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Hard;
    }
}