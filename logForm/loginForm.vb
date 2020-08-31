Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO
Public Class loginForm

    Public loginDict As Dictionary(Of String, String)

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim user, pass As String
        user = cmb_login.SelectedItem
        pass = txt_pass.Text

        If pass = loginDict(user) Then
            Me.Hide()
            mainForm.Show()
        Else
            MsgBox("Wrong login or password,try again")
            txt_pass.Text = ""
            cmb_login.Text = ""
            cmb_login.Select()
        End If
    End Sub

    Private Sub cmb_login_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_login.SelectedIndexChanged

        If cmb_login.SelectedItem = "superAdmin" Then
            passwordForm.Show()
        End If
    End Sub


    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mainForm.sDir = My.Settings.databasePath
            Dim path As String
            path = mainForm.sDir & "\Log.txt"
            Dim ws As ExcelWorksheet
            Dim excelFile = New FileInfo(path)
            Dim xlTbl As ExcelTable
            Dim endRow, startColumn As Integer

            Dim user, pass As String

        Try

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Dim Excel As ExcelPackage = New ExcelPackage(excelFile)


            ws = Excel.Workbook.Worksheets("Login")
            xlTbl = ws.Tables("login_tbl")


            startColumn = xlTbl.Address.Start.Column
            endRow = xlTbl.Address.End.Row

            loginDict = New Dictionary(Of String, String)

            For i As Integer = 2 To endRow
                user = ws.Cells(i, startColumn + 1).Value
                pass = ws.Cells(i, startColumn + 2).Value

                loginDict.Add(user, pass)

                cmb_login.Items().Add(user)

            Next i

        Catch ex As Exception
            MsgBox("Set path to DB")
        End Try


    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_pass.Text = ""
        cmb_login.Text = ""
        cmb_login.Select()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_registr_Click(sender As Object, e As EventArgs) Handles btn_registr.Click
        registrationForm.Show()
    End Sub
End Class