Imports Logica.AccesoLogica
Imports Modelo.MGlobal
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar.Rendering
Imports System.IO

Public Class P_Principal


#Region "Atributos"
    Dim RutaGlobal As String = gs_CarpetaRaiz
    Dim RutaTemporal As String = "C:\Temporal"
#End Region

#Region "Metodos Privados"

    Public Sub New()
        _prCambiarStyle()
        ' This call is required by the designer.
        InitializeComponent()
        FP_Configuracion.Select()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub _prIniciarTodo()
        'Leer Archivo de Configuración
        _prLeerArchivoConfig()

        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)

        Me.WindowState = FormWindowState.Maximized

        'iniciar login de usuario
        _prLogin()
        Dim blah As New Bitmap(New Bitmap(My.Resources.almacen), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
        _prCargarProductos()
    End Sub

    Private Sub _prCargarProductos()

        Dim dt As New DataTable
        dt = L_fnStockActualPrincipal()
        grProductos.DataSource = dt
        grProductos.RetrieveStructure()
        grProductos.AlternatingColors = True
        '' a.yfnumi  , a.yfcdprod1, Sum(c.iccven) as iccven


        With grProductos.RootTable.Columns("yfnumi")
            .Width = 150
            .Caption = "COD PRODUCTO"
            .Visible = True

        End With

        With grProductos.RootTable.Columns("yfcdprod1")
            .Width = 410
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "PRODUCTO"
        End With

        With grProductos.RootTable.Columns("iccven")
            .Width = 160
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "STOCK"
            .FormatString = "0"
        End With
        With grProductos
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla

        End With


    End Sub
    Private Sub _prCambiarStyle()
        'tratar de cambiar estilo
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver, Color.FromArgb(0, 85, 139))

        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass)
        'RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, eStyle.VisualStudio2012Dark)
        'RibbonPredefinedColorSchemes.ChangeStyle(eStyle.VisualStudio2012Dark)

        'cambio de otros colores
        Dim table As Office2007ColorTable = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable
        Dim ct As SideNavColorTable = table.SideNav
        ''  ct.TitleBackColor = Color.FromArgb(49, 59, 66)
        'ct.SideNavItem.MouseOver.BackColors = New Color() {Color.Red, Color.Yellow}
        ct.SideNavItem.MouseOver.BorderColors = New Color() {Color.FromArgb(49, 59, 66)} ' No border
        ct.SideNavItem.Selected.BackColors = New Color() {Color.Yellow}
        ''     ct.BorderColors = New Color() {Color.FromArgb(49, 59, 66)} ' Control border color

        ''  ct.PanelBackColor = Color.FromArgb(49, 59, 66)
    End Sub


    Private Sub _prLeerArchivoConfig()
        Dim Archivo() As String = IO.File.ReadAllLines(Application.StartupPath + "\CONFIG.TXT")
        gs_Ip = Archivo(0).Split("=")(1).Trim
        gs_UsuarioSql = Archivo(1).Split("=")(1).Trim
        gs_ClaveSql = Archivo(2).Split("=")(1).Trim
        gs_NombreBD = Archivo(3).Split("=")(1).Trim
        gs_CarpetaRaiz = Archivo(4).Split("=")(1).Trim
    End Sub

    Private Sub _prLogin()
        Dim ef = New Efecto
        ef.tipo = 4
        ef.ShowDialog()

        L_Usuario = gs_user
        Modelo.MGlobal.gs_usuario = gs_user

        lbUsuario.Text = gs_user
        lbUsuario.Font = New Font("Tahoma", 12, FontStyle.Bold)

        If gs_user = "DEFAULT" Then
            SideNav1.Enabled = False
        Else
            _PCargarPrivilegios()
            _prCargarConfiguracionSistema()
            SideNav1.Enabled = True
        End If

        P_prCargarParametros()
        _prValidarMayusculas()
    End Sub
    Public Sub _prValidarMayusculas()
        Dim dt As DataTable = L_fnPorcUtilidad()
        If (dt.Rows.Count > 0) Then
            Modelo.MGlobal.gs_mayusuculas = dt.Rows(0).Item("mayusculas")
        End If
    End Sub

    Private Sub P_prCargarParametros()
        Dim dtConfSistema As DataTable = L_fnConfSistemaGeneral()

        gb_FacturaEmite = dtConfSistema.Rows(0).Item("cccefac")
        gi_FacturaTipo = dtConfSistema.Rows(0).Item("ccctfac")
        gi_FacturaCantidadItems = dtConfSistema.Rows(0).Item("ccccite")
        gb_FacturaIncluirICE = dtConfSistema.Rows(0).Item("ccciice")
        'gi_codeBar = dtConfSistema.Rows(0).Item("ccciice")

    End Sub

    Private Sub _prCargarConfiguracionSistema()
        'Dim dtConf As DataTable = L_prConGlobalGeneral()
        'gd_notaAproTeo = dtConf.Rows(0).Item("gbaproteo")

    End Sub

    Private Sub _PCargarPrivilegios()
        Dim listaTabs As New List(Of DevComponents.DotNetBar.Metro.MetroTilePanel)
        listaTabs.Add(MetroTilePanel1)
        listaTabs.Add(MetroTilePanel2)
        listaTabs.Add(MetroTilePanel6)
        listaTabs.Add(MetroTilePanel7)
        listaTabs.Add(MetroTilePanelVentas)
        listaTabs.Add(MenuCreditos)


        Dim idRolUsu As String = gi_userRol

        Dim dtModulos As DataTable = L_prLibreriaDetalleGeneral(gi_LibSistema, gi_LibSISModulo)
        Dim listFormsModulo As New List(Of String)

        For i = 0 To dtModulos.Rows.Count - 1
            Dim dtDetRol As DataTable = L_RolDetalle_General(-1, idRolUsu, dtModulos.Rows(i).Item("cnnum"))
            listFormsModulo = New List(Of String)

            If dtDetRol.Rows.Count > 0 Then
                'cargo los nombres de los programas(botones) del modulo
                For Each fila As DataRow In dtDetRol.Rows
                    listFormsModulo.Add(fila.Item("yaprog").ToString.ToUpper)
                Next
                'recorro el modulo(tab) que corresponde
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        If listFormsModulo.Contains(btn.Name.ToUpper) Then 'si el nombre del boton pertenece a la lista de formularios del modulo
                            Dim Texto As String = btn.Text
                            Dim TTexto As String = btn.TitleText
                            Dim f As Integer = listFormsModulo.IndexOf(btn.Name.ToUpper)
                            If Texto = "" Then 'esta usando el Title Text
                                btn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            Else 'esta usando el Text
                                btn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                            End If

                            If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                btn.Visible = True
                            Else
                                btn.Visible = False
                            End If
                        Else 'si no pertenece lo oculto
                            btn.Visible = False
                        End If
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                If listFormsModulo.Contains(_subBtn.Name.ToUpper) Then
                                    Dim Texto As String = _subBtn.Text
                                    Dim TTexto As String = _subBtn.TitleText
                                    Dim f As Integer = listFormsModulo.IndexOf(_subBtn.Name.ToUpper)
                                    If Texto = "" Then 'esta usando el Title Text
                                        _subBtn.TitleText = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    Else 'esta usando el Text
                                        _subBtn.Text = dtDetRol.Rows(f).Item("yatit").ToString.ToUpper
                                    End If

                                    If dtDetRol.Rows(f).Item("ycshow") = True Or dtDetRol.Rows(f).Item("ycadd") = True Or dtDetRol.Rows(f).Item("ycmod") = True Or dtDetRol.Rows(f).Item("ycdel") = True Then
                                        _subBtn.Visible = True
                                    Else
                                        _subBtn.Visible = False
                                    End If
                                Else
                                    _subBtn.Visible = False
                                End If
                            Next
                        End If

                    End If
                Next
            Else ' no exiten formulario registrados en el modulo pero igual hay que ocultar los botones y los subbotones que tenga
                For Each _item As DevComponents.DotNetBar.BaseItem In listaTabs.Item(i).Items
                    If TypeOf (_item) Is DevComponents.DotNetBar.Metro.MetroTileItem Then 'es un boton del modulo
                        Dim btn As DevComponents.DotNetBar.Metro.MetroTileItem = CType(_item, DevComponents.DotNetBar.Metro.MetroTileItem)
                        btn.Visible = False
                    Else 'seria un sub grupo en el modulo
                        'recorro todos los elementos del sub grupo
                        If TypeOf _item Is ItemContainer Then
                            For Each _subItem In _item.SubItems
                                Dim _subBtn As MetroTileItem = CType(_subItem, MetroTileItem)
                                _subBtn.Visible = False
                            Next
                        End If

                    End If
                Next

            End If

        Next

        'refrescar el formulario
        Me.Refresh()
    End Sub
#End Region

    Private Sub P_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub P_Principal_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        _prLogin()
    End Sub

    Private Sub P_Principal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        _prLogin()
    End Sub

    Private Sub rmSesion_ItemClick(sender As Object, e As EventArgs) Handles rmSesion.ItemClick
        Dim item As RadialMenuItem = TryCast(sender, RadialMenuItem)
        If item IsNot Nothing AndAlso (Not String.IsNullOrEmpty(item.Text)) Then
            Select Case item.Name
                Case "btCerrarSesion"
                    _prLogin()
                Case "btSalir"
                    Me.Close()
                Case "btAbout"
                    'Dim frm As New P_Acerca
                    'frm.ShowDialog()
            End Select
        End If
    End Sub



    Private Sub btConfRoles_Click(sender As Object, e As EventArgs) Handles btConfRoles.Click

        'Dim frm As New F0_Roles
        Dim frm As New F1_Rol
        frm._nameButton = btConfRoles.Name
        frm._modulo = FP_Configuracion
        frm.Show()

    End Sub

    Private Sub btConfUsuarios_Click(sender As Object, e As EventArgs) Handles btConfUsuarios.Click


        Dim frm As New F0_Usuarios
        frm._nameButton = btConfUsuarios.Name
        frm._modulo = FP_Configuracion
        frm.Show()

    End Sub



    Private Sub Ventana_Click(sender As Object, e As EventArgs) Handles Ventana.Click
        SideNav1.IsMenuExpanded = False
    End Sub

    Private Sub SideNav1_IsMenuExpandedChanged(sender As Object, e As EventArgs) Handles SideNav1.IsMenuExpandedChanged
        If (SideNav1.IsMenuExpanded = True) Then
            FP_Configuracion.Select()

        End If
    End Sub

    Private Sub SideNavItem3_Click(sender As Object, e As EventArgs) Handles SideNavItem3.Click
        rmSesion.IsOpen = True
        rmSesion.MenuLocation = New Point(Me.Width / 2, Me.Height / 3)
        SideNav_Conf.Select()

    End Sub

    Private Sub rmSesion_MenuClosed(sender As Object, e As EventArgs) Handles rmSesion.MenuClosed
        FP_Configuracion.Select()
    End Sub

    Private Sub btConfFabrica_Click(sender As Object, e As EventArgs) Handles btConfCliente.Click

        Dim frm As New F1_Clientes
        frm._Tipo = 1
        frm._nameButton = btConfCliente.Name
        frm._modulo = FP_Configuracion
        frm.Show()

    End Sub

    Private Sub btConfTipoEquipo_Click(sender As Object, e As EventArgs) Handles btConfProducto.Click

        Dim frm As New F1_Productos
        frm._nameButton = btConfProducto.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub btConfPrecio_Click(sender As Object, e As EventArgs) Handles btConfPrecio.Click

        Dim frm As New F0_Precios
        frm._nameButton = btConfPrecio.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub btCatCatalogo_Click(sender As Object, e As EventArgs) Handles btZonas.Click

        Dim frm As New F1_Zonas
        frm._nameButton = btZonas.Name
        frm._modulo = FP_ZONAS
        frm.Show()
    End Sub



    Private Sub MetroTileItem12_Click(sender As Object, e As EventArgs) Handles btInvDeposito.Click

        Dim frm As New F1_Deposito
        frm._nameButton = btZonas.Name
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btInvAmacen_Click(sender As Object, e As EventArgs) Handles btInvAmacen.Click

        Dim frm As New F1_Almacen
        frm._nameButton = btZonas.Name
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btComProveedor_Click(sender As Object, e As EventArgs) Handles btComProveedor.Click

        Dim frm As New F1_Proveedor
        frm._Tipo = 3
        frm._nameButton = btComProveedor.Name
        frm._modulo = FP_COMPRAS
        frm.Show()

    End Sub

    Private Sub btComCompra_Click(sender As Object, e As EventArgs) Handles btComCompra.Click

        Dim frm As New F0_MCompras
        frm._nameButton = btComCompra.Name
        frm.Show()

    End Sub

    Private Sub btInvVentas_Click(sender As Object, e As EventArgs) Handles btInvVentas.Click

        Dim frm As New F0_Ventas
        frm._nameButton = btConfCliente.Name
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub



    Private Sub btConfDosificacion_Click(sender As Object, e As EventArgs) Handles btConfDosificacion.Click

        Dim frm As New F1_Dosificacion
        frm._nameButton = btZonas.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

#Region "Modulo Venta"

    Private Sub btVentVenta_Click(sender As Object, e As EventArgs) Handles btVentVenta.Click

        Dim frm As New F0_Ventas
        frm._nameButton = btVentVenta.Name
        frm.Show()
    End Sub

    Private Sub btVentAnularFactura_Click(sender As Object, e As EventArgs) Handles btVentAnularFactura.Click

        Dim frm As New F0_AnularFactura
        frm._nameButton = btVentAnularFactura.Name
        frm.Show()
    End Sub

    Private Sub btVentLibroVenta_Click(sender As Object, e As EventArgs) Handles btVentLibroVenta.Click

        Dim frm As New F0_LibroVenta
        frm._nameButton = btVentLibroVenta.Name
        frm.Show()
    End Sub

#End Region

    Private Sub btInvMovimiento_Click(sender As Object, e As EventArgs) Handles btInvMovimiento.Click

        Dim frm As New F0_Movimiento
        frm._nameButton = btInvMovimiento.Name
        frm.Show()
    End Sub

    Private Sub superTabControl3_TabItemClose(sender As Object, e As SuperTabStripTabItemCloseEventArgs) Handles superTabControl3.TabItemClose
        Dim cantidad As Integer = superTabControl3.Tabs.Count
        If cantidad = 1 Then
            FP_Configuracion.Select()
        End If
    End Sub

    Private Sub MetroTileItem16_Click(sender As Object, e As EventArgs) Handles btInvKardex.Click
        Dim frm As New F0_KardexMovimiento
        frm._nameButton = btInvKardex.Name
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btInvSaldo_Click(sender As Object, e As EventArgs) Handles btInvSaldo.Click

        Dim frm As New Pr_SAldosPorAlmacenLinea
        Dim tab3 As SuperTabItem = superTabControl3.CreateTab(frm.Text)
        frm._tab = tab3
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btVentReporteAtendidas_Click(sender As Object, e As EventArgs) Handles btVentReporteAtendidas.Click

        Dim frm As New Pr_VentasAtendidas
        Dim tab3 As SuperTabItem = superTabControl3.CreateTab(frm.Text)
        frm._tab = tab3
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub btVentReporteVentaVsCosto_Click(sender As Object, e As EventArgs) Handles btVentReporteVentaVsCosto.Click

        Dim frm As New Pr_VentasVsCostos
        Dim tab3 As SuperTabItem = superTabControl3.CreateTab(frm.Text)
        frm._tab = tab3
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub btZonaMapaCliente_Click(sender As Object, e As EventArgs) Handles btZonaMapaCliente.Click

        Dim frm As New F1_MapaCLientes
        frm._modulo = FP_ZONAS
        frm.Show()

    End Sub



    Private Sub btHojaRuta_Click(sender As Object, e As EventArgs) Handles btZonaReporteRuta.Click

        Dim frm As New Pr_HojaRuta
        frm._modulo = FP_ZONAS
        frm.Show()
    End Sub

    Private Sub btInvKardexReporte_Click(sender As Object, e As EventArgs) Handles btInvKardexReporte.Click
        Dim frm As New Pr_KardexProductos
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btVentReporteProducto_Click(sender As Object, e As EventArgs) Handles btVentReporteProducto.Click

        Dim frm As New Pr_ProductosVentas
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub MetroTileItem11_Click(sender As Object, e As EventArgs) Handles btnCredPago.Click

        Dim frm As New F0_PagosCredito
        frm._nameButton = btInvMovimiento.Name
        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub


    Private Sub btnCredEstCuenta_Click(sender As Object, e As EventArgs) Handles btnCredEstCuenta.Click

        Dim frm As New Pr_KardexCredito
        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub

    Private Sub btInvUtilidad_Click(sender As Object, e As EventArgs) Handles btInvUtilidad.Click

        Dim frm As New Pr_StockUtilidad
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub MetroTileItem13_Click(sender As Object, e As EventArgs) Handles btnCredInfMorosidad.Click

        Dim frm As New Pr_ReporteMorosidadGeneral

        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub

    Private Sub btComPagosCredito_Click(sender As Object, e As EventArgs) Handles btComPagosCredito.Click

        Dim frm As New F0_PagosCreditoCompraUlt
        frm._nameButton = btInvMovimiento.Name
        frm._modulo = FP_COMPRAS
        frm.Show()
    End Sub

    Private Sub MetroTileItem11_Click_1(sender As Object, e As EventArgs) Handles btInvSaldoLote.Click

        Dim frm As New PR_StockActualProductosLotes
        frm.Show()
    End Sub



    Private Sub btVentGrafica_Click(sender As Object, e As EventArgs) Handles btVentGrafica.Click

        Dim frm As New Pr_ReporteVentasGrafico
        frm._nameButton = btVentRotProd.Name
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub MetroTileItem11_Click_2(sender As Object, e As EventArgs) Handles btVentRotProd.Click

        Dim frm As New F0_RotacionProductos
        frm._nameButton = btVentRotProd.Name
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub btComVendedor_Click_1(sender As Object, e As EventArgs) Handles btComVendedor.Click

        Dim frm As New F1_Vendedor
        frm._Tipo = 2
        frm._nameButton = btComVendedor.Name
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub btVentEstad_Click(sender As Object, e As EventArgs) Handles btVentEstad.Click

        Dim frm As New Pr_Ventas12Meses
        frm._nameButton = btVentEstad.Name
        frm.Show()
    End Sub

    Private Sub btVentFactura_Click(sender As Object, e As EventArgs) Handles btVentFactura.Click

        Dim frm As New F0_Factura
        frm._nameButton = btVentFactura.Name
        frm._modulo = FP_VENTAS
        frm.Show()
    End Sub

    Private Sub btConfAccesorio_Click(sender As Object, e As EventArgs) Handles btConfLibreria.Click

        Dim frm As New F0_Libreria
        frm._nameButton = btConfLibreria.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub



    Private Sub btlvSaldoMinimo_Click(sender As Object, e As EventArgs) Handles btlvSaldoMinimo.Click

        Dim frm As New Pr_StockMinimo
        frm._modulo = FP_INVENTARIO
        frm.Show()
    End Sub

    Private Sub btnCredPagoCliente_Click(sender As Object, e As EventArgs) Handles btnCredPagoCliente.Click
        Dim frm As New F0_Cobrar_Cliente
        frm._nameButton = btInvMovimiento.Name
        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub

    Private Sub btnCredPagoClienteVendedor_Click(sender As Object, e As EventArgs) Handles btnCredPagoClienteVendedor.Click

        Dim frm As New F0_Cobrar_Vendedor
        frm._nameButton = btnCredPagoClienteVendedor.Name
        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub

    Private Sub FP_VENTAS_Click(sender As Object, e As EventArgs) Handles FP_VENTAS.Click

    End Sub

    Private Sub btConfRepCliente_Click(sender As Object, e As EventArgs) Handles btConfRepCliente.Click

        Dim frm As New Pr_ClientesVendedorAlmacen
        frm._nameButton = btConfRepCliente.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub btnCredPagoResumen_Click(sender As Object, e As EventArgs) Handles btnCredPagoResumen.Click

        Dim frm As New PR_ResumenCaja
        frm._nameButton = btnCredPagoResumen.Name
        frm._modulo = FP_CREDITOS
        frm.Show()
    End Sub

    Private Sub btRepClientes_Click(sender As Object, e As EventArgs) Handles btRepClientes.Click

        Dim frm As New Pr_Clientes
        frm._nameButton = btRepClientes.Name
        frm._modulo = FP_Configuracion
        frm.Show()
    End Sub

    Private Sub btVentDescuento_Click(sender As Object, e As EventArgs) Handles btVentDescuento.Click
        Dim frm As New F0_ActualizaVentasDescuentos
        frm._nameButton = btVentDescuento.Name
        frm.Show()
    End Sub

    Private Sub Saldos_Producto_Click(sender As Object, e As EventArgs) Handles Saldos_Producto.Click
        _prCargarProductos()
        grProductos.Focus()
    End Sub

    Private Sub btExcel_Click(sender As Object, e As EventArgs) Handles btExcel.Click
        _prCrearCarpetaReportes()
        Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
        If (P_ExportarExcel(RutaGlobal + "\Reporte\Reporte Productos")) Then
            ToastNotification.Show(Me, "EXPORTACIÓN DE LISTA DE STOCK EXITOSA..!!!",
                                   img, 2000,
                                   eToastGlowColor.Green,
                                   eToastPosition.BottomCenter)
        Else
            ToastNotification.Show(Me, "FALLO AL EXPORTACIÓN DE LISTA DE STOCK..!!!",
                                   My.Resources.WARNING, 2000,
                                   eToastGlowColor.Red,
                                   eToastPosition.BottomLeft)
        End If
    End Sub

    Public Function P_ExportarExcel(_ruta As String) As Boolean
        Dim _ubicacion As String
        'Dim _directorio As New FolderBrowserDialog

        If (1 = 1) Then 'If(_directorio.ShowDialog = Windows.Forms.DialogResult.OK) Then
            '_ubicacion = _directorio.SelectedPath
            _ubicacion = _ruta
            Try
                Dim _stream As Stream
                Dim _escritor As StreamWriter
                Dim _fila As Integer = grProductos.GetRows.Length
                Dim _columna As Integer = grProductos.RootTable.Columns.Count
                Dim _archivo As String = _ubicacion & "\ListaDeProductos_" & Now.Date.Day &
                    "." & Now.Date.Month & "." & Now.Date.Year & "_" & Now.Hour & "." & Now.Minute & "." & Now.Second & ".csv"
                Dim _linea As String = ""
                Dim _filadata = 0, columndata As Int32 = 0
                File.Delete(_archivo)
                _stream = File.OpenWrite(_archivo)
                _escritor = New StreamWriter(_stream, System.Text.Encoding.UTF8)

                For Each _col As GridEXColumn In grProductos.RootTable.Columns
                    If (_col.Visible) Then
                        _linea = _linea & _col.Caption & ";"
                    End If
                Next
                _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                _escritor.WriteLine(_linea)
                _linea = Nothing

                'Pbx_Precios.Visible = True
                'Pbx_Precios.Minimum = 1
                'Pbx_Precios.Maximum = Dgv_Precios.RowCount
                'Pbx_Precios.Value = 1

                For Each _fil As GridEXRow In grProductos.GetRows
                    For Each _col As GridEXColumn In grProductos.RootTable.Columns
                        If (_col.Visible) Then
                            Dim data As String = CStr(_fil.Cells(_col.Key).Value)
                            data = data.Replace(";", ",")
                            _linea = _linea & data & ";"
                        End If
                    Next
                    _linea = Mid(CStr(_linea), 1, _linea.Length - 1)
                    _escritor.WriteLine(_linea)
                    _linea = Nothing
                    'Pbx_Precios.Value += 1
                Next
                _escritor.Close()
                'Pbx_Precios.Visible = False
                Try
                    Dim ef = New Efecto
                    ef._archivo = _archivo

                    ef.tipo = 1
                    ef.Context = "Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?"
                    ef.Header = "PREGUNTA"
                    ef.ShowDialog()
                    Dim bandera As Boolean = False
                    bandera = ef.band
                    If (bandera = True) Then
                        Process.Start(_archivo)
                    End If

                    'If (MessageBox.Show("Su archivo ha sido Guardado en la ruta: " + _archivo + vbLf + "DESEA ABRIR EL ARCHIVO?", "PREGUNTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    '    Process.Start(_archivo)
                    'End If
                    Return True
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return False
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End If
        Return False
    End Function
    Private Sub _prCrearCarpetaReportes()
        Dim rutaDestino As String = RutaGlobal + "\Reporte\Reporte Productos\"

        If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos\") = False Then
            If System.IO.Directory.Exists(RutaGlobal + "\Reporte") = False Then
                System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte")
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")
                End If
            Else
                If System.IO.Directory.Exists(RutaGlobal + "\Reporte\Reporte Productos") = False Then
                    System.IO.Directory.CreateDirectory(RutaGlobal + "\Reporte\Reporte Productos")

                End If
            End If
        End If
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim _dt As DataTable = L_fnTodosAlmacenTodosLineas()
        If (_dt.Rows.Count > 0) Then

            If Not IsNothing(P_Global.Visualizador) Then
                P_Global.Visualizador.Close()
            End If

            P_Global.Visualizador = New Visualizador

            Dim objrep As New R_SaldosPorLinea
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("usuario", L_Usuario)
            P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
            P_Global.Visualizador.Show() 'Comentar
            P_Global.Visualizador.BringToFront() 'Comentar





        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        _prCargarProductos()
    End Sub
End Class