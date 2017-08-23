<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vw_Graficos_I
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Dbo_coociDataSet = New EjemploDatasetSQL.dbo_coociDataSet()
        Me.TblProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_ProyectosTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_ProyectosTableAdapter()
        Me.ReftblProyectos13BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_detalleClienteTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_detalleClienteTableAdapter()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReftblProyectos13BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(419, 284)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Grafico"
        '
        'Dbo_coociDataSet
        '
        Me.Dbo_coociDataSet.DataSetName = "dbo_coociDataSet"
        Me.Dbo_coociDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProyectosBindingSource
        '
        Me.TblProyectosBindingSource.DataMember = "tbl_Proyectos"
        Me.TblProyectosBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'Tbl_ProyectosTableAdapter
        '
        Me.Tbl_ProyectosTableAdapter.ClearBeforeFill = True
        '
        'ReftblProyectos13BindingSource
        '
        Me.ReftblProyectos13BindingSource.DataMember = "Reftbl_Proyectos13"
        Me.ReftblProyectos13BindingSource.DataSource = Me.TblProyectosBindingSource
        '
        'Tbl_detalleClienteTableAdapter
        '
        Me.Tbl_detalleClienteTableAdapter.ClearBeforeFill = True
        '
        'vw_Graficos_I
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 284)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "vw_Graficos_I"
        Me.Text = "vw_Graficos_I"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReftblProyectos13BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Dbo_coociDataSet As EjemploDatasetSQL.dbo_coociDataSet
    Friend WithEvents TblProyectosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_ProyectosTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_ProyectosTableAdapter
    Friend WithEvents ReftblProyectos13BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_detalleClienteTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_detalleClienteTableAdapter
End Class
