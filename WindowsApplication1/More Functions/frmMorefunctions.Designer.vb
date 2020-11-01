<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMorefunctions
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
        Me.btnPrinter = New System.Windows.Forms.Button()
        Me.btnReprintLastSale = New System.Windows.Forms.Button()
        Me.btnSuspendSale = New System.Windows.Forms.Button()
        Me.btnViewPendingSales = New System.Windows.Forms.Button()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.AutogenTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter()
        Me.AutogenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.btnPromotions = New System.Windows.Forms.Button()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrinter
        '
        Me.btnPrinter.Location = New System.Drawing.Point(122, 7)
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(379, 66)
        Me.btnPrinter.TabIndex = 0
        Me.btnPrinter.Text = "Printer Settings"
        Me.btnPrinter.UseVisualStyleBackColor = True
        '
        'btnReprintLastSale
        '
        Me.btnReprintLastSale.Location = New System.Drawing.Point(122, 79)
        Me.btnReprintLastSale.Name = "btnReprintLastSale"
        Me.btnReprintLastSale.Size = New System.Drawing.Size(379, 70)
        Me.btnReprintLastSale.TabIndex = 1
        Me.btnReprintLastSale.Text = "Reprint Last Sale"
        Me.btnReprintLastSale.UseVisualStyleBackColor = True
        '
        'btnSuspendSale
        '
        Me.btnSuspendSale.Location = New System.Drawing.Point(122, 155)
        Me.btnSuspendSale.Name = "btnSuspendSale"
        Me.btnSuspendSale.Size = New System.Drawing.Size(379, 71)
        Me.btnSuspendSale.TabIndex = 2
        Me.btnSuspendSale.Text = "Suspend sale"
        Me.btnSuspendSale.UseVisualStyleBackColor = True
        '
        'btnViewPendingSales
        '
        Me.btnViewPendingSales.Location = New System.Drawing.Point(122, 232)
        Me.btnViewPendingSales.Name = "btnViewPendingSales"
        Me.btnViewPendingSales.Size = New System.Drawing.Size(379, 66)
        Me.btnViewPendingSales.TabIndex = 3
        Me.btnViewPendingSales.Text = "View Pending Sales"
        Me.btnViewPendingSales.UseVisualStyleBackColor = True
        '
        'AAPOSDataSet
        '
        Me.AAPOSDataSet.DataSetName = "AAPOSDataSet"
        Me.AAPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AutogenTableAdapter = Me.AutogenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Company_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.ItemTableAdapter = Nothing
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierDetailsTableAdapter = Nothing
        Me.TableAdapterManager.SupplierPayOutTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTransectionsTableAdapter = Nothing
        Me.TableAdapterManager.Till_SetupTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'AutogenTableAdapter
        '
        Me.AutogenTableAdapter.ClearBeforeFill = True
        '
        'AutogenBindingSource
        '
        Me.AutogenBindingSource.DataMember = "Autogen"
        Me.AutogenBindingSource.DataSource = Me.AAPOSDataSet
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(565, 537)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(62, 27)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(122, 304)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(379, 71)
        Me.btnAccounts.TabIndex = 5
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnExpenses
        '
        Me.btnExpenses.Location = New System.Drawing.Point(122, 381)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(379, 65)
        Me.btnExpenses.TabIndex = 6
        Me.btnExpenses.Text = "Expenses"
        Me.btnExpenses.UseVisualStyleBackColor = True
        '
        'btnPromotions
        '
        Me.btnPromotions.Location = New System.Drawing.Point(122, 452)
        Me.btnPromotions.Name = "btnPromotions"
        Me.btnPromotions.Size = New System.Drawing.Size(379, 65)
        Me.btnPromotions.TabIndex = 7
        Me.btnPromotions.Text = "Promotions"
        Me.btnPromotions.UseVisualStyleBackColor = True
        '
        'frmMorefunctions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 588)
        Me.Controls.Add(Me.btnPromotions)
        Me.Controls.Add(Me.btnExpenses)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnViewPendingSales)
        Me.Controls.Add(Me.btnSuspendSale)
        Me.Controls.Add(Me.btnReprintLastSale)
        Me.Controls.Add(Me.btnPrinter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMorefunctions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMorefunctions"
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrinter As System.Windows.Forms.Button
    Friend WithEvents btnReprintLastSale As System.Windows.Forms.Button
    Friend WithEvents btnSuspendSale As System.Windows.Forms.Button
    Friend WithEvents btnViewPendingSales As System.Windows.Forms.Button
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutogenTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter
    Friend WithEvents AutogenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents btnExpenses As System.Windows.Forms.Button
    Friend WithEvents btnPromotions As Button
End Class
