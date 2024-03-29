﻿Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text
Imports System.Reflection
Imports System.Runtime.InteropServices
Public Class F0_MCompras


#Region "Variables Globales"
    Dim _CodProveedor As Integer = 0
    Dim _numiCatCosto As Integer = 0
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Public Table_Producto As DataTable
    Dim _PorcentajeUtil As Double = 0 '' En esta varible obtendre de la libreria el porcentaje de utilidad para la venta 
    Dim _estadoPor As Integer ''En esta variable me dira si sera visible o no las columnas de porcentaje de utilidad y precio de venta
    Dim Lote As Boolean = False
#End Region

#Region "Metodos Privados"
    Private Sub _IniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        _prValidarLote()
        _prCargarComboLibreriaSucursal(cbSucursal)
        _prObtenerPorcentajeUtilidad()
        'Me.WindowState = FormWindowState.Maximized
        _prCargarCompra()
        _prInhabiliitar()
        grCompra.Focus()
        _prAsignarPermisos()
        Me.Text = "COMPRAS"

    End Sub
    Public Sub _prValidarLote()
        Dim dt As DataTable = L_fnPorcUtilidad()
        If (dt.Rows.Count > 0) Then
            Dim lot As Integer = dt.Rows(0).Item("VerLote")
            If (lot = 1) Then
                Lote = True
            Else
                Lote = False
            End If

        End If
    End Sub
    Private Sub _prAsignarPermisos()

        Dim dtRolUsu As DataTable = L_prRolDetalleGeneral(gi_userRol, _nameButton)

        Dim show As Boolean = dtRolUsu.Rows(0).Item("ycshow")
        Dim add As Boolean = dtRolUsu.Rows(0).Item("ycadd")
        Dim modif As Boolean = dtRolUsu.Rows(0).Item("ycmod")
        Dim del As Boolean = dtRolUsu.Rows(0).Item("ycdel")

        If add = False Then
            btnNuevo.Visible = False
        End If
        If modif = False Then
            btnModificar.Visible = False
        End If
        If del = False Then
            btnEliminar.Visible = False
        End If
    End Sub
    Public Sub _prObtenerPorcentajeUtilidad()
        ''''En este procedimiento obtendre el porcentaje de utilidad que esta en la tabla de configuraciones
        Dim dt As DataTable = L_fnPorcUtilidad()
        If (dt.Rows.Count > 0) Then
            _PorcentajeUtil = dt.Rows(0).Item("PorcUtil")
            _estadoPor = dt.Rows(0).Item("VerPorc")
        End If

    End Sub
    Private Sub _prCargarComboLibreriaSucursal(mCombo As Janus.Windows.GridEX.EditControls.MultiColumnCombo)
        Dim dt As New DataTable
        dt = L_fnListarSucursales()
        With mCombo
            .DropDownList.Columns.Clear()
            .DropDownList.Columns.Add("aanumi").Width = 60
            .DropDownList.Columns("aanumi").Caption = "COD"
            .DropDownList.Columns.Add("aabdes").Width = 500
            .DropDownList.Columns("aabdes").Caption = "SUCURSAL"
            .ValueMember = "aanumi"
            .DisplayMember = "aabdes"
            .DataSource = dt
            .Refresh()
        End With
    End Sub
    Private Sub _prInhabiliitar()
        tbnrocod.ReadOnly = True
        tbCodigo.ReadOnly = True
        tbProveedor.ReadOnly = True
        tbObservacion.ReadOnly = True
        tbFechaVenta.IsInputReadOnly = True
        tbFechaVenc.IsInputReadOnly = True
        cbSucursal.ReadOnly = True
        swTipoVenta.IsReadOnly = True
        ''''''''''
        btnModificar.Enabled = True
        btnGrabar.Enabled = False
        btnNuevo.Enabled = True
        btnEliminar.Enabled = True

        tbtotal.IsInputReadOnly = True

        grCompra.Enabled = True
        PanelNavegacion.Enabled = True
        grdetalle.RootTable.Columns("img").Visible = False


    End Sub
    Private Sub _prhabilitar()
        grCompra.Enabled = False
        'tbnrocod.ReadOnly = False
        ''  tbCliente.ReadOnly = False  por que solo podra seleccionar Cliente
        ''  tbVendedor.ReadOnly = False
        tbObservacion.ReadOnly = False
        tbFechaVenta.IsInputReadOnly = False
        tbFechaVenc.IsInputReadOnly = False
        If (tbCodigo.Text.Length > 0) Then
            cbSucursal.ReadOnly = True
        Else
            cbSucursal.ReadOnly = False
        End If


        swTipoVenta.IsReadOnly = False
        btnGrabar.Enabled = True
    End Sub
    Public Sub _prFiltrar()
        'cargo el buscador
        Dim _Mpos As Integer
        _prCargarCompra()
        If grCompra.RowCount > 0 Then
            _Mpos = 0
            grCompra.Row = _Mpos
        Else
            _Limpiar()
            LblPaginacion.Text = "0/0"
        End If
    End Sub
    Private Sub _Limpiar()
        tbnrocod.Clear()
        tbCodigo.Clear()
        tbProveedor.Clear()
        tbObservacion.Clear()
        If (CType(cbSucursal.DataSource, DataTable).Rows.Count > 0) Then
            cbSucursal.SelectedIndex = 0
        Else
            cbSucursal.SelectedIndex = -1
        End If
        swTipoVenta.Value = True
        _CodProveedor = 0
        tbFechaVenta.Value = Now.Date
        tbFechaVenc.Visible = False
        lbCredito.Visible = False
        _prCargarDetalleVenta(-1)

        MSuperTabControl.SelectedTabIndex = 0

        tbPdesc.Value = 0
        tbMdesc.Value = 0
        tbtotal.Value = 0
        With grdetalle.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar"
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = True
        End With
        _prAddDetalleVenta()

        tbProveedor.Focus()
        Table_Producto = Nothing

        tbnrocod.Text = _fnSiguienteNumiCompra() + 1
    End Sub
    Public Function _fnSiguienteNumiCompra() As Integer
        Dim dt As DataTable = CType(grCompra.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("canumi=MAX(canumi)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("canumi")
        End If
        Return 1
    End Function
    Public Sub _prMostrarRegistro(_N As Integer)
        '' grVentas.Row = _N
        'a.canumi ,a.caalm ,a.cafdoc ,a.caty4prov ,proveedor .yddesc as proveedor ,a.catven ,a.cafvcr ,
        'a.camon ,IIF(camon=1,'Boliviano','Dolar') as moneda,a.caest ,a.caobs ,
        'a.cadesc ,a.cafact ,a.cahact ,a.cauact,(Sum(b.cbptot)-a.cadesc ) as total

        With grCompra
            tbnrocod.Text = .GetValue("canumi")
            tbCodigo.Text = .GetValue("canumi")
            tbFechaVenta.Value = .GetValue("cafdoc")
            _CodProveedor = .GetValue("caty4prov")
            swTipoVenta.Value = .GetValue("catven")
            tbProveedor.Text = .GetValue("proveedor")
            cbSucursal.Value = .GetValue("caalm")
            tbObservacion.Text = .GetValue("caobs")


            'If (swTipoVenta.Value = False) Then

            tbFechaVenc.Value = .GetValue("cafvcr")
            'Else
            '    lbCredito.Visible = False
            '    tbFechaVenc.Visible = False
            'End If

            lbFecha.Text = CType(.GetValue("cafact"), Date).ToString("dd/MM/yyyy")
            lbHora.Text = .GetValue("cahact").ToString
            lbUsuario.Text = .GetValue("cauact").ToString

        End With

        _prCargarDetalleVenta(tbCodigo.Text)
        tbMdesc.Value = grCompra.GetValue("cadesc")
        _prCalcularPrecioTotal()
        LblPaginacion.Text = Str(grCompra.Row + 1) + "/" + grCompra.RowCount.ToString

    End Sub

    Private Sub _prCargarDetalleVenta(_numi As String)
        Dim dt As New DataTable
        dt = L_fnDetalleCompra(_numi)
        grdetalle.DataSource = dt
        grdetalle.RetrieveStructure()
        grdetalle.AlternatingColors = True
        '      a.cbnumi ,a.cbtv1numi ,a.cbty5prod ,b.yfcdprod1 as producto,a.cbest ,a.cbcmin 
        ',a.cbumin ,Umin .ycdes3 as unidad,a.cbpcost,a.cblote ,a.cbfechavenc ,a.cbptot 
        ',a.cbutven ,a.cbprven   ,a.cbobs ,
        'a.cbfact ,a.cbhact ,a.cbuact,1 as estado,Cast(null as Image) as img,a.cbpcost as costo,a.cbprven as venta
        If (Lote = True) Then
            With grdetalle.RootTable.Columns("cblote")
                .Width = 150
                .Caption = "LOTE"
                .Visible = False
                .MaxLength = 50
            End With
            With grdetalle.RootTable.Columns("cbfechavenc")
                .Width = 150
                .Caption = "FECHA VENC."
                .Visible = False
                .FormatString = "dd/MM/yyyy"
            End With
        Else
            With grdetalle.RootTable.Columns("cblote")
                .Width = 150
                .Caption = "LOTE"
                .Visible = False
                .MaxLength = 50
            End With
            With grdetalle.RootTable.Columns("cbfechavenc")
                .Width = 150
                .Caption = "FECHA VENC."
                .Visible = False
                .FormatString = "dd/MM/yyyy"
            End With
        End If


        With grdetalle.RootTable.Columns("cbnumi")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = False
        End With

        With grdetalle.RootTable.Columns("cbtv1numi")
            .Width = 90
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("cbty5prod")
            .Width = 90
            .Visible = False
        End With

        With grdetalle.RootTable.Columns("producto")
            .Caption = "PRODUCTOS"
            .Width = 600
            .Visible = True

        End With
        With grdetalle.RootTable.Columns("cbest")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With

        With grdetalle.RootTable.Columns("cbcmin")
            .Width = 160
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0"
            .Caption = "Cantidad".ToUpper
        End With
        With grdetalle.RootTable.Columns("cbumin")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("unidad")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
            .Caption = "Unidad".ToUpper
        End With
        With grdetalle.RootTable.Columns("cbpcost")
            .Width = 120
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Precio U.".ToUpper
        End With
        If (_estadoPor = 1) Then
            With grdetalle.RootTable.Columns("cbutven")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .Caption = "Utilidad (%)".ToUpper
            End With
            With grdetalle.RootTable.Columns("cbprven")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .Caption = "Precio Venta.".ToUpper
            End With
        Else
            With grdetalle.RootTable.Columns("cbutven")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .Caption = "Utilidad.".ToUpper
            End With
            With grdetalle.RootTable.Columns("cbprven")
                .Width = 120
                .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                .Visible = False
                .FormatString = "0.00"
                .Caption = "Precio Venta.".ToUpper
            End With
        End If

        With grdetalle.RootTable.Columns("cbptot")
            .Width = 100
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .FormatString = "0.00"
            .Caption = "Sub Total".ToUpper
        End With
        With grdetalle.RootTable.Columns("cbobs")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("cbfact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("cbhact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("cbuact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("estado")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("costo")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("img")
            .Width = 80
            .Caption = "Eliminar".ToUpper
            .CellStyle.ImageHorizontalAlignment = ImageHorizontalAlignment.Center
            .Visible = False
        End With
        With grdetalle.RootTable.Columns("venta")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = False
        End With
        With grdetalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With
    End Sub

    Private Sub _prCargarCompra()
        Dim dt As New DataTable
        dt = L_fnGeneralCompras()
        grCompra.DataSource = dt
        grCompra.RetrieveStructure()
        grCompra.AlternatingColors = True


        With grCompra.RootTable.Columns("canumi")
            .Width = 100
            .Caption = "CODIGO"
            .Visible = True

        End With

        With grCompra.RootTable.Columns("caalm")
            .Width = 90
            .Visible = False
        End With
        With grCompra.RootTable.Columns("cafdoc")
            .Width = 90
            .Visible = True
            .Caption = "FECHA"
        End With

        With grCompra.RootTable.Columns("caty4prov")
            .Width = 160
            .Visible = False
        End With
        With grCompra.RootTable.Columns("proveedor")
            .Width = 250
            .Visible = True
            .Caption = "proveedor".ToUpper
        End With


        With grCompra.RootTable.Columns("catven")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With

        With grCompra.RootTable.Columns("cafvcr")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        '     a.canumi ,a.caalm ,a.cafdoc ,a.caty4prov ,proveedor .yddesc as proveedor ,a.catven ,a.cafvcr ,
        'a.camon ,IIF(camon=1,'Boliviano','Dolar') as moneda,a.caest ,a.caobs ,
        'a.cadesc ,a.cafact ,a.cahact ,a.cauact,(Sum(b.cbptot)-a.cadesc ) as total



        With grCompra.RootTable.Columns("camon")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("moneda")
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
            .Caption = "MONEDA"
        End With
        With grCompra.RootTable.Columns("caobs")
            .Width = 200
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = True
            .Caption = "OBSERVACION"
        End With
        With grCompra.RootTable.Columns("cadesc")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("caest")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("cafact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("cahact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("cauact")
            .Width = 50
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            .Visible = False
        End With
        With grCompra.RootTable.Columns("total")
            .Width = 150
            .CellStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
            .Visible = True
            .Caption = "TOTAL"
            .FormatString = "0.00"
        End With
        With grCompra
            .DefaultFilterRowComparison = FilterConditionOperator.BeginsWith
            .FilterMode = FilterMode.Automatic
            .FilterRowUpdateMode = FilterRowUpdateMode.WhenValueChanges
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007
        End With

        If (dt.Rows.Count <= 0) Then
            _prCargarDetalleVenta(-1)
        End If
    End Sub
    Private Sub _prCargarProductos(_cliente As String)

        Dim dtname As DataTable = L_fnNameLabel()
        Dim dt As New DataTable
        If (cbSucursal.SelectedIndex < 0) Then
            Return
        End If

        dt = L_fnListarProductosCompra(cbSucursal.Value, 73, CType(grdetalle.DataSource, DataTable))
        Dim listEstCeldas As New List(Of Modelo.Celda)
        '     a.yfnumi, a.yfcdprod1
        ',b.yhprecio,prevent.yhprecio as venta ,stock
        listEstCeldas.Add(New Modelo.Celda("yfnumi,", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("yfcdprod1", True, "Producto", 350))
        listEstCeldas.Add(New Modelo.Celda("yhprecio,", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("venta,", False, "ID", 50))
        listEstCeldas.Add(New Modelo.Celda("stock", True, "Stock", 70))


        Dim frmAyuda As Modelo.ModeloAyuda2
        frmAyuda = New Modelo.ModeloAyuda2(900, 60, dt, "", listEstCeldas, "Producto", "yfcdprod1")
        'Dim frmAyuda As Fr_Ayuda = New Fr_Ayuda(900, 60, dt, "Lista", listEstCeldas)

        'frmAyuda = New Modelo.ModeloAyuda2(alto, ancho, dt, Context.ToUpper, listEstCeldas, NameLabel, NamelColumna)
        Dim tamano As Size = New Size((42 * Me.Size.Width) / 100, Me.Size.Height)

        frmAyuda.Size = tamano

        frmAyuda.ShowDialog()
        If frmAyuda.seleccionado = True Then
            Dim Row As Janus.Windows.GridEX.GridEXRow
            Row = frmAyuda.filaSelect
            Dim pos As Integer = -1
            grdetalle.Row = grdetalle.RowCount - 1
            _fnObtenerFilaDetalle(pos, grdetalle.GetValue("cbnumi"))
            Dim existe As Boolean = _fnExisteProducto(Row.Cells("yfnumi").Value)
            If ((pos >= 0) And (Not existe)) Then
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbty5prod") = Row.Cells("yfnumi").Value
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("producto") = Row.Cells("yfcdprod1").Value
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost") = Row.Cells("yhprecio").Value
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = 0
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbcmin") = 0

                Dim PrecioVenta As Double = IIf(IsDBNull(Row.Cells("venta").Value), 0, Row.Cells("venta").Value)
                If (PrecioVenta > 0) Then
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = PrecioVenta
                    Dim montodesc As Double = PrecioVenta - Row.Cells("yhprecio").Value
                    Dim precio As Integer = IIf(IsDBNull(Row.Cells("yhprecio").Value), 0, Row.Cells("yhprecio").Value)
                    If (precio = 0) Then
                        CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbutven") = 100
                    Else
                        Dim pordesc As Double = ((montodesc * 100) / Row.Cells("yhprecio").Value)
                        CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbutven") = pordesc
                    End If


                Else
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbutven") = _PorcentajeUtil
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = (Row.Cells("yhprecio").Value + ((Row.Cells("yhprecio").Value) * (_PorcentajeUtil / 100)))


                End If


                _prCalcularPrecioTotal()
                _DesHabilitarProductos()
            Else
                If (existe) Then
                    Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                    ToastNotification.Show(Me, "El producto ya existe en el detalle".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                End If
            End If
        End If
    End Sub
    Private Sub _prAddDetalleVenta()
        '     a.cbnumi ,a.cbtv1numi ,a.cbty5prod ,b.yfcdprod1 as producto,a.cbest ,a.cbcmin 
        ',a.cbumin ,Umin .ycdes3 as unidad,a.cbpcost,a.cblote ,a.cbfechavenc ,a.cbptot 
        ',a.cbutven ,a.cbprven   ,a.cbobs ,
        'a.cbfact ,a.cbhact ,a.cbuact,1 as estado,Cast(null as Image) as img,a.cbpcost as costo,a.cbprven as venta
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 20, 20)
        img.Save(Bin, Imaging.ImageFormat.Png)
        CType(grdetalle.DataSource, DataTable).Rows.Add(_fnSiguienteNumi() + 1, 0, 0, "", 0, 0, 0, "",
                                                        0, "20170101", CDate("2017/01/01"), 0, 0, 0, "", Now.Date, "", "", 0, Bin.GetBuffer, 0, 0)
    End Sub

    Public Function _fnSiguienteNumi()
        Dim dt As DataTable = CType(grdetalle.DataSource, DataTable)
        Dim rows() As DataRow = dt.Select("cbnumi=MAX(cbnumi)")
        If (rows.Count > 0) Then
            Return rows(rows.Count - 1).Item("cbnumi")
        End If
        Return 1
    End Function
    Public Function _fnAccesible()
        Return tbFechaVenta.IsInputReadOnly = False
    End Function
    Private Sub _HabilitarProductos()


        _prCargarProductos(73) ''''Aqui poner el Primer Precio de Costo

    End Sub
    Private Sub _DesHabilitarProductos()
        grdetalle.Select()
        grdetalle.Col = 5
        grdetalle.Row = grdetalle.RowCount - 1
        grdetalle.SetValue("cbcmin", DBNull.Value)
    End Sub
    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(grdetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(grdetalle.DataSource, DataTable).Rows(i).Item("cbnumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub

    Public Function _fnExisteProducto(idprod As Integer) As Boolean
        For i As Integer = 0 To CType(grdetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _idprod As Integer = CType(grdetalle.DataSource, DataTable).Rows(i).Item("cbty5prod")
            Dim estado As Integer = CType(grdetalle.DataSource, DataTable).Rows(i).Item("estado")
            If (_idprod = idprod And estado >= 0) Then

                Return True
            End If
        Next
        Return False
    End Function
    Public Sub P_PonerTotal(rowIndex As Integer)
        If (rowIndex < grdetalle.RowCount) Then

            Dim lin As Integer = grdetalle.GetValue("cbnumi")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim cant As Double = grdetalle.GetValue("cbcmin")
            Dim uni As Double = grdetalle.GetValue("cbpcost")
            If (pos >= 0) Then
                Dim TotalUnitario As Double = cant * uni
                'grDetalle.SetValue("lcmdes", montodesc)

                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = TotalUnitario
                grdetalle.SetValue("cbptot", TotalUnitario)
                Dim estado As Integer = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = uni + (uni * (grdetalle.GetValue("cbutven") / 100))
                grdetalle.SetValue("cbprven", uni + (uni * (grdetalle.GetValue("cbutven") / 100)))
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta") = uni + (uni * (grdetalle.GetValue("cbutven") / 100))
                grdetalle.SetValue("cbprven", uni + (uni * (grdetalle.GetValue("cbutven") / 100)))
            End If
            _prCalcularPrecioTotal()
        End If



    End Sub
    Public Sub _prCalcularPrecioTotal()
        Dim montodesc As Double = tbMdesc.Value
        Dim pordesc As Double = ((montodesc * 100) / grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum))
        tbPdesc.Value = pordesc
        tbtotal.Value = grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum) - montodesc
    End Sub
    Public Sub _prEliminarFila()
        If (grdetalle.Row >= 0) Then
            If (grdetalle.RowCount >= 2) Then
                Dim estado As Integer = grdetalle.GetValue("estado")
                Dim pos As Integer = -1
                Dim lin As Integer = grdetalle.GetValue("cbnumi")
                _fnObtenerFilaDetalle(pos, lin)
                If (estado = 0) Then
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = -2

                End If
                If (estado = 1) Then
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = -1
                End If
                grdetalle.RootTable.ApplyFilter(New Janus.Windows.GridEX.GridEXFilterCondition(grdetalle.RootTable.Columns("estado"), Janus.Windows.GridEX.ConditionOperator.GreaterThanOrEqualTo, 0))
                _prCalcularPrecioTotal()
                grdetalle.Select()
                grdetalle.Col = 5
                grdetalle.Row = grdetalle.RowCount - 1
            End If
        End If


    End Sub
    Public Function _ValidarCampos() As Boolean
        If (_CodProveedor <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Por Favor Seleccione un Proveedor con Ctrl+Enter".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            tbProveedor.Focus()
            Return False

        End If

        If (grdetalle.RowCount = 1) Then
            grdetalle.Row = grdetalle.RowCount - 1
            If (grdetalle.GetValue("cbty5prod") = 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor Seleccione  un detalle de producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                Return False
            End If
            If (IsDBNull(grdetalle.GetValue("cbcmin"))) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor inserte una cantidad al producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                grdetalle.Select()
                grdetalle.Col = 5
                grdetalle.Focus()
                Return False
            End If
            If (grdetalle.GetValue("cbcmin") <= 0) Then
                Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                ToastNotification.Show(Me, "Por Favor inserte una cantidad al producto".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                grdetalle.Select()
                grdetalle.Col = 5
                grdetalle.Focus()
                Return False
            End If
        End If
        If (cbSucursal.SelectedIndex < 0) Then


            Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
            ToastNotification.Show(Me, "Por Favor Seleccione una Sucursal".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            tbProveedor.Focus()
            Return False


        End If
        Return True
    End Function

    Public Sub _GuardarNuevo()


        '_canumi As String, _caalm As Integer, _cafdoc As String, _caTy4prov As Integer, _catven As Integer, _cafvcr As String,
        '                                   _camon As Integer, _caobs As String,
        '                                   _cadesc As Double, detalle As DataTable
        Dim res As Boolean = L_fnGrabarCompra("", cbSucursal.Value, tbFechaVenta.Value.ToString("yyyy/MM/dd"), _CodProveedor, IIf(swTipoVenta.Value = True, 1, 0), IIf(swTipoVenta.Value = True, Now.Date.ToString("yyyy/MM/dd"), tbFechaVenc.Value.ToString("yyyy/MM/dd")), 0, tbObservacion.Text, tbMdesc.Value, tbtotal.Value, CType(grdetalle.DataSource, DataTable))


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Compra ".ToUpper + tbCodigo.Text + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )

            _prCargarCompra()

            _prSalir()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If

    End Sub
    Private Sub _prGuardarModificado()
        Dim res As Boolean = L_fnModificarCompra(tbCodigo.Text, cbSucursal.Value, tbFechaVenta.Value.ToString("yyyy/MM/dd"), _CodProveedor, IIf(swTipoVenta.Value = True, 1, 0), IIf(swTipoVenta.Value = True, Now.Date.ToString("yyyy/MM/dd"), tbFechaVenc.Value.ToString("yyyy/MM/dd")), cbSucursal.Value, tbObservacion.Text, tbMdesc.Value, tbtotal.Value, CType(grdetalle.DataSource, DataTable))
        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Código de Compra ".ToUpper + tbCodigo.Text + " Modificado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )
            _prCargarCompra()

            _prSalir()


        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser Modificada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
    End Sub
    Private Sub _prSalir()
        If btnGrabar.Enabled = True Then
            _prInhabiliitar()
            If grCompra.RowCount > 0 Then

                Dim _pos As Integer = grCompra.Row
                If grCompra.RowCount > 0 Then
                    _pos = grCompra.RowCount - 1
                    _prMostrarRegistro(_pos)
                    grCompra.Row = _pos
                End If

            End If
        Else
            Me.Close()


        End If
    End Sub
    Public Sub _prCargarIconELiminar()
        For i As Integer = 0 To CType(grdetalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim Bin As New MemoryStream
            Dim img As New Bitmap(My.Resources.delete, 20, 20)
            img.Save(Bin, Imaging.ImageFormat.Png)
            CType(grdetalle.DataSource, DataTable).Rows(i).Item("img") = Bin.GetBuffer
            grdetalle.RootTable.Columns("img").Visible = True
        Next

    End Sub
    Public Sub _PrimerRegistro()
        Dim _MPos As Integer
        If grCompra.RowCount > 0 Then
            _MPos = 0
            ''   _prMostrarRegistro(_MPos)
            grCompra.Row = _MPos
        End If
    End Sub




#End Region


#Region "Eventos Formulario"
    Private Sub F0_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()


    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        _Limpiar()
        _prhabilitar()

        btnNuevo.Enabled = False
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
        btnGrabar.Enabled = True
        PanelNavegacion.Enabled = False


    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        _prSalir()

    End Sub

    Private Sub tbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles tbProveedor.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Control + Keys.Enter Then

                Dim dt As DataTable

                dt = L_fnListarProveedores()
                '              a.ydnumi, a.ydcod, a.yddesc, a.yddctnum, a.yddirec
                ',a.ydtelf1 ,a.ydfnac 

                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("ydnumi,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("ydcod", True, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("yddesc", True, "NOMBRE", 280))
                listEstCeldas.Add(New Modelo.Celda("yddctnum", True, "N. Documento".ToUpper, 150))
                listEstCeldas.Add(New Modelo.Celda("yddirec", True, "DIRECCION", 220))
                listEstCeldas.Add(New Modelo.Celda("ydtelf1", True, "Telefono".ToUpper, 200))
                listEstCeldas.Add(New Modelo.Celda("ydfnac", True, "F.Nacimiento".ToUpper, 150, "MM/dd,YYYY"))
                Dim ef = New Efecto
                ef.tipo = 5
                ef.dt = dt
                ef.SeleclCol = 2
                ef.listEstCeldas = listEstCeldas
                ef.alto = 50
                ef.NameLabel = "PROVEEDOR: "
                ef.NamelColumna = "yddesc"
                ef.ancho = 350
                ef.Context = "Seleccione Proveedor".ToUpper
                ef.ShowDialog()
                Dim bandera As Boolean = False
                bandera = ef.band
                If (bandera = True) Then
                    Try
                        Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row

                        _CodProveedor = Row.Cells("ydnumi").Value
                        tbProveedor.Text = Row.Cells("yddesc").Value
                        grdetalle.Select()
                        grdetalle.Col = 2
                        grdetalle.Focus()
                    Catch ex As Exception

                    End Try


                End If

            End If

        End If




    End Sub

    Private Sub swTipoVenta_ValueChanged(sender As Object, e As EventArgs) Handles swTipoVenta.ValueChanged
        If (swTipoVenta.Value = False) Then
            lbCredito.Visible = True
            tbFechaVenc.Visible = True
            tbFechaVenc.Value = Now.Date
        Else
            lbCredito.Visible = False
            tbFechaVenc.Visible = False
        End If
    End Sub

    Private Sub grdetalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles grdetalle.EditingCell
        If (_fnAccesible()) Then


            If (_estadoPor = 0) Then
                If (e.Column.Index = grdetalle.RootTable.Columns("cbcmin").Index Or e.Column.Index = grdetalle.RootTable.Columns("cbpcost").Index) Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Else

                If (e.Column.Index = grdetalle.RootTable.Columns("cbcmin").Index Or e.Column.Index = grdetalle.RootTable.Columns("cbpcost").Index Or e.Column.Index = grdetalle.RootTable.Columns("cbprven").Index Or e.Column.Index = grdetalle.RootTable.Columns("cbutven").Index Or e.Column.Index = grdetalle.RootTable.Columns("cblote").Index Or e.Column.Index = grdetalle.RootTable.Columns("cbfechavenc").Index) Then
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            End If

        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub grdetalle_Enter(sender As Object, e As EventArgs) Handles grdetalle.Enter

        If (_fnAccesible()) Then
            If (_CodProveedor <= 0) Then
                ToastNotification.Show(Me, "           Antes de Continuar Por favor Seleccione un Proveedor!!             ", My.Resources.WARNING, 4000, eToastGlowColor.Red, eToastPosition.TopCenter)
                tbProveedor.Focus()

                Return
            End If


            'grdetalle.Select()
            'grdetalle.Col = 2
            'grdetalle.Row = 0
        End If


    End Sub
    Private Sub grdetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles grdetalle.KeyDown
        If (Not _fnAccesible()) Then
            Return
        End If
        If (e.KeyData = Keys.Enter) Then
            Dim f, c As Integer
            c = grdetalle.Col
            f = grdetalle.Row

            If (grdetalle.Col = grdetalle.RootTable.Columns("cbcmin").Index) Then
                If (grdetalle.GetValue("producto") <> String.Empty) Then
                    _prAddDetalleVenta()
                    _HabilitarProductos()
                Else
                    ToastNotification.Show(Me, "Seleccione un Producto Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                End If

            End If
            If (grdetalle.Col = grdetalle.RootTable.Columns("producto").Index) Then
                If (grdetalle.GetValue("producto") <> String.Empty) Then
                    _prAddDetalleVenta()
                    _HabilitarProductos()
                Else
                    ToastNotification.Show(Me, "Seleccione un Producto Por Favor", My.Resources.WARNING, 3000, eToastGlowColor.Red, eToastPosition.TopCenter)
                End If

            End If
salirIf:
        End If

        If (e.KeyData = Keys.Control + Keys.Enter And grdetalle.Row >= 0 And
            grdetalle.Col = grdetalle.RootTable.Columns("producto").Index) Then
            Dim indexfil As Integer = grdetalle.Row
            Dim indexcol As Integer = grdetalle.Col
            _HabilitarProductos()

        End If
        If (e.KeyData = Keys.Escape And grdetalle.Row >= 0) Then

            _prEliminarFila()


        End If
        If (e.KeyData = Keys.Control + Keys.A) Then
            btnGrabar.Focus()
        End If

    End Sub

    Private Sub grdetalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles grdetalle.CellValueChanged
        Dim lin As Integer = grdetalle.GetValue("cbnumi")
        Dim pos As Integer = -1
        _fnObtenerFilaDetalle(pos, lin)
        If (e.Column.Index = grdetalle.RootTable.Columns("cbcmin").Index) Then
            If (Not IsNumeric(grdetalle.GetValue("cbcmin")) Or grdetalle.GetValue("cbcmin").ToString = String.Empty Or IsDBNull(grdetalle.GetValue("cbcmin"))) Then
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbcmin") = 0
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = 0
            Else
                If (grdetalle.GetValue("cbcmin") > 0) Then
                    Dim rowIndex As Integer = grdetalle.Row
                    P_PonerTotal(rowIndex)
                Else

                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbcmin") = 0
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = 0
                    _prCalcularPrecioTotal()
                End If
            End If
        End If

        ''''''''''''''''''''''COSTO  ''''''''''''''''''''''''''''''''''''''''''
        If (e.Column.Index = grdetalle.RootTable.Columns("cbpcost").Index) Then
            If (Not IsNumeric(grdetalle.GetValue("cbpcost")) Or grdetalle.GetValue("cbpcost").ToString = String.Empty) Then

                Dim cantidad As Double = IIf(IsDBNull(grdetalle.GetValue("cbcmin")), 0, grdetalle.GetValue("cbcmin"))
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = cantidad * CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = _PorcentajeUtil * CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")


            Else
                If (grdetalle.GetValue("cbpcost") > 0) Then
                    Dim rowIndex As Integer = grdetalle.Row
                    P_PonerTotal(rowIndex)
                Else

                    Dim cantidad As Double = IIf(IsDBNull(grdetalle.GetValue("cbcmin")), 0, grdetalle.GetValue("cbcmin"))
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbptot") = cantidad * CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = _PorcentajeUtil * CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                End If
            End If
        End If

        ''''''''''''''''''PRECIO VENTA '''''''''   CONTINUARA  '''''''''''''
        'Habilitar solo las columnas de Precio, %, Monto y Observación
        '     a.cbnumi ,a.cbtv1numi ,a.cbty5prod ,b.yfcdprod1 as producto,a.cbest ,a.cbcmin ,a.cbumin ,Umin .ycdes3 as unidad,a.cbpcost 
        ',a.cbutven ,a.cbprven  ,a.cbptot ,a.cbobs ,
        'a.cbfact ,a.cbhact ,a.cbuact,1 as escado,Cast(null as Image) as img,costo,venta
        If (e.Column.Index = grdetalle.RootTable.Columns("cbprven").Index) Then
            If (Not IsNumeric(grdetalle.GetValue("cbprven")) Or grdetalle.GetValue("cbprven").ToString = String.Empty) Then

                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta")
                Dim montodesc As Double = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta") - grdetalle.GetValue("cbpcost")
                Dim pordesc As Double = ((montodesc * 100) / CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost"))
            Else
                If (grdetalle.GetValue("cbprven") > 0) Then


                    Dim montodesc As Double = grdetalle.GetValue("cbprven") - CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                    Dim pordesc As Double = ((montodesc * 100) / CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost"))
                    grdetalle.SetValue("cbutven", pordesc)

                Else

                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta")
                    Dim montodesc As Double = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta") - CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                    Dim pordesc As Double = ((montodesc * 100) / CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost"))
                End If
            End If
        End If



        ''''''''''''''''''PORCENTAJE PRECIO VENTA '''''''''   CONTINUARA  '''''''''''''
        'Habilitar solo las columnas de Precio, %, Monto y Observación
        '     a.cbnumi ,a.cbtv1numi ,a.cbty5prod ,b.yfcdprod1 as producto,a.cbest ,a.cbcmin ,a.cbumin ,Umin .ycdes3 as unidad,a.cbpcost 
        ',a.cbutven ,a.cbprven  ,a.cbptot ,a.cbobs ,
        'a.cbfact ,a.cbhact ,a.cbuact,1 as escado,Cast(null as Image) as img,costo,venta
        If (e.Column.Index = grdetalle.RootTable.Columns("cbutven").Index) Then

            Dim venta As Double = IIf(IsDBNull(CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta")), 0, CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta"))
            Dim PrecioCosto As Double = IIf(IsDBNull(grdetalle.GetValue("cbpcost")), 0, grdetalle.GetValue("cbpcost"))
            If (Not IsNumeric(grdetalle.GetValue("cbutven")) Or grdetalle.GetValue("cbutven").ToString = String.Empty) Then

                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta")
                Dim montodesc As Double = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta") - grdetalle.GetValue("cbpcost")

                Dim pordesc As Double = ((montodesc * 100) / CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost"))

                CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbutven") = pordesc
            Else
                If (grdetalle.GetValue("cbutven") > 0) Then

                    Dim porcentaje As Double = grdetalle.GetValue("cbutven")

                    Dim monto As Double = (grdetalle.GetValue("cbpcost") * (porcentaje / 100))
                    Dim precioventa As Double = monto + grdetalle.GetValue("cbpcost")
                    grdetalle.SetValue("cbprven", precioventa)



                Else

                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbprven") = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta")
                    Dim montodesc As Double = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("venta") - CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost")
                    Dim pordesc As Double = ((montodesc * 100) / CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbpcost"))
                    CType(grdetalle.DataSource, DataTable).Rows(pos).Item("cbutven") = pordesc
                End If
            End If
        End If
        Dim estado As Integer = CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado")
        If (estado = 1) Then
            CType(grdetalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
        End If
    End Sub
    Private Sub tbPdesc_ValueChanged(sender As Object, e As EventArgs) Handles tbPdesc.ValueChanged
        If (tbPdesc.Focused) Then
            If (Not tbPdesc.Text = String.Empty And Not tbtotal.Text = String.Empty) Then
                If (tbPdesc.Value = 0 Or tbPdesc.Value > 100) Then
                    tbPdesc.Value = 0
                    tbMdesc.Value = 0

                    _prCalcularPrecioTotal()

                Else

                    Dim porcdesc As Double = tbPdesc.Value
                    Dim montodesc As Double = (grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum) * (porcdesc / 100))
                    tbMdesc.Value = montodesc
                    tbtotal.Value = grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum) - montodesc
                End If


            End If
            If (tbPdesc.Text = String.Empty) Then
                tbMdesc.Value = 0

            End If
        End If
    End Sub

    Private Sub tbMdesc_ValueChanged(sender As Object, e As EventArgs) Handles tbMdesc.ValueChanged
        If (tbMdesc.Focused) Then

            Dim total As Double = tbtotal.Value
            If (Not tbMdesc.Text = String.Empty And Not tbMdesc.Text = String.Empty) Then
                If (tbMdesc.Value = 0 Or tbMdesc.Value > total) Then
                    tbMdesc.Value = 0
                    tbPdesc.Value = 0
                    _prCalcularPrecioTotal()
                Else
                    Dim montodesc As Double = tbMdesc.Value
                    Dim pordesc As Double = ((montodesc * 100) / grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum))
                    tbPdesc.Value = pordesc
                    tbtotal.Value = grdetalle.GetTotal(grdetalle.RootTable.Columns("cbptot"), AggregateFunction.Sum) - montodesc

                End If

            End If

            If (tbMdesc.Text = String.Empty) Then
                tbMdesc.Value = 0

            End If
        End If

    End Sub


    Private Sub grdetalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles grdetalle.CellEdited
        If (e.Column.Index = grdetalle.RootTable.Columns("cbcmin").Index) Then
            If (Not IsNumeric(grdetalle.GetValue("cbcmin")) Or grdetalle.GetValue("cbcmin").ToString = String.Empty Or IsDBNull(grdetalle.GetValue("cbcmin"))) Then

                grdetalle.SetValue("cbcmin", 0)
                grdetalle.SetValue("cbptot", 0)
            Else
                If (grdetalle.GetValue("cbcmin") > 0) Then


                Else

                    grdetalle.SetValue("cbcmin", 0)
                    grdetalle.SetValue("cbptot", 0)

                End If
            End If
        End If
    End Sub
    Private Sub grdetalle_MouseClick(sender As Object, e As MouseEventArgs) Handles grdetalle.MouseClick
        If (Not _fnAccesible()) Then
            Return
        End If
        If (grdetalle.RowCount >= 2) Then
            If (grdetalle.CurrentColumn.Index = grdetalle.RootTable.Columns("img").Index) Then
                _prEliminarFila()
            End If
        End If


    End Sub
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If _ValidarCampos() = False Then
            Exit Sub
        End If

        If (tbCodigo.Text = String.Empty) Then
            _GuardarNuevo()
        Else
            If (tbCodigo.Text <> String.Empty) Then
                _prGuardarModificado()
                ''    _prInhabiliitar()

            End If
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If (grCompra.RowCount > 0) Then
            _prhabilitar()
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            btnGrabar.Enabled = True

            PanelNavegacion.Enabled = False
            _prCargarIconELiminar()
        End If


    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Dim ef = New Efecto


        ef.tipo = 2
        ef.Context = "¿esta seguro de eliminar el registro?".ToUpper
        ef.Header = "mensaje principal".ToUpper
        ef.ShowDialog()
        Dim bandera As Boolean = False
        bandera = ef.band
        If (bandera = True) Then
            Dim mensajeError As String = ""
            Dim res As Boolean = L_fnEliminarCompra(tbCodigo.Text, mensajeError)
            If res Then


                Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)

                ToastNotification.Show(Me, "Código de Compra ".ToUpper + tbCodigo.Text + " eliminado con Exito.".ToUpper,
                                          img, 2000,
                                          eToastGlowColor.Green,
                                          eToastPosition.TopCenter)

                _prFiltrar()

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, mensajeError, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            End If
        End If

    End Sub

    Private Sub grVentas_SelectionChanged(sender As Object, e As EventArgs) Handles grCompra.SelectionChanged
        If (grCompra.RowCount >= 0 And grCompra.Row >= 0) Then

            _prMostrarRegistro(grCompra.Row)
        End If


    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim _pos As Integer = grCompra.Row
        If _pos < grCompra.RowCount - 1 And _pos >= 0 Then
            _pos = grCompra.Row + 1
            '' _prMostrarRegistro(_pos)
            grCompra.Row = _pos
        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Dim _pos As Integer = grCompra.Row
        If grCompra.RowCount > 0 Then
            _pos = grCompra.RowCount - 1
            ''  _prMostrarRegistro(_pos)
            grCompra.Row = _pos
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim _MPos As Integer = grCompra.Row
        If _MPos > 0 And grCompra.RowCount > 0 Then
            _MPos = _MPos - 1
            ''  _prMostrarRegistro(_MPos)
            grCompra.Row = _MPos
        End If
    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        _PrimerRegistro()
    End Sub
    Private Sub grVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles grCompra.KeyDown
        If e.KeyData = Keys.Enter Then
            MSuperTabControl.SelectedTabIndex = 0
            grdetalle.Focus()

        End If
    End Sub


    Private Sub cbSucursal_KeyDown(sender As Object, e As KeyEventArgs) Handles cbSucursal.KeyDown
        If (_fnAccesible()) Then
            If e.KeyData = Keys.Enter Then
                grdetalle.Focus()
                'grdetalle.Select()
                'grdetalle.Col = 3
                'grdetalle.Row = 0
            End If
        End If

    End Sub

    Private Sub cbSucursal_ValueChanged(sender As Object, e As EventArgs) Handles cbSucursal.ValueChanged
        If (tbObservacion.ReadOnly = False) Then

            _prCargarDetalleVenta(-1)
            _prAddDetalleVenta()
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        P_GenerarReporte()
    End Sub
    Private Sub P_GenerarReporte()
        Dim dt As DataTable = L_fnNotaCompras(tbnrocod.Text)
        If Not IsNothing(P_Global.Visualizador) Then
            P_Global.Visualizador.Close()
        End If

        P_Global.Visualizador = New Visualizador

        Dim objrep As New R_ReporteCompra
        objrep.SetDataSource(dt)
        objrep.SetParameterValue("usuario", gs_user)
        P_Global.Visualizador.CrGeneral.ReportSource = objrep 'Comentar
        P_Global.Visualizador.Show() 'Comentar
        P_Global.Visualizador.BringToFront() 'Comentar
    End Sub
#End Region




End Class