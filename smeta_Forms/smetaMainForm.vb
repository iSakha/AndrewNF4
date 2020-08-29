Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable

    '===================================================================================
    '             === Load Smeta Form  ===
    '===================================================================================
    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createGlobal_dt()
        format_DGV_smeta(DGV_db)
        format_DGV_smeta(DGV_smeta)
        txt_pwr.Text = 0
        txt_price.Text = 0
        txt_weight.Text = 0

        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days

        txt_daysQty.Text = days

        '           Fill up cities combobox
        '----------------------------------------------------------------
        Dim sPath As String
        sPath = mainForm.sDir & "\Log.txt"
        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(sPath)
        Dim xlTbl As ExcelTable
        Dim city As String
        Dim endRow As Integer

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        ws = Excel.Workbook.Worksheets("Location")

        xlTbl = ws.Tables("Cities")
        endRow = xlTbl.Address.End.Row
        For i As Integer = 2 To endRow
            city = ws.Cells(i, 2).Value
            cmb_eventCity.Items().Add(city)
        Next i

        lbl_cat_value.Text = ""

        lbl_depart_value.Text = "Lighting"
        lbl_depart_value.BackColor = btn_lighting_smeta.BackColor
        DGV_db.ClearSelection()

    End Sub

    '           Fill up locations combobox
    '----------------------------------------------------------------
    Private Sub cmb_eventCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_eventCity.SelectedIndexChanged

        cmb_eventLocation.Items.Clear()
        cmb_eventLocation.Text = ""
        Dim sPath As String
        sPath = mainForm.sDir & "\Log.txt"
        Dim ws As ExcelWorksheet
        Dim excelFile = New FileInfo(sPath)
        Dim xlTbl As ExcelTable
        Dim city, location As String
        Dim endRow, startColumn As Integer

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim Excel As ExcelPackage = New ExcelPackage(excelFile)

        ws = Excel.Workbook.Worksheets("Location")
        city = "City_" & cmb_eventCity.SelectedIndex.ToString
        'Console.WriteLine(city)
        xlTbl = ws.Tables(city)
        startColumn = xlTbl.Address.Start.Column
        endRow = xlTbl.Address.End.Row

        For i As Integer = 2 To endRow
            location = ws.Cells(i, startColumn).Value
            cmb_eventLocation.Items().Add(location)
        Next i
    End Sub

    '===================================================================================
    '             === Select Department buttons ===
    '===================================================================================

    '             === Lighting button ===
    '===================================================================================
    Private Sub btn_lighting_smeta_Click(sender As Object, e As EventArgs) Handles btn_lighting_smeta.Click
        setScroll(1001001)
        changeButtonStyle(sender)
    End Sub
    '             === Screen button ===
    '===================================================================================
    Private Sub btn_screen_smeta_Click(sender As Object, e As EventArgs) Handles btn_screen_smeta.Click
        setScroll(2001001)
        changeButtonStyle(sender)
    End Sub
    '             === Commutation button ===
    '===================================================================================
    Private Sub btn_commut_smeta_Click(sender As Object, e As EventArgs) Handles btn_commut_smeta.Click
        setScroll(3001001)
        changeButtonStyle(sender)
    End Sub
    '             === Trusses and motors button ===
    '===================================================================================
    Private Sub btn_truss_smeta_Click(sender As Object, e As EventArgs) Handles btn_truss_smeta.Click
        setScroll(4001001)
        changeButtonStyle(sender)
    End Sub
    '             === Construction button ===
    '===================================================================================
    Private Sub btn_construct_smeta_Click(sender As Object, e As EventArgs) Handles btn_construct_smeta.Click
        setScroll(5001001)
        changeButtonStyle(sender)
    End Sub
    '             === Sound button ===
    '===================================================================================
    Private Sub btn_sound_smeta_Click(sender As Object, e As EventArgs) Handles btn_sound_smeta.Click
        setScroll(6001001)
        changeButtonStyle(sender)
    End Sub

    Private Sub DGV_smeta_Scroll(sender As Object, e As ScrollEventArgs) _
     Handles DGV_db.Scroll

        Console.WriteLine(DGV_db.FirstDisplayedScrollingRowIndex)

    End Sub
    '===================================================================================
    '             === DGV_smeta CellClick ===
    '===================================================================================
    Private Sub DGV_smeta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_db.CellClick
        DGV_smeta_clickCell(sender, e)
    End Sub

    Private Sub DGV_smeta_Enter(sender As Object, e As EventArgs) Handles DGV_db.Enter

    End Sub

    Private Sub DGV_smeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV_db.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            enumRows()
        End If
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

        Dim targetRows = enumRows()
        DGV_smeta.Rows.Clear()
        For Each drr As DataGridViewRow In enumRows()
            Dim row As DataGridViewRow = CType(drr.Clone(), DataGridViewRow)
            For i As Int32 = 0 To drr.Cells.Count - 1
                row.Cells(i).Value = drr.Cells(i).Value
                row.DefaultCellStyle.BackColor = SystemColors.Window
            Next
            DGV_smeta.Rows.Add(row)
        Next

        tbCtrl_smeta.SelectedIndex = 1
        DGV_smeta.ClearSelection()

    End Sub

    Private Sub btn_clr_filter_Click(sender As Object, e As EventArgs) Handles btn_clr_filter.Click
        tbCtrl_smeta.SelectedIndex = 0
    End Sub

    Private Sub DTP_start_ValueChanged(sender As Object, e As EventArgs) Handles DTP_start.ValueChanged
        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days
        txt_daysQty.Text = days

        DTP_end.Visible = True
    End Sub

    Private Sub DTP_end_ValueChanged(sender As Object, e As EventArgs) Handles DTP_end.ValueChanged
        Dim dateOne = DTP_start.Value
        Dim dateTwo = DTP_end.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim days = diff.Days
        txt_daysQty.Text = days
    End Sub

End Class