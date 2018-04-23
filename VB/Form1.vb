Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraReports.UI

Namespace dxSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As New XtraReport2()
            report.CreateDocument(False)
            CType(New ReportPrintTool(report), ReportPrintTool).ShowPreviewDialog()
        End Sub
    End Class
End Namespace
