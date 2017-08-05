namespace car_speed_calculator
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
            this.button_start = new System.Windows.Forms.Button();
            this.button_select_video = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1Label = new System.Windows.Forms.Label();
            this.pictureBox2Label = new System.Windows.Forms.Label();
            this.pictureBox3Label = new System.Windows.Forms.Label();
            this.pictureBox4Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_start.Location = new System.Drawing.Point(1055, 99);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(152, 46);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_select_video
            // 
            this.button_select_video.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button_select_video.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_select_video.Location = new System.Drawing.Point(1055, 12);
            this.button_select_video.Name = "button_select_video";
            this.button_select_video.Size = new System.Drawing.Size(152, 46);
            this.button_select_video.TabIndex = 4;
            this.button_select_video.Text = "Select Video";
            this.button_select_video.UseVisualStyleBackColor = false;
            this.button_select_video.Click += new System.EventHandler(this.button8_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 300);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(587, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(450, 300);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 354);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(450, 300);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(587, 354);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(450, 300);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1Label
            // 
            this.pictureBox1Label.AutoSize = true;
            this.pictureBox1Label.Location = new System.Drawing.Point(155, 325);
            this.pictureBox1Label.Name = "pictureBox1Label";
            this.pictureBox1Label.Size = new System.Drawing.Size(72, 13);
            this.pictureBox1Label.TabIndex = 17;
            this.pictureBox1Label.Text = "Orignal Image";
            // 
            // pictureBox2Label
            // 
            this.pictureBox2Label.AutoSize = true;
            this.pictureBox2Label.Location = new System.Drawing.Point(761, 325);
            this.pictureBox2Label.Name = "pictureBox2Label";
            this.pictureBox2Label.Size = new System.Drawing.Size(82, 13);
            this.pictureBox2Label.TabIndex = 18;
            this.pictureBox2Label.Text = "Binarized Image";
            // 
            // pictureBox3Label
            // 
            this.pictureBox3Label.AutoSize = true;
            this.pictureBox3Label.Location = new System.Drawing.Point(155, 668);
            this.pictureBox3Label.Name = "pictureBox3Label";
            this.pictureBox3Label.Size = new System.Drawing.Size(129, 13);
            this.pictureBox3Label.TabIndex = 19;
            this.pictureBox3Label.Text = "Applying canny opertation";
            // 
            // pictureBox4Label
            // 
            this.pictureBox4Label.AutoSize = true;
            this.pictureBox4Label.Location = new System.Drawing.Point(761, 668);
            this.pictureBox4Label.Name = "pictureBox4Label";
            this.pictureBox4Label.Size = new System.Drawing.Size(37, 13);
            this.pictureBox4Label.TabIndex = 20;
            this.pictureBox4Label.Text = "Result";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1219, 733);
            this.Controls.Add(this.pictureBox4Label);
            this.Controls.Add(this.pictureBox3Label);
            this.Controls.Add(this.pictureBox2Label);
            this.Controls.Add(this.pictureBox1Label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_select_video);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_select_video;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label pictureBox1Label;
        private System.Windows.Forms.Label pictureBox2Label;
        private System.Windows.Forms.Label pictureBox3Label;
        private System.Windows.Forms.Label pictureBox4Label;
    }
}

