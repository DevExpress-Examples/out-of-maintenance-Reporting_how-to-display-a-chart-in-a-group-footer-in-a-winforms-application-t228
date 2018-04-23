using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraCharts;

namespace dxSample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrChart1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            XRChart xrc = (XRChart)sender;

            // Gets the current value of the grouping field. For correct implementation, the value should be of the same type as a data field. 
            // For the master-detail report, use DetailBand.GetCurrentColumnValue in the detail band instead.
            int filter_value = Convert.ToInt32(GetCurrentColumnValue("Year"));

            // Clears the filters that may have been set earlier. 
            xrc.Series[0].DataFilters.Clear();

            // Creates and adds a new filter to the "Year" data field which has the int type.  
            // The condition is that the data value equals the filter_value parameter. 
            xrc.Series[0].DataFilters.Add(new DataFilter("Year", typeof(int).ToString(), DataFilterCondition.Equal, filter_value));
        }

    }
}
