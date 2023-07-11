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
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' lbOrderID
            ' 
            Me.lbOrderID.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.lbOrderID.LocationFloat = New DevExpress.Utils.PointFloat(400F, 17F)
            Me.lbOrderID.Name = "lbOrderID"
            Me.lbOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbOrderID.SizeF = New System.Drawing.SizeF(117F, 33F)
            Me.lbOrderID.Text = "lbOrderID"
            Me.lbOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.BorderWidth = 1
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Tag = "ProductName"
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell1.Weight = 0.25384615384615383R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.BorderWidth = 1
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.Tag = "Supplier"
            Me.xrTableCell4.Text = "Supplier"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell4.Weight = 0.34615384615384615R
            ' 
            ' clSupplier
            ' 
            Me.clSupplier.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Supplier")})
            Me.clSupplier.Name = "clSupplier"
            Me.clSupplier.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clSupplier.Text = "clSupplier"
            Me.clSupplier.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clSupplier.Weight = 0.34615384615384615R
            ' 
            ' xrPageInfo1
            ' 
            Me.xrPageInfo1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            Me.xrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(383F, 67F)
            Me.xrPageInfo1.Name = "xrPageInfo1"
            Me.xrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.xrPageInfo1.SizeF = New System.Drawing.SizeF(245F, 16F)
            Me.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell4, Me.xrTableCell7, Me.xrTableCell2, Me.xrTableCell13})
            Me.xrTableRow1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell7
            ' 
            Me.xrTableCell7.BorderWidth = 1
            Me.xrTableCell7.Name = "xrTableCell7"
            Me.xrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell7.Tag = "UnitPrice"
            Me.xrTableCell7.Text = "Unit Price"
            Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell7.Weight = 0.10923076923076923R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.BorderWidth = 1
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Tag = "Quantity"
            Me.xrTableCell2.Text = "Quantity"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell2.Weight = 0.13384615384615384R
            ' 
            ' xrTableCell13
            ' 
            Me.xrTableCell13.BorderWidth = 1
            Me.xrTableCell13.Name = "xrTableCell13"
            Me.xrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell13.Tag = "Discount"
            Me.xrTableCell13.Text = "Discount"
            Me.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell13.Weight = 0.15692307692307692R
            ' 
            ' clQuantity
            ' 
            Me.clQuantity.BorderWidth = 1
            Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Quantity")})
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clQuantity.Text = "clQuantity"
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clQuantity.Weight = 0.13384615384615384R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 25F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.BorderColor = System.Drawing.Color.Black
            Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.BorderWidth = 1
            Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75F)
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(650F, 25F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clProductName, Me.clSupplier, Me.clUnitPrice, Me.clQuantity, Me.clDiscount})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 1R
            ' 
            ' clProductName
            ' 
            Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.ProductName")})
            Me.clProductName.Name = "clProductName"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clProductName.Text = "clProductName"
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.clProductName.Weight = 0.25384615384615383R
            ' 
            ' clUnitPrice
            ' 
            Me.clUnitPrice.BorderWidth = 1
            Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.UnitPrice", "{0:$0.00}")})
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clUnitPrice.Text = "clUnitPrice"
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clUnitPrice.Weight = 0.10923076923076923R
            ' 
            ' clDiscount
            ' 
            Me.clDiscount.BorderWidth = 1
            Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OrderDetails.Discount")})
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clDiscount.Text = "clDiscount"
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDiscount.Weight = 0.15692307692307692R
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbOrderID, Me.xrLabel1, Me.xrPageInfo1})
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.CanShrink = True
            Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(25F, 17F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(366F, 33F)
            Me.xrLabel1.Text = "Details of the customer order"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrTable1})
            Me.PageHeader.HeightF = 72.1667F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Verdana", 11.25F, (CType((DevExpress.Drawing.DXFontStyle.Bold Or DevExpress.Drawing.DXFontStyle.Italic), DevExpress.Drawing.DXFontStyle)))
            Me.xrLabel2.ForeColor = System.Drawing.Color.DimGray
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(650F, 23F)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.Text = "Click a header to sort the report by the corresponding field."
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(214)))), (CInt((CByte(211)))))
            Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(189)))), (CInt((CByte(177)))), (CInt((CByte(183)))))
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.BorderWidth = 2
            Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 38.5417F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(650F, 33.625F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' orderDetailsTableAdapter
            ' 
            Me.orderDetailsTableAdapter.ClearBeforeFill = True
            ' 
            ' OrderDetailsReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.ReportHeader, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataAdapter = Me.orderDetailsTableAdapter
            Me.DataMember = "OrderDetails"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "11.1"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

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
