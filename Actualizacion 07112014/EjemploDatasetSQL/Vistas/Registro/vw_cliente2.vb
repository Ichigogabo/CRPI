Public Class vw_cliente2
#Region "Atributos"
    Private control As Object
    Private idPersona As Integer
    Private idCliente As Integer
    Private _mregion As region_control
    Private _control As cliente_control
    Dim id As Integer
#End Region

#Region "Metodos y Funciones"
    Public Sub Nuevo()
        tpdatos.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        tpdatosadicionales.Parent = Nothing
        tpdireccion.Parent = Nothing
        NombresTextBox.Text = ""
        ApellidosTextBox.Text = ""
        CedulaTextBox.Text = ""
        SexoComboBox.Text = ""
    End Sub

    Public Sub Cargar_Regiones()
        _mregion = New region_control
        cmbregion.DataSource = _mregion.REGIONES
        cmbregion.DisplayMember = "REGION"
        cmbregion.ValueMember = "ID"
    End Sub

    Public Sub Cargar_Departamento(ByVal i As Integer)
        _mregion = New region_control
        cmbdepartamento.DataSource = _mregion.DEPARTAMENTOS(i)
        cmbdepartamento.DisplayMember = "Departamento"
        cmbdepartamento.ValueMember = "ID"
    End Sub

    Public Sub Cargar_Municipio(ByVal i As Integer)
        _mregion = New region_control
        cmbMunicipio.DataSource = _mregion.MUNICIPIOS(i)
        cmbMunicipio.DisplayMember = "Municipio"
        cmbMunicipio.ValueMember = "ID"
    End Sub

    Public Sub Cargar_Localidad(ByVal i As Integer)
        _mregion = New region_control
        cmbLocalidad.DataSource = _mregion.LOCALIDADES(i)
        cmbLocalidad.DisplayMember = "Localidad"
        cmbLocalidad.ValueMember = "ID"
    End Sub

    Public Sub Ajustar_Columnas()
        Vw_datosMaterialDataGridView.Columns(1).Width = 200
        Vw_datosMaterialDataGridView.Columns(2).Width = 200
        Vw_datosMaterialDataGridView.Columns(3).Width = 200
        Vw_datosMaterialDataGridView.Columns(4).Width = 500
        Vw_datosMaterialDataGridView.Columns(5).Width = 250
        Vw_datosMaterialDataGridView.Columns(6).Width = 200
        Vw_datosMaterialDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub Listar()
        _control = New cliente_control
        Vw_datosMaterialDataGridView.DataSource = _control.Listar()
        'Vw_datosMaterialDataGridView.Columns(0).Visible = False
        'Vw_datosMaterialDataGridView.Columns(1).HeaderText = "Nombre"
        'Vw_datosMaterialDataGridView.Columns(2).HeaderText = "Apellido"
        'Vw_datosMaterialDataGridView.Columns(3).HeaderText = "Cedula"
        'Vw_datosMaterialDataGridView.Columns(4).HeaderText = "Sexo"
        'Vw_datosMaterialDataGridView.Columns(5).HeaderText = ""
        'Vw_datosMaterialDataGridView.Columns(6).HeaderText = "Direcciòn"
        'Vw_datosMaterialDataGridView.Columns(9).Visible = False
        Ajustar_Columnas()
    End Sub
#End Region
    Private Sub vw_cliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_cliente' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_clienteTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_cliente)
        ''TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_persona' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_personaTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_persona)
        TabControl2.Alignment = TabAlignment.Bottom
        tpdatos.Parent = Nothing
        tpdatosadicionales.Parent = Nothing
        tpdireccion.Parent = Nothing
        Cargar_Regiones()
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

    Private Sub btnsig01_Click(sender As System.Object, e As System.EventArgs) Handles btnsig01.Click
        tpdireccion.Parent = TabControl2
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub cmbregion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbregion.SelectedIndexChanged
        Try
            id = cmbregion.SelectedValue
            Cargar_Departamento(id)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbdepartamento_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbdepartamento.SelectedIndexChanged
        Try
            id = cmbdepartamento.SelectedValue
            Cargar_Municipio(id)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cmbMunicipio_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMunicipio.SelectedIndexChanged
        Try
            id = cmbMunicipio.SelectedValue
            Cargar_Localidad(id)
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub
End Class