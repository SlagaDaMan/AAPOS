Imports Microsoft.Reporting.WinForms

Public Class frmPendingSales
    Public Shared Pending_Ref As String
    Private Sub frmPendingSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        '  Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Try
            Me.SalesTableAdapter.FillBySTATUS(Me.AAPOSDataSet.Sales, "PENDING")
            For I = 0 To AAPOSDataSet.Sales.Rows.Count - 1
                Dim REF As String = AAPOSDataSet.Sales.Rows(0)("Reference_Nr").ToString
                cmbReferenceNo.Items.Add(REF)
            Next
        Catch ex As Exception

        End Try
        Me.TopMost = True

    End Sub

    Private Sub SalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SalesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AAPOSDataSet)

    End Sub

    Private Sub btnRetrieve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetrieve.Click

        Try
            Me.SalesTableAdapter.FillByNr(Me.AAPOSDataSet.Sales, cmbReferenceNo.Text)
            Dim Total As Double
            For I = 0 To AAPOSDataSet.Sales.Rows.Count - 1
                Total = Total + Val(AAPOSDataSet.Sales.Rows(I)("Selling_Price").ToString)
            Next
            Dim Outstanding_Amount As New ReportParameter("Total", "R " & String.Format("{0:n}", Convert.ToDouble(Total)))
            ReportViewer1.LocalReport.SetParameters(Outstanding_Amount)
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnResume_Sale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume_Sale.Click
        frmMorefunctions.Suspend = "ON"
        Pending_Ref = cmbReferenceNo.Text
        Try
            Me.SalesTableAdapter.FillByNr(Me.AAPOSDataSet.Sales, cmbReferenceNo.Text)
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
            '  Form1.txttotals.Text = Total
            Form1.total = Total
            Form1.count = Total
            Form1.lblTotal.Text = "R" + Total.ToString("0.00")
        Catch ex As Exception

        End Try
       
        Me.Close()
    End Sub
End Class