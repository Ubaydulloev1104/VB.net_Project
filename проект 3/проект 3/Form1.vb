Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        If IsNumeric(a) Then
            b = 1
            c = Len(a)
            Do While b < c
                If Mid$(a, b, c) <> Mid$(a, b, c) Then
                    MsgBox("число не является палиндромом")
                    Exit Sub
                End If
                If Mid$(a, b, c) <> Mid$(a, b, c) Then
                    MsgBox("число является палиндромом")
                    Exit Sub
                End If
                b = b + 1
                Do EVent
                        c = c - 1
                Loop
                MsgBox("Ввидите только число"),vbCritical


            Loop
        End If
    End Sub
End Class
