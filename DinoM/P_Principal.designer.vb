﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Principal))
        Me.rmSesion = New DevComponents.DotNetBar.RadialMenu()
        Me.btCerrarSesion = New DevComponents.DotNetBar.RadialMenuItem()
        Me.btSalir = New DevComponents.DotNetBar.RadialMenuItem()
        Me.btAbout = New DevComponents.DotNetBar.RadialMenuItem()
        Me.lbUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SideNav1 = New DevComponents.DotNetBar.Controls.SideNav()
        Me.SideNavPanel7 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MenuCreditos = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btnCredPago = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btnCredEstCuenta = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btnCredInfMorosidad = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btnCredPagoCliente = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btnCredPagoClienteVendedor = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btnCredPagoResumen = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNavPanel8 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.grProductos = New Janus.Windows.GridEX.GridEX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnActualizar = New DevComponents.DotNetBar.ButtonX()
        Me.btnReporte = New DevComponents.DotNetBar.ButtonX()
        Me.btExcel = New DevComponents.DotNetBar.ButtonX()
        Me.SideNavPanel5 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroTilePanel6 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btInvDeposito = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvAmacen = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvMovimiento = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvKardex = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvSaldo = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvKardexReporte = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvUtilidad = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvSaldoLote = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btlvSaldoMinimo = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btInvVentas = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNavPanel6 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroTilePanel7 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btComProveedor = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btComCompra = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btComPagosCredito = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem21 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem22 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem23 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNav_Logistica = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MetroTilePanel2 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btZonas = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btZonaMapaCliente = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btZonaReporteRuta = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btRHAntigueVacaciones = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btRHBonosDesc = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btRHRepPlanillaSueldos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btRHPedidoVacacion = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SideNav_Conf = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MetroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btConfRoles = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfUsuarios = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfCliente = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfProducto = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfPrecio = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfLibreria = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfDosificacion = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btConfRepCliente = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btRepClientes = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.SideNav_Ventas = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.MetroTilePanelVentas = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btVentVenta = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentFactura = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentAnularFactura = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentLibroVenta = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentReporteAtendidas = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentReporteVentaVsCosto = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentReporteProducto = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentGrafica = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentRotProd = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btComVendedor = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentEstad = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentDescuento = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNavPanel3 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.superTabControl3 = New DevComponents.DotNetBar.SuperTabControl()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.SideNavPanel4 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MetroTilePanel5 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.MetroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem3 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem10 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNavPanel1 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MetroTilePanel4 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btSocSocio = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocPagos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.btSocRepSocio = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocRepSocioEdad = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocRepSocioPagos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocRepSocioPagosGral = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocRepSocioPagosMortuoriaGral = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btSocRepSocioListaSociosActivos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SideNavPanel2 = New DevComponents.DotNetBar.Controls.SideNavPanel()
        Me.MetroTilePanel3 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.btEscVehiculo = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscAlumnos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscEquipos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscClaPracticas = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscInscripciones = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscPreExamen = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscClasesTeoricas = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.btEscRepPreExamen = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscRepEstadosAlumnos = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btEscRepAlumnosSinPreExamen = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SideNavItem1 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator1 = New DevComponents.DotNetBar.Separator()
        Me.FP_Configuracion = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_ZONAS = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_INVENTARIO = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Saldos_Producto = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_Pedidos = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem2 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_COMPRAS = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_VENTAS = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.FP_CREDITOS = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.Separator2 = New DevComponents.DotNetBar.Separator()
        Me.Ventana = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.SideNavItem3 = New DevComponents.DotNetBar.Controls.SideNavItem()
        Me.MetroTileFrame1 = New DevComponents.DotNetBar.Metro.MetroTileFrame()
        Me.MetroTileFrame2 = New DevComponents.DotNetBar.Metro.MetroTileFrame()
        Me.MetroTileItem8 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem7 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.btVentRepSaldoClientes = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem11 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.SideNav1.SuspendLayout()
        Me.SideNavPanel7.SuspendLayout()
        Me.SideNavPanel8.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SideNavPanel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SideNavPanel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SideNav_Logistica.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideNav_Conf.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideNav_Ventas.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.SideNavPanel3.SuspendLayout()
        CType(Me.superTabControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superTabControl3.SuspendLayout()
        Me.SideNavPanel4.SuspendLayout()
        Me.SideNavPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SideNavPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rmSesion
        '
        Me.rmSesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rmSesion.BackColor = System.Drawing.Color.Transparent
        Me.rmSesion.Diameter = 200
        Me.rmSesion.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btCerrarSesion, Me.btSalir, Me.btAbout})
        Me.rmSesion.Location = New System.Drawing.Point(46, 446)
        Me.rmSesion.Name = "rmSesion"
        Me.rmSesion.Size = New System.Drawing.Size(50, 50)
        Me.rmSesion.Symbol = ""
        Me.rmSesion.SymbolSize = 20.0!
        Me.rmSesion.TabIndex = 2
        Me.rmSesion.Text = "RadialMenu1"
        Me.rmSesion.Visible = False
        '
        'btCerrarSesion
        '
        Me.btCerrarSesion.Name = "btCerrarSesion"
        Me.btCerrarSesion.Symbol = ""
        Me.btCerrarSesion.Text = "CERRAR SESION"
        '
        'btSalir
        '
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Symbol = ""
        Me.btSalir.Text = "SALIR"
        '
        'btAbout
        '
        Me.btAbout.Name = "btAbout"
        Me.btAbout.Symbol = ""
        Me.btAbout.Text = "ABOUT DIES"
        '
        'lbUsuario
        '
        Me.lbUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lbUsuario.Border.Class = "TextBoxBorder"
        Me.lbUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbUsuario.Location = New System.Drawing.Point(12, 506)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.PreventEnterBeep = True
        Me.lbUsuario.ReadOnly = True
        Me.lbUsuario.Size = New System.Drawing.Size(119, 20)
        Me.lbUsuario.TabIndex = 4
        Me.lbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lbUsuario.Visible = False
        '
        'SideNav1
        '
        Me.SideNav1.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.SideNav1.Controls.Add(Me.SideNavPanel7)
        Me.SideNav1.Controls.Add(Me.SideNavPanel8)
        Me.SideNav1.Controls.Add(Me.SideNavPanel5)
        Me.SideNav1.Controls.Add(Me.SideNavPanel6)
        Me.SideNav1.Controls.Add(Me.SideNav_Logistica)
        Me.SideNav1.Controls.Add(Me.SideNav_Conf)
        Me.SideNav1.Controls.Add(Me.SideNav_Ventas)
        Me.SideNav1.Controls.Add(Me.SideNavPanel3)
        Me.SideNav1.Controls.Add(Me.SideNavPanel4)
        Me.SideNav1.Controls.Add(Me.SideNavPanel1)
        Me.SideNav1.Controls.Add(Me.SideNavPanel2)
        Me.SideNav1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SideNavItem1, Me.Separator1, Me.FP_Configuracion, Me.FP_ZONAS, Me.FP_INVENTARIO, Me.Saldos_Producto, Me.FP_Pedidos, Me.SideNavItem2, Me.FP_COMPRAS, Me.FP_VENTAS, Me.FP_CREDITOS, Me.Separator2, Me.Ventana, Me.SideNavItem3})
        Me.SideNav1.Location = New System.Drawing.Point(0, 0)
        Me.SideNav1.Name = "SideNav1"
        Me.SideNav1.Padding = New System.Windows.Forms.Padding(1)
        Me.SideNav1.Size = New System.Drawing.Size(1003, 561)
        Me.SideNav1.TabIndex = 1
        Me.SideNav1.Text = "SideNav1"
        '
        'SideNavPanel7
        '
        Me.SideNavPanel7.Controls.Add(Me.MenuCreditos)
        Me.SideNavPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel7.Location = New System.Drawing.Point(155, 36)
        Me.SideNavPanel7.Margin = New System.Windows.Forms.Padding(2)
        Me.SideNavPanel7.Name = "SideNavPanel7"
        Me.SideNavPanel7.Size = New System.Drawing.Size(843, 524)
        Me.SideNavPanel7.TabIndex = 162
        '
        'MenuCreditos
        '
        Me.MenuCreditos.BackColor = System.Drawing.Color.Transparent
        Me.MenuCreditos.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MenuCreditos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MenuCreditos.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MenuCreditos.BackgroundStyle.Class = "MetroTilePanel"
        Me.MenuCreditos.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MenuCreditos.ContainerControlProcessDialogKey = True
        Me.MenuCreditos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuCreditos.DragDropSupport = True
        Me.MenuCreditos.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnCredPago, Me.btnCredEstCuenta, Me.btnCredInfMorosidad, Me.btnCredPagoCliente, Me.btnCredPagoClienteVendedor, Me.btnCredPagoResumen})
        Me.MenuCreditos.ItemSpacing = 10
        Me.MenuCreditos.Location = New System.Drawing.Point(0, 0)
        Me.MenuCreditos.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCreditos.MultiLine = True
        Me.MenuCreditos.Name = "MenuCreditos"
        Me.MenuCreditos.Size = New System.Drawing.Size(843, 524)
        Me.MenuCreditos.TabIndex = 2
        Me.MenuCreditos.Text = "mtp2Logistica"
        '
        'btnCredPago
        '
        Me.btnCredPago.Image = Global.DinoM.My.Resources.Resources.creditopagos
        Me.btnCredPago.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredPago.Name = "btnCredPago"
        Me.btnCredPago.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredPago.Text = "REALIZAR PAGOS"
        Me.btnCredPago.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredPago.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredPago.TileStyle.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btnCredPago.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredPago.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredPago.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredPago.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredPago.TitleTextColor = System.Drawing.Color.Red
        '
        'btnCredEstCuenta
        '
        Me.btnCredEstCuenta.Image = Global.DinoM.My.Resources.Resources.rp_estadoCuentas
        Me.btnCredEstCuenta.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredEstCuenta.Name = "btnCredEstCuenta"
        Me.btnCredEstCuenta.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredEstCuenta.Text = "ESTADO DE CUENTAS"
        Me.btnCredEstCuenta.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredEstCuenta.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredEstCuenta.TileStyle.BackColor = System.Drawing.Color.Blue
        Me.btnCredEstCuenta.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredEstCuenta.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredEstCuenta.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredEstCuenta.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredEstCuenta.TitleTextColor = System.Drawing.Color.Red
        '
        'btnCredInfMorosidad
        '
        Me.btnCredInfMorosidad.Image = Global.DinoM.My.Resources.Resources.hojaruta
        Me.btnCredInfMorosidad.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredInfMorosidad.Name = "btnCredInfMorosidad"
        Me.btnCredInfMorosidad.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredInfMorosidad.Text = "INFORME DE MOROSIDAD"
        Me.btnCredInfMorosidad.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredInfMorosidad.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredInfMorosidad.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCredInfMorosidad.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCredInfMorosidad.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredInfMorosidad.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredInfMorosidad.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredInfMorosidad.TitleTextColor = System.Drawing.Color.Red
        '
        'btnCredPagoCliente
        '
        Me.btnCredPagoCliente.Image = Global.DinoM.My.Resources.Resources.creditopagos
        Me.btnCredPagoCliente.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredPagoCliente.Name = "btnCredPagoCliente"
        Me.btnCredPagoCliente.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredPagoCliente.Text = "PAGOS POR CLIENTE"
        Me.btnCredPagoCliente.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredPagoCliente.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredPagoCliente.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredPagoCliente.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredPagoCliente.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredPagoCliente.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredPagoCliente.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredPagoCliente.TitleTextColor = System.Drawing.Color.Red
        '
        'btnCredPagoClienteVendedor
        '
        Me.btnCredPagoClienteVendedor.Image = Global.DinoM.My.Resources.Resources.creditopagos
        Me.btnCredPagoClienteVendedor.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredPagoClienteVendedor.Name = "btnCredPagoClienteVendedor"
        Me.btnCredPagoClienteVendedor.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredPagoClienteVendedor.Text = "PAGOS POR VENDEDOR"
        Me.btnCredPagoClienteVendedor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredPagoClienteVendedor.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredPagoClienteVendedor.TileStyle.BackColor = System.Drawing.Color.Gold
        Me.btnCredPagoClienteVendedor.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCredPagoClienteVendedor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredPagoClienteVendedor.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredPagoClienteVendedor.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredPagoClienteVendedor.TitleTextColor = System.Drawing.Color.Red
        '
        'btnCredPagoResumen
        '
        Me.btnCredPagoResumen.Image = Global.DinoM.My.Resources.Resources.hojaruta
        Me.btnCredPagoResumen.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCredPagoResumen.Name = "btnCredPagoResumen"
        Me.btnCredPagoResumen.SymbolColor = System.Drawing.Color.Empty
        Me.btnCredPagoResumen.Text = "REPORTE DE PAGOS"
        Me.btnCredPagoResumen.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btnCredPagoResumen.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btnCredPagoResumen.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCredPagoResumen.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCredPagoResumen.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btnCredPagoResumen.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredPagoResumen.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCredPagoResumen.TitleTextColor = System.Drawing.Color.Red
        '
        'SideNavPanel8
        '
        Me.SideNavPanel8.Controls.Add(Me.GroupPanel4)
        Me.SideNavPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel8.Location = New System.Drawing.Point(155, 36)
        Me.SideNavPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.SideNavPanel8.Name = "SideNavPanel8"
        Me.SideNavPanel8.Size = New System.Drawing.Size(843, 524)
        Me.SideNavPanel8.TabIndex = 190
        Me.SideNavPanel8.Visible = False
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.Panel5)
        Me.GroupPanel4.Controls.Add(Me.Panel3)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(843, 524)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 2
        Me.GroupPanel4.Text = "SALDO PRODUCTOS"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.grProductos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(837, 420)
        Me.Panel5.TabIndex = 0
        '
        'grProductos
        '
        Me.grProductos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grProductos.BackColor = System.Drawing.Color.GhostWhite
        Me.grProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grProductos.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grProductos.Location = New System.Drawing.Point(0, 0)
        Me.grProductos.Name = "grProductos"
        Me.grProductos.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.grProductos.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.grProductos.Size = New System.Drawing.Size(837, 420)
        Me.grProductos.TabIndex = 3
        Me.grProductos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnActualizar)
        Me.Panel3.Controls.Add(Me.btnReporte)
        Me.Panel3.Controls.Add(Me.btExcel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(837, 81)
        Me.Panel3.TabIndex = 4
        '
        'btnActualizar
        '
        Me.btnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnActualizar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Image = Global.DinoM.My.Resources.Resources.reload_5
        Me.btnActualizar.ImageFixedSize = New System.Drawing.Size(45, 50)
        Me.btnActualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnActualizar.Location = New System.Drawing.Point(158, 0)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnActualizar.Size = New System.Drawing.Size(79, 81)
        Me.btnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnActualizar.TabIndex = 12
        Me.btnActualizar.Text = "ACTUALIZAR"
        Me.btnActualizar.TextColor = System.Drawing.Color.White
        '
        'btnReporte
        '
        Me.btnReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btnReporte.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnReporte.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Image = Global.DinoM.My.Resources.Resources.printee
        Me.btnReporte.ImageFixedSize = New System.Drawing.Size(45, 50)
        Me.btnReporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnReporte.Location = New System.Drawing.Point(79, 0)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btnReporte.Size = New System.Drawing.Size(79, 81)
        Me.btnReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btnReporte.TabIndex = 11
        Me.btnReporte.Text = "IMPRIMIR"
        Me.btnReporte.TextColor = System.Drawing.Color.White
        '
        'btExcel
        '
        Me.btExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.btExcel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btExcel.Image = Global.DinoM.My.Resources.Resources.sheets
        Me.btExcel.ImageFixedSize = New System.Drawing.Size(45, 50)
        Me.btExcel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btExcel.Location = New System.Drawing.Point(0, 0)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.btExcel.Size = New System.Drawing.Size(79, 81)
        Me.btExcel.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014
        Me.btExcel.TabIndex = 10
        Me.btExcel.Text = "EXPORTAR"
        Me.btExcel.TextColor = System.Drawing.Color.White
        '
        'SideNavPanel5
        '
        Me.SideNavPanel5.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.SideNavPanel5.Controls.Add(Me.Panel1)
        Me.SideNavPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel5.Location = New System.Drawing.Point(155, 36)
        Me.SideNavPanel5.Name = "SideNavPanel5"
        Me.SideNavPanel5.Size = New System.Drawing.Size(844, 524)
        Me.SideNavPanel5.TabIndex = 87
        Me.SideNavPanel5.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.Panel1.Controls.Add(Me.MetroTilePanel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 524)
        Me.Panel1.TabIndex = 0
        '
        'MetroTilePanel6
        '
        Me.MetroTilePanel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel6.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel6.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel6.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel6.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel6.DragDropSupport = True
        Me.MetroTilePanel6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btInvDeposito, Me.btInvAmacen, Me.btInvMovimiento, Me.btInvKardex, Me.btInvSaldo, Me.btInvKardexReporte, Me.btInvUtilidad, Me.btInvSaldoLote, Me.btlvSaldoMinimo, Me.btInvVentas})
        Me.MetroTilePanel6.ItemSpacing = 10
        Me.MetroTilePanel6.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel6.MultiLine = True
        Me.MetroTilePanel6.Name = "MetroTilePanel6"
        Me.MetroTilePanel6.Size = New System.Drawing.Size(844, 524)
        Me.MetroTilePanel6.TabIndex = 2
        Me.MetroTilePanel6.Text = "mtp2Logistica"
        '
        'btInvDeposito
        '
        Me.btInvDeposito.Image = CType(resources.GetObject("btInvDeposito.Image"), System.Drawing.Image)
        Me.btInvDeposito.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvDeposito.Name = "btInvDeposito"
        Me.btInvDeposito.SymbolColor = System.Drawing.Color.Empty
        Me.btInvDeposito.Text = "DEPOSITO"
        Me.btInvDeposito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvDeposito.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvDeposito.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btInvDeposito.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btInvDeposito.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvDeposito.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvDeposito.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvDeposito.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvAmacen
        '
        Me.btInvAmacen.Image = Global.DinoM.My.Resources.Resources.almacen
        Me.btInvAmacen.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvAmacen.Name = "btInvAmacen"
        Me.btInvAmacen.SymbolColor = System.Drawing.Color.Empty
        Me.btInvAmacen.Text = "ALMACEN"
        Me.btInvAmacen.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvAmacen.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvAmacen.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btInvAmacen.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btInvAmacen.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvAmacen.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvAmacen.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvAmacen.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvMovimiento
        '
        Me.btInvMovimiento.Image = CType(resources.GetObject("btInvMovimiento.Image"), System.Drawing.Image)
        Me.btInvMovimiento.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvMovimiento.Name = "btInvMovimiento"
        Me.btInvMovimiento.SymbolColor = System.Drawing.Color.Empty
        Me.btInvMovimiento.Text = "MOVIMIENTOS"
        Me.btInvMovimiento.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvMovimiento.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvMovimiento.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btInvMovimiento.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btInvMovimiento.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvMovimiento.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvMovimiento.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvMovimiento.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvKardex
        '
        Me.btInvKardex.Image = Global.DinoM.My.Resources.Resources.movimiento
        Me.btInvKardex.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvKardex.Name = "btInvKardex"
        Me.btInvKardex.SymbolColor = System.Drawing.Color.Empty
        Me.btInvKardex.Text = "KARDEX DE PRODUCTO"
        Me.btInvKardex.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvKardex.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvKardex.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btInvKardex.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btInvKardex.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvKardex.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvKardex.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvKardex.TitleTextColor = System.Drawing.Color.Red
        Me.btInvKardex.TitleTextFont = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btInvSaldo
        '
        Me.btInvSaldo.Image = CType(resources.GetObject("btInvSaldo.Image"), System.Drawing.Image)
        Me.btInvSaldo.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvSaldo.Name = "btInvSaldo"
        Me.btInvSaldo.SymbolColor = System.Drawing.Color.Empty
        Me.btInvSaldo.Text = "SALDO DE PRODUCTOS"
        Me.btInvSaldo.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvSaldo.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvSaldo.TileStyle.BackColor = System.Drawing.Color.Gold
        Me.btInvSaldo.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btInvSaldo.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvSaldo.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvSaldo.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvSaldo.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvKardexReporte
        '
        Me.btInvKardexReporte.Image = Global.DinoM.My.Resources.Resources._14
        Me.btInvKardexReporte.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvKardexReporte.Name = "btInvKardexReporte"
        Me.btInvKardexReporte.SymbolColor = System.Drawing.Color.Empty
        Me.btInvKardexReporte.Text = "REPORTE KARDEX PRODUCTO"
        Me.btInvKardexReporte.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvKardexReporte.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvKardexReporte.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btInvKardexReporte.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btInvKardexReporte.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvKardexReporte.TileStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvKardexReporte.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvKardexReporte.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvUtilidad
        '
        Me.btInvUtilidad.Image = Global.DinoM.My.Resources.Resources.rp_estadoCuentas
        Me.btInvUtilidad.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvUtilidad.Name = "btInvUtilidad"
        Me.btInvUtilidad.SymbolColor = System.Drawing.Color.Empty
        Me.btInvUtilidad.Text = "SALDOS VALORADOS"
        Me.btInvUtilidad.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvUtilidad.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvUtilidad.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btInvUtilidad.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btInvUtilidad.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvUtilidad.TileStyle.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvUtilidad.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvUtilidad.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvSaldoLote
        '
        Me.btInvSaldoLote.Image = CType(resources.GetObject("btInvSaldoLote.Image"), System.Drawing.Image)
        Me.btInvSaldoLote.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvSaldoLote.Name = "btInvSaldoLote"
        Me.btInvSaldoLote.SymbolColor = System.Drawing.Color.Empty
        Me.btInvSaldoLote.Text = "SALDO POR LOTES"
        Me.btInvSaldoLote.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvSaldoLote.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvSaldoLote.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btInvSaldoLote.TileStyle.BackColor2 = System.Drawing.Color.DarkGreen
        Me.btInvSaldoLote.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvSaldoLote.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvSaldoLote.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvSaldoLote.TitleTextColor = System.Drawing.Color.Red
        '
        'btlvSaldoMinimo
        '
        Me.btlvSaldoMinimo.Image = CType(resources.GetObject("btlvSaldoMinimo.Image"), System.Drawing.Image)
        Me.btlvSaldoMinimo.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btlvSaldoMinimo.Name = "btlvSaldoMinimo"
        Me.btlvSaldoMinimo.SymbolColor = System.Drawing.Color.Empty
        Me.btlvSaldoMinimo.Text = "SALDO MINIMO"
        Me.btlvSaldoMinimo.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btlvSaldoMinimo.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btlvSaldoMinimo.TileStyle.BackColor = System.Drawing.Color.Gold
        Me.btlvSaldoMinimo.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btlvSaldoMinimo.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btlvSaldoMinimo.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btlvSaldoMinimo.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btlvSaldoMinimo.TitleTextColor = System.Drawing.Color.Red
        '
        'btInvVentas
        '
        Me.btInvVentas.Image = CType(resources.GetObject("btInvVentas.Image"), System.Drawing.Image)
        Me.btInvVentas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btInvVentas.Name = "btInvVentas"
        Me.btInvVentas.SymbolColor = System.Drawing.Color.Empty
        Me.btInvVentas.Text = "VENTAS"
        Me.btInvVentas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btInvVentas.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btInvVentas.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btInvVentas.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btInvVentas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btInvVentas.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInvVentas.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btInvVentas.TitleTextColor = System.Drawing.Color.Red
        '
        'SideNavPanel6
        '
        Me.SideNavPanel6.Controls.Add(Me.Panel2)
        Me.SideNavPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel6.Location = New System.Drawing.Point(155, 36)
        Me.SideNavPanel6.Name = "SideNavPanel6"
        Me.SideNavPanel6.Size = New System.Drawing.Size(844, 524)
        Me.SideNavPanel6.TabIndex = 109
        Me.SideNavPanel6.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.Panel2.Controls.Add(Me.MetroTilePanel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 524)
        Me.Panel2.TabIndex = 1
        '
        'MetroTilePanel7
        '
        Me.MetroTilePanel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel7.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel7.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel7.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel7.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel7.DragDropSupport = True
        Me.MetroTilePanel7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btComProveedor, Me.btComCompra, Me.btComPagosCredito, Me.MetroTileItem21, Me.MetroTileItem22, Me.MetroTileItem23})
        Me.MetroTilePanel7.ItemSpacing = 10
        Me.MetroTilePanel7.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel7.MultiLine = True
        Me.MetroTilePanel7.Name = "MetroTilePanel7"
        Me.MetroTilePanel7.Size = New System.Drawing.Size(844, 524)
        Me.MetroTilePanel7.TabIndex = 2
        Me.MetroTilePanel7.Text = "mtp2Logistica"
        '
        'btComProveedor
        '
        Me.btComProveedor.Image = Global.DinoM.My.Resources.Resources.user
        Me.btComProveedor.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btComProveedor.Name = "btComProveedor"
        Me.btComProveedor.SymbolColor = System.Drawing.Color.Empty
        Me.btComProveedor.Text = "PROVEEDOR"
        Me.btComProveedor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btComProveedor.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btComProveedor.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btComProveedor.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btComProveedor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btComProveedor.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComProveedor.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btComProveedor.TitleTextColor = System.Drawing.Color.Red
        '
        'btComCompra
        '
        Me.btComCompra.Image = CType(resources.GetObject("btComCompra.Image"), System.Drawing.Image)
        Me.btComCompra.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btComCompra.Name = "btComCompra"
        Me.btComCompra.SymbolColor = System.Drawing.Color.Empty
        Me.btComCompra.Text = "COMPRA"
        Me.btComCompra.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btComCompra.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btComCompra.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btComCompra.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btComCompra.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btComCompra.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComCompra.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btComCompra.TitleTextColor = System.Drawing.Color.Red
        '
        'btComPagosCredito
        '
        Me.btComPagosCredito.Image = Global.DinoM.My.Resources.Resources.precio
        Me.btComPagosCredito.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btComPagosCredito.Name = "btComPagosCredito"
        Me.btComPagosCredito.SymbolColor = System.Drawing.Color.Empty
        Me.btComPagosCredito.Text = "PAGOS COMPRA CREDITOS"
        Me.btComPagosCredito.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btComPagosCredito.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btComPagosCredito.TileStyle.BackColor = System.Drawing.Color.Blue
        Me.btComPagosCredito.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btComPagosCredito.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btComPagosCredito.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComPagosCredito.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btComPagosCredito.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem21
        '
        Me.MetroTileItem21.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem21.Name = "MetroTileItem21"
        Me.MetroTileItem21.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem21.Text = "BONOS / DECUENTOS"
        Me.MetroTileItem21.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem21.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem21.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem21.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem21.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem22
        '
        Me.MetroTileItem22.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem22.Name = "MetroTileItem22"
        Me.MetroTileItem22.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem22.Text = "REPORTE PLANILLA DE SUELDOS"
        Me.MetroTileItem22.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem22.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem22.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem22.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem22.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem23
        '
        Me.MetroTileItem23.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem23.Name = "MetroTileItem23"
        Me.MetroTileItem23.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem23.Text = "PEDIDO DE VACACION"
        Me.MetroTileItem23.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem23.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem23.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem23.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem23.TitleTextColor = System.Drawing.Color.Red
        '
        'SideNav_Logistica
        '
        Me.SideNav_Logistica.BackColor = System.Drawing.Color.White
        Me.SideNav_Logistica.Controls.Add(Me.MetroTilePanel2)
        Me.SideNav_Logistica.Controls.Add(Me.PictureBox3)
        Me.SideNav_Logistica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav_Logistica.Location = New System.Drawing.Point(155, 36)
        Me.SideNav_Logistica.Name = "SideNav_Logistica"
        Me.SideNav_Logistica.Size = New System.Drawing.Size(843, 524)
        Me.SideNav_Logistica.TabIndex = 6
        Me.SideNav_Logistica.Visible = False
        '
        'MetroTilePanel2
        '
        Me.MetroTilePanel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel2.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel2.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel2.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel2.DragDropSupport = True
        Me.MetroTilePanel2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btZonas, Me.btZonaMapaCliente, Me.btZonaReporteRuta, Me.btRHAntigueVacaciones, Me.btRHBonosDesc, Me.btRHRepPlanillaSueldos, Me.btRHPedidoVacacion})
        Me.MetroTilePanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel2.MultiLine = True
        Me.MetroTilePanel2.Name = "MetroTilePanel2"
        Me.MetroTilePanel2.Size = New System.Drawing.Size(843, 410)
        Me.MetroTilePanel2.TabIndex = 1
        Me.MetroTilePanel2.Text = "mtp2Logistica"
        '
        'btZonas
        '
        Me.btZonas.Image = Global.DinoM.My.Resources.Resources.zona
        Me.btZonas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btZonas.Name = "btZonas"
        Me.btZonas.SymbolColor = System.Drawing.Color.Empty
        Me.btZonas.Text = "ZONAS"
        Me.btZonas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btZonas.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btZonas.TileStyle.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btZonas.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btZonas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btZonas.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btZonas.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btZonas.TitleTextColor = System.Drawing.Color.Red
        '
        'btZonaMapaCliente
        '
        Me.btZonaMapaCliente.Image = Global.DinoM.My.Resources.Resources.MapaClientes
        Me.btZonaMapaCliente.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btZonaMapaCliente.Name = "btZonaMapaCliente"
        Me.btZonaMapaCliente.SymbolColor = System.Drawing.Color.Empty
        Me.btZonaMapaCliente.Text = "MAPA CLIENTES"
        Me.btZonaMapaCliente.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btZonaMapaCliente.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btZonaMapaCliente.TileStyle.BackColor = System.Drawing.Color.Blue
        Me.btZonaMapaCliente.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btZonaMapaCliente.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btZonaMapaCliente.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btZonaMapaCliente.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btZonaMapaCliente.TitleTextColor = System.Drawing.Color.Red
        '
        'btZonaReporteRuta
        '
        Me.btZonaReporteRuta.Image = Global.DinoM.My.Resources.Resources.hojaruta
        Me.btZonaReporteRuta.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btZonaReporteRuta.Name = "btZonaReporteRuta"
        Me.btZonaReporteRuta.SymbolColor = System.Drawing.Color.Empty
        Me.btZonaReporteRuta.Text = "REPORTE HOJA DE RUTA"
        Me.btZonaReporteRuta.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btZonaReporteRuta.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btZonaReporteRuta.TileStyle.BackColor = System.Drawing.Color.Red
        Me.btZonaReporteRuta.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btZonaReporteRuta.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btZonaReporteRuta.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btZonaReporteRuta.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btZonaReporteRuta.TitleTextColor = System.Drawing.Color.Red
        '
        'btRHAntigueVacaciones
        '
        Me.btRHAntigueVacaciones.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btRHAntigueVacaciones.Name = "btRHAntigueVacaciones"
        Me.btRHAntigueVacaciones.SymbolColor = System.Drawing.Color.Empty
        Me.btRHAntigueVacaciones.Text = "BONOS ANTIGUEDAD Y VACACIONES"
        Me.btRHAntigueVacaciones.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btRHAntigueVacaciones.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btRHAntigueVacaciones.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btRHAntigueVacaciones.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btRHAntigueVacaciones.TitleTextColor = System.Drawing.Color.Red
        '
        'btRHBonosDesc
        '
        Me.btRHBonosDesc.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btRHBonosDesc.Name = "btRHBonosDesc"
        Me.btRHBonosDesc.SymbolColor = System.Drawing.Color.Empty
        Me.btRHBonosDesc.Text = "BONOS / DECUENTOS"
        Me.btRHBonosDesc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btRHBonosDesc.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btRHBonosDesc.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btRHBonosDesc.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btRHBonosDesc.TitleTextColor = System.Drawing.Color.Red
        '
        'btRHRepPlanillaSueldos
        '
        Me.btRHRepPlanillaSueldos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btRHRepPlanillaSueldos.Name = "btRHRepPlanillaSueldos"
        Me.btRHRepPlanillaSueldos.SymbolColor = System.Drawing.Color.Empty
        Me.btRHRepPlanillaSueldos.Text = "REPORTE PLANILLA DE SUELDOS"
        Me.btRHRepPlanillaSueldos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btRHRepPlanillaSueldos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btRHRepPlanillaSueldos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btRHRepPlanillaSueldos.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btRHRepPlanillaSueldos.TitleTextColor = System.Drawing.Color.Red
        '
        'btRHPedidoVacacion
        '
        Me.btRHPedidoVacacion.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btRHPedidoVacacion.Name = "btRHPedidoVacacion"
        Me.btRHPedidoVacacion.SymbolColor = System.Drawing.Color.Empty
        Me.btRHPedidoVacacion.Text = "PEDIDO DE VACACION"
        Me.btRHPedidoVacacion.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btRHPedidoVacacion.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btRHPedidoVacacion.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btRHPedidoVacacion.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btRHPedidoVacacion.TitleTextColor = System.Drawing.Color.Red
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3.Location = New System.Drawing.Point(0, 410)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(843, 114)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'SideNav_Conf
        '
        Me.SideNav_Conf.Controls.Add(Me.MetroTilePanel1)
        Me.SideNav_Conf.Controls.Add(Me.PictureBox4)
        Me.SideNav_Conf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav_Conf.Location = New System.Drawing.Point(155, 36)
        Me.SideNav_Conf.Name = "SideNav_Conf"
        Me.SideNav_Conf.Size = New System.Drawing.Size(843, 524)
        Me.SideNav_Conf.TabIndex = 2
        Me.SideNav_Conf.Visible = False
        '
        'MetroTilePanel1
        '
        Me.MetroTilePanel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel1.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel1.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel1.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel1.DragDropSupport = True
        Me.MetroTilePanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTilePanel1.ForeColor = System.Drawing.Color.White
        Me.MetroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btConfRoles, Me.btConfUsuarios, Me.btConfCliente, Me.btConfProducto, Me.btConfPrecio, Me.btConfLibreria, Me.btConfDosificacion, Me.btConfRepCliente, Me.btRepClientes})
        Me.MetroTilePanel1.ItemSpacing = 10
        Me.MetroTilePanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel1.MultiLine = True
        Me.MetroTilePanel1.Name = "MetroTilePanel1"
        Me.MetroTilePanel1.Size = New System.Drawing.Size(843, 431)
        Me.MetroTilePanel1.TabIndex = 0
        Me.MetroTilePanel1.Text = "mtp1Configuracion"
        '
        'btConfRoles
        '
        Me.btConfRoles.Image = Global.DinoM.My.Resources.Resources.ROLES
        Me.btConfRoles.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfRoles.Name = "btConfRoles"
        Me.btConfRoles.SymbolColor = System.Drawing.Color.Black
        Me.btConfRoles.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfRoles.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfRoles.TileStyle.BackColor = System.Drawing.Color.MediumVioletRed
        Me.btConfRoles.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConfRoles.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfRoles.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConfRoles.TitleText = "ROLES"
        Me.btConfRoles.TitleTextColor = System.Drawing.Color.White
        '
        'btConfUsuarios
        '
        Me.btConfUsuarios.Image = Global.DinoM.My.Resources.Resources.user
        Me.btConfUsuarios.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfUsuarios.Name = "btConfUsuarios"
        Me.btConfUsuarios.SymbolColor = System.Drawing.Color.Empty
        Me.btConfUsuarios.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfUsuarios.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfUsuarios.TileStyle.BackColor = System.Drawing.Color.MediumOrchid
        Me.btConfUsuarios.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btConfUsuarios.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfUsuarios.TitleText = "USUARIOS"
        '
        'btConfCliente
        '
        Me.btConfCliente.Image = Global.DinoM.My.Resources.Resources.cliente
        Me.btConfCliente.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfCliente.Name = "btConfCliente"
        Me.btConfCliente.SymbolColor = System.Drawing.Color.Empty
        Me.btConfCliente.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfCliente.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfCliente.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btConfCliente.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btConfCliente.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfCliente.TitleText = "CLIENTES"
        '
        'btConfProducto
        '
        Me.btConfProducto.Image = Global.DinoM.My.Resources.Resources.producto
        Me.btConfProducto.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfProducto.Name = "btConfProducto"
        Me.btConfProducto.SymbolColor = System.Drawing.Color.Empty
        Me.btConfProducto.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfProducto.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfProducto.TileStyle.BackColor = System.Drawing.Color.Crimson
        Me.btConfProducto.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.btConfProducto.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfProducto.TitleText = "PRODUCTOS"
        '
        'btConfPrecio
        '
        Me.btConfPrecio.Image = Global.DinoM.My.Resources.Resources.precio
        Me.btConfPrecio.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfPrecio.Name = "btConfPrecio"
        Me.btConfPrecio.SymbolColor = System.Drawing.Color.Empty
        Me.btConfPrecio.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfPrecio.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfPrecio.TileStyle.BackColor = System.Drawing.Color.Magenta
        Me.btConfPrecio.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConfPrecio.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfPrecio.TitleText = "PRECIOS"
        '
        'btConfLibreria
        '
        Me.btConfLibreria.Image = Global.DinoM.My.Resources.Resources.check_mark
        Me.btConfLibreria.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfLibreria.Name = "btConfLibreria"
        Me.btConfLibreria.SymbolColor = System.Drawing.Color.Empty
        Me.btConfLibreria.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfLibreria.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfLibreria.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConfLibreria.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btConfLibreria.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfLibreria.TitleText = "LIBRERIA"
        '
        'btConfDosificacion
        '
        Me.btConfDosificacion.Image = CType(resources.GetObject("btConfDosificacion.Image"), System.Drawing.Image)
        Me.btConfDosificacion.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfDosificacion.Name = "btConfDosificacion"
        Me.btConfDosificacion.SymbolColor = System.Drawing.Color.Empty
        Me.btConfDosificacion.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfDosificacion.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfDosificacion.TileStyle.BackColor = System.Drawing.Color.Green
        Me.btConfDosificacion.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btConfDosificacion.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btConfDosificacion.TitleText = "DOSIFICACIÓN"
        '
        'btConfRepCliente
        '
        Me.btConfRepCliente.Image = Global.DinoM.My.Resources.Resources.check_mark
        Me.btConfRepCliente.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btConfRepCliente.Name = "btConfRepCliente"
        Me.btConfRepCliente.SymbolColor = System.Drawing.Color.Empty
        Me.btConfRepCliente.Text = "REPORTE CLIENTE"
        Me.btConfRepCliente.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btConfRepCliente.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btConfRepCliente.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btConfRepCliente.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btConfRepCliente.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'btRepClientes
        '
        Me.btRepClientes.Image = Global.DinoM.My.Resources.Resources.check_mark
        Me.btRepClientes.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btRepClientes.Name = "btRepClientes"
        Me.btRepClientes.SymbolColor = System.Drawing.Color.Empty
        Me.btRepClientes.Text = "REPORTE  DETALLADO CLIENTES"
        Me.btRepClientes.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btRepClientes.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btRepClientes.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btRepClientes.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.btRepClientes.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox4.Location = New System.Drawing.Point(0, 431)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(843, 93)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'SideNav_Ventas
        '
        Me.SideNav_Ventas.Controls.Add(Me.PanelVentas)
        Me.SideNav_Ventas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNav_Ventas.Location = New System.Drawing.Point(155, 36)
        Me.SideNav_Ventas.Name = "SideNav_Ventas"
        Me.SideNav_Ventas.Size = New System.Drawing.Size(843, 524)
        Me.SideNav_Ventas.TabIndex = 134
        Me.SideNav_Ventas.Visible = False
        '
        'PanelVentas
        '
        Me.PanelVentas.Controls.Add(Me.MetroTilePanelVentas)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVentas.Location = New System.Drawing.Point(0, 0)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(843, 524)
        Me.PanelVentas.TabIndex = 0
        '
        'MetroTilePanelVentas
        '
        Me.MetroTilePanelVentas.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanelVentas.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanelVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanelVentas.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanelVentas.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanelVentas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanelVentas.ContainerControlProcessDialogKey = True
        Me.MetroTilePanelVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanelVentas.DragDropSupport = True
        Me.MetroTilePanelVentas.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btVentVenta, Me.btVentFactura, Me.btVentAnularFactura, Me.btVentLibroVenta, Me.btVentReporteAtendidas, Me.btVentReporteVentaVsCosto, Me.btVentReporteProducto, Me.btVentGrafica, Me.btVentRotProd, Me.btComVendedor, Me.btVentEstad, Me.btVentDescuento})
        Me.MetroTilePanelVentas.ItemSpacing = 10
        Me.MetroTilePanelVentas.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanelVentas.MultiLine = True
        Me.MetroTilePanelVentas.Name = "MetroTilePanelVentas"
        Me.MetroTilePanelVentas.Size = New System.Drawing.Size(843, 524)
        Me.MetroTilePanelVentas.TabIndex = 3
        Me.MetroTilePanelVentas.Text = "mtp2Logistica"
        '
        'btVentVenta
        '
        Me.btVentVenta.Image = CType(resources.GetObject("btVentVenta.Image"), System.Drawing.Image)
        Me.btVentVenta.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentVenta.Name = "btVentVenta"
        Me.btVentVenta.SymbolColor = System.Drawing.Color.Empty
        Me.btVentVenta.Text = "DESPACHO"
        Me.btVentVenta.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentVenta.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentVenta.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btVentVenta.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentVenta.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentVenta.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentVenta.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentVenta.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentFactura
        '
        Me.btVentFactura.Image = Global.DinoM.My.Resources.Resources.facturacion
        Me.btVentFactura.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentFactura.Name = "btVentFactura"
        Me.btVentFactura.SymbolColor = System.Drawing.Color.Empty
        Me.btVentFactura.Text = "FACTURACION"
        Me.btVentFactura.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentFactura.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentFactura.TileStyle.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btVentFactura.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentFactura.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentFactura.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentFactura.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentFactura.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentAnularFactura
        '
        Me.btVentAnularFactura.Image = CType(resources.GetObject("btVentAnularFactura.Image"), System.Drawing.Image)
        Me.btVentAnularFactura.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentAnularFactura.Name = "btVentAnularFactura"
        Me.btVentAnularFactura.SymbolColor = System.Drawing.Color.Empty
        Me.btVentAnularFactura.Text = "ANULAR FACTURA"
        Me.btVentAnularFactura.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentAnularFactura.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentAnularFactura.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentAnularFactura.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentAnularFactura.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentAnularFactura.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentAnularFactura.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentAnularFactura.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentLibroVenta
        '
        Me.btVentLibroVenta.Image = CType(resources.GetObject("btVentLibroVenta.Image"), System.Drawing.Image)
        Me.btVentLibroVenta.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentLibroVenta.Name = "btVentLibroVenta"
        Me.btVentLibroVenta.SymbolColor = System.Drawing.Color.Empty
        Me.btVentLibroVenta.Text = "LIBRO DE  VENTA"
        Me.btVentLibroVenta.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentLibroVenta.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentLibroVenta.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btVentLibroVenta.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btVentLibroVenta.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentLibroVenta.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentLibroVenta.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentLibroVenta.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentReporteAtendidas
        '
        Me.btVentReporteAtendidas.Image = Global.DinoM.My.Resources.Resources.check_mark
        Me.btVentReporteAtendidas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentReporteAtendidas.Name = "btVentReporteAtendidas"
        Me.btVentReporteAtendidas.SymbolColor = System.Drawing.Color.Empty
        Me.btVentReporteAtendidas.Text = "REPORTE VENTAS"
        Me.btVentReporteAtendidas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentReporteAtendidas.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentReporteAtendidas.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btVentReporteAtendidas.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentReporteAtendidas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentReporteAtendidas.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentReporteAtendidas.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentReporteAtendidas.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentReporteVentaVsCosto
        '
        Me.btVentReporteVentaVsCosto.Image = Global.DinoM.My.Resources.Resources.ventasCostos
        Me.btVentReporteVentaVsCosto.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentReporteVentaVsCosto.Name = "btVentReporteVentaVsCosto"
        Me.btVentReporteVentaVsCosto.SymbolColor = System.Drawing.Color.Empty
        Me.btVentReporteVentaVsCosto.Text = "REPORTE VENTAS Y COSTOS"
        Me.btVentReporteVentaVsCosto.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentReporteVentaVsCosto.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentReporteVentaVsCosto.TileStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.btVentReporteVentaVsCosto.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentReporteVentaVsCosto.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentReporteVentaVsCosto.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentReporteVentaVsCosto.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentReporteVentaVsCosto.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentReporteProducto
        '
        Me.btVentReporteProducto.Image = Global.DinoM.My.Resources.Resources.FormatFactoryunnamed
        Me.btVentReporteProducto.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentReporteProducto.Name = "btVentReporteProducto"
        Me.btVentReporteProducto.SymbolColor = System.Drawing.Color.Empty
        Me.btVentReporteProducto.Text = "REPORTE PRODUCTOS"
        Me.btVentReporteProducto.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentReporteProducto.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentReporteProducto.TileStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentReporteProducto.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btVentReporteProducto.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentReporteProducto.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentReporteProducto.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentReporteProducto.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentGrafica
        '
        Me.btVentGrafica.Image = Global.DinoM.My.Resources.Resources.grafica
        Me.btVentGrafica.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentGrafica.Name = "btVentGrafica"
        Me.btVentGrafica.SymbolColor = System.Drawing.Color.Empty
        Me.btVentGrafica.Text = "REPORTE GRAFICO VENTA"
        Me.btVentGrafica.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentGrafica.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentGrafica.TileStyle.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btVentGrafica.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentGrafica.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentGrafica.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentGrafica.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentGrafica.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentRotProd
        '
        Me.btVentRotProd.Image = Global.DinoM.My.Resources.Resources.rotacionproducto
        Me.btVentRotProd.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentRotProd.Name = "btVentRotProd"
        Me.btVentRotProd.SymbolColor = System.Drawing.Color.Empty
        Me.btVentRotProd.Text = "ROTACION DE PRODUCTOS"
        Me.btVentRotProd.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentRotProd.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentRotProd.TileStyle.BackColor = System.Drawing.Color.Crimson
        Me.btVentRotProd.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btVentRotProd.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentRotProd.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentRotProd.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentRotProd.TitleTextColor = System.Drawing.Color.Red
        '
        'btComVendedor
        '
        Me.btComVendedor.Image = Global.DinoM.My.Resources.Resources.vendedor
        Me.btComVendedor.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btComVendedor.Name = "btComVendedor"
        Me.btComVendedor.SymbolColor = System.Drawing.Color.Empty
        Me.btComVendedor.Text = "VENDEDOR"
        Me.btComVendedor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btComVendedor.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btComVendedor.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btComVendedor.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btComVendedor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btComVendedor.TileStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComVendedor.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btComVendedor.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentEstad
        '
        Me.btVentEstad.Image = Global.DinoM.My.Resources.Resources.estadistico
        Me.btVentEstad.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentEstad.Name = "btVentEstad"
        Me.btVentEstad.SymbolColor = System.Drawing.Color.Empty
        Me.btVentEstad.Text = "REPORTE ESTADISTICO VENTA"
        Me.btVentEstad.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentEstad.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentEstad.TileStyle.BackColor = System.Drawing.Color.Crimson
        Me.btVentEstad.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btVentEstad.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentEstad.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentEstad.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentEstad.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentDescuento
        '
        Me.btVentDescuento.Image = CType(resources.GetObject("btVentDescuento.Image"), System.Drawing.Image)
        Me.btVentDescuento.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentDescuento.Name = "btVentDescuento"
        Me.btVentDescuento.SymbolColor = System.Drawing.Color.Empty
        Me.btVentDescuento.Text = "DESCUENTOS"
        Me.btVentDescuento.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentDescuento.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentDescuento.TileStyle.BackColor = System.Drawing.SystemColors.Highlight
        Me.btVentDescuento.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btVentDescuento.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentDescuento.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVentDescuento.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btVentDescuento.TitleTextColor = System.Drawing.Color.Red
        '
        'SideNavPanel3
        '
        Me.SideNavPanel3.Controls.Add(Me.superTabControl3)
        Me.SideNavPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel3.Location = New System.Drawing.Point(106, 29)
        Me.SideNavPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.SideNavPanel3.Name = "SideNavPanel3"
        Me.SideNavPanel3.Size = New System.Drawing.Size(642, 426)
        Me.SideNavPanel3.TabIndex = 73
        Me.SideNavPanel3.Visible = False
        '
        'superTabControl3
        '
        Me.superTabControl3.CloseButtonOnTabsAlwaysDisplayed = False
        Me.superTabControl3.CloseButtonOnTabsVisible = True
        '
        '
        '
        '
        '
        '
        Me.superTabControl3.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.superTabControl3.ControlBox.MenuBox.Name = ""
        Me.superTabControl3.ControlBox.Name = ""
        Me.superTabControl3.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl3.ControlBox.MenuBox, Me.superTabControl3.ControlBox.CloseBox})
        Me.superTabControl3.Controls.Add(Me.PanelPrincipal)
        Me.superTabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.superTabControl3.Location = New System.Drawing.Point(0, 0)
        Me.superTabControl3.Margin = New System.Windows.Forms.Padding(2)
        Me.superTabControl3.Name = "superTabControl3"
        Me.superTabControl3.ReorderTabsEnabled = True
        Me.superTabControl3.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.superTabControl3.SelectedTabIndex = -1
        Me.superTabControl3.Size = New System.Drawing.Size(642, 426)
        Me.superTabControl3.TabFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.superTabControl3.TabIndex = 5
        Me.superTabControl3.TabVerticalSpacing = 3
        Me.superTabControl3.Text = "superTabControl3"
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(642, 426)
        Me.PanelPrincipal.TabIndex = 1
        '
        'SideNavPanel4
        '
        Me.SideNavPanel4.Controls.Add(Me.MetroTilePanel5)
        Me.SideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel4.Location = New System.Drawing.Point(142, 36)
        Me.SideNavPanel4.Name = "SideNavPanel4"
        Me.SideNavPanel4.Size = New System.Drawing.Size(856, 524)
        Me.SideNavPanel4.TabIndex = 77
        Me.SideNavPanel4.Visible = False
        '
        'MetroTilePanel5
        '
        Me.MetroTilePanel5.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel5.BackgroundImage = Global.DinoM.My.Resources.Resources.fondoInfo
        Me.MetroTilePanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel5.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel5.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel5.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel5.DragDropSupport = True
        Me.MetroTilePanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTilePanel5.ForeColor = System.Drawing.Color.White
        Me.MetroTilePanel5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItem1, Me.MetroTileItem2, Me.MetroTileItem3, Me.MetroTileItem9, Me.MetroTileItem10})
        Me.MetroTilePanel5.ItemSpacing = 10
        Me.MetroTilePanel5.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel5.MultiLine = True
        Me.MetroTilePanel5.Name = "MetroTilePanel5"
        Me.MetroTilePanel5.Size = New System.Drawing.Size(856, 524)
        Me.MetroTilePanel5.TabIndex = 1
        Me.MetroTilePanel5.Text = "mtp1Configuracion"
        '
        'MetroTileItem1
        '
        Me.MetroTileItem1.Image = Global.DinoM.My.Resources.Resources.ROLES
        Me.MetroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem1.Name = "MetroTileItem1"
        Me.MetroTileItem1.SymbolColor = System.Drawing.Color.Black
        Me.MetroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem1.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem1.TileStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTileItem1.TileStyle.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.MetroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem1.TileStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroTileItem1.TitleText = "ROLES"
        Me.MetroTileItem1.TitleTextColor = System.Drawing.Color.White
        '
        'MetroTileItem2
        '
        Me.MetroTileItem2.Image = Global.DinoM.My.Resources.Resources.user
        Me.MetroTileItem2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem2.Name = "MetroTileItem2"
        Me.MetroTileItem2.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem2.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem2.TileStyle.BackColor = System.Drawing.Color.MediumOrchid
        Me.MetroTileItem2.TileStyle.BackColor2 = System.Drawing.Color.Aqua
        Me.MetroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem2.TitleText = "USUARIOS"
        '
        'MetroTileItem3
        '
        Me.MetroTileItem3.Image = Global.DinoM.My.Resources.Resources.cliente
        Me.MetroTileItem3.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem3.Name = "MetroTileItem3"
        Me.MetroTileItem3.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem3.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem3.TileStyle.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MetroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem3.TitleText = "CLIENTES"
        '
        'MetroTileItem9
        '
        Me.MetroTileItem9.Image = Global.DinoM.My.Resources.Resources.producto
        Me.MetroTileItem9.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem9.Name = "MetroTileItem9"
        Me.MetroTileItem9.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem9.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem9.TileStyle.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MetroTileItem9.TileStyle.BackColor2 = System.Drawing.Color.DeepSkyBlue
        Me.MetroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem9.TitleText = "PRODUCTOS"
        '
        'MetroTileItem10
        '
        Me.MetroTileItem10.Image = Global.DinoM.My.Resources.Resources.precio
        Me.MetroTileItem10.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem10.Name = "MetroTileItem10"
        Me.MetroTileItem10.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem10.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem10.TileStyle.BackColor = System.Drawing.Color.Magenta
        Me.MetroTileItem10.TileStyle.BackColor2 = System.Drawing.Color.DodgerBlue
        Me.MetroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem10.TitleText = "PRECIOS"
        '
        'SideNavPanel1
        '
        Me.SideNavPanel1.Controls.Add(Me.MetroTilePanel4)
        Me.SideNavPanel1.Controls.Add(Me.PictureBox1)
        Me.SideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel1.Location = New System.Drawing.Point(-24604, 26469)
        Me.SideNavPanel1.Name = "SideNavPanel1"
        Me.SideNavPanel1.Size = New System.Drawing.Size(609, 524)
        Me.SideNavPanel1.TabIndex = 66
        Me.SideNavPanel1.Visible = False
        '
        'MetroTilePanel4
        '
        Me.MetroTilePanel4.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel4.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel4.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel4.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel4.DragDropSupport = True
        Me.MetroTilePanel4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btSocSocio, Me.btSocPagos, Me.ItemContainer2})
        Me.MetroTilePanel4.ItemSpacing = 10
        Me.MetroTilePanel4.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel4.MultiLine = True
        Me.MetroTilePanel4.Name = "MetroTilePanel4"
        Me.MetroTilePanel4.Size = New System.Drawing.Size(609, 410)
        Me.MetroTilePanel4.TabIndex = 2
        Me.MetroTilePanel4.Text = "mtp2Logistica"
        '
        'btSocSocio
        '
        Me.btSocSocio.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocSocio.Name = "btSocSocio"
        Me.btSocSocio.SymbolColor = System.Drawing.Color.Empty
        Me.btSocSocio.Text = "SOCIO"
        Me.btSocSocio.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocSocio.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocSocio.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocSocio.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btSocSocio.TitleTextColor = System.Drawing.Color.Red
        '
        'btSocPagos
        '
        Me.btSocPagos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocPagos.Name = "btSocPagos"
        Me.btSocPagos.SymbolColor = System.Drawing.Color.Empty
        Me.btSocPagos.Text = "PAGOS"
        Me.btSocPagos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocPagos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocPagos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocPagos.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.btSocPagos.TitleTextColor = System.Drawing.Color.Red
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.ItemSpacing = 10
        Me.ItemContainer2.MultiLine = True
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btSocRepSocio, Me.btSocRepSocioEdad, Me.btSocRepSocioPagos, Me.btSocRepSocioPagosGral, Me.btSocRepSocioPagosMortuoriaGral, Me.btSocRepSocioListaSociosActivos})
        '
        '
        '
        Me.ItemContainer2.TitleStyle.Class = "MetroTileGroupTitle"
        Me.ItemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer2.TitleStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemContainer2.TitleStyle.TextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ItemContainer2.TitleText = "REPORTES"
        '
        'btSocRepSocio
        '
        Me.btSocRepSocio.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocio.Name = "btSocRepSocio"
        Me.btSocRepSocio.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocio.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocio.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocio.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocio.TitleText = "VEHICULO"
        '
        'btSocRepSocioEdad
        '
        Me.btSocRepSocioEdad.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocioEdad.Name = "btSocRepSocioEdad"
        Me.btSocRepSocioEdad.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocioEdad.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocioEdad.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocioEdad.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocioEdad.TitleText = "VEHICULO"
        '
        'btSocRepSocioPagos
        '
        Me.btSocRepSocioPagos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocioPagos.Name = "btSocRepSocioPagos"
        Me.btSocRepSocioPagos.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocioPagos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocioPagos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocioPagos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocioPagos.TitleText = "VEHICULO"
        '
        'btSocRepSocioPagosGral
        '
        Me.btSocRepSocioPagosGral.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocioPagosGral.Name = "btSocRepSocioPagosGral"
        Me.btSocRepSocioPagosGral.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocioPagosGral.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocioPagosGral.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocioPagosGral.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocioPagosGral.TitleText = "VEHICULO"
        '
        'btSocRepSocioPagosMortuoriaGral
        '
        Me.btSocRepSocioPagosMortuoriaGral.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocioPagosMortuoriaGral.Name = "btSocRepSocioPagosMortuoriaGral"
        Me.btSocRepSocioPagosMortuoriaGral.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocioPagosMortuoriaGral.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocioPagosMortuoriaGral.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocioPagosMortuoriaGral.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocioPagosMortuoriaGral.TitleText = "VEHICULO"
        '
        'btSocRepSocioListaSociosActivos
        '
        Me.btSocRepSocioListaSociosActivos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btSocRepSocioListaSociosActivos.Name = "btSocRepSocioListaSociosActivos"
        Me.btSocRepSocioListaSociosActivos.SymbolColor = System.Drawing.Color.Empty
        Me.btSocRepSocioListaSociosActivos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btSocRepSocioListaSociosActivos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btSocRepSocioListaSociosActivos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btSocRepSocioListaSociosActivos.TitleText = "VEHICULO"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 410)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 114)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'SideNavPanel2
        '
        Me.SideNavPanel2.Controls.Add(Me.MetroTilePanel3)
        Me.SideNavPanel2.Controls.Add(Me.PictureBox2)
        Me.SideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SideNavPanel2.Location = New System.Drawing.Point(170, 36)
        Me.SideNavPanel2.Name = "SideNavPanel2"
        Me.SideNavPanel2.Size = New System.Drawing.Size(609, 524)
        Me.SideNavPanel2.TabIndex = 56
        Me.SideNavPanel2.Visible = False
        '
        'MetroTilePanel3
        '
        Me.MetroTilePanel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        '
        '
        '
        Me.MetroTilePanel3.BackgroundStyle.BackColor = System.Drawing.Color.Transparent
        Me.MetroTilePanel3.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel3.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroTilePanel3.DragDropSupport = True
        Me.MetroTilePanel3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btEscVehiculo, Me.btEscAlumnos, Me.btEscEquipos, Me.btEscClaPracticas, Me.btEscInscripciones, Me.btEscPreExamen, Me.btEscClasesTeoricas, Me.ItemContainer1})
        Me.MetroTilePanel3.ItemSpacing = 10
        Me.MetroTilePanel3.Location = New System.Drawing.Point(0, 0)
        Me.MetroTilePanel3.MultiLine = True
        Me.MetroTilePanel3.Name = "MetroTilePanel3"
        Me.MetroTilePanel3.Size = New System.Drawing.Size(609, 410)
        Me.MetroTilePanel3.TabIndex = 2
        Me.MetroTilePanel3.Text = "mtp3Pedidos"
        '
        'btEscVehiculo
        '
        Me.btEscVehiculo.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscVehiculo.Name = "btEscVehiculo"
        Me.btEscVehiculo.SymbolColor = System.Drawing.Color.Empty
        Me.btEscVehiculo.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscVehiculo.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscVehiculo.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscVehiculo.TitleText = "VEHICULO"
        '
        'btEscAlumnos
        '
        Me.btEscAlumnos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscAlumnos.Name = "btEscAlumnos"
        Me.btEscAlumnos.SymbolColor = System.Drawing.Color.Empty
        Me.btEscAlumnos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscAlumnos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscAlumnos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscAlumnos.TitleText = "VEHICULO"
        '
        'btEscEquipos
        '
        Me.btEscEquipos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscEquipos.Name = "btEscEquipos"
        Me.btEscEquipos.SymbolColor = System.Drawing.Color.Empty
        Me.btEscEquipos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscEquipos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscEquipos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscEquipos.TitleText = "VEHICULO"
        '
        'btEscClaPracticas
        '
        Me.btEscClaPracticas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscClaPracticas.Name = "btEscClaPracticas"
        Me.btEscClaPracticas.SymbolColor = System.Drawing.Color.Empty
        Me.btEscClaPracticas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscClaPracticas.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscClaPracticas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscClaPracticas.TitleText = "VEHICULO"
        '
        'btEscInscripciones
        '
        Me.btEscInscripciones.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscInscripciones.Name = "btEscInscripciones"
        Me.btEscInscripciones.SymbolColor = System.Drawing.Color.Empty
        Me.btEscInscripciones.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscInscripciones.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscInscripciones.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscInscripciones.TitleText = "VEHICULO"
        '
        'btEscPreExamen
        '
        Me.btEscPreExamen.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscPreExamen.Name = "btEscPreExamen"
        Me.btEscPreExamen.SymbolColor = System.Drawing.Color.Empty
        Me.btEscPreExamen.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscPreExamen.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscPreExamen.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscPreExamen.TitleText = "VEHICULO"
        '
        'btEscClasesTeoricas
        '
        Me.btEscClasesTeoricas.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscClasesTeoricas.Name = "btEscClasesTeoricas"
        Me.btEscClasesTeoricas.SymbolColor = System.Drawing.Color.Empty
        Me.btEscClasesTeoricas.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscClasesTeoricas.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscClasesTeoricas.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscClasesTeoricas.TitleText = "VEHICULO"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.ItemSpacing = 10
        Me.ItemContainer1.MultiLine = True
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btEscRepPreExamen, Me.btEscRepEstadosAlumnos, Me.btEscRepAlumnosSinPreExamen})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.Class = "MetroTileGroupTitle"
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.TitleStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemContainer1.TitleStyle.TextColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ItemContainer1.TitleText = "REPORTES"
        '
        'btEscRepPreExamen
        '
        Me.btEscRepPreExamen.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscRepPreExamen.Name = "btEscRepPreExamen"
        Me.btEscRepPreExamen.SymbolColor = System.Drawing.Color.Empty
        Me.btEscRepPreExamen.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscRepPreExamen.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscRepPreExamen.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscRepPreExamen.TitleText = "VEHICULO"
        '
        'btEscRepEstadosAlumnos
        '
        Me.btEscRepEstadosAlumnos.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscRepEstadosAlumnos.Name = "btEscRepEstadosAlumnos"
        Me.btEscRepEstadosAlumnos.SymbolColor = System.Drawing.Color.Empty
        Me.btEscRepEstadosAlumnos.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscRepEstadosAlumnos.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscRepEstadosAlumnos.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscRepEstadosAlumnos.TitleText = "VEHICULO"
        '
        'btEscRepAlumnosSinPreExamen
        '
        Me.btEscRepAlumnosSinPreExamen.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btEscRepAlumnosSinPreExamen.Name = "btEscRepAlumnosSinPreExamen"
        Me.btEscRepAlumnosSinPreExamen.SymbolColor = System.Drawing.Color.Empty
        Me.btEscRepAlumnosSinPreExamen.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btEscRepAlumnosSinPreExamen.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btEscRepAlumnosSinPreExamen.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btEscRepAlumnosSinPreExamen.TitleText = "VEHICULO"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox2.Location = New System.Drawing.Point(0, 410)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(609, 114)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'SideNavItem1
        '
        Me.SideNavItem1.IsSystemMenu = True
        Me.SideNavItem1.Name = "SideNavItem1"
        Me.SideNavItem1.Symbol = ""
        Me.SideNavItem1.Text = "Menu"
        '
        'Separator1
        '
        Me.Separator1.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator1.Name = "Separator1"
        Me.Separator1.Padding.Bottom = 2
        Me.Separator1.Padding.Left = 6
        Me.Separator1.Padding.Right = 6
        Me.Separator1.Padding.Top = 2
        Me.Separator1.SeparatorColor = System.Drawing.Color.White
        Me.Separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'FP_Configuracion
        '
        Me.FP_Configuracion.Name = "FP_Configuracion"
        Me.FP_Configuracion.Panel = Me.SideNav_Conf
        Me.FP_Configuracion.Symbol = ""
        Me.FP_Configuracion.Text = "CONFIGURACION"
        '
        'FP_ZONAS
        '
        Me.FP_ZONAS.Name = "FP_ZONAS"
        Me.FP_ZONAS.Panel = Me.SideNav_Logistica
        Me.FP_ZONAS.Symbol = "58718"
        Me.FP_ZONAS.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.FP_ZONAS.Text = "ZONAS"
        '
        'FP_INVENTARIO
        '
        Me.FP_INVENTARIO.Name = "FP_INVENTARIO"
        Me.FP_INVENTARIO.Panel = Me.SideNavPanel5
        Me.FP_INVENTARIO.Symbol = ""
        Me.FP_INVENTARIO.Text = "INVENTARIO"
        '
        'Saldos_Producto
        '
        Me.Saldos_Producto.Name = "Saldos_Producto"
        Me.Saldos_Producto.Panel = Me.SideNavPanel8
        Me.Saldos_Producto.Symbol = "59538"
        Me.Saldos_Producto.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Saldos_Producto.Text = "SALDO_PRODUCTO"
        '
        'FP_Pedidos
        '
        Me.FP_Pedidos.Name = "FP_Pedidos"
        Me.FP_Pedidos.Panel = Me.SideNavPanel2
        Me.FP_Pedidos.Symbol = ""
        Me.FP_Pedidos.Text = "ESCUELA"
        Me.FP_Pedidos.Visible = False
        '
        'SideNavItem2
        '
        Me.SideNavItem2.Name = "SideNavItem2"
        Me.SideNavItem2.Panel = Me.SideNavPanel1
        Me.SideNavItem2.Symbol = ""
        Me.SideNavItem2.Text = "SOCIOS"
        Me.SideNavItem2.Visible = False
        '
        'FP_COMPRAS
        '
        Me.FP_COMPRAS.Name = "FP_COMPRAS"
        Me.FP_COMPRAS.Panel = Me.SideNavPanel6
        Me.FP_COMPRAS.Symbol = ""
        Me.FP_COMPRAS.Text = "COMPRAS"
        '
        'FP_VENTAS
        '
        Me.FP_VENTAS.Name = "FP_VENTAS"
        Me.FP_VENTAS.Panel = Me.SideNav_Ventas
        Me.FP_VENTAS.Symbol = ""
        Me.FP_VENTAS.Text = "VENTAS"
        '
        'FP_CREDITOS
        '
        Me.FP_CREDITOS.Checked = True
        Me.FP_CREDITOS.Name = "FP_CREDITOS"
        Me.FP_CREDITOS.Panel = Me.SideNavPanel7
        Me.FP_CREDITOS.Symbol = ""
        Me.FP_CREDITOS.Text = "CREDITOS"
        '
        'Separator2
        '
        Me.Separator2.FixedSize = New System.Drawing.Size(3, 1)
        Me.Separator2.Name = "Separator2"
        Me.Separator2.Padding.Bottom = 2
        Me.Separator2.Padding.Left = 6
        Me.Separator2.Padding.Right = 6
        Me.Separator2.Padding.Top = 2
        Me.Separator2.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical
        '
        'Ventana
        '
        Me.Ventana.Name = "Ventana"
        Me.Ventana.Panel = Me.SideNavPanel3
        Me.Ventana.Symbol = "57404"
        Me.Ventana.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material
        Me.Ventana.Text = "VENTANAS"
        '
        'SideNavItem3
        '
        Me.SideNavItem3.Name = "SideNavItem3"
        Me.SideNavItem3.Panel = Me.SideNavPanel4
        Me.SideNavItem3.Symbol = ""
        Me.SideNavItem3.Text = "CERRAR SESION"
        '
        'MetroTileFrame1
        '
        Me.MetroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileFrame1.Text = "REALIZAR PEDIDOS"
        Me.MetroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileFrame1.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileFrame1.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileFrame2
        '
        Me.MetroTileFrame2.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileFrame2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        '
        '
        '
        Me.MetroTileFrame2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileFrame2.TitleText = "VEHICULO"
        '
        'MetroTileItem8
        '
        Me.MetroTileItem8.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem8.Name = "MetroTileItem8"
        Me.MetroTileItem8.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem8.Text = "PERSONAL"
        Me.MetroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem8.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem8.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem8.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem6
        '
        Me.MetroTileItem6.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem6.Name = "MetroTileItem6"
        Me.MetroTileItem6.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem6.Text = "PERSONAL"
        Me.MetroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem6.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem6.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem6.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem7
        '
        Me.MetroTileItem7.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem7.Name = "MetroTileItem7"
        Me.MetroTileItem7.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem7.Text = "PERSONAL"
        Me.MetroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem7.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem7.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem7.TitleTextColor = System.Drawing.Color.Red
        '
        'MetroTileItem4
        '
        Me.MetroTileItem4.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem4.Name = "MetroTileItem4"
        Me.MetroTileItem4.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem4.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem4.TitleText = "VEHICULO"
        '
        'MetroTileItem5
        '
        Me.MetroTileItem5.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem5.Name = "MetroTileItem5"
        Me.MetroTileItem5.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem5.Text = "BONOS / DECUENTOS"
        Me.MetroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem5.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem5.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTileItem5.TitleTextColor = System.Drawing.Color.Red
        '
        'btVentRepSaldoClientes
        '
        Me.btVentRepSaldoClientes.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btVentRepSaldoClientes.Name = "btVentRepSaldoClientes"
        Me.btVentRepSaldoClientes.SymbolColor = System.Drawing.Color.Empty
        Me.btVentRepSaldoClientes.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.btVentRepSaldoClientes.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.btVentRepSaldoClientes.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.btVentRepSaldoClientes.TitleText = "VEHICULO"
        '
        'MetroTileItem11
        '
        Me.MetroTileItem11.Image = Global.DinoM.My.Resources.Resources.user
        Me.MetroTileItem11.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTileItem11.Name = "MetroTileItem11"
        Me.MetroTileItem11.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem11.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem11.TileSize = New System.Drawing.Size(250, 135)
        '
        '
        '
        Me.MetroTileItem11.TileStyle.BackColor = System.Drawing.Color.MediumOrchid
        Me.MetroTileItem11.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.MetroTileItem11.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem11.TitleText = "USUARIOS"
        '
        'P_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 561)
        Me.Controls.Add(Me.rmSesion)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.SideNav1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "P_Principal"
        Me.Text = "Dino M"
        Me.SideNav1.ResumeLayout(False)
        Me.SideNav1.PerformLayout()
        Me.SideNavPanel7.ResumeLayout(False)
        Me.SideNavPanel8.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.grProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.SideNavPanel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.SideNavPanel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SideNav_Logistica.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideNav_Conf.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideNav_Ventas.ResumeLayout(False)
        Me.PanelVentas.ResumeLayout(False)
        Me.SideNavPanel3.ResumeLayout(False)
        CType(Me.superTabControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superTabControl3.ResumeLayout(False)
        Me.SideNavPanel4.ResumeLayout(False)
        Me.SideNavPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SideNavPanel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents SideNav1 As DevComponents.DotNetBar.Controls.SideNav
    Friend WithEvents SideNav_Logistica As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents SideNav_Conf As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem1 As DevComponents.DotNetBar.Controls.SideNavItem
    Private WithEvents FP_Configuracion As DevComponents.DotNetBar.Controls.SideNavItem
    Private WithEvents FP_ZONAS As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents MetroTilePanel2 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btZonaMapaCliente As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem8 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem7 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents Separator1 As DevComponents.DotNetBar.Separator
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents MetroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNavPanel2 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents MetroTilePanel3 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btEscVehiculo As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscAlumnos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscEquipos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscClaPracticas As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btEscRepPreExamen As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscRepEstadosAlumnos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents FP_Pedidos As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents rmSesion As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents btCerrarSesion As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents btSalir As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents btVentRepSaldoClientes As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfRoles As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfUsuarios As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents lbUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btAbout As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents btZonas As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfProducto As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNavPanel1 As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem2 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents MetroTilePanel4 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btSocSocio As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocPagos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btConfLibreria As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscInscripciones As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfPrecio As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscPreExamen As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btSocRepSocio As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocRepSocioEdad As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscRepAlumnosSinPreExamen As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocRepSocioPagos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btEscClasesTeoricas As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btZonaReporteRuta As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btRHAntigueVacaciones As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btRHBonosDesc As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btRHRepPlanillaSueldos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btRHPedidoVacacion As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocRepSocioPagosGral As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocRepSocioPagosMortuoriaGral As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btSocRepSocioListaSociosActivos As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfCliente As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNavPanel3 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents PanelPrincipal As System.Windows.Forms.Panel
    Friend WithEvents Separator2 As DevComponents.DotNetBar.Separator
    Private WithEvents Ventana As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavPanel4 As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents SideNavItem3 As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavPanel5 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MetroTilePanel6 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btInvDeposito As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvAmacen As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvVentas As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvMovimiento As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvKardex As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvSaldo As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvKardexReporte As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents FP_INVENTARIO As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents SideNavPanel6 As DevComponents.DotNetBar.Controls.SideNavPanel
    Private WithEvents FP_COMPRAS As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroTilePanel7 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btComProveedor As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btComCompra As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btComPagosCredito As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem21 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem22 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem23 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTilePanel5 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents MetroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem3 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem10 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfDosificacion As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNav_Ventas As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents PanelVentas As System.Windows.Forms.Panel
    Friend WithEvents MetroTilePanelVentas As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btVentVenta As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentAnularFactura As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentLibroVenta As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents FP_VENTAS As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents btVentReporteAtendidas As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentReporteVentaVsCosto As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentReporteProducto As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNavPanel7 As DevComponents.DotNetBar.Controls.SideNavPanel
    Friend WithEvents MenuCreditos As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents btnCredPago As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btnCredEstCuenta As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btnCredInfMorosidad As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents FP_CREDITOS As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents btInvUtilidad As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btInvSaldoLote As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentGrafica As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentRotProd As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btComVendedor As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentEstad As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentFactura As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btlvSaldoMinimo As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btnCredPagoCliente As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btnCredPagoClienteVendedor As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem11 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btConfRepCliente As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileFrame1 As DevComponents.DotNetBar.Metro.MetroTileFrame
    Friend WithEvents MetroTileFrame2 As DevComponents.DotNetBar.Metro.MetroTileFrame
    Friend WithEvents superTabControl3 As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents btnCredPagoResumen As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btRepClientes As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents btVentDescuento As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents SideNavPanel8 As DevComponents.DotNetBar.Controls.SideNavPanel

    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents grProductos As Janus.Windows.GridEX.GridEX
    Private WithEvents Saldos_Producto As DevComponents.DotNetBar.Controls.SideNavItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btExcel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReporte As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnActualizar As DevComponents.DotNetBar.ButtonX
End Class
