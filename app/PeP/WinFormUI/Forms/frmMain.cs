using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI.Forms;
using WinFormUI.Util;

namespace WinFormUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!(RunningForm.OpenForm is frmPretragaAdmin))
                frmPretragaAdmin.frm = null;

            frmPretragaAdmin frm = frmPretragaAdmin.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm))
            {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void btnDodajAdmina_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (!(RunningForm.OpenForm is frmNoviAdmin))
                frmNoviAdmin.frm = null;

            frmNoviAdmin frm = frmNoviAdmin.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm))
            {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtImePrezime.Text = Global.logiraniKorisnik.Ime + " " + Global.logiraniKorisnik.Prezime;
            frmSlideShow frm = new frmSlideShow();
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Close();
            RunningForm.OpenForm = new Form();
            new frmLogin().Show();
            //frmLogin login = new frmLogin();
            //login.Show();
        }

        private void mainPregledKorisnici_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmPretragaKorisnik))
                frmPretragaKorisnik.frm = null;

            frmPretragaKorisnik frm = frmPretragaKorisnik.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainDodajKorisnika_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmNoviKorisnik))
                frmNoviKorisnik.frm = null;

            frmNoviKorisnik frm = frmNoviKorisnik.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainPregledProizvodi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmPregledProizvodi))
                frmPregledProizvodi.frm = null;

            frmPregledProizvodi frm = frmPregledProizvodi.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainNarudzbe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmPregledNarudzbe))
                frmPregledNarudzbe.frm = null;

            frmPregledNarudzbe frm = frmPregledNarudzbe.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainLogovi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmPregledLogovi))
                frmPregledLogovi.frm = null;

            frmPregledLogovi frm = frmPregledLogovi.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainProfil_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            if (!(RunningForm.OpenForm is frmProfil))
                frmProfil.frm = null;

            frmProfil frm = frmProfil.SingletonInstance();
            if (!RunningForm.OpenForm.Equals(frm)) {
                RunningForm.OpenForm.Close();
                RunningForm.OpenForm = frm;
            }
            frm.MdiParent = this;
            frm.Show();
            frm.Left = 170;
            frm.Top = 75;
        }

        private void mainOdjava_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            this.Close();
            RunningForm.OpenForm = new Form();
            new frmLogin().Show();
        }
    }
}
