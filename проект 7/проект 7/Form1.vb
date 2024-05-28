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
        Dim n, f, f1, f2 As Double
        If n >= 1 Then
            MsgBox("Введите n<=1 !", MsgBoxStyle.Information, "Внимание!")
            Exit Sub
        End If
        n = Integer.Parse(TextBox1.Text)
        f1 = 1
        f2 = 1
        ListBox1.Items.Add("f (" & 1 & ")= " & f1)
        ListBox1.Items.Add("f (" & 2 & ")= " & f2)
        If n > 1 Then
            For i = 3 To n
                f = f1 + f2
                f1 = f2
                f2 = f
                ListBox1.Items.Add("f (" & i & ")= " & f)
            Next
        End If
    End Sub
End Class
