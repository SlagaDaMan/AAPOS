Public Class frmSystem_Settings

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Advanced_Options.Show()

    End Sub

    Private Sub frmSystem_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Till_Setup' table. You can move, or remove it, as needed.
        Me.Till_SetupTableAdapter.Fill(Me.AAPOSDataSet.Till_Setup)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Status' table. You can move, or remove it, as needed.

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        btnUpdate.Enabled = False
    End Sub

    
    Private Sub cmbOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbOptions.SelectedIndexChanged
        If cmbOptions.Text = "Printer" Then
            GroupBox2.Enabled = False
            GroupBox1.Enabled = True
            cmbOptions.Enabled = False
            btnUpdate.Enabled = True
            Exit Sub
        End If
        If cmbOptions.Text = "System" Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            cmbOptions.Enabled = False
            Exit Sub
        Else
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            cmbOptions.Enabled = True
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbOptions.Text = "Printer" Then
            If cmbPrinter.Text = "" Then
                MessageBox.Show("Please select if you want to switch the printer ON/OFF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If cmbCompanyType.Text = "" Then
                MessageBox.Show("Please select the company type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Me.StatusTableAdapter.U(Me.AAPOSDataSet.Status)
            StatusTableAdapter.UpdateQueryPrinter(cmbPrinter.Text, "1")
            StatusTableAdapter.UpdateQueryType(cmbCompanyType.Text, "1")
            MessageBox.Show("Printer settings has been successfully updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbOptions.Enabled = True
            cmbOptions.SelectedIndex = -1
            cmbPrinter.SelectedIndex = -1
            cmbSystem.SelectedIndex = -1
            cmbCompanyType.SelectedIndex = -1
            cmbTill.SelectedIndex = -1
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            Exit Sub
        ElseIf cmbOptions.Text = "System" Then
            If cmbSystem.Text = "" Then
                MessageBox.Show("Please select if you want to switch the VAT ON/OFF", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            'Me.StatusTableAdapter.U(Me.AAPOSDataSet.Status)
            StatusTableAdapter.UpdateQueryPrinter(cmbSystem.Text, "1")
            MessageBox.Show("System settings has been successfully updated ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbOptions.Enabled = True
            cmbOptions.SelectedIndex = -1
            cmbPrinter.SelectedIndex = -1
            cmbSystem.SelectedIndex = -1
            cmbTill.SelectedIndex = -1
            cmbCompanyType.SelectedIndex = -1
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            Exit Sub
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cmbOptions.Enabled = True
        cmbOptions.SelectedIndex = -1
        cmbPrinter.SelectedIndex = -1
        cmbSystem.SelectedIndex = -1
        cmbTill.SelectedIndex = -1
        cmbCompanyType.SelectedIndex = -1
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        MessageBox.Show("Successfully Cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub StatusBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnTill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTill.Click
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.UpdateQuerySetTilln("", IP)
        Till_SetupTableAdapter.UpdateQuery(IP, cmbTill.Text)
        cmbOptions.Enabled = True
        cmbOptions.SelectedIndex = -1
        cmbPrinter.SelectedIndex = -1
        cmbSystem.SelectedIndex = -1
        cmbTill.SelectedIndex = -1
        cmbCompanyType.SelectedIndex = -1
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        MessageBox.Show("Successfully Updated Till Number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class