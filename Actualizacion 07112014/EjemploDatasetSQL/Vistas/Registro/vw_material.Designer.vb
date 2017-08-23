<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vw_material
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim UNDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vw_material))
        Me.Dbo_coociDataSet = New EjemploDatasetSQL.dbo_coociDataSet()
        Me.Tbl_materialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_materialesTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_materialesTableAdapter()
        Me.TableAdapterManager = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_materialesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpMateriales = New System.Windows.Forms.TabPage()
        Me.Vw_datosMaterialDataGridView = New System.Windows.Forms.DataGridView()
        Me.Vw_datosMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlbusqueda = New System.Windows.Forms.Panel()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpdatos = New System.Windows.Forms.TabPage()
        Me.cmbUnidMedida = New System.Windows.Forms.ComboBox()
        Me.TblunidMedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TblunidMedidaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_unidMedidaTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_unidMedidaTableAdapter()
        Me.Vw_datosMaterialTableAdapter = New EjemploDatasetSQL.dbo_coociDataSetTableAdapters.vw_datosMaterialTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        MaterialLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        UNDLabel = New System.Windows.Forms.Label()
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_materialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_materialesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_materialesBindingNavigator.SuspendLayout()
        Me.pnlheader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpMateriales.SuspendLayout()
        CType(Me.Vw_datosMaterialDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_datosMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbusqueda.SuspendLayout()
        Me.tpdatos.SuspendLayout()
        CType(Me.TblunidMedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblunidMedidaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label2.Location = New System.Drawing.Point(71, 13)
        Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(188, 20)
        Label2.TabIndex = 3
        Label2.Text = "REGISTRO DE MATERIALES"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(683, 25)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(27, 20)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.Location = New System.Drawing.Point(35, 77)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(67, 20)
        MaterialLabel.TabIndex = 21
        MaterialLabel.Text = "Material:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(35, 149)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(72, 20)
        CantidadLabel.TabIndex = 23
        CantidadLabel.Text = "Cantidad:"
        '
        'UNDLabel
        '
        UNDLabel.AutoSize = True
        UNDLabel.Location = New System.Drawing.Point(35, 225)
        UNDLabel.Name = "UNDLabel"
        UNDLabel.Size = New System.Drawing.Size(136, 20)
        UNDLabel.TabIndex = 25
        UNDLabel.Text = "Unidad de Medida:"
        '
        'Dbo_coociDataSet
        '
        Me.Dbo_coociDataSet.DataSetName = "dbo_coociDataSet"
        Me.Dbo_coociDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_materialesBindingSource
        '
        Me.Tbl_materialesBindingSource.DataMember = "tbl_materiales"
        Me.Tbl_materialesBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'Tbl_materialesTableAdapter
        '
        Me.Tbl_materialesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_materialesTableAdapter = Me.Tbl_materialesTableAdapter
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
        'Tbl_materialesBindingNavigator
        '
        Me.Tbl_materialesBindingNavigator.AddNewItem = Nothing
        Me.Tbl_materialesBindingNavigator.BackColor = System.Drawing.Color.Black
        Me.Tbl_materialesBindingNavigator.BindingSource = Me.Tbl_materialesBindingSource
        Me.Tbl_materialesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_materialesBindingNavigator.DeleteItem = Nothing
        Me.Tbl_materialesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Tbl_materialesBindingNavigator.Location = New System.Drawing.Point(0, 44)
        Me.Tbl_materialesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_materialesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_materialesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_materialesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_materialesBindingNavigator.Name = "Tbl_materialesBindingNavigator"
        Me.Tbl_materialesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_materialesBindingNavigator.Size = New System.Drawing.Size(911, 50)
        Me.Tbl_materialesBindingNavigator.TabIndex = 0
        Me.Tbl_materialesBindingNavigator.Text = "BindingNavigator1"
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
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
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
        Me.pnlheader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlheader.Name = "pnlheader"
        Me.pnlheader.Size = New System.Drawing.Size(911, 44)
        Me.pnlheader.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.Panel1.Location = New System.Drawing.Point(699, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 44)
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
        Me.btnmin.Location = New System.Drawing.Point(133, 0)
        Me.btnmin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmin.Name = "btnmin"
        Me.btnmin.Size = New System.Drawing.Size(41, 44)
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
        Me.btnclose.Location = New System.Drawing.Point(174, 0)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(38, 44)
        Me.btnclose.TabIndex = 0
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpMateriales)
        Me.TabControl1.Controls.Add(Me.tpdatos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 94)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(911, 566)
        Me.TabControl1.TabIndex = 11
        '
        'tpMateriales
        '
        Me.tpMateriales.Controls.Add(Me.Vw_datosMaterialDataGridView)
        Me.tpMateriales.Controls.Add(Me.pnlbusqueda)
        Me.tpMateriales.Location = New System.Drawing.Point(4, 29)
        Me.tpMateriales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpMateriales.Name = "tpMateriales"
        Me.tpMateriales.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpMateriales.Size = New System.Drawing.Size(903, 533)
        Me.tpMateriales.TabIndex = 1
        Me.tpMateriales.Text = "Materiales Existentes"
        Me.tpMateriales.UseVisualStyleBackColor = True
        '
        'Vw_datosMaterialDataGridView
        '
        Me.Vw_datosMaterialDataGridView.AllowUserToAddRows = False
        Me.Vw_datosMaterialDataGridView.AllowUserToDeleteRows = False
        Me.Vw_datosMaterialDataGridView.AllowUserToOrderColumns = True
        Me.Vw_datosMaterialDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Vw_datosMaterialDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Vw_datosMaterialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vw_datosMaterialDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vw_datosMaterialDataGridView.Location = New System.Drawing.Point(4, 46)
        Me.Vw_datosMaterialDataGridView.Name = "Vw_datosMaterialDataGridView"
        Me.Vw_datosMaterialDataGridView.ReadOnly = True
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(2)
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.Vw_datosMaterialDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow
        Me.Vw_datosMaterialDataGridView.RowTemplate.Height = 44
        Me.Vw_datosMaterialDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Vw_datosMaterialDataGridView.Size = New System.Drawing.Size(895, 482)
        Me.Vw_datosMaterialDataGridView.TabIndex = 11
        '
        'Vw_datosMaterialBindingSource
        '
        Me.Vw_datosMaterialBindingSource.DataMember = "vw_datosMaterial"
        Me.Vw_datosMaterialBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'pnlbusqueda
        '
        Me.pnlbusqueda.Controls.Add(Me.txtbusqueda)
        Me.pnlbusqueda.Controls.Add(Me.Label1)
        Me.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlbusqueda.Location = New System.Drawing.Point(4, 5)
        Me.pnlbusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlbusqueda.Name = "pnlbusqueda"
        Me.pnlbusqueda.Size = New System.Drawing.Size(895, 41)
        Me.pnlbusqueda.TabIndex = 11
        '
        'txtbusqueda
        '
        Me.txtbusqueda.Location = New System.Drawing.Point(111, 6)
        Me.txtbusqueda.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(715, 27)
        Me.txtbusqueda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'tpdatos
        '
        Me.tpdatos.BackColor = System.Drawing.Color.CornflowerBlue
        Me.tpdatos.Controls.Add(Me.btncancelar)
        Me.tpdatos.Controls.Add(Me.btnActualizar)
        Me.tpdatos.Controls.Add(Me.Button2)
        Me.tpdatos.Controls.Add(Me.cmbUnidMedida)
        Me.tpdatos.Controls.Add(IDLabel)
        Me.tpdatos.Controls.Add(Me.IDTextBox)
        Me.tpdatos.Controls.Add(MaterialLabel)
        Me.tpdatos.Controls.Add(Me.MaterialTextBox)
        Me.tpdatos.Controls.Add(CantidadLabel)
        Me.tpdatos.Controls.Add(Me.CantidadTextBox)
        Me.tpdatos.Controls.Add(UNDLabel)
        Me.tpdatos.Controls.Add(Me.Button1)
        Me.tpdatos.Controls.Add(Me.btnGuardar)
        Me.tpdatos.Location = New System.Drawing.Point(4, 29)
        Me.tpdatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpdatos.Name = "tpdatos"
        Me.tpdatos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpdatos.Size = New System.Drawing.Size(903, 533)
        Me.tpdatos.TabIndex = 0
        Me.tpdatos.Text = "Datos del Material"
        '
        'cmbUnidMedida
        '
        Me.cmbUnidMedida.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cmbUnidMedida.FormattingEnabled = True
        Me.cmbUnidMedida.Location = New System.Drawing.Point(39, 257)
        Me.cmbUnidMedida.Name = "cmbUnidMedida"
        Me.cmbUnidMedida.Size = New System.Drawing.Size(264, 28)
        Me.cmbUnidMedida.TabIndex = 26
        '
        'TblunidMedidaBindingSource
        '
        Me.TblunidMedidaBindingSource.DataMember = "tbl_unidMedida"
        Me.TblunidMedidaBindingSource.DataSource = Me.Dbo_coociDataSet
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_datosMaterialBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(761, 22)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 27)
        Me.IDTextBox.TabIndex = 20
        Me.IDTextBox.Visible = False
        '
        'MaterialTextBox
        '
        Me.MaterialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_datosMaterialBindingSource, "Material", True))
        Me.MaterialTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MaterialTextBox.Location = New System.Drawing.Point(39, 110)
        Me.MaterialTextBox.Name = "MaterialTextBox"
        Me.MaterialTextBox.Size = New System.Drawing.Size(264, 27)
        Me.MaterialTextBox.TabIndex = 22
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_datosMaterialBindingSource, "Cantidad", True))
        Me.CantidadTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CantidadTextBox.Location = New System.Drawing.Point(39, 183)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(264, 27)
        Me.CantidadTextBox.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 46)
        Me.Button1.TabIndex = 19
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
        Me.btnGuardar.Location = New System.Drawing.Point(182, 306)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(122, 38)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TblunidMedidaBindingSource1
        '
        Me.TblunidMedidaBindingSource1.DataMember = "tbl_unidMedida"
        Me.TblunidMedidaBindingSource1.DataSource = Me.Dbo_coociDataSet
        '
        'Tbl_unidMedidaTableAdapter
        '
        Me.Tbl_unidMedidaTableAdapter.ClearBeforeFill = True
        '
        'Vw_datosMaterialTableAdapter
        '
        Me.Vw_datosMaterialTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(309, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 30)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(39, 306)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(131, 38)
        Me.btncancelar.TabIndex = 29
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
        Me.btnActualizar.Location = New System.Drawing.Point(182, 306)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(121, 38)
        Me.btnActualizar.TabIndex = 28
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = False
        Me.btnActualizar.Visible = False
        '
        'vw_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 660)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Tbl_materialesBindingNavigator)
        Me.Controls.Add(Me.pnlheader)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "vw_material"
        Me.Text = "vw_material"
        CType(Me.Dbo_coociDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_materialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_materialesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_materialesBindingNavigator.ResumeLayout(False)
        Me.Tbl_materialesBindingNavigator.PerformLayout()
        Me.pnlheader.ResumeLayout(False)
        Me.pnlheader.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpMateriales.ResumeLayout(False)
        CType(Me.Vw_datosMaterialDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_datosMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbusqueda.ResumeLayout(False)
        Me.pnlbusqueda.PerformLayout()
        Me.tpdatos.ResumeLayout(False)
        Me.tpdatos.PerformLayout()
        CType(Me.TblunidMedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblunidMedidaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dbo_coociDataSet As EjemploDatasetSQL.dbo_coociDataSet
    Friend WithEvents Tbl_materialesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_materialesTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_materialesTableAdapter
    Friend WithEvents TableAdapterManager As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_materialesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlheader As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnmin As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpMateriales As System.Windows.Forms.TabPage
    Friend WithEvents tpdatos As System.Windows.Forms.TabPage
    Friend WithEvents pnlbusqueda As System.Windows.Forms.Panel
    Friend WithEvents txtbusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblunidMedidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_unidMedidaTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.tbl_unidMedidaTableAdapter
    Friend WithEvents TblunidMedidaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Vw_datosMaterialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_datosMaterialTableAdapter As EjemploDatasetSQL.dbo_coociDataSetTableAdapters.vw_datosMaterialTableAdapter
    Friend WithEvents Vw_datosMaterialDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmbUnidMedida As System.Windows.Forms.ComboBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MaterialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
