Public Class frmAccounts

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCellNo.TextChanged

    End Sub
    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlternativeNo.TextChanged

    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.AAPOSDataSet.Accounts)

    End Sub

    Private Sub AccountsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AccountsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnCapture_Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapture_Client.Click

        If txtname.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtSurname.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtID2.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtAddress.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtCellNo.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtAlternativeNo.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEmailAddress.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Try
            AccountsTableAdapter.Insert(txtID2.Text, UCase(txtname.Text), UCase(txtSurname.Text), UCase(txtCompanyName.Text), UCase(txtAddress.Text), UCase(txtAddress2.Text), UCase(txtAddress3.Text), UCase(txtCellNo.Text), UCase(txtEmailAddress.Text), UCase(txtAlternativeNo.Text), "", "", "", "", "", "", "")
            MessageBox.Show("Successfully captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtname.Text = ""
            txtSurname.Text = ""
            txtID2.Text = ""
            txtCompanyName.Text = ""
            txtAddress.Text = ""
            txtAddress2.Text = ""
            txtAddress3.Text = ""
            txtCellNo.Text = ""
            txtAlternativeNo.Text = ""
            txtEmailAddress.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEnquire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnquire.Click
        If txtname.Text = "" Then
            MessageBox.Show("Please retrieve the account you want to view", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        FrmAccountEnqire.Show()
        Me.Hide()





    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If txtID.Text = "" Then
            MessageBox.Show("Please fill in the ID/Cell No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'AAPOSDataSet.Accounts
        Try
            AccountsTableAdapter.FillByID(AAPOSDataSet.Accounts, txtID.Text, txtID.Text, txtID.Text)
        txtname.Text = AAPOSDataSet.Accounts.Rows(0)("Name").ToString
        txtSurname.Text = AAPOSDataSet.Accounts.Rows(0)("Surname").ToString
        txtID2.Text = AAPOSDataSet.Accounts.Rows(0)("ID_No").ToString
        txtCompanyName.Text = AAPOSDataSet.Accounts.Rows(0)("CompanyName").ToString
        txtAddress.Text = AAPOSDataSet.Accounts.Rows(0)("Physical_Address").ToString
        txtAddress2.Text = AAPOSDataSet.Accounts.Rows(0)("Physical_Address2").ToString
        txtAddress3.Text = AAPOSDataSet.Accounts.Rows(0)("Physical_Address3").ToString
        txtCellNo.Text = AAPOSDataSet.Accounts.Rows(0)("Cel_No").ToString
        txtAlternativeNo.Text = AAPOSDataSet.Accounts.Rows(0)("Alternative").ToString
        txtEmailAddress.Text = AAPOSDataSet.Accounts.Rows(0)("Email_Address").ToString
        Catch ex As Exception
            MessageBox.Show("Incorrect ID/Contact No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub

    Private Sub btnUpdate_Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_Client.Click

        If txtname.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtSurname.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtID2.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtCompanyName.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtAddress.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtCellNo.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtAlternativeNo.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtEmailAddress.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        AccountsTableAdapter.UpdateQuery(UCase(txtname.Text), UCase(txtSurname.Text), UCase(txtCompanyName.Text), UCase(txtAddress.Text), UCase(txtAddress2.Text), UCase(txtAddress3.Text), UCase(txtCellNo.Text), UCase(txtEmailAddress.Text), UCase(txtAlternativeNo.Text), txtID2.Text)
        MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname.Text = ""
        txtSurname.Text = ""
        txtID2.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtAddress2.Text = ""
        txtAddress3.Text = ""
        txtCellNo.Text = ""
        txtAlternativeNo.Text = ""
        txtEmailAddress.Text = ""
    End Sub

    Private Sub btnRemove_Client_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove_Client.Click
        AccountsTableAdapter.DeleteQuery(txtID2.Text)
        MessageBox.Show("Account has been successfully removed from the database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtname.Text = ""
        txtSurname.Text = ""
        txtID2.Text = ""
        txtCompanyName.Text = ""
        txtAddress.Text = ""
        txtAddress2.Text = ""
        txtAddress3.Text = ""
        txtCellNo.Text = ""
        txtAlternativeNo.Text = ""
        txtEmailAddress.Text = ""
    End Sub

    
    Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
        frmAccountList.Show()
        Me.Hide()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Advanced_Options.Show()

    End Sub
End Class