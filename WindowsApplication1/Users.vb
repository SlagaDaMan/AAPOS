Public Class Users

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.AAPOSDataSet.Users)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Autogen' table. You can move, or remove it, as needed.
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        Me.UsersTableAdapter.Fill(Me.AAPOSDataSet.Users)
        ProvinceComboBox1.Items.Add("HEAD OFFICE")
        ProvinceComboBox1.Items.Add("GAUTENG")
        ProvinceComboBox1.Items.Add("WESTERN CAPE")
        ProvinceComboBox1.Items.Add("LIMPOPO")
        ProvinceComboBox1.Items.Add("NORTHERN CAPE")
        ProvinceComboBox1.Items.Add("EASTERN CAPE")
        ProvinceComboBox1.Items.Add("MPUMALANGA")
        ProvinceComboBox1.Items.Add("NORTH WEST")
        ProvinceComboBox1.Items.Add("Kwa zulu Natal")
        ProvinceComboBox1.Items.Add("FREE STATE")
        Dim a As Integer = AAPOSDataSet.Users.Rows.Count()
        Try
            For value As Integer = 0 To a - 1
                Dim name As String = AAPOSDataSet.Users.Rows(value)("Log_ID").ToString()
                NameComboBox.Items.Add(name)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameComboBox.SelectedIndexChanged
        Try


            UsersTableAdapter.FillByLogin(AAPOSDataSet.Users, NameComboBox.Text)

            Dim Name As String = AAPOSDataSet.Users.Rows(0)("Name").ToString()
            Dim Surname As String = AAPOSDataSet.Users.Rows(0)("Surname").ToString()
            Dim Log_ID As String = AAPOSDataSet.Users.Rows(0)("Log_ID").ToString()
            Dim Password As String = AAPOSDataSet.Users.Rows(0)("Password").ToString()
            Dim Profile As String = AAPOSDataSet.Users.Rows(0)("Profile").ToString()
            Dim Province As String = AAPOSDataSet.Users.Rows(0)("Province").ToString()
            Dim Fax_Number As String = AAPOSDataSet.Users.Rows(0)("Fax_Number").ToString()
            Dim Cell_Number As String = AAPOSDataSet.Users.Rows(0)("Cell_Number").ToString()
            Dim Work_Number As String = AAPOSDataSet.Users.Rows(0)("Work_Number").ToString()
            Dim Email_Address As String = AAPOSDataSet.Users.Rows(0)("Email_Address").ToString()

            NameComboBox.Text = Name
            SurnameTextBox1.Text = Surname
            Log_IDTextBox1.Text = Log_ID
            PasswordTextBox1.Text = Password
            ProfileComboBox1.Text = Profile
            ProvinceComboBox1.Text = Province
            Fax_NumberTextBox1.Text = Fax_Number
            Cell_NumberTextBox1.Text = Cell_Number
            Work_NumberTextBox1.Text = Work_Number
            Email_AddressTextBox1.Text = Email_Address
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCreateUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateUsers.Click
        Dim a2 As String = Format(Now, "yyyy/MM/dd  hh:mm:ss")
        Dim time2, day2, hh2, mm2, year2, month2, ref2 As String
        Dim creaRef2 As String
        year2 = a2.Substring(2, 2)
        month2 = a2.Substring(5, 2)
        day2 = a2.Substring(8, 2)
        hh2 = a2.Substring(12, 2)
        mm2 = a2.Substring(15, 2)
        ref2 = year2 + month2 + day2
        Dim count As Integer = 0
        Me.AutogenTableAdapter.Fill(Me.AAPOSDataSet.Autogen)
        count = Val(AAPOSDataSet.Autogen.Rows(0)("Autonum").ToString) + 1
        Try
            UsersTableAdapter.Insert(count, UCase(NameComboBox.Text), UCase(SurnameTextBox1.Text), Log_IDTextBox1.Text, PasswordTextBox1.Text, ProfileComboBox1.Text, ProvinceComboBox1.Text, Fax_NumberTextBox1.Text, Cell_NumberTextBox1.Text, Work_NumberTextBox1.Text, Email_AddressTextBox1.Text, "", "", "")
            AutogenTableAdapter.UpdateQueryUsers(count, 1)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        NameComboBox.Text = ""
        SurnameTextBox1.Text = ""
        Log_IDTextBox1.Text = ""
        PasswordTextBox1.Text = ""
        ProfileComboBox1.SelectedIndex = -1
        ProvinceComboBox1.SelectedIndex = -1
        Cell_NumberTextBox1.Text = ""
        Work_NumberTextBox1.Text = ""
        Fax_NumberTextBox1.Text = ""
        Email_AddressTextBox1.Text = ""
        MessageBox.Show("The user has been successfully created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmMainScreen.Show()

    End Sub
End Class