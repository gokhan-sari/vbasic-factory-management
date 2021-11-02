Public Class Form3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'vtDataSet.urunstok' table. You can move, or remove it, as needed.
        Me.urunstokTableAdapter.Fill(Me.vtDataSet.urunstok)
        'TODO: This line of code loads data into the 'vtDataSet.hammadde' table. You can move, or remove it, as needed.
        Me.hammaddeTableAdapter.Fill(Me.vtDataSet.hammadde)
        Me.Width = 850
        Me.Height = 600
        Me.CenterToScreen()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class