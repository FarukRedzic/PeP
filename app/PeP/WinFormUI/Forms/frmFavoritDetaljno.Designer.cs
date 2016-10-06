namespace WinFormUI.Forms {
    partial class frmFavoritDetaljno {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFavoritDetaljno));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.rtxtOpisFavorit = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkAktivanFavorit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazivFavorit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCijenaFavorit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVlasnikFavorit = new System.Windows.Forms.Label();
            this.pbProizvodSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvodSlika)).BeginInit();
            this.SuspendLayout();
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
            this.btnZatvori.Location = new System.Drawing.Point(482, 131);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(66, 23);
            this.btnZatvori.TabIndex = 101;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // rtxtOpisFavorit
            // 
            this.rtxtOpisFavorit.Location = new System.Drawing.Point(13, 141);
            this.rtxtOpisFavorit.Name = "rtxtOpisFavorit";
            this.rtxtOpisFavorit.ReadOnly = true;
            this.rtxtOpisFavorit.Size = new System.Drawing.Size(355, 96);
            this.rtxtOpisFavorit.TabIndex = 100;
            this.rtxtOpisFavorit.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "Opis:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkAktivanFavorit
            // 
            this.chkAktivanFavorit.AutoSize = true;
            this.chkAktivanFavorit.Enabled = false;
            this.chkAktivanFavorit.Location = new System.Drawing.Point(95, 86);
            this.chkAktivanFavorit.Name = "chkAktivanFavorit";
            this.chkAktivanFavorit.Size = new System.Drawing.Size(15, 14);
            this.chkAktivanFavorit.TabIndex = 98;
            this.chkAktivanFavorit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "Naziv:";
            // 
            // lblNazivFavorit
            // 
            this.lblNazivFavorit.AutoSize = true;
            this.lblNazivFavorit.BackColor = System.Drawing.Color.CadetBlue;
            this.lblNazivFavorit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivFavorit.Location = new System.Drawing.Point(76, 29);
            this.lblNazivFavorit.Name = "lblNazivFavorit";
            this.lblNazivFavorit.Size = new System.Drawing.Size(0, 25);
            this.lblNazivFavorit.TabIndex = 97;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.CadetBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 91;
            this.label11.Text = "Aktivan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 90;
            this.label4.Text = "Cijena:";
            // 
            // lblCijenaFavorit
            // 
            this.lblCijenaFavorit.AutoSize = true;
            this.lblCijenaFavorit.BackColor = System.Drawing.Color.CadetBlue;
            this.lblCijenaFavorit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCijenaFavorit.Location = new System.Drawing.Point(77, 53);
            this.lblCijenaFavorit.Name = "lblCijenaFavorit";
            this.lblCijenaFavorit.Size = new System.Drawing.Size(0, 25);
            this.lblCijenaFavorit.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 102;
            this.label3.Text = "Vlasnik:";
            // 
            // lblVlasnikFavorit
            // 
            this.lblVlasnikFavorit.AutoSize = true;
            this.lblVlasnikFavorit.BackColor = System.Drawing.Color.CadetBlue;
            this.lblVlasnikFavorit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlasnikFavorit.Location = new System.Drawing.Point(89, 6);
            this.lblVlasnikFavorit.Name = "lblVlasnikFavorit";
            this.lblVlasnikFavorit.Size = new System.Drawing.Size(0, 25);
            this.lblVlasnikFavorit.TabIndex = 103;
            // 
            // pbProizvodSlika
            // 
            this.pbProizvodSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbProizvodSlika.Location = new System.Drawing.Point(455, 6);
            this.pbProizvodSlika.Name = "pbProizvodSlika";
            this.pbProizvodSlika.Size = new System.Drawing.Size(120, 120);
            this.pbProizvodSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProizvodSlika.TabIndex = 104;
            this.pbProizvodSlika.TabStop = false;
            // 
            // frmFavoritDetaljno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(584, 249);
            this.Controls.Add(this.pbProizvodSlika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblVlasnikFavorit);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.rtxtOpisFavorit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkAktivanFavorit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNazivFavorit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCijenaFavorit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavoritDetaljno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Favorit detaljno";
            this.Load += new System.EventHandler(this.frmFavoritDetaljno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProizvodSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.RichTextBox rtxtOpisFavorit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkAktivanFavorit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazivFavorit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCijenaFavorit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVlasnikFavorit;
        private System.Windows.Forms.PictureBox pbProizvodSlika;
    }
}