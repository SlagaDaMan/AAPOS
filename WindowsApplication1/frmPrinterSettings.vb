Public Class frmPrinterSettings

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'Me.StatusTableAdapter.U(Me.AAPOSDataSet.Status)
        If cmbPrinter.Text = "" Then
            MessageBox.Show("Please select an option", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        StatusTableAdapter.UpdateQueryPrinter(cmbPrinter.Text, "1")
        MessageBox.Show("Printer settings has been successfully updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbPrinter.SelectedIndex = -1
        Exit Sub
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close() '

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbPrinter.SelectedIndex = -1
        MessageBox.Show("Successfully Cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub frmPrinterSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub
End Class