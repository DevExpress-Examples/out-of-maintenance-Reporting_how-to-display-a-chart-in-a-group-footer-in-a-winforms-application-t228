Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraCharts

Namespace dxSample
    Partial Public Class XtraReport2
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrChart1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrChart1.BeforePrint
            Dim xrc As XRChart = DirectCast(sender, XRChart)

            ' Gets the current value of the grouping field. For correct implementation, the value should be of the same type as a data field. 
            ' For the master-detail report, use DetailBand.GetCurrentColumnValue in the detail band instead.
            Dim filter_value As Integer = Convert.ToInt32(GetCurrentColumnValue("Year"))

            ' Clears the filters that may have been set earlier. 
            xrc.Series(0).DataFilters.Clear()

            ' Creates and adds a new filter to the "Year" data field which has the int type.  
            ' The condition is that the data value equals the filter_value parameter. 
            xrc.Series(0).DataFilters.Add(New DataFilter("Year", GetType(Integer).ToString(), DataFilterCondition.Equal, filter_value))
        End Sub

    End Class
End Namespace
