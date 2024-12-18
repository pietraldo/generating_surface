﻿namespace generating_surface
{
    partial class mainForm
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
            components = new System.ComponentModel.Container();
            canvas = new PictureBox();
            panel1 = new Panel();
            cmbSurfaceFile = new ComboBox();
            btnSurfaceColor = new Button();
            checkBoxFill = new CheckBox();
            trackBarM = new NoFocusTrackBar();
            txtM = new TextBox();
            label8 = new Label();
            trackBarKs = new NoFocusTrackBar();
            txtKs = new TextBox();
            label7 = new Label();
            trackBarKd = new NoFocusTrackBar();
            txtKd = new TextBox();
            label6 = new Label();
            label5 = new Label();
            checkBoxAxis = new CheckBox();
            checkBoxLittleGrid = new CheckBox();
            checkBoxMainLines = new CheckBox();
            checkBoxMainPoints = new CheckBox();
            trackBarAxisY = new NoFocusTrackBar();
            txtAxisYValue = new TextBox();
            label4 = new Label();
            btnLightColor = new Button();
            trackBarAccuracy = new NoFocusTrackBar();
            txtAccuracy = new TextBox();
            label3 = new Label();
            trackBarAxisZ = new NoFocusTrackBar();
            trackBarAxisX = new NoFocusTrackBar();
            txtAxisZValue = new TextBox();
            txtAxisXValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSunMovement = new Button();
            checkBoxSunLines = new CheckBox();
            txtSunZ = new TextBox();
            txtSunY = new TextBox();
            txtSunX = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            trackBarSunY = new NoFocusTrackBar();
            trackBarSunZ = new NoFocusTrackBar();
            trackBarSunX = new NoFocusTrackBar();
            colorDialog1 = new ColorDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            cmbTextura = new ComboBox();
            checkboxTextura = new CheckBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAccuracy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunX).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // canvas
            // 
            canvas.BackColor = SystemColors.ButtonHighlight;
            canvas.Location = new Point(12, 12);
            canvas.Name = "canvas";
            canvas.Size = new Size(283, 225);
            canvas.TabIndex = 0;
            canvas.TabStop = false;
            canvas.Paint += canvas_Paint;
            canvas.MouseDown += canvas_MouseDown;
            canvas.MouseMove += canvas_MouseMove;
            canvas.MouseUp += canvas_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(cmbSurfaceFile);
            panel1.Controls.Add(btnSurfaceColor);
            panel1.Controls.Add(checkBoxFill);
            panel1.Controls.Add(trackBarM);
            panel1.Controls.Add(txtM);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(trackBarKs);
            panel1.Controls.Add(txtKs);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(trackBarKd);
            panel1.Controls.Add(txtKd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(checkBoxAxis);
            panel1.Controls.Add(checkBoxLittleGrid);
            panel1.Controls.Add(checkBoxMainLines);
            panel1.Controls.Add(checkBoxMainPoints);
            panel1.Controls.Add(trackBarAxisY);
            panel1.Controls.Add(txtAxisYValue);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLightColor);
            panel1.Controls.Add(trackBarAccuracy);
            panel1.Controls.Add(txtAccuracy);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(trackBarAxisZ);
            panel1.Controls.Add(trackBarAxisX);
            panel1.Controls.Add(txtAxisZValue);
            panel1.Controls.Add(txtAxisXValue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(608, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 628);
            panel1.TabIndex = 1;
            // 
            // cmbSurfaceFile
            // 
            cmbSurfaceFile.FormattingEnabled = true;
            cmbSurfaceFile.Location = new Point(9, 12);
            cmbSurfaceFile.Name = "cmbSurfaceFile";
            cmbSurfaceFile.Size = new Size(121, 23);
            cmbSurfaceFile.TabIndex = 105;
            cmbSurfaceFile.SelectedIndexChanged += cmbSurfaceFile_SelectedIndexChanged;
            cmbSurfaceFile.Click += cmbSurfaceFile_Click;
            // 
            // btnSurfaceColor
            // 
            btnSurfaceColor.Location = new Point(9, 566);
            btnSurfaceColor.Name = "btnSurfaceColor";
            btnSurfaceColor.Size = new Size(182, 23);
            btnSurfaceColor.TabIndex = 103;
            btnSurfaceColor.Text = "Wybierz kolor powierzchni";
            btnSurfaceColor.UseVisualStyleBackColor = true;
            btnSurfaceColor.Click += btnSurfaceColor_Click;
            // 
            // checkBoxFill
            // 
            checkBoxFill.AutoSize = true;
            checkBoxFill.Checked = true;
            checkBoxFill.CheckState = CheckState.Checked;
            checkBoxFill.Location = new Point(9, 334);
            checkBoxFill.Name = "checkBoxFill";
            checkBoxFill.Size = new Size(89, 19);
            checkBoxFill.TabIndex = 101;
            checkBoxFill.Text = "wypełnienie";
            checkBoxFill.UseVisualStyleBackColor = true;
            checkBoxFill.CheckedChanged += checkBoxFill_CheckedChanged;
            // 
            // trackBarM
            // 
            trackBarM.Location = new Point(42, 486);
            trackBarM.Maximum = 1000;
            trackBarM.Minimum = 1;
            trackBarM.Name = "trackBarM";
            trackBarM.Size = new Size(104, 45);
            trackBarM.TabIndex = 90;
            trackBarM.TickStyle = TickStyle.None;
            trackBarM.Value = 1;
            trackBarM.Scroll += trackBarM_Scroll;
            // 
            // txtM
            // 
            txtM.Enabled = false;
            txtM.Location = new Point(152, 486);
            txtM.Name = "txtM";
            txtM.Size = new Size(39, 23);
            txtM.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 486);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 88;
            label8.Text = "m";
            // 
            // trackBarKs
            // 
            trackBarKs.Location = new Point(42, 445);
            trackBarKs.Maximum = 1000;
            trackBarKs.Name = "trackBarKs";
            trackBarKs.Size = new Size(104, 45);
            trackBarKs.SmallChange = 0;
            trackBarKs.TabIndex = 87;
            trackBarKs.TickStyle = TickStyle.None;
            trackBarKs.Value = 400;
            trackBarKs.Scroll += trackBarKs_Scroll;
            // 
            // txtKs
            // 
            txtKs.Enabled = false;
            txtKs.Location = new Point(152, 445);
            txtKs.Name = "txtKs";
            txtKs.Size = new Size(39, 23);
            txtKs.TabIndex = 86;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 445);
            label7.Name = "label7";
            label7.Size = new Size(18, 15);
            label7.TabIndex = 85;
            label7.Text = "ks";
            // 
            // trackBarKd
            // 
            trackBarKd.Location = new Point(42, 405);
            trackBarKd.Maximum = 1000;
            trackBarKd.Name = "trackBarKd";
            trackBarKd.Size = new Size(104, 45);
            trackBarKd.TabIndex = 84;
            trackBarKd.TickStyle = TickStyle.None;
            trackBarKd.Value = 500;
            trackBarKd.Scroll += trackBarKd_Scroll;
            // 
            // txtKd
            // 
            txtKd.Enabled = false;
            txtKd.Location = new Point(152, 405);
            txtKd.Name = "txtKd";
            txtKd.Size = new Size(39, 23);
            txtKd.TabIndex = 83;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 405);
            label6.Name = "label6";
            label6.Size = new Size(20, 15);
            label6.TabIndex = 82;
            label6.Text = "kd";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(9, 360);
            label5.Name = "label5";
            label5.Size = new Size(91, 32);
            label5.TabIndex = 81;
            label5.Text = "Światło";
            // 
            // checkBoxAxis
            // 
            checkBoxAxis.AutoSize = true;
            checkBoxAxis.Checked = true;
            checkBoxAxis.CheckState = CheckState.Checked;
            checkBoxAxis.Location = new Point(9, 309);
            checkBoxAxis.Name = "checkBoxAxis";
            checkBoxAxis.Size = new Size(47, 19);
            checkBoxAxis.TabIndex = 18;
            checkBoxAxis.Text = "osie";
            checkBoxAxis.UseVisualStyleBackColor = true;
            checkBoxAxis.CheckedChanged += checkBoxAxis_CheckedChanged;
            // 
            // checkBoxLittleGrid
            // 
            checkBoxLittleGrid.AutoSize = true;
            checkBoxLittleGrid.Location = new Point(9, 284);
            checkBoxLittleGrid.Name = "checkBoxLittleGrid";
            checkBoxLittleGrid.Size = new Size(85, 19);
            checkBoxLittleGrid.TabIndex = 17;
            checkBoxLittleGrid.Text = "mała siatka";
            checkBoxLittleGrid.UseVisualStyleBackColor = true;
            checkBoxLittleGrid.CheckedChanged += checkBoxLittleGrid_CheckedChanged;
            // 
            // checkBoxMainLines
            // 
            checkBoxMainLines.AutoSize = true;
            checkBoxMainLines.Location = new Point(9, 259);
            checkBoxMainLines.Name = "checkBoxMainLines";
            checkBoxMainLines.Size = new Size(90, 19);
            checkBoxMainLines.TabIndex = 16;
            checkBoxMainLines.Text = "główne linie";
            checkBoxMainLines.UseVisualStyleBackColor = true;
            checkBoxMainLines.CheckedChanged += checkBoxMainLines_CheckedChanged;
            // 
            // checkBoxMainPoints
            // 
            checkBoxMainPoints.AutoSize = true;
            checkBoxMainPoints.Location = new Point(9, 234);
            checkBoxMainPoints.Name = "checkBoxMainPoints";
            checkBoxMainPoints.Size = new Size(105, 19);
            checkBoxMainPoints.TabIndex = 15;
            checkBoxMainPoints.Text = "główne punkty";
            checkBoxMainPoints.UseVisualStyleBackColor = true;
            checkBoxMainPoints.CheckedChanged += checkBoxMainPoints_CheckedChanged;
            // 
            // trackBarAxisY
            // 
            trackBarAxisY.Location = new Point(42, 151);
            trackBarAxisY.Maximum = 15;
            trackBarAxisY.Name = "trackBarAxisY";
            trackBarAxisY.Size = new Size(104, 45);
            trackBarAxisY.TabIndex = 14;
            trackBarAxisY.TickStyle = TickStyle.None;
            trackBarAxisY.Scroll += trackBarAxisY_Scroll;
            // 
            // txtAxisYValue
            // 
            txtAxisYValue.Enabled = false;
            txtAxisYValue.Location = new Point(152, 151);
            txtAxisYValue.Name = "txtAxisYValue";
            txtAxisYValue.Size = new Size(39, 23);
            txtAxisYValue.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 151);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 12;
            label4.Text = "oś Y";
            // 
            // btnLightColor
            // 
            btnLightColor.Location = new Point(9, 537);
            btnLightColor.Name = "btnLightColor";
            btnLightColor.Size = new Size(182, 23);
            btnLightColor.TabIndex = 11;
            btnLightColor.Text = "Wybierz kolor światła";
            btnLightColor.UseVisualStyleBackColor = true;
            btnLightColor.Click += btnColor_Click;
            // 
            // trackBarAccuracy
            // 
            trackBarAccuracy.Location = new Point(42, 201);
            trackBarAccuracy.Maximum = 200;
            trackBarAccuracy.Minimum = 2;
            trackBarAccuracy.Name = "trackBarAccuracy";
            trackBarAccuracy.Size = new Size(104, 45);
            trackBarAccuracy.TabIndex = 80;
            trackBarAccuracy.TickStyle = TickStyle.None;
            trackBarAccuracy.Value = 50;
            trackBarAccuracy.Scroll += trackBarAccuracy_Scroll;
            // 
            // txtAccuracy
            // 
            txtAccuracy.Enabled = false;
            txtAccuracy.Location = new Point(152, 201);
            txtAccuracy.Name = "txtAccuracy";
            txtAccuracy.Size = new Size(39, 23);
            txtAccuracy.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 201);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 8;
            label3.Text = "Dokładność triangulacji";
            // 
            // trackBarAxisZ
            // 
            trackBarAxisZ.Location = new Point(42, 100);
            trackBarAxisZ.Name = "trackBarAxisZ";
            trackBarAxisZ.Size = new Size(104, 45);
            trackBarAxisZ.TabIndex = 7;
            trackBarAxisZ.TickStyle = TickStyle.None;
            trackBarAxisZ.Scroll += trackBarBeta_Scroll;
            // 
            // trackBarAxisX
            // 
            trackBarAxisX.Location = new Point(42, 46);
            trackBarAxisX.Maximum = 45;
            trackBarAxisX.Minimum = -45;
            trackBarAxisX.Name = "trackBarAxisX";
            trackBarAxisX.Size = new Size(104, 45);
            trackBarAxisX.TabIndex = 6;
            trackBarAxisX.TickStyle = TickStyle.None;
            trackBarAxisX.Scroll += trackBarAlfa_Scroll;
            // 
            // txtAxisZValue
            // 
            txtAxisZValue.Enabled = false;
            txtAxisZValue.Location = new Point(152, 100);
            txtAxisZValue.Name = "txtAxisZValue";
            txtAxisZValue.Size = new Size(39, 23);
            txtAxisZValue.TabIndex = 5;
            // 
            // txtAxisXValue
            // 
            txtAxisXValue.Enabled = false;
            txtAxisXValue.Location = new Point(152, 46);
            txtAxisXValue.Name = "txtAxisXValue";
            txtAxisXValue.Size = new Size(39, 23);
            txtAxisXValue.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "oś Z";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 49);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "oś X";
            // 
            // btnSunMovement
            // 
            btnSunMovement.Location = new Point(144, 108);
            btnSunMovement.Name = "btnSunMovement";
            btnSunMovement.Size = new Size(59, 23);
            btnSunMovement.TabIndex = 104;
            btnSunMovement.Text = "Stop";
            btnSunMovement.UseVisualStyleBackColor = true;
            btnSunMovement.Click += btnSunMovement_Click;
            // 
            // checkBoxSunLines
            // 
            checkBoxSunLines.AutoSize = true;
            checkBoxSunLines.Location = new Point(15, 108);
            checkBoxSunLines.Name = "checkBoxSunLines";
            checkBoxSunLines.Size = new Size(117, 19);
            checkBoxSunLines.TabIndex = 102;
            checkBoxSunLines.Text = "Promienie słońca";
            checkBoxSunLines.UseVisualStyleBackColor = true;
            checkBoxSunLines.CheckedChanged += checkBoxSunLines_CheckedChanged;
            // 
            // txtSunZ
            // 
            txtSunZ.Enabled = false;
            txtSunZ.Location = new Point(144, 87);
            txtSunZ.Name = "txtSunZ";
            txtSunZ.Size = new Size(39, 23);
            txtSunZ.TabIndex = 100;
            // 
            // txtSunY
            // 
            txtSunY.Enabled = false;
            txtSunY.Location = new Point(144, 57);
            txtSunY.Name = "txtSunY";
            txtSunY.Size = new Size(39, 23);
            txtSunY.TabIndex = 99;
            // 
            // txtSunX
            // 
            txtSunX.Enabled = false;
            txtSunX.Location = new Point(144, 30);
            txtSunX.Name = "txtSunX";
            txtSunX.Size = new Size(39, 23);
            txtSunX.TabIndex = 98;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 84);
            label10.Name = "label10";
            label10.Size = new Size(12, 15);
            label10.TabIndex = 97;
            label10.Text = "z";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 57);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 96;
            label11.Text = "y";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 30);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 95;
            label12.Text = "x";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.Location = new Point(10, 0);
            label9.Name = "label9";
            label9.Size = new Size(86, 32);
            label9.TabIndex = 94;
            label9.Text = "Słońce";
            // 
            // trackBarSunY
            // 
            trackBarSunY.Location = new Point(34, 57);
            trackBarSunY.Maximum = 500;
            trackBarSunY.Minimum = -500;
            trackBarSunY.Name = "trackBarSunY";
            trackBarSunY.Size = new Size(104, 45);
            trackBarSunY.TabIndex = 93;
            trackBarSunY.TickStyle = TickStyle.None;
            trackBarSunY.Scroll += trackBarSunY_Scroll;
            // 
            // trackBarSunZ
            // 
            trackBarSunZ.Location = new Point(34, 84);
            trackBarSunZ.Maximum = 1000;
            trackBarSunZ.Minimum = -20;
            trackBarSunZ.Name = "trackBarSunZ";
            trackBarSunZ.Size = new Size(104, 45);
            trackBarSunZ.TabIndex = 92;
            trackBarSunZ.TickStyle = TickStyle.None;
            trackBarSunZ.Value = 100;
            trackBarSunZ.Scroll += trackBarSunZ_Scroll;
            // 
            // trackBarSunX
            // 
            trackBarSunX.Location = new Point(34, 30);
            trackBarSunX.Maximum = 500;
            trackBarSunX.Minimum = -500;
            trackBarSunX.Name = "trackBarSunX";
            trackBarSunX.Size = new Size(104, 45);
            trackBarSunX.TabIndex = 91;
            trackBarSunX.TickStyle = TickStyle.None;
            trackBarSunX.Scroll += trackBarSunX_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            panel2.Controls.Add(cmbTextura);
            panel2.Controls.Add(checkboxTextura);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(checkBoxSunLines);
            panel2.Controls.Add(trackBarSunZ);
            panel2.Controls.Add(btnSunMovement);
            panel2.Controls.Add(trackBarSunY);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(trackBarSunX);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtSunZ);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtSunY);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtSunX);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 478);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 150);
            panel2.TabIndex = 2;
            // 
            // cmbTextura
            // 
            cmbTextura.FormattingEnabled = true;
            cmbTextura.Location = new Point(254, 61);
            cmbTextura.Margin = new Padding(3, 2, 3, 2);
            cmbTextura.Name = "cmbTextura";
            cmbTextura.Size = new Size(133, 23);
            cmbTextura.TabIndex = 107;
            cmbTextura.SelectedIndexChanged += cmbTextura_SelectedIndexChanged;
            // 
            // checkboxTextura
            // 
            checkboxTextura.AutoSize = true;
            checkboxTextura.Location = new Point(254, 41);
            checkboxTextura.Margin = new Padding(3, 2, 3, 2);
            checkboxTextura.Name = "checkboxTextura";
            checkboxTextura.Size = new Size(63, 19);
            checkboxTextura.TabIndex = 106;
            checkboxTextura.Text = "textura";
            checkboxTextura.UseVisualStyleBackColor = true;
            checkboxTextura.CheckedChanged += checkboxTextura_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label13.Location = new Point(240, 0);
            label13.Name = "label13";
            label13.Size = new Size(91, 32);
            label13.TabIndex = 105;
            label13.Text = "Textura";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(872, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(canvas);
            Name = "mainForm";
            Text = "Generating surface";
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarM).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKs).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKd).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAccuracy).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunY).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSunX).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private Panel panel1;
        private TrackBar trackBarAlfaa;
        private Label label1;
        private Label label2;
        private TextBox txtAxisXValue;
        private TextBox txtAxisZValue;
        private NoFocusTrackBar trackBarAxisX;
        private NoFocusTrackBar trackBarAxisZ;
        private NoFocusTrackBar trackBarAccuracy;
        private TextBox txtAccuracy;
        private Label label3;
        private Button btnLightColor;
        private NoFocusTrackBar trackBarAxisY;
        private TextBox txtAxisYValue;
        private Label label4;
        private CheckBox checkBoxLittleGrid;
        private CheckBox checkBoxMainLines;
        private CheckBox checkBoxMainPoints;
        private CheckBox checkBoxAxis;
        private NoFocusTrackBar trackBarM;
        private TextBox txtM;
        private Label label8;
        private NoFocusTrackBar trackBarKs;
        private TextBox txtKs;
        private Label label7;
        private NoFocusTrackBar trackBarKd;
        private TextBox txtKd;
        private Label label6;
        private Label label5;
        private ColorDialog colorDialog1;
        private NoFocusTrackBar trackBarSunX;
        private NoFocusTrackBar trackBarSunY;
        private NoFocusTrackBar trackBarSunZ;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label9;
        private TextBox txtSunZ;
        private TextBox txtSunY;
        private TextBox txtSunX;
        private CheckBox checkBoxFill;
        private CheckBox checkBoxSunLines;
        private System.Windows.Forms.Timer timer1;
        private Button btnSurfaceColor;
        private Button btnSunMovement;
        private ComboBox cmbSurfaceFile;
        private Panel panel2;
        private ComboBox cmbTextura;
        private CheckBox checkboxTextura;
        private Label label13;
    }
}
