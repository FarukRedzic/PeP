namespace WinFormUI.Forms {
    partial class frmZaboravioLozinku {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZaboravioLozinku));
            this.label8 = new System.Windows.Forms.Label();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(59, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Korisničko ime:";
            // 
            // btnPosalji
            // 
            this.btnPosalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPosalji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosalji.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPosalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosalji.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosalji.Image = ((System.Drawing.Image)(resources.GetObject("btnPosalji.Image")));
            this.btnPosalji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosalji.Location = new System.Drawing.Point(246, 62);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(75, 23);
            this.btnPosalji.TabIndex = 44;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPosalji.UseVisualStyleBackColor = false;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOdustani.Image = ((System.Drawing.Image)(resources.GetObject("btnOdustani.Image")));
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(166, 62);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 43;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(172, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 20);
            this.txtUsername.TabIndex = 41;
            // 
            // frmZaboravioLozinku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(403, 122);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmZaboravioLozinku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Povrat lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtUsername;
    }
}