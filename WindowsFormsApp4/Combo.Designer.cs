namespace WindowsFormsApp4
{
    partial class FrmCombo
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
            this.BtnMethood1 = new System.Windows.Forms.Button();
            this.BtnMethood2 = new System.Windows.Forms.Button();
            this.BtnRemoveInd = new System.Windows.Forms.Button();
            this.BtnRemoeName = new System.Windows.Forms.Button();
            this.BtnBackCombo = new System.Windows.Forms.Button();
            this.BtnRemove2ndItem = new System.Windows.Forms.Button();
            this.BtnRemoveLastitem = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnMethood1
            // 
            this.BtnMethood1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMethood1.Location = new System.Drawing.Point(124, 76);
            this.BtnMethood1.Name = "BtnMethood1";
            this.BtnMethood1.Size = new System.Drawing.Size(122, 52);
            this.BtnMethood1.TabIndex = 0;
            this.BtnMethood1.Text = "show  method 1";
            this.BtnMethood1.UseVisualStyleBackColor = false;
            // 
            // BtnMethood2
            // 
            this.BtnMethood2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnMethood2.Location = new System.Drawing.Point(415, 76);
            this.BtnMethood2.Name = "BtnMethood2";
            this.BtnMethood2.Size = new System.Drawing.Size(122, 52);
            this.BtnMethood2.TabIndex = 1;
            this.BtnMethood2.Text = "show method 2";
            this.BtnMethood2.UseVisualStyleBackColor = false;
            // 
            // BtnRemoveInd
            // 
            this.BtnRemoveInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRemoveInd.Location = new System.Drawing.Point(124, 310);
            this.BtnRemoveInd.Name = "BtnRemoveInd";
            this.BtnRemoveInd.Size = new System.Drawing.Size(122, 52);
            this.BtnRemoveInd.TabIndex = 2;
            this.BtnRemoveInd.Text = "Remove by Index";
            this.BtnRemoveInd.UseVisualStyleBackColor = false;
            // 
            // BtnRemoeName
            // 
            this.BtnRemoeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnRemoeName.Location = new System.Drawing.Point(415, 310);
            this.BtnRemoeName.Name = "BtnRemoeName";
            this.BtnRemoeName.Size = new System.Drawing.Size(122, 52);
            this.BtnRemoeName.TabIndex = 3;
            this.BtnRemoeName.Text = "Remove by Name";
            this.BtnRemoeName.UseVisualStyleBackColor = false;
            // 
            // BtnBackCombo
            // 
            this.BtnBackCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnBackCombo.Location = new System.Drawing.Point(633, 375);
            this.BtnBackCombo.Name = "BtnBackCombo";
            this.BtnBackCombo.Size = new System.Drawing.Size(122, 52);
            this.BtnBackCombo.TabIndex = 4;
            this.BtnBackCombo.Text = "Back";
            this.BtnBackCombo.UseVisualStyleBackColor = false;
            // 
            // BtnRemove2ndItem
            // 
            this.BtnRemove2ndItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRemove2ndItem.Location = new System.Drawing.Point(633, 215);
            this.BtnRemove2ndItem.Name = "BtnRemove2ndItem";
            this.BtnRemove2ndItem.Size = new System.Drawing.Size(122, 52);
            this.BtnRemove2ndItem.TabIndex = 5;
            this.BtnRemove2ndItem.Text = "Remove 2nd item";
            this.BtnRemove2ndItem.UseVisualStyleBackColor = false;
            // 
            // BtnRemoveLastitem
            // 
            this.BtnRemoveLastitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRemoveLastitem.Location = new System.Drawing.Point(633, 128);
            this.BtnRemoveLastitem.Name = "BtnRemoveLastitem";
            this.BtnRemoveLastitem.Size = new System.Drawing.Size(122, 52);
            this.BtnRemoveLastitem.TabIndex = 6;
            this.BtnRemoveLastitem.Text = "Remove last item";
            this.BtnRemoveLastitem.UseVisualStyleBackColor = false;
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(124, 187);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(127, 21);
            this.CmbDays.TabIndex = 7;
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnRemoveLastitem);
            this.Controls.Add(this.BtnRemove2ndItem);
            this.Controls.Add(this.BtnBackCombo);
            this.Controls.Add(this.BtnRemoeName);
            this.Controls.Add(this.BtnRemoveInd);
            this.Controls.Add(this.BtnMethood2);
            this.Controls.Add(this.BtnMethood1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMethood1;
        private System.Windows.Forms.Button BtnMethood2;
        private System.Windows.Forms.Button BtnRemoveInd;
        private System.Windows.Forms.Button BtnRemoeName;
        private System.Windows.Forms.Button BtnBackCombo;
        private System.Windows.Forms.Button BtnRemove2ndItem;
        private System.Windows.Forms.Button BtnRemoveLastitem;
        private System.Windows.Forms.ComboBox CmbDays;
    }
}