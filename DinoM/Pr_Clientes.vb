Imports Logica.AccesoLogica
Imports DevComponents.DotNetBar
Imports System.Data.OleDb
Imports DevComponents.DotNetBar.Controls

Public Class Pr_Clientes
    Public _nameButton As String
    Public _tab As SuperTabItem
    Dim bandera As Boolean = False
    Public _modulo As SideNavItem
    Public Sub _prIniciarTodo()
        'L_prAbrirConexion(gs_Ip, gs_UsuarioSql, gs_ClaveSql, gs_NombreBD)

        _PMIniciarTodo()
        Me.Text = "REPORTE DETALLADO CLIENTES"
        MReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None

        bandera = True
    End Sub
    Public Sub _PMIniciarTodo()

        'TxtNombreUsu.Text = MGlobal.gs_usuario
        'TxtNombreUsu.ReadOnly = True

        Me.WindowState = FormWindowState.Maximized
        'Me.SupTabItemBusqueda.Visible = False

    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        _prCargarReporte()
    End Sub
    Private Sub _prCargarReporte()
        Dim _dt As New DataTable
        _prInterpretarDatos(_dt)

        If (_dt.Rows.Count > 0) Then
            Dim objrep As New R_Cliente
            objrep.SetDataSource(_dt)
            objrep.SetParameterValue("usuario", L_Usuario)
            MReportViewer.ReportSource = objrep
            MReportViewer.Show()
            MReportViewer.BringToFront()
        Else
            ToastNotification.Show(Me, "NO HAY DATOS PARA LOS PARAMETROS SELECCIONADOS..!!!",
                                       My.Resources.INFORMATION, 2000,
                                       eToastGlowColor.Blue,
                                       eToastPosition.BottomLeft)
            MReportViewer.ReportSource = Nothing
        End If





    End Sub

    Public Sub _prInterpretarDatos(ByRef _dt As DataTable)


        If (checkUnaVendedor.Checked And CheckTodosAlmacen.Checked) Then
            If (tbCodigoVendedorC.Text.Length > 0) Then
                _dt = L_prClientesVendedorTodosAlmacen(tbCodigoVendedorC.Text)
            End If

        End If
        If (checkUnaVendedor.Checked And CheckUnaALmacen.Checked) Then
            If (tbAlmacenC.SelectedIndex >= 0 And tbCodigoVendedorC.Text.Length > 0) Then
                _dt = L_prClientesUnVendedorUnAlmacen(tbCodigoVendedorC.Text, tbAlmacenC.Value)
            End If

        End If
    End Sub
    Private Sub Pr_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _prIniciarTodo()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub tbVendedorC_KeyDown(sender As Object, e As KeyEventArgs) Handles tbVendedorC.KeyDown
        tbVendedorC.Enabled = True
        tbVendedorC.BackColor = Color.White
        tbVendedorC.Focus()
        If (checkUnaVendedor.Checked) Then
            If e.KeyData = Keys.Control + Keys.Enter Then
                Dim dt As DataTable
                dt = L_fnListarEmpleado()
                '              a.ydnumi, a.ydcod, a.yddesc, a.yddctnum, a.yddirec
                ',a.ydtelf1 ,a.ydfnac 
                Dim listEstCeldas As New List(Of Modelo.Celda)
                listEstCeldas.Add(New Modelo.Celda("ydnumi,", False, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("ydcod", True, "ID", 50))
                listEstCeldas.Add(New Modelo.Celda("yddesc", True, "NOMBRE", 280))
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
                        tbVendedorC.Focus()
                        Return
                    End If
                    tbCodigoVendedorC.Text = Row.Cells("ydnumi").Value
                    tbVendedorC.Text = Row.Cells("yddesc").Value
                    btnGenerar.Focus()
                End If

            End If

        End If
    End Sub



    Private Sub checkUnaVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles checkUnaVendedor.CheckValueChanged
        If (checkUnaVendedor.Checked) Then
            CheckTodosVendedor.CheckValue = False
            tbVendedorC.Enabled = True
            tbVendedorC.BackColor = Color.White
            tbVendedorC.Focus()

        End If
    End Sub

    Private Sub CheckUnaALmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckUnaALmacen.CheckValueChanged
        If (CheckUnaALmacen.Checked) Then
            CheckTodosAlmacen.CheckValue = False
            tbAlmacenC.Enabled = True
            tbAlmacenC.BackColor = Color.White
            tbAlmacenC.Focus()
            tbAlmacenC.ReadOnly = False
            _prCargarComboLibreriaSucursal(tbAlmacenC)
            If (CType(tbAlmacenC.DataSource, DataTable).Rows.Count > 0) Then
                tbAlmacenC.SelectedIndex = 0

            End If
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

    Private Sub CheckTodosVendedor_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosVendedor.CheckValueChanged
        If (CheckTodosVendedor.Checked) Then
            checkUnaVendedor.CheckValue = False
            tbVendedorC.Enabled = True
            tbVendedorC.BackColor = Color.Gainsboro
            tbVendedorC.Clear()
            tbCodigoVendedorC.Clear()

        End If
    End Sub

    Private Sub CheckTodosAlmacen_CheckValueChanged(sender As Object, e As EventArgs) Handles CheckTodosAlmacen.CheckValueChanged
        If (CheckTodosAlmacen.Checked) Then
            CheckUnaALmacen.CheckValue = False
            tbAlmacenC.Enabled = True
            tbAlmacenC.BackColor = Color.Gainsboro
            tbAlmacenC.ReadOnly = True
            _prCargarComboLibreriaSucursal(tbAlmacenC)
            CType(tbAlmacenC.DataSource, DataTable).Rows.Clear()
            tbAlmacenC.SelectedIndex = -1

        End If
    End Sub
End Class