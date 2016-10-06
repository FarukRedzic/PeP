namespace WinFormUI.Forms {
    partial class frmKomentariProizvod {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKomentariProizvod));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvKomentari = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Komentarisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(203, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 50;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(203, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 51;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(169, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(29, 13);
            this.lblIme.TabIndex = 52;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(149, 38);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(51, 13);
            this.lblPrezime.TabIndex = 53;
            this.lblPrezime.Text = "Prezime:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrazi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTrazi.Image = ((System.Drawing.Image)(resources.GetObject("btnTrazi.Image")));
            this.btnTrazi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrazi.Location = new System.Drawing.Point(330, 9);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 23);
            this.btnTrazi.TabIndex = 55;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(330, 38);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 56;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
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
            this.btnZatvori.Location = new System.Drawing.Point(225, 229);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 23);
            this.btnZatvori.TabIndex = 90;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvKomentari
            // 
            this.dgvKomentari.AllowUserToAddRows = false;
            this.dgvKomentari.AllowUserToDeleteRows = false;
            this.dgvKomentari.AllowUserToOrderColumns = true;
            this.dgvKomentari.AllowUserToResizeColumns = false;
            this.dgvKomentari.AllowUserToResizeRows = false;
            this.dgvKomentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKomentari.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKomentari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKomentari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sadrzaj,
            this.Komentarisao,
            this.Slika});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKomentari.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvKomentari.Location = new System.Drawing.Point(65, 67);
            this.dgvKomentari.Name = "dgvKomentari";
            this.dgvKomentari.ReadOnly = true;
            this.dgvKomentari.RowHeadersVisible = false;
            this.dgvKomentari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKomentari.Size = new System.Drawing.Size(460, 156);
            this.dgvKomentari.TabIndex = 91;
            this.dgvKomentari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKomentari_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadržaj";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            this.Sadrzaj.Width = 180;
            // 
            // Komentarisao
            // 
            this.Komentarisao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Komentarisao.DataPropertyName = "Komentarisao";
            this.Komentarisao.HeaderText = "Komentarisao";
            this.Komentarisao.Name = "Komentarisao";
            this.Komentarisao.ReadOnly = true;
            this.Komentarisao.Width = 150;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmKomentariProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(590, 267);
            this.Controls.Add(this.dgvKomentari);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKomentariProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komentari";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvKomentari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentarisao;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
    }
}