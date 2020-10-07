Public Class frmExpenses

    Private Sub frmExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Expenses' table. You can move, or remove it, as needed.
        Me.ExpensesTableAdapter.Fill(Me.AAPOSDataSet.Expenses)

    End Sub

    Private Sub ExpensesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ExpensesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        If cmbDepartment.Text = "" Then
            MessageBox.Show("Please enter the department you would like to use", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If
        'If cmbSupplier.Text = "" Then
        '    MessageBox.Show("Please enter the Supplier you would like to use", "Information", MessageBoxButtons.OK)
        '    Exit Sub
        'End If

        If txtBalance.Text = "" Then
            MessageBox.Show("Please enter the Balance", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If
        If txtDescription.Text = "" Then
            MessageBox.Show("Please enter the description", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If
        If txtOutstanding.Text = "" Then
            MessageBox.Show("Please enter the oustanding balance", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If
        If txtPaid.Text = "" Then
            MessageBox.Show("Please enter the paid amount", "Information", MessageBoxButtons.OK)
            Exit Sub
        End If

        ExpensesTableAdapter.Insert(cmbDepartment.Text, cmbSupplier.Text, txtDescription.Text, txtBalance.Text, txtPaid.Text, txtOutstanding.Text, Format(DateTimePicker1.Value, "yyyy/MM/dd"), "", "", "", "", "", "", "")

        cmbDepartment.SelectedIndex = -1
        cmbSupplier.SelectedIndex = -1
        txtBalance.Text = ""
        txtDescription.Text = ""
        txtOutstanding.Text = ""
        txtPaid.Text = ""
        MessageBox.Show("Information has been successfully captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click

    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class