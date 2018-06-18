Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim creport As New CrystalReport2
        creport.Load(Application.StartupPath & "\CrystalReport2.rpt")
        CrystalReportViewer1.ReportSource = creport
        CrystalReportViewer1.Refresh()

    End Sub

End Class