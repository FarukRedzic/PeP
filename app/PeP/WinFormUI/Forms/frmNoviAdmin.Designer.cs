namespace WinFormUI.Forms
{
    partial class frmNoviAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNoviAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkIsTrgovina = new System.Windows.Forms.CheckBox();
            this.btnPretraziSliku = new System.Windows.Forms.Button();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkKorisnickiNalog = new System.Windows.Forms.CheckBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbxOpstina = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.btnSnimiAdmin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFocus = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkIsTrgovina);
            this.groupBox1.Controls.Add(this.btnPretraziSliku);
            this.groupBox1.Controls.Add(this.txtSlikaInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkKorisnickiNalog);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.cbxOpstina);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOsvjezi);
            this.groupBox1.Controls.Add(this.btnSnimiAdmin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(813, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novi administrator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Trgovina:";
            // 
            // chkIsTrgovina
            // 
            this.chkIsTrgovina.AutoSize = true;
            this.chkIsTrgovina.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsTrgovina.Location = new System.Drawing.Point(456, 174);
            this.chkIsTrgovina.Name = "chkIsTrgovina";
            this.chkIsTrgovina.Size = new System.Drawing.Size(15, 14);
            this.chkIsTrgovina.TabIndex = 42;
            this.chkIsTrgovina.UseVisualStyleBackColor = true;
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
            this.btnPretraziSliku.Location = new System.Drawing.Point(532, 103);
            this.btnPretraziSliku.Name = "btnPretraziSliku";
            this.btnPretraziSliku.Size = new System.Drawing.Size(60, 24);
            this.btnPretraziSliku.TabIndex = 40;
            this.btnPretraziSliku.Text = "Pretraži";
            this.btnPretraziSliku.UseVisualStyleBackColor = false;
            this.btnPretraziSliku.Click += new System.EventHandler(this.btnPretraziSliku_Click);
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(405, 105);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(121, 22);
            this.txtSlikaInput.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Slika:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Korisnički nalog:";
            // 
            // chkKorisnickiNalog
            // 
            this.chkKorisnickiNalog.AutoSize = true;
            this.chkKorisnickiNalog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKorisnickiNalog.Location = new System.Drawing.Point(456, 141);
            this.chkKorisnickiNalog.Name = "chkKorisnickiNalog";
            this.chkKorisnickiNalog.Size = new System.Drawing.Size(15, 14);
            this.chkKorisnickiNalog.TabIndex = 34;
            this.chkKorisnickiNalog.UseVisualStyleBackColor = true;
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
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(405, 71);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(121, 22);
            this.txtLozinka.TabIndex = 32;
            this.txtLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtLozinka_Validating);
            // 
            // txtUsername
            // 
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
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
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
            this.btnOsvjezi.Location = new System.Drawing.Point(466, 216);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(65, 23);
            this.btnOsvjezi.TabIndex = 23;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOsvjezi.UseVisualStyleBackColor = false;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // btnSnimiAdmin
            // 
            this.btnSnimiAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnimiAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimiAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSnimiAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnimiAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimiAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimiAdmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnSnimiAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnSnimiAdmin.Image")));
            this.btnSnimiAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnimiAdmin.Location = new System.Drawing.Point(395, 216);
            this.btnSnimiAdmin.Name = "btnSnimiAdmin";
            this.btnSnimiAdmin.Size = new System.Drawing.Size(65, 23);
            this.btnSnimiAdmin.TabIndex = 22;
            this.btnSnimiAdmin.Text = "Snimi";
            this.btnSnimiAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSnimiAdmin.UseVisualStyleBackColor = false;
            this.btnSnimiAdmin.Click += new System.EventHandler(this.btnSnimiAdmin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(292, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Korisničko ime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "e-mail:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Lozinka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(921, 407);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(652, 39);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 44;
            this.pictureBox.TabStop = false;
            // 
            // frmNoviAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNoviAdmin";
            this.Text = "frmNoviAdmin";
            this.Load += new System.EventHandler(this.frmNoviAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.Button btnSnimiAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbxOpstina;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkKorisnickiNalog;
        private System.Windows.Forms.Button btnPretraziSliku;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkIsTrgovina;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}