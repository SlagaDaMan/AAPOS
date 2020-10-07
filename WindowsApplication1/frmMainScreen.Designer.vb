<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainScreen))
        Me.btnStock_Items = New System.Windows.Forms.Button()
        Me.btnPos = New System.Windows.Forms.Button()
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCreateUsers = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PicMaster = New System.Windows.Forms.PictureBox()
        Me.picStock_Items = New System.Windows.Forms.PictureBox()
        Me.picpos = New System.Windows.Forms.PictureBox()
        Me.picstats = New System.Windows.Forms.PictureBox()
        Me.piccreateusers = New System.Windows.Forms.PictureBox()
        Me.picsales = New System.Windows.Forms.PictureBox()
        Me.piclogout = New System.Windows.Forms.PictureBox()
        Me.picStock_Items02 = New System.Windows.Forms.PictureBox()
        Me.picpos02 = New System.Windows.Forms.PictureBox()
        Me.picstats02 = New System.Windows.Forms.PictureBox()
        Me.piccreateusers02 = New System.Windows.Forms.PictureBox()
        Me.picsales02 = New System.Windows.Forms.PictureBox()
        Me.piclogout02 = New System.Windows.Forms.PictureBox()
        CType(Me.PicMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStock_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccreateusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStock_Items02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picpos02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picstats02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piccreateusers02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picsales02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piclogout02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStock_Items
        '
        Me.btnStock_Items.Location = New System.Drawing.Point(12, 141)
        Me.btnStock_Items.Name = "btnStock_Items"
        Me.btnStock_Items.Size = New System.Drawing.Size(227, 177)
        Me.btnStock_Items.TabIndex = 0
        Me.btnStock_Items.Text = "Stock Items"
        Me.btnStock_Items.UseVisualStyleBackColor = True
        '
        'btnPos
        '
        Me.btnPos.Location = New System.Drawing.Point(245, 141)
        Me.btnPos.Name = "btnPos"
        Me.btnPos.Size = New System.Drawing.Size(227, 177)
        Me.btnPos.TabIndex = 1
        Me.btnPos.Text = "POS"
        Me.btnPos.UseVisualStyleBackColor = True
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(12, 324)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(227, 177)
        Me.btnStats.TabIndex = 2
        Me.btnStats.Text = "STATS"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(12, 507)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(227, 177)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "Sales Person"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(245, 507)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(227, 177)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "LogOut"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnCreateUsers
        '
        Me.btnCreateUsers.Location = New System.Drawing.Point(245, 324)
        Me.btnCreateUsers.Name = "btnCreateUsers"
        Me.btnCreateUsers.Size = New System.Drawing.Size(227, 177)
        Me.btnCreateUsers.TabIndex = 5
        Me.btnCreateUsers.Text = "Create Users"
        Me.btnCreateUsers.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(391, 118)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "MUSHROOM HUT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "      Main Sreen"
        '
        'PicMaster
        '
        Me.PicMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicMaster.Image = CType(resources.GetObject("PicMaster.Image"), System.Drawing.Image)
        Me.PicMaster.Location = New System.Drawing.Point(0, 0)
        Me.PicMaster.Name = "PicMaster"
        Me.PicMaster.Size = New System.Drawing.Size(490, 701)
        Me.PicMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMaster.TabIndex = 51
        Me.PicMaster.TabStop = False
        '
        'picStock_Items
        '
        Me.picStock_Items.Image = CType(resources.GetObject("picStock_Items.Image"), System.Drawing.Image)
        Me.picStock_Items.Location = New System.Drawing.Point(65, 141)
        Me.picStock_Items.Name = "picStock_Items"
        Me.picStock_Items.Size = New System.Drawing.Size(148, 151)
        Me.picStock_Items.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStock_Items.TabIndex = 52
        Me.picStock_Items.TabStop = False
        '
        'picpos
        '
        Me.picpos.Image = CType(resources.GetObject("picpos.Image"), System.Drawing.Image)
        Me.picpos.Location = New System.Drawing.Point(262, 141)
        Me.picpos.Name = "picpos"
        Me.picpos.Size = New System.Drawing.Size(156, 151)
        Me.picpos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpos.TabIndex = 53
        Me.picpos.TabStop = False
        '
        'picstats
        '
        Me.picstats.Image = CType(resources.GetObject("picstats.Image"), System.Drawing.Image)
        Me.picstats.Location = New System.Drawing.Point(65, 324)
        Me.picstats.Name = "picstats"
        Me.picstats.Size = New System.Drawing.Size(156, 151)
        Me.picstats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstats.TabIndex = 54
        Me.picstats.TabStop = False
        '
        'piccreateusers
        '
        Me.piccreateusers.Image = CType(resources.GetObject("piccreateusers.Image"), System.Drawing.Image)
        Me.piccreateusers.Location = New System.Drawing.Point(262, 324)
        Me.piccreateusers.Name = "piccreateusers"
        Me.piccreateusers.Size = New System.Drawing.Size(156, 151)
        Me.piccreateusers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccreateusers.TabIndex = 55
        Me.piccreateusers.TabStop = False
        '
        'picsales
        '
        Me.picsales.Image = CType(resources.GetObject("picsales.Image"), System.Drawing.Image)
        Me.picsales.Location = New System.Drawing.Point(62, 512)
        Me.picsales.Name = "picsales"
        Me.picsales.Size = New System.Drawing.Size(156, 151)
        Me.picsales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsales.TabIndex = 56
        Me.picsales.TabStop = False
        '
        'piclogout
        '
        Me.piclogout.Image = CType(resources.GetObject("piclogout.Image"), System.Drawing.Image)
        Me.piclogout.Location = New System.Drawing.Point(262, 512)
        Me.piclogout.Name = "piclogout"
        Me.piclogout.Size = New System.Drawing.Size(156, 151)
        Me.piclogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogout.TabIndex = 57
        Me.piclogout.TabStop = False
        '
        'picStock_Items02
        '
        Me.picStock_Items02.Image = CType(resources.GetObject("picStock_Items02.Image"), System.Drawing.Image)
        Me.picStock_Items02.Location = New System.Drawing.Point(65, 141)
        Me.picStock_Items02.Name = "picStock_Items02"
        Me.picStock_Items02.Size = New System.Drawing.Size(148, 151)
        Me.picStock_Items02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStock_Items02.TabIndex = 58
        Me.picStock_Items02.TabStop = False
        '
        'picpos02
        '
        Me.picpos02.Image = CType(resources.GetObject("picpos02.Image"), System.Drawing.Image)
        Me.picpos02.Location = New System.Drawing.Point(262, 141)
        Me.picpos02.Name = "picpos02"
        Me.picpos02.Size = New System.Drawing.Size(156, 151)
        Me.picpos02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picpos02.TabIndex = 59
        Me.picpos02.TabStop = False
        '
        'picstats02
        '
        Me.picstats02.Image = CType(resources.GetObject("picstats02.Image"), System.Drawing.Image)
        Me.picstats02.Location = New System.Drawing.Point(65, 324)
        Me.picstats02.Name = "picstats02"
        Me.picstats02.Size = New System.Drawing.Size(156, 151)
        Me.picstats02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picstats02.TabIndex = 60
        Me.picstats02.TabStop = False
        '
        'piccreateusers02
        '
        Me.piccreateusers02.Image = CType(resources.GetObject("piccreateusers02.Image"), System.Drawing.Image)
        Me.piccreateusers02.Location = New System.Drawing.Point(262, 324)
        Me.piccreateusers02.Name = "piccreateusers02"
        Me.piccreateusers02.Size = New System.Drawing.Size(156, 151)
        Me.piccreateusers02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piccreateusers02.TabIndex = 61
        Me.piccreateusers02.TabStop = False
        '
        'picsales02
        '
        Me.picsales02.Image = CType(resources.GetObject("picsales02.Image"), System.Drawing.Image)
        Me.picsales02.Location = New System.Drawing.Point(62, 512)
        Me.picsales02.Name = "picsales02"
        Me.picsales02.Size = New System.Drawing.Size(156, 151)
        Me.picsales02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picsales02.TabIndex = 62
        Me.picsales02.TabStop = False
        '
        'piclogout02
        '
        Me.piclogout02.Image = CType(resources.GetObject("piclogout02.Image"), System.Drawing.Image)
        Me.piclogout02.Location = New System.Drawing.Point(262, 512)
        Me.piclogout02.Name = "piclogout02"
        Me.piclogout02.Size = New System.Drawing.Size(156, 151)
        Me.piclogout02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.piclogout02.TabIndex = 63
        Me.piclogout02.TabStop = False
        '
        'frmMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(490, 701)
        Me.Controls.Add(Me.piclogout02)
        Me.Controls.Add(Me.picsales02)
        Me.Controls.Add(Me.piccreateusers02)
        Me.Controls.Add(Me.picstats02)
        Me.Controls.Add(Me.picpos02)
        Me.Controls.Add(Me.picStock_Items02)
        Me.Controls.Add(Me.piclogout)
        Me.Controls.Add(Me.picsales)
        Me.Controls.Add(Me.piccreateusers)
        Me.Controls.Add(Me.picstats)
        Me.Controls.Add(Me.picpos)
        Me.Controls.Add(Me.picStock_Items)
        Me.Controls.Add(Me.PicMaster)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCreateUsers)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnPos)
        Me.Controls.Add(Me.btnStock_Items)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMainScreen"
        CType(Me.PicMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStock_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccreateusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStock_Items02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picpos02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picstats02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piccreateusers02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picsales02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piclogout02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStock_Items As System.Windows.Forms.Button
    Friend WithEvents btnPos As System.Windows.Forms.Button
    Friend WithEvents btnStats As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnCreateUsers As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PicMaster As System.Windows.Forms.PictureBox
    Friend WithEvents picStock_Items As System.Windows.Forms.PictureBox
    Friend WithEvents picpos As System.Windows.Forms.PictureBox
    Friend WithEvents picstats As System.Windows.Forms.PictureBox
    Friend WithEvents piccreateusers As System.Windows.Forms.PictureBox
    Friend WithEvents picsales As System.Windows.Forms.PictureBox
    Friend WithEvents piclogout As System.Windows.Forms.PictureBox
    Friend WithEvents picStock_Items02 As System.Windows.Forms.PictureBox
    Friend WithEvents picpos02 As System.Windows.Forms.PictureBox
    Friend WithEvents picstats02 As System.Windows.Forms.PictureBox
    Friend WithEvents piccreateusers02 As System.Windows.Forms.PictureBox
    Friend WithEvents picsales02 As System.Windows.Forms.PictureBox
    Friend WithEvents piclogout02 As System.Windows.Forms.PictureBox
End Class
