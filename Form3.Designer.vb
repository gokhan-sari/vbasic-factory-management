<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.vtDataSet = New uretim_ve_imalat.vtDataSet()
        Me.hammaddeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.hammaddeTableAdapter = New uretim_ve_imalat.vtDataSetTableAdapters.hammaddeTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.urunstokBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.urunstokTableAdapter = New uretim_ve_imalat.vtDataSetTableAdapters.urunstokTableAdapter()
        CType(Me.vtDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hammaddeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.urunstokBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.hammaddeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "uretim_ve_imalat.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(25, 25)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 250)
        Me.ReportViewer1.TabIndex = 0
        '
        'vtDataSet
        '
        Me.vtDataSet.DataSetName = "vtDataSet"
        Me.vtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'hammaddeBindingSource
        '
        Me.hammaddeBindingSource.DataMember = "hammadde"
        Me.hammaddeBindingSource.DataSource = Me.vtDataSet
        '
        'hammaddeTableAdapter
        '
        Me.hammaddeTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.urunstokBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "uretim_ve_imalat.Report2.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(25, 295)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(800, 250)
        Me.ReportViewer2.TabIndex = 1
        '
        'urunstokBindingSource
        '
        Me.urunstokBindingSource.DataMember = "urunstok"
        Me.urunstokBindingSource.DataSource = Me.vtDataSet
        '
        'urunstokTableAdapter
        '
        Me.urunstokTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 574)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Üretim ve İmalat Otomasyonu"
        CType(Me.vtDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hammaddeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.urunstokBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents hammaddeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents vtDataSet As uretim_ve_imalat.vtDataSet
    Friend WithEvents hammaddeTableAdapter As uretim_ve_imalat.vtDataSetTableAdapters.hammaddeTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents urunstokBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents urunstokTableAdapter As uretim_ve_imalat.vtDataSetTableAdapters.urunstokTableAdapter
End Class
