Imports Microsoft.Reporting.WinForms

Public Class Sales_Person_Stats
    Public Shared total, Cash, ellectronically As Double
    Private Sub Sales_Person_Stats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AAPOSDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.AAPOSDataSet.Users)
        For i = 0 To AAPOSDataSet.Users.Count - 1

            Dim name As String = AAPOSDataSet.Users.Rows(i)("Name").ToString()
            Dim Surname As String = AAPOSDataSet.Users.Rows(i)("Surname").ToString()
            cmbUsers.Items.Add(name & " " & Surname)
        Next
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.AAPOSDataSet.Sales)
        'TODO: This line of code loads data into the 'AAPOSDataSet.Sales' table. You can move, or remove it, as needed.

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'If cmbSRD.Text = "" Then
        '    MessageBox.Show("Please select the type of sale you would like to view", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        'If cmbtype.Text = "" Then
        '    MessageBox.Show("Please select the type of sale you would like to view", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        If cmbUsers.Text = "" Then
            MessageBox.Show("Please select the user you would like to view", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim date_start1 As String = Format(DateTimePicker1.Value, "yyyy/MM/dd")
        Dim final_date1 As String = date_start1 & "  01:10:19 AM"

        Dim date_start2 As String = Format(DateTimePicker2.Value, "yyyy/MM/dd")
        Dim final_date2 As String = date_start2 & "  11:59:19 PM"
        If cmbUsers.Text = "ALL" Then
            Me.SalesTableAdapter.FillByDate(Me.AAPOSDataSet.Sales, final_date1, final_date2)
            For i = 0 To AAPOSDataSet.Sales.Count - 1
                Dim Price As String = Val(AAPOSDataSet.Sales.Rows(i)("Selling_Price").ToString)
                Cash = Cash + Price
            Next
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Else

            Me.SalesTableAdapter.FillByNameDateEftType(Me.AAPOSDataSet.Sales, final_date1, final_date2, cmbUsers.Text, cmbtype.Text, cmbSRD.Text)



            For i = 0 To AAPOSDataSet.Sales.Count - 1
                Dim Price As String = Val(AAPOSDataSet.Sales.Rows(i)("Selling_Price").ToString)
                Cash = Cash + Price
            Next
            Me.ReportViewer1.RefreshReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        End If
        Dim Total_Amount As New ReportParameter("total", "R" & String.Format("{0:n}", Convert.ToDouble(Cash)))
        ReportViewer1.LocalReport.SetParameters(Total_Amount)
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("    MUSHROOM HUT")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("SALES PERSON STATS")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("FROM : " & date_start1)
        ListBox1.Items.Add("TO   : " & date_start2)
        ListBox1.Items.Add("")
        ListBox1.Items.Add("SALES PERSON NAME ")
        ListBox1.Items.Add(cmbUsers.Text)
        ListBox1.Items.Add("")
        If cmbUsers.Text = "ALL" Then
            ListBox1.Items.Add("TYPE : ALL")
        Else
            ListBox1.Items.Add("TYPE :" & cmbtype.Text)
        End If

        ListBox1.Items.Add("TOTAL SALES : R" & Cash)
        ListBox1.Items.Add("")
        PrintDocument1.Print()

        ListBox1.Items.Clear()

        Cash = 0

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        frmMainScreen.Show()

    End Sub

    Private Sub btnClose1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose1.Click
        Me.Close()
        frmMainScreen.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fnt As New Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point)
        Dim ListBoxItem As String = String.Empty
        For Each LBItem As String In ListBox1.Items
            ListBoxItem = ListBoxItem & vbCrLf & LBItem
        Next
        ListBoxItem = ListBoxItem.Substring(vbCrLf.Length)
        e.Graphics.DrawString(ListBoxItem, fnt, Brushes.Black, 0, 0)
        e.HasMorePages = False
    End Sub

End Class