Public Class loginForm
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Hide()
        mainForm.Show()
    End Sub
End Class