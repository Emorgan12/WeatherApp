﻿namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CityLab = new Label();
            CityInput = new TextBox();
            btnSearch = new Button();
            ConLab = new Label();
            DetailsLab = new Label();
            RiseLab = new Label();
            setLab = new Label();
            WindLab = new Label();
            PressureLab = new Label();
            SunsetValue = new Label();
            SunriseValue = new Label();
            PressureValue = new Label();
            WindValue = new Label();
            picIcon = new PictureBox();
            MaxTempValue = new Label();
            MaxTempLab = new Label();
            MinTempLab = new Label();
            MinTempValue = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // CityLab
            // 
            CityLab.AutoSize = true;
            CityLab.BackColor = Color.Transparent;
            CityLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityLab.ForeColor = Color.Black;
            CityLab.Location = new Point(88, 55);
            CityLab.Name = "CityLab";
            CityLab.Size = new Size(60, 30);
            CityLab.TabIndex = 0;
            CityLab.Text = "City:";
            // 
            // CityInput
            // 
            CityInput.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityInput.Location = new Point(168, 64);
            CityInput.Margin = new Padding(3, 2, 3, 2);
            CityInput.Name = "CityInput";
            CityInput.Size = new Size(158, 24);
            CityInput.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGray;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(345, 64);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(63, 24);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // ConLab
            // 
            ConLab.AutoSize = true;
            ConLab.BackColor = Color.Transparent;
            ConLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConLab.ForeColor = Color.Black;
            ConLab.Location = new Point(22, 194);
            ConLab.Name = "ConLab";
            ConLab.Size = new Size(110, 36);
            ConLab.TabIndex = 3;
            ConLab.Text = "Condition:";
            ConLab.TextAlign = ContentAlignment.TopRight;
            ConLab.UseCompatibleTextRendering = true;
            ConLab.UseMnemonic = false;
            // 
            // DetailsLab
            // 
            DetailsLab.AutoSize = true;
            DetailsLab.BackColor = Color.Transparent;
            DetailsLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetailsLab.ForeColor = Color.Black;
            DetailsLab.Location = new Point(22, 286);
            DetailsLab.Name = "DetailsLab";
            DetailsLab.Size = new Size(92, 30);
            DetailsLab.TabIndex = 4;
            DetailsLab.Text = "Details:";
            // 
            // RiseLab
            // 
            RiseLab.AutoSize = true;
            RiseLab.BackColor = Color.Transparent;
            RiseLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RiseLab.ForeColor = Color.Black;
            RiseLab.Location = new Point(908, 296);
            RiseLab.Name = "RiseLab";
            RiseLab.Size = new Size(97, 30);
            RiseLab.TabIndex = 5;
            RiseLab.Text = "Sunrise:";
            // 
            // setLab
            // 
            setLab.AutoSize = true;
            setLab.BackColor = Color.Transparent;
            setLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setLab.ForeColor = Color.Black;
            setLab.Location = new Point(908, 421);
            setLab.Name = "setLab";
            setLab.Size = new Size(91, 30);
            setLab.TabIndex = 6;
            setLab.Text = "Sunset:";
            // 
            // WindLab
            // 
            WindLab.AutoSize = true;
            WindLab.BackColor = Color.Transparent;
            WindLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindLab.ForeColor = Color.Black;
            WindLab.Location = new Point(207, 296);
            WindLab.Name = "WindLab";
            WindLab.Size = new Size(140, 30);
            WindLab.TabIndex = 7;
            WindLab.Text = "Wind speed:";
            // 
            // PressureLab
            // 
            PressureLab.AutoSize = true;
            PressureLab.BackColor = Color.Transparent;
            PressureLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PressureLab.ForeColor = Color.Black;
            PressureLab.Location = new Point(239, 421);
            PressureLab.Name = "PressureLab";
            PressureLab.Size = new Size(108, 30);
            PressureLab.TabIndex = 8;
            PressureLab.Text = "Pressure:";
            // 
            // SunsetValue
            // 
            SunsetValue.AutoSize = true;
            SunsetValue.BackColor = Color.Transparent;
            SunsetValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SunsetValue.ForeColor = Color.Black;
            SunsetValue.Location = new Point(1063, 421);
            SunsetValue.Name = "SunsetValue";
            SunsetValue.Size = new Size(59, 30);
            SunsetValue.TabIndex = 9;
            SunsetValue.Text = "N/A";
            // 
            // SunriseValue
            // 
            SunriseValue.AutoSize = true;
            SunriseValue.BackColor = Color.Transparent;
            SunriseValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SunriseValue.ForeColor = Color.Black;
            SunriseValue.Location = new Point(1063, 301);
            SunriseValue.Name = "SunriseValue";
            SunriseValue.Size = new Size(59, 30);
            SunriseValue.TabIndex = 10;
            SunriseValue.Text = "N/A";
            // 
            // PressureValue
            // 
            PressureValue.AutoSize = true;
            PressureValue.BackColor = Color.Transparent;
            PressureValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PressureValue.ForeColor = Color.Black;
            PressureValue.Location = new Point(428, 421);
            PressureValue.Name = "PressureValue";
            PressureValue.Size = new Size(59, 30);
            PressureValue.TabIndex = 11;
            PressureValue.Text = "N/A";
            // 
            // WindValue
            // 
            WindValue.AutoSize = true;
            WindValue.BackColor = Color.Transparent;
            WindValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindValue.ForeColor = Color.Black;
            WindValue.Location = new Point(428, 296);
            WindValue.Name = "WindValue";
            WindValue.Size = new Size(59, 30);
            WindValue.TabIndex = 12;
            WindValue.Text = "N/A";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picIcon.ErrorImage = (Image)resources.GetObject("picIcon.ErrorImage");
            picIcon.Location = new Point(46, 92);
            picIcon.Margin = new Padding(3, 2, 3, 2);
            picIcon.MaximumSize = new Size(175, 150);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(109, 83);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 14;
            picIcon.TabStop = false;
            // 
            // MaxTempValue
            // 
            MaxTempValue.AutoSize = true;
            MaxTempValue.BackColor = Color.Transparent;
            MaxTempValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxTempValue.ForeColor = Color.Black;
            MaxTempValue.Location = new Point(788, 268);
            MaxTempValue.Name = "MaxTempValue";
            MaxTempValue.Size = new Size(59, 30);
            MaxTempValue.TabIndex = 17;
            MaxTempValue.Text = "N/A";
            // 
            // MaxTempLab
            // 
            MaxTempLab.AutoSize = true;
            MaxTempLab.BackColor = Color.Transparent;
            MaxTempLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxTempLab.ForeColor = Color.Black;
            MaxTempLab.Location = new Point(549, 268);
            MaxTempLab.Name = "MaxTempLab";
            MaxTempLab.Size = new Size(202, 30);
            MaxTempLab.TabIndex = 16;
            MaxTempLab.Text = "Max Temperature:";
            // 
            // MinTempLab
            // 
            MinTempLab.AutoSize = true;
            MinTempLab.BackColor = Color.Transparent;
            MinTempLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinTempLab.ForeColor = Color.Black;
            MinTempLab.Location = new Point(549, 154);
            MinTempLab.Name = "MinTempLab";
            MinTempLab.Size = new Size(196, 30);
            MinTempLab.TabIndex = 18;
            MinTempLab.Text = "Min Temperature:";
            // 
            // MinTempValue
            // 
            MinTempValue.AutoSize = true;
            MinTempValue.BackColor = Color.Transparent;
            MinTempValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinTempValue.ForeColor = Color.Black;
            MinTempValue.Location = new Point(788, 154);
            MinTempValue.Name = "MinTempValue";
            MinTempValue.Size = new Size(59, 30);
            MinTempValue.TabIndex = 19;
            MinTempValue.Text = "N/A";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(316, 194);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.MaximumSize = new Size(175, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(316, 328);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.MaximumSize = new Size(175, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 83);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(967, 194);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.MaximumSize = new Size(175, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 83);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.ErrorImage = (Image)resources.GetObject("pictureBox4.ErrorImage");
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(967, 332);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.MaximumSize = new Size(175, 150);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 83);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.ErrorImage = (Image)resources.GetObject("pictureBox5.ErrorImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(658, 64);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.MaximumSize = new Size(175, 150);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(109, 83);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.ErrorImage = (Image)resources.GetObject("pictureBox7.ErrorImage");
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(658, 186);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.MaximumSize = new Size(175, 150);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(109, 83);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1184, 561);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(MinTempValue);
            Controls.Add(MinTempLab);
            Controls.Add(MaxTempValue);
            Controls.Add(MaxTempLab);
            Controls.Add(picIcon);
            Controls.Add(WindValue);
            Controls.Add(PressureValue);
            Controls.Add(SunriseValue);
            Controls.Add(SunsetValue);
            Controls.Add(PressureLab);
            Controls.Add(WindLab);
            Controls.Add(setLab);
            Controls.Add(RiseLab);
            Controls.Add(DetailsLab);
            Controls.Add(ConLab);
            Controls.Add(btnSearch);
            Controls.Add(CityInput);
            Controls.Add(CityLab);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CityLab;
        private TextBox CityInput;
        private Button btnSearch;
        private Label ConLab;
        private Label DetailsLab;
        private Label RiseLab;
        private Label setLab;
        private Label WindLab;
        private Label PressureLab;
        private Label SunsetValue;
        private Label SunriseValue;
        private Label PressureValue;
        private Label WindValue;
        public PictureBox picIcon;
        private Label MinTempLab;
        private Label MaxTempValue;
        private Label MaxTempLab;
        private Label MinTempValue;
        public PictureBox pictureBox1;
        public PictureBox pictureBox2;
        public PictureBox pictureBox3;
        public PictureBox pictureBox4;
        public PictureBox pictureBox5;
        public PictureBox pictureBox7;
    }
}
