﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinancial_Stats
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnRetrieve = New System.Windows.Forms.Button()
        Me.AAPOSDataSet = New WindowsApplication1.AAPOSDataSet()
        Me.TotalsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.TotalsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager()
        Me.Stock_ItemsTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter()
        Me.Stock_ItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesTableAdapter = New WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter()
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.frmFinancial_Stats.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 52)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(867, 787)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(744, 846)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 26)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(219, 26)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'btnRetrieve
        '
        Me.btnRetrieve.Location = New System.Drawing.Point(435, 23)
        Me.btnRetrieve.Name = "btnRetrieve"
        Me.btnRetrieve.Size = New System.Drawing.Size(105, 23)
        Me.btnRetrieve.TabIndex = 4
        Me.btnRetrieve.Text = "Retrieve"
        Me.btnRetrieve.UseVisualStyleBackColor = True
        '
        'AAPOSDataSet
        '
        Me.AAPOSDataSet.DataSetName = "AAPOSDataSet"
        Me.AAPOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AutogenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Company_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.ExpensesTableAdapter = Nothing
        Me.TableAdapterManager.MenuTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.Stock_ItemsTableAdapter = Me.Stock_ItemsTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Till_SetupTableAdapter = Nothing
        Me.TableAdapterManager.TotalsTableAdapter = Me.TotalsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Stock_ItemsTableAdapter
        '
        Me.Stock_ItemsTableAdapter.ClearBeforeFill = True
        '
        'Stock_ItemsBindingSource
        '
        Me.Stock_ItemsBindingSource.DataMember = "Stock_Items"
        Me.Stock_ItemsBindingSource.DataSource = Me.AAPOSDataSet
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(560, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'frmFinancial_Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 899)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRetrieve)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFinancial_Stats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFinancial_Stats"
        CType(Me.AAPOSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_ItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRetrieve As System.Windows.Forms.Button
    Friend WithEvents AAPOSDataSet As WindowsApplication1.AAPOSDataSet
    Friend WithEvents TotalsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.TotalsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AAPOSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stock_ItemsTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.Stock_ItemsTableAdapter
    Friend WithEvents Stock_ItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As WindowsApplication1.AAPOSDataSetTableAdapters.SalesTableAdapter
End Class
