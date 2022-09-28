Module Main
    Sub Main()
        Try
            '// Instanciar la forma Splash
            Dim FrmSpl As New frmSplash
            FrmSpl.Show()

            '// Refrescar sus controles
            FrmSpl.Refresh()

            '// Instanciar el menu principal
            Dim frmMain As sgtmain
            frmMain = New sgtmain

            '// Cerrar la forma splash
            FrmSpl.Close()
            FrmSpl = Nothing

            frmMain.ShowDialog()

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub
End Module
