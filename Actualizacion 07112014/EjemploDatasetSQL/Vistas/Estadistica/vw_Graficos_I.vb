Public Class vw_Graficos_I

    Private Sub vw_Graficos_I_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_detalleCliente' Puede moverla o quitarla según sea necesario.
        Me.Tbl_detalleClienteTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_detalleCliente)
        'TODO: esta línea de código carga datos en la tabla 'Dbo_coociDataSet.tbl_Proyectos' Puede moverla o quitarla según sea necesario.
        Me.Tbl_ProyectosTableAdapter.Fill(Me.Dbo_coociDataSet.tbl_Proyectos)

    End Sub

    Private Sub Costo_proyectoToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Tbl_ProyectosTableAdapter.costo_proyecto(Me.Dbo_coociDataSet.tbl_Proyectos)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class