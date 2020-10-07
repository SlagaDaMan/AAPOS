Public Class Stock_Items

    Private Sub Stock_Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.SupplierDetails' table. You can move, or remove it, as needed.
        ' Me.SupplierDetailsTableAdapter.Fill(Me.AAPOSDataSet.SupplierDetails)
        'TODO: This line of code loads data into the 'AAPOSDataSet.SupplierTransections' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.
        '  Me.TotalsTableAdapter.Fill(Me.AAPOSDataSet.Totals)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        ' Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Autogen' table. You can move, or remove it, as needed.
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        TxtItemDescription.Enabled = False
        TxtItemStockPrice.Enabled = False
        TxtItemSellingPrice.Enabled = False
        TxtNumberOfItems.Enabled = False
        Label5.Visible = False
        txtref.Visible = False
        btnUpdateRe.Visible = False
        GroupBox1.Enabled = False

        Try
            Me.SupplierDetailsTableAdapter.Fill(Me.AAPOSDataSet.SupplierDetails)
            For I = 0 To AAPOSDataSet.SupplierDetails.Rows.Count - 1
                Dim REF As String = AAPOSDataSet.SupplierDetails.Rows(I)("CompanyName").ToString
                cmbSuppliers.Items.Add(REF)
            Next
        Catch ex As Exception

        End Try
        cmbSuppliers.Enabled = False
        If frmLogin.profile = "STOCK MANAGER" Then
            cmboption.Items.Add("ADD STOCK")
            'cmboption.Items.Add("REMOVE STOCK")
            cmboption.Items.Add("CHECK STOCK")
            cmboption.Items.Add("UPDATE SELLING\STOCK PRICE")
            cmboption.Items.Add("RETURNS")
            cmboption.Items.Add("DAMAGES")
            cmboption.Items.Add("UPDATE ALL")
            btnExtraFuctions.Visible = False
        Else
            cmboption.Items.Add("ADD STOCK")
            cmboption.Items.Add("REMOVE STOCK")
            cmboption.Items.Add("CHECK STOCK")
            cmboption.Items.Add("UPDATE SELLING\STOCK PRICE")
            cmboption.Items.Add("RETURNS")
            cmboption.Items.Add("DAMAGES")
            cmboption.Items.Add("UPDATE ALL")
            btnExtraFuctions.Visible = True
        End If
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtItemBarcode.Text = "" Then
            MessageBox.Show("Please enter the barcode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If TxtItemDescription.Text = "" Then
            MessageBox.Show("Please enter the item description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If TxtItemSellingPrice.Text = "" Then
            MessageBox.Show("Please enter the item selling price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TxtItemBarcode.Text)
        If AAPOSDataSet.Stock_Items.Count = 1 Then
            Dim count1 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) + Val(TxtNumberOfItems.Text)
            Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count1, TxtItemBarcode.Text)
            Dim CurrentDate1 As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
            If cmbCredit.Text = "YES" Then

                Me.SupplierTransectionsTableAdapter.InsertQueryCredit(cmbSuppliers.Text, txttotalAm.Text, "0", "Credit", CurrentDate1, frmLogin.name & " " & frmLogin.surname, TxtItemBarcode.Text, TxtNumberOfItems.Text)

                Me.SupplierDetailsTableAdapter.FillByCompanyName(Me.AAPOSDataSet.SupplierDetails, cmbSuppliers.Text)
                SupplierDetailsTableAdapter.UpdateQueryBalance(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Balance").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
                SupplierDetailsTableAdapter.UpdateQueryCredit(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Credit").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
            Else
                Me.SupplierTransectionsTableAdapter.InsertQueryCredit(cmbSuppliers.Text, txttotalAm.Text, "0", "Debit", CurrentDate1, frmLogin.name & " " & frmLogin.surname, TxtItemBarcode.Text, TxtNumberOfItems.Text)

            End If
            MessageBox.Show(TxtNumberOfItems.Text & " Items have been successfully added, current total is : " & count1)
           
            Exit Sub
        End If

        Dim count As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Me.Stock_ItemsTableAdapter.Insert(count, TxtItemBarcode.Text, UCase(TxtItemDescription.Text), TxtItemStockPrice.Text, TxtItemSellingPrice.Text, "", TxtNumberOfItems.Text, txtLinkBarcode.Text, txtTotal.Text, "", "")
        Dim CurrentDate As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
        If cmbCredit.Text = "YES" Then

            Me.SupplierTransectionsTableAdapter.InsertQueryCredit(cmbSuppliers.Text, txttotalAm.Text, "0", "Credit", CurrentDate, frmLogin.name & " " & frmLogin.surname, TxtItemBarcode.Text, TxtNumberOfItems.Text)
            Me.SupplierDetailsTableAdapter.FillByCompanyName(Me.AAPOSDataSet.SupplierDetails, cmbSuppliers.Text)
            SupplierDetailsTableAdapter.UpdateQueryBalance(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Balance").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
            SupplierDetailsTableAdapter.UpdateQueryCredit(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Credit").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
        Else
            Me.SupplierTransectionsTableAdapter.InsertQueryCredit(cmbSuppliers.Text, txttotalAm.Text, "0", "Debit", CurrentDate, frmLogin.name & " " & frmLogin.surname, TxtItemBarcode.Text, TxtNumberOfItems.Text)
        End If
        AutogenTableAdapter.UpdateQueryUsers(count, 1)
        MessageBox.Show("Items has been successfully added", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TxtItemDescription.Text = ""
        TxtItemStockPrice.Text = ""
        TxtItemSellingPrice.Text = ""
        TxtNumberOfItems.Text = ""
        TxtItemBarcode.Text = ""
        txtLinkBarcode.Text = ""
        txtTotal.Text = ""
        txtPer.Text = ""
        txttotalAm.Text = ""
        TxtItemBarcode.Focus()
        cmbCredit.SelectedIndex = -1
        cmbSuppliers.SelectedIndex = -1
        TxtItemDescription.Text = ""
        TxtItemStockPrice.Text = ""
        TxtItemSellingPrice.Text = ""
        TxtNumberOfItems.Text = ""
        TxtItemBarcode.Text = ""
        txtLinkBarcode.Text = ""
        txtTotal.Text = ""
        txtPer.Text = ""
        txttotalAm.Text = ""
        TxtItemBarcode.Focus()
        cmbCredit.SelectedIndex = -1
        cmbSuppliers.SelectedIndex = -1
    End Sub

    Private Sub TxtItemBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtItemBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TxtItemBarcode.Text)
            Dim count As Integer = AAPOSDataSet.Stock_Items.Count
            If count >= 1 Then
                TxtItemDescription.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                TxtItemStockPrice.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString
                TxtItemSellingPrice.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString
                txtLinkBarcode.Text = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
                txtTotal.Text = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
                ' TxtItemDescription.Text = AAPOSDataSet.Autogen.Rows(0)("Master_Item").ToString
                ' TxtNumberOfItems.Text = AAPOSDataSet.Autogen.Rows(0)("Optional_Item1").ToString
                BtnAdd.Enabled = False
                btnUpdate.Enabled = True
                If cmboption.Text = "ADD STOCK" Then
                    TxtNumberOfItems.Enabled = True
                    BtnAdd.Enabled = True
                End If
                If cmboption.Text = "REMOVE STOCK" Then
                    TxtNumberOfItems.Enabled = True
                End If
                If cmboption.Text = "UPDATE SELLING\STOCK PRICE" Then
                    TxtItemSellingPrice.Enabled = True
                    TxtItemStockPrice.Enabled = True
                    TxtNumberOfItems.Enabled = False
                End If
                If cmboption.Text = "CHECK STOCK" Then
                    TxtItemSellingPrice.Enabled = False
                    TxtItemStockPrice.Enabled = False
                    TxtNumberOfItems.Enabled = False
                    TxtNumberOfItems.Text = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString
                    TxtNumberOfItems.Enabled = False
                End If
                If cmboption.Text = "UPDATE ALL" Then
                    TxtItemSellingPrice.Enabled = True
                    TxtItemStockPrice.Enabled = True
                    TxtNumberOfItems.Enabled = True
                    TxtNumberOfItems.Text = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString
                    TxtNumberOfItems.Enabled = True
                    GroupBox2.Enabled = True
                    txtLinkBarcode.Enabled = True
                    txtTotal.Enabled = True
                End If
            Else
                MessageBox.Show("New Item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtItemDescription.Enabled = True
                TxtItemStockPrice.Enabled = True
                TxtItemSellingPrice.Enabled = True
                TxtNumberOfItems.Enabled = True
                BtnAdd.Enabled = True
                btnUpdate.Enabled = False
            End If
        End If
    End Sub

    Private Sub TxtItemBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemBarcode.TextChanged

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If TxtItemBarcode.Text = "" Then
            MessageBox.Show("Please enter the item barcode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtItemBarcode.Focus()
            Exit Sub
        End If
        
      
        If cmboption.Text = "ADD STOCK" Then
            If TxtNumberOfItems.Text = "" Then
                MessageBox.Show("Please enter the number of items you would like to add to the store", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtNumberOfItems.Focus()
                Exit Sub
            End If
            Try
                'Me.SupplierTransectionsTableAdapter.Fill(Me.AAPOSDataSet.SupplierTransections)
                Me.SupplierDetailsTableAdapter.FillByCompanyName(Me.AAPOSDataSet.SupplierDetails, cmbSuppliers.Text)
                Dim CompanyRegNumber, VatNum, CompanyAddress, CompanyAddress2, CompanyAddress3, Tel, Fax, Internet, Email, CompanyName, Balance, Credit As String

                CompanyRegNumber = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyRegNumber").ToString)
                VatNum = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("VatNum").ToString)
                CompanyAddress = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress").ToString)
                CompanyAddress2 = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress2").ToString)
                CompanyAddress3 = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyAddress3").ToString)
                Tel = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Tel").ToString)
                Fax = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Fax").ToString)
                Internet = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Internet").ToString)
                Email = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Email").ToString)
                CompanyName = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("CompanyName").ToString)
                Balance = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Balance").ToString)
                Credit = UCase(AAPOSDataSet.SupplierDetails.Rows(0)("Credit").ToString)
                'txtPayOut.Text = ""
                Dim CurrentDate As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
                If cmbCredit.Text = "YES" Then
                    Me.SupplierTransectionsTableAdapter.InsertQueryCredit(cmbSuppliers.Text, txttotalAm.Text, "0", "Credit", CurrentDate, frmLogin.name & " " & frmLogin.surname, TxtItemBarcode.Text, TxtNumberOfItems.Text)
                    Me.SupplierDetailsTableAdapter.FillByCompanyName(Me.AAPOSDataSet.SupplierDetails, cmbSuppliers.Text)
                    SupplierDetailsTableAdapter.UpdateQueryBalance(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Balance").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
                    SupplierDetailsTableAdapter.UpdateQueryCredit(Val(AAPOSDataSet.SupplierDetails.Rows(0)("Credit").ToString) + Val(txttotalAm.Text), cmbSuppliers.Text)
                End If
                Me.SupplierTransectionsTableAdapter.Insert(UCase(cmbSuppliers.Text), UCase(CompanyRegNumber), UCase(CompanyAddress), UCase(CompanyAddress2), UCase(CompanyAddress3), UCase(Val(TxtItemStockPrice.Text) * Val(TxtNumberOfItems.Text)), UCase(Val(Balance) + Val(Val(TxtItemStockPrice.Text) * Val(TxtNumberOfItems.Text))), UCase(0), UCase(Tel), UCase(Fax), LCase(Internet), LCase(Email), VatNum, "Credit", "", frmLogin.txtUserName.Text, TxtItemBarcode.Text, Val(TxtItemStockPrice.Text) * Val(TxtNumberOfItems.Text))
                SupplierDetailsTableAdapter.UpdateQueryBalance(Val(Balance) + Val(Val(TxtItemStockPrice.Text) * Val(TxtNumberOfItems.Text)), cmbSuppliers.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TxtItemBarcode.Text)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) + Val(TxtNumberOfItems.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, TxtItemBarcode.Text)
                MessageBox.Show(TxtNumberOfItems.Text & " Items have been successfully added, current total is : " & count)
                ' MessageBox.Show("Items has been successfully added", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtItemDescription.Text = ""
                TxtItemStockPrice.Text = ""
                TxtItemSellingPrice.Text = ""
                TxtNumberOfItems.Text = ""
                TxtItemBarcode.Text = ""
                txtPer.Text = ""
                txttotalAm.Text = ""
                TxtItemBarcode.Focus()
                cmbCredit.SelectedIndex = -1
                cmbSuppliers.SelectedIndex = -1
            Catch ex As Exception

            End Try
            Exit Sub
        End If

        If cmboption.Text = "REMOVE STOCK" Then
            If TxtNumberOfItems.Text = "" Then
                MessageBox.Show("Please enter the number of items you would like to add to the store", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtNumberOfItems.Focus()
                Exit Sub
            End If
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TxtItemBarcode.Text)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(TxtNumberOfItems.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, TxtItemBarcode.Text)
                MessageBox.Show(TxtNumberOfItems.Text & " Items have been successfully removed from, current total is : " & count)
                ' MessageBox.Show("Items has been successfully added", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtItemDescription.Text = ""
                TxtItemStockPrice.Text = ""
                TxtItemSellingPrice.Text = ""
                TxtNumberOfItems.Text = ""
                TxtItemBarcode.Text = ""
                TxtItemBarcode.Focus()
                cmbCredit.SelectedIndex = -1
                cmbSuppliers.SelectedIndex = -1
            Catch ex As Exception

            End Try
            Exit Sub
        End If


        If cmboption.Text = "UPDATE SELLING\STOCK PRICE" Then
            Try
                Me.Stock_ItemsTableAdapter.UpdateQuerySellingstock(TxtItemStockPrice.Text, TxtItemSellingPrice.Text, TxtItemBarcode.Text)
                MessageBox.Show("Item prices have been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtItemDescription.Text = ""
                TxtItemStockPrice.Text = ""
                TxtItemSellingPrice.Text = ""
                TxtNumberOfItems.Text = ""
                TxtItemBarcode.Text = ""
                TxtItemBarcode.Focus()
                txtLinkBarcode.Text = ""
                txtTotal.Text = ""
                txtPer.Text = ""
                txttotalAm.Text = ""
                cmbCredit.SelectedIndex = -1
                cmbSuppliers.SelectedIndex = -1
            Catch ex As Exception

            End Try
            Exit Sub
        End If
        If cmboption.Text = "UPDATE ALL" Then
            Try
                Me.Stock_ItemsTableAdapter.UpdateQueryALL(UCase(TxtItemDescription.Text), TxtItemStockPrice.Text, TxtItemSellingPrice.Text, "", TxtNumberOfItems.Text, txtLinkBarcode.Text, txtTotal.Text, TxtItemBarcode.Text)
                MessageBox.Show("Updated successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtItemDescription.Text = ""
                TxtItemStockPrice.Text = ""
                TxtItemSellingPrice.Text = ""
                TxtNumberOfItems.Text = ""
                TxtItemBarcode.Text = ""
                TxtItemBarcode.Focus()
                txtLinkBarcode.Text = ""
                txtTotal.Text = ""
                txtPer.Text = ""
                txttotalAm.Text = ""
                cmbCredit.SelectedIndex = -1
                cmbSuppliers.SelectedIndex = -1

            Catch ex As Exception

            End Try
            Exit Sub
        End If
    End Sub


    Private Sub cmboption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmboption.SelectedIndexChanged
        If cmboption.Text = "DAMAGES" Then
            Label5.Visible = True
            txtref.Visible = True
            btnUpdateRe.Visible = True
        ElseIf cmboption.Text = "RETURNS" Then
            Label5.Visible = True
            txtref.Visible = True
            btnUpdateRe.Visible = True
        Else
            Label5.Visible = False
            txtref.Visible = False
            btnUpdateRe.Visible = False
        End If
        GroupBox1.Enabled = True
        TxtItemStockPrice.Text = ""
        TxtItemSellingPrice.Text = ""
        TxtNumberOfItems.Text = ""
        TxtItemBarcode.Text = ""
        txtPer.Text = ""
        txttotalAm.Text = ""
        TxtItemDescription.Text = ""
        TxtItemStockPrice.Enabled = False
        TxtItemSellingPrice.Enabled = False
        TxtNumberOfItems.Enabled = False
        'TxtItemBarcode.Enabled = False
        TxtItemDescription.Enabled = True
        txtLinkBarcode.Text = ""
        txtTotal.Text = ""
        cmbCredit.SelectedIndex = -1
        cmbSuppliers.SelectedIndex = -1
        MessageBox.Show("Please scan barcode", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TxtItemBarcode.Focus()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click

        If frmLogin.profile = "STOCK MANAGER" Then
            Me.Close()
            Exit Sub
        Else
            Me.Close()
            frmMainScreen.Show()
        End If
 

    End Sub

    Private Sub btnTotal_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal_Stock.Click
        Stock_Stats.Show()
        Me.Close()

    End Sub

    'Private Sub chkLink_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If chkLink.Checked = True Then
    '        GroupBox2.Enabled = True
    '        txtLinkBarcode.Text = ""
    '        txtTotal.Text = ""
    '    End If
    'End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If TxtItemBarcode.Text = "" Then
            MessageBox.Show("Please enter the barcode you would like to link", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtItemDescription.Text = "" Then
            MessageBox.Show("Please retrieve the item you would like to link", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        frmMenu.Show()

    End Sub

    Private Sub btnUpdateRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateRe.Click
        If cmboption.Text = "RETURNS" Then
            SalesTableAdapter.UpdateQuerySalesStatus("RETURNS", txtref.Text)
            TotalsTableAdapter.UpdateQueryStatus("RETURNS", txtref.Text)
            MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf cmboption.Text = "DAMAGES" Then
            SalesTableAdapter.UpdateQuerySalesStatus("DAMAGES", txtref.Text)
            TotalsTableAdapter.UpdateQueryStatus("DAMAGES", txtref.Text)
            MessageBox.Show("Successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub TxtItemSellingPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItemSellingPrice.TextChanged
        txtPer.Text = String.Format("{0:n}", Convert.ToDouble(Val(TxtItemSellingPrice.Text) - Val(TxtItemStockPrice.Text)))

    End Sub

    Private Sub TxtNumberOfItems_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNumberOfItems.TextChanged
        Dim Subt As Double = Val(TxtItemSellingPrice.Text) - Val(TxtItemStockPrice.Text)
        txttotalAm.Text = String.Format("{0:n}", Convert.ToDouble(Subt * Val(TxtNumberOfItems.Text)))

    End Sub

    Private Sub btnExtraFuctions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtraFuctions.Click
        Advanced_Options.Show()

    End Sub

    Private Sub cmbCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCredit.SelectedIndexChanged
        If cmbCredit.Text = "YES" Then
            cmbSuppliers.Enabled = True
        End If
    End Sub

    Private Sub txtref_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtref.TextChanged

    End Sub
End Class