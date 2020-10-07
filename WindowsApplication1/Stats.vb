Imports Microsoft.Reporting.WinForms

Public Class Stats
    Public Shared total, Cash, ellectronically As Double

    Private Sub Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.
        Me.TotalsTableAdapter.Fill(Me.AAPOSDataSet.Totals)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.



    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  01:10:19 AM"

        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  11:59:19 PM"

        If cmbOptions.Text = "" Then
            MessageBox.Show("Please select one of the options", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        If cmbOptions.Text = "ALL" Then
            Me.TotalsTableAdapter.FillByDatetype(Me.AAPOSDataSet.Totals, final_date1, final_date2, "CASH")
            Dim count1 As Integer = AAPOSDataSet.Totals.Count
            For i = 0 To count1 - 1
                Dim Price As String = Val(AAPOSDataSet.Totals.Rows(i)("Total").ToString)
                Cash = Cash + Price
            Next
            Me.TotalsTableAdapter.FillByDatetype(Me.AAPOSDataSet.Totals, final_date1, final_date2, "ELECTRONICALLY")
            Dim count2 As Integer = AAPOSDataSet.Totals.Count
            For i = 0 To count2 - 1
                Dim Price As Double = Val(AAPOSDataSet.Totals.Rows(i)("Total").ToString)
                ellectronically = ellectronically + Price
            Next
            'FillByDatetype
            Me.TotalsTableAdapter.FillBydate(Me.AAPOSDataSet.Totals, final_date1, final_date2)
            Dim count As Integer = AAPOSDataSet.Totals.Count
            For i = 0 To count - 1
                Dim Price As Double = Val(AAPOSDataSet.Totals.Rows(i)("Total").ToString)
                total = total + Price
            Next
            Dim Total_Amount As New ReportParameter("total", "R " & String.Format("{0:n}", Convert.ToDouble(total)))
            ReportViewer1.LocalReport.SetParameters(Total_Amount)
            Dim Total_Cash_Amount As New ReportParameter("Cash", "R " & String.Format("{0:n}", Convert.ToDouble(Cash)))
            ReportViewer1.LocalReport.SetParameters(Total_Cash_Amount)
            Dim Total_ellectronically_Amount As New ReportParameter("ellectronically", "R " & String.Format("{0:n}", Convert.ToDouble(ellectronically)))
            ReportViewer1.LocalReport.SetParameters(Total_ellectronically_Amount)
            Dim Date1 As New ReportParameter("Date1", final_date1)
            ReportViewer1.LocalReport.SetParameters(Date1)
            Dim Date2 As New ReportParameter("Date2", final_date2)
            ReportViewer1.LocalReport.SetParameters(Date2)
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        End If


        If cmbOptions.Text = "CASH" Then
            Me.TotalsTableAdapter.FillByDatetype(Me.AAPOSDataSet.Totals, final_date1, final_date2, "CASH")
            Dim count1 As Integer = AAPOSDataSet.Totals.Count
            For i = 1 To count1
                Dim Price As String = Val(AAPOSDataSet.Totals.Rows(0)("Total").ToString)
                Cash = Cash + Price
            Next
       
            Dim Total_Amount As New ReportParameter("total", "R " & String.Format("{0:n}", Convert.ToDouble(Cash)))
            ReportViewer1.LocalReport.SetParameters(Total_Amount)
            Dim Total_Cash_Amount As New ReportParameter("Cash", "R " & String.Format("{0:n}", Convert.ToDouble(Cash)))
            ReportViewer1.LocalReport.SetParameters(Total_Cash_Amount)
            Dim Total_ellectronically_Amount As New ReportParameter("ellectronically", "R " & String.Format("{0:n}", Convert.ToDouble(ellectronically)))
            ReportViewer1.LocalReport.SetParameters(Total_ellectronically_Amount)
            Dim Date1 As New ReportParameter("Date1", Format(DateTimePicker1.Value, "yyyy/MM/dd  hh:mm:ss"))
            ReportViewer1.LocalReport.SetParameters(Date1)
            Dim Date2 As New ReportParameter("Date2", Format(DateTimePicker2.Value, "yyyy/MM/dd  hh:mm:ss"))
            ReportViewer1.LocalReport.SetParameters(Date2)
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        End If


        If cmbOptions.Text = "ELECTRONICALLY" Then
            Me.TotalsTableAdapter.FillByDatetype(Me.AAPOSDataSet.Totals, final_date1, final_date2, "ELECTRONICALLY")
            Dim count2 As Integer = AAPOSDataSet.Totals.Count
            For i = 1 To count2
                Dim Price As Double = Val(AAPOSDataSet.Totals.Rows(0)("Total").ToString)
                ellectronically = ellectronically + Price
            Next

            Dim Total_Amount As New ReportParameter("total", "R" & ellectronically)
            ReportViewer1.LocalReport.SetParameters(Total_Amount)
            Dim Total_Cash_Amount As New ReportParameter("Cash", "R" & Cash)
            ReportViewer1.LocalReport.SetParameters(Total_Cash_Amount)
            Dim Total_ellectronically_Amount As New ReportParameter("ellectronically", "R " & String.Format("{0:n}", Convert.ToDouble(ellectronically)))
            ReportViewer1.LocalReport.SetParameters(Total_ellectronically_Amount)
            Dim Date1 As New ReportParameter("Date1", Format(DateTimePicker1.Value, "yyyy/MM/dd  hh:mm:ss"))
            ReportViewer1.LocalReport.SetParameters(Date1)
            Dim Date2 As New ReportParameter("Date2", Format(DateTimePicker2.Value, "yyyy/MM/dd  hh:mm:ss"))
            ReportViewer1.LocalReport.SetParameters(Date2)
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        End If
        total = 0
        Cash = 0
        ellectronically = 0



    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        frmMainScreen.Show()

    End Sub
End Class