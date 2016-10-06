namespace WinFormUI
{
    partial class frmPretragaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretragaAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.dgvAdmini = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnTraziAdmin = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.Administratori = new System.Windows.Forms.GroupBox();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmini)).BeginInit();
            this.Administratori.SuspendLayout();
            this.SuspendLayout();
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
            // dgvAdmini
            // 
            this.dgvAdmini.AllowUserToAddRows = false;
            this.dgvAdmini.AllowUserToDeleteRows = false;
            this.dgvAdmini.AllowUserToOrderColumns = true;
            this.dgvAdmini.AllowUserToResizeColumns = false;
            this.dgvAdmini.AllowUserToResizeRows = false;
            this.dgvAdmini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmini.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmini.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmini.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdmini.Location = new System.Drawing.Point(50, 76);
            this.dgvAdmini.Name = "dgvAdmini";
            this.dgvAdmini.ReadOnly = true;
            this.dgvAdmini.RowHeadersVisible = false;
            this.dgvAdmini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmini.Size = new System.Drawing.Size(802, 272);
            this.dgvAdmini.TabIndex = 20;
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
            // btnTraziAdmin
            // 
            this.btnTraziAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraziAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraziAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTraziAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraziAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraziAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraziAdmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTraziAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnTraziAdmin.Image")));
            this.btnTraziAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziAdmin.Location = new System.Drawing.Point(559, 28);
            this.btnTraziAdmin.Name = "btnTraziAdmin";
            this.btnTraziAdmin.Size = new System.Drawing.Size(65, 23);
            this.btnTraziAdmin.TabIndex = 19;
            this.btnTraziAdmin.Text = "Traži";
            this.btnTraziAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraziAdmin.UseVisualStyleBackColor = false;
            this.btnTraziAdmin.Click += new System.EventHandler(this.btnTraziAdmin_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(247, 45);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 18;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(247, 19);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Prezime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(408, 30);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 13;
            // 
            // Administratori
            // 
            this.Administratori.BackColor = System.Drawing.Color.CadetBlue;
            this.Administratori.Controls.Add(this.btnIspis);
            this.Administratori.Controls.Add(this.btnDetalji);
            this.Administratori.Controls.Add(this.dgvAdmini);
            this.Administratori.Controls.Add(this.btnOsvjezi);
            this.Administratori.Controls.Add(this.cbxStatus);
            this.Administratori.Controls.Add(this.btnTraziAdmin);
            this.Administratori.Controls.Add(this.label1);
            this.Administratori.Controls.Add(this.txtPrezime);
            this.Administratori.Controls.Add(this.label2);
            this.Administratori.Controls.Add(this.txtIme);
            this.Administratori.Controls.Add(this.label3);
            this.Administratori.Location = new System.Drawing.Point(31, 21);
            this.Administratori.Name = "Administratori";
            this.Administratori.Size = new System.Drawing.Size(888, 399);
            this.Administratori.TabIndex = 22;
            this.Administratori.TabStop = false;
            this.Administratori.Text = "Pretraga administratora";
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetalji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalji.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDetalji.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetalji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalji.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalji.Location = new System.Drawing.Point(742, 354);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(110, 26);
            this.btnDetalji.TabIndex = 40;
            this.btnDetalji.Text = "Detaljan pregled";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
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
            this.btnIspis.Location = new System.Drawing.Point(645, 354);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(91, 26);
            this.btnIspis.TabIndex = 96;
            this.btnIspis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmPretragaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.Administratori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPretragaAdmin";
            this.Text = "frmPretragaAdmin";
            this.Load += new System.EventHandler(this.frmPretragaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmini)).EndInit();
            this.Administratori.ResumeLayout(false);
            this.Administratori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.DataGridView dgvAdmini;
        private System.Windows.Forms.Button btnTraziAdmin;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.GroupBox Administratori;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivan;
        private System.Windows.Forms.Button btnDetaljanPregled;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnIspis;
    }
}