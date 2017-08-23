Public Class vw_cliente

#Region "Atributos"
    Private control As Object
    Private idPersona As Integer
    Private idCliente As Integer
    Private _mregion As region_control
    Private _control As cliente_control
    Private validacion_General As New Validaciones_Generales_Controls
    Private validacion As New Guardar_Control
    Dim id As Integer
#End Region

#Region "Cargar Combo"

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

#End Region

#Region "Acciones Secundarias"

    Private Sub cmbregion_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles cmbregion.SelectedIndexChanged
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

    Public Sub Nuevo()
        tpdatos.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        tpClientes.Parent = Nothing
        tpdatosadicionales.Parent = Nothing
        tpdireccion.Parent = Nothing
        NombresTextBox.Text = ""
        ApellidosTextBox.Text = ""
        CedulaTextBox.Text = ""
        SexoComboBox.Text = ""
    End Sub

    Public Sub Ajustar_Columnas()
        Vw_datosMaterialDataGridView.Columns(1).Width = 200
        Vw_datosMaterialDataGridView.Columns(2).Width = 200
        Vw_datosMaterialDataGridView.Columns(3).Width = 200
        Vw_datosMaterialDataGridView.Columns(4).Width = 200
        Vw_datosMaterialDataGridView.Columns(5).Width = 500
        Vw_datosMaterialDataGridView.Columns(6).Width = 250
        Vw_datosMaterialDataGridView.Columns(7).Width = 200
        Vw_datosMaterialDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    End Sub

    Public Sub Listar()
        _control = New cliente_control
        Vw_datosMaterialDataGridView.DataSource = _control.Listar()
        Ajustar_Columnas()
    End Sub

    Private Sub vw_cliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        tpdatosadicionales.Parent = TabControl2
        TabControl2.SelectedIndex = 2
    End Sub

    Private Sub btncancelar_Click(sender As System.Object, e As System.EventArgs) Handles btncancelar.Click
        tpClientes.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        tpdatos.Parent = Nothing
        tpdatosadicionales.Parent = Nothing
        tpdireccion.Parent = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub


#End Region

#Region "Guardar"

    Private Sub GuardarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If (Not (ValidarControles())) Then
            guardar()
            Nuevo()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If (Not (ValidarControles())) Then
            guardar()
            Nuevo()
        End If
    End Sub

    Private Sub guardar()
        _control = New cliente_control
        _control.insert(NombresTextBox.Text, ApellidosTextBox.Text, CedulaTextBox.Text, cmbLocalidad.SelectedIndex, TextBox1.Text, SexoComboBox.Text, NomcompaniaTextBox.Text, CorreoTextBox.Text)

        'Dim row As DataGridViewRow
        'For i As Integer = 0 To dgvtelefono.Rows.Count - 1
        '    row = dgvtelefono.Rows(i)
        '    Dim telefono As telefono_control = New telefono_control
        '    telefono.Insert(idpersona, row.Cells(0).Value, row.Cells(1).Value)w
        'Next
        Listar()
    End Sub

#End Region


#Region "Validaciones"

#Region "Validaciones KeyPress"


    Private Sub NombresTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NombresTextBox.KeyPress
        validacion_General.letras(e)
    End Sub

    Private Sub ApellidosTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ApellidosTextBox.KeyPress
        validacion_General.letras(e)
    End Sub

    'Private Sub txttelefono_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
    '    validacion_General.numeros(e)
    'End Sub

    Private Sub CedulaTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CedulaTextBox.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

#End Region

    '#Region "Validaciones en Tiempo Real"

    '    Private Sub txtcedula_Leave(sender As System.Object, e As System.EventArgs) Handles txtcedula.Leave
    '        Dim cedula As String
    '        cedula = txtcedula.Text.Replace(" ", "")
    '        If (cedula.Length >= 3) Then
    '            lblError03.Visible = (validacion.val_Cedula(txtcedula.Text))
    '        Else
    '            lblError03.Visible = False
    '        End If
    '    End Sub

    '    Private Sub txtnombre_Leave(sender As System.Object, e As System.EventArgs) Handles txtnombre.Leave
    '        If (txtnombre.Text <> "") Then
    '            lblerror01.Visible = validacion.val_nombre(txtnombre.Text)
    '        Else
    '            lblerror01.Visible = False
    '        End If
    '    End Sub

    '    Private Sub txtapellido_Leave(sender As System.Object, e As System.EventArgs) Handles txtapellido.Leave
    '        If (txtapellido.Text <> "") Then
    '            lblerror02.Visible = validacion.val_apellido(txtapellido.Text)
    '        Else
    '            lblerror02.Visible = False
    '        End If
    '    End Sub

    '    Private Sub txtdireccion_Leave(sender As System.Object, e As System.EventArgs) Handles txtdireccion.Leave
    '        If (txtdireccion.Text <> "") Then
    '            lblError08.Visible = validacion.val_direccion(txtdireccion.Text)
    '        Else
    '            lblError08.Visible = False
    '        End If
    '    End Sub

    '    Private Sub txtcorreo_Leave(sender As System.Object, e As System.EventArgs) Handles txtcorreo.Leave
    '        If (txtcorreo.Text <> "") Then
    '            lblerror09.Visible = validacion.val_correo(txtcorreo.Text)
    '        Else
    '            lblerror09.Visible = False
    '        End If
    '    End Sub

    '#End Region

#Region "Validaciones Guardar"

    Private Function ValidarControles() As Boolean
        Dim Cadena As String = ""
        Dim band As Boolean = False


        If (validacion.val_nombre(NombresTextBox.Text)) Then
            '' lblerror01.Visible = True
            Cadena = Cadena + "1"
        Else
            '' lblerror01.Visible = False
        End If

        If (validacion.val_apellido(ApellidosTextBox.Text)) Then
            '' lblerror02.Visible = True
            Cadena = Cadena + "1"
        Else
            '' lblerror02.Visible = False
        End If

        If (validacion.val_Cedula(CedulaTextBox.Text)) Then
            '' lblError03.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblError03.Visible = False
        End If

        If (cmbregion.Text = "") Then
            ''  lblError04.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblError04.Visible = False
        End If

        If (cmbdepartamento.Text = "") Then
            '' lblError05.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblError05.Visible = False
        End If

        If (cmbmunicipio.Text = "") Then
            ''  lblError06.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblError06.Visible = False
        End If

        If (validacion.val_localidad(cmblocalidad.Text)) Then
            '' lblError07.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblError07.Visible = False
        End If

        If (validacion.val_direccion(TextBox1.Text)) Then
            ''  lblError08.Visible = True
            Cadena = Cadena + "1"
        Else
            '' lblError08.Visible = False
        End If


        If (validacion.val_correo(CorreoTextBox.Text)) Then
            ''  lblerror09.Visible = True
            Cadena = Cadena + "1"
        Else
            ''  lblerror09.Visible = False
        End If

        'If (dgvtelefono.Rows.Count = 0) Then
        '   '' lblerror11.Visible = True
        '    Cadena = Cadena + "1"
        'Else
        '    lblerror11.Visible = False
        'End If


        If (Cadena.Contains("1")) Then
            band = True
        End If

        Return band
    End Function

    'Function Telefono_Grid() As Boolean

    '    Dim Cadena As String = ""
    '    Dim band As Boolean = False

    '    If (validacion.val_operadora(cmboperadora.Text)) Then
    '        lblerror10.Visible = True
    '        Cadena = Cadena + "1"
    '    Else
    '        lblerror10.Visible = False
    '    End If

    '    If (validacion.val_telefono(txttelefono.Text)) Then
    '        Label1.Visible = True
    '        Cadena = Cadena + "1"
    '    Else
    '        Label1.Visible = False
    '    End If

    '    If (Cadena.Contains("1")) Then
    '        band = True
    '    End If

    '    Return band
    'End Function

#End Region

#End Region



    Private Sub btntelefono_Click(sender As System.Object, e As System.EventArgs) Handles btntelefono.Click
        vws_telefono.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        tpdatospersonales.Parent = TabControl2
        TabControl2.SelectedIndex = 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        tpdireccion.Parent = TabControl2
        TabControl2.SelectedIndex = 0
    End Sub
End Class