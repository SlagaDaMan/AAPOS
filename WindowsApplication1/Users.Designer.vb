<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProfileLabel1 As System.Windows.Forms.Label
        Dim NameLabel1 As System.Windows.Forms.Label
        Dim SurnameLabel1 As System.Windows.Forms.Label
        Dim Fax_NumberLabel1 As System.Windows.Forms.Label
        Dim Work_NumberLabel1 As System.Windows.Forms.Label
        Dim Cell_NumberLabel1 As System.Windows.Forms.Label
        Dim Email_AddressLabel1 As System.Windows.Forms.Label
        Dim Log_IDLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim ProvinceLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCreateUsers = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTest = New System.Windows.Forms.Button()
        Me.Cell_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Work_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.Fax_NumberTextBox1 = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Log_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProfileComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProvinceComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.AutogenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutogenTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.UsersTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.UsersTableAdapter()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ProfileLabel1 = New System.Windows.Forms.Label()
        NameLabel1 = New System.Windows.Forms.Label()
        SurnameLabel1 = New System.Windows.Forms.Label()
        Fax_NumberLabel1 = New System.Windows.Forms.Label()
        Work_NumberLabel1 = New System.Windows.Forms.Label()
        Cell_NumberLabel1 = New System.Windows.Forms.Label()
        Email_AddressLabel1 = New System.Windows.Forms.Label()
        Log_IDLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        ProvinceLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProfileLabel1
        '
        ProfileLabel1.AutoSize = True
        ProfileLabel1.Location = New System.Drawing.Point(35, 190)
        ProfileLabel1.Name = "ProfileLabel1"
        ProfileLabel1.Size = New System.Drawing.Size(39, 13)
        ProfileLabel1.TabIndex = 40
        ProfileLabel1.Text = "Profile:"
        '
        'NameLabel1
        '
        NameLabel1.AutoSize = True
        NameLabel1.Location = New System.Drawing.Point(32, 45)
        NameLabel1.Name = "NameLabel1"
        NameLabel1.Size = New System.Drawing.Size(38, 13)
        NameLabel1.TabIndex = 32
        NameLabel1.Text = "Name:"
        '
        'SurnameLabel1
        '
        SurnameLabel1.AutoSize = True
        SurnameLabel1.Location = New System.Drawing.Point(22, 77)
        SurnameLabel1.Name = "SurnameLabel1"
        SurnameLabel1.Size = New System.Drawing.Size(52, 13)
        SurnameLabel1.TabIndex = 34
        SurnameLabel1.Text = "Surname:"
        '
        'Fax_NumberLabel1
        '
        Fax_NumberLabel1.AutoSize = True
        Fax_NumberLabel1.Location = New System.Drawing.Point(28, 29)
        Fax_NumberLabel1.Name = "Fax_NumberLabel1"
        Fax_NumberLabel1.Size = New System.Drawing.Size(67, 13)
        Fax_NumberLabel1.TabIndex = 44
        Fax_NumberLabel1.Text = "Fax Number:"
        '
        'Work_NumberLabel1
        '
        Work_NumberLabel1.AutoSize = True
        Work_NumberLabel1.Location = New System.Drawing.Point(19, 115)
        Work_NumberLabel1.Name = "Work_NumberLabel1"
        Work_NumberLabel1.Size = New System.Drawing.Size(76, 13)
        Work_NumberLabel1.TabIndex = 48
        Work_NumberLabel1.Text = "Work Number:"
        '
        'Cell_NumberLabel1
        '
        Cell_NumberLabel1.AutoSize = True
        Cell_NumberLabel1.Location = New System.Drawing.Point(28, 71)
        Cell_NumberLabel1.Name = "Cell_NumberLabel1"
        Cell_NumberLabel1.Size = New System.Drawing.Size(67, 13)
        Cell_NumberLabel1.TabIndex = 46
        Cell_NumberLabel1.Text = "Cell Number:"
        '
        'Email_AddressLabel1
        '
        Email_AddressLabel1.AutoSize = True
        Email_AddressLabel1.Location = New System.Drawing.Point(19, 161)
        Email_AddressLabel1.Name = "Email_AddressLabel1"
        Email_AddressLabel1.Size = New System.Drawing.Size(76, 13)
        Email_AddressLabel1.TabIndex = 50
        Email_AddressLabel1.Text = "Email Address:"
        '
        'Log_IDLabel1
        '
        Log_IDLabel1.AutoSize = True
        Log_IDLabel1.Location = New System.Drawing.Point(32, 113)
        Log_IDLabel1.Name = "Log_IDLabel1"
        Log_IDLabel1.Size = New System.Drawing.Size(42, 13)
        Log_IDLabel1.TabIndex = 36
        Log_IDLabel1.Text = "Log ID:"
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(22, 152)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(56, 13)
        PasswordLabel1.TabIndex = 38
        PasswordLabel1.Text = "Password:"
        '
        'ProvinceLabel1
        '
        ProvinceLabel1.AutoSize = True
        ProvinceLabel1.Location = New System.Drawing.Point(22, 224)
        ProvinceLabel1.Name = "ProvinceLabel1"
        ProvinceLabel1.Size = New System.Drawing.Size(52, 13)
        ProvinceLabel1.TabIndex = 42
        ProvinceLabel1.Text = "Province:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(699, 444)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(130, 41)
        Me.btnClose.TabIndex = 50
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCreateUsers
        '
        Me.btnCreateUsers.BackColor = System.Drawing.Color.White
        Me.btnCreateUsers.Location = New System.Drawing.Point(72, 444)
        Me.btnCreateUsers.Name = "btnCreateUsers"
        Me.btnCreateUsers.Size = New System.Drawing.Size(130, 41)
        Me.btnCreateUsers.TabIndex = 49
        Me.btnCreateUsers.Text = "Create Users"
        Me.btnCreateUsers.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NameComboBox)
        Me.GroupBox2.Controls.Add(ProfileLabel1)
        Me.GroupBox2.Controls.Add(NameLabel1)
        Me.GroupBox2.Controls.Add(SurnameLabel1)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.SurnameTextBox1)
        Me.GroupBox2.Controls.Add(Log_IDLabel1)
        Me.GroupBox2.Controls.Add(Me.Log_IDTextBox1)
        Me.GroupBox2.Controls.Add(PasswordLabel1)
        Me.GroupBox2.Controls.Add(Me.PasswordTextBox1)
        Me.GroupBox2.Controls.Add(Me.ProfileComboBox1)
        Me.GroupBox2.Controls.Add(Me.ProvinceComboBox1)
        Me.GroupBox2.Controls.Add(ProvinceLabel1)
        Me.GroupBox2.Location = New System.Drawing.Point(111, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(673, 306)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personal Details"
        '
        'NameComboBox
        '
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(104, 42)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(143, 21)
        Me.NameComboBox.TabIndex = 44
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTest)
        Me.GroupBox1.Controls.Add(Fax_NumberLabel1)
        Me.GroupBox1.Controls.Add(Work_NumberLabel1)
        Me.GroupBox1.Controls.Add(Me.Cell_NumberTextBox1)
        Me.GroupBox1.Controls.Add(Me.Email_AddressTextBox1)
        Me.GroupBox1.Controls.Add(Cell_NumberLabel1)
        Me.GroupBox1.Controls.Add(Me.Work_NumberTextBox1)
        Me.GroupBox1.Controls.Add(Email_AddressLabel1)
        Me.GroupBox1.Controls.Add(Me.Fax_NumberTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 203)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Details"
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(238, 156)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(61, 23)
        Me.txtTest.TabIndex = 28
        Me.txtTest.Text = "Test"
        Me.txtTest.UseVisualStyleBackColor = True
        '
        'Cell_NumberTextBox1
        '
        Me.Cell_NumberTextBox1.Location = New System.Drawing.Point(101, 68)
        Me.Cell_NumberTextBox1.Name = "Cell_NumberTextBox1"
        Me.Cell_NumberTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.Cell_NumberTextBox1.TabIndex = 47
        '
        'Email_AddressTextBox1
        '
        Me.Email_AddressTextBox1.Location = New System.Drawing.Point(101, 158)
        Me.Email_AddressTextBox1.Name = "Email_AddressTextBox1"
        Me.Email_AddressTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.Email_AddressTextBox1.TabIndex = 51
        '
        'Work_NumberTextBox1
        '
        Me.Work_NumberTextBox1.Location = New System.Drawing.Point(101, 112)
        Me.Work_NumberTextBox1.Name = "Work_NumberTextBox1"
        Me.Work_NumberTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.Work_NumberTextBox1.TabIndex = 49
        '
        'Fax_NumberTextBox1
        '
        Me.Fax_NumberTextBox1.Location = New System.Drawing.Point(101, 26)
        Me.Fax_NumberTextBox1.Name = "Fax_NumberTextBox1"
        Me.Fax_NumberTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.Fax_NumberTextBox1.TabIndex = 45
        '
        'SurnameTextBox1
        '
        Me.SurnameTextBox1.Location = New System.Drawing.Point(104, 77)
        Me.SurnameTextBox1.Name = "SurnameTextBox1"
        Me.SurnameTextBox1.Size = New System.Drawing.Size(143, 20)
        Me.SurnameTextBox1.TabIndex = 35
        '
        'Log_IDTextBox1
        '
        Me.Log_IDTextBox1.Location = New System.Drawing.Point(104, 110)
        Me.Log_IDTextBox1.Name = "Log_IDTextBox1"
        Me.Log_IDTextBox1.Size = New System.Drawing.Size(143, 20)
        Me.Log_IDTextBox1.TabIndex = 37
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.Location = New System.Drawing.Point(104, 149)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(143, 20)
        Me.PasswordTextBox1.TabIndex = 39
        '
        'ProfileComboBox1
        '
        Me.ProfileComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProfileComboBox1.FormattingEnabled = True
        Me.ProfileComboBox1.Items.AddRange(New Object() {"STOCK MANAGER", "SALES", "ADMINISTRATOR", "SUPPORT"})
        Me.ProfileComboBox1.Location = New System.Drawing.Point(104, 182)
        Me.ProfileComboBox1.Name = "ProfileComboBox1"
        Me.ProfileComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ProfileComboBox1.TabIndex = 41
        '
        'ProvinceComboBox1
        '
        Me.ProvinceComboBox1.FormattingEnabled = True
        Me.ProvinceComboBox1.Location = New System.Drawing.Point(104, 221)
        Me.ProvinceComboBox1.Name = "ProvinceComboBox1"
        Me.ProvinceComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ProvinceComboBox1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(318, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 31)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Create Users Screen"
        '
        'AAPOSDataSet
        '
        Me.AAPOSDataSet.DataSetName = "AAPOSDataSet"
        Me.AAPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutogenBindingSource
        '
        Me.AutogenBindingSource.DataMember = "Autogen"
        Me.AutogenBindingSource.DataSource = Me.AAPOSDataSet
        '
        'AutogenTableAdapter
        '
        Me.AutogenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutogenTableAdapter = Me.AutogenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AAPOSDataSet
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 498)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreateUsers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCreateUsers As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTest As System.Windows.Forms.Button
    Friend WithEvents Cell_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Work_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Fax_NumberTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Log_IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ProfileComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ProvinceComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents AutogenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutogenTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsersTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
End Class
