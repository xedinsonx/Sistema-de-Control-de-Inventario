Imports System.Data.SqlClient

Module Conexion

    Public con As String = "Data Source = . ; Database = BD_Control ; Integrated Security = True;"
    ' Public conexion As String = "Data Source = . ; Database = BD_Control ; User Id=sa; Password=123456;"

    Public objconexion As New SqlConnection(con)

End Module
