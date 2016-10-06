namespace WinFormUI.Forms {
    partial class frmOcjeneProizvod {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcjeneProizvod));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblProsjecnaOcj = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.cbxOcjenaDO = new System.Windows.Forms.ComboBox();
            this.cbxOcjenaOD = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.dgvOcjene = new System.Windows.Forms.DataGridView();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodDojam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblProsjecnaOcj);
            this.groupBox10.Controls.Add(this.label30);
            this.groupBox10.Controls.Add(this.cbxOcjenaDO);
            this.groupBox10.Controls.Add(this.cbxOcjenaOD);
            this.groupBox10.Controls.Add(this.label24);
            this.groupBox10.Controls.Add(this.label28);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.btnTrazi);
            this.groupBox10.Controls.Add(this.dgvOcjene);
            this.groupBox10.Controls.Add(this.btnOsvjezi);
            this.groupBox10.Controls.Add(this.label25);
            this.groupBox10.Controls.Add(this.txtPrezime);
            this.groupBox10.Controls.Add(this.label26);
            this.groupBox10.Controls.Add(this.txtIme);
            this.groupBox10.Controls.Add(this.label27);
            this.groupBox10.Location = new System.Drawing.Point(54, 40);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(645, 341);
            this.groupBox10.TabIndex = 93;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ocjene";
            // 
            // lblProsjecnaOcj
            // 
            this.lblProsjecnaOcj.AutoSize = true;
            this.lblProsjecnaOcj.BackColor = System.Drawing.Color.CadetBlue;
            this.lblProsjecnaOcj.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProsjecnaOcj.Location = new System.Drawing.Point(189, 96);
            this.lblProsjecnaOcj.Name = "lblProsjecnaOcj";
            this.lblProsjecnaOcj.Size = new System.Drawing.Size(97, 25);
            this.lblProsjecnaOcj.TabIndex = 103;
            this.lblProsjecnaOcj.Text = "vrijednost";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.CadetBlue;
            this.label30.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(30, 96);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(162, 25);
            this.label30.TabIndex = 102;
            this.label30.Text = "Prosječna ocjena:";
            // 
            // cbxOcjenaDO
            // 
            this.cbxOcjenaDO.FormattingEnabled = true;
            this.cbxOcjenaDO.Items.AddRange(new object[] {
            "-Odaberite ocjenu-",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxOcjenaDO.Location = new System.Drawing.Point(158, 62);
            this.cbxOcjenaDO.Name = "cbxOcjenaDO";
            this.cbxOcjenaDO.Size = new System.Drawing.Size(115, 21);
            this.cbxOcjenaDO.TabIndex = 94;
            // 
            // cbxOcjenaOD
            // 
            this.cbxOcjenaOD.FormattingEnabled = true;
            this.cbxOcjenaOD.Items.AddRange(new object[] {
            "-Odaberite ocjenu-",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxOcjenaOD.Location = new System.Drawing.Point(158, 34);
            this.cbxOcjenaOD.Name = "cbxOcjenaOD";
            this.cbxOcjenaOD.Size = new System.Drawing.Size(115, 21);
            this.cbxOcjenaOD.TabIndex = 93;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(196, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(41, 13);
            this.label24.TabIndex = 92;
            this.label24.Text = "Ocjena";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(128, 65);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 13);
            this.label28.TabIndex = 90;
            this.label28.Text = "Do:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(128, 36);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(24, 13);
            this.label29.TabIndex = 89;
            this.label29.Text = "Od:";
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
            this.btnTrazi.Location = new System.Drawing.Point(465, 33);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(65, 22);
            this.btnTrazi.TabIndex = 87;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // dgvOcjene
            // 
            this.dgvOcjene.AllowUserToAddRows = false;
            this.dgvOcjene.AllowUserToDeleteRows = false;
            this.dgvOcjene.AllowUserToOrderColumns = true;
            this.dgvOcjene.AllowUserToResizeColumns = false;
            this.dgvOcjene.AllowUserToResizeRows = false;
            this.dgvOcjene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOcjene.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOcjene.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOcjene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Sadrzaj,
            this.ProizvodDojam,
            this.Ocjena});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOcjene.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOcjene.Location = new System.Drawing.Point(34, 124);
            this.dgvOcjene.Name = "dgvOcjene";
            this.dgvOcjene.ReadOnly = true;
            this.dgvOcjene.RowHeadersVisible = false;
            this.dgvOcjene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOcjene.Size = new System.Drawing.Size(584, 192);
            this.dgvOcjene.TabIndex = 21;
            this.dgvOcjene.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcjene_CellDoubleClick);
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
            this.btnOsvjezi.Location = new System.Drawing.Point(465, 59);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 22);
            this.btnOsvjezi.TabIndex = 86;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(342, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 13);
            this.label25.TabIndex = 84;
            this.label25.Text = "Ocijenio proizvod";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(336, 60);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(104, 20);
            this.txtPrezime.TabIndex = 83;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(280, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 13);
            this.label26.TabIndex = 82;
            this.label26.Text = "Prezime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(336, 34);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(104, 20);
            this.txtIme.TabIndex = 80;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(301, 37);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 13);
            this.label27.TabIndex = 81;
            this.label27.Text = "Ime:";
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
            this.btnZatvori.Location = new System.Drawing.Point(310, 387);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(120, 23);
            this.btnZatvori.TabIndex = 94;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ocijenio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ocijenio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.DataPropertyName = "Komentar";
            this.Sadrzaj.HeaderText = "Napomena";
            this.Sadrzaj.Name = "Sadrzaj";
            this.Sadrzaj.ReadOnly = true;
            // 
            // ProizvodDojam
            // 
            this.ProizvodDojam.DataPropertyName = "Proizvod";
            this.ProizvodDojam.HeaderText = "Proizvod";
            this.ProizvodDojam.Name = "ProizvodDojam";
            this.ProizvodDojam.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ocjena.Width = 114;
            // 
            // frmOcjeneProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(752, 420);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.groupBox10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOcjeneProizvod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocjene";
            this.Load += new System.EventHandler(this.frmOcjeneProizvod_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblProsjecnaOcj;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbxOcjenaDO;
        private System.Windows.Forms.ComboBox cbxOcjenaOD;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.DataGridView dgvOcjene;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodDojam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}