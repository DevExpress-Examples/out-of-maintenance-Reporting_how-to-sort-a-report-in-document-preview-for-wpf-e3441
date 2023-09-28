Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Printing

' ...
Namespace PreviewSortSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Private ReadOnly report As OrderDetailsReport

        Public Sub New()
            Me.InitializeComponent()
            report = New OrderDetailsReport()
            report.SetOrderID(11077)
            Dim model As XtraReportPreviewModel = New XtraReportPreviewModel(report)
            AddHandler model.PreviewClick, AddressOf model_PreviewClick
            AddHandler model.PreviewMouseMove, AddressOf model_PreviewMouseMove
            Me.preview.Model = model
            report.CreateDocument(True)
        End Sub

        Private Sub model_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If Not String.IsNullOrEmpty(e.ElementTag) Then
                Dim sortField As String = e.ElementTag
                report.Sort(sortField)
            End If
        End Sub

        Private Sub model_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If Not String.IsNullOrEmpty(e.ElementTag) AndAlso e.Element IsNot Nothing Then
                e.Element.Cursor = Cursors.Hand
            End If
        End Sub
    End Class
End Namespace
