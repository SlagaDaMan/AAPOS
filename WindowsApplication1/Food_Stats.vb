Imports Microsoft.Reporting.WinForms

Public Class Food_Stats

    Private Sub Food_Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        '  Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)

        ' Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Me.SalesTableAdapter.FillByDate(Me.AAPOSDataSet.Sales, date_start1, date_start2)
        Dim Date1 As New ReportParameter("Date1", date_start1)
        ReportViewer1.LocalReport.SetParameters(Date1)
        Dim Date2 As New ReportParameter("Date2", date_start2)
        ReportViewer1.LocalReport.SetParameters(Date2)

        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        Main_Stats.Show()

    End Sub
End Class