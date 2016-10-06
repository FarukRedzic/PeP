namespace WinFormUI.Forms {
    partial class frmSlideShow {
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Image = global::WinFormUI.Properties.Resources.deprives_you_of_tangibility;
            this.pb1.Location = new System.Drawing.Point(0, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(961, 1);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::WinFormUI.Properties.Resources._2_;
            this.pb2.Location = new System.Drawing.Point(0, 0);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(975, 454);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb3.Image = global::WinFormUI.Properties.Resources._1_;
            this.pb3.Location = new System.Drawing.Point(0, 0);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(961, 444);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 6500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(961, 444);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSlideShow";
            this.Text = "frmSlideShow";
            this.Load += new System.EventHandler(this.frmSlideShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Timer timer;
    }
}