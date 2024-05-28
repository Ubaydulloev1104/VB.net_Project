Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Convert.ToInt32(TextBox1.Text)
        Select Case (a \ 10)
            Case 2
                MsgBox("двадцать")
            Case 3
                MsgBox("тридацать")
            Case 4
                MsgBox("сорок")
            Case 5
                MsgBox("пятьдесят")
            Case 6
                MsgBox("шестьдесят")
        End Select
        Select Case (a Mod 10)
            Case 1
                MsgBox("один")
            Case 2
                MsgBox("два")
            Case 3
                MsgBox("три")
            Case 4
                MsgBox("Четыре")
            Case 5
                MsgBox("пят")
            Case 6
                MsgBox("шесть")
            Case 7
                MsgBox("семь")
            Case 8
                MsgBox("восемь")
            Case 9
                MsgBox("девять")
        End Select
        If ((a Mod 10) = 1) Then
            MsgBox("год")
        End If
        If (((a Mod 10) >= 2) AndAlso (a Mod 10) <= 4) Then
            MsgBox("года")
        End If
        If ((a Mod 10) = 0 OrElse ((a Mod 10) >= 5 OrElse (a Mod 10) <= 9)) Then
            MsgBox("лет")
        End If
    End Sub
End Class
