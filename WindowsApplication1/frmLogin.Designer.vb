<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnok = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PicMaster = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PicOk01 = New System.Windows.Forms.PictureBox()
        Me.PicCancel01 = New System.Windows.Forms.PictureBox()
        Me.PicCancel02 = New System.Windows.Forms.PictureBox()
        Me.PicOk02 = New System.Windows.Forms.PictureBox()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PicMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOk01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCancel01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCancel02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOk02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.BackColor = System.Drawing.Color.White
        Me.btnok.Location = New System.Drawing.Point(448, 356)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(100, 26)
        Me.btnok.TabIndex = 45
        Me.btnok.Text = "OK"
        Me.btnok.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(284, 356)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 26)
        Me.btnClose.TabIndex = 44
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPassword.Location = New System.Drawing.Point(243, 233)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(354, 24)
        Me.txtPassword.TabIndex = 42
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(243, 175)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(354, 24)
        Me.txtUserName.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(715, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 7)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "AAPOS Ace Ends I.T Copyright"
        '
        'PicMaster
        '
        Me.PicMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicMaster.Image = CType(resources.GetObject("PicMaster.Image"), System.Drawing.Image)
        Me.PicMaster.Location = New System.Drawing.Point(0, 0)
        Me.PicMaster.Name = "PicMaster"
        Me.PicMaster.Size = New System.Drawing.Size(833, 394)
        Me.PicMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMaster.TabIndex = 51
        Me.PicMaster.TabStop = False
        '
        'PicOk01
        '
        Me.PicOk01.BackColor = System.Drawing.Color.Silver
        Me.PicOk01.Image = CType(resources.GetObject("PicOk01.Image"), System.Drawing.Image)
        Me.PicOk01.Location = New System.Drawing.Point(276, 294)
        Me.PicOk01.Name = "PicOk01"
        Me.PicOk01.Size = New System.Drawing.Size(122, 37)
        Me.PicOk01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOk01.TabIndex = 52
        Me.PicOk01.TabStop = False
        '
        'PicCancel01
        '
        Me.PicCancel01.BackColor = System.Drawing.Color.Silver
        Me.PicCancel01.Image = CType(resources.GetObject("PicCancel01.Image"), System.Drawing.Image)
        Me.PicCancel01.Location = New System.Drawing.Point(434, 296)
        Me.PicCancel01.Name = "PicCancel01"
        Me.PicCancel01.Size = New System.Drawing.Size(122, 37)
        Me.PicCancel01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCancel01.TabIndex = 53
        Me.PicCancel01.TabStop = False
        '
        'PicCancel02
        '
        Me.PicCancel02.BackColor = System.Drawing.Color.Silver
        Me.PicCancel02.Image = CType(resources.GetObject("PicCancel02.Image"), System.Drawing.Image)
        Me.PicCancel02.Location = New System.Drawing.Point(434, 296)
        Me.PicCancel02.Name = "PicCancel02"
        Me.PicCancel02.Size = New System.Drawing.Size(122, 37)
        Me.PicCancel02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCancel02.TabIndex = 55
        Me.PicCancel02.TabStop = False
        '
        'PicOk02
        '
        Me.PicOk02.BackColor = System.Drawing.Color.Silver
        Me.PicOk02.Image = CType(resources.GetObject("PicOk02.Image"), System.Drawing.Image)
        Me.PicOk02.Location = New System.Drawing.Point(276, 294)
        Me.PicOk02.Name = "PicOk02"
        Me.PicOk02.Size = New System.Drawing.Size(122, 37)
        Me.PicOk02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicOk02.TabIndex = 54
        Me.PicOk02.TabStop = False
        '
        'AAPOSDataSet
        '
        Me.AAPOSDataSet.DataSetName = "AAPOSDataSet"
        Me.AAPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.AAPOSDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AutogenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Company_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ItemTableAdapter = Nothing
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierPayOutTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.Till_SetupTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 7)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Version 2"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(833, 394)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicCancel02)
        Me.Controls.Add(Me.PicOk02)
        Me.Controls.Add(Me.PicCancel01)
        Me.Controls.Add(Me.PicOk01)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.PicMaster)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnok)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        CType(Me.PicMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOk01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCancel01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCancel02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOk02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PicMaster As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PicOk01 As System.Windows.Forms.PictureBox
    Friend WithEvents PicCancel01 As System.Windows.Forms.PictureBox
    Friend WithEvents PicCancel02 As System.Windows.Forms.PictureBox
    Friend WithEvents PicOk02 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
