Imports System
Imports DevExpress.XtraReports.UI

' ...
Namespace PreviewSortSample

    Public Partial Class OrderDetailsReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public Sub SetOrderID(ByVal orderID As Integer)
            Me.nwindDataSet1.Clear()
            Me.orderDetailsTableAdapter.Fill(Me.nwindDataSet1.OrderDetails, orderID)
            Me.lbOrderID.Text = orderID.ToString()
        End Sub

        Public Sub Sort(ByVal fieldName As String)
            ' Disable sorting.
            Me.Detail.SortFields.Clear()
            ' Create a new sorting criterion.
            Dim grField As DevExpress.XtraReports.UI.GroupField = New DevExpress.XtraReports.UI.GroupField With {.FieldName = fieldName, .SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending}
            ' Enable sorting.
            Me.Detail.SortFields.Add(grField)
            ' Re-create the report document.
            Me.CreateDocument(True)
        End Sub
    End Class
End Namespace
