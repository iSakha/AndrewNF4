Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class registrationForm
    Private Sub registrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oldAddr As OfficeOpenXml.ExcelAddressBase
        Dim newAddr As OfficeOpenXml.ExcelAddressBase

        Dim path As String
        path = mainForm.sDir & "\Log.txt"
        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(path)
        Dim xlTbl As ExcelTable
        Dim endRow, startColumn As Integer

        Dim user, pass As String

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)


        ws = Excel.Workbook.Worksheets("Login")
        xlTbl = ws.Tables("login_tbl")

        txt_login_reg.Text = ""
        txt_pass_reg.Text = ""
        txt_pass_confirm.Text = ""

    End Sub
    Function checkName()
        Dim name As String = txt_login_reg.Text
        Dim name_ok As Boolean

        For Each item As KeyValuePair(Of String, String) In loginForm.loginDict
            If item.Key = name Then
                name_ok = False
                Exit For
            Else
                name_ok = True
            End If
        Next
        Return name_ok
    End Function

    Function checkPass()
        Dim pass_ok As Boolean
        If txt_pass_reg.Text = txt_pass_confirm.Text Then
            pass_ok = True
        Else
            pass_ok = False
        End If
        Return pass_ok
    End Function

    Private Sub btn_registr_Click(sender As Object, e As EventArgs) Handles btn_registr.Click

        If checkName() Then

        Else
            MsgBox("This name already exists!")
            txt_login_reg.Text = ""
            Exit Sub
        End If

        If checkPass() Then
            MsgBox("Pass ok")
            Me.Close()
        Else
            MsgBox("Wrong password confirmation")
        End If

    End Sub
End Class