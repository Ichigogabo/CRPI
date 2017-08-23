<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vw_cargo
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
        Dim IdCargoLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vw_cargo))
        Me.tccargo = New System.Windows.Forms.TabControl()
        Me.tpcargo = New System.Windows.Forms.TabPage()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.IdCargoTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_cargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dbo_coociDataSet = New EjemploDatasetSQL.dbo_coociDataSet()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.tpdatos = New System.Windows.Forms.TabPage()
        Me.Tbl_cargoDataGridView = New System.Windows.Forms.DataGridView()
        Me.pnlbusqueda = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_cargoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.pnlheader = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnmin = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Tbl_cargoTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_cargoTableAdapter()
        Me.TableAdapterManager = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager()
        IdCargoLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.tccargo.SuspendLayout()
        Me.tpcargo.SuspendLayout()
        CType(Me.Tbl_cargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpdatos.SuspendLayout()
        CType(Me.Tbl_cargoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbusqueda.SuspendLayout()
        CType(Me.Tbl_cargoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_cargoBindingNavigator.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdCargoLabel
        '
        IdCargoLabel.AutoSize = True
        IdCargoLabel.Location = New System.Drawing.Point(482, 20)
        IdCargoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdCargoLabel.Name = "IdCargoLabel"
        IdCargoLabel.Size = New System.Drawing.Size(69, 20)
        IdCargoLabel.TabIndex = 0
        IdCargoLabel.Text = "id Cargo:"
        IdCargoLabel.Visible = False
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CargoLabel.ForeColor = System.Drawing.SystemColors.Control
        CargoLabel.Location = New System.Drawing.Point(39, 66)
        CargoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(55, 21)
        CargoLabel.TabIndex = 2
        CargoLabel.Text = "Cargo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.SystemColors.Control
        DescripcionLabel.Location = New System.Drawing.Point(39, 138)
        DescripcionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(94, 21)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "Descripcion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(62, 13)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(160, 20)
        Label2.TabIndex = 3
        Label2.Text = "REGISTRO DE CARGOS"
        '
        'tccargo
        '
        Me.tccargo.Controls.Add(Me.tpcargo)
        Me.tccargo.Controls.Add(Me.tpdatos)
        Me.tccargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tccargo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tccargo.Location = New System.Drawing.Point(0, 94)
        Me.tccargo.Margin = New System.Windows.Forms.Padding(4)
        Me.tccargo.Name = "tccargo"
        Me.tccargo.SelectedIndex = 0
        Me.tccargo.Size = New System.Drawing.Size(753, 357)
        Me.tccargo.TabIndex = 0
        '
        'tpcargo
        '
        Me.tpcargo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.tpcargo.Controls.Add(Me.btncancelar)
        Me.tpcargo.Controls.Add(Me.btnActualizar)
        Me.tpcargo.Controls.Add(Me.Button1)
        Me.tpcargo.Controls.Add(Me.btnGuardar)
        Me.tpcargo.Controls.Add(IdCargoLabel)
        Me.tpcargo.Controls.Add(Me.IdCargoTextBox)
        Me.tpcargo.Controls.Add(CargoLabel)
        Me.tpcargo.Controls.Add(Me.CargoTextBox)
        Me.tpcargo.Controls.Add(DescripcionLabel)
        Me.tpcargo.Controls.Add(Me.DescripcionTextBox)
        Me.tpcargo.Location = New System.Drawing.Point(4, 29)
        Me.tpcargo.Margin = New System.Windows.Forms.Padding(4)
        Me.tpcargo.Name = "tpcargo"
        Me.tpcargo.Padding = New System.Windows.Forms.Padding(4)
        Me.tpcargo.Size = New System.Drawing.Size(745, 324)
        Me.tpcargo.TabIndex = 0
        Me.tpcargo.Text = "Datos del Cargo"
        Me.tpcargo.ToolTipText = "Datos del Cargo"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(43, 281)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(131, 38)
        Me.btncancelar.TabIndex = 9
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
        Me.btnActualizar.Location = New System.Drawing.Point(180, 281)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(121, 38)
        Me.btnActualizar.TabIndex = 8
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(38, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 46)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Regresar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(180, 281)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 38)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'IdCargoTextBox
        '
        Me.IdCargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_cargoBindingSource, "idCargo", True))
        Me.IdCargoTextBox.Location = New System.Drawing.Point(578, 17)
        Me.IdCargoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdCargoTextBox.Name = "IdCargoTextBox"
        Me.IdCargoTextBox.Size = New System.Drawing.Size(158, 27)
        Me.IdCargoTextBox.TabIndex = 1
        Me.IdCargoTextBox.Visible = False
        '
        'Tbl_cargoBindingSource
        '
        Me.Tbl_cargoBindingSource.DataMember = "tbl_cargo"
        Me.Tbl_cargoBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'Dbo_coociDataSet
        '
        Me.Dbo_coociDataSet.DataSetName = "dbo_coociDataSet"
        Me.Dbo_coociDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargoTextBox
        '
        Me.CargoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_cargoBindingSource, "cargo", True))
        Me.CargoTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CargoTextBox.Location = New System.Drawing.Point(42, 101)
        Me.CargoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(260, 27)
        Me.CargoTextBox.TabIndex = 3
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_cargoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DescripcionTextBox.Location = New System.Drawing.Point(42, 168)
        Me.DescripcionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(260, 95)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'tpdatos
        '
        Me.tpdatos.AutoScroll = True
        Me.tpdatos.Controls.Add(Me.Tbl_cargoDataGridView)
        Me.tpdatos.Controls.Add(Me.pnlbusqueda)
        Me.tpdatos.Location = New System.Drawing.Point(4, 29)
        Me.tpdatos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpdatos.Name = "tpdatos"
        Me.tpdatos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpdatos.Size = New System.Drawing.Size(745, 324)
        Me.tpdatos.TabIndex = 1
        Me.tpdatos.Text = "Cargos existentes"
        Me.tpdatos.UseVisualStyleBackColor = True
        '
        'Tbl_cargoDataGridView
        '
        Me.Tbl_cargoDataGridView.AllowUserToAddRows = False
        Me.Tbl_cargoDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_cargoDataGridView.AllowUserToOrderColumns = True
        Me.Tbl_cargoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Tbl_cargoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Tbl_cargoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_cargoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tbl_cargoDataGridView.Location = New System.Drawing.Point(4, 45)
        Me.Tbl_cargoDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Tbl_cargoDataGridView.Name = "Tbl_cargoDataGridView"
        Me.Tbl_cargoDataGridView.ReadOnly = True
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(4)
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.Tbl_cargoDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow
        Me.Tbl_cargoDataGridView.RowTemplate.Height = 44
        Me.Tbl_cargoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_cargoDataGridView.Size = New System.Drawing.Size(737, 275)
        Me.Tbl_cargoDataGridView.TabIndex = 1
        '
        'pnlbusqueda
        '
        Me.pnlbusqueda.Controls.Add(Me.txtbusqueda)
        Me.pnlbusqueda.Controls.Add(Me.Label1)
        Me.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlbusqueda.Location = New System.Drawing.Point(4, 4)
        Me.pnlbusqueda.Name = "pnlbusqueda"
        Me.pnlbusqueda.Size = New System.Drawing.Size(737, 41)
        Me.pnlbusqueda.TabIndex = 0
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(83, 7)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(494, 27)
        Me.txtbusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'Tbl_cargoBindingNavigator
        '
        Me.Tbl_cargoBindingNavigator.AddNewItem = Nothing
        Me.Tbl_cargoBindingNavigator.BackColor = System.Drawing.SystemColors.WindowText
        Me.Tbl_cargoBindingNavigator.BindingSource = Me.Tbl_cargoBindingSource
        Me.Tbl_cargoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_cargoBindingNavigator.DeleteItem = Nothing
        Me.Tbl_cargoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Tbl_cargoBindingNavigator.Location = New System.Drawing.Point(0, 44)
        Me.Tbl_cargoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_cargoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_cargoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_cargoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_cargoBindingNavigator.Name = "Tbl_cargoBindingNavigator"
        Me.Tbl_cargoBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.Tbl_cargoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_cargoBindingNavigator.Size = New System.Drawing.Size(753, 50)
        Me.Tbl_cargoBindingNavigator.TabIndex = 1
        Me.Tbl_cargoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 47)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'ToolStripDropDownButton1
        '
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
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
        'pnlheader
        '
        Me.pnlheader.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlheader.Controls.Add(Me.PictureBox1)
        Me.pnlheader.Controls.Add(Label2)
        Me.pnlheader.Controls.Add(Me.Panel1)
        Me.pnlheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlheader.Location = New System.Drawing.Point(0, 0)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(753, 44)
        Me.pnlheader.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 39)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnmin)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(594, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 44)
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
        Me.btnmin.Location = New System.Drawing.Point(72, 0)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(44, 44)
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
        Me.btnclose.Location = New System.Drawing.Point(116, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(43, 44)
        Me.btnclose.TabIndex = 0
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Tbl_cargoTableAdapter
        '
        Me.Tbl_cargoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_cargoTableAdapter = Me.Tbl_cargoTableAdapter
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
        Me.TableAdapterManager.tbl_unidMedidaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'vw_cargo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 451)
        Me.Controls.Add(Me.tccargo)
        Me.Controls.Add(Me.Tbl_cargoBindingNavigator)
        Me.Controls.Add(Me.pnlheader)
        Me.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "vw_cargo"
        Me.Text = "Registro de Cargo"
        Me.tccargo.ResumeLayout(False)
        Me.tpcargo.ResumeLayout(False)
        Me.tpcargo.PerformLayout()
        CType(Me.Tbl_cargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpdatos.ResumeLayout(False)
        CType(Me.Tbl_cargoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbusqueda.ResumeLayout(False)
        Me.pnlbusqueda.PerformLayout()
        CType(Me.Tbl_cargoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_cargoBindingNavigator.ResumeLayout(False)
        Me.Tbl_cargoBindingNavigator.PerformLayout()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tccargo As System.Windows.Forms.TabControl
    Friend WithEvents tpcargo As System.Windows.Forms.TabPage
    Friend WithEvents tpdatos As System.Windows.Forms.TabPage
    Friend WithEvents Dbo_coociDataSet As EjemploDatasetSQL.dbo_coociDataSet
    Friend WithEvents Tbl_cargoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_cargoTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_cargoTableAdapter
    Friend WithEvents TableAdapterManager As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_cargoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdCargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Tbl_cargoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pnlbusqueda As System.Windows.Forms.Panel
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
End Class
