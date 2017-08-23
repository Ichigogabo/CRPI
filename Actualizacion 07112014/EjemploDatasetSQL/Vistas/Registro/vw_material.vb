Public Class vw_material
    Private control As material_control
    Private id As Integer
    Private idundmed As Integer
    Private Sub Nuevo()
        tpdatos.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        MaterialTextBox.Text = ""
        MaterialTextBox.Focus()
        CantidadTextBox.Text = ""
        cmbUnidMedida.SelectedValue = 1
        btnActualizar.Visible = False
        btnGuardar.Visible = True
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorCountItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
    End Sub
    Private Sub cargar_combobox()
        Dim unidadMedida = New unidadMedida_control
        cmbUnidMedida.DataSource = unidadMedida.LISTAR
        cmbUnidMedida.DisplayMember = "UnidMedida"
        cmbUnidMedida.ValueMember = "idUnidMed"
    End Sub
    Public Sub Actualizar()
        control = New material_control
        tpdatos.Parent = Nothing
        control.MODEL.ID = id
        control.MODEL.Material = MaterialTextBox.Text
        control.MODEL.Cantidad = CantidadTextBox.Text
        control.MODEL.UNIDAD_MEDIDA = idundmed
        control.ACTUALIZAR()
        Listar()
        MsgBox("Se actualizo correctamente los datos del Material " & MaterialTextBox.Text, MsgBoxStyle.Information)
    End Sub
    Public Sub Guardar()
        control = New material_control
        If control.EXISTE(MaterialTextBox.Text) Then
            MsgBox("Este Cargo ya Existe", MsgBoxStyle.Critical)
        Else
            control.MODEL.Material = MaterialTextBox.Text
            control.MODEL.Cantidad = Convert.ToInt32(CantidadTextBox.Text)
            control.MODEL.UNIDAD_MEDIDA = idundmed
            control.INSERTAR()
            tpdatos.Parent = Nothing
            MsgBox("Se almaceno correcatamente este cargo")
            Listar()
        End If
    End Sub
    Public Sub Listar()
        control = New material_control
        Vw_datosMaterialDataGridView.DataSource = control.LISTAR
        Vw_datosMaterialDataGridView.Columns(0).Visible = False
        Vw_datosMaterialDataGridView.Columns(1).HeaderText = "Material"
        Vw_datosMaterialDataGridView.Columns(2).HeaderText = "Cantidad"
        Vw_datosMaterialDataGridView.Columns(3).HeaderText = "Unidad de Medida"
        Vw_datosMaterialDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        Vw_datosMaterialDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Public Sub CargarDatosdelGrid()
        control = New material_control
        control.BUSCARPORID(id)
        MaterialTextBox.Text = control.MODEL.Material
        MaterialTextBox.Enabled = False
        CantidadTextBox.Text = control.MODEL.Cantidad
        cmbUnidMedida.Text = control.MODEL.NOMBRE_UNIDAD_MEDIDA
        btnGuardar.Visible = False
    End Sub
    Private Sub ListarFiltro()
        control = New material_control
        Vw_datosMaterialDataGridView.DataSource = (control.FILTRO(txtbusqueda.Text))
        Vw_datosMaterialDataGridView.Columns(0).Visible = False
        Vw_datosMaterialDataGridView.Columns(1).HeaderText = "Material"
        Vw_datosMaterialDataGridView.Columns(2).HeaderText = "Cantidad"
        Vw_datosMaterialDataGridView.Columns(3).HeaderText = "Unidad de Medida"
        Vw_datosMaterialDataGridView.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        Vw_datosMaterialDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub Tbl_materialesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        'Me.Validate()
        'Me.Tbl_materialesBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.Dbo_coociDataSet)
    End Sub

    Private Sub vw_material_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.vw_datosMaterial' Puede moverla o quitarla según sea necesario.
        'Me.Vw_datosMaterialTableAdapter.Fill(Me.Dbo_coociDataSet.vw_datosMaterial)
        ''TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_unidMedida' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_unidMedidaTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_unidMedida)
        ''TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_materiales' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_materialesTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_materiales)
        tpdatos.Parent = Nothing
        Listar()
        cargar_combobox()
    End Sub

    Private Sub Tbl_materialesBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs) Handles Tbl_materialesBindingNavigator.RefreshItems

    End Sub

    Private Sub btnclose_Click(sender As System.Object, e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnmin_Click(sender As System.Object, e As System.EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Vw_datosMaterialDataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Vw_datosMaterialDataGridView.CellClick
        id = Vw_datosMaterialDataGridView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        tpdatos.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        btnActualizar.Visible = True
        btnGuardar.Visible = False
        cargar_combobox()
        CargarDatosdelGrid()
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        MaterialTextBox.Text = ""
        CantidadTextBox.Text = ""
        cmbUnidMedida.Text = ""
        tpdatos.Parent = Nothing
    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub cmbUnidMedida_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbUnidMedida.SelectedIndexChanged
        Try
            idundmed = cmbUnidMedida.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Guardar()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        txtbusqueda.Text = ""
        txtbusqueda.Focus()
    End Sub

    Private Sub txtbusqueda_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbusqueda.TextChanged
        ListarFiltro()
    End Sub
End Class