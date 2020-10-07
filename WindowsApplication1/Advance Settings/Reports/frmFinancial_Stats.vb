Imports Microsoft.Reporting.WinForms

Public Class frmFinancial_Stats
    Public Shared total, Cash, ellectronically As Double
    Private Sub frmFinancial_Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.
        Me.TotalsTableAdapter.Fill(Me.AAPOSDataSet.Totals)


    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  01:10:19 AM"

        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  11:59:19 PM"



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

        'Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        Dim counttotal As Double = 0
        Dim countStock As Double = 0
        SalesTableAdapter.FillByDate(AAPOSDataSet.Sales, final_date1, final_date2)
        Try
            Dim count_int As Integer = AAPOSDataSet.Sales.Rows.Count

            For i = 0 To count_int - 2
                Dim Item_Nr As Double = Val(AAPOSDataSet.Sales.Rows(i)("Auto").ToString)
                Dim item_Selling_price As Double = Val(AAPOSDataSet.Sales.Rows(i)("Selling_Price").ToString) * Item_Nr
                counttotal = counttotal + item_Selling_price
                Dim item_Stock_Price As Double = Val(AAPOSDataSet.Sales.Rows(i)("Stock_Price").ToString) * Item_Nr
                countStock = countStock + item_Stock_Price

            Next
        Catch ex As Exception
        End Try
        Dim total_profit As Double = counttotal - countStock

        'Dim Total_Amount As New ReportParameter("total_Stock_Cost", "R " & String.Format("{0:n}", Convert.ToDouble(counttotal)))
        'ReportViewer1.LocalReport.SetParameters(Total_Amount)

        Dim Profit As New ReportParameter("Total_Profit", "R " & String.Format("{0:n}", Convert.ToDouble(total_profit)))
        ReportViewer1.LocalReport.SetParameters(Profit)


        'Me.ReportViewer1.RefreshReport()


        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TotalsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TotalsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmAdvanceReports.Show()

    End Sub
End Class