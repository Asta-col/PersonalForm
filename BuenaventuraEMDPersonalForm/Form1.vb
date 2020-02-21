Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OBJ As New Form2
        OBJ.NamePass = TextBox1.Text
        OBJ.AgePass = TextBox2.Text
        OBJ.AddressPass = TextBox3.Text
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OBJ As New Form3
        OBJ.NamePass = TextBox1.Text
        OBJ.AgePass = TextBox2.Text
        OBJ.AddressPass = TextBox3.Text
        OBJ.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OBJ As New Form4
        OBJ.NamePass = TextBox1.Text
        OBJ.AgePass = TextBox2.Text
        OBJ.AddressPass = TextBox3.Text
        OBJ.Show()
    End Sub
End Class
