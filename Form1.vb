Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x, y, z, year

        year = TextBox1.Text
        x = year Mod 4
        y = year Mod 100
        z = year Mod 400

        If ((x = 0 And Not (y = 0)) Or z = 0) Then
            Label2.Text = "this is a leap year"
        Else
            Label2.Text = "this is not a leap year"
        End If


    End Sub
End Class
