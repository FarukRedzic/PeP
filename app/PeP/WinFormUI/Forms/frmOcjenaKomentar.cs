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
    public partial class frmOcjenaKomentar : Form {
        string Komentar;
        public frmOcjenaKomentar(string Komentar) {
            InitializeComponent();
            this.Komentar = Komentar;
        }

        private void btnZatvori_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void frmOcjenaKomentar_Load(object sender, EventArgs e) {
            rtxtKomentar.Text = Komentar;
        }
    }
}
