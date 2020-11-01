Public Class Form1
    Public Shared amount As Double = 14.0
    Public Shared count As Double = 0.0
    Public Shared tax As Double
    Public Shared VAT As Double
    Public Shared total As Double = 0.0
    Public Shared itemNo As Integer = 0
    Public Shared QTY, Check_Price, Status As String
    Public Shared On_Bar As String = "BAR"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet1.Promotions' table. You can move, or remove it, as needed.
        ' Me.PromotionsTableAdapter.Fill(Me.AAPOSDataSet1.Promotions)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Till_Setup' table. You can move, or remove it, as needed.
        Me.Till_SetupTableAdapter.Fill(Me.AAPOSDataSet.Till_Setup)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Company_Details' table. You can move, or remove it, as needed.
        Me.Company_DetailsTableAdapter.Fill(Me.AAPOSDataSet.Company_Details)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Status' table. You can move, or remove it, as needed.
        Me.StatusTableAdapter.Fill(Me.AAPOSDataSet.Status)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.AAPOSDataSet.Menu)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Autogen' table. You can move, or remove it, as needed.
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Totals' table. You can move, or remove it, as needed.
        Me.TotalsTableAdapter.Fill(Me.AAPOSDataSet.Totals)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        lblTax.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        lblSubTotal.Visible = False
        TextBox2.Enabled = False
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        ' Label14.Visible = False
        txtVoidPass.Visible = False
        ' GroupBox1.Enabled = False
        txtQty.Text = "1"
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Label1.Text = Label1.Text + " " + TILL_NO
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item").ToString)
        btn1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item2").ToString)
        btn2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item3").ToString)
        btn3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item4").ToString)
        btn4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item5").ToString)
        btn5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item6").ToString)
        btn6.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item7").ToString)
        btn7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item8").ToString)
        btn8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item9").ToString)
        btn9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item10").ToString)
        btn10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item11").ToString)
        btn11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item12").ToString)
        btn12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item13").ToString)
        btn13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item14").ToString)
        btn14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item15").ToString)
        btn15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item16").ToString)
        btn16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item17").ToString)
        btn17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item18").ToString)
        btn18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item19").ToString)
        btn19.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item21").ToString)
        btn21.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item22").ToString)
        btn22.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        'Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item23").ToString)
        'btn23.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        'Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(0)("item24").ToString)
        'btn24.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        lblName.Text = "LOGIN NAME : " & frmLogin.name & " " & frmLogin.surname

    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown


        If e.KeyCode = Keys.Enter Then
            If Check_Price = "ON" Then
                Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, TextBox2.Text)
                PromotionsTableAdapter.FillByBarcode(AAPOSDataSet1.Promotions, TextBox2.Text)

                If AAPOSDataSet1.Promotions.Count > 0 Then
                    AAPOSDataSet1.Promotions.Rows(0)("Status").ToString()
                End If

                Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
                If count1 = 0 Then
                    MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Label12.Text = "R0.00 "
                Dim Price As Double
                Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                Dim CheckPromotion = fuctions.GetDiscountPrice(TextBox2.Text)
                If CheckPromotion = 0 Then
                    Price = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
                Else
                    Price = CheckPromotion * Val(txtQty.Text)
                End If


                Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
                itemNo = itemNo + 1
                ' ListBox2.Items.Add(itemNo.ToString + "     " + TextBox2.Text + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
                ' ListBox1.Items.Add(discription)
                With ListBox1
                    Dim item As New ListViewItem(New String() {itemNo.ToString, discription, txtQty.Text, "R " & Price})
                    .Items.Add(item)
                End With

                count = count + Price
                lblSubTotal.Text = "R" + count.ToString("0.00")
                ' tax = count * 0.14
                ' lblTax.Text = "R" + tax.ToString("0.00")
                total = count
                lblTotal.Text = "R" + total.ToString("0.00")
                TextBox2.Text = ""
                Check_Price = "OFF"
                Exit Sub
            End If
            If QTY = "ON" Then
                txtQty.Text = "1"
                txtQty.Focus()
            ElseIf QTY = "OFF" Then
                ''''
                ' MenuTableAdapter.Fill(AAPOSDataSet.Menu)
                Dim Code As String = TextBox2.Text

                txtQty.Text = "1"
                Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
                Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
                If count1 = 0 Then
                    MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Label12.Text = "R0.00 "
                Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
                Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
                Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
                Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
                itemNo = itemNo + 1
                ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
                With ListBox1
                    Dim item As New ListViewItem(New String() {itemNo.ToString, discription, txtQty.Text, "R " & Price})
                    .Items.Add(item)
                End With
                'ListBox1.Items.Add(discription)
                count = count + Price
                lblSubTotal.Text = "R" + count.ToString("0.00")
                ' tax = count * 0.14
                ' lblTax.Text = "R" + tax.ToString("0.00")
                total = count
                lblTotal.Text = "R" + total.ToString("0.00")
                Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
                Dim day, hh, mm, year, month, ref As String
                year = a.Substring(2, 2)
                month = a.Substring(5, 2)
                day = a.Substring(8, 2)
                hh = a.Substring(12, 2)
                mm = a.Substring(15, 2)
                ref = year + month + day
                Dim count2 As Integer = 0
                Dim Reference As Integer = 0
                Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
                count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
                Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
                AutogenTableAdapter.UpdateQueryUsers(count2, 1)

                If frmMorefunctions.Suspend = "ON" Then
                    Reference = frmPendingSales.Pending_Ref
                End If
                Dim strHostName As String = System.Net.Dns.GetHostName()
                Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
                Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
                Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
                Dim DayName As String = Format(Now, "yyyy/MM/ddd")
                Dim DayNameLength As Integer = DayName.Length
                Dim ShortDayName As String = DayName.Substring(DayName.Length - 3, 3)
                Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, ShortDayName, "")


                'New Stock packs and 24's
                If Link_Code = "" Then
                    Try
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                        Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
                    Catch ex As Exception
                    End Try
                Else
                    For i = 1 To Val(txtQty.Text)
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                        Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                        Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
                    Next
                End If
                TextBox2.Text = ""
                TextBox2.Focus()
                ''''
            End If
            QTY = "OFF"
            Check_Price = "OFF"
            txtQty.Text = "1"
        End If
        If e.KeyCode = Keys.F3 Then
            txttotals.Focus()
        End If
        'Check Price
        If e.KeyCode = Keys.C Then
            Check_Price = "ON"
        End If
        'Delete List
        If e.KeyCode = Keys.D Then
            ListBox2.Items.Clear()
            ListBox1.Items.Clear()
            Label12.Text = "R0.00"
            txttotals.Text = ""
            lblSubTotal.Text = "R0.00"
            lblTotal.Text = "R0.00"
            ' lblTax.Text = "R0.00"
            total = 0.0
            count = 0.0
        End If
        If e.KeyCode = Keys.Q Then
            QTY = "ON"
            TextBox2.Text = ""
            TextBox2.Focus()
            TextBox2.Text = ""
            TextBox2.Focus()
        End If

        If e.KeyCode = Keys.Q Then
            QTY = "ON"
            TextBox2.Text = ""
            TextBox2.Focus()
            TextBox2.Text = ""
            TextBox2.Focus()
        End If
        If TextBox2.Text = "Q" Then
            TextBox2.Text = ""
        End If

        If e.KeyCode = Keys.F4 Then
            If ListBox1.Items.Count = 0 Then
                MessageBox.Show("Please enter all the items you require to sell", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("VAT").ToString()
            If Status = "ON" Then
                VAT = total * 0.14
            Else
                VAT = 0
            End If
            '  Dim change As Double = Val(txttotals.Text) - Val(total)

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
            Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
            Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
            TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), VAT, total.ToString("0.00"), total.ToString("0.00"), "R0.00", "ELECTRONICALLY", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", TILL_NO, "", "")

            Dim COUNT2 As Integer = ListBox1.Items.Count()
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            Company_DetailsTableAdapter.Fill(AAPOSDataSet.Company_Details)
            Dim Company_Reg As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString()
            Dim Company_Name As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString()
            Dim Physical_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString()
            Dim Contact_No As String = AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString()
            Dim Email_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString()

            ListBox3.Items.Add("                            " & Physical_Address)
            ' ListBox3.Items.Add("                           SHOP NO 03 STAND 1193/1194")
            ListBox3.Items.Add("                           CONTACT US ON : " & Contact_No)
            ListBox3.Items.Add("                    " & Company_Name & " REG " & Company_Reg)

            ListBox3.Items.Add("")
            ListBox3.Items.Add(" ORDER NUMBER/REF NUMBER : " & Reference)
            ListBox3.Items.Add("------------------------------------------------------------------------------------")
            ListBox3.Items.Add("")
            ListBox3.Items.Add(" LIST OF ITEMS")
            ListBox3.Items.Add("")

            'For I = 0 To COUNT2 - 1
            '    Dim TTT As String = ListBox1.Items(I)
            '    ListBox3.Items.Add(TTT)
            'Next
            ' ListBox3.Items.Add(ListBox1.Text)
            ListBox4.Items.Add("------------------------------------------------------------------------------------")
            ListBox4.Items.Add(" TOTAL : " & lblTotal.Text)
            ListBox4.Items.Add(" CASH  : " & txttotals.Text)
            ListBox4.Items.Add(" RETURN: " & Label12.Text)
            ListBox4.Items.Add(" PAYMENT TYPE: " & "EFT")
            ListBox4.Items.Add("------------------------------------------------------------------------------------")
            ListBox4.Items.Add("")
            ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
            ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
            ListBox4.Items.Add("")

            ListBox4.Items.Add("                             THANKS AND ENJOY")
            ListBox4.Items.Add("")
            ListBox4.Items.Add("")
            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()
            Dim Status2 = AAPOSDataSet.Status.Rows(0)("AUTO").ToString()
            If Status2 = "RESTAURANT" Then
                PrintDocument1.Print()
            End If
            If Status = "ON" Then
                PrintDocument1.Print()
            Else

            End If
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox1.Items.Clear()
            ListBox4.Items.Clear()
            Label12.Text = "R0.00"
            txttotals.Text = ""
            lblSubTotal.Text = "R0.00"
            lblTotal.Text = "R0.00"
            'lblTax.Text = "R0.00"
            total = 0.0
            count = 0.0

            SalesTableAdapter.UpdateQueryCASH("ELECTRONICALLY", Reference)
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
            TextBox2.Focus()
            On_Bar = "BAR"
            itemNo = 0
            ListBox1.Items.Clear()
            frmMorefunctions.Suspend = "OFF"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "Q" Then
            TextBox2.Text = ""
        End If
        If TextBox2.Text = "C" Then
            TextBox2.Text = ""
        End If
        If TextBox2.Text = "D" Then
            TextBox2.Text = ""
        End If
        If TextBox2.Text = "q" Then
            TextBox2.Text = ""
        End If
        If TextBox2.Text = "c" Then
            TextBox2.Text = ""
        End If
        If TextBox2.Text = "d" Then
            TextBox2.Text = ""
        End If
        'TextBox2.Text = "" Then
        '   TextBox2.Text = ""
        '   End If    If TextBox2.Text = "" Then
        '   TextBox2.Text = ""
        '   End If
        '   If
    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' GroupBox1.Enabled = True
        TextBox2.Focus()
        txtQty.Text = "1"
        On_Bar = "BAR"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If frmLogin.profile = "SALES" Then
            Me.Close()
            Exit Sub
        Else
            Me.Close()
            frmMainScreen.Show()
        End If

    End Sub

    Private Sub txttotals_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttotals.KeyDown
        If e.KeyCode = Keys.Enter Then
            '
            If Val(txttotals.Text) < count Then
                MessageBox.Show("Cash can't be less than the total,Please enter the correct amount to complete transcation")
                Exit Sub
            End If
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            Dim change As Double = Val(txttotals.Text) - Val(count)
            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("VAT").ToString()
            If Status = "ON" Then
                VAT = total * 0.14
            Else
                VAT = 0
            End If

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
            Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
            Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
            TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), VAT, count.ToString("0.00"), txttotals.Text, change, "CASH", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", TILL_NO, "", "")
            ListBox2.Items.Clear()
            '''''''''
            Dim COUNT2 As Integer = ListBox1.Items.Count()
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            Company_DetailsTableAdapter.Fill(AAPOSDataSet.Company_Details)
            Dim Company_Reg As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString()
            Dim Company_Name As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString()
            Dim Physical_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString()
            Dim Contact_No As String = AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString()
            Dim Email_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString()

            ListBox3.Items.Add("                            " & Physical_Address)
            ' ListBox3.Items.Add("                           SHOP NO 03 STAND 1193/1194")
            ListBox3.Items.Add("                           CONTACT US ON : " & Contact_No)
            ListBox3.Items.Add("                    " & Company_Name & " REG " & Company_Reg)

            ListBox3.Items.Add("")
            ListBox3.Items.Add(" ORDER NUMBER/REF NUMBER : " & Reference)
            ListBox3.Items.Add("----------------------------------------------------------------")
            ListBox3.Items.Add("")
            ListBox3.Items.Add(" LIST OF ITEMS")
            ListBox3.Items.Add("")

            'For I = 0 To COUNT2 - 1
            '    Dim TTT As String = ListBox1.Items(I)
            '    ListBox3.Items.Add(TTT)
            'Next
            ' ListBox3.Items.Add(ListBox1.Text)
            ListBox4.Items.Add("----------------------------------------------------------------")
            ListBox4.Items.Add(" SUB TOTAL : " & lblTotal.Text)
            ListBox4.Items.Add(" CASH  : " & "R" & txttotals.Text)
            ListBox4.Items.Add(" RETURN: " & Label12.Text)
            If Status = "ON" Then
                ListBox4.Items.Add(" TOTAL inclu  : " & "R" & Val(total + VAT))
            Else
                ListBox4.Items.Add(" TOTAL Exclu  : " & "R" & Val(total))
            End If
            ' Status
            ' ListBox4.Items.Add(" PAYMENT TYPE: " & "CASH")
            ListBox4.Items.Add("----------------------------------------------------------------")
            ListBox4.Items.Add("")
            ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
            ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
            ListBox4.Items.Add("")

            ListBox4.Items.Add("                             THANKS AND ENJOY")
            ListBox4.Items.Add("")
            ListBox4.Items.Add("")
            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()
            Dim Status2 = AAPOSDataSet.Status.Rows(0)("AUTO").ToString()
            If Status2 = "RESTAURANT" Then
                PrintDocument1.Print()
            End If
            If Status = "ON" Then
                PrintDocument1.Print()
            Else

            End If
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox1.Items.Clear()
            ListBox4.Items.Clear()
            'Label12.Text = "R0.00"
            Label12.Text = "R " & change
            txttotals.Text = ""
            lblSubTotal.Text = "R0.00"
            lblTotal.Text = "R0.00"
            'lblTax.Text = "R0.00"
            total = 0.0
            count = 0.0
            SalesTableAdapter.UpdateQueryCASH("CASH", Reference)
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
            TextBox2.Focus()
            On_Bar = "BAR"
            itemNo = 0
            ListBox1.Items.Clear()
            frmMorefunctions.Suspend = "OFF"
        End If
        '

        'Dim Reference As Integer = 0
        'Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        'Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        'Dim change As Double = Val(txttotals.Text) - Val(count)
        'TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), "", count.ToString("0.00"), txttotals.Text, change, "CASH", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", "", "", "")
        'ListBox2.Items.Clear()
        'PrintDocument1.Print()
        'Label12.Text = "R " & change
        'txttotals.Text = ""
        'lblSubTotal.Text = "R0.00"
        'lblTotal.Text = "R0.00"
        '' lblTax.Text = "R0.00"
        'total = 0.0
        'count = 0.0
        'itemNo = 0
        ''Add totals
        'SalesTableAdapter.UpdateQueryCASH("CASH", Reference)
        'AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
        'TextBox2.Focus()
        'End If
    End Sub

    Private Sub ListBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListBox2.KeyDown
        'Label14.Visible = True
        txtVoidPass.Visible = True
        txtVoidPass.Text = ""
        txtVoidPass.Focus()

    End Sub

    Private Sub txtVoidPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoidPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If txtVoidPass.Text = "1320" Then
            If txtVoidPass.Text = "1320" Then
                Dim count12 As Double = 0
                Dim Reference1 As Double = 0
                Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
                count12 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
                Reference1 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
                ' Dim Item As String = ListBox2.SelectedItem.ToString()
                '' Dim itemsub As String = Item.Substring(0, 4)
                Dim item_nr As String
                If ListBox1.SelectedItems.Count > 0 Then
                    item_nr = ListBox1.SelectedItems(0).SubItems(0).Text
                Else
                    MessageBox.Show("Please select the item you would like to void, click void and enter the void password", "Information")
                    Exit Sub
                End If

                If frmMorefunctions.Suspend = "ON" Then
                    Reference1 = frmPendingSales.Pending_Ref
                End If
                SalesTableAdapter.FillByNrRef(AAPOSDataSet.Sales, item_nr, Reference1)
                Dim VOID_Tax As Double = Val(AAPOSDataSet.Sales.Rows(0)("Selling_Price").ToString)
                Dim Qty As Integer = Val(AAPOSDataSet.Sales.Rows(0)("Auto").ToString)
                Dim Product_Code As String = AAPOSDataSet.Sales.Rows(0)("Product_Code").ToString
                Dim DES As String = AAPOSDataSet.Sales.Rows(0)("Description").ToString
                Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Product_Code)
                Dim current_number_of_items As Double = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString
                Dim stock_n_void As Double = current_number_of_items + Qty
                Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(stock_n_void, Product_Code)
                Dim selec As Double = ListBox2.SelectedIndex
                '   ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
                For Each i As ListViewItem In ListBox1.SelectedItems
                    ListBox1.Items.Remove(i)
                Next
                count = count - VOID_Tax
                lblSubTotal.Text = "R" + count.ToString("0.00")
                lblTotal.Text = "R" + count.ToString("0.00")
                SalesTableAdapter.DeleteQuery(item_nr, Reference1)

                ' Label14.Visible = False
                txtVoidPass.Visible = False
                TextBox2.Focus()
                '  ListBox1.Items.Remove(DES)
            Else
                MessageBox.Show("Incorrect Void password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            On_Bar = "BAR"
        End If
        ' End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        '  Dim change As Double = Val(txttotals.Text) - Val(total)

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), "", total.ToString("0.00"), total.ToString("0.00"), "R0.00", "ELECTRONICALLY", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", TILL_NO, "", "")
        ListBox2.Items.Clear()


        ListBox1.Items.Clear()
        Label12.Text = "R0.00"
        txttotals.Text = ""
        lblSubTotal.Text = "R0.00"
        lblTotal.Text = "R0.00"
        'lblTax.Text = "R0.00"
        total = 0.0
        count = 0.0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
        TextBox2.Focus()
        On_Bar = "BAR"

    End Sub

    Private Sub btnPayManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On_Bar = "OFF"
        txttotals.Focus()
    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Check_Price = "ON" Then
                Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, TextBox2.Text)
                Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
                If count1 = 0 Then
                    MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Label12.Text = "R0.00 "
                Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
                Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
                itemNo = itemNo + 1
                'ListBox2.Items.Add(itemNo.ToString + "     " + TextBox2.Text + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
                With ListBox1
                    Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
                    .Items.Add(item)
                End With
                ' ListBox1.Items.Add(discription)
                count = count + Price
                lblSubTotal.Text = "R" + count.ToString("0.00")
                ' tax = count * 0.14
                ' lblTax.Text = "R" + tax.ToString("0.00")
                total = count
                lblTotal.Text = "R" + total.ToString("0.00")
                TextBox2.Text = ""
                Check_Price = "OFF"
                Exit Sub
            End If
            If QTY = "ON" Then
                txtQty.Text = "1"
                txtQty.Focus()
            ElseIf QTY = "OFF" Then


                ''''
                ' MenuTableAdapter.Fill(AAPOSDataSet.Menu)
                Dim Code As String = TextBox2.Text

                '
                Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
                Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
                If count1 = 0 Then
                    MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Label12.Text = "R0.00 "
                Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
                Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
                Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
                Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
                itemNo = itemNo + 1
                ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
                With ListBox1
                    Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
                    .Items.Add(item)
                End With
                '  ListBox1.Items.Add(discription)
                count = count + Price
                lblSubTotal.Text = "R" + count.ToString("0.00")
                ' tax = count * 0.14
                ' lblTax.Text = "R" + tax.ToString("0.00")
                total = count
                lblTotal.Text = "R" + total.ToString("0.00")
                Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
                Dim day, hh, mm, year, month, ref As String
                year = a.Substring(2, 2)
                month = a.Substring(5, 2)
                day = a.Substring(8, 2)
                hh = a.Substring(12, 2)
                mm = a.Substring(15, 2)
                ref = year + month + day
                Dim count2 As Integer = 0
                Dim Reference As Integer = 0
                Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
                count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
                Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
                AutogenTableAdapter.UpdateQueryUsers(count2, 1)

                If frmMorefunctions.Suspend = "ON" Then
                    Reference = frmPendingSales.Pending_Ref
                End If
                Dim strHostName As String = System.Net.Dns.GetHostName()
                Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
                Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
                Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
                Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
                'New Stock packs and 24's
                If Link_Code = "" Then
                    Try
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                        Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
                    Catch ex As Exception
                    End Try
                Else
                    For i = 1 To Val(txtQty.Text)
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                        Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                        Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                        Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                        Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
                    Next
                End If
                TextBox2.Text = ""
                TextBox2.Focus()
                txtQty.Text = "1"
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  Label14.Visible = True
        txtVoidPass.Visible = True
        txtVoidPass.Text = ""
        txtVoidPass.Focus()
        On_Bar = "VOI"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "1"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "1"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "1"
        End If
    End Sub

    Private Sub btnenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "VOI" Then
            If txtVoidPass.Text = "1320" Then
                Dim count12 As Integer = 0
                Dim Reference1 As Integer = 0
                Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
                count12 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
                Reference1 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

                If frmMorefunctions.Suspend = "ON" Then
                    Reference1 = frmPendingSales.Pending_Ref
                End If
                Dim Item As String = ListBox2.SelectedItem.ToString()
                Dim itemsub As String = Item.Substring(0, 4)
                Dim item_nr As String = itemsub.TrimEnd()
                SalesTableAdapter.FillByNrRef(AAPOSDataSet.Sales, item_nr, Reference1)
                Dim VOID_Tax As Double = Val(AAPOSDataSet.Sales.Rows(0)("Selling_Price").ToString)
                Dim Qty As Integer = Val(AAPOSDataSet.Sales.Rows(0)("Auto").ToString)
                Dim Product_Code As String = Val(AAPOSDataSet.Sales.Rows(0)("Product_Code").ToString)
                Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Product_Code)
                Dim current_number_of_items As Integer = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString
                Dim stock_n_void As Integer = current_number_of_items + Qty
                Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(stock_n_void, Product_Code)
                count = count - VOID_Tax
                lblSubTotal.Text = "R" + count.ToString("0.00")
                lblTotal.Text = "R" + count.ToString("0.00")
                SalesTableAdapter.DeleteQuery(item_nr, Reference1)
                ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
                '  Label14.Visible = False
                txtVoidPass.Visible = False
                TextBox2.Focus()
            Else
                MessageBox.Show("Incorrect Void password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            On_Bar = "BAR"
        End If



        If On_Bar = "BAR" Then


            Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, TextBox2.Text)
            Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
            If count1 = 0 Then
                MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Label12.Text = "R0.00 "
            Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
            Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
            Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)

            itemNo = itemNo + 1

            ListBox2.Items.Add(itemNo.ToString + "     " + TextBox2.Text + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
            count = count + Price
            lblSubTotal.Text = "R" + count.ToString("0.00")
            ' tax = count * 0.14
            ' lblTax.Text = "R" + tax.ToString("0.00")
            total = count
            lblTotal.Text = "R" + total.ToString("0.00")

            Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
            Dim day, hh, mm, year, month, ref As String
            year = a.Substring(2, 2)
            month = a.Substring(5, 2)
            day = a.Substring(8, 2)
            hh = a.Substring(12, 2)
            mm = a.Substring(15, 2)
            ref = year + month + day

            Dim count2 As Integer = 0
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            AutogenTableAdapter.UpdateQueryUsers(count2, 1)
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
            Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
            Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
            Me.SalesTableAdapter.Insert(count2, itemNo.ToString, TextBox2.Text, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
            txtQty.Text = "1"
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TextBox2.Text)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, TextBox2.Text)
            Catch ex As Exception

            End Try
            TextBox2.Text = ""
            TextBox2.Focus()
            QTY = "OFF"
            On_Bar = "BAR"
        End If
        If On_Bar = "OFF" Then
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            Dim change As Double = Val(txttotals.Text) - Val(count)
            TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), "", count.ToString("0.00"), txttotals.Text, change, "CASH", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "", "", "", "")
            ListBox2.Items.Clear()
            Label12.Text = "R " & change
            txttotals.Text = ""
            lblSubTotal.Text = "R0.00"
            lblTotal.Text = "R0.00"
            ' lblTax.Text = "R0.00"
            total = 0.0
            count = 0.0
            itemNo = 0
            'Add totals
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
            TextBox2.Focus()
            On_Bar = "BAR"
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "2"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "2"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "3"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "3"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "3"
        End If
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "4"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "4"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "5"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "5"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "6"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "6"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "7"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "7"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "8"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "8"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "9"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "9"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "9"
        End If
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "0"
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "0"
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "0"
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "."
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "."
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "."
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub picstart_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picstart.MouseMove
        picstart.Visible = False
        picstart2.Visible = True
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub picstart2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picstart2.MouseClick
        ' GroupBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox2.Focus()
        txtQty.Text = "1"
        On_Bar = "BAR"
        MessageBox.Show("Welcome To the Advance Point Of Sale System Enjoy Smplicity at its best", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub picend_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picend.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = False
        picend2.Visible = True
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False
    End Sub

    Private Sub picend2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picend2.MouseClick
        If ListBox1.Items.Count = 0 Then
            If MessageBox.Show("Are you sure you what to exit", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If frmLogin.profile = "SALES" Then
                    Me.Close()
                    Exit Sub
                Else
                    Me.Close()
                    frmMainScreen.Show()
                End If
            End If
        Else
            MessageBox.Show("Please complete the transection before ending your shift", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


    End Sub

    Private Sub picpay_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picpay.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = False
        picpay2.Visible = True
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False
    End Sub

    Private Sub picpay2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picpay2.MouseClick
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please enter all the items you require to sell", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        On_Bar = "OFF"
        txttotals.Focus()
    End Sub

    Private Sub picele_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picele.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = False
        picele2.Visible = True
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False
    End Sub

    Private Sub picele2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picele2.MouseClick
        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("Please enter all the items you require to sell", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        '  Dim change As Double = Val(txttotals.Text) - Val(total)
        StatusTableAdapter.Fill(AAPOSDataSet.Status)
        Status = AAPOSDataSet.Status.Rows(0)("VAT").ToString()
        If Status = "ON" Then
            VAT = total * 0.14
        Else
            VAT = 0
        End If
        'Dim VAT As Double = Val (

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), VAT, total.ToString("0.00"), total.ToString("0.00"), "R0.00", "ELECTRONICALLY", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "SALE", "", "", "")

        Dim COUNT2 As Integer = ListBox1.Items.Count()
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        ListBox3.Items.Add("")
        Company_DetailsTableAdapter.Fill(AAPOSDataSet.Company_Details)
        Dim Company_Reg As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString()
        Dim Company_Name As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString()
        Dim Physical_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString()
        Dim Contact_No As String = AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString()
        Dim Email_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString()

        ListBox3.Items.Add("                            " & Physical_Address)
        ' ListBox3.Items.Add("                           SHOP NO 03 STAND 1193/1194")
        ListBox3.Items.Add("                           CONTACT US ON : " & Contact_No)
        ListBox3.Items.Add("                    " & Company_Name & " REG " & Company_Reg)
        ListBox3.Items.Add("")
        ListBox3.Items.Add(" ORDER NUMBER/REF NUMBER : " & Reference)
        ListBox3.Items.Add("------------------------------------------------------------------------------------")
        ListBox3.Items.Add("")
        ListBox3.Items.Add(" LIST OF ITEMS")
        ListBox3.Items.Add("")

        'For I = 0 To COUNT2 - 1
        '    Dim TTT As String = ListBox1.Items(I)
        '    ListBox3.Items.Add(TTT)
        'Next
        ' ListBox3.Items.Add(ListBox1.Text)
        ListBox4.Items.Add("------------------------------------------------------------------------------------")
        ListBox4.Items.Add(" TOTAL : " & lblTotal.Text)
        ListBox4.Items.Add(" PAYMENT TYPE: " & "EFT")
        If Status = "ON" Then
            ListBox4.Items.Add(" TOTAL inclu  : " & "R" & Val(total + VAT))
        Else
            ListBox4.Items.Add(" TOTAL Exclu  : " & "R" & Val(total))
        End If
        ListBox4.Items.Add("------------------------------------------------------------------------------------")
        ListBox4.Items.Add("")
        ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
        ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
        ListBox4.Items.Add("")

        ListBox4.Items.Add("                             THANKS AND ENJOY")
        ListBox4.Items.Add("")
        ListBox4.Items.Add("")
        StatusTableAdapter.Fill(AAPOSDataSet.Status)
        Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()
        Dim Status2 = AAPOSDataSet.Status.Rows(0)("AUTO").ToString()
        If Status2 = "RESTAURANT" Then
            PrintDocument1.Print()
        End If
        If Status = "ON" Then
            PrintDocument1.Print()
        Else

        End If
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox1.Items.Clear()
        ListBox4.Items.Clear()
        Label12.Text = "R0.00"
        txttotals.Text = ""
        lblSubTotal.Text = "R0.00"
        lblTotal.Text = "R0.00"
        'lblTax.Text = "R0.00"
        total = 0.0
        count = 0.0
        SalesTableAdapter.UpdateQueryCASH("ELECTRONICALLY", Reference)
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
        TextBox2.Focus()
        On_Bar = "BAR"
        itemNo = 0
        ListBox1.Items.Clear()
        txtQty.Text = "1"
        frmMorefunctions.Suspend = "OFF"
    End Sub

    Private Sub picvoid_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picvoid.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = False
        picvoid2.Visible = True
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False
    End Sub

    Private Sub picvoid2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picvoid2.MouseClick
        '  Label14.Visible = True
        txtVoidPass.Visible = True
        txtVoidPass.Text = ""
        txtVoidPass.Focus()
        On_Bar = "VOI"
    End Sub

    Private Sub pic1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic1.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = False
        pic12.Visible = True
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False
    End Sub

    Private Sub pic12_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic12.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "1"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "1"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "1"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "1"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "1"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "1"
            End If
        End If
    End Sub

    Private Sub pic2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic2.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = False
        pic22.Visible = True
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic22_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic22.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "2"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "2"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "2"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "2"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "2"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "2"
            End If
        End If
    End Sub

    Private Sub pic3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic3.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = False
        pic32.Visible = True
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic32_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic32.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "3"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "3"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "3"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "3"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "3"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "3"
            End If
        End If
    End Sub

    Private Sub pic4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic4.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = False
        pic42.Visible = True
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic42_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic42.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "4"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "4"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "4"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "4"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "4"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "4"
            End If
        End If
    End Sub

    Private Sub pic5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic5.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = False
        pic52.Visible = True
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic52_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic52.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "5"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "5"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "5"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "5"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "5"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "5"
            End If
        End If
    End Sub

    Private Sub pic6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic6.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = False
        pic62.Visible = True
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic62_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic62.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "6"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "6"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "6"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "6"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "6"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "6"
            End If
        End If
    End Sub

    Private Sub pic7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic7.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = False
        pic72.Visible = True
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic72_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic72.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "7"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "7"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "7"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "7"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "7"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "7"
            End If
        End If
    End Sub

    Private Sub pic8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic8.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = False
        pic82.Visible = True
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic82_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic82.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "8"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "8"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "8"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "8"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "8"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "8"
            End If
        End If
    End Sub

    Private Sub pic9_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic9.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = False
        pic92.Visible = True
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic92_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic92.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "9"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "9"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "9"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "9"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "9"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "9"
            End If
        End If
    End Sub

    Private Sub pic0_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic0.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = False
        pic02.Visible = True
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub pic02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic02.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "0"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "0"
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "0"
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "0"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "0"
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "0"
            End If
        End If
    End Sub

    Private Sub picdot_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picdot.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = False
        picdot2.Visible = True
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub picdot2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picdot2.MouseClick
        If On_Bar = "BAR" Then
            TextBox2.Text = TextBox2.Text & "."
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "."
            End If
        ElseIf On_Bar = "OFF" Then
            txttotals.Text = txttotals.Text & "."
            If TextBox2.SelectionLength >= 1 Then
                txttotals.Text = "6"
            End If
        ElseIf On_Bar = "VOI" Then
            txtVoidPass.Text = txtVoidPass.Text & "."
            If txtVoidPass.SelectionLength >= 1 Then
                txtVoidPass.Text = "."
            End If
        End If
    End Sub

    Private Sub picenter_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picenter.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = False
        picenter2.Visible = True

    End Sub

    Private Sub picenter2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picenter2.MouseClick
        If On_Bar = "VOI" Then
            If txtVoidPass.Text = "1320" Then
                Dim count12 As Double = 0
                Dim Reference1 As Double = 0
                Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
                count12 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
                Reference1 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

                If frmMorefunctions.Suspend = "ON" Then
                    Reference1 = frmPendingSales.Pending_Ref
                End If
                ' Dim Item As String = ListBox2.SelectedItem.ToString()
                '' Dim itemsub As String = Item.Substring(0, 4)
                Dim item_nr As String
                If ListBox1.SelectedItems.Count > 0 Then
                    item_nr = ListBox1.SelectedItems(0).SubItems(0).Text
                Else
                    MessageBox.Show("Please select the item you would like to void, click void and enter the void password", "Information")
                    Exit Sub
                End If
                SalesTableAdapter.FillByNrRef(AAPOSDataSet.Sales, item_nr, Reference1)
                Dim VOID_Tax As Double = Val(AAPOSDataSet.Sales.Rows(0)("Selling_Price").ToString)
                Dim Qty As Integer = Val(AAPOSDataSet.Sales.Rows(0)("Auto").ToString)
                Dim Product_Code As String = AAPOSDataSet.Sales.Rows(0)("Product_Code").ToString
                Dim DES As String = AAPOSDataSet.Sales.Rows(0)("Description").ToString
                Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Product_Code)
                Dim current_number_of_items As Double = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString
                Dim stock_n_void As Double = current_number_of_items + Qty
                Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(stock_n_void, Product_Code)
                Dim selec As Double = ListBox2.SelectedIndex
                '   ListBox2.Items.RemoveAt(ListBox2.SelectedIndex)
                For Each i As ListViewItem In ListBox1.SelectedItems
                    ListBox1.Items.Remove(i)
                Next
                count = count - VOID_Tax
                lblSubTotal.Text = "R" + count.ToString("0.00")
                lblTotal.Text = "R" + count.ToString("0.00")
                SalesTableAdapter.DeleteQuery(item_nr, Reference1)

                ' Label14.Visible = False
                txtVoidPass.Visible = False
                TextBox2.Focus()
                ' ListBox1.Items.Remove(DES.ToString)
            Else
                MessageBox.Show("Incorrect Void password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            On_Bar = "BAR"
        End If



        If On_Bar = "BAR" Then


            Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, TextBox2.Text)
            Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
            If count1 = 0 Then
                MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Label12.Text = "R0.00 "
            Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
            Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
            Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)

            itemNo = itemNo + 1

            ListBox2.Items.Add(itemNo.ToString + "     " + TextBox2.Text + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
            ' ListBox1.Items.Add(discription)
            count = count + Price
            lblSubTotal.Text = "R" + count.ToString("0.00")
            ' tax = count * 0.14
            ' lblTax.Text = "R" + tax.ToString("0.00")
            total = count
            lblTotal.Text = "R" + total.ToString("0.00")

            Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
            Dim day, hh, mm, year, month, ref As String
            year = a.Substring(2, 2)
            month = a.Substring(5, 2)
            day = a.Substring(8, 2)
            hh = a.Substring(12, 2)
            mm = a.Substring(15, 2)
            ref = year + month + day

            Dim count2 As Integer = 0
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            AutogenTableAdapter.UpdateQueryUsers(count2, 1)
            Me.SalesTableAdapter.Insert(count2, itemNo.ToString, TextBox2.Text, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "", "", "", "")
            txtQty.Text = "1"
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, TextBox2.Text)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, TextBox2.Text)
            Catch ex As Exception

            End Try
            TextBox2.Text = ""
            TextBox2.Focus()
            QTY = "OFF"
            On_Bar = "BAR"
        End If
        If On_Bar = "OFF" Then
            If Val(txttotals.Text) < count Then
                MessageBox.Show("Cash can't be less than the total,Please enter the correct amount to complete transcation")
                Exit Sub
            End If
            Dim Reference As Integer = 0
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

            If frmMorefunctions.Suspend = "ON" Then
                Reference = frmPendingSales.Pending_Ref
            End If
            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("VAT").ToString()
            If Status = "ON" Then
                VAT = total * 0.14
            Else
                VAT = 0
            End If
            Dim change As Double = Val(txttotals.Text) - Val(count)
            TotalsTableAdapter.Insert(Reference, count.ToString("0.00"), VAT, count.ToString("0.00"), txttotals.Text, change, "CASH", ListBox2.Items.Count, Format(Now, "yyyy/MM/dd  hh:mm:ss tt"), Reference, "", "", "", "")
            ListBox2.Items.Clear()
            '''''''''
            Dim COUNT2 As Integer = ListBox1.Items.Count()
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            ListBox3.Items.Add("")
            Company_DetailsTableAdapter.Fill(AAPOSDataSet.Company_Details)
            Dim Company_Reg As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Reg").ToString()
            Dim Company_Name As String = AAPOSDataSet.Company_Details.Rows(0)("Company_Name").ToString()
            Dim Physical_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Physical_Address").ToString()
            Dim Contact_No As String = AAPOSDataSet.Company_Details.Rows(0)("Contact_No").ToString()
            Dim Email_Address As String = AAPOSDataSet.Company_Details.Rows(0)("Email_Address").ToString()

            ListBox3.Items.Add("                            " & Physical_Address)
            ' ListBox3.Items.Add("                           SHOP NO 03 STAND 1193/1194")
            ListBox3.Items.Add("                           CONTACT US ON : " & Contact_No)
            ListBox3.Items.Add("                    " & Company_Name & " REG " & Company_Reg)

            ListBox3.Items.Add("")
            ListBox3.Items.Add(" ORDER NUMBER/REF NUMBER : " & Reference)
            ListBox3.Items.Add("----------------------------------------------------------------")
            ListBox3.Items.Add("")
            ListBox3.Items.Add(" LIST OF ITEMS")
            ListBox3.Items.Add("")

            'For I = 0 To COUNT2 - 1
            '    Dim TTT As String = ListBox1.Items(I)
            '    ListBox3.Items.Add(TTT)
            'Next
            ' ListBox3.Items.Add(ListBox1.Text)
            ListBox4.Items.Add("----------------------------------------------------------------")
            ListBox4.Items.Add(" TOTAL : " & lblTotal.Text)
            ListBox4.Items.Add(" CASH  : " & "R" & txttotals.Text)
            ListBox4.Items.Add(" RETURN: " & Label12.Text)
            If Status = "ON" Then
                ListBox4.Items.Add(" TOTAL inclu  : " & "R" & Val(total + VAT))
            Else
                ListBox4.Items.Add(" TOTAL Exclu  : " & "R" & Val(total))
            End If
            ListBox4.Items.Add(" PAYMENT TYPE: " & "CASH")
            ListBox4.Items.Add("----------------------------------------------------------------")
            ListBox4.Items.Add("")
            ListBox4.Items.Add(" DATE & TIME  : " & Format(Now, "yyyy/MM/dd  hh:mm:ss tt"))
            ListBox4.Items.Add(" CASHIER NAME : " & UCase(frmLogin.name))
            ListBox4.Items.Add("")

            ListBox4.Items.Add("                             THANKS AND ENJOY")
            ListBox4.Items.Add("")
            ListBox4.Items.Add("")

            StatusTableAdapter.Fill(AAPOSDataSet.Status)
            Status = AAPOSDataSet.Status.Rows(0)("PRINTER").ToString()
            Dim Status2 = AAPOSDataSet.Status.Rows(0)("AUTO").ToString()
            If Status2 = "RESTAURANT" Then
                PrintDocument1.Print()
            End If
            If Status = "ON" Then
                PrintDocument1.Print()
            Else

            End If


            'PrintDocument1.Print()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
            ListBox1.Items.Clear()
            ListBox4.Items.Clear()
            'Label12.Text = "R0.00"
            Label12.Text = "R " & change
            txttotals.Text = ""
            lblSubTotal.Text = "R0.00"
            lblTotal.Text = "R0.00"
            'lblTax.Text = "R0.00"
            total = 0.0
            count = 0.0
            SalesTableAdapter.UpdateQueryCASH("CASH", Reference)
            Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
            Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
            AutogenTableAdapter.UpdateQuerySliprefnr(Reference, "1")
            TextBox2.Focus()
            On_Bar = "BAR"
            itemNo = 0
            ListBox1.Items.Clear()
            frmMorefunctions.Suspend = "OFF"
        End If
        txtQty.Text = "1"
        frmMorefunctions.Suspend = "OFF"
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        picstart.Visible = True
        picstart2.Visible = False
        picend.Visible = True
        picend2.Visible = False
        picpay.Visible = True
        picpay2.Visible = False
        picele.Visible = True
        picele2.Visible = False
        picvoid.Visible = True
        picvoid2.Visible = False
        pic1.Visible = True
        pic12.Visible = False
        pic2.Visible = True
        pic22.Visible = False
        pic3.Visible = True
        pic32.Visible = False
        pic4.Visible = True
        pic42.Visible = False
        pic5.Visible = True
        pic52.Visible = False
        pic6.Visible = True
        pic62.Visible = False
        pic7.Visible = True
        pic72.Visible = False
        pic8.Visible = True
        pic82.Visible = False
        pic9.Visible = True
        pic92.Visible = False
        pic0.Visible = True
        pic02.Visible = False
        picdot.Visible = True
        picdot2.Visible = False
        picenter.Visible = True
        picenter2.Visible = False

    End Sub

    Private Sub btn1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
        ' lblTotal.Text = 1

    End Sub

    Private Sub btn2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item2").ToString()

        '  txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", "", "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item3").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", "", "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item4").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item5").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item6").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item7").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item8").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item9").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item10").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item11").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item12").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub pic22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic22.Click

    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Dim startX As Integer = 10
        'Dim startY As Integer = 10
        'Dim offset As Integer = 40
        'e.Graphics.DrawString("Welcome to the coffee shop", New Font("Calibri", 8), New SolidBrush(Color.Black), startX, startY)

        Dim fnt As New Font("Calibri", 8, FontStyle.Regular, GraphicsUnit.Point)
        Dim ListBoxItem As String = String.Empty
        For Each LBItem As String In ListBox3.Items
            ListBoxItem = ListBoxItem & vbCrLf & LBItem
        Next
        ListBoxItem = ListBoxItem.Substring(vbCrLf.Length)
        e.Graphics.DrawString(ListBoxItem, fnt, Brushes.Black, 0, 0)
        e.HasMorePages = False

        ' '''''
        Dim lvwItem As ListViewItem
        Dim lvwSubItem As ListViewItem.ListViewSubItem
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0

        ' Counter for display purposes
        Dim listviewcount As Integer = 12

        ' Loop through our listview items
        For Each lvwItem In ListBox1.Items
            xPos = 0

            ' Print the count
            ' Debug.Print(listviewcount)

            ' Print the subitems of this particular ListViewItem

            For Each lvwSubItem In lvwItem.SubItems

                yPos = 35 + (listviewcount * 15)

                ' e.Graphics.DrawString(lvwSubItem.Text(), fnt, Brushes.Black, 0, 0)

                e.Graphics.DrawString(lvwSubItem.Text(), _
                    New Font("Calibri", 7, FontStyle.Regular), Brushes.Black, xPos, yPos)
                xPos += 75
            Next

            ' Increment the count (for display purposes)
            listviewcount += 1


        Next

        yPos = 35 + (listviewcount * 15)
        'Dim fnt1 As New Font("Calibri", 8, FontStyle.Regular, GraphicsUnit.Point)
        Dim ListBoxItem2 As String = String.Empty
        For Each LBItem2 As String In ListBox4.Items
            ListBoxItem2 = ListBoxItem2 & vbCrLf & LBItem2
        Next
        ListBoxItem2 = ListBoxItem2.Substring(vbCrLf.Length)
        e.Graphics.DrawString(ListBoxItem2, fnt, Brushes.Black, 0, yPos)
        e.HasMorePages = False
        ' e.Graphics.DrawString("Welcome to the coffee shop", New Font("Calibri", 8), New SolidBrush(Color.Black), 10, yPos)
    End Sub

    Private Sub btn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item13").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item14").ToString()

        '  txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item15").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ' ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        ' ListBox1.Items.Add(discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item20").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn19.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item19").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item18").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item16").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item17").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        ' ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub


    Private Sub btn23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn23.Click
        menu2.Show()
    End Sub

    Private Sub btn24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn24.Click
        menu3.Show()
    End Sub

    Private Sub picenter2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picenter2.Click

    End Sub

    Private Sub txttotals_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttotals.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub btn22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn22.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item22").ToString()

        ' txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub btn21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn21.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(0)("item21").ToString()

        'txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Label12.Text = "R0.00 "
        Dim discription As String = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(txtQty.Text)
        Dim Stock_Price As Double = Val(AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        itemNo = itemNo + 1
        ListBox2.Items.Add(itemNo.ToString + "     " + Code + "                R " & Price & "                 " & txtQty.Text & "                           " & discription)
        With ListBox1
            Dim item As New ListViewItem(New String() {itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        '  ListBox1.Items.Add(discription)
        count = count + Price
        lblSubTotal.Text = "R" + count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        total = count
        lblTotal.Text = "R" + total.ToString("0.00")
        Dim a As String = Format(Now, "yyyy/MM/dd  hh:mm:ss tt")
        Dim day, hh, mm, year, month, ref As String
        year = a.Substring(2, 2)
        month = a.Substring(5, 2)
        day = a.Substring(8, 2)
        hh = a.Substring(12, 2)
        mm = a.Substring(15, 2)
        ref = year + month + day
        Dim count2 As Integer = 0
        Dim Reference As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1

        If frmMorefunctions.Suspend = "ON" Then
            Reference = frmPendingSales.Pending_Ref
        End If
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Me.SalesTableAdapter.Insert(count2, itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(txtQty.Text)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        TextBox2.Text = ""
        TextBox2.Focus()
        txtQty.Text = "1"
    End Sub

    Private Sub txtVoidPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoidPass.TextChanged

    End Sub

    Private Sub btnExtra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtra.Click
        frmMorefunctions.Show()

    End Sub
End Class
