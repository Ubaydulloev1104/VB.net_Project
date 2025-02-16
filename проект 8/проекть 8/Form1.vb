Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        If TextBox1.Text = "" Then
            MsgBox("Значения n отсутствуют!", MsgBoxStyle.Information, "Внимание!")
            Exit Sub
        ElseIf Not IsNumeric(TextBox1.Text) Then
            MsgBox("Значения n должно быть числом !", MsgBoxStyle.Information, "Внимание!")
            Exit Sub
        End If
        Dim n, x, y, max, min As Integer
        n = CInt(TextBox1.Text)
        x = CInt(InputBox("Введите рост !"))
        ListBox1.Items.Add("рост= " & x)
        max = x
        min = x
        For i = 2 To n
            x = CInt(InputBox("Введите рост !"))
            ListBox1.Items.Add("рост= " & x)
            If x > max Then
                max = x
            End If
            If x < min Then
                min = x
            End If
        Next
        y = max - min
        MsgBox("самый высоки рост=" & max & vbTab & "самый низкий рост= " & min & vbTab & "превышает=" & y)
    End Sub
End Class
