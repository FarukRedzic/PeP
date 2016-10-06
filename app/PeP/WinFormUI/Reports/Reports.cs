using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebAPI.ViewModels;

namespace WinFormUI.Reports {
    public partial class Reports : Form {
        string rptName = string.Empty;
        List<ProizvodVM> listaProizvodi = new List<ProizvodVM>();
        List<NarudzbaVM> listaNarudzbe = new List<NarudzbaVM>();
        List<LogoviVM> listaLogovi = new List<LogoviVM>();
        List<KorisnikVM> listaKorisnici = new List<KorisnikVM>();
        List<DojamVM> listaDojmovi = new List<DojamVM>();
        List<FavoritiVM> listaFavoriti = new List<FavoritiVM>();

        public Reports(List<ProizvodVM> lista, string rptName) {
            InitializeComponent();
            this.listaProizvodi = lista;
            this.rptName = rptName;
        }

        public Reports(List<NarudzbaVM> lista, string rptName) {
            InitializeComponent();
            this.listaNarudzbe = lista;
            this.rptName = rptName;
        }


        public Reports(List<LogoviVM> lista, string rptName) {
            InitializeComponent();
            this.listaLogovi = lista;
            this.rptName = rptName;
        }

        public Reports(List<KorisnikVM> lista, string rptName) {
            InitializeComponent();
            this.listaKorisnici = lista;
            this.rptName = rptName;
        }

        public Reports(List<DojamVM> lista, string rptName) {
            InitializeComponent();
            this.listaDojmovi = lista;
            this.rptName = rptName;
        }

        public Reports(List<FavoritiVM> lista, string rptName) {
            InitializeComponent();
            this.listaFavoriti = lista;
            this.rptName = rptName;
        }

        private void rptProizvodi_Load(object sender, EventArgs e) {
            ReportDataSource rds;

            switch (this.rptName) {
                case "Proizvodi":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportProizvodi.rdlc";
                    ProizvodVMBindingSource.DataSource = listaProizvodi;
                    rds = new ReportDataSource("dsProizvodi", ProizvodVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;

                case "Narudzbe":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportNarudzbe.rdlc";
                    NarudzbaVMBindingSource.DataSource = listaNarudzbe;
                    rds = new ReportDataSource("dsNarudzbe", NarudzbaVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;


                case "Logovi":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportLogovi.rdlc";
                    LogoviVMBindingSource.DataSource = listaLogovi;
                    rds = new ReportDataSource("dsLogovi", LogoviVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;

                case "Korisnici":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportKorisnici.rdlc";
                    KorisnikVMBindingSource.DataSource = listaKorisnici;
                    rds = new ReportDataSource("dsKorisnici", KorisnikVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break; 

                case "metroProizvodi":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroProizvodi.rdlc";
                    ProizvodVMBindingSource.DataSource = listaProizvodi;
                    rds = new ReportDataSource("dsMetroProizvodi", ProizvodVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;
                case "metroNarudzbe":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroNarudzbe.rdlc";
                    NarudzbaVMBindingSource.DataSource = listaNarudzbe;
                    rds = new ReportDataSource("dsNarudzbe", NarudzbaVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;

                case "metroProdao":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroProdao.rdlc";
                    NarudzbaVMBindingSource.DataSource = listaNarudzbe;
                    rds = new ReportDataSource("dsMetroProdao", NarudzbaVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;
                //
                case "metroFavoriti":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroFavoriti.rdlc";
                    NarudzbaVMBindingSource.DataSource = listaFavoriti;
                    rds = new ReportDataSource("dsMetroFavoriti", NarudzbaVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;

                case "metroDojmovi":
                    reportViewer.LocalReport.ReportEmbeddedResource = "WinFormUI.Reports.ReportMetroDojmovi.rdlc";
                    DojamVMBindingSource.DataSource = listaDojmovi;
                    rds = new ReportDataSource("dsMetroDojmovi", DojamVMBindingSource);
                    reportViewer.LocalReport.DataSources.Add(rds);
                    this.reportViewer.RefreshReport();
                    break;

            }

        }
    }
}
