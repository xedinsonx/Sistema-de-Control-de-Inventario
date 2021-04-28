Imports Entidad
Imports System.Data.SqlClient
Public Class CargosDA

    Public Function Listar_Cargos() As DataTable
        Using cn As New SqlConnection(con)
            Dim cmd As New SqlCommand()
            cmd.Connection = cn
            cmd.CommandText = "Listar_Cargos"
            cmd.CommandType = CommandType.StoredProcedure

            Dim da = New SqlDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = cmd
            cn.Open()
            da.Fill(dt)
            Return dt
        End Using
    End Function

    Public Function Registrar_Cargos(obj As CargosEN) As String
        Using cn As New SqlConnection(con)
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "Registrar_Cargos"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@DescripcionCargo", SqlDbType.VarChar).Value = obj.DescripcionCargo

            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If

            cn.Open()

            cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function Modificar_Cargos(obj As CargosEN) As String
        Using cn As New SqlConnection(con)
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "Modificar_Cargos"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@DescripcionCargo", SqlDbType.VarChar).Value = obj.DescripcionCargo
            cmd.Parameters.AddWithValue("IdCargo", obj.IdCargo)

            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If

            cn.Open()

            cmd.ExecuteNonQuery()
        End Using
    End Function

    Public Function Eliminar_Cargos(obj As CargosEN) As String
        Using cn As New SqlConnection(con)
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "Eliminar_Cargos"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("IdCargo", obj.IdCargo)

            If cn.State = ConnectionState.Open Then
                cn.Close()

            End If

            cn.Open()

            cmd.ExecuteNonQuery()
        End Using
    End Function



End Class
