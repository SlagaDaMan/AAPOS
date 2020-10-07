Public Class Extra_Menu2

    Private Sub Extra_Menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.AAPOSDataSet.Menu)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        If Stock_Items.TxtItemBarcode.Text = "" Then
            MessageBox.Show("Please enter the barcode you would like to link", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Stock_Items.TxtItemDescription.Text = "" Then
            MessageBox.Show("Please retrieve the item you would like to link", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

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


        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item").ToString)
        Button1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item2").ToString)
        Button2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item3").ToString)
        Button3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item4").ToString)
        Button4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item5").ToString)
        Button5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item6").ToString)
        Button6.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item7").ToString)
        Button7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item8").ToString)
        Button8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item9").ToString)
        Button9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item10").ToString)
        Button10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item11").ToString)
        Button11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item12").ToString)
        Button12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item13").ToString)
        Button13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item14").ToString)
        Button14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item15").ToString)
        Button15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item16").ToString)
        Button16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item17").ToString)
        Button17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item18").ToString)
        Button18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item19").ToString)
        Button19.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item20").ToString)
        Button20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item21").ToString)
        Button21.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item22").ToString)
        Button22.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item23").ToString)
        Button23.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString

        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item24").ToString)
        Button24.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
















    End Sub

    Private Sub btn18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        MenuTableAdapter.UpdateQueryitem18(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item18").ToString)
        btn18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        MenuTableAdapter.UpdateQueryitem(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item").ToString)
        btn1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        MenuTableAdapter.UpdateQueryitem2(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item2").ToString)
        btn2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        MenuTableAdapter.UpdateQueryitem3(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item3").ToString)
        btn3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        MenuTableAdapter.UpdateQueryitem4(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item4").ToString)
        btn4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        MenuTableAdapter.UpdateQueryitem5(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item5").ToString)
        btn5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        MenuTableAdapter.UpdateQueryitem6(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item6").ToString)
        btn6.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        MenuTableAdapter.UpdateQueryitem7(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item7").ToString)
        btn7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        MenuTableAdapter.UpdateQueryitem8(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item8").ToString)
        btn8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        MenuTableAdapter.UpdateQueryitem9(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item9").ToString)
        btn9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        MenuTableAdapter.UpdateQueryitem10(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item10").ToString)
        btn10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        MenuTableAdapter.UpdateQueryitem11(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item11").ToString)
        btn11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        MenuTableAdapter.UpdateQueryitem12(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item12").ToString)
        btn12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        MenuTableAdapter.UpdateQueryitem13(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item13").ToString)
        btn13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        MenuTableAdapter.UpdateQueryitem14(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item14").ToString)
        btn14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        MenuTableAdapter.UpdateQueryitem15(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item15").ToString)
        btn15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        MenuTableAdapter.UpdateQueryitem16(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item16").ToString)
        btn16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        MenuTableAdapter.UpdateQueryitem17(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item17").ToString)
        btn17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn19.Click
        MenuTableAdapter.UpdateQueryitem19(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item19").ToString)
        btn19.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn20.Click
        MenuTableAdapter.UpdateQueryitem20(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btn21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn21.Click
        MenuTableAdapter.UpdateQueryitem21(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn22.Click
        MenuTableAdapter.UpdateQueryitem22(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn23.Click
        MenuTableAdapter.UpdateQueryitem23(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub btn24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn24.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "3")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(2)("item20").ToString)
        btn20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub MenuBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MenuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item").ToString)
        Button1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item2").ToString)
        Button2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item3").ToString)
        Button3.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item4").ToString)
        Button4.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item5").ToString)
        Button5.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item7").ToString)
        Button7.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item8").ToString)
        Button8.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item9").ToString)
        Button9.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item10").ToString)
        Button10.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item11").ToString)
        Button11.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item12").ToString)
        Button12.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item13").ToString)
        Button13.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item14").ToString)
        Button14.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item15").ToString)
        Button15.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item16").ToString)
        Button16.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item17").ToString)
        Button17.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item18").ToString)
        Button18.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item20").ToString)
        Button20.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item21").ToString)
        Button21.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item22").ToString)
        Button22.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item23").ToString)
        Button23.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        MenuTableAdapter.UpdateQueryitem24(Stock_Items.TxtItemBarcode.Text, "7")
        MessageBox.Show("Successfuly Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, AAPOSDataSet.Menu.Rows(4)("item24").ToString)
        Button24.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Me.Close()
    End Sub

End Class