Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, min, r, k, m As Integer
        ListBox1.Items.Clear()
        If Not (IsNumeric(TextBox1.Text)) Then
            MsgBox("Введите число!")
        End If
        a = Val(TextBox1.Text)
        m = a
        min = a Mod 10
        k = 0
        Do While a > 9
            r = a Mod 10
            a = a - r
            a = a / 10
            If r < min Then
                min = r
            End If
        Loop
        ListBox1.Items.Add("минимальная цифра: " + min.ToString)
        Do While m > 9
            r = m Mod 10
            If r = min Then
                k = k + 1
            End If
            m = m - r
            m = m / 10
        Loop
        If m = min Then
            k = k + 1
        End If
        ListBox1.Items.Add("количество минимальны цифра=" & k)

    End Sub
End Class



'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'    Dim a, min, r, k, m As Integer
'    ListBox1.Items.Clear()
'    If Not (IsNumeric(TextBox1.Text)) Then
'        MsgBox("Введите число!")
'    End If
'    a = Val(TextBox1.Text)
'    min = a Mod 10
'    a = a / 10
'    a = m
'    Do While a > 0
'        r = a Mod 10
'        If r < min Then
'            min = r
'        End If
'        a = a / 10
'    Loop
'    ListBox1.Items.Add("минимальная цифра: " + min.ToString)
'    Do
'        r = m Mod 10
'        If r = min Then
'            k = k + 1
'        End If
'        If min < r Then
'            min = r
'            k = 1
'        End If
'        m = m / 10
'    Loop
'    ListBox1.Items.Add("количество минимальны цифра=" & k)



'Do While m > 9
'    r = m Mod 10
'    If r = min Then
'        'ListBox1.Items.Add("r: " + r.ToString)
'        k = k + 1
'    End If
'    m = m - r
'    m = m / 10
'Loop
'If m = min Then
'    'ListBox1.Items.Add("r: " + m.ToString)
'    k = k + 1
'End If
'ListBox1.Items.Add("количество минимальны цифра=" & k)




'    End Sub
'End Class




