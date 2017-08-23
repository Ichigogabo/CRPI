Public Class vw_proyecto
#Region "Atributos"
    Private bandmaxpnl As Boolean
    Private bandmaxfse As Boolean
    Private bandmaxact As Boolean
    Private idProyecto As Integer
    Private idFase As Integer
    Private idActividad As Integer
    Private control As proyecto_control
#End Region
#Region "Metodos y Funciones"

    Private Sub openpanel(ByVal panel As Panel, ByRef panelsaves As Panel, ByRef bandera As Boolean)
        If bandera = False Then
            bandera = True
            panel.Size = New Size(729, 270)
            panelsaves.Visible = True
            Panel2.Size = New Size(729, Panel2.Height + 233)
        Else
            panel.Size = New Size(729, 35)
            bandera = False
            panelsaves.Visible = False
            Panel2.Size = New Size(729, Panel2.Height - 233)
        End If
    End Sub

    Private Sub CargarProyectos()
        control = New proyecto_control
        cmbproyecto.DataSource = control.CARGAR_PROYECTOS()
        cmbproyecto.DisplayMember = "Proyecto"
        cmbproyecto.ValueMember = "idProyecto"
    End Sub

    Public Sub Listar_Proyectos()
        control = New proyecto_control()
        dgvProyectos.DataSource = control.CARGAR_PROYECTOS()
        'dgvProyectos.Columns(0).Visible = False
        dgvProyectos.Columns(5).Visible = False
    End Sub

    Public Sub Listar_Fases()
        control = New proyecto_control
        Dim dt As DataTable = control.CARGAR_FASES(dgvProyectos.CurrentCell.Value)
        dgvfases.DataSource = dt
        'dgvfases.Columns(0).Visible = False
        dgvfases.Columns(5).Visible = False
    End Sub

    Public Sub TreeViewGenerator()
        'Cargamos al padre
        Dim nodopadre As TreeNode
        Dim nodohijo As TreeNode
        Dim nodonieto As TreeNode
        control = New proyecto_control
        Dim dtP As DataTable = control.CARGAR_PROYECTOS()
        For i = 0 To dgvProyectos.RowCount - 1
            nodopadre = New TreeNode(dtP.Rows(i).Item(1))
            tvproyecto.Nodes.Add(nodopadre)
            control = New proyecto_control
            Dim dt As DataTable = control.CARGAR_FASES(dtP.Rows(i).Item(0))
            For j = 0 To dt.Rows.Count - 1
                nodohijo = New TreeNode(dt.Rows(j).Item(1))
                nodopadre.Nodes.Add(nodohijo)
                control = New proyecto_control
                Dim dt2 As DataTable = control.CARGAR_ACTIVIDADES(dt.Rows(j).Item(0))
                For k = 0 To dt2.Rows.Count - 1
                    nodonieto = New TreeNode(dt2.Rows(k).Item(1))
                    nodohijo.Nodes.Add(nodonieto)
                Next
            Next

        Next

        control = New proyecto_control()
        dgvProyectos.DataSource = control.CARGAR_PROYECTOS()
    End Sub

    Private Sub CargarFases(ByVal id As Integer)
        control = New proyecto_control
        cmbfases.DataSource = control.CARGAR_FASES(id)
        cmbfases.DisplayMember = "Fase"
        cmbfases.ValueMember = "IdFase"
    End Sub

    Private Sub CargarActividades(ByVal id As Integer)
        control = New proyecto_control
        cmbactividades.DataSource = control.CARGAR_ACTIVIDADES(id)
        cmbactividades.DisplayMember = "Actividad"
        cmbactividades.ValueMember = "IdActividad"
    End Sub

    Private Sub DatosProyectos()
        Try
            openpanel(pnlproyecto, pnlcontrolpro, False)
            control = New proyecto_control
            control.DATOSPROYECTO(idProyecto)
            txtproyecto.Text = control.MODEL.NOMBRE
            txtdescripcionproyecto.Text = control.MODEL.DESCRIPCION
            dtpinicioproyecto.Value = control.MODEL.INICIO.ToString()
            CostoTextBox.Text = control.MODEL.COSTO
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DatosFase()
        Try
            openpanel(pnlfase, pnlcontrolfase, False)
            control = New proyecto_control
            control.DATOSFASE(idFase)
            txtfase.Text = control.MODEL.NOMBRE
            txtdescripcionfase.Text = control.MODEL.DESCRIPCION
            dtpiniciofaase.Value = control.MODEL.INICIO.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DatosActividad()
        Try
            openpanel(pnlActividad, pnlcontrolact, False)
            control = New proyecto_control
            control.DATOSACTIVIDAD(idActividad)
            txtactividades.Text = control.MODEL.NOMBRE
            txtdescripcionact.Text = control.MODEL.DESCRIPCION
            dptiniciaactividad.Value = control.MODEL.INICIO.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Nuevo()
        TabPage2.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        txtproyecto.Text = ""
        txtdescripcionproyecto.Text = ""
        dtpinicioproyecto.Enabled = True
        dtpterminaproyecto.Enabled = True
        txtproyecto.Enabled = True
        txtdescripcionproyecto.Enabled = True
        txtproyecto.Focus()
        openpanel(pnlproyecto, pnlcontrolpro, False)
        btnguardarproy.Visible = True
        btnmodificarproy.Visible = False
        btnaddfase.Visible = False
    End Sub

    Private Sub Guardar()
        control = New proyecto_control
        control.MODEL.NOMBRE = txtproyecto.Text
        control.MODEL.DESCRIPCION = txtdescripcionproyecto.Text
        control.MODEL.INICIO = dtpinicioproyecto.Value
        control.MODEL.FINALIZA = dtpterminaproyecto.Value
        'control.INSERTAR_PROYECTO()
        'btnaddfase.Visible = True
        'btnaddfase.Focus()
        'CargarProyectos()
        'Listar_Proyectos()
        'cmbproyecto.SelectedIndex =cmbproyecto.se|

    End Sub

#End Region
    Private Sub vw_proyecto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_Proyectos' Puede moverla o quitarla según sea necesario.
        'Me.Tbl_ProyectosTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_Proyectos)
        bandmaxpnl = False
        CargarProyectos()
        TabPage2.Parent = Nothing
        Listar_Proyectos()
        TreeViewGenerator()
    End Sub

    Private Sub btnmaxpro_Click(sender As System.Object, e As System.EventArgs) Handles btnmaxpro.Click
        openpanel(pnlproyecto, pnlcontrolpro, bandmaxpnl)
    End Sub

    Private Sub btnmaxfase_Click(sender As System.Object, e As System.EventArgs) Handles btnmaxfase.Click
        openpanel(pnlfase, pnlcontrolfase, bandmaxfse)
    End Sub

    Private Sub btnmaxact_Click(sender As System.Object, e As System.EventArgs) Handles btnmaxact.Click
        openpanel(pnlActividad, pnlcontrolact, bandmaxact)
    End Sub

    Private Sub cmbproyecto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbproyecto.SelectedIndexChanged
        Try
            idProyecto = cmbproyecto.SelectedValue
            CargarFases(cmbproyecto.SelectedValue)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbfases_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbfases.SelectedIndexChanged
        Try
            idFase = cmbfases.SelectedValue
            CargarActividades(cmbfases.SelectedValue)
        Catch ex As Exception

        End Try
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DatosProyectos()
        btneditarpro.Enabled = True
    End Sub

    Private Sub btneditarpro_Click(sender As System.Object, e As System.EventArgs) Handles btneditarpro.Click
        txtproyecto.Enabled = True
        txtdescripcionproyecto.Enabled = True
        CostoTextBox.Enabled = True
        dtpinicioproyecto.Enabled = True
        dtpterminaproyecto.Enabled = True
        dtpiniciofaase.MinDate = dtpinicioproyecto.Value
        dtpiniciofaase.MaxDate = dtpterminaactividad.Value
        dtpterminafase.MaxDate = dtpterminaproyecto.Value
        btneditarfase.Enabled = True
        dtpiniciofaase.Enabled = True
    End Sub

    Private Sub btnselectfase_Click(sender As System.Object, e As System.EventArgs) Handles btnselectfase.Click
        DatosFase()
        btneditarfase.Enabled = True
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        DatosActividad()
        btneditaractividad.Enabled = True
    End Sub

    Private Sub cmbactividades_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbactividades.SelectedIndexChanged
        Try
            idActividad = cmbactividades.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaddfase_Click(sender As System.Object, e As System.EventArgs) Handles btnaddfase.Click
        txtfase.Text = ""
        txtdescripcionfase.Text = ""
        dtpiniciofaase.MinDate = dtpinicioproyecto.Value
        dtpiniciofaase.MaxDate = dtpterminaproyecto.Value
        dtpterminafase.MinDate = dtpiniciofaase.Value
        dtpterminafase.MaxDate = dtpterminaproyecto.Value
        openpanel(pnlfase, pnlcontrolfase, False)
        txtfase.Enabled = True
        txtdescripcionfase.Enabled = True
        dtpiniciofaase.Enabled = True
        dtpterminafase.Enabled = True
        ProyectoAsignadoTextBox.Text = cmbproyecto.Text
        btnupdatefase.Visible = False
        btnsavefase.Visible = True
    End Sub

    Private Sub dtpiniciofaase_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpiniciofaase.ValueChanged
        dtpterminafase.MaxDate = dtpterminaproyecto.Value
        dtpterminafase.MinDate = dtpiniciofaase.Value
    End Sub

    Private Sub dgvProyectos_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProyectos.CellClick
        Try
            Listar_Fases()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub dgvfases_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvfases.CellClick
        Try
            control = New proyecto_control
            Dim dt As DataTable = control.CARGAR_ACTIVIDADES(dgvfases.CurrentCell.Value)
            dgvactividad.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnguardarproy_Click(sender As System.Object, e As System.EventArgs) Handles btnguardarproy.Click
        Guardar()
    End Sub

    Private Sub dtpinicioproyecto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpinicioproyecto.ValueChanged
        dtpterminaproyecto.MinDate = dtpinicioproyecto.Value
    End Sub
End Class