namespace WeatherApp
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
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // CityLab
            // 
            CityLab.AutoSize = true;
            CityLab.BackColor = Color.Transparent;
            CityLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityLab.ForeColor = Color.Black;
            CityLab.Location = new Point(101, 73);
            CityLab.Name = "CityLab";
            CityLab.Size = new Size(77, 39);
            CityLab.TabIndex = 0;
            CityLab.Text = "City:";
            // 
            // CityInput
            // 
            CityInput.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CityInput.Location = new Point(192, 85);
            CityInput.Name = "CityInput";
            CityInput.Size = new Size(180, 28);
            CityInput.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightGray;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(394, 85);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(72, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // ConLab
            // 
            ConLab.AutoSize = true;
            ConLab.BackColor = Color.Transparent;
            ConLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConLab.ForeColor = Color.Black;
            ConLab.Location = new Point(25, 259);
            ConLab.Name = "ConLab";
            ConLab.Size = new Size(145, 39);
            ConLab.TabIndex = 3;
            ConLab.Text = "Condition:";
            
            // 
            // DetailsLab
            // 
            DetailsLab.AutoSize = true;
            DetailsLab.BackColor = Color.Transparent;
            DetailsLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DetailsLab.ForeColor = Color.Black;
            DetailsLab.Location = new Point(54, 313);
            DetailsLab.Name = "DetailsLab";
            DetailsLab.Size = new Size(116, 39);
            DetailsLab.TabIndex = 4;
            DetailsLab.Text = "Details:";
     
            // 
            // RiseLab
            // 
            RiseLab.AutoSize = true;
            RiseLab.BackColor = Color.Transparent;
            RiseLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RiseLab.ForeColor = Color.Black;
            RiseLab.Location = new Point(46, 423);
            RiseLab.Name = "RiseLab";
            RiseLab.Size = new Size(124, 39);
            RiseLab.TabIndex = 5;
            RiseLab.Text = "Sunrise:";
            
            // 
            // setLab
            // 
            setLab.AutoSize = true;
            setLab.BackColor = Color.Transparent;
            setLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setLab.ForeColor = Color.Black;
            setLab.Location = new Point(54, 488);
            setLab.Name = "setLab";
            setLab.Size = new Size(116, 39);
            setLab.TabIndex = 6;
            setLab.Text = "Sunset:";
            // 
            // WindLab
            // 
            WindLab.AutoSize = true;
            WindLab.BackColor = Color.Transparent;
            WindLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindLab.ForeColor = Color.Black;
            WindLab.Location = new Point(394, 259);
            WindLab.Name = "WindLab";
            WindLab.Size = new Size(176, 39);
            WindLab.TabIndex = 7;
            WindLab.Text = "Wind speed:";
            // 
            // PressureLab
            // 
            PressureLab.AutoSize = true;
            PressureLab.BackColor = Color.Transparent;
            PressureLab.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PressureLab.ForeColor = Color.Black;
            PressureLab.Location = new Point(429, 321);
            PressureLab.Name = "PressureLab";
            PressureLab.Size = new Size(141, 39);
            PressureLab.TabIndex = 8;
            PressureLab.Text = "Pressure:";
            // 
            // SunsetValue
            // 
            SunsetValue.AutoSize = true;
            SunsetValue.BackColor = Color.Transparent;
            SunsetValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SunsetValue.ForeColor = Color.Black;
            SunsetValue.Location = new Point(192, 488);
            SunsetValue.Name = "SunsetValue";
            SunsetValue.Size = new Size(74, 39);
            SunsetValue.TabIndex = 9;
            SunsetValue.Text = "N/A";
            // 
            // SunriseValue
            // 
            SunriseValue.AutoSize = true;
            SunriseValue.BackColor = Color.Transparent;
            SunriseValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SunriseValue.ForeColor = Color.Black;
            SunriseValue.Location = new Point(192, 423);
            SunriseValue.Name = "SunriseValue";
            SunriseValue.Size = new Size(74, 39);
            SunriseValue.TabIndex = 10;
            SunriseValue.Text = "N/A";
           
            // 
            // PressureValue
            // 
            PressureValue.AutoSize = true;
            PressureValue.BackColor = Color.Transparent;
            PressureValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PressureValue.ForeColor = Color.Black;
            PressureValue.Location = new Point(576, 321);
            PressureValue.Name = "PressureValue";
            PressureValue.Size = new Size(74, 39);
            PressureValue.TabIndex = 11;
            PressureValue.Text = "N/A";
            // 
            // WindValue
            // 
            WindValue.AutoSize = true;
            WindValue.BackColor = Color.Transparent;
            WindValue.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindValue.ForeColor = Color.Black;
            WindValue.Location = new Point(576, 259);
            WindValue.Name = "WindValue";
            WindValue.Size = new Size(74, 39);
            WindValue.TabIndex = 12;
            WindValue.Text = "N/A";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.Location = new Point(36, 139);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(113, 83);
            picIcon.TabIndex = 13;
            picIcon.TabStop = false;
     
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1845, 837);
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
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
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
        private PictureBox picIcon;
    }
}
