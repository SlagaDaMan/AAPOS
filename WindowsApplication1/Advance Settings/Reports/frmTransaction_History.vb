Imports Microsoft.Reporting.WinForms

Public Class frmTransaction_History

    Private Sub btnRetreive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetreive.Click

        If txtReference.Text = "" Then
            MessageBox.Show("Please fill in the Ref No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.SalesTableAdapter.FillByNr(Me.AAPOSDataSet.Sales, txtReference.Text)
        Me.TotalsTableAdapter.FillByRef(Me.AAPOSDataSet.Totals, txtReference.Text)
        Dim Total As String = AAPOSDataSet.Totals.Rows(0)("Total").ToString
        Dim Amount_Paid As String = AAPOSDataSet.Totals.Rows(0)("Amount_Paid").ToString
        Dim Change As String = AAPOSDataSet.Totals.Rows(0)("Change").ToString
        Dim Auto As String = AAPOSDataSet.Totals.Rows(0)("Auto").ToString
        Dim Auto2 As String = AAPOSDataSet.Totals.Rows(0)("Auto2").ToString

        Dim Total_Amount As New ReportParameter("Total_Amount", "R " & String.Format("{0:n}", Convert.ToDouble(Total)))
        ReportViewer1.LocalReport.SetParameters(Total_Amount)

        Dim Total_Change As New ReportParameter("Total_Change", Change)
        ReportViewer1.LocalReport.SetParameters(Total_Change)

        Dim Cash As New ReportParameter("Cash", "R " & String.Format("{0:n}", Convert.ToDouble(Amount_Paid)))
        ReportViewer1.LocalReport.SetParameters(Cash)
        Me.TopMost = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub frmTransaction_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.



    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        frmAdvanceReports.Show()

    End Sub
End Class