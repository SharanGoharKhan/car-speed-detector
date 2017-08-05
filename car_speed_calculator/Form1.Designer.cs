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
            this.labelErosionTitle = new System.Windows.Forms.Label();
            this.labelErosionValue = new System.Windows.Forms.Label();
            this.buttonErosionPlus = new System.Windows.Forms.Button();
            this.buttonErosionMinus = new System.Windows.Forms.Button();
            this.labelDialtionTitle = new System.Windows.Forms.Label();
            this.labelDilationValue = new System.Windows.Forms.Label();
            this.buttonDilationPlus = new System.Windows.Forms.Button();
            this.buttonDilationMinus = new System.Windows.Forms.Button();
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
            // labelErosionTitle
            // 
            this.labelErosionTitle.AutoSize = true;
            this.labelErosionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErosionTitle.Location = new System.Drawing.Point(1086, 168);
            this.labelErosionTitle.Name = "labelErosionTitle";
            this.labelErosionTitle.Size = new System.Drawing.Size(75, 24);
            this.labelErosionTitle.TabIndex = 21;
            this.labelErosionTitle.Text = "Erosion";
            // 
            // labelErosionValue
            // 
            this.labelErosionValue.AutoSize = true;
            this.labelErosionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErosionValue.Location = new System.Drawing.Point(1120, 208);
            this.labelErosionValue.Name = "labelErosionValue";
            this.labelErosionValue.Size = new System.Drawing.Size(20, 24);
            this.labelErosionValue.TabIndex = 22;
            this.labelErosionValue.Text = "0";
            // 
            // buttonErosionPlus
            // 
            this.buttonErosionPlus.Location = new System.Drawing.Point(1158, 211);
            this.buttonErosionPlus.Name = "buttonErosionPlus";
            this.buttonErosionPlus.Size = new System.Drawing.Size(49, 23);
            this.buttonErosionPlus.TabIndex = 23;
            this.buttonErosionPlus.Text = "+";
            this.buttonErosionPlus.UseVisualStyleBackColor = true;
            this.buttonErosionPlus.Click += new System.EventHandler(this.buttonErosionPlus_Click);
            // 
            // buttonErosionMinus
            // 
            this.buttonErosionMinus.Location = new System.Drawing.Point(1055, 211);
            this.buttonErosionMinus.Name = "buttonErosionMinus";
            this.buttonErosionMinus.Size = new System.Drawing.Size(49, 23);
            this.buttonErosionMinus.TabIndex = 24;
            this.buttonErosionMinus.Text = "-";
            this.buttonErosionMinus.UseVisualStyleBackColor = true;
            this.buttonErosionMinus.Click += new System.EventHandler(this.buttonErosionMinus_Click);
            // 
            // labelDialtionTitle
            // 
            this.labelDialtionTitle.AutoSize = true;
            this.labelDialtionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDialtionTitle.Location = new System.Drawing.Point(1090, 261);
            this.labelDialtionTitle.Name = "labelDialtionTitle";
            this.labelDialtionTitle.Size = new System.Drawing.Size(71, 24);
            this.labelDialtionTitle.TabIndex = 25;
            this.labelDialtionTitle.Text = "Dilation";
            // 
            // labelDilationValue
            // 
            this.labelDilationValue.AutoSize = true;
            this.labelDilationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDilationValue.Location = new System.Drawing.Point(1120, 297);
            this.labelDilationValue.Name = "labelDilationValue";
            this.labelDilationValue.Size = new System.Drawing.Size(20, 24);
            this.labelDilationValue.TabIndex = 26;
            this.labelDilationValue.Text = "0";
            // 
            // buttonDilationPlus
            // 
            this.buttonDilationPlus.Location = new System.Drawing.Point(1158, 300);
            this.buttonDilationPlus.Name = "buttonDilationPlus";
            this.buttonDilationPlus.Size = new System.Drawing.Size(49, 23);
            this.buttonDilationPlus.TabIndex = 27;
            this.buttonDilationPlus.Text = "+";
            this.buttonDilationPlus.UseVisualStyleBackColor = true;
            this.buttonDilationPlus.Click += new System.EventHandler(this.buttonDilationPlus_Click);
            // 
            // buttonDilationMinus
            // 
            this.buttonDilationMinus.Location = new System.Drawing.Point(1055, 300);
            this.buttonDilationMinus.Name = "buttonDilationMinus";
            this.buttonDilationMinus.Size = new System.Drawing.Size(49, 23);
            this.buttonDilationMinus.TabIndex = 28;
            this.buttonDilationMinus.Text = "-";
            this.buttonDilationMinus.UseVisualStyleBackColor = true;
            this.buttonDilationMinus.Click += new System.EventHandler(this.buttonDilationMinus_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1219, 733);
            this.Controls.Add(this.buttonDilationMinus);
            this.Controls.Add(this.buttonDilationPlus);
            this.Controls.Add(this.labelDilationValue);
            this.Controls.Add(this.labelDialtionTitle);
            this.Controls.Add(this.buttonErosionMinus);
            this.Controls.Add(this.buttonErosionPlus);
            this.Controls.Add(this.labelErosionValue);
            this.Controls.Add(this.labelErosionTitle);
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
        private System.Windows.Forms.Label labelErosionTitle;
        private System.Windows.Forms.Label labelErosionValue;
        private System.Windows.Forms.Button buttonErosionPlus;
        private System.Windows.Forms.Button buttonErosionMinus;
        private System.Windows.Forms.Label labelDialtionTitle;
        private System.Windows.Forms.Label labelDilationValue;
        private System.Windows.Forms.Button buttonDilationPlus;
        private System.Windows.Forms.Button buttonDilationMinus;
    }
}

