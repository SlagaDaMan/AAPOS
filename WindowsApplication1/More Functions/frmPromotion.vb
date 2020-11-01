Public Class frmPromotion

    Private Sub frmPromotion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet1.Promotions' table. You can move, or remove it, as needed.
        Me.PromotionsTableAdapter.Fill(Me.AAPOSDataSet1.Promotions)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)

    End Sub

    Private Sub txthh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthh.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub chkStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStatus.CheckedChanged
        If chkStatus.Checked = True Then
            cmbStatus.Enabled = True
        Else
            cmbStatus.Enabled = False
        End If
    End Sub

    Private Sub ChkEnableDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEnableDate.CheckedChanged
        If chkStatus.Checked = True Then
            grpDate.Enabled = True
        Else
            grpDate.Enabled = False
        End If
    End Sub

    Private Sub ChkEnableTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEnableTime.CheckedChanged
        If chkStatus.Checked = True Then
            grpTime.Enabled = True
        Else
            grpTime.Enabled = False
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Sub clear()
        txtBarcode.Text = ""
        txthh2.Text = "00"
        txthh.Text = "00"
        txtItemDescription.Text = ""
        txtmm.Text = "00"
        txtmm2.Text = "00"
        txtss.Text = "00"
        txtss2.Text = "00"
        ChkEnableDate.Checked = False
        ChkEnableTime.Checked = False
        chkStatus.Checked = False

    End Sub

    Private Sub btnPromotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPromotion.Click
        Dim ERRORFound = ValidationClass()
        If Not ERRORFound = "" Then
            MessageBox.Show(ERRORFound)
            Exit Sub
        End If
        Dim Barcode = txtBarcode.Text
        Dim Status = cmbStatus.Text
        Dim date_start1 As String = Format(dtpFrom.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  " & txthh.Text & ":" & txtmm.Text & ":" & txtss.Text & " " & cmbTime1.Text & ""
        Dim Timefrom As String = txthh.Text & ":" & txtmm.Text & ":" & txtss.Text & " " & cmbTime1.Text & ""
        Dim date_start2 As String = Format(dtpTo.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  " & txthh2.Text & ":" & txtmm2.Text & ":" & txtss2.Text & " " & cmbTime2.Text & ""
        Dim Timeto As String = txthh.Text & ":" & txtmm.Text & ":" & txtss.Text & " " & cmbTime1.Text
        PromotionsTableAdapter.FillByBarcode(AAPOSDataSet1.Promotions, txtBarcode.Text)

        If AAPOSDataSet1.Promotions.Rows.Count > 0 Then
            PromotionsTableAdapter.UpdateQueryAllByBarcode(txtBarcode.Text, txtItemDescription.Text, cmbStatus.Text, cmbPromotionType.Text, TxtItemStockPrice.Text, TxtItemSellingPrice.Text, txtAmmendPromotion.Text, txtPromotionPrice.Text, chkDateFrames.CheckState, final_date1, final_date2, ChkEnableDate.CheckState, cmbmon.Text, cmbtues.Text, cmbwed.Text, cmbthur.Text, cmbfri.Text, cmbsat.Text, cmbsun.Text, Timefrom, Timeto, frmLogin.txtUserName.Text, Format(Now(), "yyyy/MM/dd"), frmLogin.txtUserName.Text, Format(Now(), "yyyy/MM/dd"), txtBarcode.Text)
        Else
            PromotionsTableAdapter.Insert(txtBarcode.Text, txtItemDescription.Text, cmbStatus.Text, cmbPromotionType.Text, TxtItemStockPrice.Text, TxtItemSellingPrice.Text, txtAmmendPromotion.Text, txtPromotionPrice.Text, chkDateFrames.CheckState, final_date1, final_date2, ChkEnableDate.CheckState, cmbmon.Text, cmbtues.Text, cmbwed.Text, cmbthur.Text, cmbfri.Text, cmbsat.Text, cmbsun.Text, Timefrom, Timeto, frmLogin.txtUserName.Text, Format(Now(), "yyyy/MM/dd"), frmLogin.txtUserName.Text, Format(Now(), "yyyy/MM/dd"))
        End If
        clear()
        MessageBox.Show("The promotion has been successfully captured", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtmm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmm.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub txtss_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtss.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub cmbTime1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTime1.SelectedIndexChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub txthh2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthh2.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub txtmm2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmm2.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub txtss2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtss2.TextChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub cmbTime2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTime2.SelectedIndexChanged
        txthh.MaxLength = 2
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then


            Me.Stock_ItemsTableAdapter.FillByBarcode(AAPOSDataSet.Stock_Items, txtBarcode.Text)
            Dim count As Integer = AAPOSDataSet.Stock_Items.Count
            If count >= 1 Then
                txtItemDescription.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
                TxtItemStockPrice.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_StockPrice").ToString
                TxtItemSellingPrice.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice").ToString          
            Else

            End If
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        
    End Sub

    Private Sub Stock_ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Stock_ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        frmMorefunctions.Show()

    End Sub
    Public Function ValidationClass()
        Dim ErrorFound = ""
        If txtBarcode.Text = "" Then
            ErrorFound = "Please search for a barcode you would like to add promotion to"
        End If
        If txtItemDescription.Text = "" Then
            ErrorFound = "Please search for a barcode you would like to add promotion to"
        End If
        If cmbStatus.Text = "" Then
            ErrorFound = "Please select the promotion status"
        End If
        If cmbPromotionType.Text = "" Then
            ErrorFound = "Please select the promotion type"
        End If
        If txtAmmendPromotion.Text = "" Then
            ErrorFound = "Please enter the Ammend promotion option"
        End If
        If txtPromotionPrice.Text = "" Then
            ErrorFound = "The promotion price is not calculated"
        End If
        If Not cmbmon.Text = "ON" Or Not cmbmon.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Mon"
        End If
        If Not cmbtues.Text = "ON" Or Not cmbtues.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Tue"
        End If
        If Not cmbwed.Text = "ON" Or Not cmbwed.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Wed"
        End If
        If Not cmbthur.Text = "ON" Or Not cmbthur.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Thu"
        End If
        If Not cmbfri.Text = "ON" Or Not cmbfri.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Fir"
        End If
        If Not cmbsat.Text = "ON" Or Not cmbsat.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Sat"
        End If
        If Not cmbsun.Text = "ON" Or Not cmbsun.Text = "OFF" Then
            ErrorFound = "Please select the promotion option on Sun"
        End If

        If txthh.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If
        If txthh2.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If

        If txtmm.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If

        If txtmm2.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If

        If txtss.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If

        If txtss2.Text = "" Then
            ErrorFound = "Please enter the time frames"
        End If

        If cmbTime1.Text = "" Then
            ErrorFound = "Please Select the time format"
        End If
        If cmbTime2.Text = "" Then
            ErrorFound = "Please Select the time format"
        End If
        '
        Return ErrorFound
    End Function

    Private Sub chkDateFrames_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDateFrames.CheckedChanged

    End Sub

    Private Sub txtAmmendPromotion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmmendPromotion.TextChanged
        If cmbPromotionType.Text = "Price" Then
            txtPromotionPrice.Text = txtAmmendPromotion.Text

        ElseIf cmbPromotionType.Text = "Percentage" Then
            txtPromotionPrice.Text = CDbl(TxtItemSellingPrice.Text) * CDbl(txtAmmendPromotion.Text) / 100
        End If
    End Sub
End Class