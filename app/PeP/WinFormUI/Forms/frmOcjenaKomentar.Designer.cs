namespace WinFormUI.Forms {
    partial class frmOcjenaKomentar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcjenaKomentar));
            this.rtxtKomentar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxtKomentar
            // 
            this.rtxtKomentar.Enabled = false;
            this.rtxtKomentar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtKomentar.Location = new System.Drawing.Point(12, 46);
            this.rtxtKomentar.Name = "rtxtKomentar";
            this.rtxtKomentar.Size = new System.Drawing.Size(473, 133);
            this.rtxtKomentar.TabIndex = 0;
            this.rtxtKomentar.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Napomena:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatvori.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZatvori.Location = new System.Drawing.Point(176, 185);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 23);
            this.btnZatvori.TabIndex = 90;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // frmOcjenaKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(497, 220);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtKomentar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOcjenaKomentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOcjenaKomentar";
            this.Load += new System.EventHandler(this.frmOcjenaKomentar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtKomentar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZatvori;
    }
}