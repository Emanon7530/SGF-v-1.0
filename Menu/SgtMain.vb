Imports System.Configuration
Imports System.Configuration.ConfigurationSettings

Public Class sgtmain
    Inherits System.Windows.Forms.Form
    Dim ProgramRunning As Hashtable
    Dim ProgramAccess As SGT.Administracion.Entidades.Program
    Dim ProgramParam As SGT.Administracion.Entidades.Program.PermissionArgs
    Dim mMachine As SGT.Administracion.Entidades.Program.Autentication
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
    Friend WithEvents opcCXC As System.Windows.Forms.MenuItem
    Friend WithEvents opcCXP As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
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
    Friend WithEvents stbDatabase As System.Windows.Forms.StatusBarPanel
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
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents stbAlmacen As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents tbb_devoluciones As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_ajustes As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_clientes As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_suplidores As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_cotizaciones As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
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
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents tbb_menu As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbb_dropdown As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents cmenuEntrada As System.Windows.Forms.MenuItem
    Friend WithEvents cmenuDevol As System.Windows.Forms.MenuItem
    Friend WithEvents cmenuAjustes As System.Windows.Forms.MenuItem
    Friend WithEvents cmenuCxp As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents cmenuRecCXC As System.Windows.Forms.MenuItem
    Friend WithEvents cmenuDocCXC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents ctMenuFav As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFavoritos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(sgtmain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFavoritos = New System.Windows.Forms.MenuItem
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
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem217 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
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
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem164 = New System.Windows.Forms.MenuItem
        Me.MenuItem165 = New System.Windows.Forms.MenuItem
        Me.MenuItem129 = New System.Windows.Forms.MenuItem
        Me.MenuItem219 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem199 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem149 = New System.Windows.Forms.MenuItem
        Me.MenuItem183 = New System.Windows.Forms.MenuItem
        Me.MenuItem169 = New System.Windows.Forms.MenuItem
        Me.MenuItem181 = New System.Windows.Forms.MenuItem
        Me.MenuItem212 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem218 = New System.Windows.Forms.MenuItem
        Me.MenuItem138 = New System.Windows.Forms.MenuItem
        Me.MenuItem229 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.opcCXC = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem201 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem226 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem148 = New System.Windows.Forms.MenuItem
        Me.MenuItem188 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem189 = New System.Windows.Forms.MenuItem
        Me.MenuItem191 = New System.Windows.Forms.MenuItem
        Me.MenuItem190 = New System.Windows.Forms.MenuItem
        Me.MenuItem221 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.opcCXP = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem207 = New System.Windows.Forms.MenuItem
        Me.MenuItem180 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.MenuItem200 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem194 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem147 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem231 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem182 = New System.Windows.Forms.MenuItem
        Me.MenuItem184 = New System.Windows.Forms.MenuItem
        Me.MenuItem186 = New System.Windows.Forms.MenuItem
        Me.MenuItem187 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem228 = New System.Windows.Forms.MenuItem
        Me.MenuItem227 = New System.Windows.Forms.MenuItem
        Me.MenuItem195 = New System.Windows.Forms.MenuItem
        Me.MenuItem196 = New System.Windows.Forms.MenuItem
        Me.MenuItem197 = New System.Windows.Forms.MenuItem
        Me.MenuItem139 = New System.Windows.Forms.MenuItem
        Me.MenuItem193 = New System.Windows.Forms.MenuItem
        Me.MenuItem172 = New System.Windows.Forms.MenuItem
        Me.MenuItem173 = New System.Windows.Forms.MenuItem
        Me.MenuItem175 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem204 = New System.Windows.Forms.MenuItem
        Me.MenuItem216 = New System.Windows.Forms.MenuItem
        Me.MenuItem214 = New System.Windows.Forms.MenuItem
        Me.MenuItem215 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem174 = New System.Windows.Forms.MenuItem
        Me.MenuItem198 = New System.Windows.Forms.MenuItem
        Me.MenuItem230 = New System.Windows.Forms.MenuItem
        Me.MenuItem158 = New System.Windows.Forms.MenuItem
        Me.MenuItem116 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem119 = New System.Windows.Forms.MenuItem
        Me.MenuItem122 = New System.Windows.Forms.MenuItem
        Me.MenuItem120 = New System.Windows.Forms.MenuItem
        Me.MenuItem160 = New System.Windows.Forms.MenuItem
        Me.MenuItem121 = New System.Windows.Forms.MenuItem
        Me.MenuItem126 = New System.Windows.Forms.MenuItem
        Me.MenuItem127 = New System.Windows.Forms.MenuItem
        Me.MenuItem128 = New System.Windows.Forms.MenuItem
        Me.MenuItem130 = New System.Windows.Forms.MenuItem
        Me.MenuItem161 = New System.Windows.Forms.MenuItem
        Me.MenuItem123 = New System.Windows.Forms.MenuItem
        Me.MenuItem131 = New System.Windows.Forms.MenuItem
        Me.MenuItem132 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem136 = New System.Windows.Forms.MenuItem
        Me.MenuItem220 = New System.Windows.Forms.MenuItem
        Me.MenuItem224 = New System.Windows.Forms.MenuItem
        Me.MenuItem225 = New System.Windows.Forms.MenuItem
        Me.MenuItem162 = New System.Windows.Forms.MenuItem
        Me.MenuItem124 = New System.Windows.Forms.MenuItem
        Me.MenuItem137 = New System.Windows.Forms.MenuItem
        Me.MenuItem223 = New System.Windows.Forms.MenuItem
        Me.MenuItem140 = New System.Windows.Forms.MenuItem
        Me.MenuItem141 = New System.Windows.Forms.MenuItem
        Me.MenuItem222 = New System.Windows.Forms.MenuItem
        Me.MenuItem125 = New System.Windows.Forms.MenuItem
        Me.MenuItem142 = New System.Windows.Forms.MenuItem
        Me.MenuItem143 = New System.Windows.Forms.MenuItem
        Me.MenuItem144 = New System.Windows.Forms.MenuItem
        Me.MenuItem159 = New System.Windows.Forms.MenuItem
        Me.MenuItem117 = New System.Windows.Forms.MenuItem
        Me.MenuItem145 = New System.Windows.Forms.MenuItem
        Me.MenuItem146 = New System.Windows.Forms.MenuItem
        Me.MenuItem171 = New System.Windows.Forms.MenuItem
        Me.MenuItem150 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.MenuItem163 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.MenuItem157 = New System.Windows.Forms.MenuItem
        Me.MnuTools = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.MenuItem206 = New System.Windows.Forms.MenuItem
        Me.MenuItem203 = New System.Windows.Forms.MenuItem
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
        Me.MenuItem234 = New System.Windows.Forms.MenuItem
        Me.MenuItem235 = New System.Windows.Forms.MenuItem
        Me.MenuItem236 = New System.Windows.Forms.MenuItem
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem213 = New System.Windows.Forms.MenuItem
        Me.MenuItem237 = New System.Windows.Forms.MenuItem
        Me.MenuItem243 = New System.Windows.Forms.MenuItem
        Me.MenuItem240 = New System.Windows.Forms.MenuItem
        Me.MenuItem239 = New System.Windows.Forms.MenuItem
        Me.MenuItem244 = New System.Windows.Forms.MenuItem
        Me.MenuItem241 = New System.Windows.Forms.MenuItem
        Me.MenuItem246 = New System.Windows.Forms.MenuItem
        Me.MenuItem242 = New System.Windows.Forms.MenuItem
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
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.tbb_Locales = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton
        Me.tbb_devoluciones = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.tbb_ajustes = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.tbb_clientes = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.tbb_suplidores = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.tbb_cotizaciones = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton
        Me.tbb_menu = New System.Windows.Forms.ToolBarButton
        Me.tbb_dropdown = New System.Windows.Forms.ToolBarButton
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.cmenuEntrada = New System.Windows.Forms.MenuItem
        Me.cmenuDevol = New System.Windows.Forms.MenuItem
        Me.cmenuAjustes = New System.Windows.Forms.MenuItem
        Me.MenuItem232 = New System.Windows.Forms.MenuItem
        Me.cmenuCxp = New System.Windows.Forms.MenuItem
        Me.MenuItem233 = New System.Windows.Forms.MenuItem
        Me.cmenuDocCXC = New System.Windows.Forms.MenuItem
        Me.cmenuRecCXC = New System.Windows.Forms.MenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.stbMessage = New System.Windows.Forms.StatusBarPanel
        Me.stbUserName = New System.Windows.Forms.StatusBarPanel
        Me.stbNombre = New System.Windows.Forms.StatusBarPanel
        Me.stbDatabase = New System.Windows.Forms.StatusBarPanel
        Me.stbAlmacen = New System.Windows.Forms.StatusBarPanel
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.LibXConnector1 = New LibX.LibXConnector(Me.components)
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ctMenuFav = New System.Windows.Forms.ContextMenu
        Me.MenuItem245 = New System.Windows.Forms.MenuItem
        Me.MenuItem238 = New System.Windows.Forms.MenuItem
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
        Me.MnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFavoritos, Me.mnuRecent, Me.MenuItem46, Me.MenuItem45, Me.MenuItem43, Me.MenuItem44})
        Me.MnuFile.Text = "Archivos"
        '
        'mnuFavoritos
        '
        Me.mnuFavoritos.Index = 0
        Me.mnuFavoritos.Text = "Favoritos"
        '
        'mnuRecent
        '
        Me.mnuRecent.Index = 1
        Me.mnuRecent.Text = "Recientes"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 3
        Me.MenuItem45.Text = "Impresoras"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 4
        Me.MenuItem43.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 5
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
        Me.MnuSistem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.opcINV, Me.MenuItem32, Me.opcCXC, Me.MenuItem48, Me.opcCXP, Me.MenuItem49, Me.MenuItem147, Me.MenuItem158, Me.MenuItem116, Me.MenuItem159, Me.MenuItem117})
        Me.MnuSistem.Text = "Sistemas"
        '
        'opcINV
        '
        Me.opcINV.Index = 0
        Me.opcINV.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem5, Me.MenuItem179, Me.MenuItem4, Me.MenuItem6, Me.MenuItem176, Me.MenuItem170, Me.MenuItem166, Me.MenuItem7, Me.MenuItem8, Me.MenuItem24, Me.MenuItem80, Me.MenuItem81, Me.MenuItem63, Me.MenuItem64, Me.MenuItem65, Me.MenuItem66, Me.MenuItem78, Me.MenuItem67, Me.MenuItem25, Me.MenuItem75, Me.MenuItem76, Me.MenuItem229})
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
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10, Me.MenuItem16, Me.MenuItem88, Me.MenuItem12})
        Me.MenuItem8.Text = "Devoluciones"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Registrar Devoluciones"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "Aplicar Devoluciones"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 2
        Me.MenuItem16.Text = "Reposicion de Mercancia"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 3
        Me.MenuItem88.Text = "Listado de Devoluciones"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 4
        Me.MenuItem12.Text = ""
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 10
        Me.MenuItem24.Text = "-"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 11
        Me.MenuItem80.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem82, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem86, Me.MenuItem217, Me.MenuItem71})
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
        'MenuItem217
        '
        Me.MenuItem217.Index = 5
        Me.MenuItem217.Text = "Productos no Inventariados"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 6
        Me.MenuItem71.Text = "Conteo Automatico"
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
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.MenuItem33, Me.MenuItem35, Me.MenuItem87, Me.MenuItem53, Me.MenuItem164, Me.MenuItem165})
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
        'MenuItem53
        '
        Me.MenuItem53.Index = 6
        Me.MenuItem53.Text = "Tipos Ajustes"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 7
        Me.MenuItem164.Text = "Referencias"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 8
        Me.MenuItem165.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem129, Me.MenuItem219})
        Me.MenuItem165.Text = "Vencimientos"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 0
        Me.MenuItem129.Text = "Agregar Vencimientos"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 1
        Me.MenuItem219.Text = "Editar Vencimientos"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 20
        Me.MenuItem75.Text = "-"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 21
        Me.MenuItem76.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem79, Me.MenuItem90, Me.MenuItem199, Me.MenuItem96, Me.MenuItem149, Me.MenuItem183, Me.MenuItem169, Me.MenuItem181, Me.MenuItem212, Me.MenuItem72, Me.MenuItem218, Me.MenuItem138})
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
        'MenuItem199
        '
        Me.MenuItem199.Index = 2
        Me.MenuItem199.Text = "Listado de Productos"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 3
        Me.MenuItem96.Text = "Listado de Precios"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 4
        Me.MenuItem149.Text = "Listado de Existencia "
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 5
        Me.MenuItem183.Text = "Listado de Referencia"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 6
        Me.MenuItem169.Text = "Diario de Compras"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 7
        Me.MenuItem181.Text = "Estadisticas"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 8
        Me.MenuItem212.Text = "Listado de Vencimientos"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 9
        Me.MenuItem72.Text = "Producto no se Venden"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 10
        Me.MenuItem218.Text = "Productos Controlados"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 11
        Me.MenuItem138.Text = "Listado Documentos "
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 22
        Me.MenuItem229.Text = "Consulta Movimientos Productos"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "-"
        '
        'opcCXC
        '
        Me.opcCXC.Index = 2
        Me.opcCXC.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem42, Me.MenuItem54, Me.MenuItem55, Me.MenuItem201, Me.MenuItem56, Me.MenuItem57, Me.MenuItem58, Me.MenuItem226, Me.MenuItem73, Me.MenuItem74, Me.MenuItem59})
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
        Me.MenuItem56.Text = "Aplicar Documentos"
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
        'MenuItem226
        '
        Me.MenuItem226.Index = 8
        Me.MenuItem226.Text = "Aplicar Recibos"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 9
        Me.MenuItem73.Text = "Consulta de Movimientos"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 10
        Me.MenuItem74.Text = "-"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 11
        Me.MenuItem59.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem60, Me.MenuItem61, Me.MenuItem62, Me.MenuItem148, Me.MenuItem188, Me.MenuItem52, Me.MenuItem189, Me.MenuItem191, Me.MenuItem190, Me.MenuItem221})
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
        'MenuItem52
        '
        Me.MenuItem52.Index = 5
        Me.MenuItem52.Text = "Facturas Pendientes"
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
        'MenuItem221
        '
        Me.MenuItem221.Index = 9
        Me.MenuItem221.Text = "Mayor Auxiliar"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 3
        Me.MenuItem48.Text = "-"
        '
        'opcCXP
        '
        Me.opcCXP.Index = 4
        Me.opcCXP.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem23, Me.MenuItem207, Me.MenuItem180, Me.MenuItem98, Me.MenuItem100, Me.MenuItem99, Me.MenuItem101, Me.MenuItem102, Me.MenuItem200, Me.MenuItem103, Me.MenuItem106, Me.MenuItem194, Me.MenuItem105})
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
        'MenuItem180
        '
        Me.MenuItem180.Index = 2
        Me.MenuItem180.Text = "Cuentas de Banco"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 3
        Me.MenuItem98.Text = "-"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 4
        Me.MenuItem100.Text = "Registrar Docummentos"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 5
        Me.MenuItem99.Text = "Registro Transacciones"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 6
        Me.MenuItem101.Text = "Aplicar Documentos"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 7
        Me.MenuItem102.Text = "Transferencia de Facturas"
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
        'MenuItem194
        '
        Me.MenuItem194.Index = 11
        Me.MenuItem194.Text = "Consulta Movimientos"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 12
        Me.MenuItem105.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem107, Me.MenuItem108, Me.MenuItem109, Me.MenuItem110, Me.MenuItem89, Me.MenuItem115, Me.MenuItem112, Me.MenuItem113, Me.MenuItem114})
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
        Me.MenuItem109.Text = "Dirario de Facturas"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 3
        Me.MenuItem110.Text = "Listado de Suplidores"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 4
        Me.MenuItem89.Text = "Listado de Documentos"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 5
        Me.MenuItem115.Text = "Facturas Pendientes"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 6
        Me.MenuItem112.Text = "Facturas a Vencimiento"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 7
        Me.MenuItem113.Text = "Diario de Cheques"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 8
        Me.MenuItem114.Text = "Pendiente a una Fecha"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 5
        Me.MenuItem49.Text = "-"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 6
        Me.MenuItem147.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem97, Me.MenuItem13, Me.MenuItem19, Me.MenuItem70, Me.MenuItem182, Me.MenuItem195, Me.MenuItem193, Me.MenuItem172, Me.MenuItem216, Me.MenuItem214, Me.MenuItem230})
        Me.MenuItem147.Text = "Punto de Venta"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 0
        Me.MenuItem97.Text = "Cotizacion"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 1
        Me.MenuItem13.Text = "Factura Servicios"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 2
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem51, Me.MenuItem38, Me.MenuItem231, Me.MenuItem47})
        Me.MenuItem19.Text = "Proceso de Caja"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 0
        Me.MenuItem51.Text = "Cajas"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 1
        Me.MenuItem38.Text = "Iniciar"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 2
        Me.MenuItem231.Text = "Cierre"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Text = "Reporte de cierre"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 3
        Me.MenuItem70.Text = "-"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 4
        Me.MenuItem182.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem184, Me.MenuItem186, Me.MenuItem187, Me.MenuItem77, Me.MenuItem228, Me.MenuItem227})
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
        'MenuItem77
        '
        Me.MenuItem77.Index = 3
        Me.MenuItem77.Text = "Reclamacion de Seguro"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 4
        Me.MenuItem228.Text = "Reporte de Asegurados"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 5
        Me.MenuItem227.Text = "Clinicas"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 5
        Me.MenuItem195.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem196, Me.MenuItem197, Me.MenuItem139})
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
        'MenuItem139
        '
        Me.MenuItem139.Index = 2
        Me.MenuItem139.Text = "Reporte estafetas"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 6
        Me.MenuItem193.Text = "-"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 7
        Me.MenuItem172.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem173, Me.MenuItem175, Me.MenuItem11, Me.MenuItem204})
        Me.MenuItem172.Text = "Otros"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 0
        Me.MenuItem173.Text = "Ofertas y Combos"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 1
        Me.MenuItem175.Text = "Politica Precios"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.Text = "Pago de Comisiones"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 3
        Me.MenuItem204.Text = "Motivos de Devoluciones"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 8
        Me.MenuItem216.Text = "-"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 9
        Me.MenuItem214.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem215, Me.MenuItem14, Me.MenuItem15, Me.MenuItem20, Me.MenuItem21, Me.MenuItem29, Me.MenuItem30, Me.MenuItem50, Me.MenuItem68, Me.MenuItem69, Me.MenuItem174, Me.MenuItem198})
        Me.MenuItem214.Text = "Reportes"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 0
        Me.MenuItem215.Text = "Resume de Ventas"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Diario de Facturas"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Ganancias y Perdida detallado"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "Ganancias y Perdida por Mes"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 4
        Me.MenuItem21.Text = "Comparativo de Ventas"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 5
        Me.MenuItem29.Text = "Listado de Comisiones"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 6
        Me.MenuItem30.Text = "Listado de Ret. ITBIS Ncf"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 7
        Me.MenuItem50.Text = "Ranking de Ventas"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 8
        Me.MenuItem68.Text = "Reporte de domicilios"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 9
        Me.MenuItem69.Text = "Diario de Ventas"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 10
        Me.MenuItem174.Text = "Notas de Credito"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 11
        Me.MenuItem198.Text = "Recibos de Egreso"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 10
        Me.MenuItem230.Text = "Consulta Documentos "
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 7
        Me.MenuItem158.Text = "-"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 8
        Me.MenuItem116.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem118, Me.MenuItem119, Me.MenuItem122, Me.MenuItem120, Me.MenuItem160, Me.MenuItem121, Me.MenuItem161, Me.MenuItem123, Me.MenuItem162, Me.MenuItem124, Me.MenuItem125})
        Me.MenuItem116.Text = "Contabilidad"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 0
        Me.MenuItem118.Text = "Catalogo de Cuenta"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 1
        Me.MenuItem119.Text = "Entrada de Diario"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 2
        Me.MenuItem122.Text = "Generar Entradas"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 3
        Me.MenuItem120.Text = "Pase al Mayor"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 4
        Me.MenuItem160.Text = "-"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 5
        Me.MenuItem121.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem126, Me.MenuItem127, Me.MenuItem128, Me.MenuItem130})
        Me.MenuItem121.Text = "Proceso"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 0
        Me.MenuItem126.Text = "Cierre Mensual"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 1
        Me.MenuItem127.Text = "Iniciar año Fiscal"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 2
        Me.MenuItem128.Text = "Cerrar año Fiscal"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 3
        Me.MenuItem130.Text = "Generar Entrada Final"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 6
        Me.MenuItem161.Text = "-"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 7
        Me.MenuItem123.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem131, Me.MenuItem132, Me.MenuItem133, Me.MenuItem134, Me.MenuItem135, Me.MenuItem136, Me.MenuItem220, Me.MenuItem224, Me.MenuItem225})
        Me.MenuItem123.Text = "Otros"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 0
        Me.MenuItem131.Text = "Tipos de Cuentas"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 1
        Me.MenuItem132.Text = "Tipos de Documentos"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 2
        Me.MenuItem133.Text = "Periodos Contables"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 3
        Me.MenuItem134.Text = "Codificacion Contable"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 4
        Me.MenuItem135.Text = "Departamento"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 5
        Me.MenuItem136.Text = "Definir Estados Financieros"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 6
        Me.MenuItem220.Text = "Configuracion Balance General"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 7
        Me.MenuItem224.Text = "Configuracion de Estado Resultado"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 8
        Me.MenuItem225.Text = "Sucursales"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 8
        Me.MenuItem162.Text = "-"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 9
        Me.MenuItem124.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem137, Me.MenuItem223, Me.MenuItem140, Me.MenuItem141, Me.MenuItem222})
        Me.MenuItem124.Text = "Reportes"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 0
        Me.MenuItem137.Text = "Movimientos"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 1
        Me.MenuItem223.Text = "Movimiento por Cuentas"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 2
        Me.MenuItem140.Text = "Generar Informes"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 3
        Me.MenuItem141.Text = "Listado de Cuentas"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 4
        Me.MenuItem222.Text = "Mayor General"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 10
        Me.MenuItem125.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem142, Me.MenuItem143, Me.MenuItem144})
        Me.MenuItem125.Text = "Estados Financieros"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 0
        Me.MenuItem142.Text = "Balanza de Comprobacion"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 1
        Me.MenuItem143.Text = "Estado de Resultado"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 2
        Me.MenuItem144.Text = "Balance General"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 9
        Me.MenuItem159.Text = "-"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 10
        Me.MenuItem117.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem145, Me.MenuItem146, Me.MenuItem171, Me.MenuItem150, Me.MenuItem151, Me.MenuItem163, Me.MenuItem152, Me.MenuItem153})
        Me.MenuItem117.Text = "Control Bancario"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 0
        Me.MenuItem145.Text = "Cuentas de Bancos"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 1
        Me.MenuItem146.Text = "Registro de Documentos"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 2
        Me.MenuItem171.Text = "-"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 3
        Me.MenuItem150.Text = "Conciliar"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 4
        Me.MenuItem151.Text = "Generar Consiliacion"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 5
        Me.MenuItem163.Text = "-"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 6
        Me.MenuItem152.Text = "Impresion de Cheques"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 7
        Me.MenuItem153.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem154, Me.MenuItem157})
        Me.MenuItem153.Text = "Reportes"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 0
        Me.MenuItem154.Text = "Listado de Documentos"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 1
        Me.MenuItem157.Text = "Movimiento por cuentas Bancarias"
        '
        'MnuTools
        '
        Me.MnuTools.Index = 4
        Me.MnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem1, Me.MenuItem37, Me.MenuItem234, Me.MenuItem235, Me.MenuItem236, Me.MenuItem111, Me.MenuItem213})
        Me.MnuTools.Text = "Herramientas"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem155, Me.MenuItem156, Me.MenuItem206, Me.MenuItem203, Me.MenuItem185, Me.MenuItem192, Me.MenuItem202, Me.MenuItem104, Me.MenuItem205, Me.MenuItem34, Me.MenuItem36, Me.MenuItem31, Me.MenuItem208, Me.MenuItem209, Me.MenuItem210, Me.MenuItem211})
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
        'MenuItem203
        '
        Me.MenuItem203.Index = 3
        Me.MenuItem203.Text = "Modelo de Printer"
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
        'MenuItem234
        '
        Me.MenuItem234.Index = 3
        Me.MenuItem234.Text = "-"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 4
        Me.MenuItem235.Text = "Existencia Minima"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 5
        Me.MenuItem236.Text = "Proximo a Vencer"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 6
        Me.MenuItem111.Text = "-"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 7
        Me.MenuItem213.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem237, Me.MenuItem243, Me.MenuItem240, Me.MenuItem239, Me.MenuItem244, Me.MenuItem241, Me.MenuItem246, Me.MenuItem242})
        Me.MenuItem213.Text = "Herramientas DGII"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 0
        Me.MenuItem237.Text = "Formato de compras de bienes y servicios 606" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 1
        Me.MenuItem243.Text = "-"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 2
        Me.MenuItem240.Text = "Formato de ventas de bienes y servicios 607"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 3
        Me.MenuItem239.Text = "Formato de envío de comprobantes anulados 608 "
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 4
        Me.MenuItem244.Text = "-"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 5
        Me.MenuItem241.Text = "Formato de envío de retenciones del Estado 623"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 6
        Me.MenuItem246.Text = "-"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 7
        Me.MenuItem242.Text = "Envío del libro de ventas. 987"
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
        Me.MenuItem92.Text = "Sobre SGF 1.0 ..."
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbb_Products, Me.ToolBarButton2, Me.tbb_Locales, Me.ToolBarButton4, Me.tbb_devoluciones, Me.ToolBarButton5, Me.tbb_ajustes, Me.ToolBarButton3, Me.tbb_clientes, Me.ToolBarButton1, Me.tbb_suplidores, Me.ToolBarButton6, Me.tbb_cotizaciones, Me.ToolBarButton7, Me.tbb_menu, Me.tbb_dropdown})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1030, 28)
        Me.ToolBar1.TabIndex = 5
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        '
        'tbb_Products
        '
        Me.tbb_Products.ImageIndex = 0
        Me.tbb_Products.Text = "Productos"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_Locales
        '
        Me.tbb_Locales.ImageIndex = 1
        Me.tbb_Locales.Text = "Entradas Almacén"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_devoluciones
        '
        Me.tbb_devoluciones.ImageIndex = 5
        Me.tbb_devoluciones.Text = "Devoluciones"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        'ToolBarButton1
        '
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_suplidores
        '
        Me.tbb_suplidores.ImageIndex = 9
        Me.tbb_suplidores.Text = "Suplidores"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_cotizaciones
        '
        Me.tbb_cotizaciones.ImageIndex = 10
        Me.tbb_cotizaciones.Text = "Cotizacion"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbb_menu
        '
        Me.tbb_menu.ImageIndex = 13
        Me.tbb_menu.Text = "Menu"
        '
        'tbb_dropdown
        '
        Me.tbb_dropdown.DropDownMenu = Me.ContextMenu1
        Me.tbb_dropdown.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.cmenuEntrada, Me.cmenuDevol, Me.cmenuAjustes, Me.MenuItem232, Me.cmenuCxp, Me.MenuItem233, Me.cmenuDocCXC, Me.cmenuRecCXC})
        '
        'cmenuEntrada
        '
        Me.cmenuEntrada.Index = 0
        Me.cmenuEntrada.Text = "Aplicar Entradas"
        '
        'cmenuDevol
        '
        Me.cmenuDevol.Index = 1
        Me.cmenuDevol.Text = "Aplicar Devoluciones"
        '
        'cmenuAjustes
        '
        Me.cmenuAjustes.Index = 2
        Me.cmenuAjustes.Text = "Aplicar Documentos"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 3
        Me.MenuItem232.Text = "-"
        '
        'cmenuCxp
        '
        Me.cmenuCxp.Index = 4
        Me.cmenuCxp.Text = "Aplicar Doc. CXP"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 5
        Me.MenuItem233.Text = "-"
        '
        'cmenuDocCXC
        '
        Me.cmenuDocCXC.Index = 6
        Me.cmenuDocCXC.Text = "Aplicar Doc. CXC"
        '
        'cmenuRecCXC
        '
        Me.cmenuRecCXC.Index = 7
        Me.cmenuRecCXC.Text = "Aplicar Rec. CXC"
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
        Me.StatusBar1.Size = New System.Drawing.Size(1030, 22)
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
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(0, 28)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(315, 417)
        Me.Splitter1.TabIndex = 11
        Me.Splitter1.TabStop = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ctMenuFav
        '
        Me.ctMenuFav.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem245, Me.MenuItem238})
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 0
        Me.MenuItem245.Text = "Agregar Favoritos"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 1
        Me.MenuItem238.Text = "Remover Favoritos"
        '
        'sgtmain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1030, 467)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "sgtmain"
        Me.Text = "Sistema para Gestión de Farmacias v 2.1.0.1                                      " & _
        ""
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
    Dim WithEvents oCbbx As ComboBox

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        RunProgram("INV", "i_ivitem01", False, sender.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim WhName As String
        Dim XSelect As LibX.Data.XSelecStmt
        Dim MenuTitle As String
        '//Dim oAno As SGT.Contabilidad.Entidades.AnoFiscal
        '//Dim oPeriodo As SGT.Contabilidad.Entidades.Periodo
        Try
            ProgramRunning = New Hashtable
            ProgramAccess = New SGT.Administracion.Entidades.Program
            ProgramParam = New SGT.Administracion.Entidades.Program.PermissionArgs
            mMachine = New SGT.Administracion.Entidades.Program.Autentication

            mMachine.Machine = System.Environment.MachineName

            If ProgramAccess.BuildAutentication(mMachine) = False Then
                If MessageBox.Show("ESTE PROGRAMA ESTA PROTEGIDO CONTRA" & _
                                    vbCrLf & "COPIA NO AUTORIZADA, NECESITA" & _
                                    vbCrLf & "LA INTERVENSION DEL AUTOR, REDSOFT, S. A." & _
                                    vbCrLf & "TEL. 809-540-0547.", _
                                    "Copia no autorizada", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                    Me.Close()
                End If
            End If

            '// buscar el nombre del almacen
            If LibX.User.WhDefault > 0 Then
                XSelect = New LibX.Data.XSelecStmt("ivwhsem", "select whse_name from ivwhsem")
                XSelect.Parameters.Add("whse_code", LibX.User.WhDefault)
                WhName = XSelect.GetScalar()

                XSelect.Dispose()
            End If

            If Me.IsMdiContainer = True Then
                LibX.App.MainMdi = Me
            End If
            If LibX.Data.Manager.ExecuteLogin() = False Then
                Application.Exit()
            End If

            If LibX.User.UserName Is Nothing Then
                LibX.User.UserName = ConfigurationSettings.AppSettings.Get("LibxAllowUser")
            End If

            'ProgramRunning = New Hashtable
            'ProgramAccess = New SGT.Administracion.Entidades.Program
            'ProgramParam = New SGT.Administracion.Entidades.Program.PermissionArgs
            '//oAno = New SGT.Contabilidad.Entidades.AnoFiscal

            'oPeriodo = oAno.BuscarPeriodoActual

            stbMessage.Text = "Bienvenido " & LibX.User.NombreVendedor
            ''stbNombre.Text = LibX.User.NombreVendedor
            stbNombre.Text = "Terminal : " & mMachine.Machine
            stbUserName.Text = LibX.User.UserName
            'stbUserName.Text = "Periodo:" & oPeriodo.year.ToString & "-" & oPeriodo.Number.ToString
            stbDatabase.Text = LibX.Data.Manager.Connection.Database
            stbAlmacen.Text = WhName

            MenuTitle = System.Configuration.ConfigurationSettings.AppSettings.Get("LibxMenuTitle")

            '// Cargar Menu

            'Dim frmTree As New frmTreeMenu
            'frmTree.MdiParent = Me
            'frmTree.FillTree(MnuSistem)
            'frmTree.Show()

            Dim OtREE As TreeView

            OtREE = New TreeView
            oCbbx = New ComboBox
            Splitter1.Controls.Add(oCbbx)

            Splitter1.Controls.Add(OtREE)
            Splitter1.Cursor = Cursors.Default

            oCbbx.Dock = DockStyle.Top
            OtREE.Dock = DockStyle.Bottom
            OtREE.Height = Splitter1.Size.Height - (oCbbx.Height + 8)
            OtREE.Nodes.Add("Menu")

            '// asigno menu contextual
            OtREE.ContextMenu = ctMenuFav

            FillTree(MnuSistem, OtREE.Nodes(0))


            OtREE.Nodes(0).ExpandAll()
            OtREE.Nodes(0).EnsureVisible()

            AddHandler OtREE.AfterSelect, AddressOf ClickTreeEvent

            If Not MenuTitle Is Nothing Then
                Me.Text = MenuTitle
            End If

            'Dim oFrm As New frmTreeMenu
            'oFrm.MdiParent = Me
            'Splitter1.Hide()
            'oFrm.Show()


            'Dim oFrm1 As New frmVencimiento
            'oFrm1.MdiParent = Me
            'oFrm1.Show()

            GetCountEntr()


        Catch ex As Exception
            LibX.Log.Show(ex)
        End Try

    End Sub


    Private Sub ClickTreeEvent(ByVal sender As Object, ByVal e As TreeViewEventArgs)
        Dim oMenu As MenuItem

        If e.Action <> TreeViewAction.Collapse _
        And e.Action <> TreeViewAction.Expand Then

            '//Splitter1.Hide()
            e.Node.NodeFont = New Font(e.Node.TreeView.Font, FontStyle.Bold)
            oMenu = LocateMenuByText(e.Node.Text)
            If oMenu Is Nothing Then
                'MessageBox.Show("Click " & e.Node.Text)
            Else
                oMenu.PerformClick()
                'End If
            End If
        End If
    End Sub

    Private Function LocateMenuByText(ByVal Texto As String) As MenuItem
        Dim oMenuItem As MenuItem

        oMenuItem = LocateMenu(Texto, MnuSistem)


        Return oMenuItem

    End Function
    Private Function LocateMenu(ByVal Texto As String, ByVal oMenu As MenuItem) As MenuItem
        Dim oMenuitem2 As MenuItem

        For Each oMenuitem As MenuItem In oMenu.MenuItems
            If oMenuitem.Text = Texto Then
                Return oMenuitem
            Else
                If oMenuitem.MenuItems.Count > 0 Then
                    oMenuitem2 = LocateMenu(Texto, oMenuitem)
                    If Not oMenuitem2 Is Nothing Then
                        Return oMenuitem2
                    End If
                End If
            End If
        Next

    End Function

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        RunProgram("INV", "i_iventr02", False, sender.Text)
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_ivdevm01", False, sender.Text)
    End Sub

    'Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
    '    RunProgram("INV", "p_iventr01")
    'End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        RunProgram("INV", "i_ivdevm01", False, sender.Text)
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click, cmenuDevol.Click
        RunProgram("INV", "p_ivdevm01", False, sender.Text)
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXC", "i_ccpaym02", False, sender.Text)
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        RunProgram("FCT", "i_ftvend01", False, sender.Text)
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "i_ptvrecib01", False, sender.Text)
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXC", "i_custrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CAJ", "i_cjcaja01", False, sender.Text)
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CAJ", "i_cjinit01", False, sender.Text)
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CAJ", "p_cjinit01", False, sender.Text)
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        RunProgram("INV", "i_ivgroup01", False, sender.Text)
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        RunProgram("INV", "i_ivsgroup01", False, sender.Text)
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        RunProgram("INV", "i_ivbrand01", False, sender.Text)
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        RunProgram("INV", "i_ivunitm01", False, sender.Text)
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        RunProgram("INV", "i_ivwhsem01", False, sender.Text)
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        RunProgram("CAj", "i_cjmonedam01", False, sender.Text)
    End Sub

    Private Sub MenuItem6_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        RunProgram("CXP", "i_cpprovm01", False, sender.Text)
    End Sub

    Private Sub RunProgram(ByVal mdlname As String, ByVal ProgName As String, ByVal RunPerm As Boolean, Optional ByVal prgName As String = "")

        Try
            Cursor = Cursors.WaitCursor

            ProgramParam.Type = SGT.Administracion.Entidades.Program.PermissionTypeEnum.AccessProgram
            ProgramParam.ProgramName = ProgName
            ProgramParam.UserID = LibX.User.UserID

            If ProgramAccess.HasPermission(ProgramParam) = False Then
                Throw New ApplicationException("No tienes permisos para ejecutar este programa")
            End If

            If ProgName <> "i_ftfact01" Then
                If ProgramRunning.Contains(ProgName) = True Then
                    If Me.IsMdiContainer = True Then
                        For Each OForm As Form In Me.MdiChildren
                            If OForm.Name = ProgName Then
                                OForm.Activate()
                                Me.Cursor = Cursors.Default
                                Exit Sub
                            End If
                        Next
                    End If
                End If

                ProgramRunning.Add(ProgName, mdlname)
                If prgName.Trim <> "" Then
                    mnuRecent.MenuItems.Add(prgName)
                Else
                    mnuRecent.MenuItems.Add(ProgName)
                End If

            End If

            '//
            'If Splitter1.Visible = False Then
            '    Splitter1.Show()
            'Else
            Splitter1.Hide()
            'End If
            '//

            LibX.LibXRunner.Run(ProgName, mdlname)
            If Me.IsMdiContainer = True Then
                For idx As Integer = 0 To Me.MdiChildren.Length - 1
                    If CType(Me.MdiChildren(idx), Form).Name = ProgName Then
                        AddHandler CType(Me.MdiChildren(idx), Form).Closing, AddressOf FormChild_Closing
                    End If
                Next
            End If
            Cursor = Cursors.Default

        Catch ex As Exception
            LibX.Log.Show(ex)
            If ProgName.Trim <> "" Then
                ProgramRunning.Remove(ProgName)
            End If

            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_ivadjus01", False, sender.Text)
    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "p_ftdevm01.exe", False, sender.Text)
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
        RunProgram("CXC", "i_custrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        RunProgram("CXC", "i_ccterm01", False, sender.Text)
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        RunProgram("CXC", "i_cccsttpm01", False, sender.Text)
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Me.Close()
    End Sub


    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        PrintDialog1.ShowDialog(Me)
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            If e.Button Is tbb_Products Then
                MenuItem1_Click(sender, Nothing)
            End If
            If e.Button Is tbb_Locales Then
                MenuItem2_Click(sender, Nothing)
            End If
            If e.Button Is tbb_devoluciones Then
                MenuItem3_Click(sender, Nothing)
            End If
            If e.Button Is tbb_ajustes Then
                MenuItem4_Click(sender, Nothing)
            End If

            If e.Button Is tbb_clientes Then
                MenuItem6_Click(sender, Nothing)
            End If
            If e.Button Is tbb_suplidores Then
                MenuItem6_1_Click(sender, Nothing)
            End If

            If e.Button Is tbb_cotizaciones Then
                MenuItem8_Click(sender, Nothing)
            End If
            If e.Button Is tbb_menu Then
                If Splitter1.Visible = False Then
                    Splitter1.Show()
                Else
                    Splitter1.Hide()
                End If

            End If
            'If e.Button Is tbb_estafetas Then
            '    MenuItem52_Click(Nothing, Nothing)
            'End If

            'If e.Button Is tbb_Excel Then
            '    Dim Proceso As New System.Diagnostics.Process
            '    Proceso.Start(AppSettings.Get("apppath") & "Others\SheetPrice.xls")
            'End If

        Catch ex As Exception
            LibX.Log.Show(ex)

        End Try

    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftfact10", False, sender.Text)
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "i_ftfact11", False, sender.Text)
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXC", "i_ccinvce01", False, sender.Text)
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "i_sfcobrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftfact00", False, sender.Text)
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        RunProgram("cxc", "i_ccinvce01", False, sender.Text)
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        RunProgram("cxc", "i_ccpaym02", False, sender.Text)
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        RunProgram("INV", "i_ivsalid01", False, sender.Text)
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        RunProgram("INV", "i_ivadjus01", False, sender.Text)
    End Sub

    Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
        RunProgram("INV", "i_ivtransf01", False, sender.Text)
    End Sub

    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click, cmenuAjustes.Click
        RunProgram("INV", "p_ivdocs01", False, sender.Text)

    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "i_ftdevtp01", False, sender.Text)

    End Sub

    Private Sub MenuItem38_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "i_ftofert01", False, sender.Text)

    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "p_ftcomm01", False, sender.Text)

    End Sub

    Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
        RunProgram("CXC", "c_ccdocs03", False, sender.Text)

    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        RunProgram("CXC", "r_ccpaym03", False, sender.Text)

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        RunProgram("CXC", "r_ccpaym01", False, sender.Text)

    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        RunProgram("CXC", "r_ccpaym02", False, sender.Text)
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click, cmenuDocCXC.Click
        RunProgram("CXC", "p_ccdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem78_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem78.Click
        RunProgram("INV", "p_ivcierr01", False, sender.Text)
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        RunProgram("INV", "r_ivonhnd01", False, sender.Text)
    End Sub

    Private Sub MenuItem87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "p_ivcount02", False, sender.Text)
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        RunProgram("INV", "g_ivcount03", False, sender.Text)
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        RunProgram("INV", "i_ivcount01", False, sender.Text)
    End Sub

    Private Sub MenuItem84_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem84.Click
        RunProgram("INV", "p_ivcount01", False, sender.Text)
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftcomm02", False, sender.Text)
    End Sub

    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        RunProgram("INV", "r_ivrorder", False, sender.Text)
    End Sub

    Private Sub MenuItem96_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem96.Click
        RunProgram("FCT", "r_ftprecio", False, sender.Text)
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftfact05", False, sender.Text)

    End Sub

    Private Sub MenuItem99_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_iventr02", False, sender.Text)

    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        RunProgram("CXP", "i_cpinvce01", False, sender.Text)

    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click, cmenuCxp.Click, cmenuCxp.Click
        RunProgram("CXP", "p_cpdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("ADM", "i_stprogrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("ADM", "i_users", False, sender.Text)

    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("ADM", "i_groups", False, sender.Text)

    End Sub

    Private Sub MenuItem116_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("ADM", "i_access", False, sender.Text)

    End Sub

    Private Sub MenuItem118_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "c_ftdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftfact09", False, sender.Text)
    End Sub

    Private Sub MenuItem120_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftfact07", False, sender.Text)
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgacctm", False, sender.Text)
    End Sub

    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgacctp", False, sender.Text)
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgdoctp", False, sender.Text)
    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgperdr", False, sender.Text)
    End Sub

    Private Sub MenuItem127_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgperdd", False, sender.Text)
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgjourm", False, sender.Text)
    End Sub

    Private Sub MenuItem128_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgcodifm", False, sender.Text)
    End Sub

    Private Sub MenuItem136_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_postpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_acctpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "p_ftfact02", False, sender.Text)
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "i_iventr03", False, sender.Text)
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        RunProgram("CXC", "r_ccpaym04", False, sender.Text)
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        RunProgram("INV", "r_ivonhnd02", False, sender.Text)
    End Sub

    Private Sub MenuItem86_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem86.Click
        RunProgram("INV", "r_ivcount02", False, sender.Text)
    End Sub

    Private Sub MenuItem150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXC", "i_ccpaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_pstccpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem126_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_acctpr02", False, sender.Text)
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgdepto", False, sender.Text)
    End Sub

    Private Sub MenuItem151_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_tranr01", False, sender.Text)
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_acctrp02", False, sender.Text)
    End Sub

    Private Sub MenuItem140_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "i_cgestfin", False, sender.Text)
    End Sub

    Private Sub MenuItem154_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_acctrp01", False, sender.Text)
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXP", "i_cppaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem99_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem99.Click
        RunProgram("CXP", "i_cppaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        RunProgram("INV", "i_ivsetup", False, sender.Text)
    End Sub

    Private Sub MenuItem156_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem156.Click
        RunProgram("CTG", "i_cgconf01", False, sender.Text)
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_acctpr03", False, sender.Text)
    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "p_acctpr04", False, sender.Text)

    End Sub

    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_tranr02", False, sender.Text)
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_acctrp03", False, sender.Text)
    End Sub

    Private Sub MenuItem160_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_tranr04", False, sender.Text)
    End Sub

    Private Sub MenuItem107_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem107.Click
        RunProgram("CXP", "r_cppaym02", False, sender.Text)
    End Sub

    Private Sub MenuItem108_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem108.Click
        RunProgram("CXP", "r_cppaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem163_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CAJ", "i_cjpaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        RunProgram("CXP", "i_cpordm01", False, sender.Text)
    End Sub

    Private Sub MenuItem87_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem87.Click
        RunProgram("INV", "i_ivcobm01", False, sender.Text)
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        RunProgram("INV", "i_ivrefm01", False, sender.Text)
    End Sub

    Private Sub MenuItem167_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem167.Click
        RunProgram("CXP", "g_cpordm01", False, sender.Text)
    End Sub

    Private Sub MenuItem168_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem168.Click
        RunProgram("CXP", "i_cpordm01", False, sender.Text)
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        RunProgram("INV", "i_ivpreciom01", False, sender.Text)
    End Sub

    Private Sub MenuItem171_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "i_ptvfact01", False, sender.Text)
    End Sub

    Private Sub MenuItem173_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem173.Click
        RunProgram("PTV", "i_ptvcomb01", False, sender.Text)
    End Sub

    Private Sub MenuItem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "i_ptvtarjm01", False, sender.Text)
    End Sub

    Private Sub MenuItem175_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem175.Click
        RunProgram("PTV", "i_ptvpolm01", False, sender.Text)
    End Sub
    Private Sub MenuItem178_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem178.Click
        RunProgram("INV", "r_ivetiqm01", False, sender.Text)
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        RunProgram("CXP", "i_cpcheqm", False, sender.Text)
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        RunProgram("INV", "r_ivdevol01", False, sender.Text)
    End Sub

    Private Sub MenuItem177_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem177.Click
        RunProgram("INV", "i_ivetiqm01", False, sender.Text)
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        RunProgram("INV", "r_iventr01", False, sender.Text)
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        RunProgram("INV", "r_iventr03", False, sender.Text)
    End Sub

    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem183.Click
        RunProgram("INV", "r_ivitemref", False, sender.Text)
    End Sub

    Private Sub MenuItem185_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem185.Click
        RunProgram("INV", "i_ivetiqmod", False, sender.Text)
    End Sub

    Private Sub MenuItem184_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem184.Click
        RunProgram("PTV", "i_ptvciasgm01", False, sender.Text)
    End Sub

    Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click
        RunProgram("PTV", "i_ptvasegm01", False, sender.Text)
    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
        RunProgram("PTV", "i_sgplanm01", False, sender.Text)
    End Sub

    Private Sub MenuItem188_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem188.Click
        RunProgram("CXC", "r_ccpaym05", False, sender.Text)
    End Sub

    Private Sub MenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem189.Click
        RunProgram("CXC", "r_ccpaym06", False, sender.Text)
    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
        RunProgram("CXC", "r_ccpaym08", False, sender.Text)
    End Sub

    Private Sub MenuItem190_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem190.Click
        RunProgram("CXC", "r_ccpaym07", False, sender.Text)
    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click
        RunProgram("INV", "i_ivtype01", False, sender.Text)
    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click
        RunProgram("PTV", "i_sfmaem01", False, sender.Text)
    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click
        RunProgram("PTV", "i_sfcobrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem198_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CXP", "i_cpdepom01", False, sender.Text)
    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        RunProgram("CXC", "p_cctrfdoc01", False, sender.Text)
    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click
        RunProgram("PTV", "i_pvtarjm01", False, sender.Text)
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

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CAJ", "i_cjncrm01", False, sender.Text)
    End Sub

    Private Sub MenuItem204_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem204.Click
        RunProgram("FCT", "i_ftdevtp01", False, sender.Text)
    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        RunProgram("ADM", "i_adbanco01", False, sender.Text)
    End Sub

    Private Sub MenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem207.Click
        RunProgram("CXP", "i_cptypem01", False, sender.Text)
    End Sub

    Private Sub MenuItem208_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem208.Click
        RunProgram("FCT", "i_ftncfm01", False, sender.Text)
    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        RunProgram("CXC", "i_citym", False, sender.Text)
    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click
        RunProgram("CXC", "i_sectorm", False, sender.Text)
    End Sub

    Private Sub MenuItem212_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem212.Click
        RunProgram("INV", "r_ivitvenc", False, sender.Text)
    End Sub

    Private Sub MenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "i_ptvrecib01", False, sender.Text)
    End Sub

    Private Sub MenuItem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem215.Click
        RunProgram("PTV", "r_ptvfact02", False, sender.Text)
    End Sub

    Private Sub MenuItem217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem217.Click
        RunProgram("INV", "r_ivnocount01", False, sender.Text)
    End Sub

    Private Sub MenuItem52_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "r_ftmes", False, sender.Text)
    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        RunProgram("PTV", "r_ftsegr", False, sender.Text)
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        RunProgram("FCT", "i_ftfact11", False, sender.Text)
    End Sub

    Private Sub MenuItem51_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        RunProgram("CAJ", "i_cjcaja01", False, sender.Text)
    End Sub

    Private Sub MenuItem38_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        RunProgram("CAJ", "i_cjinit01", False, sender.Text)
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        RunProgram("CAJ", "p_cjcierre01", True)
    End Sub

    Private Sub MenuItem97_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        RunProgram("FCT", "i_ftfact11", False, sender.Text)
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("FCT", "c_ftdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        RunProgram("FCT", "r_ftfact10", False, sender.Text)
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        RunProgram("FCT", "r_ftfact00", False, sender.Text)
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        RunProgram("FCT", "r_ftmes", False, sender.Text)
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        RunProgram("FCT", "r_ftfact09", False, sender.Text)
    End Sub

    Private Sub MenuItem29_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        RunProgram("FCT", "r_ftcomm02", False, sender.Text)
    End Sub

    'Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
    '    RunProgram("FCT", "r_ftfact07")
    'End Sub
    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        RunProgram("FCT", "r_ftfact08", False, sender.Text)
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click, cmenuEntrada.Click
        RunProgram("INV", "p_iventr01", False, sender.Text)
    End Sub

    Private Sub MenuItem50_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        RunProgram("FCT", "r_ivranking", False, sender.Text)
    End Sub

    Private Sub MenuItem61_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        RunProgram("CXC", "r_ccpaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem52_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        RunProgram("CXC", "r_ccpaym09", False, sender.Text)
    End Sub

    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        RunProgram("INV", "i_ivdevm02", False, sender.Text)
    End Sub

    Private Sub MenuItem53_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        RunProgram("INV", "i_ivtpeadj01", False, sender.Text)
    End Sub

    Private Sub MenuItem68_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
        RunProgram("PTV", "r_ptvfact03", False, sender.Text)
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        RunProgram("INV", "i_ivconteoauto", False, sender.Text)
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        RunProgram("INV", "r_ivrotap", False, sender.Text)
    End Sub

    Private Sub MenuItem77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem77.Click
        RunProgram("PTV", "r_ftsegm", False, sender.Text)
    End Sub

    Private Sub MenuItem69_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        RunProgram("PTV", "r_ptvfact04", False, sender.Text)
    End Sub

    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        RunProgram("FCT", "i_ftfact02", False, sender.Text)
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        RunProgram("CXP", "r_cppaym03", False, sender.Text)
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        RunProgram("CXP", "r_cppaym04", False, sender.Text)
    End Sub

    Private Sub MenuItem89_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click

    End Sub

    Private Sub MenuItem115_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        RunProgram("CXP", "r_cppaym09", False, sender.Text)
    End Sub

    Private Sub MenuItem112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem112.Click
        RunProgram("CXP", "r_cppaym06", False, sender.Text)
    End Sub

    Private Sub MenuItem118_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem118.Click
        RunProgram("CTG", "i_cgacctm", False, sender.Text)
    End Sub

    Private Sub MenuItem119_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        RunProgram("CTG", "i_cgjourm", False, sender.Text)
    End Sub

    Private Sub MenuItem120_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem120.Click
        RunProgram("CTG", "p_postpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem122_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem122.Click
        RunProgram("CTG", "p_pstccpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem126_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        RunProgram("CTG", "p_acctpr02", False, sender.Text)
    End Sub

    Private Sub MenuItem127_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem127.Click
        RunProgram("CTG", "p_acctpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem130_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem130.Click
        RunProgram("CTG", "p_acctpr03", False, sender.Text)
    End Sub

    Private Sub MenuItem131_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        RunProgram("CTG", "i_cgacctp", False, sender.Text)
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click
        RunProgram("CTG", "i_cgdoctp", False, sender.Text)
    End Sub

    Private Sub MenuItem133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem133.Click
        RunProgram("CTG", "i_cgperdd", False, sender.Text)
    End Sub

    Private Sub MenuItem134_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        RunProgram("CTG", "i_cgcodifm", False, sender.Text)
    End Sub

    Private Sub MenuItem135_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem135.Click
        RunProgram("CTG", "i_cgdepto", False, sender.Text)
    End Sub

    Private Sub MenuItem136_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem136.Click
        RunProgram("CTG", "i_cgestfin", False, sender.Text)
    End Sub

    Private Sub MenuItem145_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        RunProgram("CXP", "i_cpcheqm", False, sender.Text)
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        RunProgram("CTB", "i_cbdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem150_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem150.Click
        RunProgram("CTB", "p_cbdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem151_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem151.Click
        RunProgram("CTB", "p_cbdocs02", False, sender.Text)
    End Sub

    Private Sub MenuItem152_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem152.Click
        RunProgram("CTB", "p_cbdocs03", False, sender.Text)
    End Sub

    Private Sub MenuItem154_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem154.Click
        RunProgram("CTB", "r_cbdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem157_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        RunProgram("CTB", "r_cbrcuem01", False, sender.Text)
    End Sub

    Private Sub MenuItem137_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem137.Click
        RunProgram("CTG", "r_tranr01", False, sender.Text)
    End Sub

    Private Sub MenuItem138_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_tranr04", False, sender.Text)
    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("CTG", "r_tranr02", False, sender.Text)
    End Sub

    Private Sub MenuItem140_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem140.Click
        RunProgram("CTG", "r_acctrp01", False, sender.Text)
    End Sub

    Private Sub MenuItem141_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        RunProgram("CTG", "r_acctrp03", False, sender.Text)
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        RunProgram("CTG", "r_cgbalcpr01", False, sender.Text)
    End Sub

    Private Sub MenuItem143_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem143.Click
        RunProgram("CTG", "r_cgresul01", False, sender.Text)
    End Sub

    Private Sub MenuItem144_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        RunProgram("CTG", "r_cgbalgn01", False, sender.Text)
    End Sub

    Private Sub MenuItem174_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        RunProgram("PTV", "r_pvnc01", False, sender.Text)
    End Sub

    Private Sub opcCXP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcCXP.Click

    End Sub

    Private Sub MenuItem113_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem113.Click
        RunProgram("CXP", "r_cppaym08", False, sender.Text)
    End Sub

    Private Sub MenuItem194_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem194.Click
        RunProgram("CXP", "c_cpdocs03", False, sender.Text)
    End Sub

    Private Sub MenuItem198_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem198.Click
        RunProgram("PTV", "r_pvreceg", False, sender.Text)
    End Sub

    Private Sub MenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem199.Click
        RunProgram("INV", "r_ivproduc", False, sender.Text)
    End Sub

    Private Sub MenuItem203_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        RunProgram("ADM", "i_sgfprinter", False, sender.Text)
    End Sub

    Private Sub MenuItem102_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem102.Click
        RunProgram("CXP", "p_cptrfdoc01", False, sender.Text)
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click
        RunProgram("INV", "r_ivcontrol", False, sender.Text)
    End Sub

    Private Sub MenuItem129_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem129.Click
        RunProgram("INV", "i_ivvcmto01", False, sender.Text)
    End Sub

    Private Sub MenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem219.Click
        RunProgram("INV", "i_ivcmted", False, sender.Text)
    End Sub

    Private Sub MenuItem220_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem220.Click
        RunProgram("CTG", "i_cgcdifem01", False, sender.Text)
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click
        RunProgram("CXC", "r_ccmaux", False, sender.Text)
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        RunProgram("ADM", "i_redsoft", False, sender.Text)
    End Sub

    Private Sub MenuItem213_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem213.Click
        RunProgram("ADM", "i_redsoft", False, sender.Text)
    End Sub

    Private Sub MenuItem223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem223.Click
        RunProgram("CTG", "r_tranr05", False, sender.Text)
    End Sub

    Private Sub MenuItem138_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click
        RunProgram("INV", "r_movimiento", False, sender.Text)
    End Sub

    Private Sub MenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem222.Click
        RunProgram("CTG", "r_acctrp02", False, sender.Text)
    End Sub

    Private Sub MenuItem139_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        RunProgram("PTV", "r_pvestaf", False, sender.Text)
    End Sub

    Private Sub MenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem224.Click
        RunProgram("CTG", "i_cgcdifem02", False, sender.Text)
    End Sub

    Private Sub MenuItem128_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem128.Click
        RunProgram("CTG", "p_acctpr05", False, sender.Text)
    End Sub

    Private Sub MenuItem225_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem225.Click
        RunProgram("CTG", "i_cgsucm01", False, sender.Text)
    End Sub

    Private Sub MenuItem226_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem226.Click, cmenuRecCXC.Click
        RunProgram("CXC", "p_ccpaym01", False, sender.Text)
    End Sub

    Private Sub MenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem227.Click
        RunProgram("PTV", "i_ptvclinim01", False, sender.Text)
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click
        RunProgram("PTV", "r_maeasegm", False, sender.Text)
    End Sub

    Private Sub MenuItem229_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("PTV", "c_ptvdocs01", False, sender.Text)
    End Sub

    Private Sub MenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem230.Click
        RunProgram("PTV", "c_ptvfact03", False, sender.Text)
    End Sub

    Private Sub MenuItem229_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem229.Click
        RunProgram("INV", "c_ivdocs02", False, sender.Text)
    End Sub

    Private Sub GetCountEntr()

        Dim intCount As Integer

        intCount = LibX.Data.Manager.GetScalar("SELECT COUNT(*) FROM iventrdm WHERE entr_status = 2 ")
        tbb_dropdown.Text = ""
        tbb_dropdown.Enabled = False

        If intCount > 0 Then
            cmenuEntrada.Text = "Entradas Almacén - (" & intCount.ToString() & ")"
            cmenuEntrada.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

        intCount = LibX.Data.Manager.GetScalar("SELECT COUNT(*) FROM ivdevolm WHERE dev_status = 2 ")
        If intCount > 0 Then
            cmenuDevol.Text = "Devoluciones - (" & intCount.ToString() & ")"
            cmenuDevol.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

        intCount = LibX.Data.Manager.GetScalar("SELECT COUNT(*) FROM ivdocsm WHERE doc_status = 2 ")
        If intCount > 0 Then
            cmenuAjustes.Text = "Ajustes - (" & intCount.ToString() & ")"
            cmenuAjustes.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

        intCount = LibX.Data.Manager.GetScalar("select COUNT(*) from cpdocsv where type_code <> 'DVI' and invce_status = 2")
        If intCount > 0 Then
            cmenuCxp.Text = "Aplicar Doc. CXP - (" & intCount.ToString() & ")"
            cmenuCxp.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

        intCount = LibX.Data.Manager.GetScalar("SELECT COUNT(*) FROM ccinvcem WHERE invce_status = 2 ")
        If intCount > 0 Then
            cmenuDocCXC.Text = "Aplicar Doc. CXC - (" & intCount.ToString() & ")"
            cmenuDocCXC.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

        intCount = LibX.Data.Manager.GetScalar("SELECT COUNT(*) FROM ccpaymm WHERE invce_status = 2 ")
        If intCount > 0 Then
            cmenuRecCXC.Text = "Aplicar Rec. CXC - (" & intCount.ToString() & ")"
            cmenuRecCXC.Enabled = True
            tbb_dropdown.Text = "Pendintes"
            tbb_dropdown.Enabled = True
        End If

    End Sub

    Private Sub sgtmain_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        GetCountEntr()
    End Sub

    Private Sub oCbbx_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles oCbbx.KeyPress
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub MenuItem235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem235.Click
        Try
            Dim oFrmTree As New frmTreeMenu
            oFrmTree.MdiParent = Me
            oFrmTree.Show()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try
    End Sub

    Private Sub MenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem236.Click
        Try
            Dim oFrmTree As New frmTreeMenu
            oFrmTree.MdiParent = Me
            oFrmTree.Show()

        Catch ex As Exception
            LibX.Log.Add(ex)
        End Try

    End Sub

    Private Sub sgtmain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        GetCountEntr()
    End Sub

    Private Sub sgtmain_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MyBase.ControlRemoved
        GetCountEntr()
    End Sub


    Private Sub MenuItem245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem245.Click
        mnuFavoritos.MenuItems.Add(CType(ctMenuFav.SourceControl, TreeView).SelectedNode.Text)
    End Sub

    Private Sub Splitter1_SplitterMoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub MenuItem239_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RunProgram("INV", "r_iventr01", False, sender.Text)
    End Sub

    Private Sub MenuItem240_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem240.Click
        RunProgram("PTV", "r_ptvfact04", False, sender.Text)
    End Sub

    Private Sub MenuItem239_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem239.Click
        RunProgram("PTV", "r_ptvfact04", False, sender.Text)
    End Sub

    Private Sub sgtmain_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles MyBase.ControlAdded
        'GetCountEntr()
    End Sub

    Private Sub MenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem237.Click
        RunProgram("INV", "r_iventr606", False, sender.Text)

    End Sub
End Class


