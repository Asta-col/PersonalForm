Public Class Form2
    Public Property NamePass As String
    Public Property AgePass As String
    Public Property AddressPass As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = NamePass
        Label5.Text = AgePass
        Label6.Text = AddressPass
    End Sub
End Class