Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
' ...

Namespace PreviewSortSample
	Partial Public Class OrderDetailsReport
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub SetOrderID(ByVal orderID As Integer)
			nwindDataSet1.Clear()
			orderDetailsTableAdapter.Fill(nwindDataSet1.OrderDetails, orderID)
			lbOrderID.Text = orderID.ToString()
		End Sub

		Public Sub Sort(ByVal fieldName As String)
			' Disable sorting.
			Detail.SortFields.Clear()

			' Create a new sorting criterion.
			Dim grField As GroupField = New GroupField With {.FieldName = fieldName, .SortOrder = XRColumnSortOrder.Ascending}

			' Enable sorting.
			Detail.SortFields.Add(grField)

			' Re-create the report document.
			CreateDocument(True)
		End Sub
	End Class
End Namespace
