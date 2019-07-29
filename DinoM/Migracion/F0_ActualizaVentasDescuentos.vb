Imports GMap.NET.WindowsForms
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
Public Class F0_ActualizaVentasDescuentos

#Region "Variables Globales"
    Dim precio As DataTable
    Public _nameButton As String
    Public _tab As SuperTabItem
    Public _modulo As SideNavItem
    Dim bandera As Boolean = False
    Dim Bin As New MemoryStream
#End Region

#Region "METODOS PRIVADOS"

    Private Sub _IniciarTodo()


        L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)
        'Me.WindowState = FormWindowState.Maximized
        _prAsignarPermisos()
        Me.Text = "Descuentos Por Ventas"
        Dim blah As New Bitmap(New Bitmap(My.Resources.cobro), 20, 20)
        Dim ico As Icon = Icon.FromHandle(blah.GetHicon())
        Me.Icon = ico
        tbFechaDesde.Value = Now.Date
        tbFechaHasta.Value = Now.Date
        _prCargarTablaVentas()




    End Sub


    Private Sub _Limpiar()

        tbFechaDesde.Value = Now.Date

        tbFechaHasta.Value = Now.Date
        _prCargarTablaVentas()
        '_prAddDetalle()




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
    Private Sub _prCargarTablaVentas()

        Dim dt As New DataTable
        dt = L_fnObtenerVentasByFechas(tbFechaDesde.Value.ToString("yyyy/MM/dd"), tbFechaHasta.Value.ToString("yyyy/MM/dd"))
        If (dt.Rows.Count <= 0) Then
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "No Hay Datos Para Mostrar".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

        End If
        '_prCargarIconDelete(dt)
        gr_detalle.DataSource = dt
        gr_detalle.RetrieveStructure()
        gr_detalle.AlternatingColors = True
        '    tanumi , codigo, a.tafdoc, vendedor, a.tafvcr, codcliente,
        '     cliente, moneda, a.taobs, subtotal, descuento, porcentaje, total, tienedescuento,
        'existepagos, estado


        With gr_detalle.RootTable.Columns("tienedescuento")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("existepagos")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("estado")
            .Width = 100
            .Visible = False
        End With

        With gr_detalle.RootTable.Columns("porcentaje")
            .Caption = "Porcentaje"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"

            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("total")
            .Caption = "Total"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("codigo")
            .Width = 100
            .Visible = True
            .Caption = "Cod Venta"
        End With
        With gr_detalle.RootTable.Columns("tanumi")
            .Width = 100
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("moneda")
            .Width = 100
            .Visible = False
            .Caption = "Moneda"
        End With
        With gr_detalle.RootTable.Columns("taobs")
            .Width = 150
            .Visible = False
            .Caption = "Observacion"
        End With
        With gr_detalle.RootTable.Columns("vendedor")
            .Width = 220
            .Visible = True
            .Caption = "Vendedor"
        End With
        With gr_detalle.RootTable.Columns("cliente")
            .Width = 190
            .Visible = True
            .Caption = "Cliente"
        End With

        With gr_detalle.RootTable.Columns("tafdoc")
            .Caption = "Fecha Venta"
            .Width = 120
            .TextAlignment = TextAlignment.Center
            .Visible = True
        End With

        With gr_detalle.RootTable.Columns("tafvcr")
            .Caption = "Fecha Vencimiento"
            .TextAlignment = TextAlignment.Center
            .Width = 160
            .Visible = False
        End With
        With gr_detalle.RootTable.Columns("codcliente")
            .Width = 100
            .Visible = True
            .Caption = "Cod Cliente"

        End With

        With gr_detalle.RootTable.Columns("subtotal")
            .Caption = "Sub Total"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
        End With
        With gr_detalle.RootTable.Columns("descuento")
            .Caption = "Descuento"
            .Width = 120
            .TextAlignment = TextAlignment.Far
            .FormatString = "0.00"
            .AggregateFunction = AggregateFunction.Sum
            .Visible = True
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

    End Sub
    Public Sub _prAplicarCondiccionJanus()
        Dim fc As GridEXFormatCondition
        fc = New GridEXFormatCondition(gr_detalle.RootTable.Columns("existepagos"), ConditionOperator.Equal, 1)
        fc.FormatStyle.BackColor = Color.DodgerBlue
        gr_detalle.RootTable.FormatConditions.Add(fc)
        Dim fc2 As GridEXFormatCondition
        fc2 = New GridEXFormatCondition(gr_detalle.RootTable.Columns("tienedescuento"), ConditionOperator.Equal, 1)
        fc2.FormatStyle.BackColor = Color.DodgerBlue

        gr_detalle.RootTable.FormatConditions.Add(fc2)
    End Sub


    Private Sub F0_Cobrar_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _IniciarTodo()
    End Sub



    Private Sub Bt1Generar_Click(sender As Object, e As EventArgs) Handles Bt1Generar.Click
        _prCargarTablaVentas()

    End Sub

    Private Sub gr_detalle_EditingCell(sender As Object, e As EditingCellEventArgs) Handles gr_detalle.EditingCell


        'gr_detalle.GetRow(rowIndex).Cells("cant").Value = 1
        '  gr_detalle.CurrentRow.Cells.Item("cant").Value = 1
        Dim tieneDescuento As Integer = gr_detalle.GetValue("tienedescuento")
        Dim TienePagos As Integer = gr_detalle.GetValue("existepagos")
        If (tieneDescuento = 1 Or TienePagos = 1) Then
            e.Cancel = True
            Return

        End If
        If (e.Column.Index = gr_detalle.RootTable.Columns("descuento").Index Or
              e.Column.Index = gr_detalle.RootTable.Columns("porcentaje").Index) Then
            e.Cancel = False

        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub gr_detalle_CellValueChanged(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellValueChanged

        If (e.Column.Index = gr_detalle.RootTable.Columns("porcentaje").Index) Then
            If (Not IsNumeric(gr_detalle.GetValue("porcentaje")) Or gr_detalle.GetValue("porcentaje").ToString = String.Empty) Then

                'gr_detalle.GetRow(rowIndex).Cells("cant").Value = 1
                '  gr_detalle.CurrentRow.Cells.Item("cant").Value = 1
                Dim lin As Integer = gr_detalle.GetValue("tanumi")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("porcentaje") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("estado") = 1
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("total") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("subtotal")
                'gr_detalle.SetValue("tbcmin", 1)
                'gr_detalle.SetValue("subtotal", gr_detalle.GetValue("tbpbas"))
            Else
                If (gr_detalle.GetValue("porcentaje") > 0 And gr_detalle.GetValue("porcentaje") <= 100) Then

                    Dim porcdesc As Double = gr_detalle.GetValue("porcentaje")
                    Dim montodesc As Double = (gr_detalle.GetValue("subtotal") * (porcdesc / 100))
                    Dim lin As Integer = gr_detalle.GetValue("tanumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = montodesc
                    gr_detalle.SetValue("descuento", montodesc)


                    Dim rowIndex As Integer = gr_detalle.Row
                    P_PonerTotal(rowIndex)

                Else
                    Dim lin As Integer = gr_detalle.GetValue("tanumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("porcentaje") = 0
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = 0
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("total") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("subtotal")
                    gr_detalle.SetValue("porcentaje", 0)
                    gr_detalle.SetValue("descuento", 0)
                    gr_detalle.SetValue("total", gr_detalle.GetValue("subtotal"))

                    'gr_detalle.SetValue("tbcmin", 1)
                    'gr_detalle.SetValue("subtotal", gr_detalle.GetValue("tbpbas"))

                End If
            End If
        End If


        '''''''''''''''''''''MONTO DE DESCUENTO '''''''''''''''''''''
        If (e.Column.Index = gr_detalle.RootTable.Columns("descuento").Index) Then
            If (Not IsNumeric(gr_detalle.GetValue("descuento")) Or gr_detalle.GetValue("descuento").ToString = String.Empty) Then

                'gr_detalle.GetRow(rowIndex).Cells("cant").Value = 1
                '  gr_detalle.CurrentRow.Cells.Item("cant").Value = 1
                Dim lin As Integer = gr_detalle.GetValue("tanumi")
                Dim pos As Integer = -1
                _fnObtenerFilaDetalle(pos, lin)
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("porcentaje") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = 0
                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("total") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("subtotal")
                'gr_detalle.SetValue("tbcmin", 1)
                'gr_detalle.SetValue("subtotal", gr_detalle.GetValue("tbpbas"))
            Else
                If (gr_detalle.GetValue("descuento") > 0 And gr_detalle.GetValue("descuento") <= gr_detalle.GetValue("subtotal")) Then

                    Dim montodesc As Double = gr_detalle.GetValue("descuento")
                    Dim pordesc As Double = ((montodesc * 100) / gr_detalle.GetValue("subtotal"))

                    Dim lin As Integer = gr_detalle.GetValue("tanumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = montodesc
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("porcentaje") = pordesc

                    gr_detalle.SetValue("porcentaje", pordesc)
                    Dim rowIndex As Integer = gr_detalle.Row
                    P_PonerTotal(rowIndex)

                Else
                    Dim lin As Integer = gr_detalle.GetValue("tanumi")
                    Dim pos As Integer = -1
                    _fnObtenerFilaDetalle(pos, lin)
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("porcentaje") = 0
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("descuento") = 0
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("total") = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("subtotal")
                    gr_detalle.SetValue("porcentaje", 0)
                    gr_detalle.SetValue("descuento", 0)
                    gr_detalle.SetValue("total", gr_detalle.GetValue("subtotal"))

                    'gr_detalle.SetValue("tbcmin", 1)
                    'gr_detalle.SetValue("subtotal", gr_detalle.GetValue("tbpbas"))

                End If
            End If
        End If
    End Sub


    Public Sub P_PonerTotal(rowIndex As Integer)

        If (rowIndex < gr_detalle.RowCount) Then

            Dim lin As Integer = gr_detalle.GetValue("tanumi")
            Dim pos As Integer = -1
            _fnObtenerFilaDetalle(pos, lin)
            Dim MontoDesc As Double = gr_detalle.GetValue("descuento")
            Dim SubTotal As Double = gr_detalle.GetValue("subtotal")
            Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)
            If (pos >= 0) Then

                'gr_detalle.SetValue("lcmdes", montodesc)

                CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("total") = SubTotal - MontoDesc

                gr_detalle.SetValue("total", SubTotal - MontoDesc)


                Dim estado As Integer = CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("estado")
                If (estado = 1) Then
                    CType(gr_detalle.DataSource, DataTable).Rows(pos).Item("estado") = 2
                End If
            End If
            'MontoDesc = tbMdesc.Value
            'Dim pocentaje As Double = Math.Round(((MontoDesc * 100) / Auxsubtotal), 0)

        End If



    End Sub

    Public Sub _fnObtenerFilaDetalle(ByRef pos As Integer, numi As Integer)
        For i As Integer = 0 To CType(gr_detalle.DataSource, DataTable).Rows.Count - 1 Step 1
            Dim _numi As Integer = CType(gr_detalle.DataSource, DataTable).Rows(i).Item("tanumi")
            If (_numi = numi) Then
                pos = i
                Return
            End If
        Next

    End Sub
    Public Function ExisteItemModificados() As Boolean
        Dim dt As DataTable = CType(gr_detalle.DataSource, DataTable)

        For i As Integer = 0 To dt.Rows.Count - 1 Step 1
            Dim estado As Integer = dt.Rows(i).Item("estado")
            If (estado = 2) Then
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        Dim numi As String = ""
        Dim img2 As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)

        If (Not ExisteItemModificados()) Then
            ToastNotification.Show(Me, "No existen datos a Modificar".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return
        End If
        Dim res As Boolean = L_fnGrabarModificacionVenta(CType(gr_detalle.DataSource, DataTable))


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Las ventas han sido Actualizadas Correctamente ".ToUpper + " con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )


            _Limpiar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Venta no pudo ser actualizada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

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

        If (Not ExisteItemModificados()) Then
            ToastNotification.Show(Me, "No existen datos a Modificar".ToUpper, img2, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)
            Return
        End If
        Dim res As Boolean = L_fnGrabarModificacionVenta(CType(gr_detalle.DataSource, DataTable))


        If res Then

            Dim img As Bitmap = New Bitmap(My.Resources.checked, 50, 50)
            ToastNotification.Show(Me, "Las ventas han sido Actualizadas Correctamente ".ToUpper + " con Exito.".ToUpper,
                                      img, 2000,
                                      eToastGlowColor.Green,
                                      eToastPosition.TopCenter
                                      )


            _Limpiar()

        Else
            Dim img As Bitmap = New Bitmap(My.Resources.cancel, 50, 50)
            ToastNotification.Show(Me, "La Venta no pudo ser actualizada".ToUpper, img, 2000, eToastGlowColor.Red, eToastPosition.BottomCenter)

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



    Private Sub gr_detalle_CellEdited(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellEdited
        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub gr_detalle_CellUpdated(sender As Object, e As ColumnActionEventArgs) Handles gr_detalle.CellUpdated
        'tbTotalCobrado.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("PagoAc"), AggregateFunction.Sum))
        'tbSaldo.Value = (gr_detalle.GetTotal(gr_detalle.RootTable.Columns("pendiente"), AggregateFunction.Sum))
    End Sub

    Private Sub tbFechaHasta_ValueChanged(sender As Object, e As EventArgs) Handles tbFechaHasta.ValueChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()

    End Sub



#End Region
End Class