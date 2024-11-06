namespace generating_surface
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
            canvas = new PictureBox();
            panel1 = new Panel();
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
            button1 = new Button();
            trackBarAccuracy = new NoFocusTrackBar();
            txtAccuracy = new TextBox();
            label3 = new Label();
            trackBarAxisZ = new NoFocusTrackBar();
            trackBarAxisX = new NoFocusTrackBar();
            txtAxisZValue = new TextBox();
            txtAxisXValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarKd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAccuracy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAxisX).BeginInit();
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
            panel1.Controls.Add(button1);
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
            panel1.Location = new Point(633, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 678);
            panel1.TabIndex = 1;
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
            checkBoxAxis.Location = new Point(9, 327);
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
            checkBoxLittleGrid.Checked = true;
            checkBoxLittleGrid.CheckState = CheckState.Checked;
            checkBoxLittleGrid.Location = new Point(9, 302);
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
            checkBoxMainLines.Location = new Point(9, 277);
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
            checkBoxMainPoints.Location = new Point(9, 252);
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
            trackBarAxisY.Maximum = 180;
            trackBarAxisY.Minimum = -180;
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
            // button1
            // 
            button1.Location = new Point(65, 643);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBarAccuracy
            // 
            trackBarAccuracy.Location = new Point(42, 201);
            trackBarAccuracy.Maximum = 80;
            trackBarAccuracy.Minimum = 2;
            trackBarAccuracy.Name = "trackBarAccuracy";
            trackBarAccuracy.Size = new Size(104, 45);
            trackBarAccuracy.TabIndex = 80;
            trackBarAccuracy.TickStyle = TickStyle.None;
            trackBarAccuracy.Value = 5;
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
            trackBarAxisZ.Maximum = 180;
            trackBarAxisZ.Minimum = -180;
            trackBarAxisZ.Name = "trackBarAxisZ";
            trackBarAxisZ.Size = new Size(104, 45);
            trackBarAxisZ.TabIndex = 7;
            trackBarAxisZ.TickStyle = TickStyle.None;
            trackBarAxisZ.Scroll += trackBarBeta_Scroll;
            // 
            // trackBarAxisX
            // 
            trackBarAxisX.Location = new Point(42, 46);
            trackBarAxisX.Maximum = 180;
            trackBarAxisX.Minimum = -180;
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
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(897, 678);
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
        private Button button1;
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
    }
}
