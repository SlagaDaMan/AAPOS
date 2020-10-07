Imports Microsoft.Reporting.WinForms

Public Class frmIndividual_Stock_Stats

    Private Sub frmIndividual_Stock_Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Stock_Items' table. You can move, or remove it, as needed.
        Try


            Me.Stock_ItemsTableAdapter.Fill(Me.AAPOSDataSet.Stock_Items)
            Dim count As Integer = AAPOSDataSet.Stock_Items.Count
            For i = 0 To count
                cmbBarcode.Items.Add(AAPOSDataSet.Stock_Items.Rows(i)("Item_BarCode").ToString)

            Next
        Catch ex As Exception

        End Try
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)


    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub cmbBarcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBarcode.SelectedIndexChanged
        Try
            Stock_ItemsTableAdapter.FillByBarcode(Me.AAPOSDataSet.Stock_Items, cmbBarcode.Text)
            txtDesc.Text = AAPOSDataSet.Stock_Items.Rows(0)("Item_Description").ToString
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  01:10:19 AM"

        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  11:59:19 PM"
        SalesTableAdapter.FillByCodeDate(AAPOSDataSet.Sales, cmbBarcode.Text, final_date1, final_date2)
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.TopMost = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmAdvanceReports.Show()

    End Sub
End Class