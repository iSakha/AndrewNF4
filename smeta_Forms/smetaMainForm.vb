Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable
    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createGlobal_dt()
        format_DGV_smeta()
        txt_pwr.Text = 0
        txt_price.Text = 0
        txt_weight.Text = 0
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
     Handles DGV_db.Scroll

        Console.WriteLine(DGV_db.FirstDisplayedScrollingRowIndex)

    End Sub

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
        DGV_smeta.Columns.Add("Col_0", "Dep")
        DGV_smeta.Columns.Add("Col_1", "Cat")
        DGV_smeta.Columns.Add("Col_2", "ID")
        DGV_smeta.Columns.Add("Col_3", "Fixture")
        DGV_smeta.Columns.Add("Col_4", "Qty")
    End Sub
End Class