Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Dim A(), max, min, y As Single
        Dim rnd As New Random()
        ReDim A(30)
        For i = 1 To 30
            A(i) = Single.Parse(rnd.Next(1960, 2020))
            ListBox1.Items.Add(A(i))
        Next
        max = A(1)
        min = A(1)
        For i = 2 To 30
            If A(i) < max Then
                max = A(i)
            ElseIf A(i) > min Then
                min = A(i)
            End If
        Next
        ' для оприделиния сколько лет возрост самого старого человека превышвет возрост самого молодого
        y = min - max
        MsgBox("самый старший= " & max & vbTab & "самый молодой= " & min & vbTab & "превышает=" & y)
    End Sub
End Class
