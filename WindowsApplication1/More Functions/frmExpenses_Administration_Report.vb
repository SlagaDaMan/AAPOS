Imports Microsoft.Reporting.WinForms

Public Class frmExpenses_Administration_Report

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        Try


            Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
            Dim final_date1 As String = date_start1 & " 01:10:19 AM"
            Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
            Dim final_date2 As String = date_start2 & " 11:59:19 PM"
            Dim total_paid As Double = 0
            Dim total_outstanding As Double = 0
            Dim total_balance As Double = 0

            If cmbDepartment.Text = "ALL" Then

                ExpensesTableAdapter.FillByAll(AAPOSDataSet.Expenses, final_date1, final_date2)
                For i = 0 To AAPOSDataSet.Expenses.Count - 1


                    total_paid = total_paid + Val(AAPOSDataSet.Expenses.Rows(i)("Paid").ToString)
                    total_outstanding = total_outstanding + Val(AAPOSDataSet.Expenses.Rows(i)("Outstanding").ToString)
                    total_balance = total_balance + Val(AAPOSDataSet.Expenses.Rows(i)("Balance").ToString)
                    'Me.ReportViewer1.RefreshReport()
                Next
                ExpensesTableAdapter.FillByAll(AAPOSDataSet.Expenses, final_date1, final_date2)
                Dim total_paid1 As New ReportParameter("total_paid", "R " & String.Format("{0:n}", Convert.ToDouble(total_paid)))
                ReportViewer1.LocalReport.SetParameters(total_paid1)

                Dim total_outstanding1 As New ReportParameter("total_outstanding", "R " & String.Format("{0:n}", Convert.ToDouble(total_outstanding)))
                ReportViewer1.LocalReport.SetParameters(total_outstanding1)

                Dim total_balance1 As New ReportParameter("total_balance", "R " & String.Format("{0:n}", Convert.ToDouble(total_balance)))
                ReportViewer1.LocalReport.SetParameters(total_balance1)

                Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Else

                ExpensesTableAdapter.FillByOrganisation(AAPOSDataSet.Expenses, final_date1, final_date2, cmbDepartment.Text)
                For i = 0 To AAPOSDataSet.Expenses.Count - 1


                    total_paid = total_paid + Val(AAPOSDataSet.Expenses.Rows(i)("Paid").ToString)
                    total_outstanding = total_outstanding + Val(AAPOSDataSet.Expenses.Rows(i)("Outstanding").ToString)
                    total_balance = total_balance + Val(AAPOSDataSet.Expenses.Rows(i)("Balance").ToString)
                Next
                ExpensesTableAdapter.FillByOrganisation(AAPOSDataSet.Expenses, final_date1, final_date2, cmbDepartment.Text)
                Dim total_paid1 As New ReportParameter("total_paid", "R " & String.Format("{0:n}", Convert.ToDouble(total_paid)))
                ReportViewer1.LocalReport.SetParameters(total_paid1)

                Dim total_outstanding1 As New ReportParameter("total_outstanding", "R " & String.Format("{0:n}", Convert.ToDouble(total_outstanding)))
                ReportViewer1.LocalReport.SetParameters(total_outstanding1)

                Dim total_balance1 As New ReportParameter("total_balance", "R " & String.Format("{0:n}", Convert.ToDouble(total_balance)))
                ReportViewer1.LocalReport.SetParameters(total_balance1)

                Me.ReportViewer1.RefreshReport()
                ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub ExpensesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub frmExpenses_Administration_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Expenses' table. You can move, or remove it, as needed.
        Me.ExpensesTableAdapter.Fill(Me.AAPOSDataSet.Expenses)

    End Sub
End Class