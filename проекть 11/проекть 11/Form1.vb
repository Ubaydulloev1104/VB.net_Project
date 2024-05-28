Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = TextBox1.Text
        Dim k1, k2 As Integer
        Dim L As Char
        For i = 0 To str.Length - 1
            L = str(i)
            If Asc(L) = Asc("м") And Asc("М") Then
                k1 += 1
            ElseIf Asc(L) = Asc("н") And Asc("Н") Then
                k2 += 1
            End If
        Next
        If k1 > k2 Then
            MsgBox("буквы м больше ", MsgBoxStyle.Information, "результат!")
        ElseIf k1 < k2 Then
            MsgBox("буквы н больше ", MsgBoxStyle.Information, "результат!")
        ElseIf k1 = k2 Then
            MsgBox("буквы (н) и (м) равны ", MsgBoxStyle.Information, "результат!")
        End If
    End Sub
End Class
