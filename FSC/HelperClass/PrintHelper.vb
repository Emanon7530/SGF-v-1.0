Public Class PrintHelper


    Public Shared Function FormatearParatetroMock() As String

        Dim cmd As String = String.Empty

        Dim inicio As Short = &HAS 'Int16.Parse("H" + Parametro.Substring(0, 2) + "s")
        Dim final As Short = &H1S 'Int16.Parse(Parametro.Substring(3, 2))

        cmd = Chr(inicio) + Chr(final)

        Return cmd

    End Function


    Public Shared Function FormatearParametro(ByVal Parametro As String) As String

        Dim cmd As String = String.Empty

        Dim inicio As Short = GetShortFromString(Parametro.Substring(0, 2))
        Dim final As Short = GetShortFromString(Parametro.Substring(2, 2))

        cmd = Chr(inicio) + Chr(final)

        Return cmd

    End Function

    Public Shared Function GetShortFromString(ByVal Comando As String) As Short
        Return Convert.ToInt32(Comando, 16)
    End Function


End Class
