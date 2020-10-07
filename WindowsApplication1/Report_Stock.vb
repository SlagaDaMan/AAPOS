Imports Microsoft.Reporting.WinForms

Public Class Report_Stock

    Private Sub Report_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        Dim Total_Amount As New ReportParameter("total_Stock_Cost", Stock_Stats.lblStock.Text)
        ReportViewer1.LocalReport.SetParameters(Total_Amount)

        Dim Profit As New ReportParameter("Total_Profit", Stock_Stats.lblProfit.Text)
        ReportViewer1.LocalReport.SetParameters(Profit)
        Me.TopMost = True
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub Stock_ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Stock_ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub
End Class