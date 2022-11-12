Imports System.Drawing
Public Class Form1
    Dim xob As Integer
    Dim yob As Integer
    Dim xsub As Integer
    Dim ysub As Integer
    Dim trsfx As Integer
    Dim trsfy As Integer
    Dim ylim As Integer
    Dim xlim As Integer
    Dim ybar As Integer
    Dim xbar As Integer
    Dim flagel As Integer
    Dim yt As Integer
    Dim xt As Integer
    Dim x0 As Integer
    Dim y0 As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        yob = objc.Top
        xob = objc.Left
        xsub = subj.Left
        ysub = subj.Top
        trsfx = xob - xsub
        trsfy = yob - ysub
        If ysub = yob And xsub = xob Then
            Exit Sub
        Else
            If subj.Bounds.IntersectsWith(Disapears.Bounds) Then
                flags.Text = Val(flags.Text) + 1
                listx.Items.Add(subj.Left)
                listy.Items.Add(subj.Top)
                subj.Left = x0 
                subj.Top = y0
                If listx.Items.Contains(xob) Then
                    subj.Left = subj.Left - 10
                End If
            Else
                    If trsfx > 0 And trsfy > 0 Then
                        subj.Left = xsub + 1
                        subj.Top = ysub + 1
                    ElseIf trsfx < 0 And trsfy > 0 Then
                        subj.Left = xsub - 1
                        subj.Top = ysub + 1
                    ElseIf trsfx < 0 And trsfy < 0 Then
                        subj.Left = xsub - 1
                        subj.Top = ysub - 1
                    ElseIf trsfx > 0 And trsfy < 0 Then
                        subj.Left = xsub + 1
                        subj.Top = ysub - 1
                    ElseIf trsfx = 0 And trsfy < 0 Then
                        subj.Top = ysub - 1
                    ElseIf trsfx = 0 And trsfy > 0 Then
                        subj.Top = ysub + 1
                    ElseIf trsfx > 0 And trsfy = 0 Then
                        subj.Left = xsub + 1
                    ElseIf trsfx < 0 And trsfy = 0 Then
                        subj.Left = xsub - 1
                    End If
                End If
            End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ytr.Text = trsfy
        xtr.Text = trsfx
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        For Each x In listx.Items
            For Each y In listy.Items
                If x = subj.Left And y = subj.Top Then
                    If trsfx > 0 And trsfy > 0 Then
                        If yt = Not subj.Top Then
                            yt = subj.Top
                        Else
                            subj.Left = xsub - 2
                        End If
                    ElseIf trsfx < 0 And trsfy > 0 Then
                        If yt = Not subj.Top Then
                            yt = subj.Top
                            subj.Left = xsub + 2
                        Else
                            subj.Left = xsub + 2
                        End If
                    ElseIf trsfx < 0 And trsfy < 0 Then
                         If yt = Not subj.Top Then
                            yt = subj.Top
                        Else
                            subj.Left = xsub + 2
                        End If
                    ElseIf trsfx > 0 And trsfy < 0 Then
                       If yt = Not subj.Top Then
                            yt = subj.Top
                        Else
                            subj.Left = xsub - 2
                            subj.Top = xsub + 2
                        End If
                    ElseIf trsfx = 0 And trsfy < 0 Then
                       If yt = Not subj.Top Then
                            yt = subj.Top
                            subj.Left = xsub - 2
                        Else
                            subj.Left = xsub - 2
                        End If
                    ElseIf trsfx = 0 And trsfy > 0 Then
                        subj.Top = ysub - 3
                    ElseIf trsfx > 0 And trsfy = 0 Then
                         If yt = Not subj.Top Then
                            yt = subj.Top
                        Else
                            subj.Left = xsub - 2
                            subj.Top = xsub + 2
                        End If
                    ElseIf trsfx < 0 And trsfy = 0 Then
                        If yt = Not subj.Top Then
                            yt = subj.Top
                            subj.Left = xsub - 2
                        Else
                            subj.Left = xsub - 2
                            subj.Top = subj.Top + 2
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x0 = subj.Left
        y0 = subj.Top
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        subj.Left = x0
        subj.Top = y0
    End Sub
End Class
