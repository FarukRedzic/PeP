namespace WinFormUI.Forms {
    partial class frmPretragaKorisnik {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaKorisnik));
            this.Korisnici = new System.Windows.Forms.GroupBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnTraziKorisnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.Korisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // Korisnici
            // 
            this.Korisnici.BackColor = System.Drawing.Color.CadetBlue;
            this.Korisnici.Controls.Add(this.btnIspis);
            this.Korisnici.Controls.Add(this.btnDetalji);
            this.Korisnici.Controls.Add(this.dgvKorisnici);
            this.Korisnici.Controls.Add(this.btnOsvjezi);
            this.Korisnici.Controls.Add(this.cbxStatus);
            this.Korisnici.Controls.Add(this.btnTraziKorisnik);
            this.Korisnici.Controls.Add(this.label1);
            this.Korisnici.Controls.Add(this.txtPrezime);
            this.Korisnici.Controls.Add(this.label2);
            this.Korisnici.Controls.Add(this.txtIme);
            this.Korisnici.Controls.Add(this.label3);
            this.Korisnici.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Korisnici.Location = new System.Drawing.Point(31, 21);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(888, 399);
            this.Korisnici.TabIndex = 23;
            this.Korisnici.TabStop = false;
            this.Korisnici.Text = "Pretraga korisnika";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetalji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalji.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDetalji.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalji.Location = new System.Drawing.Point(745, 354);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(107, 26);
            this.btnDetalji.TabIndex = 40;
            this.btnDetalji.Text = "Detaljan pregled";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AllowUserToOrderColumns = true;
            this.dgvKorisnici.AllowUserToResizeColumns = false;
            this.dgvKorisnici.AllowUserToResizeRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKorisnici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email,
            this.Telefon,
            this.Naziv,
            this.Aktivan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKorisnici.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKorisnici.Location = new System.Drawing.Point(50, 76);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersVisible = false;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(802, 272);
            this.dgvKorisnici.TabIndex = 20;
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
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "Korisničko ime";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Width = 114;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 158;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Width = 113;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Naziv.DataPropertyName = "Opstina";
            this.Naziv.HeaderText = "Opština";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            this.Aktivan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Aktivan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Aktivan.Width = 114;
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjezi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjezi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOsvjezi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOsvjezi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjezi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjezi.Image")));
            this.btnOsvjezi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjezi.Location = new System.Drawing.Point(628, 28);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 21;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(408, 30);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 23);
            this.cbxStatus.TabIndex = 13;
            // 
            // btnTraziKorisnik
            // 
            this.btnTraziKorisnik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraziKorisnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraziKorisnik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTraziKorisnik.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraziKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraziKorisnik.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraziKorisnik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTraziKorisnik.Image = ((System.Drawing.Image)(resources.GetObject("btnTraziKorisnik.Image")));
            this.btnTraziKorisnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziKorisnik.Location = new System.Drawing.Point(559, 28);
            this.btnTraziKorisnik.Name = "btnTraziKorisnik";
            this.btnTraziKorisnik.Size = new System.Drawing.Size(65, 23);
            this.btnTraziKorisnik.TabIndex = 19;
            this.btnTraziKorisnik.Text = "Traži";
            this.btnTraziKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraziKorisnik.UseVisualStyleBackColor = false;
            this.btnTraziKorisnik.Click += new System.EventHandler(this.btnTraziKorisnik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(247, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 24);
            this.txtPrezime.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(247, 19);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 24);
            this.txtIme.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prezime:";
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIspis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIspis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIspis.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIspis.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnIspis.Image = ((System.Drawing.Image)(resources.GetObject("btnIspis.Image")));
            this.btnIspis.Location = new System.Drawing.Point(648, 354);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(91, 26);
            this.btnIspis.TabIndex = 97;
            this.btnIspis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmPretragaKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.Korisnici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPretragaKorisnik";
            this.Text = "frmPretragaKorisnik";
            this.Load += new System.EventHandler(this.frmPretragaKorisnik_Load);
            this.Korisnici.ResumeLayout(false);
            this.Korisnici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Korisnici;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnTraziKorisnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIspis;
    }
}