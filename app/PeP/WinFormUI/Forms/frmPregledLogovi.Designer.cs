namespace WinFormUI.Forms {
    partial class frmPregledLogovi {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledLogovi));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxUspjesnost = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvLogovi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uspjesnost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogovi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnIspis);
            this.groupBox8.Controls.Add(this.txtPrezime);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.cbxUspjesnost);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.dtpDO);
            this.groupBox8.Controls.Add(this.dtpOD);
            this.groupBox8.Controls.Add(this.btnTrazi);
            this.groupBox8.Controls.Add(this.dgvLogovi);
            this.groupBox8.Controls.Add(this.btnOsvjezi);
            this.groupBox8.Controls.Add(this.txtIme);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(113, 47);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(734, 359);
            this.groupBox8.TabIndex = 94;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Logovi";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(191, 68);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Prezime:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 94;
            this.label15.Text = "Uspješnost";
            // 
            // cbxUspjesnost
            // 
            this.cbxUspjesnost.FormattingEnabled = true;
            this.cbxUspjesnost.Location = new System.Drawing.Point(432, 53);
            this.cbxUspjesnost.Name = "cbxUspjesnost";
            this.cbxUspjesnost.Size = new System.Drawing.Size(129, 21);
            this.cbxUspjesnost.TabIndex = 93;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(351, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Datum";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(294, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 91;
            this.label16.Text = "Do:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(295, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "Od:";
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(320, 69);
            this.dtpDO.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpDO.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(106, 20);
            this.dtpDO.TabIndex = 89;
            this.dtpDO.Value = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            // 
            // dtpOD
            // 
            this.dtpOD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOD.Location = new System.Drawing.Point(320, 38);
            this.dtpOD.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 88;
            this.dtpOD.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
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
            this.btnTrazi.Location = new System.Drawing.Point(567, 36);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 23);
            this.btnTrazi.TabIndex = 87;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // dgvLogovi
            // 
            this.dgvLogovi.AllowUserToAddRows = false;
            this.dgvLogovi.AllowUserToDeleteRows = false;
            this.dgvLogovi.AllowUserToOrderColumns = true;
            this.dgvLogovi.AllowUserToResizeColumns = false;
            this.dgvLogovi.AllowUserToResizeRows = false;
            this.dgvLogovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogovi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogovi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DatumVrijeme,
            this.Uspjesnost,
            this.Korisnik});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLogovi.Location = new System.Drawing.Point(133, 94);
            this.dgvLogovi.Name = "dgvLogovi";
            this.dgvLogovi.ReadOnly = true;
            this.dgvLogovi.RowHeadersVisible = false;
            this.dgvLogovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogovi.Size = new System.Drawing.Size(504, 228);
            this.dgvLogovi.TabIndex = 21;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            this.DatumVrijeme.Width = 200;
            // 
            // Uspjesnost
            // 
            this.Uspjesnost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Uspjesnost.DataPropertyName = "Uspjesnost";
            this.Uspjesnost.HeaderText = "Uspješnost";
            this.Uspjesnost.Name = "Uspjesnost";
            this.Uspjesnost.ReadOnly = true;
            this.Uspjesnost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uspjesnost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uspjesnost.Width = 80;
            // 
            // Korisnik
            // 
            this.Korisnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            this.Korisnik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Korisnik.Width = 204;
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
            this.btnOsvjezi.Location = new System.Drawing.Point(567, 66);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 86;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(191, 37);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(156, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Ime:";
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
            this.btnIspis.Location = new System.Drawing.Point(546, 327);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(91, 22);
            this.btnIspis.TabIndex = 97;
            this.btnIspis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmPregledLogovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledLogovi";
            this.Text = "frmPregledLogovi";
            this.Load += new System.EventHandler(this.frmPregledLogovi_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxUspjesnost;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvLogovi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uspjesnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.Button btnIspis;
    }
}