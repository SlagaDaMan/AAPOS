Public Class frmLogin
    Public Shared name, surname, cell_phone, profile, province As String
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Me.UsersTableAdapter.FillBylogpass(Me.AAPOSDataSet.Users, txtUserName.Text, txtPassword.Text)
        Dim count As Integer = AAPOSDataSet.Users.Count
        If count = 1 Then
            MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            name = AAPOSDataSet.Users.Rows(0)("Name").ToString
            surname = AAPOSDataSet.Users.Rows(0)("Surname").ToString
            cell_phone = AAPOSDataSet.Users.Rows(0)("Cell_Number").ToString
            profile = AAPOSDataSet.Users.Rows(0)("Profile").ToString
            province = AAPOSDataSet.Users.Rows(0)("Province").ToString
            Me.Hide()

            If profile = "STOCK MANAGER" Then
                Stock_Items.Show()
                Exit Sub
            End If

            If profile = "SALES" Then
                Form1.Show()
                Exit Sub
            End If

            If profile = "ADMINISTRATOR" Then
                frmMainScreen.Show()
                Exit Sub
            End If

            If profile = "SUPPORT" Then
                frmMainScreen.Show()
                Exit Sub
            End If
         
        Else
            MessageBox.Show("Incorrect Login details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Users' table. You can move, or remove it, as needed.
        PicCancel01.Visible = True
        PicOk01.Visible = True
        PicCancel02.Visible = False
        PicOk02.Visible = False
        Dim a2 As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
        If a2 > "2020/11/10  07:04:21" Then
            MessageBox.Show("License has expired!!, Please contact ace ends for the license renewal", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'MessageBox.Show("Connection Error", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()

        End If


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub PicMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicMaster.Click
      
    End Sub


    Private Sub PicOk01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicOk01.MouseMove
        PicCancel01.Visible = True
        PicOk01.Visible = False
        PicCancel02.Visible = False
        PicOk02.Visible = True
    End Sub
    Private Sub PicOk02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicOk02.MouseClick
        Me.UsersTableAdapter.FillBylogpass(Me.AAPOSDataSet.Users, txtUserName.Text, txtPassword.Text)
        Dim count As Integer = AAPOSDataSet.Users.Count
        If count = 1 Then
            ' MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            name = AAPOSDataSet.Users.Rows(0)("Name").ToString
            surname = AAPOSDataSet.Users.Rows(0)("Surname").ToString
            cell_phone = AAPOSDataSet.Users.Rows(0)("Cell_Number").ToString
            profile = AAPOSDataSet.Users.Rows(0)("Profile").ToString
            province = AAPOSDataSet.Users.Rows(0)("Province").ToString
            Me.Hide()

            If profile = "STOCK MANAGER" Then
                Stock_Items.Show()
                Exit Sub
            End If

            If profile = "SALES" Then
                Form1.Show()
                Exit Sub
            End If

            If profile = "ADMINISTRATOR" Then
                frmMainScreen.Show()
                Exit Sub
            End If

            If profile = "SUPPORT" Then
                frmMainScreen.Show()
                Exit Sub
            End If

        Else
            MessageBox.Show("Incorrect Login details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub PicCancel01_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicCancel01.MouseMove
        PicCancel01.Visible = False
        PicOk01.Visible = True
        PicCancel02.Visible = True
        PicOk02.Visible = False
    End Sub
    Private Sub PicCancel02_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicCancel02.MouseClick
        Me.Close()
    End Sub

    Private Sub PicMaster_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PicMaster.MouseMove
        PicCancel01.Visible = True
        PicOk01.Visible = True
        PicCancel02.Visible = False
        PicOk02.Visible = False
    End Sub

    Private Sub PicOk02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicOk02.Click

    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.UsersTableAdapter.FillBylogpass(Me.AAPOSDataSet.Users, txtUserName.Text, txtPassword.Text)
            Dim count As Integer = AAPOSDataSet.Users.Count
            If count = 1 Then
                ' MessageBox.Show("Login successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                name = AAPOSDataSet.Users.Rows(0)("Name").ToString
                surname = AAPOSDataSet.Users.Rows(0)("Surname").ToString
                cell_phone = AAPOSDataSet.Users.Rows(0)("Cell_Number").ToString
                profile = AAPOSDataSet.Users.Rows(0)("Profile").ToString
                province = AAPOSDataSet.Users.Rows(0)("Province").ToString
                Me.Hide()

                If profile = "STOCK MANAGER" Then
                    Stock_Items.Show()
                    Exit Sub
                End If

                If profile = "SALES" Then
                    Form1.Show()
                    Exit Sub
                End If

                If profile = "ADMINISTRATOR" Then
                    frmMainScreen.Show()
                    Exit Sub
                End If

                If profile = "SUPPORT" Then
                    frmMainScreen.Show()
                    Exit Sub
                End If

            Else
                MessageBox.Show("Incorrect Login details", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class