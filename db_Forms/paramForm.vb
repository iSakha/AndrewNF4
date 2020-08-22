Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class paramForm
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'Creating DataTable.
        Dim dt As New DataTable()

        ''Adding the Columns.
        'For Each column As DataGridViewColumn In dgv.Columns
        '    dt.Columns.Add(column.HeaderText, column.ValueType)
        'Next

        ''Adding the Rows.
        'For Each row As DataGridViewRow In dgv.Rows
        '    dt.Rows.Add()
        '    For Each cell As DataGridViewCell In row.Cells
        '        dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value
        '    Next
        'Next

        dt = TryCast(dgv.DataSource, DataTable)

        Console.WriteLine(dt.TableName)

        Dim xlTable As ExcelTable
        Dim startCellAddress As String

        Dim excelFile = New FileInfo(mainForm.filePath(mainForm.iDepartment + 1))
        Dim ws As ExcelWorksheet

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        Console.WriteLine(excelFile.Name)

        ws = Excel.Workbook.Worksheets(mainForm.iCategory)

        Console.WriteLine(ws.Name)

        xlTable = ws.Tables(0)

        Console.WriteLine(xlTable.Name)
        startCellAddress = xlTable.Range.Start.Address
        Console.WriteLine(startCellAddress)
        For i As Integer = 0 To dt.Columns.Count - 1
            Console.WriteLine(dt.Columns(i).ColumnName)
        Next
        ws.Cells(startCellAddress).LoadFromDataTable(dt, True)
        Excel.SaveAs(excelFile)

    End Sub
End Class