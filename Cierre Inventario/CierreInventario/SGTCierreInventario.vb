Imports System.ServiceProcess

Public Class SGTCierre
    Inherits System.ServiceProcess.ServiceBase

#Region " Component Designer generated code "

    Dim oTimer As System.Threading.Timer

    Public Sub New()
        MyBase.New()

        ' This call is required by the Component Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call
        If System.Diagnostics.EventLog.SourceExists("LibX") = False Then
            System.Diagnostics.EventLog.CreateEventSource("LibX", "SGTCierreInventario")
        End If

        EventLog1.Source = "LibX"
        EventLog1.Log = "SGTCierreInventario"

    End Sub

    'UserService overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' The main entry point for the process
    <MTAThread()> _
    Shared Sub Main()
        Dim ServicesToRun() As System.ServiceProcess.ServiceBase

        ' More than one NT Service may run within the same process. To add
        ' another service to this process, change the following line to
        ' create a second service object. For example,
        '
        '   ServicesToRun = New System.ServiceProcess.ServiceBase () {New Service1, New MySecondUserService}
        '
        ServicesToRun = New System.ServiceProcess.ServiceBase() {New SGTCierre}

        System.ServiceProcess.ServiceBase.Run(ServicesToRun)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  
    ' Do not modify it using the code editor.
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.EventLog1 = New System.Diagnostics.EventLog
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'EventLog1
        '
        '
        'SGTCierre
        '
        Me.ServiceName = "SGTCierre"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method s`hould set things
        ' in motion so your service can do its work.
        EventLog1.WriteEntry("SGT 1.0 Cierre de Inventario Iniciado")

        oTimer = New System.Threading.Timer(New System.Threading.TimerCallback(AddressOf TimerCallback), _
                                                Nothing, System.Threading.Timeout.Infinite, 10000)


        oTimer.Change(0, 10000)
    End Sub

    Public Sub TimerCallback(ByVal state As Object)
        EventLog1.WriteEntry("SGT 1.0 Verificar si cierre existe!")
        Try
            Dim oCierre As New EjecutarCierre

            oCierre.CrearCierre(Now.ToString("yyyy/MM/dd"))

        Catch ex As Exception
            EventLog1.WriteEntry("Error!" & ex.ToString)
        End Try

    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        EventLog1.WriteEntry("SGT 1.0 Cierre de Inventario Detenido")
        oTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)

    End Sub

    Protected Overrides Sub OnContinue()
        EventLog1.WriteEntry("SGT 1.0 El Servicio fue resturado!")

    End Sub

    Protected Overrides Sub OnPause()
        EventLog1.WriteEntry("SGT 1.0 El Servicio fue pausado!")

    End Sub

    Private Sub EventLog1_EntryWritten(ByVal sender As System.Object, ByVal e As System.Diagnostics.EntryWrittenEventArgs) Handles EventLog1.EntryWritten

    End Sub
End Class
