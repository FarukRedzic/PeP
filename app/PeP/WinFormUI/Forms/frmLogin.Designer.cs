namespace WinFormUI.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkLozinka = new System.Windows.Forms.LinkLabel();
            this.lblFocus = new System.Windows.Forms.Label();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(179, 56);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(146, 20);
            this.txtLozinka.TabIndex = 36;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(179, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(146, 20);
            this.txtUsername.TabIndex = 35;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Korisničko ime:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Lozinka:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkLozinka);
            this.groupBox1.Controls.Add(this.lblFocus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnPrijava);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnOdustani);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtLozinka);
            this.groupBox1.Location = new System.Drawing.Point(45, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 137);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prijava";
            // 
            // lnkLozinka
            // 
            this.lnkLozinka.ActiveLinkColor = System.Drawing.Color.Navy;
            this.lnkLozinka.AutoSize = true;
            this.lnkLozinka.LinkColor = System.Drawing.Color.Navy;
            this.lnkLozinka.Location = new System.Drawing.Point(35, 98);
            this.lnkLozinka.Name = "lnkLozinka";
            this.lnkLozinka.Size = new System.Drawing.Size(126, 13);
            this.lnkLozinka.TabIndex = 41;
            this.lnkLozinka.TabStop = true;
            this.lnkLozinka.Text = "Zaboravio/la sam lozinku";
            this.lnkLozinka.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLozinka_LinkClicked);
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(331, 56);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 40;
            this.lblFocus.Visible = false;
            this.lblFocus.Click += new System.EventHandler(this.lblFocus_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Image = ((System.Drawing.Image)(resources.GetObject("btnPrijava.Image")));
            this.btnPrijava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrijava.Location = new System.Drawing.Point(250, 93);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 38;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOdustani.Image = ((System.Drawing.Image)(resources.GetObject("btnOdustani.Image")));
            this.btnOdustani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdustani.Location = new System.Drawing.Point(170, 93);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 37;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(485, 183);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava na sistem";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.LinkLabel lnkLozinka;
    }
}