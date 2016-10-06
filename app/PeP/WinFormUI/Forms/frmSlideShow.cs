using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI.Forms {
    public partial class frmSlideShow : Form {
        public frmSlideShow() {
            InitializeComponent();
            pb1.Width = 970;
            pb1.Height = 448;
            pb1.Dock = DockStyle.Fill;
            pb1.BorderStyle = BorderStyle.None;

            pb2.Width = 964;
            pb2.Height = 448;
            pb2.Dock = DockStyle.Fill;
            pb2.BorderStyle = BorderStyle.None;


            pb3.Width = 964;
            pb3.Height = 448;
            pb3.Dock = DockStyle.Fill;
            pb3.BorderStyle = BorderStyle.None;

        }

        private void timer_Tick(object sender, EventArgs e) {
            if (pb1.Visible == true) {
                pb1.Visible = false;
                pb2.Visible = true;
            }
            else if (pb2.Visible == true) {
                pb2.Visible = false;
                pb3.Visible = true;
            }
            else if (pb3.Visible == true) {
                pb3.Visible = false;
                pb1.Visible = true;
            }

        }

        private void frmSlideShow_Load(object sender, EventArgs e) {
            timer.Start();
        }
    }
}
