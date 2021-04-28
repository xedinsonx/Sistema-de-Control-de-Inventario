Public Class CargosEN

    Private _IdCargo As String
    Public Property IdCargo() As String
        Get
            Return _IdCargo
        End Get
        Set(ByVal value As String)
            _IdCargo = value
        End Set
    End Property


    Private _DescripcionCargo As String
    Public Property DescripcionCargo() As String
        Get
            Return _DescripcionCargo
        End Get
        Set(ByVal value As String)
            _DescripcionCargo = value
        End Set
    End Property


End Class
