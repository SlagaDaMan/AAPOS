Public Class menu3

    Private Sub menu3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item").ToString)
        btn1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item2").ToString)
        btn2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item3").ToString)
        btn3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item4").ToString)
        btn4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item5").ToString)
        btn5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item6").ToString)
        btn6.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item7").ToString)
        btn7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item8").ToString)
        btn8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item9").ToString)
        btn9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item10").ToString)
        btn10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item11").ToString)
        btn11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item12").ToString)
        btn12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item13").ToString)
        btn13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item14").ToString)
        btn14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item15").ToString)
        btn15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item16").ToString)
        btn16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item17").ToString)
        btn17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item18").ToString)
        btn18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item19").ToString)
        btn19.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item21").ToString)
        btn21.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item22").ToString)
        btn22.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item23").ToString)
        btn23.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item24").ToString)
        btn24.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString


        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item").ToString)
        Button1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item2").ToString)
        Button2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item3").ToString)
        Button3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item4").ToString)
        Button4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item5").ToString)
        Button5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item6").ToString)
        Button6.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item7").ToString)
        Button7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item8").ToString)
        Button8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item9").ToString)
        Button9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item10").ToString)
        Button10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item11").ToString)
        Button11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item12").ToString)
        Button12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item13").ToString)
        Button13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item14").ToString)
        Button14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item15").ToString)
        Button15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item16").ToString)
        Button16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item17").ToString)
        Button17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item18").ToString)
        Button18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item19").ToString)
        Button19.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item20").ToString)
        Button20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item21").ToString)
        Button21.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item22").ToString)
        Button22.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item23").ToString)
        Button23.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(3)("item24").ToString)
        Button24.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString





    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"

    End Sub
    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item2").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item3").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item4").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item5").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item6").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item7").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item8").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item9").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item10").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item11").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item12").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item13").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item14").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item15").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item20").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn19.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item19").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item18").ToString()

        'Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item16").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item17").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn22.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item22").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn23.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item23").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn24.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = Form1.AAPOSDataSet.Menu.Rows(2)("item24").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item2").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item3").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item4").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item5").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item6").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item7").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item8").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item9").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item10").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item11").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item12").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item13").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item14").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item15").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item16").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item17").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item19").ToString()

        ' Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item20").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item21").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item22").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item23").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(5)("item21").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    'Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click

    ''End Sub

    'Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click

    'End Sub

    Private Sub btn6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item6").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item8").ToString()

        '      Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item9").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item2").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item3").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item4").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item5").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn21.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item21").ToString()

        '   Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item6").ToString()

        '    Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item11").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub

    Private Sub btn12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        MenuTableAdapter.Fill(AAPOSDataSet.Menu)
        Dim Code As String = AAPOSDataSet.Menu.Rows(2)("item12").ToString()

        '  Form1.txtQty.Text = "1"
        Me.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
        Dim count1 As Integer = Form1.AAPOSDataSet.Stock_Items.Count
        If count1 = 0 Then
            MessageBox.Show("The item has not ben added to the database please contact administrator to add item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Form1.Label12.Text = "R0.00 "
        Dim discription As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Dim Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString) * Val(Form1.txtQty.Text)
        Dim Stock_Price As Double = Val(Form1.AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString)
        Dim Link_Code As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item2").ToString
        Dim PAck As String = Form1.AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item3").ToString
        Form1.itemNo = Form1.itemNo + 1
        Form1.ListBox2.Items.Add(Form1.itemNo.ToString + "     " + Code + "                R " & Price & "                 " & Form1.txtQty.Text & "                           " & discription)
        With Form1.ListBox1
            Dim item As New ListViewItem(New String() {Form1.itemNo.ToString, discription, "", "R " & Price})
            .Items.Add(item)
        End With
        Form1.ListBox1.Items.Add(discription)
        Form1.count = Form1.count + Price
        Form1.lblSubTotal.Text = "R" + Form1.count.ToString("0.00")
        ' tax = count * 0.14
        ' lblTax.Text = "R" + tax.ToString("0.00")
        Form1.total = Form1.count
        Form1.lblTotal.Text = "R" + Form1.total.ToString("0.00")
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
        Form1.AutogenTableAdapter.Fill(AAPOSDataSet.Autogen)
        count2 = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Reference = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum1").ToString) + 1
        Form1.AutogenTableAdapter.UpdateQueryUsers(count2, 1)
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim IP As String = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        Form1.Till_SetupTableAdapter.FillByIP(AAPOSDataSet.Till_Setup, IP)
        Dim TILL_NO As String = AAPOSDataSet.Till_Setup.Rows(0)("ID").ToString
        Form1.SalesTableAdapter.Insert(count2, Form1.itemNo.ToString, Code, Price, Stock_Price, discription, frmLogin.name & " " & frmLogin.surname, a, "", Reference, Form1.txtQty.Text, "", "SALE", TILL_NO, "", "")
        'New Stock packs and 24's
        If Link_Code = "" Then
            Try
                Form1.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Code)
            Catch ex As Exception
            End Try
        Else
            For i = 1 To Val(Form1.txtQty.Text)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Link_Code)
                Dim count As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Form1.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count, Link_Code)
                Form1.Stock_ItemsTableAdapter.FillByBarcode(Form1.AAPOSDataSet.Stock_Items, Code)
                Dim count22 As Integer = Val(AAPOSDataSet.Stock_Items.Rows(0)("Optional_Item1").ToString) - PAck
                Me.Stock_ItemsTableAdapter.UpdateQueryNUMBEROFSTOCK(count22, Code)
            Next
        End If
        Form1.TextBox2.Text = ""
        Form1.TextBox2.Focus()
        Form1.txtQty.Text = "1"
    End Sub
End Class