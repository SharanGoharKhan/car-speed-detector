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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelErosionTitle = new System.Windows.Forms.Label();
            this.labelErosionValue = new System.Windows.Forms.Label();
            this.buttonErosionPlus = new System.Windows.Forms.Button();
            this.buttonErosionMinus = new System.Windows.Forms.Button();
            this.labelDialtionTitle = new System.Windows.Forms.Label();
            this.labelDilationValue = new System.Windows.Forms.Label();
            this.buttonDilationPlus = new System.Windows.Forms.Button();
            this.buttonDilationMinus = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.labelkmTitle = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelRectangleAdj = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
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
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(23, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1012, 689);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
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
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(1074, 350);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(104, 35);
            this.labelSpeed.TabIndex = 29;
            this.labelSpeed.Text = "Speed";
            this.labelSpeed.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeedValue.Location = new System.Drawing.Point(1074, 409);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(29, 31);
            this.labelSpeedValue.TabIndex = 30;
            this.labelSpeedValue.Text = "0";
            // 
            // labelkmTitle
            // 
            this.labelkmTitle.AutoSize = true;
            this.labelkmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkmTitle.Location = new System.Drawing.Point(1128, 415);
            this.labelkmTitle.Name = "labelkmTitle";
            this.labelkmTitle.Size = new System.Drawing.Size(61, 25);
            this.labelkmTitle.TabIndex = 31;
            this.labelkmTitle.Text = "km/hr";
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(1094, 524);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 23);
            this.buttonUp.TabIndex = 32;
            this.buttonUp.Text = "UP";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelRectangleAdj
            // 
            this.labelRectangleAdj.AutoSize = true;
            this.labelRectangleAdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRectangleAdj.Location = new System.Drawing.Point(1041, 475);
            this.labelRectangleAdj.Name = "labelRectangleAdj";
            this.labelRectangleAdj.Size = new System.Drawing.Size(169, 22);
            this.labelRectangleAdj.TabIndex = 33;
            this.labelRectangleAdj.Text = "Speed Box Adjustor";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(1094, 571);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 23);
            this.buttonDown.TabIndex = 34;
            this.buttonDown.Text = "DOWN";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(1041, 542);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(46, 23);
            this.buttonLeft.TabIndex = 35;
            this.buttonLeft.Text = "LEFT";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(1160, 542);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(51, 23);
            this.buttonRight.TabIndex = 36;
            this.buttonRight.Text = "RIGHT";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1219, 733);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.labelRectangleAdj);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelkmTitle);
            this.Controls.Add(this.labelSpeedValue);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonDilationMinus);
            this.Controls.Add(this.buttonDilationPlus);
            this.Controls.Add(this.labelDilationValue);
            this.Controls.Add(this.labelDialtionTitle);
            this.Controls.Add(this.buttonErosionMinus);
            this.Controls.Add(this.buttonErosionPlus);
            this.Controls.Add(this.labelErosionValue);
            this.Controls.Add(this.labelErosionTitle);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button_select_video);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
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
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelErosionTitle;
        private System.Windows.Forms.Label labelErosionValue;
        private System.Windows.Forms.Button buttonErosionPlus;
        private System.Windows.Forms.Button buttonErosionMinus;
        private System.Windows.Forms.Label labelDialtionTitle;
        private System.Windows.Forms.Label labelDilationValue;
        private System.Windows.Forms.Button buttonDilationPlus;
        private System.Windows.Forms.Button buttonDilationMinus;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.Label labelkmTitle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelRectangleAdj;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
    }
}

