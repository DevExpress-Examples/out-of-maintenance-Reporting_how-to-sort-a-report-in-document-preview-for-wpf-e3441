Imports Microsoft.VisualBasic
Imports System
Namespace PreviewSortSample
	Partial Public Class OrderDetailsReport
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
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.lbOrderID = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSupplier = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.nwindDataSet1 = New PreviewSortSample.nwindDataSet()
            Me.orderDetailsTableAdapter = New PreviewSortSample.nwindDataSetTableAdapters.OrderDetailsTableAdapter()
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'topMarginBand1
            '
            Me.topMarginBand1.Name = "topMarginBand1"
            '
            'lbOrderID
            '
            Me.lbOrderID.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 17.0!)
            Me.lbOrderID.Name = "lbOrderID"
            Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.lbOrderID.SizeF = New System.Drawing.SizeF(117.0!, 33.0!)
            Me.lbOrderID.Text = "lbOrderID"
            Me.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'xrTableCell1
            '
            Me.xrTableCell1.BorderWidth = 1
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrTableCell1.Tag = "ProductName"
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.25384615384615383R
            '
            'xrTableCell4
            '
            Me.xrTableCell4.BorderWidth = 1
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrTableCell4.Tag = "Supplier"
            Me.xrTableCell4.Text = "Supplier"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.34615384615384615R
            '
            'clSupplier
            '
            Me.clSupplier.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Supplier")})
            Me.clSupplier.Name = "clSupplier"
            Me.clSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.clSupplier.Text = "clSupplier"
            Me.clSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clSupplier.Weight = 0.34615384615384615R
            '
            'xrPageInfo1
            '
            Me.xrPageInfo1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(383.0!, 67.0!)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(245.0!, 16.0!)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'xrTableRow1
            '
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell13})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1.0R
            '
            'xrTableCell7
            '
            Me.xrTableCell7.BorderWidth = 1
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrTableCell7.Tag = "UnitPrice"
            Me.xrTableCell7.Text = "Unit Price"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.10923076923076923R
            '
            'xrTableCell2
            '
            Me.xrTableCell2.BorderWidth = 1
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrTableCell2.Tag = "Quantity"
            Me.xrTableCell2.Text = "Quantity"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.13384615384615384R
            '
            'xrTableCell13
            '
            Me.xrTableCell13.BorderWidth = 1
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrTableCell13.Tag = "Discount"
            Me.xrTableCell13.Text = "Discount"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.15692307692307692R
            '
            'clQuantity
            '
            Me.clQuantity.BorderWidth = 1
            Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity")})
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.clQuantity.Text = "clQuantity"
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clQuantity.Weight = 0.13384615384615384R
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrTable2
            '
            Me.xrTable2.BorderColor = System.Drawing.Color.Black
            Me.xrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable2.BorderWidth = 1
            Me.xrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrTableRow2
            '
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.clProductName, Me.clSupplier, Me.clUnitPrice, Me.clQuantity, Me.clDiscount})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1.0R
            '
            'clProductName
            '
            Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName")})
            Me.clProductName.Name = "clProductName"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.clProductName.Text = "clProductName"
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clProductName.Weight = 0.25384615384615383R
            '
            'clUnitPrice
            '
            Me.clUnitPrice.BorderWidth = 1
            Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "{0:$0.00}")})
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.clUnitPrice.Text = "clUnitPrice"
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clUnitPrice.Weight = 0.10923076923076923R
            '
            'clDiscount
            '
            Me.clDiscount.BorderWidth = 1
            Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount")})
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.clDiscount.Text = "clDiscount"
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDiscount.Weight = 0.15692307692307692R
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.lbOrderID, Me.xrLabel1, Me.xrPageInfo1})
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrLabel1
            '
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 17.0!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(366.0!, 33.0!)
            Me.xrLabel1.Text = "Details of the customer order"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'bottomMarginBand1
            '
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrTable1})
            Me.PageHeader.HeightF = 72.1667!
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel2
            '
            Me.xrLabel2.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.xrLabel2.ForeColor = System.Drawing.Color.DimGray
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.Text = "Click a header to sort the report by the corresponding field."
            '
            'xrTable1
            '
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(211, Byte), Integer))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(183, Byte), Integer))
            Me.xrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                Or DevExpress.XtraPrinting.BorderSide.Right) _
                Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.xrTable1.BorderWidth = 2
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 38.5417!)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0!, 33.625!)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'nwindDataSet1
            '
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'orderDetailsTableAdapter
            '
            Me.orderDetailsTableAdapter.ClearBeforeFill = True
            '
            'OrderDetailsReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataAdapter = Me.orderDetailsTableAdapter
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "11.1"
            CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

		#End Region

		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private lbOrderID As DevExpress.XtraReports.UI.XRLabel
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private clSupplier As DevExpress.XtraReports.UI.XRTableCell
		Private xrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
		Private clQuantity As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private clProductName As DevExpress.XtraReports.UI.XRTableCell
		Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell
		Private clDiscount As DevExpress.XtraReports.UI.XRTableCell
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private nwindDataSet1 As nwindDataSet
		Private orderDetailsTableAdapter As nwindDataSetTableAdapters.OrderDetailsTableAdapter
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel


	End Class
End Namespace
