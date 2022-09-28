Imports System.Configuration
Imports System.Configuration.ConfigurationSettings

Public Class sgtmain
    Inherits System.Windows.Forms.Form
    Dim ProgramRunning As Hashtable
    Dim ProgramAccess As SGT.Administracion.Entidades.Program
    Dim ProgramParam As SGT.Administracion.Entidades.Program.PermissionArgs
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents MnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents MnuView As System.Windows.Forms.MenuItem
    Friend WithEvents MnuSistem As System.Windows.Forms.MenuItem
    Friend WithEvents MnuTools As System.Windows.Forms.MenuItem
    Friend WithEvents MnuWindows As System.Windows.Forms.MenuItem
    Friend WithEvents MnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents opcINV As System.Windows.Forms.MenuItem
    Friend WithEvents opcFCT As System.Windows.Forms.MenuItem
    Friend WithEvents opcCXC As System.Windows.Forms.MenuItem
    Friend WithEvents opcCXP As System.Windows.Forms.MenuItem
    Friend WithEvents OpcCTG As System.Windows.Forms.MenuItem
    Friend WithEvents OpcLargeIcon As System.Windows.Forms.MenuItem
    Friend WithEvents OpcSmallicon As System.Windows.Forms.MenuItem
    Friend WithEvents OpcDetail As System.Windows.Forms.MenuItem
    Friend WithEvents OpcList As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents stbMessage As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbUserName As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbNombre As System.Windows.Forms.StatusBarPanel
    Friend WithEvents LibXConnector1 As LibX.LibXConnector
    Friend WithEvents mnuRecent As System.Windows.Forms.MenuItem
    Friend WithEvents tbb_Products As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_Locales As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_Facturas As System.Windows.Forms.ToolBarButton
    Friend WithEvents stbDatabase As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents tbb_Excel As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents stbAlmacen As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents tbb_devoluciones As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_ajustes As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_clientes As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents tbb_recibos As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_facturacion As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_ingrso As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_estafetas As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(sgtmain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MnuFile = New System.Windows.Forms.MenuItem
        Me.mnuRecent = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MnuEdit = New System.Windows.Forms.MenuItem
        Me.MnuView = New System.Windows.Forms.MenuItem
        Me.OpcLargeIcon = New System.Windows.Forms.MenuItem
        Me.OpcSmallicon = New System.Windows.Forms.MenuItem
        Me.OpcDetail = New System.Windows.Forms.MenuItem
        Me.OpcList = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MnuSistem = New System.Windows.Forms.MenuItem
        Me.opcINV = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem179 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem176 = New System.Windows.Forms.MenuItem
        Me.MenuItem177 = New System.Windows.Forms.MenuItem
        Me.MenuItem178 = New System.Windows.Forms.MenuItem
        Me.MenuItem170 = New System.Windows.Forms.MenuItem
        Me.MenuItem166 = New System.Windows.Forms.MenuItem
        Me.MenuItem167 = New System.Windows.Forms.MenuItem
        Me.MenuItem168 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem212 = New System.Windows.Forms.MenuItem
        Me.MenuItem213 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem214 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem226 = New System.Windows.Forms.MenuItem
        Me.MenuItem164 = New System.Windows.Forms.MenuItem
        Me.MenuItem165 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem149 = New System.Windows.Forms.MenuItem
        Me.MenuItem183 = New System.Windows.Forms.MenuItem
        Me.MenuItem169 = New System.Windows.Forms.MenuItem
        Me.MenuItem181 = New System.Windows.Forms.MenuItem
        Me.opcFCT = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem144 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem161 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem162 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem163 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem117 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem119 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem120 = New System.Windows.Forms.MenuItem
        Me.MenuItem147 = New System.Windows.Forms.MenuItem
        Me.MenuItem171 = New System.Windows.Forms.MenuItem
        Me.MenuItem194 = New System.Windows.Forms.MenuItem
        Me.MenuItem182 = New System.Windows.Forms.MenuItem
        Me.MenuItem184 = New System.Windows.Forms.MenuItem
        Me.MenuItem186 = New System.Windows.Forms.MenuItem
        Me.MenuItem187 = New System.Windows.Forms.MenuItem
        Me.MenuItem195 = New System.Windows.Forms.MenuItem
        Me.MenuItem196 = New System.Windows.Forms.MenuItem
        Me.MenuItem197 = New System.Windows.Forms.MenuItem
        Me.MenuItem193 = New System.Windows.Forms.MenuItem
        Me.MenuItem172 = New System.Windows.Forms.MenuItem
        Me.MenuItem173 = New System.Windows.Forms.MenuItem
        Me.MenuItem174 = New System.Windows.Forms.MenuItem
        Me.MenuItem175 = New System.Windows.Forms.MenuItem
        Me.MenuItem203 = New System.Windows.Forms.MenuItem
        Me.MenuItem204 = New System.Windows.Forms.MenuItem
        Me.opcCXC = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem201 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem150 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem148 = New System.Windows.Forms.MenuItem
        Me.MenuItem188 = New System.Windows.Forms.MenuItem
        Me.MenuItem225 = New System.Windows.Forms.MenuItem
        Me.MenuItem189 = New System.Windows.Forms.MenuItem
        Me.MenuItem191 = New System.Windows.Forms.MenuItem
        Me.MenuItem190 = New System.Windows.Forms.MenuItem
        Me.opcCXP = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem207 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem198 = New System.Windows.Forms.MenuItem
        Me.MenuItem199 = New System.Windows.Forms.MenuItem
        Me.MenuItem200 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem227 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.OpcCTG = New System.Windows.Forms.MenuItem
        Me.MenuItem121 = New System.Windows.Forms.MenuItem
        Me.MenuItem131 = New System.Windows.Forms.MenuItem
        Me.MenuItem136 = New System.Windows.Forms.MenuItem
        Me.MenuItem145 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem132 = New System.Windows.Forms.MenuItem
        Me.MenuItem126 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem146 = New System.Windows.Forms.MenuItem
        Me.MenuItem138 = New System.Windows.Forms.MenuItem
        Me.MenuItem157 = New System.Windows.Forms.MenuItem
        Me.MenuItem122 = New System.Windows.Forms.MenuItem
        Me.MenuItem123 = New System.Windows.Forms.MenuItem
        Me.MenuItem124 = New System.Windows.Forms.MenuItem
        Me.MenuItem125 = New System.Windows.Forms.MenuItem
        Me.MenuItem127 = New System.Windows.Forms.MenuItem
        Me.MenuItem128 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.MenuItem139 = New System.Windows.Forms.MenuItem
        Me.MenuItem140 = New System.Windows.Forms.MenuItem
        Me.MenuItem129 = New System.Windows.Forms.MenuItem
        Me.MenuItem130 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.MenuItem160 = New System.Windows.Forms.MenuItem
        Me.MenuItem158 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.MenuItem159 = New System.Windows.Forms.MenuItem
        Me.MenuItem137 = New System.Windows.Forms.MenuItem
        Me.MenuItem141 = New System.Windows.Forms.MenuItem
        Me.MenuItem142 = New System.Windows.Forms.MenuItem
        Me.MenuItem143 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.MenuItem215 = New System.Windows.Forms.MenuItem
        Me.MenuItem180 = New System.Windows.Forms.MenuItem
        Me.MenuItem216 = New System.Windows.Forms.MenuItem
        Me.MenuItem217 = New System.Windows.Forms.MenuItem
        Me.MenuItem218 = New System.Windows.Forms.MenuItem
        Me.MenuItem219 = New System.Windows.Forms.MenuItem
        Me.MenuItem220 = New System.Windows.Forms.MenuItem
        Me.MenuItem221 = New System.Windows.Forms.MenuItem
        Me.MenuItem222 = New System.Windows.Forms.MenuItem
        Me.MenuItem223 = New System.Windows.Forms.MenuItem
        Me.MenuItem224 = New System.Windows.Forms.MenuItem
        Me.MnuTools = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.MenuItem206 = New System.Windows.Forms.MenuItem
        Me.MenuItem228 = New System.Windows.Forms.MenuItem
        Me.MenuItem185 = New System.Windows.Forms.MenuItem
        Me.MenuItem192 = New System.Windows.Forms.MenuItem
        Me.MenuItem202 = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.MenuItem205 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem208 = New System.Windows.Forms.MenuItem
        Me.MenuItem209 = New System.Windows.Forms.MenuItem
        Me.MenuItem210 = New System.Windows.Forms.MenuItem
        Me.MenuItem211 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem116 = New System.Windows.Forms.MenuItem
        Me.MnuWindows = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MnuHelp = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tbb_Products = New System.Windows.Forms.ToolBarButton
        Me.tbb_Locales = New System.Windows.Forms.ToolBarButton
        Me.tbb_devoluciones = New System.Windows.Forms.ToolBarButton
        Me.tbb_ajustes = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.tbb_clientes = New System.Windows.Forms.ToolBarButton
        Me.tbb_Facturas = New System.Windows.Forms.ToolBarButton
        Me.tbb_recibos = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.tbb_facturacion = New System.Windows.Forms.ToolBarButton
        Me.tbb_estafetas = New System.Windows.Forms.ToolBarButton
        Me.tbb_ingrso = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.tbb_Excel = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.stbMessage = New System.Windows.Forms.StatusBarPanel
        Me.stbUserName = New System.Windows.Forms.StatusBarPanel
        Me.stbNombre = New System.Windows.Forms.StatusBarPanel
        Me.stbDatabase = New System.Windows.Forms.StatusBarPanel
        Me.stbAlmacen = New System.Windows.Forms.StatusBarPanel
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.MenuItem229 = New System.Windows.Forms.MenuItem
        CType(Me.stbMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stbAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnuFile, Me.MnuEdit, Me.MnuView, Me.MnuSistem, Me.MnuTools, Me.MnuWindows, Me.MnuHelp})
        '
        'MnuFile
        '
        Me.MnuFile.Index = 0
        Me.MnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuRecent, Me.MenuItem46, Me.MenuItem45, Me.MenuItem43, Me.MenuItem44})
        Me.MnuFile.Text = "Archivos"
        '
        'mnuRecent
        '
        Me.mnuRecent.Index = 0
        Me.mnuRecent.Text = "Recientes"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        Me.MenuItem46.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 2
        Me.MenuItem45.Text = "Impresoras"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 3
        Me.MenuItem43.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 4
        Me.MenuItem44.Text = "Salir"
        '
        'MnuEdit
        '
        Me.MnuEdit.Index = 1
        Me.MnuEdit.Text = "Editar"
        '
        'MnuView
        '
        Me.MnuView.Index = 2
        Me.MnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpcLargeIcon, Me.OpcSmallicon, Me.OpcDetail, Me.OpcList, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41})
        Me.MnuView.Text = "Ver"
        '
        'OpcLargeIcon
        '
        Me.OpcLargeIcon.Index = 0
        Me.OpcLargeIcon.Text = "Iconos Grandes"
        '
        'OpcSmallicon
        '
        Me.OpcSmallicon.Index = 1
        Me.OpcSmallicon.Text = "Iconos Pequeños"
        '
        'OpcDetail
        '
        Me.OpcDetail.Index = 2
        Me.OpcDetail.Text = "Detalle"
        '
        'OpcList
        '
        Me.OpcList.Index = 3
        Me.OpcList.Text = "Lista"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 4
        Me.MenuItem39.Text = "-"
        '
        'MenuItem40
        '
        Me.MenuItem40.Checked = True
        Me.MenuItem40.Index = 5
        Me.MenuItem40.Text = "Toolbar"
        '
        'MenuItem41
        '
        Me.MenuItem41.Checked = True
        Me.MenuItem41.Index = 6
        Me.MenuItem41.Text = "Statusbar"
        '
        'MnuSistem
        '
        Me.MnuSistem.DefaultItem = True
        Me.MnuSistem.Index = 3
        Me.MnuSistem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.opcINV, Me.opcFCT, Me.MenuItem147, Me.opcCXC, Me.opcCXP, Me.OpcCTG, Me.MenuItem215})
        Me.MnuSistem.Text = "Sistemas"
        '
        'opcINV
        '
        Me.opcINV.Index = 0
        Me.opcINV.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem5, Me.MenuItem179, Me.MenuItem4, Me.MenuItem6, Me.MenuItem176, Me.MenuItem170, Me.MenuItem166, Me.MenuItem7, Me.MenuItem8, Me.MenuItem24, Me.MenuItem80, Me.MenuItem81, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItem66, Me.MenuItem78, Me.MenuItem67, Me.MenuItem25, Me.MenuItem75, Me.MenuItem76})
        Me.opcINV.Text = "Inventario"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Productos"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 1
        Me.MenuItem5.Text = "Actalizacion Precios  x Producto"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 2
        Me.MenuItem179.Text = "-"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "Entradas de Almacen"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "Aplicar Entradas"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 5
        Me.MenuItem176.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem177, Me.MenuItem178})
        Me.MenuItem176.Text = "Etiquetas"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 0
        Me.MenuItem177.Text = "Mantenimiento"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 1
        Me.MenuItem178.Text = "Impresion"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 6
        Me.MenuItem170.Text = "-"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 7
        Me.MenuItem166.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem167, Me.MenuItem168})
        Me.MenuItem166.Text = "Compras"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 0
        Me.MenuItem167.Text = "Generar Ordenes de Compras"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 1
        Me.MenuItem168.Text = "Registrar Ordenes de Compras"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 8
        Me.MenuItem7.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 9
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem212, Me.MenuItem213, Me.MenuItem10, Me.MenuItem214, Me.MenuItem88})
        Me.MenuItem8.Text = "Devoluciones"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Registrar Devoluciones"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 1
        Me.MenuItem212.Text = "Reposicion de Devolucion"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 2
        Me.MenuItem213.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.Text = "Aplicar Devoluciones"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 4
        Me.MenuItem214.Text = "-"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 5
        Me.MenuItem88.Text = "Listado de Devoluciones"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 10
        Me.MenuItem24.Text = "-"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 11
        Me.MenuItem80.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem82, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem86})
        Me.MenuItem80.Text = "Conteo Fisico"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 0
        Me.MenuItem82.Text = "Generar Hoja de Conteo"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 1
        Me.MenuItem83.Text = "Registrar Hoja de Conteo"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 2
        Me.MenuItem84.Text = "Aplicar Hoja de Conteo"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 3
        Me.MenuItem85.Text = "-"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 4
        Me.MenuItem86.Text = "Listado de Diferencia"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 12
        Me.MenuItem81.Text = "-"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 13
        Me.MenuItem63.Text = "Salida de Inventario"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 14
        Me.MenuItem64.Text = "Ajuste de Inventario"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 15
        Me.MenuItem65.Text = "Transferencia entre Almacenes"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 16
        Me.MenuItem66.Text = "Aplicar Documentos"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 17
        Me.MenuItem78.Text = "Cierre de Inventario"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 18
        Me.MenuItem67.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 19
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem33, Me.MenuItem35, Me.MenuItem87, Me.MenuItem226, Me.MenuItem164, Me.MenuItem165})
        Me.MenuItem25.Text = "Otros"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "Grupos"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "Subgrupos"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Text = "Marcas"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.Text = "-"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "Unidad de Medidas"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 5
        Me.MenuItem87.Text = "Codigo Barra"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 6
        Me.MenuItem226.Text = "Tipos Ajustes"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 7
        Me.MenuItem164.Text = "Referencias"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 8
        Me.MenuItem165.Text = "Vencimientos"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 20
        Me.MenuItem75.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 21
        Me.MenuItem76.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem79, Me.MenuItem90, Me.MenuItem96, Me.MenuItem149, Me.MenuItem183, Me.MenuItem169, Me.MenuItem181})
        Me.MenuItem76.Text = "Reportes"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 0
        Me.MenuItem79.Text = "Inventario a una Fecha"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 1
        Me.MenuItem90.Text = "Listado de Reorden"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 2
        Me.MenuItem96.Text = "Listado de Precios"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 3
        Me.MenuItem149.Text = "Listado de Existencia "
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 4
        Me.MenuItem183.Text = "Listado de Referencia"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 5
        Me.MenuItem169.Text = "Diario de Compras"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 6
        Me.MenuItem181.Text = "Estadisticas"
        '
        'opcFCT
        '
        Me.opcFCT.Index = 1
        Me.opcFCT.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12, Me.MenuItem50, Me.MenuItem19, Me.MenuItem51, Me.MenuItem144, Me.MenuItem21, Me.MenuItem13, Me.MenuItem20, Me.MenuItem30, Me.MenuItem77, Me.MenuItem118, Me.MenuItem117, Me.MenuItem48})
        Me.opcFCT.Text = "Facturación"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "Facturas"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "Desplacho"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 2
        Me.MenuItem50.Text = "Cotizaciones"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.Text = "Devoluciones"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 4
        Me.MenuItem51.Text = "Servicios"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 5
        Me.MenuItem144.Text = "Autorizaciones"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 6
        Me.MenuItem21.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 7
        Me.MenuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem32, Me.MenuItem161, Me.MenuItem14, Me.MenuItem15, Me.MenuItem162, Me.MenuItem16, Me.MenuItem163})
        Me.MenuItem13.Text = "Caja"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 0
        Me.MenuItem32.Text = "Cajas"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 1
        Me.MenuItem161.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 2
        Me.MenuItem14.Text = "Iniciar"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 3
        Me.MenuItem15.Text = "Cerrar"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 4
        Me.MenuItem162.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Text = "Cobro"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 6
        Me.MenuItem163.Text = "Otros Ingresos"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 8
        Me.MenuItem20.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 9
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem38, Me.MenuItem68})
        Me.MenuItem30.Text = "Otros"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Text = "Motivos de Devoluciones"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 1
        Me.MenuItem38.Text = "Ofertas"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 2
        Me.MenuItem68.Text = "Pago de Comisiones"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 10
        Me.MenuItem77.Text = "-"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 11
        Me.MenuItem118.Text = "Consulta de Documentos"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 12
        Me.MenuItem117.Text = "-"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 13
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem52, Me.MenuItem72, Me.MenuItem53, Me.MenuItem119, Me.MenuItem71, Me.MenuItem69, Me.MenuItem70, Me.MenuItem89, Me.MenuItem97, Me.MenuItem120})
        Me.MenuItem48.Text = "Reportes"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "Diario de Facturas"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 1
        Me.MenuItem52.Text = "Detalle de Facturas"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 2
        Me.MenuItem72.Text = "-"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 3
        Me.MenuItem53.Text = "Ganancia y Perdidas"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 4
        Me.MenuItem119.Text = "Comparativo de Ventas"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 5
        Me.MenuItem71.Text = "-"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 6
        Me.MenuItem69.Text = "Devoluciones"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 7
        Me.MenuItem70.Text = "Detalle de Devoluciones"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 8
        Me.MenuItem89.Text = "Listado de Comisiones"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 9
        Me.MenuItem97.Text = "Listado de Precios"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 10
        Me.MenuItem120.Text = "Listado de Ret. ITBIS"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 2
        Me.MenuItem147.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem171, Me.MenuItem194, Me.MenuItem182, Me.MenuItem195, Me.MenuItem193, Me.MenuItem172})
        Me.MenuItem147.Text = "Punto de Venta"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 0
        Me.MenuItem171.Text = "Facturaracion"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 1
        Me.MenuItem194.Text = "-"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 2
        Me.MenuItem182.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem184, Me.MenuItem186, Me.MenuItem187})
        Me.MenuItem182.Text = "Seguro Medicos"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 0
        Me.MenuItem184.Text = "Compañias"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 1
        Me.MenuItem186.Text = "Asegurado"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 2
        Me.MenuItem187.Text = "Plan de Seguro"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 3
        Me.MenuItem195.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem196, Me.MenuItem197})
        Me.MenuItem195.Text = "Estafetas"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 0
        Me.MenuItem196.Text = "Tipos de Estafeta"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 1
        Me.MenuItem197.Text = "Cobro de Estafeta"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 4
        Me.MenuItem193.Text = "-"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 5
        Me.MenuItem172.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem173, Me.MenuItem174, Me.MenuItem175, Me.MenuItem203, Me.MenuItem204})
        Me.MenuItem172.Text = "Otros"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 0
        Me.MenuItem173.Text = "Ofertas y Combos"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 1
        Me.MenuItem174.Text = "Tarjeta Credito"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 2
        Me.MenuItem175.Text = "Politica Precios"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 3
        Me.MenuItem203.Text = "Notas de Crédito"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 4
        Me.MenuItem204.Text = "Motivos de Devoluciones"
        '
        'opcCXC
        '
        Me.opcCXC.Index = 3
        Me.opcCXC.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem42, Me.MenuItem54, Me.MenuItem55, Me.MenuItem201, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem150, Me.MenuItem229, Me.MenuItem73, Me.MenuItem74, Me.MenuItem59})
        Me.opcCXC.Text = "Cuenta x Cobrar"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Text = "Clientes"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "Tipos de Clientes"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 2
        Me.MenuItem54.Text = "-"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 3
        Me.MenuItem55.Text = "Facturas"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 4
        Me.MenuItem201.Text = "Transferir Facturas"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 5
        Me.MenuItem56.Text = "Posteo de Facturas"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 6
        Me.MenuItem57.Text = "-"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 7
        Me.MenuItem58.Text = "Recibo de Ingresos"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 8
        Me.MenuItem150.Text = "Recibo de Egresos"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 10
        Me.MenuItem73.Text = "Consulta de Movimientos"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 11
        Me.MenuItem74.Text = "-"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 12
        Me.MenuItem59.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem148, Me.MenuItem188, Me.MenuItem225, Me.MenuItem189, Me.MenuItem191, Me.MenuItem190})
        Me.MenuItem59.Text = "Reportes"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 0
        Me.MenuItem60.Text = "Estados de Cuentas"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 1
        Me.MenuItem61.Text = "Saldo por Antiguedad"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 2
        Me.MenuItem62.Text = "Diario de Facturas"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 3
        Me.MenuItem148.Text = "Listado de Clientes"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 4
        Me.MenuItem188.Text = "Listado De Doc. Clientes"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 5
        Me.MenuItem225.Text = "Facturas Pendientes"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 6
        Me.MenuItem189.Text = "Doc. Vencidos De Clientes"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 7
        Me.MenuItem191.Text = "Diario de Recibos"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 8
        Me.MenuItem190.Text = "Pendiente A una Fecha"
        '
        'opcCXP
        '
        Me.opcCXP.Index = 4
        Me.opcCXP.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem207, Me.MenuItem98, Me.MenuItem100, Me.MenuItem99, Me.MenuItem101, Me.MenuItem102, Me.MenuItem47, Me.MenuItem200, Me.MenuItem103, Me.MenuItem106, Me.MenuItem227, Me.MenuItem105})
        Me.opcCXP.Text = "Cuenta x Pagar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 0
        Me.MenuItem23.Text = "Suplidores"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 1
        Me.MenuItem207.Text = "Tipo de Suplidor"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 2
        Me.MenuItem98.Text = "-"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 3
        Me.MenuItem100.Text = "Registrar Docummentos"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 4
        Me.MenuItem99.Text = "Registro Transacciones"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 5
        Me.MenuItem101.Text = "Aplicar Documentos"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 6
        Me.MenuItem102.Text = "-"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 7
        Me.MenuItem47.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem198, Me.MenuItem199})
        Me.MenuItem47.Text = "Proceso de cheques"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 0
        Me.MenuItem198.Text = "Depósito y Solicitud de cheques"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 1
        Me.MenuItem199.Text = "Impresión cheques"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 8
        Me.MenuItem200.Text = "-"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 9
        Me.MenuItem103.Text = "Crear Orden de Compras"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 10
        Me.MenuItem106.Text = "-"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 11
        Me.MenuItem227.Text = "Consulta Movimientos"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 12
        Me.MenuItem105.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem107, Me.MenuItem108, Me.MenuItem109, Me.MenuItem110})
        Me.MenuItem105.Text = "Reportes"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 0
        Me.MenuItem107.Text = "Estado de Cuentas"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 1
        Me.MenuItem108.Text = "Saldo por Antiguedad"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 2
        Me.MenuItem109.Text = "Listado de Compras"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 3
        Me.MenuItem110.Text = "Listado de Ordenes de Compras"
        '
        'OpcCTG
        '
        Me.OpcCTG.Index = 5
        Me.OpcCTG.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem121, Me.MenuItem131, Me.MenuItem136, Me.MenuItem145, Me.MenuItem133, Me.MenuItem132, Me.MenuItem122, Me.MenuItem123, Me.MenuItem129, Me.MenuItem130, Me.MenuItem137})
        Me.OpcCTG.Text = "Contabilidad General"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 0
        Me.MenuItem121.Text = "Catalogo de Cuenta"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 1
        Me.MenuItem131.Text = "Entrada de Diario"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 2
        Me.MenuItem136.Text = "Pase al Mayor General"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 3
        Me.MenuItem145.Text = "Generar Entradas"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 4
        Me.MenuItem133.Text = "-"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 5
        Me.MenuItem132.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem126, Me.MenuItem134, Me.MenuItem135, Me.MenuItem146, Me.MenuItem138, Me.MenuItem157})
        Me.MenuItem132.Text = "Procesos"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 0
        Me.MenuItem126.Text = "Cierre Mensual"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 1
        Me.MenuItem134.Text = "Iniciar Año Fiscal"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 2
        Me.MenuItem135.Text = "Cierrar Año Fiscal"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 3
        Me.MenuItem146.Text = "-"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 4
        Me.MenuItem138.Text = "Reversar Entradas"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 5
        Me.MenuItem157.Text = "Generar Entrada Final"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 6
        Me.MenuItem122.Text = "-"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 7
        Me.MenuItem123.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem124, Me.MenuItem125, Me.MenuItem127, Me.MenuItem128, Me.MenuItem153, Me.MenuItem139, Me.MenuItem140})
        Me.MenuItem123.Text = "Otros"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 0
        Me.MenuItem124.Text = "Tipos de Cuentas"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 1
        Me.MenuItem125.Text = "Tipos de Documentos"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 2
        Me.MenuItem127.Text = "Periodos Contables"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 3
        Me.MenuItem128.Text = "Codificación Contable x Documentos"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 4
        Me.MenuItem153.Text = "Departamentos"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 5
        Me.MenuItem139.Text = "-"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 6
        Me.MenuItem140.Text = "Definir Estados Financieros"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 8
        Me.MenuItem129.Text = "-"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 9
        Me.MenuItem130.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem151, Me.MenuItem160, Me.MenuItem158, Me.MenuItem154, Me.MenuItem159})
        Me.MenuItem130.Text = "Reportes"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 0
        Me.MenuItem151.Text = "Listado de Movimientos (Detallado)"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 1
        Me.MenuItem160.Text = "Listado de Movimintos (Resumido)"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 2
        Me.MenuItem158.Text = "Listado de Movimientos No Balanceados"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 3
        Me.MenuItem154.Text = "Generar Informes"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 4
        Me.MenuItem159.Text = "Listado de Cuentas"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 10
        Me.MenuItem137.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem141, Me.MenuItem142, Me.MenuItem143, Me.MenuItem152})
        Me.MenuItem137.Text = "Estados Financieros"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 0
        Me.MenuItem141.Text = "Mayor General"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 1
        Me.MenuItem142.Text = "Balance de Comprobación"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 2
        Me.MenuItem143.Text = "Ganancias y Perdidas"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 3
        Me.MenuItem152.Text = "..."
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 6
        Me.MenuItem215.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem180, Me.MenuItem216, Me.MenuItem217, Me.MenuItem218, Me.MenuItem219, Me.MenuItem220, Me.MenuItem221, Me.MenuItem222})
        Me.MenuItem215.Text = "Control Bancario"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 0
        Me.MenuItem180.Text = "Cuentas de Banco"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 1
        Me.MenuItem216.Text = "Registro de Documentos"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 2
        Me.MenuItem217.Text = "-"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 3
        Me.MenuItem218.Text = "Conciliar Documentos"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 4
        Me.MenuItem219.Text = "Generar Conciliacion"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 5
        Me.MenuItem220.Text = "-"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 6
        Me.MenuItem221.Text = "Impresion de Cheques"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 7
        Me.MenuItem222.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem223, Me.MenuItem224})
        Me.MenuItem222.Text = "Reportes"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 0
        Me.MenuItem223.Text = "Listado de Documentos"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 1
        Me.MenuItem224.Text = "Movimientos por Cuenta Bancaria"
        '
        'MnuTools
        '
        Me.MnuTools.Index = 4
        Me.MnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1, Me.MenuItem37, Me.MenuItem111, Me.MenuItem112})
        Me.MnuTools.Text = "Herramientas"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem155, Me.MenuItem156, Me.MenuItem206, Me.MenuItem228, Me.MenuItem185, Me.MenuItem192, Me.MenuItem202, Me.MenuItem104, Me.MenuItem205, Me.MenuItem34, Me.MenuItem36, Me.MenuItem31, Me.MenuItem208, Me.MenuItem209, Me.MenuItem210, Me.MenuItem211})
        Me.MenuItem2.Text = "Configuración"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 0
        Me.MenuItem155.Text = "Inventario"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 1
        Me.MenuItem156.Text = "Contabilidad"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 2
        Me.MenuItem206.Text = "-"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 3
        Me.MenuItem228.Text = "Modelo de Pinter"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 4
        Me.MenuItem185.Text = "Modelo de Etiquetas"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 5
        Me.MenuItem192.Text = "Tipos de Documentos"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 6
        Me.MenuItem202.Text = "Tipos de Tarjetas"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 7
        Me.MenuItem104.Text = "-"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 8
        Me.MenuItem205.Text = "Bancos"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 9
        Me.MenuItem34.Text = "Términos de venta"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 10
        Me.MenuItem36.Text = "Almacenes"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 11
        Me.MenuItem31.Text = "Personal"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 12
        Me.MenuItem208.Text = "NCF"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 13
        Me.MenuItem209.Text = "-"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 14
        Me.MenuItem210.Text = "Ciudad"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 15
        Me.MenuItem211.Text = "Sector"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "Opciones"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 2
        Me.MenuItem37.Text = "Monedas"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 3
        Me.MenuItem111.Text = "-"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 4
        Me.MenuItem112.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem113, Me.MenuItem114, Me.MenuItem115, Me.MenuItem116})
        Me.MenuItem112.Text = "Seguridad"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 0
        Me.MenuItem113.Text = "Programas"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 1
        Me.MenuItem114.Text = "Usuarios"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 2
        Me.MenuItem115.Text = "Grupos de Usuarios"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 3
        Me.MenuItem116.Text = "Permisos y Accesos"
        '
        'MnuWindows
        '
        Me.MnuWindows.Index = 5
        Me.MnuWindows.MdiList = True
        Me.MnuWindows.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        Me.MnuWindows.Text = "Windows"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Cascade"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "Tile"
        '
        'MnuHelp
        '
        Me.MnuHelp.Index = 6
        Me.MnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem93, Me.MenuItem94, Me.MenuItem95, Me.MenuItem91, Me.MenuItem92})
        Me.MnuHelp.Text = "Ayuda"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 0
        Me.MenuItem93.Text = "Contents ..."
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 1
        Me.MenuItem94.Text = "Index ..."
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 2
        Me.MenuItem95.Text = "Search ..."
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 3
        Me.MenuItem91.Text = "-"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 4
        Me.MenuItem92.Text = "Sobre SGT 1.0 ..."
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbb_Products, Me.tbb_Locales, Me.tbb_devoluciones, Me.tbb_ajustes, Me.ToolBarButton3, Me.tbb_clientes, Me.tbb_Facturas, Me.tbb_recibos, Me.ToolBarButton5, Me.tbb_facturacion, Me.tbb_estafetas, Me.tbb_ingrso, Me.ToolBarButton2, Me.tbb_Excel})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(806, 72)
        Me.ToolBar1.TabIndex = 5
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'tbb_Products
        '
        Me.tbb_Products.ImageIndex = 0
        Me.tbb_Products.Text = "Productos"
        '
        'tbb_Locales
        '
        Me.tbb_Locales.ImageIndex = 1
        Me.tbb_Locales.Text = "Entradas Almacén"
        '
        'tbb_devoluciones
        '
        Me.tbb_devoluciones.ImageIndex = 5
        Me.tbb_devoluciones.Text = "Devoluciones"
        '
        'tbb_ajustes
        '
        Me.tbb_ajustes.ImageIndex = 2
        Me.tbb_ajustes.Text = "Ajustes"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_clientes
        '
        Me.tbb_clientes.ImageIndex = 8
        Me.tbb_clientes.Text = "Clientes"
        '
        'tbb_Facturas
        '
        Me.tbb_Facturas.ImageIndex = 3
        Me.tbb_Facturas.Text = "Facturas"
        '
        'tbb_recibos
        '
        Me.tbb_recibos.ImageIndex = 9
        Me.tbb_recibos.Text = "Recibos"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_facturacion
        '
        Me.tbb_facturacion.ImageIndex = 10
        Me.tbb_facturacion.Text = "Facturación"
        '
        'tbb_estafetas
        '
        Me.tbb_estafetas.Text = "Estafetas"
        '
        'tbb_ingrso
        '
        Me.tbb_ingrso.ImageIndex = 4
        Me.tbb_ingrso.Text = "Ingresos"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_Excel
        '
        Me.tbb_Excel.ImageIndex = 7
        Me.tbb_Excel.Text = "Excel"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 445)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stbMessage, Me.stbUserName, Me.stbNombre, Me.stbDatabase, Me.stbAlmacen})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(806, 22)
        Me.StatusBar1.TabIndex = 9
        Me.StatusBar1.Text = "StatusBar1"
        '
        'stbMessage
        '
        Me.stbMessage.Icon = CType(resources.GetObject("stbMessage.Icon"), System.Drawing.Icon)
        Me.stbMessage.Text = "Message"
        Me.stbMessage.Width = 400
        '
        'stbUserName
        '
        Me.stbUserName.Text = "UserName"
        '
        'stbNombre
        '
        Me.stbNombre.Text = "Nombre"
        Me.stbNombre.Width = 200
        '
        'stbDatabase
        '
        Me.stbDatabase.Text = "Database:"
        '
        'stbAlmacen
        '
        Me.stbAlmacen.Text = "Almacen"
        Me.stbAlmacen.Width = 300
        '
        'LibXConnector1
        '
        Me.LibXConnector1.AllowDelete = True
        Me.LibXConnector1.AllowEdit = True
        Me.LibXConnector1.AllowNew = True
        Me.LibXConnector1.AllowPrint = True
        Me.LibXConnector1.AllowQuery = True
        Me.LibXConnector1.BOF = False
        Me.LibXConnector1.CanExecuteFind = True
        Me.LibXConnector1.DataMember = Nothing
        Me.LibXConnector1.EOF = False
        Me.LibXConnector1.HandledRowsFill = False
        Me.LibXConnector1.HandledUpdates = False
        Me.LibXConnector1.HasRecords = False
        Me.LibXConnector1.IsEditing = False
        Me.LibXConnector1.IsHeaderOnGrid = False
        Me.LibXConnector1.ModuleName = Nothing
        Me.LibXConnector1.OwnerForm = Me
        Me.LibXConnector1.Parameters = Nothing
        Me.LibXConnector1.RecordCount = 0
        Me.LibXConnector1.ReportMode = False
        Me.LibXConnector1.ReportName = Nothing
        Me.LibXConnector1.ReportObject = Nothing
        Me.LibXConnector1.RequeryData = False
        Me.LibXConnector1.ShowWarningCancel = True
        Me.LibXConnector1.State = LibX.LibxConnectorState.none
        Me.LibXConnector1.UpdatePrimaryKeyColumns = False
        Me.LibXConnector1.UseTransactions = True
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 9
        Me.MenuItem229.Text = "Aplicar Recibos"
        '
        'sgtmain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(806, 467)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "sgtmain"
        Me.Text = "Sistema para Gestión de Farmacias v 2.1.0.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.stbMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stbAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibXConnector1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        RunProgram("INV", "i_ivitem01")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WhName As String
        Dim XSelect As LibX.Data.XSelecStmt
        Dim MenuTitle As String
        '//Dim oAno As SGT.Contabilidad.Entidades.AnoFiscal
        '//Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
        Try
            '// buscar el nombre del almacen
            If LibX.User.WhDefault > 0 Then
                XSelect = New LibX.Data.XSelecStmt("ivwhsem", "select whse_name from ivwhsem")
                XSelect.Parameters.Add("whse_code", LibX.User.WhDefault)
                WhName = XSelect.GetScalar()

                XSelect.Dispose()
            End If

            LibX.App.MainMdi = Me

            If LibX.Data.Manager.ExecuteLogin() = False Then
                Application.Exit()
            End If

            If LibX.User.UserName Is Nothing Then
                LibX.User.UserName = ConfigurationSettings.AppSettings.Get("LibxAllowUser")
            End If

            ProgramRunning = New Hashtable
            ProgramAccess = New SGT.Administracion.Entidades.Program
            ProgramParam = New SGT.Administracion.Entidades.Program.PermissionArgs
            '//oAno = New SGT.Contabilidad.Entidades.AnoFiscal

            'oPeriodo = oAno.BuscarPeriodoActual

            stbMessage.Text = "Bienvenido " & LibX.User.NombreVendedor
            ''stbNombre.Text = LibX.User.NombreVendedor
            stbNombre.Text = "Terminal : " & System.Environment.MachineName
            stbUserName.Text = LibX.User.UserName
            'stbUserName.Text = "Periodo:" & oPeriodo.year.ToString & "-" & oPeriodo.Number.ToString
            stbDatabase.Text = LibX.Data.Manager.Connection.Database
            stbAlmacen.Text = WhName

            MenuTitle = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxMenuTitle")

            If Not MenuTitle Is Nothing Then
                Me.Text = MenuTitle
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        RunProgram("INV", "i_iventr02")
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_ivdevm01")
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        RunProgram("INV", "p_iventr01")
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        RunProgram("INV", "i_ivdevm01")
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        RunProgram("INV", "p_ivdevm01")
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        RunProgram("FCT", "i_ftfact01")
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        RunProgram("FCT", "i_ftvend01")
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        RunProgram("PTV", "i_ptvrecib01")
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        RunProgram("FCT", "p_ftfact01")
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        RunProgram("CAJ", "i_cjcaja01")
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        RunProgram("CAJ", "i_cjinit01")
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        RunProgram("CAJ", "p_cjinit01")
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        RunProgram("INV", "i_ivgroup01")
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        RunProgram("INV", "i_sgrpm01")
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        RunProgram("INV", "i_ivbrand01")
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        RunProgram("INV", "i_ivunitm01")
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        RunProgram("INV", "i_ivwhsem01")
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        RunProgram("CAJ", "i_cjmonedam01")
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        RunProgram("CXP", "i_cpprovm01")
    End Sub

    Private Sub RunProgram(ByVal mdlname As String, ByVal ProgName As String)

        Try
            Cursor = Cursors.WaitCursor

            '''ProgramParam.Type = SGT.Administracion.Entidades.Program.PermissionTypeEnum.AccessProgram
            '''ProgramParam.ProgramName = ProgName
            '''ProgramParam.UserID = LibX.User.UserID

            '''If ProgramAccess.HasPermission(ProgramParam) = False Then
            '''    Throw New ApplicationException("No tienes permisos para ejecutar este programa")
            '''End If

            If ProgName <> "i_ftfact01" Then
                If ProgramRunning.Contains(ProgName) = True Then
                    For Each OForm As Form In Me.MdiChildren
                        If OForm.Name = ProgName Then
                            OForm.Activate()
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        End If
                    Next
                End If

                ProgramRunning.Add(ProgName, mdlname)
                mnuRecent.MenuItems.Add(ProgName)
            End If

            LibX.LibXRunner.Run(ProgName, mdlname)

            For idx As Integer = 0 To Me.MdiChildren.Length - 1
                If CType(Me.MdiChildren(idx), Form).Name = ProgName Then
                    AddHandler CType(Me.MdiChildren(idx), Form).Closing, AddressOf FormChild_Closing
                End If
            Next
            Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
            If ProgName.Trim <> "" Then
                ProgramRunning.Remove(ProgName)
            End If

            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        RunProgram("INV", "i_ivadjus01")
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "p_ftdevm01.exe")
    End Sub

    Private Sub FormChild_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            RemoveHandler CType(sender, Form).Closing, AddressOf FormChild_Closing
            ProgramRunning.Remove(sender.name)
        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        MenuItem40.Checked = Not MenuItem40.Checked
        ToolBar1.Visible = MenuItem40.Checked

    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        MenuItem41.Checked = Not MenuItem41.Checked
        StatusBar1.Visible = MenuItem41.Checked
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        RunProgram("CXC", "i_custrm01")
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        RunProgram("CXC", "i_ccterm01")
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        RunProgram("CXC", "i_cccsttpm01")
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Me.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        PrintDialog1.ShowDialog(Me)
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            If e.Button Is tbb_Products Then
                MenuItem3_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_Locales Then
                MenuItem4_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_devoluciones Then
                MenuItem5_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_ajustes Then
                MenuItem19_Click(Nothing, Nothing)
            End If

            If e.Button Is tbb_clientes Then
                MenuItem12_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_recibos Then
                MenuItem11_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_Facturas Then
                MenuItem51_Click(Nothing, Nothing)
            End If


            If e.Button Is tbb_ingrso Then
                MenuItem16_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_facturacion Then
                MenuItem50_Click(Nothing, Nothing)
            End If
            If e.Button Is tbb_estafetas Then
                MenuItem52_Click(Nothing, Nothing)
            End If

            If e.Button Is tbb_Excel Then
                Dim Proceso As New System.Diagnostics.Process
                Proceso.Start(AppSettings.Get("apppath") & "Others\SheetPrice.xls")
            End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try

    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        RunProgram("FCT", "r_ftfact10")
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        RunProgram("FCT", "i_ftfact11")
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        RunProgram("FCT", "i_ftfact02")
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        RunProgram("PTV", "i_sfcobrm01")
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        RunProgram("FCT", "r_ftfact00")
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        RunProgram("cxc", "i_ccinvce01")
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        RunProgram("cxc", "i_ccpaym02")
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        RunProgram("INV", "i_ivsalid01")
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        RunProgram("INV", "i_ivadjus01")
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        RunProgram("INV", "i_ivtransf01")
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
        RunProgram("INV", "p_ivdocs01")

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        RunProgram("FCT", "i_ftdevtp01")

    End Sub

    Private Sub MenuItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        RunProgram("FCT", "i_ftofert01")

    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        RunProgram("FCT", "p_ftcomm01")

    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        RunProgram("CXC", "c_ccdocs03")

    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        RunProgram("CXC", "r_ccpaym03")

    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        RunProgram("CXC", "r_ccpaym01")

    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        RunProgram("CXC", "r_ccpaym02")
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        RunProgram("CXC", "p_ccdocs01")
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        RunProgram("INV", "p_ivcierr01")
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        RunProgram("INV", "r_ivonhnd01")
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "p_ivcount02")
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        RunProgram("INV", "g_ivcount03")
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        RunProgram("INV", "i_ivcount01")
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        RunProgram("INV", "p_ivcount01")
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        RunProgram("FCT", "r_ftcomm02")
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        RunProgram("INV", "r_ivrorder")
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        RunProgram("FCT", "r_ftfact05")
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        RunProgram("FCT", "r_ftfact05")

    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_iventr02")

    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        RunProgram("CXP", "i_cpinvce01")

    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        RunProgram("CXP", "p_cpdocs01")
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        RunProgram("ADM", "i_stprogrm01")
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        RunProgram("ADM", "i_users")

    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        RunProgram("ADM", "i_groups")

    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem116.Click
        RunProgram("ADM", "i_access")

    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        RunProgram("FCT", "c_ftdocs01")
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        RunProgram("FCT", "r_ftfact09")
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        RunProgram("FCT", "r_ftfact07")
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        RunProgram("CTG", "i_cgacctm")
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        RunProgram("CTG", "i_cgacctp")
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        RunProgram("CTG", "i_cgdoctp")
    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgperdr")
    End Sub

    Private Sub MenuItem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem127.Click
        RunProgram("CTG", "i_cgperdd")
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        RunProgram("CTG", "i_cgjourm")
    End Sub

    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        RunProgram("CTG", "i_cgcodifm")
    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        RunProgram("CTG", "p_postpr01")
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        RunProgram("CTG", "p_acctpr01")
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        RunProgram("FCT", "p_ftfact02")
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_iventr03")
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        RunProgram("CXC", "r_ccpaym04")
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        RunProgram("INV", "r_ivonhnd02")
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        RunProgram("INV", "r_ivcount02")
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        RunProgram("CXC", "i_ccpaym01")
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        RunProgram("CTG", "p_pstccpr01")
    End Sub

    Private Sub MenuItem126_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        RunProgram("CTG", "p_acctpr02")
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        RunProgram("CTG", "i_cgdepto")
    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        RunProgram("CTG", "r_tranr01")
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        RunProgram("CTG", "r_acctrp02")
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        RunProgram("CTG", "i_cgestfin")
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        RunProgram("CTG", "r_acctrp01")
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXP", "i_cppaym01")
    End Sub

    Private Sub MenuItem99_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        RunProgram("CXP", "i_cppaym01")
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        RunProgram("INV", "i_ivsetup")
    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        RunProgram("CTG", "i_cgconf01")
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        RunProgram("CTG", "p_acctpr03")
    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        RunProgram("CTG", "p_acctpr04")

    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        RunProgram("CTG", "r_tranr02")
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        RunProgram("CTG", "r_acctrp03")
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem160.Click
        RunProgram("CTG", "r_tranr04")
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        RunProgram("CXP", "r_cppaym02")
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        RunProgram("CXP", "r_cppaym01")
    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem163.Click
        RunProgram("CAJ", "i_cjpaym01")
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        RunProgram("CXP", "i_cpordm01")
    End Sub

    Private Sub MenuItem87_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        RunProgram("INV", "i_ivcobm01")
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        RunProgram("INV", "i_ivrefm01")
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        RunProgram("CXP", "g_cpordm01")
    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click
        RunProgram("CXP", "i_cpordm01")
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        RunProgram("INV", "i_ivpreciom01")
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem171.Click
        RunProgram("PTV", "i_ptvfact01")
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        RunProgram("PTV", "i_ptvcomb01")
    End Sub

    Private Sub MenuItem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        RunProgram("PTV", "i_ptvtarjm01")
    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        RunProgram("PTV", "i_ptvpolm01")
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        RunProgram("INV", "i_ivcmtm01")
    End Sub

    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click
        RunProgram("INV", "r_ivetiqm01")
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        RunProgram("CXP", "i_cpcheqm")
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        RunProgram("INV", "r_ivdevol01")
    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click
        RunProgram("INV", "i_ivetiqm01")
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        RunProgram("INV", "r_iventr01")
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        RunProgram("INV", "r_iventr03")
    End Sub

    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem183.Click
        RunProgram("INV", "r_ivitemref")
    End Sub

    Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
        RunProgram("INV", "i_ivetiqmod")
    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem184.Click
        RunProgram("PTV", "i_ptvciasgm01")
    End Sub

    Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click
        RunProgram("PTV", "i_ptvasegm01")
    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
        RunProgram("PTV", "i_sgplanm01")
    End Sub

    Private Sub MenuItem188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem188.Click
        RunProgram("CXC", "r_ccpaym05")
    End Sub

    Private Sub MenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem189.Click
        RunProgram("CXC", "r_ccpaym06")
    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
        RunProgram("CXC", "r_ccpaym08")
    End Sub

    Private Sub MenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem190.Click
        RunProgram("CXC", "r_ccpaym07")
    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click
        RunProgram("INV", "i_ivtype01")
    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click
        RunProgram("PTV", "i_sfmaem01")
    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click
        RunProgram("PTV", "i_sfcobrm01")
    End Sub

    Private Sub MenuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem198.Click
        RunProgram("CXP", "i_cpdepom01")
    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        RunProgram("CXC", "p_cctrfdoc01")
    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click
        RunProgram("PTV", "i_pvtarjm01")
    End Sub

    Private Sub sgtmain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Me.MdiChildren.Length > 0 Then
            If MessageBox.Show("Tiene " & Me.MdiChildren.Length.ToString.Trim & _
            " Pantalla(s) Abiertas, si sale sin grabar de de cualquiera de estas pantalla " & vbCrLf & _
            " es posible que pierda lo que esta haciendo, se recomenda que cierre las pantallas " & vbCrLf & _
            " antes de cerrar el Menu" & vbCrLf & vbCrLf & _
            " Seguro Desea Cerrar el Sistema?", "Cerrar con pantallas abiertas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                e.Cancel = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        RunProgram("CAJ", "i_cjncrm01")
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        RunProgram("FCT", "i_ftdevtp01")
    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        RunProgram("ADM", "i_adbanco01")
    End Sub

    Private Sub MenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem207.Click
        RunProgram("CXP", "i_cptypem01")
    End Sub

    Private Sub MenuItem208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem208.Click
        RunProgram("FCT", "i_ftncfm01")
    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        RunProgram("CXC", "i_citym")
    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click
        RunProgram("CXC", "i_sectorm")
    End Sub

    Private Sub MenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem212.Click
        RunProgram("INV", "i_ivdevm02")
    End Sub

    Private Sub MenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem216.Click
        RunProgram("CTB", "i_cbdocs01")
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click
        RunProgram("CTB", "p_cbdocs01")
    End Sub

    Private Sub MenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem219.Click
        RunProgram("CTB", "p_cbdocs02")
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click
        RunProgram("CTB", "p_cbdocs03")
    End Sub

    Private Sub MenuItem225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem225.Click
        RunProgram("CXC", "r_ccpaym09")
    End Sub

    Private Sub MenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem226.Click
        RunProgram("INV", "i_ivtpeadj01")
    End Sub

    Private Sub MenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem227.Click
        RunProgram("CXP", "c_cpdocs03")
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click
        RunProgram("ADM", "i_sgfprinter")
    End Sub

    Private Sub MenuItem229_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem229.Click
        RunProgram("CXC", "p_ccpaym01")
    End Sub
End Class
