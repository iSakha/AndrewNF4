Public Class sumForm
    Private Sub sumForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainForm.sumFormFlag = False
    End Sub
End Class