<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stock_Items))
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtNumberOfItems = New System.Windows.Forms.TextBox()
        Me.TxtItemSellingPrice = New System.Windows.Forms.TextBox()
        Me.TxtItemStockPrice = New System.Windows.Forms.TextBox()
        Me.TxtItemDescription = New System.Windows.Forms.TextBox()
        Me.TxtItemBarcode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCredit = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSuppliers = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalAm = New System.Windows.Forms.TextBox()
        Me.txtPer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLinkBarcode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cmboption = New System.Windows.Forms.ComboBox()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.Stock_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stock_ItemsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.AutogenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutogenTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter()
        Me.btnTotal_Stock = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.txtref = New System.Windows.Forms.TextBox()
        Me.btnUpdateRe = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter()
        Me.TotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.TotalsTableAdapter()
        Me.btnExtraFuctions = New System.Windows.Forms.Button()
        Me.SupplierTransectionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierTransectionsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SupplierTransectionsTableAdapter()
        Me.SupplierDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierDetailsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SupplierDetailsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierTransectionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(33, 637)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(122, 39)
        Me.BtnAdd.TabIndex = 30
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtNumberOfItems
        '
        Me.TxtNumberOfItems.Location = New System.Drawing.Point(241, 166)
        Me.TxtNumberOfItems.Name = "TxtNumberOfItems"
        Me.TxtNumberOfItems.Size = New System.Drawing.Size(248, 20)
        Me.TxtNumberOfItems.TabIndex = 29
        '
        'TxtItemSellingPrice
        '
        Me.TxtItemSellingPrice.Location = New System.Drawing.Point(241, 133)
        Me.TxtItemSellingPrice.Name = "TxtItemSellingPrice"
        Me.TxtItemSellingPrice.Size = New System.Drawing.Size(248, 20)
        Me.TxtItemSellingPrice.TabIndex = 28
        '
        'TxtItemStockPrice
        '
        Me.TxtItemStockPrice.Location = New System.Drawing.Point(241, 97)
        Me.TxtItemStockPrice.Name = "TxtItemStockPrice"
        Me.TxtItemStockPrice.Size = New System.Drawing.Size(248, 20)
        Me.TxtItemStockPrice.TabIndex = 27
        '
        'TxtItemDescription
        '
        Me.TxtItemDescription.Location = New System.Drawing.Point(241, 60)
        Me.TxtItemDescription.Name = "TxtItemDescription"
        Me.TxtItemDescription.Size = New System.Drawing.Size(248, 20)
        Me.TxtItemDescription.TabIndex = 26
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.Location = New System.Drawing.Point(241, 25)
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.Size = New System.Drawing.Size(248, 20)
        Me.TxtItemBarcode.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 20)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Number of Items:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 20)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Item Selling Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Item Stock Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Item Description:"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(42, 25)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(122, 20)
        Me.Lbl.TabIndex = 20
        Me.Lbl.Text = "Item Barcode:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "1. Add New Item to Database"
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(887, 637)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(122, 39)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 59)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Stock Items"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbCredit)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbSuppliers)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txttotalAm)
        Me.GroupBox1.Controls.Add(Me.txtPer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Lbl)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtNumberOfItems)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtItemSellingPrice)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtItemStockPrice)
        Me.GroupBox1.Controls.Add(Me.TxtItemBarcode)
        Me.GroupBox1.Controls.Add(Me.TxtItemDescription)
        Me.GroupBox1.Location = New System.Drawing.Point(78, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(917, 334)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(633, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 20)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Credit"
        '
        'cmbCredit
        '
        Me.cmbCredit.FormattingEnabled = True
        Me.cmbCredit.Items.AddRange(New Object() {"YES", "NO"})
        Me.cmbCredit.Location = New System.Drawing.Point(696, 27)
        Me.cmbCredit.Name = "cmbCredit"
        Me.cmbCredit.Size = New System.Drawing.Size(181, 21)
        Me.cmbCredit.TabIndex = 50
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(558, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 20)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Link to Supplier"
        '
        'cmbSuppliers
        '
        Me.cmbSuppliers.FormattingEnabled = True
        Me.cmbSuppliers.Location = New System.Drawing.Point(696, 60)
        Me.cmbSuppliers.Name = "cmbSuppliers"
        Me.cmbSuppliers.Size = New System.Drawing.Size(181, 21)
        Me.cmbSuppliers.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(554, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Total Profit Exlu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 20)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Profit Per Item Exlu"
        '
        'txttotalAm
        '
        Me.txttotalAm.Location = New System.Drawing.Point(696, 129)
        Me.txttotalAm.Name = "txttotalAm"
        Me.txttotalAm.ReadOnly = True
        Me.txttotalAm.Size = New System.Drawing.Size(181, 20)
        Me.txttotalAm.TabIndex = 45
        '
        'txtPer
        '
        Me.txtPer.Location = New System.Drawing.Point(696, 94)
        Me.txtPer.Name = "txtPer"
        Me.txtPer.ReadOnly = True
        Me.txtPer.Size = New System.Drawing.Size(181, 20)
        Me.txtPer.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(274, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Link Barcodes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLinkBarcode)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 238)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 73)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Packs"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(220, 44)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(248, 20)
        Me.txtTotal.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Link Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Total Items"
        '
        'txtLinkBarcode
        '
        Me.txtLinkBarcode.Location = New System.Drawing.Point(220, 18)
        Me.txtLinkBarcode.Name = "txtLinkBarcode"
        Me.txtLinkBarcode.Size = New System.Drawing.Size(248, 20)
        Me.txtLinkBarcode.TabIndex = 32
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(-9, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(27, 719)
        Me.Panel1.TabIndex = 33
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(1046, -7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(22, 719)
        Me.Panel2.TabIndex = 34
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(-6, -4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1067, 20)
        Me.Panel3.TabIndex = 35
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(2, 694)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1064, 20)
        Me.Panel4.TabIndex = 36
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(177, 637)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(122, 39)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cmboption
        '
        Me.cmboption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboption.FormattingEnabled = True
        Me.cmboption.Location = New System.Drawing.Point(33, 201)
        Me.cmboption.Name = "cmboption"
        Me.cmboption.Size = New System.Drawing.Size(248, 21)
        Me.cmboption.TabIndex = 39
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
        'AutogenBindingSource
        '
        Me.AutogenBindingSource.DataMember = "Autogen"
        Me.AutogenBindingSource.DataSource = Me.AAPOSDataSet
        '
        'AutogenTableAdapter
        '
        Me.AutogenTableAdapter.ClearBeforeFill = True
        '
        'btnTotal_Stock
        '
        Me.btnTotal_Stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal_Stock.Location = New System.Drawing.Point(759, 637)
        Me.btnTotal_Stock.Name = "btnTotal_Stock"
        Me.btnTotal_Stock.Size = New System.Drawing.Size(122, 39)
        Me.btnTotal_Stock.TabIndex = 40
        Me.btnTotal_Stock.Text = "Total Stock"
        Me.btnTotal_Stock.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.Location = New System.Drawing.Point(341, 637)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(122, 39)
        Me.btnMenu.TabIndex = 41
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'txtref
        '
        Me.txtref.Location = New System.Drawing.Point(297, 201)
        Me.txtref.Name = "txtref"
        Me.txtref.Size = New System.Drawing.Size(248, 20)
        Me.txtref.TabIndex = 44
        '
        'btnUpdateRe
        '
        Me.btnUpdateRe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateRe.Location = New System.Drawing.Point(565, 190)
        Me.btnUpdateRe.Name = "btnUpdateRe"
        Me.btnUpdateRe.Size = New System.Drawing.Size(122, 39)
        Me.btnUpdateRe.TabIndex = 45
        Me.btnUpdateRe.Text = "Update"
        Me.btnUpdateRe.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(351, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Reference No :"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.AAPOSDataSet
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TotalsBindingSource
        '
        Me.TotalsBindingSource.DataMember = "Totals"
        Me.TotalsBindingSource.DataSource = Me.AAPOSDataSet
        '
        'TotalsTableAdapter
        '
        Me.TotalsTableAdapter.ClearBeforeFill = True
        '
        'btnExtraFuctions
        '
        Me.btnExtraFuctions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtraFuctions.Location = New System.Drawing.Point(587, 637)
        Me.btnExtraFuctions.Name = "btnExtraFuctions"
        Me.btnExtraFuctions.Size = New System.Drawing.Size(166, 39)
        Me.btnExtraFuctions.TabIndex = 46
        Me.btnExtraFuctions.Text = "Extra Functions"
        Me.btnExtraFuctions.UseVisualStyleBackColor = True
        '
        'SupplierTransectionsBindingSource
        '
        Me.SupplierTransectionsBindingSource.DataMember = "SupplierTransections"
        Me.SupplierTransectionsBindingSource.DataSource = Me.AAPOSDataSet
        '
        'SupplierTransectionsTableAdapter
        '
        Me.SupplierTransectionsTableAdapter.ClearBeforeFill = True
        '
        'SupplierDetailsBindingSource
        '
        Me.SupplierDetailsBindingSource.DataMember = "SupplierDetails"
        Me.SupplierDetailsBindingSource.DataSource = Me.AAPOSDataSet
        '
        'SupplierDetailsTableAdapter
        '
        Me.SupplierDetailsTableAdapter.ClearBeforeFill = True
        '
        'Stock_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1068, 714)
        Me.Controls.Add(Me.btnExtraFuctions)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdateRe)
        Me.Controls.Add(Me.txtref)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnTotal_Stock)
        Me.Controls.Add(Me.cmboption)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Stock_Items"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock_Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierTransectionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtNumberOfItems As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemSellingPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemStockPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtItemBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lbl As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents Stock_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Stock_ItemsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutogenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutogenTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cmboption As System.Windows.Forms.ComboBox
    Friend WithEvents btnTotal_Stock As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLinkBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents txtref As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdateRe As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TotalsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.TotalsTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotalAm As System.Windows.Forms.TextBox
    Friend WithEvents txtPer As System.Windows.Forms.TextBox
    Friend WithEvents btnExtraFuctions As System.Windows.Forms.Button
    Friend WithEvents SupplierTransectionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierTransectionsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SupplierTransectionsTableAdapter
    Friend WithEvents SupplierDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierDetailsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SupplierDetailsTableAdapter
    Friend WithEvents cmbSuppliers As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbCredit As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
