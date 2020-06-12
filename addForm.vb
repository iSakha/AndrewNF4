Public Class addForm

    Public fxtName As String
    Public fxtQty As String

    Public qty_belimlight1, qty_belimlight2, qty_belimlight3 As Integer
    Public qty_belimlight As Integer
    Public qty_PRlighting1, qty_PRlighting2, qty_PRlighting3 As Integer
    Public qty_PRlighting As Integer
    Public qty_blackout1, qty_blackout2, qty_blackout3 As Integer
    Public qty_blackout As Integer
    Public qty_vision1, qty_vision2, qty_vision3 As Integer
    Public qty_vision As Integer
    Public qty_stage1, qty_stage2, qty_stage3 As Integer
    Public qty_stage As Integer
    Public name_belimlight1, name_belimlight2, name_belimlight3 As String
    Public name_PRlighting1, name_PRlighting2, name_PRlighting3 As String
    Public name_blackout1, name_blackout2, name_blackout3 As String
    Public name_vision1, name_vision2, name_vision3 As String
    Public name_stage1, name_stage2, name_stage3 As String

    Dim txtBxs(4, 7) As Object

    Private Sub addForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBxs = New Object(4, 7) {
            {txt_name_addform, txt_qty_addform, txt_belimlight1_addform, txt_qty_belimlight1_addform,
            txt_belimlight2_addform, txt_qty_belimlight2_addform, txt_belimlight3_addform, txt_qty_belimlight3_addform},
            {txt_name_addform, txt_qty_addform, txt_PRlighting1_addform, txt_qty_PRlighting1_addform,
            txt_PRlighting2_addform, txt_qty_PRlighting2_addform, txt_PRlighting3_addform, txt_qty_PRlighting3_addform},
            {txt_name_addform, txt_qty_addform, txt_blackout1_addform, txt_qty_blackout1_addform,
            txt_blackout2_addform, txt_qty_blackout2_addform, txt_blackout3_addform, txt_qty_blackout3_addform},
            {txt_name_addform, txt_qty_addform, txt_vision1_addform, txt_qty_vision1_addform,
            txt_vision2_addform, txt_qty_vision2_addform, txt_vision3_addform, txt_qty_vision3_addform},
            {txt_name_addform, txt_qty_addform, txt_stage1_addform, txt_qty_stage1_addform,
            txt_stage2_addform, txt_qty_stage2_addform, txt_stage3_addform, txt_qty_stage3_addform}
        }



    End Sub

    Private Sub btn_close_addform_Click(sender As Object, e As EventArgs) Handles btn_close_addform.Click
        Me.Close()
    End Sub

    Sub writeIntoTxtbxs(_sRow As String, _i As Integer, _j As Integer)

        txtBxs(_i, _j).text = _sRow
        calculate()

    End Sub

    Sub calculate()
        qty_belimlight1 = Integer.Parse(txt_qty_belimlight1_addform.Text)
        qty_belimlight2 = Integer.Parse(txt_qty_belimlight2_addform.Text)
        qty_belimlight3 = Integer.Parse(txt_qty_belimlight3_addform.Text)

        qty_belimlight = qty_belimlight1 + qty_belimlight2 + qty_belimlight3

        qty_PRlighting1 = Integer.Parse(txt_qty_PRlighting1_addform.Text)
        qty_PRlighting2 = Integer.Parse(txt_qty_PRlighting2_addform.Text)
        qty_PRlighting3 = Integer.Parse(txt_qty_PRlighting3_addform.Text)

        qty_PRlighting = qty_PRlighting1 + qty_PRlighting2 + qty_PRlighting3

        qty_blackout1 = Integer.Parse(txt_qty_blackout1_addform.Text)
        qty_blackout2 = Integer.Parse(txt_qty_blackout2_addform.Text)
        qty_blackout3 = Integer.Parse(txt_qty_blackout3_addform.Text)

        qty_blackout = qty_blackout1 + qty_blackout2 + qty_blackout3

        qty_vision1 = Integer.Parse(txt_qty_vision1_addform.Text)
        qty_vision2 = Integer.Parse(txt_qty_vision2_addform.Text)
        qty_vision3 = Integer.Parse(txt_qty_vision3_addform.Text)

        qty_vision = qty_vision1 + qty_vision2 + qty_vision3

        qty_stage1 = Integer.Parse(txt_qty_stage1_addform.Text)
        qty_stage2 = Integer.Parse(txt_qty_stage2_addform.Text)
        qty_stage3 = Integer.Parse(txt_qty_stage3_addform.Text)

        qty_stage = qty_stage1 + qty_stage2 + qty_stage3

        txt_qty_belimlight.Text = qty_belimlight
        txt_qty_PRlighting.Text = qty_PRlighting
        txt_qty_blackout.Text = qty_blackout
        txt_qty_vision.Text = qty_vision
        txt_qty_stage.Text = qty_stage

    End Sub

    Sub writeInto_dts()
        qty_belimlight1 = Integer.Parse(txt_qty_belimlight1_addform.Text)
        qty_belimlight2 = Integer.Parse(txt_qty_belimlight2_addform.Text)
        qty_belimlight3 = Integer.Parse(txt_qty_belimlight3_addform.Text)

        qty_belimlight = qty_belimlight1 + qty_belimlight2 + qty_belimlight3

        qty_PRlighting1 = Integer.Parse(txt_qty_PRlighting1_addform.Text)
        qty_PRlighting2 = Integer.Parse(txt_qty_PRlighting2_addform.Text)
        qty_PRlighting3 = Integer.Parse(txt_qty_PRlighting3_addform.Text)

        qty_PRlighting = qty_PRlighting1 + qty_PRlighting2 + qty_PRlighting3

        qty_blackout1 = Integer.Parse(txt_qty_blackout1_addform.Text)
        qty_blackout2 = Integer.Parse(txt_qty_blackout2_addform.Text)
        qty_blackout3 = Integer.Parse(txt_qty_blackout3_addform.Text)

        qty_blackout = qty_blackout1 + qty_blackout2 + qty_blackout3

        qty_vision1 = Integer.Parse(txt_qty_vision1_addform.Text)
        qty_vision2 = Integer.Parse(txt_qty_vision2_addform.Text)
        qty_vision3 = Integer.Parse(txt_qty_vision3_addform.Text)

        qty_vision = qty_vision1 + qty_vision2 + qty_vision3

        qty_stage1 = Integer.Parse(txt_qty_stage1_addform.Text)
        qty_stage2 = Integer.Parse(txt_qty_stage2_addform.Text)
        qty_stage3 = Integer.Parse(txt_qty_stage3_addform.Text)

        qty_stage = qty_stage1 + qty_stage2 + qty_stage3

        txt_qty_belimlight.Text = qty_belimlight
        txt_qty_PRlighting.Text = qty_PRlighting
        txt_qty_blackout.Text = qty_blackout
        txt_qty_vision.Text = qty_vision
        txt_qty_stage.Text = qty_stage

        name_belimlight1 = txt_belimlight1_addform.Text
        name_belimlight2 = txt_belimlight2_addform.Text
        name_belimlight3 = txt_belimlight3_addform.Text

        name_PRlighting1 = txt_PRlighting1_addform.Text
        name_PRlighting2 = txt_PRlighting2_addform.Text
        name_PRlighting3 = txt_PRlighting3_addform.Text

        name_blackout1 = txt_blackout1_addform.Text
        name_blackout2 = txt_blackout2_addform.Text
        name_blackout3 = txt_blackout3_addform.Text

        name_vision1 = txt_vision1_addform.Text
        name_vision2 = txt_vision2_addform.Text
        name_vision3 = txt_vision3_addform.Text

        name_stage1 = txt_stage1_addform.Text
        name_stage2 = txt_stage2_addform.Text
        name_stage3 = txt_stage3_addform.Text

        fxtName = txt_name_addform.Text
        fxtQty = Integer.Parse(txt_qty_addform.Text)

        Dim sRow(4, 7) As String
        Dim row As DataRow
        Dim dt As DataTable

        sRow = New String(4, 7) {
            {fxtName, fxtQty, name_belimlight1, qty_belimlight1, name_belimlight2, qty_belimlight2, name_belimlight3, qty_belimlight3},
            {fxtName, fxtQty, name_PRlighting1, qty_PRlighting1, name_PRlighting2, qty_PRlighting2, name_PRlighting3, qty_PRlighting3},
            {fxtName, fxtQty, name_blackout1, qty_blackout1, name_blackout2, qty_blackout2, name_blackout3, qty_blackout3},
            {fxtName, fxtQty, name_vision1, qty_vision1, name_vision2, qty_vision2, name_vision3, qty_vision3},
            {fxtName, fxtQty, name_stage1, qty_stage1, name_stage2, qty_stage2, name_stage3, qty_stage3}
        }


    End Sub
End Class