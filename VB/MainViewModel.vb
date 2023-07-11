Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Input

Namespace PreviewSortSample
    <POCOViewModel> _
    Public Class MainViewModel
        Private privateReport As OrderDetailsReport
        Public Overridable Property Report() As OrderDetailsReport
            Get
                Return privateReport
            End Get
            Protected Set(ByVal value As OrderDetailsReport)
                privateReport = value
            End Set
        End Property
        Protected Sub New()
            Report = New OrderDetailsReport()
            Report.SetOrderID(11077)
        End Sub

        Public Sub OnPreviewMouseClick(ByVal args As DocumentPreviewMouseEventArgs)
            Dim sortField = TryCast(args.ElementTag, String)
            If Not String.IsNullOrEmpty(sortField) Then
                Report.Sort(sortField)
            End If
        End Sub

        Public Sub OnPreviewMouseMove(ByVal args As DocumentPreviewMouseEventArgs)
            Dim sortField = TryCast(args.ElementTag, String)
            If Not String.IsNullOrEmpty(sortField) Then
                Mouse.SetCursor(Cursors.Hand)
            End If
        End Sub
    End Class
End Namespace
