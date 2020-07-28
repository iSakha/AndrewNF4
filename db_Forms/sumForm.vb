Public Class sumForm
    Private Sub sumForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainForm.sumFormFlag = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class