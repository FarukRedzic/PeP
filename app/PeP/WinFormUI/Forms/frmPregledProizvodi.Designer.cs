namespace WinFormUI.Forms {
    partial class frmPregledProizvodi {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPregledProizvodi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Administratori = new System.Windows.Forms.GroupBox();
            this.btnIspis = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivProizvod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AktivanProizvod = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Obrisan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vlasnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbxKategorije = new System.Windows.Forms.ComboBox();
            this.trol = new System.Windows.Forms.Label();
            this.cbxObrisan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.cbxAktivan = new System.Windows.Forms.ComboBox();
            this.btnTraziProizvod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.Administratori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // Administratori
            // 
            this.Administratori.BackColor = System.Drawing.Color.CadetBlue;
            this.Administratori.Controls.Add(this.btnIspis);
            this.Administratori.Controls.Add(this.dgvProizvodi);
            this.Administratori.Controls.Add(this.cbxKategorije);
            this.Administratori.Controls.Add(this.trol);
            this.Administratori.Controls.Add(this.cbxObrisan);
            this.Administratori.Controls.Add(this.label4);
            this.Administratori.Controls.Add(this.btnOsvjezi);
            this.Administratori.Controls.Add(this.cbxAktivan);
            this.Administratori.Controls.Add(this.btnTraziProizvod);
            this.Administratori.Controls.Add(this.label1);
            this.Administratori.Controls.Add(this.label2);
            this.Administratori.Controls.Add(this.txtNaziv);
            this.Administratori.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administratori.Location = new System.Drawing.Point(36, 23);
            this.Administratori.Name = "Administratori";
            this.Administratori.Size = new System.Drawing.Size(888, 401);
            this.Administratori.TabIndex = 23;
            this.Administratori.TabStop = false;
            this.Administratori.Text = "Pretraga proizvoda";
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
            this.btnIspis.Location = new System.Drawing.Point(769, 364);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(91, 22);
            this.btnIspis.TabIndex = 46;
            this.btnIspis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.AllowUserToOrderColumns = true;
            this.dgvProizvodi.AllowUserToResizeColumns = false;
            this.dgvProizvodi.AllowUserToResizeRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvodi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NazivProizvod,
            this.Cijena,
            this.AktivanProizvod,
            this.Obrisan,
            this.Vlasnik,
            this.Kategorija,
            this.Slika});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProizvodi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProizvodi.Location = new System.Drawing.Point(41, 87);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.RowHeadersVisible = false;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(819, 272);
            this.dgvProizvodi.TabIndex = 45;
            this.dgvProizvodi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvodi_CellContentClick);
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
            // NazivProizvod
            // 
            this.NazivProizvod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NazivProizvod.DataPropertyName = "Naziv";
            this.NazivProizvod.HeaderText = "Naziv";
            this.NazivProizvod.Name = "NazivProizvod";
            this.NazivProizvod.ReadOnly = true;
            this.NazivProizvod.Width = 142;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // AktivanProizvod
            // 
            this.AktivanProizvod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AktivanProizvod.DataPropertyName = "Aktivan";
            this.AktivanProizvod.HeaderText = "Aktivan";
            this.AktivanProizvod.Name = "AktivanProizvod";
            this.AktivanProizvod.ReadOnly = true;
            this.AktivanProizvod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AktivanProizvod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AktivanProizvod.Width = 90;
            // 
            // Obrisan
            // 
            this.Obrisan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Obrisan.DataPropertyName = "Obrisan";
            this.Obrisan.HeaderText = "Obrisan";
            this.Obrisan.Name = "Obrisan";
            this.Obrisan.ReadOnly = true;
            this.Obrisan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Obrisan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Obrisan.Width = 90;
            // 
            // Vlasnik
            // 
            this.Vlasnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Vlasnik.DataPropertyName = "Vlasnik";
            this.Vlasnik.HeaderText = "Vlasnik";
            this.Vlasnik.Name = "Vlasnik";
            this.Vlasnik.ReadOnly = true;
            this.Vlasnik.Width = 163;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Slika.Width = 114;
            // 
            // cbxKategorije
            // 
            this.cbxKategorije.FormattingEnabled = true;
            this.cbxKategorije.Location = new System.Drawing.Point(450, 48);
            this.cbxKategorije.Name = "cbxKategorije";
            this.cbxKategorije.Size = new System.Drawing.Size(142, 21);
            this.cbxKategorije.TabIndex = 43;
            // 
            // trol
            // 
            this.trol.AutoSize = true;
            this.trol.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trol.Location = new System.Drawing.Point(385, 51);
            this.trol.Name = "trol";
            this.trol.Size = new System.Drawing.Size(61, 13);
            this.trol.TabIndex = 44;
            this.trol.Text = "Kategorija:";
            // 
            // cbxObrisan
            // 
            this.cbxObrisan.FormattingEnabled = true;
            this.cbxObrisan.Location = new System.Drawing.Point(243, 48);
            this.cbxObrisan.Name = "cbxObrisan";
            this.cbxObrisan.Size = new System.Drawing.Size(128, 21);
            this.cbxObrisan.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Obrisan:";
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
            this.btnOsvjezi.Location = new System.Drawing.Point(668, 33);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 21;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // cbxAktivan
            // 
            this.cbxAktivan.FormattingEnabled = true;
            this.cbxAktivan.Location = new System.Drawing.Point(243, 21);
            this.cbxAktivan.Name = "cbxAktivan";
            this.cbxAktivan.Size = new System.Drawing.Size(128, 21);
            this.cbxAktivan.TabIndex = 13;
            // 
            // btnTraziProizvod
            // 
            this.btnTraziProizvod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraziProizvod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraziProizvod.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTraziProizvod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTraziProizvod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraziProizvod.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraziProizvod.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnTraziProizvod.Image = ((System.Drawing.Image)(resources.GetObject("btnTraziProizvod.Image")));
            this.btnTraziProizvod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraziProizvod.Location = new System.Drawing.Point(599, 33);
            this.btnTraziProizvod.Name = "btnTraziProizvod";
            this.btnTraziProizvod.Size = new System.Drawing.Size(65, 23);
            this.btnTraziProizvod.TabIndex = 19;
            this.btnTraziProizvod.Text = "Traži";
            this.btnTraziProizvod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraziProizvod.UseVisualStyleBackColor = false;
            this.btnTraziProizvod.Click += new System.EventHandler(this.btnTraziProizvod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Aktivan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(450, 21);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(142, 22);
            this.txtNaziv.TabIndex = 17;
            // 
            // frmPregledProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.Administratori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPregledProizvodi";
            this.Text = "frmPregledProizvodi";
            this.Load += new System.EventHandler(this.frmPregledProizvodi_Load);
            this.Administratori.ResumeLayout(false);
            this.Administratori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Administratori;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.ComboBox cbxAktivan;
        private System.Windows.Forms.Button btnTraziProizvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cbxObrisan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxKategorije;
        private System.Windows.Forms.Label trol;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AktivanProizvod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Obrisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlasnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.Button btnIspis;
    }
}