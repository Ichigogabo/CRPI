Public Class Dashboard

    Private Sub OpenWindows(ByVal ventana As Object, ByVal panel As Panel)
        ventana.TopLevel = False
        ventana.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        ventana.Dock = DockStyle.Fill
        panel.Controls.Add(ventana)
        panel.Tag = ventana
        ventana.Show()

    End Sub
    Private Sub RandomColorDesktop()

        RandomColor(pnldatosclientes)
        RandomColor(pnldatosempleados)
        RandomColor(pnldatosmateriales)
        RandomColor(pnldatosproyectos)
        RandomColor(pnlfecha)
        RandomColor(pnldatoscargos)

    End Sub
    Private Sub RandomColor(ByVal objeto As Object)
        Dim MyAlpha As Integer
        Dim MyRed As Integer
        Dim MyGreen As Integer
        Dim MyBlue As Integer
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyAlpha = CInt(Int((254 * Rnd()) + 1))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyRed = CInt(Int((254 * Rnd()) + 1))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyGreen = CInt(Int((254 * Rnd()) + 1))
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6.
        MyBlue = CInt(Int((254 * Rnd()) + 1))

        objeto.BackColor = Color.FromArgb(200, MyGreen, MyBlue)
    End Sub
    Private Sub btnCargo_Click(sender As System.Object, e As System.EventArgs) Handles btnCargo.Click
        'If (Me.pnlformulario.Controls.Count And gt 0) Then
        'Me.pnlformulario.Controls.RemoveAt(0)

        tpformularios.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        OpenWindows(vw_cargo, pnlformulario)
        lblnavigation.Text = "DASHBOARD-REGISTRO-CARGO"
        'End If
        '    this.panelContenedor.Controls.RemoveAt(0);
        'Form fh = formHijo as Form;
        'fh.TopLevel = false;
        'fh.FormBorderStyle = FormBorderStyle.None;
        'fh.Dock = DockStyle.Fill;
        'this.panelContenedor.Controls.Add(fh);
        'this.panelContenedor.Tag = fh;
        'fh.Show();
    End Sub

    Private Function gt() As Integer
        Throw New NotImplementedException
    End Function

    Private Sub btnmenu_Click(sender As System.Object, e As System.EventArgs) Handles btnmenu.Click
        If pnlcontrolmenu.Visible Then
            pnlcontrolmenu.Visible = False
            If pnlopcionmenu.Visible Then
                pnlopcionmenu.Visible = False
            End If

        Else
            pnlcontrolmenu.Visible = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnregistro_Click(sender As System.Object, e As System.EventArgs) Handles btnregistro.Click
        pnlopcionmenu.Visible = True
        pnlRegistro.Visible = True
        pnlBodega.Visible = False
        pnlconsulta.Visible = False
        pnlProyecto.Visible = False
        pnlinforme.Visible = False
        lblnavigation.Text = "DASHBOARD-REGISTRO"
        tpformularios.Text = "REGISTRO"
    End Sub

    Private Sub btnperfils_Click(sender As System.Object, e As System.EventArgs) Handles btnperfils.Click
        If pnlUser.Visible = True Then
            pnlUser.Visible = False
        Else
            pnlUser.Visible = True
        End If
    End Sub

    Private Sub Dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tpformularios.Parent = Nothing
        RandomColorDesktop()
        Timer1.Start()
    End Sub

    Private Sub btngrafanterior_Click(sender As System.Object, e As System.EventArgs) Handles btngrafanterior.Click
        OpenWindows(vw_Graficos_I, pnlgraficos)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        TabControl1.SelectedIndex = 0
        tpformularios.Parent = Nothing
    End Sub

    Private Sub btnMateriales_Click(sender As System.Object, e As System.EventArgs) Handles btnMateriales.Click
        tpformularios.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        OpenWindows(vw_material, pnlformulario)
        vw_cargo.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblfecha.Text = Date.Now.ToShortDateString
        lblhora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub btnUnidades_Click(sender As System.Object, e As System.EventArgs) Handles btnUnidades.Click
        tpformularios.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        OpenWindows(vw_undmedida, pnlformulario)
        vw_cargo.WindowState = FormWindowState.Minimized
        vw_material.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        tpformularios.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        OpenWindows(vw_cliente, pnlformulario)
        'vw_cargo.WindowState = FormWindowState.Minimized
        'vw_material.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        pnlopcionmenu.Visible = True
        pnlRegistro.Visible = False
        pnlBodega.Visible = False
        pnlconsulta.Visible = False
        pnlProyecto.Visible = True
        pnlinforme.Visible = False
        lblnavigation.Text = "DASHBOARD-PROYECTO"
        tpformularios.Text = "PROYECTO"
    End Sub

    Private Sub btnproyecto_Click(sender As System.Object, e As System.EventArgs) Handles btnproyecto.Click
        tpformularios.Parent = TabControl1
        TabControl1.SelectedIndex = 1
        OpenWindows(vw_proyecto, pnlformulario)
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        pnlopcionmenu.Visible = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Size = New Size(106, 618)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class