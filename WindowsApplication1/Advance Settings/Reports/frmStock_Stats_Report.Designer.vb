<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock_Stats_Report
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Stock_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.AutogenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutogenTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter()
        Me.Stock_ItemsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Stock_ItemsBindingSource
        '
        Me.Stock_ItemsBindingSource.DataMember = "Stock_Items"
        Me.Stock_ItemsBindingSource.DataSource = Me.AAPOSDataSet
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
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AutogenTableAdapter = Me.AutogenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Company_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Me.Stock_ItemsTableAdapter
        Me.TableAdapterManager.Till_SetupTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'Stock_ItemsTableAdapter
        '
        Me.Stock_ItemsTableAdapter.ClearBeforeFill = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.AAPOSDataSet
        '
        'ReportViewer1
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Stock_ItemsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Stock_Stats.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, -2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(721, 726)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(604, 737)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmStock_Stats_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 772)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmStock_Stats_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStock_Stats_Report"
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutogenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents AutogenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutogenTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.AutogenTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stock_ItemsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter
    Friend WithEvents Stock_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
