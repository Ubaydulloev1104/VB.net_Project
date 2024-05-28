Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        Dim a, b As Double
        x = Integer.Parse(TextBox1.Text)
        y = Integer.Parse(TextBox2.Text)
        z = Integer.Parse(TextBox3.Text)
        a = (1 + y) * ((x + y / (x ^ 2 + 4)) / (Math.Exp(-x - 2) + 1 / (x ^ 2 + 4)))
        b = (1 + Math.Cos(y - 2)) / (x ^ 4 / 2 + Math.Sin(z) ^ 2)
        TextBox4.Text = a.ToString
        TextBox5.Text = b.ToString
    End Sub
End Class
