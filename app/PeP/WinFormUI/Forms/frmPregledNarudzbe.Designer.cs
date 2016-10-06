namespace WinFormUI.Forms {
    partial class frmPregledNarudzbe {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledNarudzbe));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxKategorijaProizvodaNarudzbe = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.btnTraziNarudzbe = new System.Windows.Forms.Button();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zakljucena = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UToku = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Otkazana = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DatumVrijeme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOsvjeziNarudzbe = new System.Windows.Forms.Button();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnIspis = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnIspis);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.cbxKategorijaProizvodaNarudzbe);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.dtpDO);
            this.groupBox8.Controls.Add(this.dtpOD);
            this.groupBox8.Controls.Add(this.btnTraziNarudzbe);
            this.groupBox8.Controls.Add(this.dgvNarudzbe);
            this.groupBox8.Controls.Add(this.btnOsvjeziNarudzbe);
            this.groupBox8.Controls.Add(this.txtBrojNarudzbe);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Location = new System.Drawing.Point(27, 30);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(904, 383);
            this.groupBox8.TabIndex = 90;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Narudzbe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(208, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 94;
            this.label15.Text = "Kategorija:";
            // 
            // cbxKategorijaProizvodaNarudzbe
            // 
            this.cbxKategorijaProizvodaNarudzbe.FormattingEnabled = true;
            this.cbxKategorijaProizvodaNarudzbe.Location = new System.Drawing.Point(269, 75);
            this.cbxKategorijaProizvodaNarudzbe.Name = "cbxKategorijaProizvodaNarudzbe";
            this.cbxKategorijaProizvodaNarudzbe.Size = new System.Drawing.Size(129, 21);
            this.cbxKategorijaProizvodaNarudzbe.TabIndex = 93;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 92;
            this.label14.Text = "Datum narudzbe";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(406, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 13);
            this.label16.TabIndex = 91;
            this.label16.Text = "Do:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(407, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "Od:";
            // 
            // dtpDO
            // 
            this.dtpDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDO.Location = new System.Drawing.Point(432, 75);
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
            this.dtpOD.Location = new System.Drawing.Point(432, 44);
            this.dtpOD.MaxDate = new System.DateTime(2017, 12, 31, 0, 0, 0, 0);
            this.dtpOD.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(106, 20);
            this.dtpOD.TabIndex = 88;
            this.dtpOD.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // btnTraziNarudzbe
            // 
            this.btnTraziNarudzbe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraziNarudzbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraziNarudzbe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraziNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraziNarudzbe.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraziNarudzbe.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTraziNarudzbe.Image = ((System.Drawing.Image)(resources.GetObject("btnTraziNarudzbe.Image")));
            this.btnTraziNarudzbe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziNarudzbe.Location = new System.Drawing.Point(562, 59);
            this.btnTraziNarudzbe.Name = "btnTraziNarudzbe";
            this.btnTraziNarudzbe.Size = new System.Drawing.Size(65, 23);
            this.btnTraziNarudzbe.TabIndex = 87;
            this.btnTraziNarudzbe.Text = "Traži";
            this.btnTraziNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraziNarudzbe.UseVisualStyleBackColor = false;
            this.btnTraziNarudzbe.Click += new System.EventHandler(this.btnTraziNarudzbe_Click);
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.AllowUserToOrderColumns = true;
            this.dgvNarudzbe.AllowUserToResizeColumns = false;
            this.dgvNarudzbe.AllowUserToResizeRows = false;
            this.dgvNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNarudzbe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.BrojNarudzbe,
            this.Proizvod,
            this.Zakljucena,
            this.UToku,
            this.Otkazana,
            this.DatumVrijeme});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNarudzbe.Location = new System.Drawing.Point(90, 107);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersVisible = false;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(721, 228);
            this.dgvNarudzbe.TabIndex = 21;
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "NarudzbaId";
            this.NarudzbaId.HeaderText = "NarudzbaId";
            this.NarudzbaId.Name = "NarudzbaId";
            this.NarudzbaId.ReadOnly = true;
            this.NarudzbaId.Visible = false;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Broj narudzbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.ReadOnly = true;
            this.BrojNarudzbe.Width = 160;
            // 
            // Proizvod
            // 
            this.Proizvod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Proizvod.DataPropertyName = "Proizvod";
            this.Proizvod.HeaderText = "Proizvod";
            this.Proizvod.Name = "Proizvod";
            this.Proizvod.ReadOnly = true;
            this.Proizvod.Width = 185;
            // 
            // Zakljucena
            // 
            this.Zakljucena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Zakljucena.DataPropertyName = "Zakljucena";
            this.Zakljucena.HeaderText = "Zakljucena";
            this.Zakljucena.Name = "Zakljucena";
            this.Zakljucena.ReadOnly = true;
            this.Zakljucena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zakljucena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Zakljucena.Width = 70;
            // 
            // UToku
            // 
            this.UToku.DataPropertyName = "UToku";
            this.UToku.HeaderText = "U toku";
            this.UToku.Name = "UToku";
            this.UToku.ReadOnly = true;
            this.UToku.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UToku.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Otkazana
            // 
            this.Otkazana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Otkazana.DataPropertyName = "Otkazana";
            this.Otkazana.HeaderText = "Otkazana";
            this.Otkazana.Name = "Otkazana";
            this.Otkazana.ReadOnly = true;
            this.Otkazana.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Otkazana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Otkazana.Width = 65;
            // 
            // DatumVrijeme
            // 
            this.DatumVrijeme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DatumVrijeme.DataPropertyName = "DatumVrijeme";
            this.DatumVrijeme.HeaderText = "Datum i vrijeme";
            this.DatumVrijeme.Name = "DatumVrijeme";
            this.DatumVrijeme.ReadOnly = true;
            this.DatumVrijeme.Width = 175;
            // 
            // btnOsvjeziNarudzbe
            // 
            this.btnOsvjeziNarudzbe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOsvjeziNarudzbe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOsvjeziNarudzbe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOsvjeziNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOsvjeziNarudzbe.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjeziNarudzbe.Image = ((System.Drawing.Image)(resources.GetObject("btnOsvjeziNarudzbe.Image")));
            this.btnOsvjeziNarudzbe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOsvjeziNarudzbe.Location = new System.Drawing.Point(634, 59);
            this.btnOsvjeziNarudzbe.Name = "btnOsvjeziNarudzbe";
            this.btnOsvjeziNarudzbe.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjeziNarudzbe.TabIndex = 86;
            this.btnOsvjeziNarudzbe.Text = "Osvježi";
            this.btnOsvjeziNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjeziNarudzbe.UseVisualStyleBackColor = false;
            this.btnOsvjeziNarudzbe.Click += new System.EventHandler(this.btnOsvjeziNarudzbe_Click);
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(269, 43);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(129, 20);
            this.txtBrojNarudzbe.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(190, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Broj narudzbe:";
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
            this.btnIspis.Location = new System.Drawing.Point(720, 341);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(91, 22);
            this.btnIspis.TabIndex = 95;
            this.btnIspis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // frmPregledNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.groupBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledNarudzbe";
            this.Text = "frmPregledNarudzbe";
            this.Load += new System.EventHandler(this.frmPregledNarudzbe_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxKategorijaProizvodaNarudzbe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Button btnTraziNarudzbe;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zakljucena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UToku;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Otkazana;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijeme;
        private System.Windows.Forms.Button btnOsvjeziNarudzbe;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnIspis;
    }
}