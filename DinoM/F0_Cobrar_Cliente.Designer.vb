﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F0_Cobrar_Cliente
    Inherits Modelo.ModeloF1


    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F0_Cobrar_Cliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbTotalCobrar = New DevComponents.Editors.DoubleInput()
        Me.tbSaldo = New DevComponents.Editors.DoubleInput()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTotalCobrado = New DevComponents.Editors.DoubleInput()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tbCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Bt1Generar = New DevComponents.DotNetBar.ButtonX()
        Me.tbFechaVenta = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.gr_detalle = New Janus.Windows.GridEX.GridEX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.tbnrocod = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.MPanelSup.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.GroupPanelBuscador.SuspendLayout()
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tbTotalCobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTotalCobrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFechaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gr_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabPrincipal.Size = New System.Drawing.Size(1284, 641)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(1252, 631)
        '
        'SupTabItemBusqueda
        '
        Me.SupTabItemBusqueda.Visible = False
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(1252, 641)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Controls.Add(Me.ButtonX2)
        Me.PanelSuperior.Controls.Add(Me.ButtonX1)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSuperior.Size = New System.Drawing.Size(1252, 72)
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.PanelToolBar2, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.ButtonX1, 0)
        Me.PanelSuperior.Controls.SetChildIndex(Me.ButtonX2, 0)
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 605)
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelInferior.Size = New System.Drawing.Size(1252, 36)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.DarkSlateGray
        Me.PanelInferior.Style.BackgroundImage = CType(resources.GetObject("PanelInferior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'TxtNombreUsu
        '
        Me.TxtNombreUsu.Margin = New System.Windows.Forms.Padding(2)
        '
        'btnSalir
        '
        Me.btnSalir.Image = Nothing
        Me.btnSalir.Text = ""
        '
        'btnGrabar
        '
        Me.btnGrabar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Visible = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Visible = False
        '
        'PanelToolBar2
        '
        Me.PanelToolBar2.Location = New System.Drawing.Point(908, 0)
        Me.PanelToolBar2.Margin = New System.Windows.Forms.Padding(2)
        '
        'MPanelSup
        '
        Me.MPanelSup.Controls.Add(Me.tbnrocod)
        Me.MPanelSup.Controls.Add(Me.tbFechaVenta)
        Me.MPanelSup.Controls.Add(Me.Bt1Generar)
        Me.MPanelSup.Controls.Add(Me.LabelX4)
        Me.MPanelSup.Controls.Add(Me.tbCodigo)
        Me.MPanelSup.Controls.Add(Me.tbNombre)
        Me.MPanelSup.Controls.Add(Me.LabelX2)
        Me.MPanelSup.Margin = New System.Windows.Forms.Padding(2)
        Me.MPanelSup.Size = New System.Drawing.Size(1252, 184)
        Me.MPanelSup.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX2, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.tbNombre, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.tbCodigo, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.LabelX4, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.Bt1Generar, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.tbFechaVenta, 0)
        Me.MPanelSup.Controls.SetChildIndex(Me.tbnrocod, 0)
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.Panel1)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPrincipal.Size = New System.Drawing.Size(1252, 533)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.MPanelSup, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.Panel1, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.GroupPanelBuscador, 0)
        '
        'GroupPanelBuscador
        '
        Me.GroupPanelBuscador.Controls.Add(Me.gr_detalle)
        Me.GroupPanelBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupPanelBuscador.Size = New System.Drawing.Size(1252, 235)
        '
        '
        '
        Me.GroupPanelBuscador.Style.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BackColorGradientAngle = 90
        Me.GroupPanelBuscador.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderBottomWidth = 1
        Me.GroupPanelBuscador.Style.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.GroupPanelBuscador.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderLeftWidth = 1
        Me.GroupPanelBuscador.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderRightWidth = 1
        Me.GroupPanelBuscador.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanelBuscador.Style.BorderTopWidth = 1
        Me.GroupPanelBuscador.Style.CornerDiameter = 4
        Me.GroupPanelBuscador.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanelBuscador.Style.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupPanelBuscador.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanelBuscador.Style.TextColor = System.Drawing.Color.White
        Me.GroupPanelBuscador.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanelBuscador.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanelBuscador.Text = "DETALLE VENTAS A CREDITO"
        Me.GroupPanelBuscador.Controls.SetChildIndex(Me.JGrM_Buscador, 0)
        Me.GroupPanelBuscador.Controls.SetChildIndex(Me.gr_detalle, 0)
        '
        'JGrM_Buscador
        '
        Me.JGrM_Buscador.AutoEdit = True
        Me.JGrM_Buscador.HeaderFormatStyle.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.HeaderFormatStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.JGrM_Buscador.Margin = New System.Windows.Forms.Padding(2)
        Me.JGrM_Buscador.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.JGrM_Buscador.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.JGrM_Buscador.SelectedFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JGrM_Buscador.SelectedFormatStyle.ForeColor = System.Drawing.Color.White
        Me.JGrM_Buscador.Size = New System.Drawing.Size(1246, 212)
        Me.JGrM_Buscador.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Visible = False
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(1052, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(2)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 419)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1252, 114)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.DinoM.My.Resources.Resources.fondo1
        Me.Panel2.Controls.Add(Me.tbTotalCobrar)
        Me.Panel2.Controls.Add(Me.tbSaldo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbTotalCobrado)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(777, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 114)
        Me.Panel2.TabIndex = 6
        '
        'tbTotalCobrar
        '
        '
        '
        '
        Me.tbTotalCobrar.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTotalCobrar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotalCobrar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTotalCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCobrar.Increment = 1.0R
        Me.tbTotalCobrar.Location = New System.Drawing.Point(118, 24)
        Me.tbTotalCobrar.LockUpdateChecked = False
        Me.tbTotalCobrar.MinValue = 0R
        Me.tbTotalCobrar.Name = "tbTotalCobrar"
        Me.tbTotalCobrar.Size = New System.Drawing.Size(104, 21)
        Me.tbTotalCobrar.TabIndex = 3
        Me.tbTotalCobrar.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'tbSaldo
        '
        '
        '
        '
        Me.tbSaldo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbSaldo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSaldo.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldo.Increment = 1.0R
        Me.tbSaldo.Location = New System.Drawing.Point(118, 73)
        Me.tbSaldo.LockUpdateChecked = False
        Me.tbSaldo.MinValue = 0R
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.Size = New System.Drawing.Size(104, 21)
        Me.tbSaldo.TabIndex = 5
        Me.tbSaldo.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total a Cobrar :"
        '
        'tbTotalCobrado
        '
        '
        '
        '
        Me.tbTotalCobrado.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbTotalCobrado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbTotalCobrado.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.tbTotalCobrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalCobrado.Increment = 1.0R
        Me.tbTotalCobrado.Location = New System.Drawing.Point(118, 50)
        Me.tbTotalCobrado.LockUpdateChecked = False
        Me.tbTotalCobrado.MinValue = 0R
        Me.tbTotalCobrado.Name = "tbTotalCobrado"
        Me.tbTotalCobrado.Size = New System.Drawing.Size(104, 21)
        Me.tbTotalCobrado.TabIndex = 4
        Me.tbTotalCobrado.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total a Cobrado :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(69, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Saldo :"
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbNombre.Border.Class = "TextBoxBorder"
        Me.tbNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbNombre.Location = New System.Drawing.Point(265, 37)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.PreventEnterBeep = True
        Me.tbNombre.Size = New System.Drawing.Size(249, 22)
        Me.tbNombre.TabIndex = 226
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(147, 37)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(51, 16)
        Me.LabelX2.TabIndex = 227
        Me.LabelX2.Text = "Cliente:"
        '
        'tbCodigo
        '
        Me.tbCodigo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbCodigo.Border.Class = "TextBoxBorder"
        Me.tbCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigo.Location = New System.Drawing.Point(206, 108)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.PreventEnterBeep = True
        Me.tbCodigo.Size = New System.Drawing.Size(43, 22)
        Me.tbCodigo.TabIndex = 228
        Me.tbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodigo.Visible = False
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(106, 72)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX4.Size = New System.Drawing.Size(95, 16)
        Me.LabelX4.TabIndex = 233
        Me.LabelX4.Text = "Fecha de Pago:"
        '
        'Bt1Generar
        '
        Me.Bt1Generar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt1Generar.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.Bt1Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt1Generar.Image = Global.DinoM.My.Resources.Resources.list
        Me.Bt1Generar.ImageFixedSize = New System.Drawing.Size(40, 40)
        Me.Bt1Generar.Location = New System.Drawing.Point(574, 117)
        Me.Bt1Generar.Name = "Bt1Generar"
        Me.Bt1Generar.Size = New System.Drawing.Size(150, 50)
        Me.Bt1Generar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt1Generar.TabIndex = 234
        Me.Bt1Generar.Text = "Limpiar"
        Me.Bt1Generar.Visible = False
        '
        'tbFechaVenta
        '
        '
        '
        '
        Me.tbFechaVenta.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.tbFechaVenta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.tbFechaVenta.ButtonDropDown.Visible = True
        Me.tbFechaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFechaVenta.IsPopupCalendarOpen = False
        Me.tbFechaVenta.Location = New System.Drawing.Point(206, 65)
        '
        '
        '
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.tbFechaVenta.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.tbFechaVenta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.DisplayMonth = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.tbFechaVenta.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.tbFechaVenta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbFechaVenta.MonthCalendar.TodayButtonVisible = True
        Me.tbFechaVenta.Name = "tbFechaVenta"
        Me.tbFechaVenta.Size = New System.Drawing.Size(120, 22)
        Me.tbFechaVenta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.tbFechaVenta.TabIndex = 235
        '
        'gr_detalle
        '
        Me.gr_detalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gr_detalle.FlatBorderColor = System.Drawing.SystemColors.HotTrack
        Me.gr_detalle.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle
        Me.gr_detalle.FocusStyle = Janus.Windows.GridEX.FocusStyle.None
        Me.gr_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gr_detalle.HeaderFormatStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.gr_detalle.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.gr_detalle.Location = New System.Drawing.Point(0, 0)
        Me.gr_detalle.Margin = New System.Windows.Forms.Padding(2)
        Me.gr_detalle.Name = "gr_detalle"
        Me.gr_detalle.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.gr_detalle.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.gr_detalle.RowFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.gr_detalle.SelectedFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.gr_detalle.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black
        Me.gr_detalle.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Transparent
        Me.gr_detalle.Size = New System.Drawing.Size(1246, 212)
        Me.gr_detalle.TabIndex = 1
        Me.gr_detalle.TableHeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.[True]
        Me.gr_detalle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX1.Image = Global.DinoM.My.Resources.Resources.save
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.ButtonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX1.Location = New System.Drawing.Point(376, 0)
        Me.ButtonX1.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(80, 72)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 9
        Me.ButtonX1.Text = "GRABAR"
        Me.ButtonX1.TextColor = System.Drawing.Color.White
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonX2.Image = Global.DinoM.My.Resources.Resources.atras1
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(48, 48)
        Me.ButtonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonX2.Location = New System.Drawing.Point(456, 0)
        Me.ButtonX2.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(80, 72)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 10
        Me.ButtonX2.Text = "SALIR"
        Me.ButtonX2.TextColor = System.Drawing.Color.White
        '
        'tbnrocod
        '
        Me.tbnrocod.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbnrocod.Border.Class = "TextBoxBorder"
        Me.tbnrocod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbnrocod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnrocod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbnrocod.Location = New System.Drawing.Point(206, 37)
        Me.tbnrocod.Name = "tbnrocod"
        Me.tbnrocod.PreventEnterBeep = True
        Me.tbnrocod.Size = New System.Drawing.Size(43, 22)
        Me.tbnrocod.TabIndex = 237
        Me.tbnrocod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'F0_Cobrar_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 641)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "F0_Cobrar_Cliente"
        Me.Text = "F0_Cobrar_Cliente"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.MPanelSup.ResumeLayout(False)
        Me.MPanelSup.PerformLayout()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.GroupPanelBuscador.ResumeLayout(False)
        CType(Me.JGrM_Buscador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tbTotalCobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTotalCobrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFechaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gr_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSaldo As DevComponents.Editors.DoubleInput
    Friend WithEvents tbTotalCobrado As DevComponents.Editors.DoubleInput
    Friend WithEvents tbTotalCobrar As DevComponents.Editors.DoubleInput
    Friend WithEvents tbNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tbCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Bt1Generar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbFechaVenta As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents gr_detalle As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents tbnrocod As DevComponents.DotNetBar.Controls.TextBoxX
End Class
