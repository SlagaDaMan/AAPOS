Public Class lookups

    'Private Sub Stock_ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.Stock_ItemsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    'End Sub

    Private Sub lookups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Try

      
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)

        For i = 0 To AAPOSDataSet.Stock_Items.Count
            ComboBox1.Items.Add(AAPOSDataSet.Stock_Items.Rows(i)("Item_Description"))
            Next
        Catch ex As Exception

        End Try
        Me.TopMost = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try

      
        Stock_ItemsTableAdapter.FillByDes(Me.AAPOSDataSet.Stock_Items, ComboBox1.Text)
        TextBox1.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_BarCode")
            TextBox2.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_SellingPrice")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class