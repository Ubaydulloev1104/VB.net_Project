Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, n, temp, sum As Integer
        n = Val(TextBox1.Text)
        sum = 0
        temp = n
        While (n > 0)
            r = n Mod 10
            sum = sum * 10 + r
            n = n \ 10
        End While
        If temp = sum Then
            MsgBox("палиндром")
        Else
            MsgBox("не палиндром")
        End If
    End Sub
End Class
