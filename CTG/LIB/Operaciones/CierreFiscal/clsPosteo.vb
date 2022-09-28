Public MustInherit Class Posteo
    Implements Intrefaces.IPosteo

    Public MustOverride Function Aplicar(ByVal p_Args As Intrefaces.IParametrosAplicar) As Boolean Implements Intrefaces.IPosteo.Aplicar

    Public Event Posted(ByVal e As Intrefaces.PosteoEventArgs) Implements Intrefaces.IPosteo.Posted

    Public Event Posting(ByVal e As Intrefaces.PosteoEventArgs) Implements Intrefaces.IPosteo.Posting

    Public MustOverride Function isValid(ByVal p_Args As Intrefaces.IParametrosAplicar) As Boolean Implements Intrefaces.IPosteo.isValid

End Class
