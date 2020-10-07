Public Class frmAdvanceReports

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        Advanced_Options.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmStock_Stats_Report.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmFinancial_Stats.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        frmIndividual_Stock_Stats.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        VAT_Income_Report.Show()
        Me.Hide()

    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        frmTransaction_History.Show()
        Me.Hide()

    End Sub

    Private Sub btnWeeklyReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeeklyReport.Click
        AWeekly.Show()
        Me.Hide()

    End Sub
End Class