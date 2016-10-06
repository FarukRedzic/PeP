namespace WinFormUI.Forms {
    partial class frmKomentarDetaljno {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKomentarDetaljno));
            this.lblProizvodId = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.rtxtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelKorisnik = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblProizvodId
            // 
            this.lblProizvodId.AutoSize = true;
            this.lblProizvodId.Location = new System.Drawing.Point(247, 75);
            this.lblProizvodId.Name = "lblProizvodId";
            this.lblProizvodId.Size = new System.Drawing.Size(0, 13);
            this.lblProizvodId.TabIndex = 103;
            this.lblProizvodId.Visible = false;
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
            this.btnZatvori.Location = new System.Drawing.Point(135, 288);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(66, 23);
            this.btnZatvori.TabIndex = 98;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // rtxtSadrzaj
            // 
            this.rtxtSadrzaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSadrzaj.Location = new System.Drawing.Point(46, 75);
            this.rtxtSadrzaj.Name = "rtxtSadrzaj";
            this.rtxtSadrzaj.ReadOnly = true;
            this.rtxtSadrzaj.Size = new System.Drawing.Size(244, 203);
            this.rtxtSadrzaj.TabIndex = 97;
            this.rtxtSadrzaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 96;
            this.label2.Text = "Sadržaj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "Napisao komentar:";
            // 
            // linkLabelKorisnik
            // 
            this.linkLabelKorisnik.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkLabelKorisnik.AutoSize = true;
            this.linkLabelKorisnik.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelKorisnik.LinkColor = System.Drawing.Color.Navy;
            this.linkLabelKorisnik.Location = new System.Drawing.Point(188, 24);
            this.linkLabelKorisnik.Name = "linkLabelKorisnik";
            this.linkLabelKorisnik.Size = new System.Drawing.Size(77, 20);
            this.linkLabelKorisnik.TabIndex = 104;
            this.linkLabelKorisnik.TabStop = true;
            this.linkLabelKorisnik.Text = "linkLabel1";
            this.linkLabelKorisnik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelKorisnik_LinkClicked);
            // 
            // frmKomentarDetaljno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(336, 334);
            this.Controls.Add(this.linkLabelKorisnik);
            this.Controls.Add(this.lblProizvodId);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.rtxtSadrzaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKomentarDetaljno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komentar";
            this.Load += new System.EventHandler(this.frmKomentarDetaljno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProizvodId;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.RichTextBox rtxtSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelKorisnik;
    }
}