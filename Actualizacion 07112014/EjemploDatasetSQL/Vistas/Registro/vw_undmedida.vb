Public Class vw_undmedida
#Region "Atributos"
    Private control As unidadMedida_control
    Private id As Integer
#End Region
#Region "Metodos Y funciones"
    Public Sub Listar()
        control = New unidadMedida_control
        Tbl_unidMedidaDataGridView.DataSource = (control.LISTAR())
        Tbl_unidMedidaDataGridView.Columns(0).Visible = False
        Tbl_unidMedidaDataGridView.Columns(1).HeaderText = "Unidad de Medida"
        Tbl_unidMedidaDataGridView.Columns(2).HeaderText = "Abreviatura"
        Tbl_unidMedidaDataGridView.Columns(1).Width = 400
    End Sub
    Public Sub Guardar()

    End Sub
    Public Sub Nuevo()
        TabPage1.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        UnidMedidaTextBox.Text = ""
        AbreviaturaTextBox.Text = ""
        btnGuardar.Visible = True
    End Sub
    Public Sub CargarDatosdelGrid()
        control = New unidadMedida_control
        control.BUSCARPORID(id)
        UnidMedidaTextBox.Text = control.MODEL.UNIDAD_MEDIDA
        UnidMedidaTextBox.Enabled = False
        AbreviaturaTextBox.Text = control.MODEL.ABREBIATURA
        btnGuardar.Visible = False
    End Sub
#End Region
    Private Sub Tbl_unidMedidaBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.Tbl_unidMedidaBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Dbo_coociDataSet)

    End Sub

    Private Sub vw_undmedida_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_unidMedida' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_unidMedidaTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_unidMedida)
        TabPage1.Parent = Nothing
        Listar()
    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnmin_Click(sender As System.Object, e As System.EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        TabPage1.Parent = Nothing
        UnidMedidaTextBox.Text = ""
        AbreviaturaTextBox.Text = ""
        btnGuardar.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        TabPage1.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        AbreviaturaTextBox.Focus()
        btnActualizar.Visible = True
        CargarDatosdelGrid()
    End Sub

    Private Sub Tbl_unidMedidaDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_unidMedidaDataGridView.CellClick
        id = Tbl_unidMedidaDataGridView.CurrentRow.Cells(0).Value
    End Sub
End Class