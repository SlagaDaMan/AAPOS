Imports Microsoft.Reporting.WinForms

Public Class FrmAccountEnqire

    Private Sub FrmAccountEnqire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.FillByAccounts(Me.AAPOSDataSet.Sales, "ACCOUNT", frmAccounts.txtID2.Text)
        Me.TopMost = True
        Label1.Text = Label1.Text + frmAccounts.txtname.Text + " " + frmAccounts.txtSurname.Text
        Dim Total_Amount As Double = 0
        For i = 0 To AAPOSDataSet.Sales.Count - 1
            Total_Amount = Total_Amount + AAPOSDataSet.Sales.Rows(0)("Selling_Price").ToString()
        Next
        ' Outstanding_Amount

        Dim Outstanding_Amount As New ReportParameter("Outstanding_Amount", "R " & String.Format("{0:n}", Convert.ToDouble(Total_Amount)))
        ReportViewer1.LocalReport.SetParameters(Outstanding_Amount)
        Dim Account_Holder_Name As New ReportParameter("Account_Holder_Name", frmAccounts.txtname.Text + " " + frmAccounts.txtSurname.Text)
        ReportViewer1.LocalReport.SetParameters(Account_Holder_Name)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmAccounts.Show()

    End Sub
End Class