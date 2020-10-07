Public Class frmMorefunctions
    Public Shared Suspend As String
    Private Sub btnPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrinter.Click
        frmPrinterSettings.Show()
        Me.Close()

    End Sub

    Private Sub frmMorefunctions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Autogen' table. You can move, or remove it, as needed.
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        ' Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        Me.TopMost = True

    End Sub

  
    Private Sub btnSuspendSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuspendSale.Click
        Suspend = "OFF"
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
        SalesTableAdapter.UpdateQueryCASH("PENDING", Reference)
        Form1.ListBox1.Items.Clear()

        Form1.TextBox2.Focus()
        Form1.On_Bar = "BAR"
        Form1.itemNo = 0
        Form1.ListBox1.Items.Clear()
        Form1.txtQty.Text = "1"

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
        Me.Close()

    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnReprintLastSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReprintLastSale.Click
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Dim Reference As Integer = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) - 1
        Try
            Me.SalesTableAdapter.FillByNr(Me.AAPOSDataSet.Sales, Reference)
            Dim Total As Double
            Dim itemNo As String
            Dim discription As String
            Dim Price As String

            For I = 0 To AAPOSDataSet.Sales.Rows.Count - 1
                Price = AAPOSDataSet.Sales.Rows(I)("Selling_Price").ToString
                itemNo = AAPOSDataSet.Sales.Rows(I)("No").ToString
                discription = AAPOSDataSet.Sales.Rows(I)("Description").ToString
                Total = Total + Val(AAPOSDataSet.Sales.Rows(I)("Selling_Price").ToString)
                With Form1.ListBox1
                    Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
                    .Items.Add(item)
                End With
            Next
            Form1.itemNo = AAPOSDataSet.Sales.Rows.Count
            Form1.txttotals.Text = Total
            Form1.total = Total
            Form1.count = Total
            '''''''''''''
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
            Form1.ListBox3.Items.Add("----------------------------------------------------------------")
            Form1.ListBox3.Items.Add("")
            Form1.ListBox3.Items.Add(" LIST OF ITEMS")
            Form1.ListBox3.Items.Add("")

            'For I = 0 To COUNT2 - 1
            '    Dim TTT As String = ListBox1.Items(I)
            '    ListBox3.Items.Add(TTT)
            'Next
            ' ListBox3.Items.Add(ListBox1.Text)
            Form1.ListBox4.Items.Add("----------------------------------------------------------------")
            Form1.ListBox4.Items.Add(" TOTAL : " & Form1.lblTotal.Text)
            Form1.ListBox4.Items.Add(" CASH  : " & "R" & Form1.txttotals.Text)
            Form1.ListBox4.Items.Add(" RETURN: " & Form1.Label12.Text)
            If Form1.Status = "ON" Then
                Form1.ListBox4.Items.Add(" TOTAL inclu  : " & "R" & Val(Total + Form1.VAT))
            Else
                Form1.ListBox4.Items.Add(" TOTAL Exclu  : " & "R" & Val(Total))
            End If
            Form1.ListBox4.Items.Add(" PAYMENT TYPE: " & "CASH")
            Form1.ListBox4.Items.Add("----------------------------------------------------------------")
            Form1.ListBox4.Items.Add("")
            Form1.ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
            Form1.ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
            Form1.ListBox4.Items.Add("")

            Form1.ListBox4.Items.Add("                             THANKS AND ENJOY")
            Form1.ListBox4.Items.Add("")
            Form1.ListBox4.Items.Add("")

            Form1.StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Form1.Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()
            Dim Status2 = AAPOSDataSet.Status.Rows(0)("AUTO").ToString()
            If Status2 = "RESTAURANT" Then
                Form1.PrintDocument1.Print()
            End If
            If Form1.Status = "ON" Then
                Form1.PrintDocument1.Print()
            Else

            End If


            'PrintDocument1.Print()
            Form1.ListBox2.Items.Clear()
            Form1.ListBox3.Items.Clear()
            Form1.ListBox1.Items.Clear()
            Form1.ListBox4.Items.Clear()
            'Label12.Text = "R0.00"
            Form1.Label12.Text = "R0.00"
            Form1.txttotals.Text = ""
            Form1.lblSubTotal.Text = "R0.00"
            Form1.lblTotal.Text = "R0.00"
            'lblTax.Text = "R0.00"
            Total = 0.0
            Form1.count = 0.0





            Form1.TextBox2.Focus()
            Form1.On_Bar = "BAR"
            Form1.itemNo = 0
            Form1.ListBox1.Items.Clear()
            frmMorefunctions.Suspend = "OFF"
            Me.Close()































        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.Click
        frmAccountpayment.Show()
        Me.Hide()

    End Sub

    Private Sub btnExpenses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpenses.Click
        frmExpenses.Show()
        Me.Close()
    End Sub

    Private Sub btnViewPendingSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewPendingSales.Click
        frmPendingSales.Show()
        Me.Close()
    End Sub
End Class