Public Enum PosteoStatusEnum
    Continue = 1
    Skip = 2
    Abort = 3
End Enum

Public Class PosteoEventArgs
    Inherits EventArgs
    Public Count As Integer
    Public Current As Integer
    Public Periodo As Entidades.Periodo
    Public Status As PosteoStatusEnum
End Class


Public Interface IPosteo

    Event Posting(ByVal e As PosteoEventArgs)
    Event Posted(ByVal e As PosteoEventArgs)

    Function isValid(ByVal p_Args As IParametrosAplicar) As Boolean
    Function Aplicar(ByVal p_Args As IParametrosAplicar) As Boolean

End Interface

