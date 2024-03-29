﻿Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.ToolTips
Imports System.Drawing
Imports DevComponents.DotNetBar.Controls
Imports System.Threading
Imports System.Drawing.Text
Imports Logica.AccesoLogica
Imports Janus.Windows.GridEX
Imports DevComponents.DotNetBar
Imports System.IO
Imports DevComponents.DotNetBar.SuperGrid
Imports GMap.NET.MapProviders
Imports GMap.NET
Imports GMap.NET.WindowsForms.Markers
Imports System.Reflection
Imports System.Runtime.InteropServices
Public Class F0_Cobrar_Vendedor
#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim bandera As Boolean = False
    Dim Bin As New MemoryStream
#End Region
    ''Evita el parpadeo de las ventanas''
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle Or &H2000000
    '        Return cp
    '    End Get
    'End Property
#Region "METODOS PRIVADOS"

    Private Sub _IniciarTodo()


        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        'Me.WindowState = FormWindowState.Maximized
        _prAsignarPermisos()
        Me.Text = "PAGO CLIENTE POR VENDEDOR"
        Dim blah As New Bitmap(New Bitmap(My.Resources.cobro), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
        _prCargarTablaPagos2(-1)
        tbCodigo.ReadOnly = True
        tbNombre.ReadOnly = True
        tbFechaVenta.Value = Now.Date
        tbFechaFactura.Value = Now.Date
        tbnrodoc.Focus()

    End Sub
    Private Sub _prCargarTablaPagos2(_numi As Integer)

        Dim dt As New DataTable
        dt = L_fnObtenerLasVentasCreditoPorVendedorFecha(_numi, tbFechaFactura.Value.ToString("yyyy/MM/dd"))

        '_prCargarIconDelete(dt)
        gr_detalle.DataSource = dt
        gr_detalle.RetrieveStructure()
        gr_detalle.AlternatingColors = True
        '      ' a.tcnumi, NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,  cliente,a.tcty4vend, vendedor,a.tcfdoc
        ',a.tcfvencre,totalfactura, pendiente, PagoAc, Pagar
        With gr_detalle.RootTable.Columns("factura")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("pendiente2")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tctv1numi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcty4vend")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("vendedor")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcnumi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("NroDoc")
            .Width = 120
            .Visible = True
            .TextAlignment = TextAlignment.Far
            .Caption = "Nro documento"
        End With

        With gr_detalle.RootTable.Columns("tcty4clie")
            .Width = 150
            .Visible = True
            .Caption = "Codigo Cliente"
        End With
        With gr_detalle.RootTable.Columns("cliente")
            .Width = 200
            .Visible = True
            .Caption = "Cliente"
        End With

        With gr_detalle.RootTable.Columns("tcfdoc")
            .Caption = "Fecha Factura"
            .Width = 120
            .TextAlignment = TextAlignment.Center
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("tcfvencre")
            .Caption = "Fecha Vencimiento"
            .TextAlignment = TextAlignment.Center
            .Width = 160
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("totalfactura")
            .Caption = "Monto Total"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("pendiente")
            .Caption = "Saldo"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("PagoAc")
            .Caption = "Total Pagado"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("Pagar")
            .Width = 100
            .Visible = True
            .Caption = "Pagar!"
        End With



        With gr_detalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007


            .VisualStyle = VisualStyle.Office2007


            .RowHeaders = InheritableBoolean.True
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        _prAplicarCondiccionJanus()
        _prCalcularTotal()
    End Sub

    Private Sub _Limpiar()

        tbCodigo.Clear()
        tbFechaVenta.Value = Now.Date
        tbNombre.Clear()
        tbTotalCobrado.Text = 0
        tbTotalCobrar.Text = 0
        tbSaldo.Text = 0
        tbCodigo.Clear()
        tbNombre.Clear()
        tbFechaFactura.Value = Now.Date
        _prCargarTablaPagos2(-1)
        '_prAddDetalle()
        tbCodigo.Focus()



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
    Private Sub _prCargarTablaPagos(_numi As Integer)

        Dim dt As New DataTable
        dt = L_fnObtenerLasVentasCreditoPorVendedorFecha(_numi, tbFechaFactura.Value.ToString("yyyy/MM/dd"))
        If (dt.Rows.Count <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "No Hay Datos Para Mostrar".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        '_prCargarIconDelete(dt)
        gr_detalle.DataSource = dt
        gr_detalle.RetrieveStructure()
        gr_detalle.AlternatingColors = True
        '      ' a.tcnumi, NroDoc,as factura,a.tctv1numi ,a.tcty4clie ,  cliente,a.tcty4vend, vendedor,a.tcfdoc
        ',a.tcfvencre,totalfactura, pendiente, PagoAc, Pagar
        With gr_detalle.RootTable.Columns("factura")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tctv1numi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcty4vend")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("vendedor")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("pendiente2")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("tcnumi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("NroDoc")
            .Width = 150
            .Visible = True
            .TextAlignment = TextAlignment.Far
            .Caption = "Nro documento"
        End With

        With gr_detalle.RootTable.Columns("tcty4clie")
            .Width = 150
            .Visible = False
            .Caption = "Codigo Cliente"
        End With

        With gr_detalle.RootTable.Columns("ydcod")
            .Width = 150
            .Visible = True
            .Caption = "Codigo Cliente"
        End With
        With gr_detalle.RootTable.Columns("cliente")
            .Width = 200
            .Visible = True
            .Caption = "Cliente"
        End With

        With gr_detalle.RootTable.Columns("tcfdoc")
            .Caption = "Fecha Factura"
            .Width = 120
            .TextAlignment = TextAlignment.Center
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("tcfvencre")
            .Caption = "Fecha Vencimiento"
            .TextAlignment = TextAlignment.Center
            .Width = 160
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("totalfactura")
            .Caption = "Monto Total"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("pendiente")
            .Caption = "Saldo"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("PagoAc")
            .Caption = "Total Pagado"
            .Width = 180
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("Pagar")
            .Width = 100
            .Visible = False
            .Caption = "Pagar!"
        End With



        With gr_detalle
            .GroupByBoxVisible = False
            'diseño de la grilla
            .VisualStyle = VisualStyle.Office2007


            .VisualStyle = VisualStyle.Office2007


            .RowHeaders = InheritableBoolean.True
            .TotalRow = InheritableBoolean.True
            .TotalRowFormatStyle.BackColor = Color.Gold
            .TotalRowPosition = TotalRowPosition.BottomFixed
        End With
        _prAplicarCondiccionJanus()
        _prCalcularTotal()
    End Sub
    Public Sub _prAplicarCondiccionJanus()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(gr_detalle.RootTable.Columns("pendiente"), ConditionOperator.Equal, 0)
        fc.FormatStyle.BackColor = Color.Green
        gr_detalle.RootTable.FormatConditions.Add(fc)
    End Sub


    Private Sub F0_Cobrar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub



    Private Sub Bt1Generar_Click(sender As Object, e As EventArgs) Handles Bt1Generar.Click
        If (tbCodigo.Text <> String.Empty) Then
            tbSaldo.Value = 0
            tbTotalCobrado.Value = 0
            tbTotalCobrar.Value = 0
            _prCargarTablaPagos(tbCodigo.Text)
        End If
    End Sub

    Private Sub gr_detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gr_detalle.EditingCell
        If (e.Column.Index = gr_detalle.RootTable.Columns("PagoAc").Index) Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub _prSumarTotales()
        Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)
        Dim Cobrado As Double = 0
        Dim Saldo As Double = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            Cobrado = Cobrado + dt.Rows(i).Item("PagoAc")
            Saldo = Saldo + dt.Rows(i).Item("pendiente")
        Next
        tbTotalCobrado.Value = Cobrado
        tbSaldo.Value = Saldo

    End Sub

    Private Sub gr_detalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellValueChanged
        ''Dim rowIndex As Integer = gr_detalle.CurrentRow.RowIndex
        ''Dim rowIndex As Integer = gr_detalle.CurrentRow.RowIndex
        Dim rowIndex As Integer = gr_detalle.Row
        'Columna de Precio Venta
        Dim ob As Boolean = gr_detalle.GetValue("Pagar")


        If (e.Column.Index = gr_detalle.RootTable.Columns("Pagar").Index) Then

            If (bandera = False) Then
                '''''''ÁQUI VERIFICO EL CHECK DE PAGAR TODO EL SALDO
                If (ob = True) Then
                    'pendiente, PagoAc, Pagar
                    tbTotalCobrado.Value = tbTotalCobrado.Value + gr_detalle.GetValue("pendiente2")
                    tbSaldo.Value = tbSaldo.Value - gr_detalle.GetValue("pendiente2")
                    gr_detalle.SetValue("PagoAc", gr_detalle.GetValue("pendiente2"))
                    gr_detalle.SetValue("pendiente", 0)
                    _prSumarTotales()

                Else
                    tbTotalCobrado.Value = tbTotalCobrado.Value - gr_detalle.GetValue("PagoAc")
                    tbSaldo.Value = tbSaldo.Value + gr_detalle.GetValue("PagoAc")
                    gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2") + gr_detalle.GetValue("PagoAc"))
                    gr_detalle.SetValue("PagoAc", 0)
                    _prSumarTotales()
                End If
                '_prCalcularTotal()
            End If

        End If
        ''''''''''''''Aqui se valida por el monto del saldo '''''''''''''''


        If (e.Column.Index = gr_detalle.RootTable.Columns("PagoAc").Index) Then


            If (Not IsNumeric(gr_detalle.GetValue("PagoAc")) Or gr_detalle.GetValue("PagoAc").ToString = String.Empty Or IsDBNull(gr_detalle.GetValue("PagoAc"))) Then

                Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2")
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = False

                gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2"))
                bandera = True
                gr_detalle.SetValue("pagar", False)
                bandera = False
                gr_detalle.SetValue("PagoAc", 0)
                _prSumarTotales()
            Else
                If (gr_detalle.GetValue("PagoAc") >= 0 And gr_detalle.GetValue("PagoAc") <= gr_detalle.GetValue("pendiente2")) Then
                    Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2") - gr_detalle.GetValue("PagoAc")
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = gr_detalle.GetValue("PagoAc")
                    gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2") - gr_detalle.GetValue("PagoAc"))
                    bandera = True
                    gr_detalle.SetValue("pagar", True)
                    bandera = False
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = True
                    'tbTotalCobrado.Value = tbTotalCobrado.Value + gr_detalle.GetValue("PagoAc")
                    'tbSaldo.Value = tbSaldo.Value - gr_detalle.GetValue("PagoAc")
                    _prSumarTotales()
                Else
                    If (gr_detalle.GetValue("PagoAc") > gr_detalle.GetValue("pendiente2")) Then
                        Dim img As Bitmap = New Bitmap(My.Resources.mensaje, 50, 50)
                        ToastNotification.Show(Me, "El monto a pagar es mayor al saldo: " + Str(gr_detalle.GetValue("pendiente2")), img, 5000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                        Dim lin As Integer = gr_detalle.GetValue("tcnumi")
                        Dim pos As Integer = -1
                        _fnObtenerFilaDetalle(pos, gr_detalle.GetValue("tcnumi"))
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pendiente2")
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("PagoAc") = 0

                        'gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente") + gr_detalle.GetValue("PagoAc"))
                        gr_detalle.SetValue("pendiente", gr_detalle.GetValue("pendiente2"))
                        gr_detalle.SetValue("PagoAc", 0)
                        bandera = True
                        gr_detalle.SetValue("pagar", False)
                        bandera = False
                        CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("pagar") = True
                        _prSumarTotales()

                    End If
                End If

            End If
        End If

    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(gr_detalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tcnumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
    Public Sub _prCalcularTotal()


        tbTotalCobrar.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
        tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""
        Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        If (tbCodigo.Text = String.Empty) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return

        End If
        If (CType(gr_detalle.DataSource, DataTable).Rows.Count <= 0) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return

        End If
        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagos(-1)
        Dim bandera As Boolean = False
        _prInterpretarDatosCobranza(dtCobro, bandera)
        If (bandera = False) Then
            ToastNotification.Show(Me, "Seleccione un detalle de la lista de pendientes".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return
        End If
        Dim res As Boolean = L_fnGrabarCobranza2(numi, tbFechaVenta.Value.ToString("yyyy/MM/dd"), 0, "", dtCobro)


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "El Pago Ha Sido ".ToUpper + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )


            _Limpiar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
    End Sub

#End Region

#Region "Eventos Formulario"
    Sub _prInterpretarDatosCobranza(ByRef dt As DataTable, ByRef bandera As Boolean)


        '       numidetalle, NroDoc, factura, numiCredito, numiCobranza, A.tctv1numi
        ',a.tcty4clie ,cliente,detalle.tdfechaPago, PagoAc, NumeroRecibo, DescBanco, banco, detalle.tdnrocheque,
        'img,estado,pendiente
        Dim Bin As New MemoryStream
        Dim img As New Bitmap(My.Resources.delete, 28, 28)
        img.Save(Bin, Imaging.ImageFormat.Png)
        Dim dtcobro As DataTable = CType(gr_detalle.DataSource, DataTable)
        For i As Integer = 0 To dtcobro.Rows.Count - 1 Step 1
            Dim pago As Double = dtcobro.Rows(i).Item("PagoAc")
            Dim estado As Boolean = dtcobro.Rows(i).Item("Pagar")
            If (estado = True) Then
                '             td.tdtv12numi ,@tenumi ,td.tdnrodoc ,@newFecha ,td.tdmonto ,td.tdnrorecibo ,td.tdty3banco,
                'td.tdnrocheque, @newFecha  ,@newHora  ,@teuact

                '              a.tcnumi, NroDoc,as factura, a.tctv1numi, a.tcty4clie, cliente, a.tcty4vend, vendedor, a.tcfdoc
                ',a.tcfvencre,totalfactura, pendiente, PagoAc, Pagar
                If (pago > 0) Then
                    dt.Rows.Add(0, dtcobro.Rows(i).Item("tcnumi"), 0, dtcobro.Rows(i).Item("NroDoc"),
                                            Now.Date, pago, 0, 1, 0, Now.Date,
                                            "", "", Bin.ToArray, 0)
                    bandera = True
                End If

            End If

        Next
    End Sub

    Private Sub ButtonX1_Click_1(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim numi As String = ""
        Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
        If (tbCodigo.Text = String.Empty) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return

        End If
        If (CType(gr_detalle.DataSource, DataTable).Rows.Count <= 0) Then
            ToastNotification.Show(Me, "No existen datos validos".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return

        End If
        Dim dtCobro As DataTable = L_fnCobranzasObtenerLosPagos(-1)
        Dim bandera As Boolean = False

        _prInterpretarDatosCobranza(dtCobro, bandera)
        If (bandera = False) Then
            ToastNotification.Show(Me, "Seleccione un detalle de la lista de pendientes".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return
        End If

        Dim res As Boolean = L_fnGrabarCobranza(numi, tbFechaVenta.Value.ToString("yyyy/MM/dd"), tbCodigo.Text, "", dtCobro)


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "El Pago Ha Sido ".ToUpper + " Grabado con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )


            _Limpiar()


        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Compra no pudo ser insertado".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
    End Sub

    Private Function _fnIsALl()
        Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1 Step 1

            If (CType(gr_detalle.DataSource, DataTable).Rows(i).Item("Pagar") = False) Then
                Return False
            End If



        Next
        Return True
    End Function

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)
        Dim b As Boolean = False
        Dim b2 As Boolean = _fnIsALl()
        If (tbTotalCobrado.Value >= 0) Then
            b = True
        Else
            b = False
        End If
        If (dt.Rows.Count > 0) Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step 1
                If (b = True) Then
                    If (CType(gr_detalle.DataSource, DataTable).Rows(i).Item("Pagar") = False) Then
                        CType(gr_detalle.DataSource, DataTable).Rows(i).Item("Pagar") = True

                        CType(gr_detalle.DataSource, DataTable).Rows(i).Item("PagoAc") = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("pendiente2")
                        CType(gr_detalle.DataSource, DataTable).Rows(i).Item("pendiente") = 0
                        tbTotalCobrado.Value = tbTotalCobrado.Value + CType(gr_detalle.DataSource, DataTable).Rows(i).Item("PagoAc")
                        tbSaldo.Value = 0
                    End If



                End If
                If (b2) Then
                    CType(gr_detalle.DataSource, DataTable).Rows(i).Item("Pagar") = False
                    tbTotalCobrado.Value = 0
                    tbSaldo.Value = tbTotalCobrar.Value

                    CType(gr_detalle.DataSource, DataTable).Rows(i).Item("pendiente") = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("PagoAc")
                    CType(gr_detalle.DataSource, DataTable).Rows(i).Item("PagoAc") = 0
                End If
            Next

        End If
    End Sub

    Private Sub tbnrodoc_KeyDown(sender As Object, e As KeyEventArgs) Handles tbnrodoc.KeyDown

        If e.KeyData = Keys.Enter Then
            Dim dt As DataTable
            If (tbnrodoc.Text = String.Empty) Then
                Return
            End If
            dt = L_fnListarEmpleado(tbnrodoc.Text.Trim)
            If (Not IsDBNull(dt)) Then
                If (dt.Rows.Count > 0) Then
                    tbCodigo.Text = dt.Rows(0).Item("ydnumi")
                    tbnrodoc.Text = dt.Rows(0).Item("ydcod")
                    tbNombre.Text = dt.Rows(0).Item("yddesc")

                Else
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, "Los Datos Del Vendedor No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                    tbCodigo.Clear()
                    tbnrodoc.Clear()
                    tbNombre.Clear()
                End If
            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Los Datos Del Vendedor No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbCodigo.Clear()
                tbnrodoc.Clear()
                tbNombre.Clear()
            End If
        End If

        If e.KeyData = Keys.Control + Keys.Enter Then

            _Limpiar()

            Dim dt As DataTable

            dt = L_fnListarEmpleado()
            '              a.ydnumi, a.ydcod, a.yddesc, a.yddctnum, a.yddirec
            ',a.ydtelf1 ,a.ydfnac 

            Dim listEstCeldas As New List(Of Modelo.Celda)
            listEstCeldas.Add(New Modelo.Celda("ydnumi,", False, "ID", 50))
            listEstCeldas.Add(New Modelo.Celda("ydcod", True, "CODIGO", 120))
            listEstCeldas.Add(New Modelo.Celda("yddesc", True, "NOMBRE", 400))
            listEstCeldas.Add(New Modelo.Celda("yddctnum", False, "N. Documento".ToUpper, 150))
            listEstCeldas.Add(New Modelo.Celda("yddirec", False, "DIRECCION", 220))
            listEstCeldas.Add(New Modelo.Celda("ydtelf1", False, "Telefono".ToUpper, 200))
            listEstCeldas.Add(New Modelo.Celda("ydfnac", False, "F.Nacimiento".ToUpper, 150, "MM/dd,YYYY"))
            Dim ef = New Efecto
            ef.tipo = 3
            ef.dt = dt
            ef.SeleclCol = 1
            ef.listEstCeldas = listEstCeldas
            ef.alto = 50
            ef.ancho = 350
            ef.Context = "Seleccione Vendedor".ToUpper
            ef.ShowDialog()
            Dim bandera As Boolean = False
            bandera = ef.band
            If (bandera = True) Then
                Dim Row As Janus.Windows.GridEX.GridEXRow = ef.Row
                If (IsNothing(Row)) Then
                    tbCodigo.Focus()
                    Return

                End If
                Try
                    tbCodigo.Text = Row.Cells("ydnumi").Value
                    tbnrodoc.Text = Row.Cells("ydcod").Value
                    tbNombre.Text = Row.Cells("yddesc").Value

                Catch ex As Exception
                    Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                    ToastNotification.Show(Me, "Los Datos Del Vendedor No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                    tbCodigo.Clear()
                    tbnrodoc.Clear()
                    tbNombre.Clear()
                End Try

            Else
                Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
                ToastNotification.Show(Me, "Los Datos Del Vendedor No Existe en el sistema".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
                tbCodigo.Clear()
                tbnrodoc.Clear()
                tbNombre.Clear()
            End If

        End If


    End Sub

    Private Sub tbnrodoc_TextChanged(sender As Object, e As EventArgs) Handles tbnrodoc.TextChanged
        If (tbnrodoc.Text = String.Empty) Then
            tbCodigo.Clear()
            tbNombre.Clear()
            _prCargarTablaPagos(-1)
        End If
    End Sub

    Private Sub gr_detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellEdited
        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub gr_detalle_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellUpdated
        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub tbFechaFactura_ValueChanged(sender As Object, e As EventArgs) Handles tbFechaFactura.ValueChanged
        If (tbCodigo.Text <> String.Empty) Then
            tbSaldo.Value = 0
            tbTotalCobrado.Value = 0
            tbTotalCobrar.Value = 0
            '_prCargarTablaPagos(tbCodigo.Text)
        End If
    End Sub



#End Region

End Class