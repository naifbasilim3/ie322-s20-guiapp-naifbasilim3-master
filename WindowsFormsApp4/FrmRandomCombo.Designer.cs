namespace WindowsFormsApp4
{
    partial class FrmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rdo2 = new System.Windows.Forms.RadioButton();
            this.Rdo1 = new System.Windows.Forms.RadioButton();
            this.CmbRandom = new System.Windows.Forms.ComboBox();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rdo4 = new System.Windows.Forms.RadioButton();
            this.Rdo3 = new System.Windows.Forms.RadioButton();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnReset2 = new System.Windows.Forms.Button();
            this.BtnGenerate2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdo2);
            this.groupBox1.Controls.Add(this.Rdo1);
            this.groupBox1.Controls.Add(this.CmbRandom);
            this.groupBox1.Controls.Add(this.BtnReset1);
            this.groupBox1.Controls.Add(this.BtnGenerate);
            this.groupBox1.Location = new System.Drawing.Point(67, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Rdo2
            // 
            this.Rdo2.AutoSize = true;
            this.Rdo2.Location = new System.Drawing.Point(198, 143);
            this.Rdo2.Name = "Rdo2";
            this.Rdo2.Size = new System.Drawing.Size(105, 17);
            this.Rdo2.TabIndex = 4;
            this.Rdo2.TabStop = true;
            this.Rdo2.Text = "Greater than 500";
            this.Rdo2.UseVisualStyleBackColor = true;
            // 
            // Rdo1
            // 
            this.Rdo1.AutoSize = true;
            this.Rdo1.Location = new System.Drawing.Point(198, 100);
            this.Rdo1.Name = "Rdo1";
            this.Rdo1.Size = new System.Drawing.Size(92, 17);
            this.Rdo1.TabIndex = 3;
            this.Rdo1.TabStop = true;
            this.Rdo1.Text = "Less than 500";
            this.Rdo1.UseVisualStyleBackColor = true;
            // 
            // CmbRandom
            // 
            this.CmbRandom.FormattingEnabled = true;
            this.CmbRandom.Location = new System.Drawing.Point(17, 38);
            this.CmbRandom.Name = "CmbRandom";
            this.CmbRandom.Size = new System.Drawing.Size(95, 21);
            this.CmbRandom.TabIndex = 2;
            // 
            // BtnReset1
            // 
            this.BtnReset1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnReset1.Location = new System.Drawing.Point(205, 188);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(78, 33);
            this.BtnReset1.TabIndex = 1;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = false;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGenerate.Location = new System.Drawing.Point(205, 31);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(78, 33);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rdo4);
            this.groupBox2.Controls.Add(this.Rdo3);
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Controls.Add(this.BtnReset2);
            this.groupBox2.Controls.Add(this.BtnGenerate2);
            this.groupBox2.Location = new System.Drawing.Point(449, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Rdo4
            // 
            this.Rdo4.AutoSize = true;
            this.Rdo4.Location = new System.Drawing.Point(194, 134);
            this.Rdo4.Name = "Rdo4";
            this.Rdo4.Size = new System.Drawing.Size(99, 17);
            this.Rdo4.TabIndex = 5;
            this.Rdo4.TabStop = true;
            this.Rdo4.Text = "Greater than 50";
            this.Rdo4.UseVisualStyleBackColor = true;
            // 
            // Rdo3
            // 
            this.Rdo3.AutoSize = true;
            this.Rdo3.Location = new System.Drawing.Point(194, 100);
            this.Rdo3.Name = "Rdo3";
            this.Rdo3.Size = new System.Drawing.Size(86, 17);
            this.Rdo3.TabIndex = 6;
            this.Rdo3.TabStop = true;
            this.Rdo3.Text = "Less than 50";
            this.Rdo3.UseVisualStyleBackColor = true;
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(19, 38);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(95, 21);
            this.CmbRandom2.TabIndex = 3;
            // 
            // BtnReset2
            // 
            this.BtnReset2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnReset2.Location = new System.Drawing.Point(194, 188);
            this.BtnReset2.Name = "BtnReset2";
            this.BtnReset2.Size = new System.Drawing.Size(78, 33);
            this.BtnReset2.TabIndex = 2;
            this.BtnReset2.Text = "Reset";
            this.BtnReset2.UseVisualStyleBackColor = false;
            // 
            // BtnGenerate2
            // 
            this.BtnGenerate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGenerate2.Location = new System.Drawing.Point(194, 31);
            this.BtnGenerate2.Name = "BtnGenerate2";
            this.BtnGenerate2.Size = new System.Drawing.Size(78, 33);
            this.BtnGenerate2.TabIndex = 3;
            this.BtnGenerate2.Text = "Generate";
            this.BtnGenerate2.UseVisualStyleBackColor = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Green;
            this.BtnBack.Location = new System.Drawing.Point(389, 387);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(78, 33);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rdo2;
        private System.Windows.Forms.RadioButton Rdo1;
        private System.Windows.Forms.ComboBox CmbRandom;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rdo4;
        private System.Windows.Forms.RadioButton Rdo3;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnReset2;
        private System.Windows.Forms.Button BtnGenerate2;
        private System.Windows.Forms.Button BtnBack;
    }
}