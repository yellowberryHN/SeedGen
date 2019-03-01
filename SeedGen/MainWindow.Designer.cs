namespace SeedGen
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.s2s = new System.Windows.Forms.RadioButton();
            this.n2s = new System.Windows.Forms.RadioButton();
            this.s2n = new System.Windows.Forms.RadioButton();
            this.parameters = new System.Windows.Forms.GroupBox();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.seedLengthText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.buttonSite = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGen
            // 
            this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGen.Location = new System.Drawing.Point(152, 260);
            this.buttonGen.Name = "buttonGen";
            this.buttonGen.Size = new System.Drawing.Size(80, 23);
            this.buttonGen.TabIndex = 0;
            this.buttonGen.Text = "Generate";
            this.buttonGen.UseVisualStyleBackColor = false;
            this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SeedGen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.s2s);
            this.groupBox1.Controls.Add(this.n2s);
            this.groupBox1.Controls.Add(this.s2n);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type:";
            // 
            // s2s
            // 
            this.s2s.AutoSize = true;
            this.s2s.Location = new System.Drawing.Point(6, 66);
            this.s2s.Name = "s2s";
            this.s2s.Size = new System.Drawing.Size(94, 17);
            this.s2s.TabIndex = 2;
            this.s2s.Text = "String to String";
            this.s2s.UseVisualStyleBackColor = true;
            this.s2s.CheckedChanged += new System.EventHandler(this.s2s_CheckedChanged);
            // 
            // n2s
            // 
            this.n2s.AutoSize = true;
            this.n2s.Location = new System.Drawing.Point(6, 43);
            this.n2s.Name = "n2s";
            this.n2s.Size = new System.Drawing.Size(104, 17);
            this.n2s.TabIndex = 1;
            this.n2s.Text = "Number to String";
            this.n2s.UseVisualStyleBackColor = true;
            this.n2s.CheckedChanged += new System.EventHandler(this.n2s_CheckedChanged);
            // 
            // s2n
            // 
            this.s2n.AutoSize = true;
            this.s2n.Checked = true;
            this.s2n.Location = new System.Drawing.Point(6, 20);
            this.s2n.Name = "s2n";
            this.s2n.Size = new System.Drawing.Size(104, 17);
            this.s2n.TabIndex = 0;
            this.s2n.TabStop = true;
            this.s2n.Text = "String to Number";
            this.s2n.UseVisualStyleBackColor = true;
            this.s2n.CheckedChanged += new System.EventHandler(this.s2n_CheckedChanged);
            // 
            // parameters
            // 
            this.parameters.Controls.Add(this.trackBar);
            this.parameters.Controls.Add(this.seedLengthText);
            this.parameters.Location = new System.Drawing.Point(134, 50);
            this.parameters.Name = "parameters";
            this.parameters.Size = new System.Drawing.Size(238, 100);
            this.parameters.TabIndex = 3;
            this.parameters.TabStop = false;
            this.parameters.Text = "Parameters:";
            this.parameters.Visible = false;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(6, 37);
            this.trackBar.Maximum = 12;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(226, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // seedLengthText
            // 
            this.seedLengthText.AutoSize = true;
            this.seedLengthText.Location = new System.Drawing.Point(6, 20);
            this.seedLengthText.Name = "seedLengthText";
            this.seedLengthText.Size = new System.Drawing.Size(80, 13);
            this.seedLengthText.TabIndex = 0;
            this.seedLengthText.Text = "Seed Length: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seed:";
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(12, 174);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(360, 20);
            this.seedBox.TabIndex = 5;
            // 
            // buttonSite
            // 
            this.buttonSite.Location = new System.Drawing.Point(12, 260);
            this.buttonSite.Name = "buttonSite";
            this.buttonSite.Size = new System.Drawing.Size(80, 23);
            this.buttonSite.TabIndex = 7;
            this.buttonSite.Text = "Visit Site";
            this.buttonSite.UseVisualStyleBackColor = true;
            this.buttonSite.Click += new System.EventHandler(this.buttonSite_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 218);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(360, 20);
            this.outputBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Output:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 295);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSite);
            this.Controls.Add(this.seedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parameters);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "SeedGen by Yellowberry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.parameters.ResumeLayout(false);
            this.parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton s2s;
        private System.Windows.Forms.RadioButton n2s;
        private System.Windows.Forms.RadioButton s2n;
        private System.Windows.Forms.GroupBox parameters;
        private System.Windows.Forms.Label seedLengthText;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Button buttonSite;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label2;
    }
}

