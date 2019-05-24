<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pr_Clientes

    Inherits Modelo.ModeloR0

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pr_Clientes))
        Dim tbAlmacenC_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckTodosVendedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.tbAlmacenC = New Janus.Windows.GridEX.EditControls.MultiColumnCombo()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.checkUnaVendedor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tbVendedorC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbCodAlmacenC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckTodosAlmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.tbCodigoVendedorC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CheckUnaALmacen = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MGPFiltros.SuspendLayout()
        Me.PanelIzq.SuspendLayout()
        CType(Me.MPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbAlmacenC, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(858, 561)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(852, 561)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelIzq, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Yellow
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.Khaki
        Me.PanelSuperior.Style.BackgroundImage = CType(resources.GetObject("PanelSuperior.Style.BackgroundImage"), System.Drawing.Image)
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelInferior.Size = New System.Drawing.Size(852, 36)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Gold
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Gold
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
        'btnSalir
        '
        '
        'btnGenerar
        '
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelPrincipal.Size = New System.Drawing.Size(489, 525)
        '
        'MPanelUserAct
        '
        Me.MPanelUserAct.Location = New System.Drawing.Point(652, 0)
        Me.MPanelUserAct.Margin = New System.Windows.Forms.Padding(2)
        '
        'MReportViewer
        '
        Me.MReportViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.MReportViewer.Size = New System.Drawing.Size(489, 525)
        '
        'MGPFiltros
        '
        Me.MGPFiltros.Controls.Add(Me.GroupBox1)
        '
        '
        '
        Me.MGPFiltros.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.MGPFiltros.Style.BackColorGradientAngle = 90
        Me.MGPFiltros.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.MGPFiltros.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderBottomWidth = 1
        Me.MGPFiltros.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MGPFiltros.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderLeftWidth = 1
        Me.MGPFiltros.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderRightWidth = 1
        Me.MGPFiltros.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MGPFiltros.Style.BorderTopWidth = 1
        Me.MGPFiltros.Style.CornerDiameter = 4
        Me.MGPFiltros.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MGPFiltros.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MGPFiltros.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MGPFiltros.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MGPFiltros.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MGPFiltros.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PanelIzq.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.PanelIzq.Controls.SetChildIndex(Me.MGPFiltros, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckTodosVendedor)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.tbAlmacenC)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.checkUnaVendedor)
        Me.GroupBox1.Controls.Add(Me.tbVendedorC)
        Me.GroupBox1.Controls.Add(Me.tbCodAlmacenC)
        Me.GroupBox1.Controls.Add(Me.CheckTodosAlmacen)
        Me.GroupBox1.Controls.Add(Me.tbCodigoVendedorC)
        Me.GroupBox1.Controls.Add(Me.CheckUnaALmacen)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 148)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agrupados"
        '
        'CheckTodosVendedor
        '
        Me.CheckTodosVendedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckTodosVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosVendedor.Location = New System.Drawing.Point(293, 46)
        Me.CheckTodosVendedor.Name = "CheckTodosVendedor"
        Me.CheckTodosVendedor.Size = New System.Drawing.Size(57, 23)
        Me.CheckTodosVendedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosVendedor.TabIndex = 258
        Me.CheckTodosVendedor.Text = "Todos"
        Me.CheckTodosVendedor.Visible = False
        '
        'LabelX2
        '
        Me.LabelX2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX2.Location = New System.Drawing.Point(6, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX2.Size = New System.Drawing.Size(74, 23)
        Me.LabelX2.TabIndex = 249
        Me.LabelX2.Text = "Vendedor:"
        '
        'tbAlmacenC
        '
        Me.tbAlmacenC.BackColor = System.Drawing.Color.Gainsboro
        tbAlmacenC_DesignTimeLayout.LayoutString = resources.GetString("tbAlmacenC_DesignTimeLayout.LayoutString")
        Me.tbAlmacenC.DesignTimeLayout = tbAlmacenC_DesignTimeLayout
        Me.tbAlmacenC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAlmacenC.Location = New System.Drawing.Point(69, 96)
        Me.tbAlmacenC.Name = "tbAlmacenC"
        Me.tbAlmacenC.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom
        Me.tbAlmacenC.Office2007CustomColor = System.Drawing.Color.DodgerBlue
        Me.tbAlmacenC.SelectedIndex = -1
        Me.tbAlmacenC.SelectedItem = Nothing
        Me.tbAlmacenC.Size = New System.Drawing.Size(164, 22)
        Me.tbAlmacenC.TabIndex = 257
        Me.tbAlmacenC.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        '
        'LabelX3
        '
        Me.LabelX3.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LabelX3.Location = New System.Drawing.Point(4, 72)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.SingleLineColor = System.Drawing.SystemColors.Control
        Me.LabelX3.Size = New System.Drawing.Size(74, 23)
        Me.LabelX3.TabIndex = 253
        Me.LabelX3.Text = "Almacen:"
        '
        'checkUnaVendedor
        '
        Me.checkUnaVendedor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.checkUnaVendedor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkUnaVendedor.Checked = True
        Me.checkUnaVendedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkUnaVendedor.CheckValue = "Y"
        Me.checkUnaVendedor.Location = New System.Drawing.Point(243, 46)
        Me.checkUnaVendedor.Name = "checkUnaVendedor"
        Me.checkUnaVendedor.Size = New System.Drawing.Size(44, 23)
        Me.checkUnaVendedor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkUnaVendedor.TabIndex = 248
        Me.checkUnaVendedor.Text = "Una"
        '
        'tbVendedorC
        '
        Me.tbVendedorC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.tbVendedorC.Border.Class = "TextBoxBorder"
        Me.tbVendedorC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbVendedorC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVendedorC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbVendedorC.Location = New System.Drawing.Point(69, 47)
        Me.tbVendedorC.Name = "tbVendedorC"
        Me.tbVendedorC.PreventEnterBeep = True
        Me.tbVendedorC.Size = New System.Drawing.Size(167, 22)
        Me.tbVendedorC.TabIndex = 256
        '
        'tbCodAlmacenC
        '
        '
        '
        '
        Me.tbCodAlmacenC.Border.Class = "TextBoxBorder"
        Me.tbCodAlmacenC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodAlmacenC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodAlmacenC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodAlmacenC.Location = New System.Drawing.Point(39, 96)
        Me.tbCodAlmacenC.Name = "tbCodAlmacenC"
        Me.tbCodAlmacenC.PreventEnterBeep = True
        Me.tbCodAlmacenC.Size = New System.Drawing.Size(22, 22)
        Me.tbCodAlmacenC.TabIndex = 254
        Me.tbCodAlmacenC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodAlmacenC.Visible = False
        '
        'CheckTodosAlmacen
        '
        Me.CheckTodosAlmacen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckTodosAlmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckTodosAlmacen.Location = New System.Drawing.Point(293, 96)
        Me.CheckTodosAlmacen.Name = "CheckTodosAlmacen"
        Me.CheckTodosAlmacen.Size = New System.Drawing.Size(57, 23)
        Me.CheckTodosAlmacen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckTodosAlmacen.TabIndex = 255
        Me.CheckTodosAlmacen.Text = "Todos"
        '
        'tbCodigoVendedorC
        '
        '
        '
        '
        Me.tbCodigoVendedorC.Border.Class = "TextBoxBorder"
        Me.tbCodigoVendedorC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbCodigoVendedorC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCodigoVendedorC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.tbCodigoVendedorC.Location = New System.Drawing.Point(41, 45)
        Me.tbCodigoVendedorC.Name = "tbCodigoVendedorC"
        Me.tbCodigoVendedorC.PreventEnterBeep = True
        Me.tbCodigoVendedorC.Size = New System.Drawing.Size(22, 22)
        Me.tbCodigoVendedorC.TabIndex = 250
        Me.tbCodigoVendedorC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCodigoVendedorC.Visible = False
        '
        'CheckUnaALmacen
        '
        Me.CheckUnaALmacen.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.CheckUnaALmacen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CheckUnaALmacen.Location = New System.Drawing.Point(243, 95)
        Me.CheckUnaALmacen.Name = "CheckUnaALmacen"
        Me.CheckUnaALmacen.Size = New System.Drawing.Size(44, 23)
        Me.CheckUnaALmacen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckUnaALmacen.TabIndex = 252
        Me.CheckUnaALmacen.Text = "Una"
        '
        'Pr_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Pr_Clientes"
        Me.Text = "Pr_Clientes"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.MPanelUserAct.ResumeLayout(False)
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MGPFiltros.ResumeLayout(False)
        Me.PanelIzq.ResumeLayout(False)
        CType(Me.MPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbAlmacenC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbAlmacenC As Janus.Windows.GridEX.EditControls.MultiColumnCombo
    Friend WithEvents tbVendedorC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CheckTodosAlmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CheckUnaALmacen As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents tbCodigoVendedorC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents tbCodAlmacenC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents checkUnaVendedor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents CheckTodosVendedor As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
