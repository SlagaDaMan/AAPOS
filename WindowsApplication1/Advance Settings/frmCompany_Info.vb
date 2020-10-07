Public Class frmCompany_Info

    Private Sub frmCompany_Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.Company_DetailsTableAdapter.Fill(Me.AAPOSDataSet.Company_Details)
            txtCompanyReg.Text = UCase(AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString)
            txtAddress.Text = UCase(AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString)
            txtEmail.Text = UCase(AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString)
            txtName.Text = UCase(AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString)
            txtContactNo.Text = UCase(AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtCompanyReg.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtAddress.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtEmail.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtName.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("Please fill in all the infomation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Try
            Company_DetailsTableAdapter.UpdateQueryCompany(txtCompanyReg.Text, txtName.Text, txtAddress.Text, txtContactNo.Text, txtEmail.Text, "", "", "", "", "", "", "", "1")
            MessageBox.Show("Company Details have been successfully updated", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCompanyReg.Text = ""
            txtAddress.Text = ""
            txtEmail.Text = ""
            txtName.Text = ""
            txtContactNo.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtCompanyReg.Text = ""
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtName.Text = ""
        txtContactNo.Text = ""
        MessageBox.Show("Company Details have been successfully cleared", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Advanced_Options.Show()

    End Sub
End Class