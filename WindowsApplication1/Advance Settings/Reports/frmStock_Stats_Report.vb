Imports Microsoft.Reporting.WinForms

Public Class frmStock_Stats_Report

    Private Sub frmStock_Stats_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        'Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        'Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Autogen' table. You can move, or remove it, as needed.
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        Dim counttotal As Double = 0
        Dim countStock As Double = 0
        Try
            Dim count_int As Integer = AAPOSDataSet.Stock_Items.Rows.Count

            For i = 0 To count_int - 2
                Dim Item_Nr As Double = Val(AAPOSDataSet.Stock_Items.Rows(i)("Optional_Item1").ToString)
                Dim item_Selling_price As Double = Val(AAPOSDataSet.Stock_Items.Rows(i)("Item_SellingPrice").ToString) * Item_Nr
                counttotal = counttotal + item_Selling_price
                Dim item_Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(i)("Item_StockPrice").ToString) * Item_Nr
                countStock = countStock + item_Stock_Price

            Next
        Catch ex As Exception
        End Try
        Dim total_profit As Double = counttotal - countStock

        Dim Total_Amount As New ReportParameter("total_Stock_Cost", "R " & String.Format("{0:n}", Convert.ToDouble(counttotal)))
        ReportViewer1.LocalReport.SetParameters(Total_Amount)

        Dim Profit As New ReportParameter("Total_Profit", "R " & String.Format("{0:n}", Convert.ToDouble(total_profit)))
        ReportViewer1.LocalReport.SetParameters(Profit)
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.TopMost = True
        'lblStock.Text = "R " & String.Format("{0:n}", Convert.ToDouble(counttotal))
        'lblProfit.Text = "R " & String.Format("{0:n}", Convert.ToDouble(total_profit))
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub AutogenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AutogenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmAdvanceReports.Show()
    End Sub
End Class