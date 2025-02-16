Imports System.IO
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New StreamReader("D:/А.txt", System.Text.Encoding.GetEncoding(1251))
        Dim n As String
        Dim m As String
        n = TextBox1.Text
        Do While a.Peek >= 0
            m = a.ReadLine()
            TextBox2.Text = m
            If m.Contains(n) Then
                Label2.Text = "Ответ:Содержит!"
            Else
                Label2.Text = ("Ответ:Нет совпадений!")
            End If
        Loop
        a.Close()
    End Sub
End Class
