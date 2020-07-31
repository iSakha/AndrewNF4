Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class smetaMainForm

    Dim dt_Global As DataTable

    Private Sub smetaMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createGlobal_dt()

    End Sub

    Private Sub btn_lighting_smeta_Click(sender As Object, e As EventArgs) Handles btn_lighting_smeta.Click

        Dim index As Integer
        '        String searchValue = "somestring";
        'Int rowIndex = -1;
        'foreach(DataGridViewRow row In DataGridView1.Rows)
        '{
        '    If (row.Cells[1].Value.ToString().Equals(searchValue))
        '    {
        '        rowIndex = row.Index;
        '        break;
        '    }
        '}

        For Each r As DataGridViewRow In DGV_smeta.Rows

            If r.Cells(2).Value = 1001001 Then
                index = r.Index
                DGV_smeta.Rows(index).Selected = True
                DGV_smeta.FirstDisplayedScrollingRowIndex = index
                Exit Sub
            End If
        Next r
    End Sub

    Private Sub btn_screen_smeta_Click(sender As Object, e As EventArgs) Handles btn_screen_smeta.Click

    End Sub

    Private Sub btn_commut_smeta_Click(sender As Object, e As EventArgs) Handles btn_commut_smeta.Click

    End Sub

    Private Sub btn_truss_smeta_Click(sender As Object, e As EventArgs) Handles btn_truss_smeta.Click

    End Sub

    Private Sub btn_construct_smeta_Click(sender As Object, e As EventArgs) Handles btn_construct_smeta.Click

    End Sub

    Private Sub btn_sound_smeta_Click(sender As Object, e As EventArgs) Handles btn_sound_smeta.Click

    End Sub
End Class