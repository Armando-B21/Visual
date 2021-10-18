Public Class Form1
    Dim n1, n2, r, oper, punto As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        oper = 1
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button18.Enabled = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        n2 = Val(TextBox1.Text)
        If oper = 1 Then
            r = n1 + n2
            TextBox1.Text = r
        ElseIf oper = 2 Then
            r = n1 + n2
            TextBox1.Text = r
        ElseIf oper = 3 Then
            r = n1 * n2
            TextBox1.Text = r
        ElseIf oper = 4 Then
            r = n1 / n2
            TextBox1.Text = r


        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        oper = 2
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button18.Enabled = True

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        oper = 3
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button18.Enabled = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = TextBox1.Text & "."
        punto = 1
        If punto = 1 Then
            Button18.Enabled = False

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        End
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        oper = 4
        n1 = Val(TextBox1.Text)
        TextBox1.Clear()
        Button18.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Clear()
        Button18.Enabled = True
    End Sub
End Class
