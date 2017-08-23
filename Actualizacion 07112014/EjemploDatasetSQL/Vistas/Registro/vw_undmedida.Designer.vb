<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vw_undmedida
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
        Dim Label2 As System.Windows.Forms.Label
        Dim IdUnidMedLabel As System.Windows.Forms.Label
        Dim UnidMedidaLabel As System.Windows.Forms.Label
        Dim AbreviaturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vw_undmedida))
        Me.Dbo_coociDataSet = New EjemploDatasetSQL.dbo_coociDataSet()
        Me.Tbl_unidMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_unidMedidaTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_unidMedidaTableAdapter()
        Me.TableAdapterManager = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.IdUnidMedTextBox = New System.Windows.Forms.TextBox()
        Me.UnidMedidaTextBox = New System.Windows.Forms.TextBox()
        Me.AbreviaturaTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tbl_unidMedidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.pnlbusqueda = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_unidMedidaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Label2 = New System.Windows.Forms.Label()
        IdUnidMedLabel = New System.Windows.Forms.Label()
        UnidMedidaLabel = New System.Windows.Forms.Label()
        AbreviaturaLabel = New System.Windows.Forms.Label()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_unidMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Tbl_unidMedidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbusqueda.SuspendLayout()
        CType(Me.Tbl_unidMedidaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_unidMedidaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(79, 12)
        Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(260, 20)
        Label2.TabIndex = 3
        Label2.Text = "REGISTRO DE UNIDADES DE MEDIDA"
        '
        'IdUnidMedLabel
        '
        IdUnidMedLabel.AutoSize = True
        IdUnidMedLabel.Location = New System.Drawing.Point(479, 26)
        IdUnidMedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdUnidMedLabel.Name = "IdUnidMedLabel"
        IdUnidMedLabel.Size = New System.Drawing.Size(94, 20)
        IdUnidMedLabel.TabIndex = 8
        IdUnidMedLabel.Text = "id Unid Med:"
        IdUnidMedLabel.Visible = False
        '
        'UnidMedidaLabel
        '
        UnidMedidaLabel.AutoSize = True
        UnidMedidaLabel.Location = New System.Drawing.Point(57, 77)
        UnidMedidaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UnidMedidaLabel.Name = "UnidMedidaLabel"
        UnidMedidaLabel.Size = New System.Drawing.Size(127, 20)
        UnidMedidaLabel.TabIndex = 10
        UnidMedidaLabel.Text = "Unida de Medida:"
        '
        'AbreviaturaLabel
        '
        AbreviaturaLabel.AutoSize = True
        AbreviaturaLabel.Location = New System.Drawing.Point(57, 139)
        AbreviaturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AbreviaturaLabel.Name = "AbreviaturaLabel"
        AbreviaturaLabel.Size = New System.Drawing.Size(89, 20)
        AbreviaturaLabel.TabIndex = 12
        AbreviaturaLabel.Text = "Abreviatura:"
        '
        'Dbo_coociDataSet
        '
        Me.Dbo_coociDataSet.DataSetName = "dbo_coociDataSet"
        Me.Dbo_coociDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_unidMedidaBindingSource
        '
        Me.Tbl_unidMedidaBindingSource.DataMember = "tbl_unidMedida"
        Me.Tbl_unidMedidaBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'Tbl_unidMedidaTableAdapter
        '
        Me.Tbl_unidMedidaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_cargoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_clienteTableAdapter = Nothing
        Me.TableAdapterManager.tbl_companiaTelefonicaTableAdapter = Nothing
        Me.TableAdapterManager.tbl_detalleClienteTableAdapter = Nothing
        Me.TableAdapterManager.tbl_detalleEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_detalleEntradaTableAdapter = Nothing
        Me.TableAdapterManager.tbl_detalleSalidaTableAdapter = Nothing
        Me.TableAdapterManager.tbl_empleadoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EntradaMaterialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_materialesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_montoComplementoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_personaTableAdapter = Nothing
        Me.TableAdapterManager.tbl_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.tbl_ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.tbl_regionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_retrasoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_SalidaMaterialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_seguimientoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_telefonoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_unidMedidaTableAdapter = Me.Tbl_unidMedidaTableAdapter
        Me.TableAdapterManager.UpdateOrder = EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlheader.Controls.Add(Me.PictureBox1)
        Me.pnlheader.Controls.Add(Label2)
        Me.pnlheader.Controls.Add(Me.Panel1)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(730, 44)
        Me.pnlheader.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(17, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 36)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnmin)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(596, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnmin
        '
        Me.btnmin.BackColor = System.Drawing.Color.Transparent
        Me.btnmin.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnmin.FlatAppearance.BorderSize = 0
        Me.btnmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmin.Image = CType(resources.GetObject("btnmin.Image"), System.Drawing.Image)
        Me.btnmin.Location = New System.Drawing.Point(28, 0)
        Me.btnmin.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(55, 44)
        Me.btnmin.TabIndex = 1
        Me.btnmin.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.Location = New System.Drawing.Point(83, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(51, 44)
        Me.btnclose.TabIndex = 0
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 94)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(730, 523)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.Controls.Add(Me.btncancelar)
        Me.TabPage1.Controls.Add(Me.btnActualizar)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(IdUnidMedLabel)
        Me.TabPage1.Controls.Add(Me.IdUnidMedTextBox)
        Me.TabPage1.Controls.Add(UnidMedidaLabel)
        Me.TabPage1.Controls.Add(Me.UnidMedidaTextBox)
        Me.TabPage1.Controls.Add(AbreviaturaLabel)
        Me.TabPage1.Controls.Add(Me.AbreviaturaTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(722, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos de la Unidad de Medida"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(61, 226)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(131, 38)
        Me.btncancelar.TabIndex = 16
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(198, 226)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(122, 38)
        Me.btnActualizar.TabIndex = 15
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = False
        Me.btnActualizar.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(198, 226)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 38)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        Me.btnGuardar.Visible = False
        '
        'IdUnidMedTextBox
        '
        Me.IdUnidMedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_unidMedidaBindingSource, "idUnidMed", True))
        Me.IdUnidMedTextBox.Location = New System.Drawing.Point(581, 21)
        Me.IdUnidMedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdUnidMedTextBox.Name = "IdUnidMedTextBox"
        Me.IdUnidMedTextBox.Size = New System.Drawing.Size(132, 27)
        Me.IdUnidMedTextBox.TabIndex = 9
        Me.IdUnidMedTextBox.Visible = False
        '
        'UnidMedidaTextBox
        '
        Me.UnidMedidaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_unidMedidaBindingSource, "UnidMedida", True))
        Me.UnidMedidaTextBox.Location = New System.Drawing.Point(61, 107)
        Me.UnidMedidaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UnidMedidaTextBox.Name = "UnidMedidaTextBox"
        Me.UnidMedidaTextBox.Size = New System.Drawing.Size(259, 27)
        Me.UnidMedidaTextBox.TabIndex = 11
        '
        'AbreviaturaTextBox
        '
        Me.AbreviaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_unidMedidaBindingSource, "Abreviatura", True))
        Me.AbreviaturaTextBox.Location = New System.Drawing.Point(61, 169)
        Me.AbreviaturaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AbreviaturaTextBox.Name = "AbreviaturaTextBox"
        Me.AbreviaturaTextBox.Size = New System.Drawing.Size(259, 27)
        Me.AbreviaturaTextBox.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Tbl_unidMedidaDataGridView)
        Me.TabPage2.Controls.Add(Me.pnlbusqueda)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(722, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unidades de Medidas Existentes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Tbl_unidMedidaDataGridView
        '
        Me.Tbl_unidMedidaDataGridView.AllowUserToAddRows = False
        Me.Tbl_unidMedidaDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_unidMedidaDataGridView.AllowUserToOrderColumns = True
        Me.Tbl_unidMedidaDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Tbl_unidMedidaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_unidMedidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_unidMedidaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_unidMedidaDataGridView.Location = New System.Drawing.Point(4, 46)
        Me.Tbl_unidMedidaDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tbl_unidMedidaDataGridView.Name = "Tbl_unidMedidaDataGridView"
        Me.Tbl_unidMedidaDataGridView.ReadOnly = True
        Me.Tbl_unidMedidaDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Tbl_unidMedidaDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbl_unidMedidaDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tbl_unidMedidaDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.Tbl_unidMedidaDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow
        Me.Tbl_unidMedidaDataGridView.RowTemplate.Height = 44
        Me.Tbl_unidMedidaDataGridView.Size = New System.Drawing.Size(714, 439)
        Me.Tbl_unidMedidaDataGridView.TabIndex = 16
        '
        'pnlbusqueda
        '
        Me.pnlbusqueda.Controls.Add(Me.txtbusqueda)
        Me.pnlbusqueda.Controls.Add(Me.Label1)
        Me.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlbusqueda.Location = New System.Drawing.Point(4, 5)
        Me.pnlbusqueda.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.pnlbusqueda.Name = "pnlbusqueda"
        Me.pnlbusqueda.Size = New System.Drawing.Size(714, 41)
        Me.pnlbusqueda.TabIndex = 17
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(109, 7)
        Me.txtbusqueda.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(562, 27)
        Me.txtbusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 47)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'Tbl_unidMedidaBindingNavigator
        '
        Me.Tbl_unidMedidaBindingNavigator.AddNewItem = Nothing
        Me.Tbl_unidMedidaBindingNavigator.BackColor = System.Drawing.Color.Black
        Me.Tbl_unidMedidaBindingNavigator.BindingSource = Me.Tbl_unidMedidaBindingSource
        Me.Tbl_unidMedidaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_unidMedidaBindingNavigator.DeleteItem = Nothing
        Me.Tbl_unidMedidaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Tbl_unidMedidaBindingNavigator.Location = New System.Drawing.Point(0, 44)
        Me.Tbl_unidMedidaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_unidMedidaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_unidMedidaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_unidMedidaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_unidMedidaBindingNavigator.Name = "Tbl_unidMedidaBindingNavigator"
        Me.Tbl_unidMedidaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_unidMedidaBindingNavigator.Size = New System.Drawing.Size(730, 50)
        Me.Tbl_unidMedidaBindingNavigator.TabIndex = 0
        Me.Tbl_unidMedidaBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(74, 47)
        Me.ToolStripDropDownButton1.Text = "Archivos"
        Me.ToolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.NuevoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(135, 32)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(135, 32)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 32)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 47)
        Me.ToolStripButton1.Text = "Editar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(52, 47)
        Me.ToolStripButton2.Text = "Buscar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'vw_undmedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 617)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Tbl_unidMedidaBindingNavigator)
        Me.Controls.Add(Me.pnlheader)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "vw_undmedida"
        Me.Text = "vw_undmedida"
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_unidMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Tbl_unidMedidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbusqueda.ResumeLayout(False)
        Me.pnlbusqueda.PerformLayout()
        CType(Me.Tbl_unidMedidaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_unidMedidaBindingNavigator.ResumeLayout(False)
        Me.Tbl_unidMedidaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dbo_coociDataSet As EjemploDatasetSQL.dbo_coociDataSet
    Friend WithEvents Tbl_unidMedidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_unidMedidaTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_unidMedidaTableAdapter
    Friend WithEvents TableAdapterManager As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents IdUnidMedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnidMedidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AbreviaturaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Tbl_unidMedidaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pnlbusqueda As System.Windows.Forms.Panel
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_unidMedidaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
End Class
