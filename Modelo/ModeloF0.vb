﻿Imports Modelo.MGlobal
Public Class ModeloF0
#Region "METODO PARPADEO"
    ''Evita el parpadeo de las ventanas'''
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim cp As CreateParams = MyBase.CreateParams
    '        cp.ExStyle = cp.ExStyle
    '        cp.Style = cp.Style
    '        Return cp
    '    End Get
    'End Property
#End Region

    Private Sub ModeloHor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If (gs_mayusuculas <> 0) Then
            e.KeyChar = e.KeyChar.ToString.ToUpper
        End If

        If (e.KeyChar = ChrW(Keys.Enter)) Then
            e.Handled = True
            'P_Moverenfoque()
        End If
    End Sub

    'Private Sub P_Moverenfoque()
    '    SendKeys.Send("{TAB}")
    'End Sub

    Private Sub MFlyoutUsuario_PrepareContent(sender As Object, e As EventArgs) Handles MFlyoutUsuario.PrepareContent
        If sender Is BubbleBarUsuario And btnGrabar.Enabled = False Then
            MFlyoutUsuario.BorderColor = Color.FromArgb(&HC0, 0, 0)
            MFlyoutUsuario.Content = PanelUsuario
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub

    Private Sub MRlAccion_Click(sender As Object, e As EventArgs) Handles MRlAccion.Click

    End Sub


    Private Sub ModeloF0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TxtNombreUsu.Text = MGlobal.gs_usuario
        TxtNombreUsu.ReadOnly = True
    End Sub
End Class