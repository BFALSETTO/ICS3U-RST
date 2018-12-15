namespace PACMANBenF
{
    partial class frmPACMAN
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.pacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Location = new System.Drawing.Point(145, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "wall";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox3.Location = new System.Drawing.Point(62, 368);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 130);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "wall";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox4.Location = new System.Drawing.Point(375, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 130);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "wall";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox5.Location = new System.Drawing.Point(472, 45);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 130);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "wall";
            // 
            // redGhost
            // 
            this.redGhost.Location = new System.Drawing.Point(183, 87);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(36, 38);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redGhost.TabIndex = 5;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Location = new System.Drawing.Point(100, 413);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(36, 38);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowGhost.TabIndex = 6;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.Location = new System.Drawing.Point(413, 413);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(36, 38);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkGhost.TabIndex = 7;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // pacman
            // 
            this.pacman.Image = global::PACMANBenF.Properties.Resources.Right;
            this.pacman.Location = new System.Drawing.Point(24, 216);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(20, 20);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman.TabIndex = 8;
            this.pacman.TabStop = false;
            // 
            // frmPACMAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 531);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPACMAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PACMAN Benjamin Falsetto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox pacman;
    }
}

