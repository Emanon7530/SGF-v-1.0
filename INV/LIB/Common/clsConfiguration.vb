Namespace Common
    Public Enum CostMethod
        FIFO = 0
        LIFO = 1
        PP = 2
    End Enum

    Public Class Configuration
        Shared CostMethod As String
        Shared ITBIS As Integer
        Shared ITBIS2 As Integer
        Shared DSCTO As Integer
        Shared DsctoTar As Decimal
        Shared AllowBO As Boolean
        Shared Benef As Decimal
        Shared Rounded As Decimal
        Shared DueDays As Integer
        Shared TasaUS As Decimal
        Shared PriceMajor As Decimal
        Shared PriceMin As Decimal
        Shared Charge As Decimal
        Shared _FacturaSinExistencia As Boolean
        Shared _CuentaInventario As String
        Shared _CuentaAjuste As String
        Shared _CuentaVentas As String
        Shared _CuentaInvFisico As String
        Shared Initialized As Boolean = False

        Public Shared ReadOnly Property CuentaInventario() As String
            Get
                Return _CuentaInventario
            End Get
        End Property

        Public Shared ReadOnly Property CuentaAjusteInventario() As String
            Get
                Return _CuentaAjuste
            End Get
        End Property

        Public Shared ReadOnly Property CuentaVentas() As String
            Get
                Return _CuentaVentas
            End Get
        End Property

        Public Shared ReadOnly Property CuentaInventarioFisico() As String
            Get
                Return _CuentaInvFisico
            End Get
        End Property

        Public Shared ReadOnly Property GetCharge() As Decimal
            Get
                Return Charge
            End Get
        End Property

        Public Shared ReadOnly Property GetCostMethdo() As CostMethod
            Get
                Dim meth As CostMethod

                Return meth
            End Get
        End Property

        Public Shared ReadOnly Property GetITBIS() As Integer
            Get
                Return ITBIS
            End Get
        End Property
        Public Shared ReadOnly Property GetITBISDOS() As Integer
            Get
                Return ITBIS2
            End Get
        End Property
        Public Shared ReadOnly Property GetDSCTO() As Integer
            Get
                Return DSCTO
            End Get
        End Property
        Public Shared ReadOnly Property GetDsctoTar() As Integer
            Get
                Return DsctoTar
            End Get
        End Property

        Public Shared ReadOnly Property GetAllowBO() As Boolean
            Get
                Return AllowBO
            End Get
        End Property

        Public Shared ReadOnly Property GetBenef() As Decimal
            Get
                Return Benef
            End Get
        End Property

        Public Shared ReadOnly Property GetRounded() As Decimal
            Get
                Return Rounded
            End Get
        End Property

        Public Shared ReadOnly Property GetDueDays() As Integer
            Get
                Return DueDays
            End Get
        End Property

        Public Shared ReadOnly Property FacturaSinExistencia() As Boolean
            Get
                Return _FacturaSinExistencia
            End Get
        End Property

        Public Shared ReadOnly Property GetTasaUS() As Decimal
            Get
                Return TasaUS
            End Get
        End Property

        Public Shared ReadOnly Property GetPriceMajor() As Decimal
            Get
                Return PriceMajor
            End Get
        End Property

        Public Shared ReadOnly Property PriceMinim() As Decimal
            Get
                Return PriceMin
            End Get
        End Property

        Public Sub New()
            Call Init()
        End Sub

        Private Sub Init()
            Dim oRow As DataRow = LibX.Data.Manager.GetDataRow("select * from ivsetup")

            If Not LibX.IsNull(oRow!cost_method) Then
                CostMethod = oRow!cost_method
            End If

            If Not LibX.IsNull(oRow!percent_itbis) Then
                ITBIS = oRow!percent_itbis
            End If
            If Not LibX.IsNull(oRow!percent_itbis2) Then
                ITBIS2 = oRow!percent_itbis2
            End If
            If Not LibX.IsNull(oRow!percent_dscto) Then
                DSCTO = oRow!percent_dscto
            End If
            If Not LibX.IsNull(oRow!percent_charge) Then
                DsctoTar = oRow!percent_charge
            End If

            If Not LibX.IsNull(oRow!allow_bo) Then
                AllowBO = oRow!allow_bo
            End If

            If Not LibX.IsNull(oRow!porc_benef) Then
                Benef = oRow!porc_benef
            End If

            If Not LibX.IsNull(oRow!rounded) Then
                Rounded = oRow!rounded
            End If

            If Not LibX.IsNull(oRow!due_days_cotiz) Then
                DueDays = oRow!due_days_cotiz
            End If

            If Not LibX.IsNull(oRow!TasaUS) Then
                TasaUS = oRow!TasaUS
            End If

            If Not LibX.IsNull(oRow!price_1) Then
                PriceMajor = oRow!price_1
            End If

            If Not LibX.IsNull(oRow!price_2) Then
                PriceMin = oRow!price_2
            End If

            If Not LibX.IsNull(oRow!charge) Then
                Charge = oRow!charge
            End If

            If Not LibX.IsNull(oRow!sin_existencia) AndAlso oRow!sin_existencia = 1 Then
                _FacturaSinExistencia = True
            Else
                _FacturaSinExistencia = False
            End If

            _CuentaInventario = oRow!acct_inv.ToString
            _CuentaInvFisico = oRow!acct_count.ToString
            _CuentaVentas = oRow!acct_sales.ToString
            _CuentaAjuste = oRow!acct_adjust.ToString

            Initialized = True
            oRow = Nothing

        End Sub
    End Class
End Namespace