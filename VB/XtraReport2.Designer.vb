Namespace dxSample
    Partial Public Class XtraReport2
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport2))
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell3, Me.xrTableCell4})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 11.5R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "GSP"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "gspConnection"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "GSP"
            tableInfo1.Name = "GSP"
            columnInfo1.Name = "ID"
            columnInfo2.Name = "Region"
            columnInfo3.Name = "Year"
            columnInfo4.Name = "GSP"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel9})
            Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("Year", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeader1.HeightF = 34.375F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "Region"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GSP.GSP")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell4"
            Me.xrTableCell4.Weight = 0.22222222222222221R
            ' 
            ' GroupFooter1
            ' 
            Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1})
            Me.GroupFooter1.HeightF = 267.7083F
            Me.GroupFooter1.Name = "GroupFooter1"
            Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 18F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)))
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(44.79167F, 0F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(232.2915F, 33F)
            Me.xrLabel9.StyleName = "Title"
            Me.xrLabel9.StylePriority.UseBorders = False
            Me.xrLabel9.StylePriority.UseFont = False
            Me.xrLabel9.Text = "GSP in [Year]"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "GSP.Region")})
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.Weight = 0.22222222222222221R
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.PageHeader.HeightF = 25F
            Me.PageHeader.Name = "PageHeader"
            ' 
            ' xrChart1
            ' 
            Me.xrChart1.BorderColor = System.Drawing.Color.Black
            Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrChart1.DataMember = "GSP"
            Me.xrChart1.DataSource = Me.sqlDataSource1
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.Diagram = xyDiagram1
            Me.xrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.xrChart1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrChart1.Name = "xrChart1"
            series1.ArgumentDataMember = "Region"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.Name = "Series 1"
            series1.ValueDataMembersSerializable = "GSP"
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True
            series1.View = sideBySideBarSeriesView1
            Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.xrChart1.SizeF = New System.Drawing.SizeF(650F, 267.7083F)
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(166)))), (CInt((CByte(210)))), (CInt((CByte(255)))))
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(649.9999F, 25F)
            Me.xrTable1.StylePriority.UseBackColor = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UseTextAlignment = False
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' XtraReport2
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1, Me.GroupFooter1})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "GSP"
            Me.DataSource = Me.sqlDataSource1
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "14.2"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
        Private WithEvents xrChart1 As DevExpress.XtraReports.UI.XRChart
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand

    End Class
End Namespace
