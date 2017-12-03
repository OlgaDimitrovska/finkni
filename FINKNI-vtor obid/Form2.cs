using CrystalDecisions.CrystalReports.Engine;
using FINKNI_Data;
using FINKNIAna_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer;

namespace FINKNI_vtor_obid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Environment.CurrentDirectory + @"CrystalReport1.rpt");
            rpt.SetDataSource(AnalitickoKontoDB.GetAKonta());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
