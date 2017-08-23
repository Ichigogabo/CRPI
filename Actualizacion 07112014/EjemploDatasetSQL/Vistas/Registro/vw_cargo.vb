Public Class vw_cargo

#Region "Atributos"
    Private control As cargo_control
    Private id As Integer
#End Region

#Region "Metodos y Funciones"
    Private Sub Nuevo()
        tpcargo.Parent = tccargo
        tccargo.SelectedIndex = 1
        CargoTextBox.Text = Nothing
        CargoTextBox.Enabled = True
        DescripcionTextBox.Text = Nothing
        CargoTextBox.Focus()
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorCountItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
    End Sub
    Public Sub Listar()
        control = New cargo_control
        Tbl_cargoDataGridView.DataSource = control.LISTAR()
        Tbl_cargoDataGridView.Columns(0).Visible = False
        Tbl_cargoDataGridView.Columns(1).HeaderText = "Cargo"
        Tbl_cargoDataGridView.Columns(2).HeaderText = "Descripcion"
        Tbl_cargoDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Tbl_cargoDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Public Sub ListarFiltro()
        control = New cargo_control
        Tbl_cargoDataGridView.DataSource = control.FILTRO(txtbusqueda.Text)
        Tbl_cargoDataGridView.Columns(0).Visible = False
        Tbl_cargoDataGridView.Columns(1).HeaderText = "Cargo"
        Tbl_cargoDataGridView.Columns(2).HeaderText = "Descripcion"
        Tbl_cargoDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Tbl_cargoDataGridView.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
    Public Sub CargarDatosdelGrid()
        control = New cargo_control
        control.BUSCARPORID(id)
        CargoTextBox.Text = control.MODEL.Cargo
        CargoTextBox.Enabled = False
        DescripcionTextBox.Text = control.MODEL.Descripcion
        btnGuardar.Visible = False
    End Sub
    Private Sub Guardar()
        control = New cargo_control
        If control.EXISTE(CargoTextBox.Text) Then
            MsgBox("Este Cargo ya Existe", MsgBoxStyle.Critical)
        Else


            control.MODEL.Cargo = CargoTextBox.Text
            control.MODEL.Descripcion = DescripcionTextBox.Text
            control.INSERTAR()
            tpcargo.Parent = Nothing
            MsgBox("Se almaceno correcatamente este cargo")
            Listar()
        End If
    End Sub
    Public Sub Actualizar()
        control = New cargo_control
        tpcargo.Parent = Nothing
        control.MODEL.ID = id
        control.MODEL.Cargo = CargoTextBox.Text
        control.MODEL.Descripcion = DescripcionTextBox.Text
        control.ACTUALIZAR()
        Listar()
        MsgBox("Se actualizo correctamente los datos del cargo " & CargoTextBox.Text, MsgBoxStyle.Information)
    End Sub
#End Region

    Private Sub Tbl_cargoBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.Tbl_cargoBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Dbo_coociDataSet)

    End Sub

    Private Sub vw_cargo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_cargo' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_cargoTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_cargo)
        tccargo.SelectedIndex = 1
        tpcargo.Parent = Nothing
        Listar()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        'Try
        '    Me.Tbl_cargoTableAdapter.buscar(Me.Dbo_coociDataSet.tbl_cargo, txtbusqueda.Text)
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        ListarFiltro()
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

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub Tbl_cargoDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_cargoDataGridView.CellClick
        id = Tbl_cargoDataGridView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        tpcargo.Parent = tccargo
        tccargo.SelectedIndex = 1
        btnActualizar.Visible = True
        btnGuardar.Visible = False
        CargarDatosdelGrid()
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        CargoTextBox.Text = Nothing
        DescripcionTextBox.Text = Nothing
        tpcargo.Parent = Nothing
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub
End Class