Imports Datos
Imports Entidad
Public Class FrmCargos
    Dim obe As New CargosEN
    Dim obd As New CargosDA

    Sub limpiar()
        txtdescripcion.Clear()
        lblid.Text = "0"
    End Sub

    Sub Listar_Cargos()
        Dim dt As DataTable = obd.Listar_Cargos()
        dgvdatos.DataSource = dt
    End Sub
    Private Sub FrmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Cargos()

    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        If btnnuevo.Text = "Nuevo" Then
            btnnuevo.Text = "Guardar"
            txtdescripcion.Enabled = True
        ElseIf btnnuevo.Text = "Guardar" Then

            obe.DescripcionCargo = txtdescripcion.Text

            obd.Registrar_Cargos(obe)

            MsgBox("Registrado Correctamente")

            Listar_Cargos()

            limpiar()


        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If btnmodificar.Text = "Modificar" Then
            btnmodificar.Text = "actualizar"

            txtdescripcion.Enabled = True
        ElseIf btnmodificar.Text = "actualizar" Then

            obe.IdCargo = Val(lblid.Text)
            obe.DescripcionCargo = txtdescripcion.Text

            obd.Modificar_Cargos(obe)

            MsgBox("Modificado Correctamente")

            Listar_Cargos()

            limpiar()


        End If
    End Sub

    Private Sub dgvdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdatos.CellDoubleClick
        Dim i As Integer
        i = dgvdatos.CurrentRow.Index

        txtdescripcion.Text = dgvdatos.Rows(i).Cells("DescripcionCargo").Value
        lblid.Text = dgvdatos.Rows(i).Cells(0).Value
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        obe.IdCargo = Val(lblid.Text)

        obd.Eliminar_Cargos(obe)

        MsgBox("elimnado Correctamente")

        Listar_Cargos()

        limpiar()

    End Sub
End Class