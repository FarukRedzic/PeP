namespace WinFormUI.Forms {
    partial class frmPromjenaLozinke {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromjenaLozinke));
            this.lblFocus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtStaraLozinka = new System.Windows.Forms.TextBox();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaLozinkaPotvrda = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(329, 62);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(0, 13);
            this.lblFocus.TabIndex = 54;
            this.lblFocus.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Stara lozinka:";
            // 
            // btnSnimi
            // 
            this.btnSnimi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSnimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnimi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSnimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimi.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.Image = ((System.Drawing.Image)(resources.GetObject("btnSnimi.Image")));
            this.btnSnimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnimi.Location = new System.Drawing.Point(252, 116);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(75, 23);
            this.btnSnimi.TabIndex = 53;
            this.btnSnimi.Text = "Potvrdi";
            this.btnSnimi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSnimi.UseVisualStyleBackColor = false;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(82, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nova lozinka:";
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
            this.btnOdustani.Location = new System.Drawing.Point(172, 116);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 52;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtStaraLozinka
            // 
            this.txtStaraLozinka.Location = new System.Drawing.Point(177, 36);
            this.txtStaraLozinka.Name = "txtStaraLozinka";
            this.txtStaraLozinka.PasswordChar = '*';
            this.txtStaraLozinka.Size = new System.Drawing.Size(146, 20);
            this.txtStaraLozinka.TabIndex = 50;
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(177, 62);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '*';
            this.txtNovaLozinka.Size = new System.Drawing.Size(146, 20);
            this.txtNovaLozinka.TabIndex = 51;
            this.txtNovaLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.txtNovaLozinka_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Potvrdite lozinku:";
            // 
            // txtNovaLozinkaPotvrda
            // 
            this.txtNovaLozinkaPotvrda.Location = new System.Drawing.Point(177, 88);
            this.txtNovaLozinkaPotvrda.Name = "txtNovaLozinkaPotvrda";
            this.txtNovaLozinkaPotvrda.PasswordChar = '*';
            this.txtNovaLozinkaPotvrda.Size = new System.Drawing.Size(146, 20);
            this.txtNovaLozinkaPotvrda.TabIndex = 56;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(432, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaLozinkaPotvrda);
            this.Controls.Add(this.lblFocus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtStaraLozinka);
            this.Controls.Add(this.txtNovaLozinka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPromjenaLozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtStaraLozinka;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovaLozinkaPotvrda;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}