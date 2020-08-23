Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable

    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createGlobal_dt()
        format_DGV_smeta()
    End Sub

    Private Sub btn_lighting_smeta_Click(sender As Object, e As EventArgs) Handles btn_lighting_smeta.Click
        setScroll(1001001)
    End Sub

    Private Sub btn_screen_smeta_Click(sender As Object, e As EventArgs) Handles btn_screen_smeta.Click
        setScroll(2001001)
    End Sub

    Private Sub btn_commut_smeta_Click(sender As Object, e As EventArgs) Handles btn_commut_smeta.Click
        setScroll(3001001)
    End Sub

    Private Sub btn_truss_smeta_Click(sender As Object, e As EventArgs) Handles btn_truss_smeta.Click
        setScroll(4001001)
    End Sub

    Private Sub btn_construct_smeta_Click(sender As Object, e As EventArgs) Handles btn_construct_smeta.Click
        setScroll(5001001)
    End Sub

    Private Sub btn_sound_smeta_Click(sender As Object, e As EventArgs) Handles btn_sound_smeta.Click
        setScroll(6001001)
    End Sub

    Private Sub DGV_smeta_Scroll(sender As Object, e As ScrollEventArgs) _
     Handles DGV_smeta.Scroll

        Console.WriteLine(DGV_smeta.FirstDisplayedScrollingRowIndex)

    End Sub

    Private Sub DGV_smeta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_smeta.CellClick
        DGV_smeta_clickCell(sender, e)
    End Sub

    Private Sub btn_clrSelRow_smeta_Click(sender As Object, e As EventArgs) Handles btn_clrSelRow_smeta.Click

        Dim index As Integer
        Dim selectedRow As DataGridViewRow
        index = DGV_smeta.SelectedCells.Item(0).RowIndex
        selectedRow = DGV_smeta.Rows(index)
        selectedRow.DefaultCellStyle.BackColor = DGV_smeta.DefaultCellStyle.BackColor
        DGV_smeta.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(242, 245, 245)
        selectedRow.Cells(3).Style.BackColor = Color.FromArgb(242, 245, 245)
        DGV_smeta.Rows(index).Selected = False

    End Sub

    Private Sub DGV_smeta_Enter(sender As Object, e As EventArgs) Handles DGV_smeta.Enter

    End Sub

    Private Sub DGV_smeta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV_smeta.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Dim row As DataGridViewRow

            For Each row In DGV_smeta.Rows
                If row.Cells(20).Value > 0 Then
                    row.DefaultCellStyle.BackColor = Color.Yellow
                Else
                    row.DefaultCellStyle.BackColor = SystemColors.Window
                End If

            Next row

        End If
    End Sub
End Class