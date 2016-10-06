namespace WinFormUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.btnAdministratori = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnPretragaAdmin = new DevExpress.XtraNavBar.NavBarItem();
            this.btnDodajAdmina = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainPregledKorisnici = new DevExpress.XtraNavBar.NavBarItem();
            this.mainDodajKorisnika = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainPregledProizvodi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainNarudzbe = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainLogovi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.mainProfil = new DevExpress.XtraNavBar.NavBarItem();
            this.mainOdjava = new DevExpress.XtraNavBar.NavBarItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtImePrezime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.btnAdministratori;
            this.navBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Gold;
            this.navBarControl1.Appearance.Background.Options.UseBackColor = true;
            this.navBarControl1.Appearance.ButtonPressed.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Appearance.ButtonPressed.Options.UseFont = true;
            this.navBarControl1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.navBarControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.navBarControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.btnAdministratori,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup1,
            this.navBarGroup4,
            this.navBarGroup6});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnPretragaAdmin,
            this.btnDodajAdmina,
            this.mainPregledKorisnici,
            this.mainDodajKorisnika,
            this.mainPregledProizvodi,
            this.mainNarudzbe,
            this.mainLogovi,
            this.mainProfil,
            this.mainOdjava});
            this.navBarControl1.Location = new System.Drawing.Point(0, 73);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.Size = new System.Drawing.Size(172, 450);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Visual Studio 2013 Dark");
            // 
            // btnAdministratori
            // 
            this.btnAdministratori.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdministratori.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnAdministratori.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAdministratori.Appearance.Options.UseBackColor = true;
            this.btnAdministratori.Appearance.Options.UseForeColor = true;
            this.btnAdministratori.Caption = "Administratori";
            this.btnAdministratori.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.btnAdministratori.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnPretragaAdmin),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDodajAdmina)});
            this.btnAdministratori.Name = "btnAdministratori";
            this.btnAdministratori.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdministratori.SmallImage")));
            // 
            // btnPretragaAdmin
            // 
            this.btnPretragaAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaAdmin.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btnPretragaAdmin.Appearance.Image")));
            this.btnPretragaAdmin.Appearance.Options.UseFont = true;
            this.btnPretragaAdmin.Appearance.Options.UseImage = true;
            this.btnPretragaAdmin.Appearance.Options.UseTextOptions = true;
            this.btnPretragaAdmin.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Show;
            this.btnPretragaAdmin.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPretragaAdmin.AppearancePressed.Options.UseBackColor = true;
            this.btnPretragaAdmin.Caption = "Pregled";
            this.btnPretragaAdmin.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPretragaAdmin.LargeImage")));
            this.btnPretragaAdmin.Name = "btnPretragaAdmin";
            this.btnPretragaAdmin.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPretragaAdmin.SmallImage")));
            this.btnPretragaAdmin.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // btnDodajAdmina
            // 
            this.btnDodajAdmina.Caption = "Dodaj administratora";
            this.btnDodajAdmina.Name = "btnDodajAdmina";
            this.btnDodajAdmina.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDodajAdmina.SmallImage")));
            this.btnDodajAdmina.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDodajAdmina_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.navBarGroup2.Appearance.Options.UseForeColor = true;
            this.navBarGroup2.Caption = "Korisnici";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainPregledKorisnici),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainDodajKorisnika)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.SmallImage")));
            // 
            // mainPregledKorisnici
            // 
            this.mainPregledKorisnici.Caption = "Pregled";
            this.mainPregledKorisnici.LargeImage = ((System.Drawing.Image)(resources.GetObject("mainPregledKorisnici.LargeImage")));
            this.mainPregledKorisnici.Name = "mainPregledKorisnici";
            this.mainPregledKorisnici.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainPregledKorisnici.SmallImage")));
            this.mainPregledKorisnici.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainPregledKorisnici_LinkClicked);
            // 
            // mainDodajKorisnika
            // 
            this.mainDodajKorisnika.Caption = "Dodaj korisnika";
            this.mainDodajKorisnika.Name = "mainDodajKorisnika";
            this.mainDodajKorisnika.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainDodajKorisnika.SmallImage")));
            this.mainDodajKorisnika.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainDodajKorisnika_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.navBarGroup3.Appearance.Options.UseForeColor = true;
            this.navBarGroup3.Caption = "Proizvodi";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainPregledProizvodi)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.SmallImage")));
            // 
            // mainPregledProizvodi
            // 
            this.mainPregledProizvodi.Caption = "Pregled";
            this.mainPregledProizvodi.Name = "mainPregledProizvodi";
            this.mainPregledProizvodi.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainPregledProizvodi.SmallImage")));
            this.mainPregledProizvodi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainPregledProizvodi_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.navBarGroup1.Appearance.Options.UseForeColor = true;
            this.navBarGroup1.Caption = "Narudžbe";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainNarudzbe)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // mainNarudzbe
            // 
            this.mainNarudzbe.Caption = "Pregled";
            this.mainNarudzbe.Name = "mainNarudzbe";
            this.mainNarudzbe.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainNarudzbe.SmallImage")));
            this.mainNarudzbe.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainNarudzbe_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.navBarGroup4.Appearance.Options.UseForeColor = true;
            this.navBarGroup4.Caption = "Logovi";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainLogovi)});
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.SmallImage")));
            // 
            // mainLogovi
            // 
            this.mainLogovi.Caption = "Pregled";
            this.mainLogovi.Name = "mainLogovi";
            this.mainLogovi.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainLogovi.SmallImage")));
            this.mainLogovi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainLogovi_LinkClicked);
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Appearance.ForeColor = System.Drawing.Color.CadetBlue;
            this.navBarGroup6.Appearance.Options.UseForeColor = true;
            this.navBarGroup6.Caption = "Moj profil";
            this.navBarGroup6.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainProfil),
            new DevExpress.XtraNavBar.NavBarItemLink(this.mainOdjava)});
            this.navBarGroup6.Name = "navBarGroup6";
            this.navBarGroup6.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup6.SmallImage")));
            // 
            // mainProfil
            // 
            this.mainProfil.Caption = "Pregled profila";
            this.mainProfil.Name = "mainProfil";
            this.mainProfil.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainProfil.SmallImage")));
            this.mainProfil.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainProfil_LinkClicked);
            // 
            // mainOdjava
            // 
            this.mainOdjava.Caption = "Odjava";
            this.mainOdjava.Name = "mainOdjava";
            this.mainOdjava.SmallImage = ((System.Drawing.Image)(resources.GetObject("mainOdjava.SmallImage")));
            this.mainOdjava.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.mainOdjava_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 76);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.txtImePrezime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnOdjava);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(171, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 77);
            this.panel2.TabIndex = 3;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.AutoSize = true;
            this.txtImePrezime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImePrezime.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtImePrezime.Location = new System.Drawing.Point(775, 30);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(54, 21);
            this.txtImePrezime.TabIndex = 14;
            this.txtImePrezime.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(686, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dobrodošli, ";
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(882, 28);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(70, 28);
            this.btnOdjava.TabIndex = 13;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administracija sistema";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Location = new System.Drawing.Point(171, 519);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 5);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel4.Location = new System.Drawing.Point(1131, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 446);
            this.panel4.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 523);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni meni :: Administracija";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup btnAdministratori;
        private DevExpress.XtraNavBar.NavBarItem btnPretragaAdmin;
        private DevExpress.XtraNavBar.NavBarItem btnDodajAdmina;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem mainPregledKorisnici;
        private DevExpress.XtraNavBar.NavBarItem mainDodajKorisnika;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem mainPregledProizvodi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Label txtImePrezime;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        private DevExpress.XtraNavBar.NavBarItem mainNarudzbe;
        private DevExpress.XtraNavBar.NavBarItem mainLogovi;
        private DevExpress.XtraNavBar.NavBarItem mainProfil;
        private DevExpress.XtraNavBar.NavBarItem mainOdjava;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

