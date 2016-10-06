namespace WinFormUI.Forms {
    partial class frmDojam {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDojam));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOstavioDojam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtSadrzaj = new System.Windows.Forms.RichTextBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.lblOcjenaDojam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProizvodDojam = new System.Windows.Forms.LinkLabel();
            this.lblProizvodId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ostavio dojam:";
            // 
            // lblOstavioDojam
            // 
            this.lblOstavioDojam.AutoSize = true;
            this.lblOstavioDojam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOstavioDojam.Location = new System.Drawing.Point(148, 14);
            this.lblOstavioDojam.Name = "lblOstavioDojam";
            this.lblOstavioDojam.Size = new System.Drawing.Size(54, 21);
            this.lblOstavioDojam.TabIndex = 1;
            this.lblOstavioDojam.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sadržaj:";
            // 
            // rtxtSadrzaj
            // 
            this.rtxtSadrzaj.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtSadrzaj.Location = new System.Drawing.Point(38, 114);
            this.rtxtSadrzaj.Name = "rtxtSadrzaj";
            this.rtxtSadrzaj.ReadOnly = true;
            this.rtxtSadrzaj.Size = new System.Drawing.Size(244, 203);
            this.rtxtSadrzaj.TabIndex = 3;
            this.rtxtSadrzaj.Text = "";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZatvori.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnZatvori.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvori.Image")));
            this.btnZatvori.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZatvori.Location = new System.Drawing.Point(127, 327);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(66, 23);
            this.btnZatvori.TabIndex = 88;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // lblOcjenaDojam
            // 
            this.lblOcjenaDojam.AutoSize = true;
            this.lblOcjenaDojam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjenaDojam.Location = new System.Drawing.Point(90, 38);
            this.lblOcjenaDojam.Name = "lblOcjenaDojam";
            this.lblOcjenaDojam.Size = new System.Drawing.Size(54, 21);
            this.lblOcjenaDojam.TabIndex = 90;
            this.lblOcjenaDojam.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 89;
            this.label4.Text = "Ocjena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 91;
            this.label5.Text = "Proizvod:";
            // 
            // lblProizvodDojam
            // 
            this.lblProizvodDojam.ActiveLinkColor = System.Drawing.Color.Navy;
            this.lblProizvodDojam.AutoSize = true;
            this.lblProizvodDojam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProizvodDojam.LinkColor = System.Drawing.Color.Navy;
            this.lblProizvodDojam.Location = new System.Drawing.Point(106, 61);
            this.lblProizvodDojam.Name = "lblProizvodDojam";
            this.lblProizvodDojam.Size = new System.Drawing.Size(83, 21);
            this.lblProizvodDojam.TabIndex = 92;
            this.lblProizvodDojam.TabStop = true;
            this.lblProizvodDojam.Text = "linkLabel1";
            this.lblProizvodDojam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProizvodDojam_LinkClicked);
            // 
            // lblProizvodId
            // 
            this.lblProizvodId.AutoSize = true;
            this.lblProizvodId.Location = new System.Drawing.Point(239, 66);
            this.lblProizvodId.Name = "lblProizvodId";
            this.lblProizvodId.Size = new System.Drawing.Size(0, 13);
            this.lblProizvodId.TabIndex = 93;
            this.lblProizvodId.Visible = false;
            // 
            // frmDojam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(324, 367);
            this.Controls.Add(this.lblProizvodId);
            this.Controls.Add(this.lblProizvodDojam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOcjenaDojam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.rtxtSadrzaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOstavioDojam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDojam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dojam";
            this.Load += new System.EventHandler(this.frmDojam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOstavioDojam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtSadrzaj;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblOcjenaDojam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblProizvodDojam;
        private System.Windows.Forms.Label lblProizvodId;
    }
}