Public Class frmsuppliers
    Public Shared TransectionDate As String
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click



        txtReg_NR.Text = ""
        txtVat_No.Text = ""
        txtADDRESS1.Text = ""
        txtADDRESS2.Text = ""
        txtADDRESS3.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtInternet.Text = ""
        txtEmail.Text = ""
        txtCompany.Text = ""
        txtPayOut.Text = ""
        txtBalance.Text = ""
        txtCredit.Text = ""
        Button1.Enabled = True
        Button2.Enabled = False
        MessageBox.Show("Cleared successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.SupplierDetailsTableAdapter.Insert(UCase(txtCompany.Text), UCase(txtReg_NR.Text), UCase(txtADDRESS1.Text), UCase(txtADDRESS2.Text), UCase(txtADDRESS3.Text), UCase(txtCredit.Text), UCase(txtBalance.Text), UCase(txtPayOut.Text), UCase(txtTel.Text), UCase(txtFax.Text), LCase(txtInternet.Text), LCase(txtEmail.Text), txtVat_No.Text)


        MessageBox.Show("Supplier has been successfully captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtReg_NR.Text = ""
        txtVat_No.Text = ""
        txtADDRESS1.Text = ""
        txtADDRESS2.Text = ""
        txtADDRESS3.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtInternet.Text = ""
        txtEmail.Text = ""
        txtCompany.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SupplierDetailsTableAdapter.UpdateQueryCompanyDetails(UCase(txtReg_NR.Text), UCase(txtADDRESS1.Text), UCase(txtADDRESS2.Text), UCase(txtADDRESS3.Text), UCase(txtCredit.Text), UCase(txtBalance.Text), UCase(txtPayOut.Text), UCase(txtTel.Text), UCase(txtFax.Text), LCase(txtInternet.Text), LCase(txtEmail.Text), txtVat_No.Text, UCase(txtCompany.Text))
        MessageBox.Show("Supplier has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtReg_NR.Text = ""
        txtVat_No.Text = ""
        txtADDRESS1.Text = ""
        txtADDRESS2.Text = ""
        txtADDRESS3.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtInternet.Text = ""
        txtEmail.Text = ""
        txtCompany.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmdType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdType.SelectedIndexChanged
        If cmdType.Text = "Add New" Then

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            cmdSuppliers.Visible = False
            lblSuppliers.Visible =
            txtCredit.Enabled = True
            txtBalance.Enabled = True
            txtPayOut.Enabled = False
        ElseIf cmdType.Text = "Enquire" Then

            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            ' GroupBox3.Enabled = False
            txtCredit.Enabled = False
            txtBalance.Enabled = False
            txtPayOut.Enabled = True
            ' GroupBox4.Enabled = False
            cmdSuppliers.Visible = True
            lblSuppliers.Visible = True
        End If
    End Sub

    Private Sub frmsuppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.SupplierTransections' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AAPOSDataSet.SupplierPayOutTransections' table. You can move, or remove it, as needed.
        Me.SupplierPayOutTransectionsTableAdapter.Fill(Me.AAPOSDataSet.SupplierPayOutTransections)
        'TODO: This line of code loads data into the 'AAPOSDataSet.SupplierDetails' table. You can move, or remove it, as needed.

        cmdSuppliers.Visible = False
        lblSuppliers.Visible = False

        Try
            Me.SupplierDetailsTableAdapter.Fill(Me.AAPOSDataSet.SupplierDetails)
            For I = 0 To AAPOSDataSet.SupplierDetails.Rows.Count - 1
                Dim REF As String = AAPOSDataSet.SupplierDetails.Rows(I)("CompanyName").ToString
                cmdSuppliers.Items.Add(REF)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSuppliers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuppliers.SelectedIndexChanged
        Try

            Me.SupplierDetailsTableAdapter.FillByCompanyName(Me.AAPOSDataSet.SupplierDetails, cmdSuppliers.Text)
            Me.SupplierTransectionsTableAdapter.FillByCompanyAll(Me.AAPOSDataSet.SupplierTransections, cmdSuppliers.Text)
            txtReg_NR.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyRegNumber").ToString)
            txtVat_No.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("VatNum").ToString)
            txtADDRESS1.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress").ToString)
            txtADDRESS2.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress2").ToString)
            txtADDRESS3.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress3").ToString)
            txtTel.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Tel").ToString)
            txtFax.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Fax").ToString)
            txtInternet.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Internet").ToString)
            txtEmail.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Email").ToString)
            txtCompany.Text = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyName").ToString)
            txtBalance.Text = String.Format("{0:n}", Convert.ToDouble(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Balance").ToString)))
            txtCredit.Text = String.Format("{0:n}", Convert.ToDouble(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Credit").ToString)))
            txtPayOut.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SupplierDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SupplierDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnPayOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPayOut.Click
        Dim CurrentDate As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
        Me.SupplierPayOutTransectionsTableAdapter.Insert(UCase(txtCompany.Text), UCase(txtReg_NR.Text), UCase(txtADDRESS1.Text), UCase(txtADDRESS2.Text), UCase(txtADDRESS3.Text), UCase(txtCredit.Text), UCase(txtBalance.Text), UCase(txtPayOut.Text), UCase(txtTel.Text), UCase(txtFax.Text), LCase(txtInternet.Text), LCase(txtEmail.Text), txtVat_No.Text, "Payment", CurrentDate, frmLogin.txtUserName.Text, Val(txtBalance.Text) - Val(txtPayOut.Text), txtPayOut.Text)
        SupplierDetailsTableAdapter.UpdateQueryBalance(Convert.ToDouble(txtBalance.Text) - Convert.ToDouble(txtPayOut.Text), txtCompany.Text)
        Dim Balance As Double
        Dim TransectionStatus As String
        If txtBalance.Text = 0 Then
            Balance = Convert.ToDouble(txtCredit.Text) - Convert.ToDouble(txtPayOut.Text)
        Else

            Balance = Convert.ToDouble(txtBalance.Text) - Convert.ToDouble(txtPayOut.Text)
            If Balance < 0 Then
                MessageBox.Show("Payout can not be more than balance", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            If Balance = 0 Then
                TransectionStatus = "Payed"
            Else
                TransectionStatus = "Credit"
            End If
        End If



        SupplierTransectionsTableAdapter.UpdateQuery(txtCredit.Text, Balance, Convert.ToDouble(txtCredit.Text) - Convert.ToDouble(txtBalance.Text) + Convert.ToDouble(txtPayOut.Text), TransectionStatus, TransectionDate)

        MessageBox.Show("Supplier has been paid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtReg_NR.Text = ""
        txtVat_No.Text = ""
        txtADDRESS1.Text = ""
        txtADDRESS2.Text = ""
        txtADDRESS3.Text = ""
        txtTel.Text = ""
        txtFax.Text = ""
        txtInternet.Text = ""
        txtEmail.Text =
            txtCredit.Text = ""
        txtBalance.Text = ""
        txtPayOut.Text = ""
        ' DataGridView1.Rows.Clear()
        SupplierTransectionsTableAdapter.Dispose()

        cmdSuppliers.SelectedIndex = -1
        cmdType.SelectedIndex = -1
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Try


            Dim intde As String = DataGridView1.CurrentRow.Index
            txtBalance.Text = DataGridView1.Rows(intde).Cells(2).Value
            txtCredit.Text = DataGridView1.Rows(intde).Cells(1).Value
            'txtpa = DataGridView1.Rows(intde).Cells(3).Value

            TransectionDate = DataGridView1.Rows(intde).Cells(0).Value
        Catch ex As Exception

        End Try
        ' SupplierPayOutTransectionsTableAdapter.Update(1)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Me.SupplierTransectionsTableAdapter.FillByCompanyType(Me.AAPOSDataSet.SupplierTransections, cmdSuppliers.Text, ComboBox1.Text)
        Catch ex As Exception

        End Try
    End Sub
End Class