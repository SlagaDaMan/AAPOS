Public Class frmMainScreen

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Close()

    End Sub

    Private Sub btnStock_Items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock_Items.Click
        Me.Hide()
        Stock_Items.Show()

    End Sub

    Private Sub btnPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPos.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btnCreateUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUsers.Click
        Users.Show()
        Me.Hide()

    End Sub

    Private Sub btnStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats.Click
        Stats.Show()
        Me.Hide()


    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Sales_Person_Stats.Show()
        Me.Hide()

    End Sub

    Private Sub PicMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMaster.Click

    End Sub

    

    Private Sub frmMainScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub

    Private Sub picStock_Items_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picStock_Items.MouseMove
        picStock_Items.Visible = False
        picStock_Items02.Visible = True
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
    Private Sub picStock_Items02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picStock_Items02.MouseClick
        Me.Hide()
        Stock_Items.Show()
    End Sub


    Private Sub picpos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picpos.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = False
        picpos02.Visible = True
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
    Private Sub picpos02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picpos02.MouseClick
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub picstats_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picstats.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = False
        picstats02.Visible = True
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
    Private Sub picstats02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picstats02.MouseClick
        Main_Stats.Show()
        Me.Hide()
    End Sub

    Private Sub piccreateusers_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles piccreateusers.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = False
        piccreateusers02.Visible = True
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
    Private Sub piccreateusers02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles piccreateusers02.MouseClick
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub picsales_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picsales.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = False
        picsales02.Visible = True
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
    Private Sub picsales02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picsales02.MouseClick
        Sales_Person_Stats.Show()
        Me.Hide()
    End Sub

    Private Sub piclogout_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles piclogout.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = False
        piclogout02.Visible = True
    End Sub
    Private Sub piclogout02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles piclogout02.MouseClick
       Me.Close()
    End Sub


    Private Sub PicMaster_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicMaster.MouseMove
        picStock_Items.Visible = True
        picStock_Items02.Visible = False
        picpos.Visible = True
        picpos02.Visible = False
        picstats.Visible = True
        picstats02.Visible = False
        piccreateusers.Visible = True
        piccreateusers02.Visible = False
        picsales.Visible = True
        picsales02.Visible = False
        piclogout.Visible = True
        piclogout02.Visible = False
    End Sub
End Class