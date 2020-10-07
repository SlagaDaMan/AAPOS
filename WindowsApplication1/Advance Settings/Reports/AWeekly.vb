Imports Microsoft.Reporting.WinForms

Public Class AWeekly

    Private Sub AWeekly_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  01:10:19 AM"

        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  11:59:19 PM"
        Me.SalesTableAdapter.FillByDateSaleType(Me.AAPOSDataSet.Sales, final_date1, final_date2, "SALE")

        Dim Date1 As New ReportParameter("Date1", final_date1)
        ReportViewer1.LocalReport.SetParameters(Date1)

        Dim Date2 As New ReportParameter("Date2", final_date2)
        ReportViewer1.LocalReport.SetParameters(Date2)

        'Dim Outcome_Vat As New ReportParameter("Outcome_Vat", "R " & String.Format("{0:n}", Convert.ToDouble(TOTAL_VAT_OUT)))
        'ReportViewer1.LocalReport.SetParameters(Outcome_Vat)

        'Dim Income_Vat1 As New ReportParameter("Income_Vat", "R " & String.Format("{0:n}", Convert.ToDouble(Income_Vat)))
        'ReportViewer1.LocalReport.SetParameters(Income_Vat1)

        'Dim VAT_Difference As Double = TOTAL_VAT_OUT - Income_Vat

        'Dim VAT_Difference1 As New ReportParameter("VAT_Difference", "R " & String.Format("{0:n}", Convert.ToDouble(VAT_Difference)))
        'ReportViewer1.LocalReport.SetParameters(VAT_Difference1)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.TopMost = True
        'Dim 
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmAdvanceReports.Show()

    End Sub
End Class