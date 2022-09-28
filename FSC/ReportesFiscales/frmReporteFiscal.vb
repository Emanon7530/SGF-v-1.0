'Printer [Epson] References
Imports EpsonFPHostControlX
Imports AxEpsonFPHostControlX

'Fiscal Print References
Imports System.Data.SqlClient
Imports LibXPrintFiscal.Helpers
Imports LibXPrintFiscal.Interfaces
Imports LibXPrintFiscal.Repositorios
Imports LibxPrintFiscalSGF
Imports LibxPrintFiscalSGF.Modelos
Imports LibxPrintFiscalFactura

Imports System.Text.RegularExpressions.Regex

Public Class frmReporteFiscal
    Inherits System.Windows.Forms.Form

    Private Epson = New AxEpsonFPHostControl
    Private dbOPenn As Object
    Private maquinaCaja As String
    Private MaquinaAutorizadas As String()


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        'Initializing the Epson Library
        Me.Controls.Add(Epson)

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tabReportesFiscales As System.Windows.Forms.TabControl
    Friend WithEvents tabCierreZRango As System.Windows.Forms.TabPage
    Friend WithEvents tabCierreZFecha As System.Windows.Forms.TabPage
    Friend WithEvents tabLibroVentaDia As System.Windows.Forms.TabPage
    Friend WithEvents tabLibroVentaMes As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerateZRango As System.Windows.Forms.Button
    Friend WithEvents btnGenerateZFecha As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRangoZInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtRangoZFinal As System.Windows.Forms.TextBox
    Friend WithEvents dtPickerFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPickerFechaInicial As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tabReportesFiscales = New System.Windows.Forms.TabControl
        Me.tabCierreZRango = New System.Windows.Forms.TabPage
        Me.btnGenerateZRango = New System.Windows.Forms.Button
        Me.txtRangoZFinal = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRangoZInicial = New System.Windows.Forms.TextBox
        Me.tabCierreZFecha = New System.Windows.Forms.TabPage
        Me.dtPickerFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtPickerFechaInicial = New System.Windows.Forms.DateTimePicker
        Me.btnGenerateZFecha = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabLibroVentaDia = New System.Windows.Forms.TabPage
        Me.tabLibroVentaMes = New System.Windows.Forms.TabPage
        Me.tabReportesFiscales.SuspendLayout()
        Me.tabCierreZRango.SuspendLayout()
        Me.tabCierreZFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabReportesFiscales
        '
        Me.tabReportesFiscales.Controls.Add(Me.tabCierreZRango)
        Me.tabReportesFiscales.Controls.Add(Me.tabCierreZFecha)
        Me.tabReportesFiscales.Controls.Add(Me.tabLibroVentaDia)
        Me.tabReportesFiscales.Controls.Add(Me.tabLibroVentaMes)
        Me.tabReportesFiscales.Location = New System.Drawing.Point(16, 56)
        Me.tabReportesFiscales.Multiline = True
        Me.tabReportesFiscales.Name = "tabReportesFiscales"
        Me.tabReportesFiscales.SelectedIndex = 0
        Me.tabReportesFiscales.Size = New System.Drawing.Size(552, 224)
        Me.tabReportesFiscales.TabIndex = 0
        '
        'tabCierreZRango
        '
        Me.tabCierreZRango.Controls.Add(Me.btnGenerateZRango)
        Me.tabCierreZRango.Controls.Add(Me.txtRangoZFinal)
        Me.tabCierreZRango.Controls.Add(Me.Label2)
        Me.tabCierreZRango.Controls.Add(Me.Label1)
        Me.tabCierreZRango.Controls.Add(Me.txtRangoZInicial)
        Me.tabCierreZRango.Location = New System.Drawing.Point(4, 22)
        Me.tabCierreZRango.Name = "tabCierreZRango"
        Me.tabCierreZRango.Size = New System.Drawing.Size(544, 198)
        Me.tabCierreZRango.TabIndex = 0
        Me.tabCierreZRango.Text = "Cierre Z por Rango"
        '
        'btnGenerateZRango
        '
        Me.btnGenerateZRango.Location = New System.Drawing.Point(168, 144)
        Me.btnGenerateZRango.Name = "btnGenerateZRango"
        Me.btnGenerateZRango.Size = New System.Drawing.Size(240, 40)
        Me.btnGenerateZRango.TabIndex = 4
        Me.btnGenerateZRango.Text = "Generar Reporte"
        '
        'txtRangoZFinal
        '
        Me.txtRangoZFinal.Location = New System.Drawing.Point(384, 48)
        Me.txtRangoZFinal.MaxLength = 4
        Me.txtRangoZFinal.Name = "txtRangoZFinal"
        Me.txtRangoZFinal.Size = New System.Drawing.Size(56, 20)
        Me.txtRangoZFinal.TabIndex = 3
        Me.txtRangoZFinal.Text = ""
        Me.txtRangoZFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rango Z Final"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rango Z Inicial"
        '
        'txtRangoZInicial
        '
        Me.txtRangoZInicial.Location = New System.Drawing.Point(136, 48)
        Me.txtRangoZInicial.MaxLength = 4
        Me.txtRangoZInicial.Name = "txtRangoZInicial"
        Me.txtRangoZInicial.Size = New System.Drawing.Size(56, 20)
        Me.txtRangoZInicial.TabIndex = 0
        Me.txtRangoZInicial.Text = ""
        Me.txtRangoZInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tabCierreZFecha
        '
        Me.tabCierreZFecha.Controls.Add(Me.dtPickerFechaFinal)
        Me.tabCierreZFecha.Controls.Add(Me.dtPickerFechaInicial)
        Me.tabCierreZFecha.Controls.Add(Me.btnGenerateZFecha)
        Me.tabCierreZFecha.Controls.Add(Me.Label3)
        Me.tabCierreZFecha.Controls.Add(Me.Label4)
        Me.tabCierreZFecha.Location = New System.Drawing.Point(4, 22)
        Me.tabCierreZFecha.Name = "tabCierreZFecha"
        Me.tabCierreZFecha.Size = New System.Drawing.Size(544, 198)
        Me.tabCierreZFecha.TabIndex = 1
        Me.tabCierreZFecha.Text = "Cierre Z por Fecha"
        '
        'dtPickerFechaFinal
        '
        Me.dtPickerFechaFinal.Location = New System.Drawing.Point(104, 80)
        Me.dtPickerFechaFinal.Name = "dtPickerFechaFinal"
        Me.dtPickerFechaFinal.TabIndex = 11
        '
        'dtPickerFechaInicial
        '
        Me.dtPickerFechaInicial.Location = New System.Drawing.Point(104, 40)
        Me.dtPickerFechaInicial.MaxDate = New Date(4000, 12, 31, 0, 0, 0, 0)
        Me.dtPickerFechaInicial.Name = "dtPickerFechaInicial"
        Me.dtPickerFechaInicial.TabIndex = 10
        '
        'btnGenerateZFecha
        '
        Me.btnGenerateZFecha.Location = New System.Drawing.Point(168, 144)
        Me.btnGenerateZFecha.Name = "btnGenerateZFecha"
        Me.btnGenerateZFecha.Size = New System.Drawing.Size(240, 40)
        Me.btnGenerateZFecha.TabIndex = 9
        Me.btnGenerateZFecha.Text = "Generar Reporte"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Fecha Final"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Inicial"
        '
        'tabLibroVentaDia
        '
        Me.tabLibroVentaDia.Location = New System.Drawing.Point(4, 22)
        Me.tabLibroVentaDia.Name = "tabLibroVentaDia"
        Me.tabLibroVentaDia.Size = New System.Drawing.Size(544, 198)
        Me.tabLibroVentaDia.TabIndex = 2
        Me.tabLibroVentaDia.Text = "Libro de Venta (Dia)"
        '
        'tabLibroVentaMes
        '
        Me.tabLibroVentaMes.Location = New System.Drawing.Point(4, 22)
        Me.tabLibroVentaMes.Name = "tabLibroVentaMes"
        Me.tabLibroVentaMes.Size = New System.Drawing.Size(544, 198)
        Me.tabLibroVentaMes.TabIndex = 3
        Me.tabLibroVentaMes.Text = "Libro de Venta (Mes)"
        '
        'frmReporteFiscal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 349)
        Me.Controls.Add(Me.tabReportesFiscales)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(592, 376)
        Me.MinimumSize = New System.Drawing.Size(592, 376)
        Me.Name = "frmReporteFiscal"
        Me.Text = "Reportes Fiscal"
        Me.tabReportesFiscales.ResumeLayout(False)
        Me.tabCierreZRango.ResumeLayout(False)
        Me.tabCierreZFecha.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnGenerateZRango_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateZRango.Click
        If ValidateValues() Then

            Dim message As String = String.Format("Se generará el reporte Z por los rangos Inicial: {0} y Final: {1}", Me.txtRangoZInicial.Text, Me.txtRangoZFinal.Text)

            If MessageBox.Show(message, "Generar Reporte Z por Rango de Cierre", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Me.GenerateReporteZRango()
            End If
        End If
    End Sub


    Private Sub btnGenerateZFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateZFecha.Click
        If ValidateDateRanges() Then

            Dim reportes As Integer = DateDiff(DateInterval.Day, dtPickerFechaInicial.Value.Date, dtPickerFechaFinal.Value.Date, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)

            reportes += 1

            Dim message As String = _
            String.Format("Se generará el reporte Z para las Fecha Inicial: {0} y Final: {1} - [{2} dias]", _
                    Me.dtPickerFechaInicial.Value.ToString("dd/MM/yyyy"), _
                    Me.dtPickerFechaFinal.Value.ToString("dd/MM/yyyy"), _
                    reportes)

            If MessageBox.Show(message, "Generar Reporte Z por Rango de Fecha", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                Me.GenerateReporteZFecha()
            End If

        End If
    End Sub


    Private Sub GenerateReporteZRango()

        Dim Continuo As Boolean
        Dim printer As IPrintFiscal = CreatePrinterFactory()

        Dim rangoInicial As String = Me.txtRangoZInicial.Text
        Dim rangoFinal As String = Me.txtRangoZFinal.Text

        Try
            'Connect the Printer;
            'Continuo = printer.Connect(Puerto.COM1, Velocidad.br38400)
            Continuo = printer.Connect(maquinaCaja.ToString.Trim())
            If Not Continuo Then
                printer.Disconnect()
                ShowErrorMessage("Printing...", "Ocurrio un error abriendo el puerto de la impresora")
            End If

            Dim fisicaPrinter As ImpresoraFisica = printer.ImprimeCierreZPorRango(rangoInicial, rangoFinal)

            If Not fisicaPrinter.IsSucess Then
                MessageBox.Show(String.Format("Ocurrio un error imprimiendo. Codigo: {0} - Descripcion: {2} - Status: {1}", _
                                                        fisicaPrinter.ReturnCode, _
                                                        fisicaPrinter.PrinterStatus, _
                                                        fisicaPrinter.ErrorDescription), _
                                "Generando Cierre Z Por Rango de Cierres", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            '// TODO: Add Log
            Throw ex
        Finally
            printer.Disconnect()

        End Try

    End Sub


    Private Sub GenerateReporteZFecha()
        Dim Continuo As Boolean
        Dim printer As IPrintFiscal = CreatePrinterFactory()

        Dim rangoInicial As Date = Me.dtPickerFechaInicial.Value.Date
        Dim rangoFinal As Date = Me.dtPickerFechaFinal.Value.Date

        Dim reportes As Integer = DateDiff(DateInterval.Day, rangoInicial, rangoFinal, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1)

        reportes += 1

        Try
            'Connect the Printer;
            'Continuo = printer.Connect(Puerto.COM1, Velocidad.br38400)
            Continuo = printer.Connect(maquinaCaja.ToString.Trim())
            If Not Continuo Then
                printer.Disconnect()
                ShowErrorMessage("Printing...", "Ocurrio un error abriendo el puerto de la impresora")
            End If

            Dim fisicaPrinter As ImpresoraFisica = printer.ImprimeCierreZPorFecha(rangoInicial, rangoFinal, reportes)

            If Not fisicaPrinter.IsSucess Then
                MessageBox.Show(String.Format("Ocurrio un error imprimiendo. Codigo: {0} - Descripcion: {2} - Status: {1}", _
                                                        fisicaPrinter.ReturnCode, _
                                                        fisicaPrinter.PrinterStatus, _
                                                        fisicaPrinter.ErrorDescription), _
                                "Generando Cierre Z Por Rango de Fecha", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If

        Catch ex As Exception
            '// TODO: Add Log
            Throw ex
        Finally
            printer.Disconnect()

        End Try

    End Sub

    Private Function ValidateValues() As Boolean

        Dim rangoInicial As String = Me.txtRangoZInicial.Text
        Dim rangoFinal As String = Me.txtRangoZFinal.Text

        If rangoInicial = String.Empty Or rangoFinal = String.Empty Then
            MessageBox.Show("Rangos no pueden estar en blanco", _
                                    "Valores de rangos invalidos", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button1)
            Return False
        End If


        If Not IsNumber(rangoInicial) Or Not IsNumber(rangoFinal) Then
            MessageBox.Show("Rango contiene valores no numericos", _
                                    "Valores de rangos invalidos", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button1)
            Return False
        End If


        If TryParseInt(rangoInicial) = 0 And TryParseInt(rangoFinal) = 0 Then
            MessageBox.Show("Ambos rangos [inicial/final] no pueden ser cero (0)", _
                                    "Valores de rangos invalidos", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button1)
            Return False
        End If


        If TryParseInt(rangoInicial) > TryParseInt(rangoFinal) Then
            MessageBox.Show("Rango Final debe ser mayor o igual al Rango Inicial", _
                                    "Valores de rangos invalidos", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True

    End Function

    Private Function ValidateDateRanges() As Boolean

        Dim fechaInicial As Date = Me.dtPickerFechaInicial.Value.Date
        Dim fechaFinal As Date = Me.dtPickerFechaFinal.Value.Date

        If fechaInicial > fechaFinal Then
            MessageBox.Show("Fecha Final debe ser mayor o igual a la Fecha Inicial", _
                                    "Valores de las fechas invalidas", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Function CreatePrinterFactory() As IPrintFiscal

        Dim Connected As Boolean = False

        'Note: CajaId From AppSettings
        Dim cajaSetiada As String = maquinaCaja.ToString.Trim

        'Note: To use Redsoft Open Connection
        Dim dbconn As SqlConnection = New SqlConnection(dbOPenn)

        Dim _dbHandler As IDbHandler = New PrintDbHandler(dbconn)

        Dim factory As PrinterFactory = _
        New PrinterFactory( _
        New ParametroRepository(_dbHandler), _
        New ImpresoraRepository(_dbHandler), _
        New ExtensionRepository(_dbHandler), _
        New TipoPagoRepository(_dbHandler))

        'Pasando Dependencia por una propiedad
        factory.ErrorRetorno = New ErrorRetornoRepository(_dbHandler)

        Dim print As IPrintFiscal = New ImpresionFiscalEpson(factory, Epson, 1, cajaSetiada)

        Return print

    End Function


    Private Sub frmReporteFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaquinaAutorizadas = Split(System.Configuration.ConfigurationSettings.AppSettings.Get("LibxCaja"), ",")

        dbOPenn = Configuration.ConfigurationSettings.AppSettings.Get("LibxConnectFiscal").ToString
        'dbOPenn = "Server=OFICINA2\REDSOFT;Database=SGF_desarrollo;User Id=sa; Password=bojelnro;"

        For Each maquinaCaja In MaquinaAutorizadas
            If maquinaCaja.ToLower = System.Environment.MachineName.ToLower Then
            End If
        Next


    End Sub


    Private Sub txtRangoZFinal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRangoZFinal.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRangoZInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRangoZInicial.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Function IsNumber(ByVal number As String) As Boolean
        Static numberExpression As New System.Text.RegularExpressions.Regex("^\d+$")

        Return numberExpression.IsMatch(number.Trim)
    End Function


    Private Function TryParseInt(ByVal value As String) As Integer
        Dim int As Integer = 0

        Try
            int = Integer.Parse(value)
        Catch
        End Try

        Return int
    End Function


    Private Sub ShowErrorMessage(ByVal title As String, ByVal message As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    End Sub

End Class
