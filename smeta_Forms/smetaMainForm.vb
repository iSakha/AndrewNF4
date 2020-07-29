Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable

    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createGlobal_dt()

    End Sub
End Class