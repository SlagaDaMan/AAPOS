Public Class Stock_Stats

    Private Sub Stock_ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Stock_ItemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub Stock_Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
        Dim counttotal As Double = 0
        Dim countStock As Double = 0
        Try
            Dim count_int As Integer = Stock_ItemsDataGridView.RowCount

            For i = 0 To count_int - 2
                Dim Item_Nr As Object = Stock_ItemsDataGridView.Rows(i).Cells("DataGridViewTextBoxColumn7").Value
                Dim item_Selling_price As Double = Val(Stock_ItemsDataGridView.Rows(i).Cells("Item_SellingPrice").Value) * Item_Nr
                counttotal = counttotal + item_Selling_price
                Dim item_Stock_Price As Double = Val(Stock_ItemsDataGridView.Rows(i).Cells("Item_StockPrice").Value) * Item_Nr
                countStock = countStock + item_Stock_Price

                If Item_Nr < 20 Then
                    Stock_ItemsDataGridView.Rows(i).Cells("DataGridViewTextBoxColumn7").Style.BackColor = Color.Red
                Else
                    Stock_ItemsDataGridView.Rows(i).Cells("DataGridViewTextBoxColumn7").Style.BackColor = Color.White
                End If
            Next
        Catch ex As Exception
        End Try
        Dim total_profit As Double = counttotal - countStock
        lblStock.Text = "R " & String.Format("{0:n}", Convert.ToDouble(counttotal))
        lblProfit.Text = "R " & String.Format("{0:n}", Convert.ToDouble(total_profit))

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Report_Stock.Show()


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Stock_Items.Show()

    End Sub
End Class