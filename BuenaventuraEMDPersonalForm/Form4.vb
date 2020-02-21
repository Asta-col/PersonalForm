Public Class Form4
    Public Property NamePass As String
    Public Property AgePass As String
    Public Property AddressPass As String

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "'" + NamePass + "'"
        Label2.Text = AgePass
        Label3.Text = "'" + AddressPass + "'"
    End Sub


End Class