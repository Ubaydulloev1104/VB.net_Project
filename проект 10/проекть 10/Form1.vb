Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim k As Integer
        k = TextBox1.Text
        Dim a(10, 12) As Integer
        Dim r As New Random
        Dim s, s1 As Integer
        Dim str As String = ""
        For i = 0 To 9
            For j = 0 To 11
                a(i, j) = r.Next(100, 2000)
                str = str & a(i, j) & vbTab
                s = s + a(i, j)
                ' summa elementov stroki
                s1 = s1 + a(i, j)
            Next
            ListBox1.Items.Add(str)
            ListBox2.Items.Add(s1)
            str = ""
            s1 = 0
        Next
        Label3.Text = "общий доход=" & s
        If k < s Then
            Label2.Text = "общий доход фирмы превысился "
        ElseIf k > s Then
            Label2.Text = "общий доход фирмы непревысился  "
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class
