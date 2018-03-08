﻿
Public Class TriviaMsgBox



    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'btnmessage.Visible = False
    End Sub

    Private Sub CustomMsgBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Protected Overloads Overrides ReadOnly Property Createparams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub PreventFlick()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub CustomMsgBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreventFlick()
        TextBox1.Focus()
        Me.Width = 0
        Timer1.Start()
        tbmessage.Refresh()
        SliderEffects()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Width += 50
        If Me.Width >= blackscreen.Width Then
            Timer1.Stop()
            'TextBox1.Focus()
            ' btnmessage.Visible = True
            If s11 = 1 Then
                TextBox1.Text = china
            ElseIf s11 = 2 Then
                TextBox1.Text = greece
            ElseIf s11 = 3 Then
                TextBox1.Text = italy
            End If
            tbmessage.Refresh()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Me.Width -= 50
        If Me.Width <= 10 Then
            Timer2.Stop()
            ' kit.FadeOut(frmTransparent, 60)
            frmTransparent.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.Width >= blackscreen.Width Then
                SliderEffects()
                Timer2.Start()
            End If
        End If
    End Sub




    Private Sub LinkLabel2_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        SliderEffects()
        Timer2.Start()
    End Sub

    Private Sub tbmessage_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tbmessage.MouseClick
        TextBox1.SelectAll()
        TextBox1.Focus()
        Timer2.Start()
    End Sub


    Private Sub CustomMsgBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        SliderEffects()
        Timer2.Start()
    End Sub
End Class