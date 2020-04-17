namespace WindowsFormsApp4
{
    partial class FrmCheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.ChkCoffee = new System.Windows.Forms.CheckBox();
            this.ChkDonut = new System.Windows.Forms.CheckBox();
            this.ChkBrownie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnShow.Location = new System.Drawing.Point(99, 85);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(128, 37);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBack.Location = new System.Drawing.Point(582, 354);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(128, 37);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // ChkCoffee
            // 
            this.ChkCoffee.AutoSize = true;
            this.ChkCoffee.Location = new System.Drawing.Point(324, 175);
            this.ChkCoffee.Name = "ChkCoffee";
            this.ChkCoffee.Size = new System.Drawing.Size(57, 17);
            this.ChkCoffee.TabIndex = 2;
            this.ChkCoffee.Text = "Coffee";
            this.ChkCoffee.UseVisualStyleBackColor = true;
            // 
            // ChkDonut
            // 
            this.ChkDonut.AutoSize = true;
            this.ChkDonut.Location = new System.Drawing.Point(324, 236);
            this.ChkDonut.Name = "ChkDonut";
            this.ChkDonut.Size = new System.Drawing.Size(55, 17);
            this.ChkDonut.TabIndex = 3;
            this.ChkDonut.Text = "Donut";
            this.ChkDonut.UseVisualStyleBackColor = true;
            // 
            // ChkBrownie
            // 
            this.ChkBrownie.AutoSize = true;
            this.ChkBrownie.Location = new System.Drawing.Point(324, 295);
            this.ChkBrownie.Name = "ChkBrownie";
            this.ChkBrownie.Size = new System.Drawing.Size(64, 17);
            this.ChkBrownie.TabIndex = 4;
            this.ChkBrownie.Text = "Brownie";
            this.ChkBrownie.UseVisualStyleBackColor = true;
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkBrownie);
            this.Controls.Add(this.ChkDonut);
            this.Controls.Add(this.ChkCoffee);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheck";
            this.Text = "Check Box Form";
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.CheckBox ChkCoffee;
        private System.Windows.Forms.CheckBox ChkDonut;
        private System.Windows.Forms.CheckBox ChkBrownie;
    }
}