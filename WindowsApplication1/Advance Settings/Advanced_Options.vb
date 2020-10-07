Public Class Advanced_Options

    Private Sub btnSystem_Setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSystem_Setting.Click
        frmSystem_Settings.Show()
        Me.Hide()

    End Sub

    Private Sub btnCompany_Info_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany_Info.Click
        frmCompany_Info.Show()
        Me.Hide()

    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        frmAdvanceReports.Show()
        Me.Hide()

    End Sub

    Private Sub btnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccounts.Click
        frmAccounts.Show()
        Me.Hide()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnSuppliers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuppliers.Click
        Me.Hide()
        frmsuppliers.Show()
    End Sub
End Class