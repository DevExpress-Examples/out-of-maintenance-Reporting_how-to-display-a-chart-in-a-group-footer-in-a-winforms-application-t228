using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace dxSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport2 report = new XtraReport2();
            report.CreateDocument(false);
            new ReportPrintTool(report).ShowPreviewDialog();
        }
    }
}
