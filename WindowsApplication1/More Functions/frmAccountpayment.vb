Public Class frmAccountpayment

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'If ComboBox1.Text = "" Then
        '    MessageBox.Show("Please fill in the ID/Cell No", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        'AAPOSDataSet.Accounts
        Try
            AccountsTableAdapter.FillByID(AAPOSDataSet.Accounts, ComboBox1.Text, ComboBox2.Text, ComboBox2.Text)
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

    Private Sub frmAccountpayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
        Try
            AccountsTableAdapter.Fill(AAPOSDataSet.Accounts)
            For i = 0 To AAPOSDataSet.Accounts.Count - 1
                ComboBox1.Items.Add(AAPOSDataSet.Accounts.Rows(i)("ID_No").ToString)
                ComboBox2.Items.Add(AAPOSDataSet.Accounts.Rows(i)("Cel_No").ToString)
                ComboBox2.Items.Add(AAPOSDataSet.Accounts.Rows(i)("Alternative").ToString)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay.Click
        If txtname.Text = "" Then
            MessageBox.Show("Please retrieve the client information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Form1.ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please enter all the items you require to sell", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Reference As Integer = 0
        Form1.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        '  Dim change As Double = Val(txttotals.Text) - Val(total)
        Form1.StatusTableAdapter.Fill(AAPOSDataSet.Status)
        Form1.Status = AAPOSDataSet.Status.Rows(0)("VAT").ToString()
        If Form1.Status = "ON" Then
            Form1.VAT = Form1.total * 0.14
        Else
            Form1.VAT = 0
        End If
        'Dim VAT As Double = Val (

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        Form1.TotalsTableAdapter.Insert(Reference, Form1.count.ToString("0.00"), Form1.VAT, Form1.total.ToString("0.00"), Form1.total.ToString("0.00"), "R0.00", "ACCOUNT", Form1.ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", txtID2.Text, "", "")

        Dim COUNT2 As Integer = Form1.ListBox1.Items.Count()
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add("")
        Form1.Company_DetailsTableAdapter.Fill(AAPOSDataSet.Company_Details)
        Dim Company_Reg As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString()
        Dim Company_Name As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString()
        Dim Physical_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString()
        Dim Contact_No As String = AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString()
        Dim Email_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString()

        Form1.ListBox3.Items.Add("                            " & Physical_Address)
        ' ListBox3.Items.Add("                           SHOP NO 03 STAND 1193/1194")
        Form1.ListBox3.Items.Add("                           CONTACT US ON : " & Contact_No)
        Form1.ListBox3.Items.Add("                    " & Company_Name & " REG " & Company_Reg)
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add(" ORDER NUMBER/REF NUMBER : " & Reference)
        Form1.ListBox3.Items.Add("------------------------------------------------------------------------------------")
        Form1.ListBox3.Items.Add("")
        Form1.ListBox3.Items.Add(" LIST OF ITEMS")
        Form1.ListBox3.Items.Add("")

        'For I = 0 To COUNT2 - 1
        '    Dim TTT As String = ListBox1.Items(I)
        '    ListBox3.Items.Add(TTT)
        'Next
        ' ListBox3.Items.Add(ListBox1.Text)
        Form1.ListBox4.Items.Add("------------------------------------------------------------------------------------")
        Form1.ListBox4.Items.Add(" TOTAL : " & Form1.lblTotal.Text)
        Form1.ListBox4.Items.Add(" PAYMENT TYPE: " & "ACCOUNT")
        If Form1.Status = "ON" Then
            Form1.ListBox4.Items.Add(" TOTAL inclu  : " & "R" & Val(Form1.total + Form1.VAT))
        Else
            Form1.ListBox4.Items.Add(" TOTAL Exclu  : " & "R" & Val(Form1.total))
        End If
        Form1.ListBox4.Items.Add("------------------------------------------------------------------------------------")
        Form1.ListBox4.Items.Add("")
        Form1.ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
        Form1.ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
        Form1.ListBox4.Items.Add("")

        Form1.ListBox4.Items.Add("                             THANKS AND ENJOY")
        Form1.ListBox4.Items.Add("")
        Form1.ListBox4.Items.Add("")
        Form1.StatusTableAdapter.Fill(AAPOSDataSet.Status)
        Form1.Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()

        If Form1.Status = "ON" Then
            Form1.PrintDocument1.Print()
        Else

        End If
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.Label12.Text = "R0.00"
        Form1.txttotals.Text = ""
        Form1.lblSubTotal.Text = "R0.00"
        Form1.lblTotal.Text = "R0.00"
        'lblTax.Text = "R0.00"
        Form1.total = 0.0
        Form1.count = 0.0
        Form1.SalesTableAdapter.UpdateQueryCASH("ACCOUNT", Reference)
        Form1.SalesTableAdapter.UpdateQueryID(txtID2.Text, Reference)
        Form1.AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
        Form1.TextBox2.Focus()
        Form1.On_Bar = "BAR"
        Form1.itemNo = 0
        Form1.ListBox1.Items.Clear()
        Form1.txtQty.Text = "1"
        frmMorefunctions.Suspend = "OFF"
        Me.Close()

    End Sub
End Class