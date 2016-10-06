namespace WinFormUI.Forms {
    partial class frmProfil {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfil));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnPromjenaLozinke = new System.Windows.Forms.Button();
            this.btnDeaktivirajSe = new System.Windows.Forms.Button();
            this.btnSnimiKorisnik = new System.Windows.Forms.Button();
            this.btnPretraziSliku = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbxOpstina = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.btnPromjenaLozinke);
            this.groupBox1.Controls.Add(this.btnDeaktivirajSe);
            this.groupBox1.Controls.Add(this.btnSnimiKorisnik);
            this.groupBox1.Controls.Add(this.btnPretraziSliku);
            this.groupBox1.Controls.Add(this.txtSlikaInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.cbxOpstina);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOsvjezi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moj profil";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(652, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 45;
            this.pictureBox.TabStop = false;
            // 
            // btnPromjenaLozinke
            // 
            this.btnPromjenaLozinke.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPromjenaLozinke.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPromjenaLozinke.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPromjenaLozinke.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPromjenaLozinke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromjenaLozinke.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromjenaLozinke.Image = ((System.Drawing.Image)(resources.GetObject("btnPromjenaLozinke.Image")));
            this.btnPromjenaLozinke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromjenaLozinke.Location = new System.Drawing.Point(652, 194);
            this.btnPromjenaLozinke.Name = "btnPromjenaLozinke";
            this.btnPromjenaLozinke.Size = new System.Drawing.Size(120, 23);
            this.btnPromjenaLozinke.TabIndex = 44;
            this.btnPromjenaLozinke.Text = "Promijeni lozinku";
            this.btnPromjenaLozinke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPromjenaLozinke.UseVisualStyleBackColor = false;
            this.btnPromjenaLozinke.Click += new System.EventHandler(this.btnPromjenaLozinke_Click);
            // 
            // btnDeaktivirajSe
            // 
            this.btnDeaktivirajSe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeaktivirajSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeaktivirajSe.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeaktivirajSe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeaktivirajSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeaktivirajSe.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeaktivirajSe.Image = ((System.Drawing.Image)(resources.GetObject("btnDeaktivirajSe.Image")));
            this.btnDeaktivirajSe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeaktivirajSe.Location = new System.Drawing.Point(652, 165);
            this.btnDeaktivirajSe.Name = "btnDeaktivirajSe";
            this.btnDeaktivirajSe.Size = new System.Drawing.Size(120, 23);
            this.btnDeaktivirajSe.TabIndex = 43;
            this.btnDeaktivirajSe.Text = "Deaktiviraj se";
            this.btnDeaktivirajSe.UseVisualStyleBackColor = false;
            this.btnDeaktivirajSe.Click += new System.EventHandler(this.btnDeaktivirajSe_Click);
            // 
            // btnSnimiKorisnik
            // 
            this.btnSnimiKorisnik.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnimiKorisnik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimiKorisnik.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSnimiKorisnik.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnimiKorisnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimiKorisnik.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiKorisnik.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSnimiKorisnik.Image = ((System.Drawing.Image)(resources.GetObject("btnSnimiKorisnik.Image")));
            this.btnSnimiKorisnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnimiKorisnik.Location = new System.Drawing.Point(402, 171);
            this.btnSnimiKorisnik.Name = "btnSnimiKorisnik";
            this.btnSnimiKorisnik.Size = new System.Drawing.Size(65, 23);
            this.btnSnimiKorisnik.TabIndex = 42;
            this.btnSnimiKorisnik.Text = "Snimi";
            this.btnSnimiKorisnik.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSnimiKorisnik.UseVisualStyleBackColor = false;
            this.btnSnimiKorisnik.Click += new System.EventHandler(this.btnSnimiKorisnik_Click);
            // 
            // btnPretraziSliku
            // 
            this.btnPretraziSliku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPretraziSliku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPretraziSliku.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPretraziSliku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPretraziSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretraziSliku.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziSliku.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPretraziSliku.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPretraziSliku.Location = new System.Drawing.Point(532, 71);
            this.btnPretraziSliku.Name = "btnPretraziSliku";
            this.btnPretraziSliku.Size = new System.Drawing.Size(60, 24);
            this.btnPretraziSliku.TabIndex = 40;
            this.btnPretraziSliku.Text = "Pretraži";
            this.btnPretraziSliku.UseVisualStyleBackColor = false;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Enabled = false;
            this.txtSlikaInput.Location = new System.Drawing.Point(405, 72);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(121, 22);
            this.txtSlikaInput.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Slika:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(139, 105);
            this.txtTelefon.Mask = "(999) 00/000-000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 22);
            this.txtTelefon.TabIndex = 33;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(405, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(121, 22);
            this.txtUsername.TabIndex = 31;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // cbxOpstina
            // 
            this.cbxOpstina.FormattingEnabled = true;
            this.cbxOpstina.Location = new System.Drawing.Point(139, 172);
            this.cbxOpstina.Name = "cbxOpstina";
            this.cbxOpstina.Size = new System.Drawing.Size(121, 21);
            this.cbxOpstina.TabIndex = 30;
            this.cbxOpstina.Validating += new System.ComponentModel.CancelEventHandler(this.cbxOpstina_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(139, 71);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(121, 22);
            this.txtPrezime.TabIndex = 27;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(139, 39);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 22);
            this.txtIme.TabIndex = 26;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Opština:";
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
            this.btnOsvjezi.Location = new System.Drawing.Point(471, 171);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 23;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Korisničko ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "e-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProfil";
            this.Text = "frmProfil";
            this.Load += new System.EventHandler(this.frmProfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPretraziSliku;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbxOpstina;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSnimiKorisnik;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnDeaktivirajSe;
        private System.Windows.Forms.Button btnPromjenaLozinke;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}