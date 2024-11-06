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
            noFocusTrackBar1 = new NoFocusTrackBar();
            textBox1 = new TextBox();
            label3 = new Label();
            trackBarBeta = new NoFocusTrackBar();
            trackBarAlfa = new NoFocusTrackBar();
            txtBetaValue = new TextBox();
            txtAlfaValue = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)canvas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)noFocusTrackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAlfa).BeginInit();
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
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(noFocusTrackBar1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(trackBarBeta);
            panel1.Controls.Add(trackBarAlfa);
            panel1.Controls.Add(txtBetaValue);
            panel1.Controls.Add(txtAlfaValue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(693, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 450);
            panel1.TabIndex = 1;
            // 
            // noFocusTrackBar1
            // 
            noFocusTrackBar1.Location = new Point(42, 140);
            noFocusTrackBar1.Name = "noFocusTrackBar1";
            noFocusTrackBar1.Size = new Size(104, 45);
            noFocusTrackBar1.TabIndex = 10;
            noFocusTrackBar1.TickStyle = TickStyle.None;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(152, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(39, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 140);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 8;
            label3.Text = "Dokładność triangulacji";
            // 
            // trackBarBeta
            // 
            trackBarBeta.Location = new Point(42, 100);
            trackBarBeta.Name = "trackBarBeta";
            trackBarBeta.Size = new Size(104, 45);
            trackBarBeta.TabIndex = 7;
            trackBarBeta.TickStyle = TickStyle.None;
            trackBarBeta.Scroll += trackBarBeta_Scroll;
            // 
            // trackBarAlfa
            // 
            trackBarAlfa.Location = new Point(42, 46);
            trackBarAlfa.Maximum = 45;
            trackBarAlfa.Minimum = -45;
            trackBarAlfa.Name = "trackBarAlfa";
            trackBarAlfa.Size = new Size(104, 45);
            trackBarAlfa.TabIndex = 6;
            trackBarAlfa.TickStyle = TickStyle.None;
            trackBarAlfa.Value = -45;
            trackBarAlfa.Scroll += trackBarAlfa_Scroll;
            // 
            // txtBetaValue
            // 
            txtBetaValue.Enabled = false;
            txtBetaValue.Location = new Point(152, 100);
            txtBetaValue.Name = "txtBetaValue";
            txtBetaValue.Size = new Size(39, 23);
            txtBetaValue.TabIndex = 5;
            // 
            // txtAlfaValue
            // 
            txtAlfaValue.Enabled = false;
            txtAlfaValue.Location = new Point(152, 46);
            txtAlfaValue.Name = "txtAlfaValue";
            txtAlfaValue.Size = new Size(39, 23);
            txtAlfaValue.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 100);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Beta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 49);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 1;
            label1.Text = "Alfa";
            // 
            // button1
            // 
            button1.Location = new Point(83, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(957, 450);
            Controls.Add(panel1);
            Controls.Add(canvas);
            Name = "mainForm";
            Text = "Generating surface";
            ((System.ComponentModel.ISupportInitialize)canvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)noFocusTrackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarAlfa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox canvas;
        private Panel panel1;
        private TrackBar trackBarAlfaa;
        private Label label1;
        private Label label2;
        private TextBox txtAlfaValue;
        private TextBox txtBetaValue;
        private NoFocusTrackBar trackBarAlfa;
        private NoFocusTrackBar trackBarBeta;
        private NoFocusTrackBar noFocusTrackBar1;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
    }
}
