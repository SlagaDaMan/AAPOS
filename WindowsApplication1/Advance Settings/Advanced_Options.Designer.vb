<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advanced_Options
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
        Me.btnSystem_Setting = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnCapture_Invoices = New System.Windows.Forms.Button()
        Me.btnCompany_Info = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSuppliers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSystem_Setting
        '
        Me.btnSystem_Setting.Location = New System.Drawing.Point(185, 148)
        Me.btnSystem_Setting.Name = "btnSystem_Setting"
        Me.btnSystem_Setting.Size = New System.Drawing.Size(387, 71)
        Me.btnSystem_Setting.TabIndex = 0
        Me.btnSystem_Setting.Text = "System Setting"
        Me.btnSystem_Setting.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(185, 302)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(387, 71)
        Me.btnReports.TabIndex = 1
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnCapture_Invoices
        '
        Me.btnCapture_Invoices.Location = New System.Drawing.Point(185, 379)
        Me.btnCapture_Invoices.Name = "btnCapture_Invoices"
        Me.btnCapture_Invoices.Size = New System.Drawing.Size(387, 71)
        Me.btnCapture_Invoices.TabIndex = 2
        Me.btnCapture_Invoices.Text = "Capture Invoices"
        Me.btnCapture_Invoices.UseVisualStyleBackColor = True
        '
        'btnCompany_Info
        '
        Me.btnCompany_Info.Location = New System.Drawing.Point(185, 225)
        Me.btnCompany_Info.Name = "btnCompany_Info"
        Me.btnCompany_Info.Size = New System.Drawing.Size(387, 71)
        Me.btnCompany_Info.TabIndex = 3
        Me.btnCompany_Info.Text = "Company Infomation"
        Me.btnCompany_Info.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 78)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Advance Settings"
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(185, 456)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(387, 71)
        Me.btnAccounts.TabIndex = 6
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(646, 623)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 31)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Location = New System.Drawing.Point(185, 533)
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.Size = New System.Drawing.Size(387, 71)
        Me.btnSuppliers.TabIndex = 8
        Me.btnSuppliers.Text = "Suppliers"
        Me.btnSuppliers.UseVisualStyleBackColor = True
        '
        'Advanced_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 666)
        Me.Controls.Add(Me.btnSuppliers)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompany_Info)
        Me.Controls.Add(Me.btnCapture_Invoices)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnSystem_Setting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Advanced_Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced_Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSystem_Setting As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnCapture_Invoices As System.Windows.Forms.Button
    Friend WithEvents btnCompany_Info As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSuppliers As System.Windows.Forms.Button
End Class
