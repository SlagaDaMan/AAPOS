<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromotion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtPromotionPrice = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtAmmendPromotion = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtItemSellingPrice = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtItemStockPrice = New System.Windows.Forms.TextBox()
        Me.cmbPromotionType = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gpDays = New System.Windows.Forms.GroupBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbsun = New System.Windows.Forms.ComboBox()
        Me.cmbsat = New System.Windows.Forms.ComboBox()
        Me.cmbfri = New System.Windows.Forms.ComboBox()
        Me.cmbthur = New System.Windows.Forms.ComboBox()
        Me.cmbwed = New System.Windows.Forms.ComboBox()
        Me.cmbtues = New System.Windows.Forms.ComboBox()
        Me.cmbmon = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chkDateFrames = New System.Windows.Forms.CheckBox()
        Me.grpTime = New System.Windows.Forms.GroupBox()
        Me.cmbTime2 = New System.Windows.Forms.ComboBox()
        Me.cmbTime1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txthh = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtmm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtss = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtss2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtmm2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txthh2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkEnableDate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkEnableTime = New System.Windows.Forms.CheckBox()
        Me.btnPromotion = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.Stock_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stock_ItemsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.AAPOSDataSet1 = New WindowsApplication1.AAPOSDataSet1()
        Me.PromotionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PromotionsTableAdapter = New WindowsApplication1.AAPOSDataSet1TableAdapters.PromotionsTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.AAPOSDataSet1TableAdapters.TableAdapterManager()
        Me.grpDetails.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpDays.SuspendLayout()
        Me.grpTime.SuspendLayout()
        Me.grpDate.SuspendLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAPOSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Promotion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scan Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.Location = New System.Drawing.Point(26, 69)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(196, 20)
        Me.txtBarcode.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Promotion Status"
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(159, 40)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.ReadOnly = True
        Me.txtItemDescription.Size = New System.Drawing.Size(196, 20)
        Me.txtItemDescription.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Item Description"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbStatus.Location = New System.Drawing.Point(486, 43)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(105, 21)
        Me.cmbStatus.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Edit Status"
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Location = New System.Drawing.Point(159, 76)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(15, 14)
        Me.chkStatus.TabIndex = 9
        Me.chkStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.Label26)
        Me.grpDetails.Controls.Add(Me.txtPromotionPrice)
        Me.grpDetails.Controls.Add(Me.Label25)
        Me.grpDetails.Controls.Add(Me.txtAmmendPromotion)
        Me.grpDetails.Controls.Add(Me.Label24)
        Me.grpDetails.Controls.Add(Me.TxtItemSellingPrice)
        Me.grpDetails.Controls.Add(Me.Label22)
        Me.grpDetails.Controls.Add(Me.Label23)
        Me.grpDetails.Controls.Add(Me.TxtItemStockPrice)
        Me.grpDetails.Controls.Add(Me.cmbPromotionType)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.chkStatus)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.Label5)
        Me.grpDetails.Controls.Add(Me.txtItemDescription)
        Me.grpDetails.Controls.Add(Me.cmbStatus)
        Me.grpDetails.Location = New System.Drawing.Point(26, 95)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(749, 182)
        Me.grpDetails.TabIndex = 10
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Promotion Deatils"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(386, 141)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Promotion Price"
        '
        'txtPromotionPrice
        '
        Me.txtPromotionPrice.Location = New System.Drawing.Point(486, 139)
        Me.txtPromotionPrice.Name = "txtPromotionPrice"
        Me.txtPromotionPrice.ReadOnly = True
        Me.txtPromotionPrice.Size = New System.Drawing.Size(196, 20)
        Me.txtPromotionPrice.TabIndex = 19
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(59, 138)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(98, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Ammend Promotion"
        '
        'txtAmmendPromotion
        '
        Me.txtAmmendPromotion.Location = New System.Drawing.Point(159, 136)
        Me.txtAmmendPromotion.Name = "txtAmmendPromotion"
        Me.txtAmmendPromotion.Size = New System.Drawing.Size(196, 20)
        Me.txtAmmendPromotion.TabIndex = 17
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(387, 109)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Item Selling Price"
        '
        'TxtItemSellingPrice
        '
        Me.TxtItemSellingPrice.Location = New System.Drawing.Point(485, 107)
        Me.TxtItemSellingPrice.Name = "TxtItemSellingPrice"
        Me.TxtItemSellingPrice.ReadOnly = True
        Me.TxtItemSellingPrice.Size = New System.Drawing.Size(196, 20)
        Me.TxtItemSellingPrice.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(61, 108)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Item Stock Price"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(387, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Promotion Type"
        '
        'TxtItemStockPrice
        '
        Me.TxtItemStockPrice.Location = New System.Drawing.Point(159, 106)
        Me.TxtItemStockPrice.Name = "TxtItemStockPrice"
        Me.TxtItemStockPrice.ReadOnly = True
        Me.TxtItemStockPrice.Size = New System.Drawing.Size(196, 20)
        Me.TxtItemStockPrice.TabIndex = 12
        '
        'cmbPromotionType
        '
        Me.cmbPromotionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPromotionType.FormattingEnabled = True
        Me.cmbPromotionType.Items.AddRange(New Object() {"Percentage", "Price"})
        Me.cmbPromotionType.Location = New System.Drawing.Point(486, 73)
        Me.cmbPromotionType.Name = "cmbPromotionType"
        Me.cmbPromotionType.Size = New System.Drawing.Size(105, 21)
        Me.cmbPromotionType.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gpDays)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.chkDateFrames)
        Me.GroupBox2.Controls.Add(Me.grpTime)
        Me.GroupBox2.Controls.Add(Me.grpDate)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ChkEnableDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ChkEnableTime)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(749, 277)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Promotion"
        '
        'gpDays
        '
        Me.gpDays.Controls.Add(Me.Label34)
        Me.gpDays.Controls.Add(Me.Label33)
        Me.gpDays.Controls.Add(Me.Label32)
        Me.gpDays.Controls.Add(Me.Label31)
        Me.gpDays.Controls.Add(Me.Label30)
        Me.gpDays.Controls.Add(Me.Label29)
        Me.gpDays.Controls.Add(Me.Label28)
        Me.gpDays.Controls.Add(Me.cmbsun)
        Me.gpDays.Controls.Add(Me.cmbsat)
        Me.gpDays.Controls.Add(Me.cmbfri)
        Me.gpDays.Controls.Add(Me.cmbthur)
        Me.gpDays.Controls.Add(Me.cmbwed)
        Me.gpDays.Controls.Add(Me.cmbtues)
        Me.gpDays.Controls.Add(Me.cmbmon)
        Me.gpDays.Location = New System.Drawing.Point(26, 34)
        Me.gpDays.Name = "gpDays"
        Me.gpDays.Size = New System.Drawing.Size(689, 73)
        Me.gpDays.TabIndex = 18
        Me.gpDays.TabStop = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(512, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 13)
        Me.Label34.TabIndex = 49
        Me.Label34.Text = "SUN"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(446, 22)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(28, 13)
        Me.Label33.TabIndex = 48
        Me.Label33.Text = "SAT"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(383, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 13)
        Me.Label32.TabIndex = 47
        Me.Label32.Text = "FRI"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(307, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 13)
        Me.Label31.TabIndex = 46
        Me.Label31.Text = "THUR"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(238, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 13)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "WED"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(170, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(36, 13)
        Me.Label29.TabIndex = 44
        Me.Label29.Text = "TUES"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(106, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(32, 13)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "MON"
        '
        'cmbsun
        '
        Me.cmbsun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsun.FormattingEnabled = True
        Me.cmbsun.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbsun.Location = New System.Drawing.Point(508, 40)
        Me.cmbsun.Name = "cmbsun"
        Me.cmbsun.Size = New System.Drawing.Size(53, 21)
        Me.cmbsun.TabIndex = 42
        '
        'cmbsat
        '
        Me.cmbsat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsat.FormattingEnabled = True
        Me.cmbsat.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbsat.Location = New System.Drawing.Point(438, 40)
        Me.cmbsat.Name = "cmbsat"
        Me.cmbsat.Size = New System.Drawing.Size(53, 21)
        Me.cmbsat.TabIndex = 41
        '
        'cmbfri
        '
        Me.cmbfri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbfri.FormattingEnabled = True
        Me.cmbfri.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbfri.Location = New System.Drawing.Point(370, 40)
        Me.cmbfri.Name = "cmbfri"
        Me.cmbfri.Size = New System.Drawing.Size(53, 21)
        Me.cmbfri.TabIndex = 40
        '
        'cmbthur
        '
        Me.cmbthur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbthur.FormattingEnabled = True
        Me.cmbthur.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbthur.Location = New System.Drawing.Point(301, 40)
        Me.cmbthur.Name = "cmbthur"
        Me.cmbthur.Size = New System.Drawing.Size(53, 21)
        Me.cmbthur.TabIndex = 39
        '
        'cmbwed
        '
        Me.cmbwed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbwed.FormattingEnabled = True
        Me.cmbwed.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbwed.Location = New System.Drawing.Point(231, 40)
        Me.cmbwed.Name = "cmbwed"
        Me.cmbwed.Size = New System.Drawing.Size(53, 21)
        Me.cmbwed.TabIndex = 38
        '
        'cmbtues
        '
        Me.cmbtues.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtues.FormattingEnabled = True
        Me.cmbtues.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbtues.Location = New System.Drawing.Point(163, 40)
        Me.cmbtues.Name = "cmbtues"
        Me.cmbtues.Size = New System.Drawing.Size(53, 21)
        Me.cmbtues.TabIndex = 37
        '
        'cmbmon
        '
        Me.cmbmon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbmon.FormattingEnabled = True
        Me.cmbmon.Items.AddRange(New Object() {"ON", "OFF"})
        Me.cmbmon.Location = New System.Drawing.Point(96, 40)
        Me.cmbmon.Name = "cmbmon"
        Me.cmbmon.Size = New System.Drawing.Size(53, 21)
        Me.cmbmon.TabIndex = 36
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(23, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 17
        Me.Label27.Text = "Date Frames"
        '
        'chkDateFrames
        '
        Me.chkDateFrames.AutoSize = True
        Me.chkDateFrames.Location = New System.Drawing.Point(97, 17)
        Me.chkDateFrames.Name = "chkDateFrames"
        Me.chkDateFrames.Size = New System.Drawing.Size(15, 14)
        Me.chkDateFrames.TabIndex = 16
        Me.chkDateFrames.UseVisualStyleBackColor = True
        '
        'grpTime
        '
        Me.grpTime.Controls.Add(Me.cmbTime2)
        Me.grpTime.Controls.Add(Me.cmbTime1)
        Me.grpTime.Controls.Add(Me.Label11)
        Me.grpTime.Controls.Add(Me.Label17)
        Me.grpTime.Controls.Add(Me.txthh)
        Me.grpTime.Controls.Add(Me.Label18)
        Me.grpTime.Controls.Add(Me.txtmm)
        Me.grpTime.Controls.Add(Me.Label19)
        Me.grpTime.Controls.Add(Me.txtss)
        Me.grpTime.Controls.Add(Me.Label20)
        Me.grpTime.Controls.Add(Me.Label10)
        Me.grpTime.Controls.Add(Me.Label21)
        Me.grpTime.Controls.Add(Me.Label12)
        Me.grpTime.Controls.Add(Me.txtss2)
        Me.grpTime.Controls.Add(Me.Label13)
        Me.grpTime.Controls.Add(Me.txtmm2)
        Me.grpTime.Controls.Add(Me.Label14)
        Me.grpTime.Controls.Add(Me.txthh2)
        Me.grpTime.Controls.Add(Me.Label15)
        Me.grpTime.Controls.Add(Me.Label16)
        Me.grpTime.Location = New System.Drawing.Point(26, 209)
        Me.grpTime.Name = "grpTime"
        Me.grpTime.Size = New System.Drawing.Size(689, 53)
        Me.grpTime.TabIndex = 15
        Me.grpTime.TabStop = False
        '
        'cmbTime2
        '
        Me.cmbTime2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime2.FormattingEnabled = True
        Me.cmbTime2.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTime2.Location = New System.Drawing.Point(590, 13)
        Me.cmbTime2.Name = "cmbTime2"
        Me.cmbTime2.Size = New System.Drawing.Size(53, 21)
        Me.cmbTime2.TabIndex = 35
        '
        'cmbTime1
        '
        Me.cmbTime1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTime1.FormattingEnabled = True
        Me.cmbTime1.Items.AddRange(New Object() {"AM", "PM"})
        Me.cmbTime1.Location = New System.Drawing.Point(216, 13)
        Me.cmbTime1.Name = "cmbTime1"
        Me.cmbTime1.Size = New System.Drawing.Size(53, 21)
        Me.cmbTime1.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "From"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(534, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = ":"
        '
        'txthh
        '
        Me.txthh.Location = New System.Drawing.Point(70, 13)
        Me.txthh.Name = "txthh"
        Me.txthh.Size = New System.Drawing.Size(37, 20)
        Me.txthh.TabIndex = 13
        Me.txthh.Text = "00"
        Me.txthh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(483, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(10, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = ":"
        '
        'txtmm
        '
        Me.txtmm.Location = New System.Drawing.Point(119, 13)
        Me.txtmm.MaxLength = 2
        Me.txtmm.Name = "txtmm"
        Me.txtmm.Size = New System.Drawing.Size(37, 20)
        Me.txtmm.TabIndex = 14
        Me.txtmm.Text = "00"
        Me.txtmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(547, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "ss"
        '
        'txtss
        '
        Me.txtss.Location = New System.Drawing.Point(173, 13)
        Me.txtss.MaxLength = 2
        Me.txtss.Name = "txtss"
        Me.txtss.Size = New System.Drawing.Size(37, 20)
        Me.txtss.TabIndex = 15
        Me.txtss.Text = "00"
        Me.txtss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(500, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 13)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "mm"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(390, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "To"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(451, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "hh"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(77, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "hh"
        '
        'txtss2
        '
        Me.txtss2.Location = New System.Drawing.Point(547, 12)
        Me.txtss2.MaxLength = 2
        Me.txtss2.Name = "txtss2"
        Me.txtss2.Size = New System.Drawing.Size(37, 20)
        Me.txtss2.TabIndex = 28
        Me.txtss2.Text = "00"
        Me.txtss2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(126, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "mm"
        '
        'txtmm2
        '
        Me.txtmm2.Location = New System.Drawing.Point(493, 12)
        Me.txtmm2.MaxLength = 2
        Me.txtmm2.Name = "txtmm2"
        Me.txtmm2.Size = New System.Drawing.Size(37, 20)
        Me.txtmm2.TabIndex = 27
        Me.txtmm2.Text = "00"
        Me.txtmm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(173, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "ss"
        '
        'txthh2
        '
        Me.txthh2.Location = New System.Drawing.Point(444, 12)
        Me.txthh2.MaxLength = 2
        Me.txthh2.Name = "txthh2"
        Me.txthh2.Size = New System.Drawing.Size(37, 20)
        Me.txthh2.TabIndex = 26
        Me.txthh2.Text = "00"
        Me.txthh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(109, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(160, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = ":"
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.Label6)
        Me.grpDate.Controls.Add(Me.dtpFrom)
        Me.grpDate.Controls.Add(Me.Label7)
        Me.grpDate.Controls.Add(Me.dtpTo)
        Me.grpDate.Location = New System.Drawing.Point(26, 128)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(689, 53)
        Me.grpDate.TabIndex = 14
        Me.grpDate.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "From"
        '
        'dtpFrom
        '
        Me.dtpFrom.Location = New System.Drawing.Point(70, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(200, 20)
        Me.dtpFrom.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(383, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "To"
        '
        'dtpTo
        '
        Me.dtpTo.Location = New System.Drawing.Point(437, 18)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Date Frames"
        '
        'ChkEnableDate
        '
        Me.ChkEnableDate.AutoSize = True
        Me.ChkEnableDate.Location = New System.Drawing.Point(97, 113)
        Me.ChkEnableDate.Name = "ChkEnableDate"
        Me.ChkEnableDate.Size = New System.Drawing.Size(15, 14)
        Me.ChkEnableDate.TabIndex = 11
        Me.ChkEnableDate.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Time Frames"
        '
        'ChkEnableTime
        '
        Me.ChkEnableTime.AutoSize = True
        Me.ChkEnableTime.Location = New System.Drawing.Point(96, 192)
        Me.ChkEnableTime.Name = "ChkEnableTime"
        Me.ChkEnableTime.Size = New System.Drawing.Size(15, 14)
        Me.ChkEnableTime.TabIndex = 9
        Me.ChkEnableTime.UseVisualStyleBackColor = True
        '
        'btnPromotion
        '
        Me.btnPromotion.Location = New System.Drawing.Point(26, 566)
        Me.btnPromotion.Name = "btnPromotion"
        Me.btnPromotion.Size = New System.Drawing.Size(147, 41)
        Me.btnPromotion.TabIndex = 12
        Me.btnPromotion.Text = "Process Promotion"
        Me.btnPromotion.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(628, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(314, 566)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(147, 41)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'AAPOSDataSet
        '
        Me.AAPOSDataSet.DataSetName = "AAPOSDataSet"
        Me.AAPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Stock_ItemsBindingSource
        '
        Me.Stock_ItemsBindingSource.DataMember = "Stock_Items"
        Me.Stock_ItemsBindingSource.DataSource = Me.AAPOSDataSet
        '
        'Stock_ItemsTableAdapter
        '
        Me.Stock_ItemsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Me.Stock_ItemsTableAdapter
        Me.TableAdapterManager.SupplierDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierPayOutTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.Till_SetupTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'AAPOSDataSet1
        '
        Me.AAPOSDataSet1.DataSetName = "AAPOSDataSet1"
        Me.AAPOSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PromotionsBindingSource
        '
        Me.PromotionsBindingSource.DataMember = "Promotions"
        Me.PromotionsBindingSource.DataSource = Me.AAPOSDataSet1
        '
        'PromotionsTableAdapter
        '
        Me.PromotionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.PromotionsTableAdapter = Me.PromotionsTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.AAPOSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmPromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 627)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPromotion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmPromotion"
        Me.Text = "frmPromotion"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpDays.ResumeLayout(False)
        Me.gpDays.PerformLayout()
        Me.grpTime.ResumeLayout(False)
        Me.grpTime.PerformLayout()
        Me.grpDate.ResumeLayout(False)
        Me.grpDate.PerformLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAPOSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PromotionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkStatus As System.Windows.Forms.CheckBox
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtss As System.Windows.Forms.TextBox
    Friend WithEvents txtmm As System.Windows.Forms.TextBox
    Friend WithEvents txthh As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkEnableDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkEnableTime As System.Windows.Forms.CheckBox
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnPromotion As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtss2 As System.Windows.Forms.TextBox
    Friend WithEvents txtmm2 As System.Windows.Forms.TextBox
    Friend WithEvents txthh2 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpTime As System.Windows.Forms.GroupBox
    Friend WithEvents grpDate As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents cmbTime2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTime1 As System.Windows.Forms.ComboBox
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents Stock_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stock_ItemsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtPromotionPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAmmendPromotion As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TxtItemSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtItemStockPrice As System.Windows.Forms.TextBox
    Friend WithEvents cmbPromotionType As System.Windows.Forms.ComboBox
    Friend WithEvents gpDays As System.Windows.Forms.GroupBox
    Friend WithEvents cmbsun As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbfri As System.Windows.Forms.ComboBox
    Friend WithEvents cmbthur As System.Windows.Forms.ComboBox
    Friend WithEvents cmbwed As System.Windows.Forms.ComboBox
    Friend WithEvents cmbtues As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmon As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents chkDateFrames As System.Windows.Forms.CheckBox
    Friend WithEvents AAPOSDataSet1 As WindowsApplication1.AAPOSDataSet1
    Friend WithEvents PromotionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PromotionsTableAdapter As WindowsApplication1.AAPOSDataSet1TableAdapters.PromotionsTableAdapter
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.AAPOSDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
End Class
