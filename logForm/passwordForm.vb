Public Class passwordForm
    Function superPass()

        Dim passOK As Boolean
        Dim pass As String = txt_admin_pass.Text

        If pass = "iSakha2836" Then
            passOK = True
        Else
            passOK = False
        End If
        Return passOK

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If superPass() Then
            Me.Close()
            loginForm.Hide()
            mainForm.Show()
        Else
            MsgBox("Wrong password!")
            Me.Close()
            loginForm.Close()
        End If
    End Sub
End Class