Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Module myFunc

    '===================================================================================
    '             === Write to labels ===
    '===================================================================================
#Region "WriteToLabels"
    Sub writeToLabel(_department As String, _sender As Object)
        mainForm.GroupBox1.Visible = True
        mainForm.GroupBox2.Visible = True
        mainForm.lbl_dpartmentValue.Text = _department
        mainForm.lbl_subsectionValue.Text = _sender.text
        mainForm.dgv.DataSource = Nothing
        sumForm.dgv_sum.DataSource = Nothing
    End Sub

    Sub writeToLabelCompany(_sender As Object)
        mainForm.GroupBox3.Visible = True
        mainForm.lbl_companyValue.Text = _sender.text
    End Sub
#End Region
    '===================================================================================
    '             === Create dataset ===
    '===================================================================================
    Sub create_dataset(_iDEpartment As Integer, _iCategory As Integer)

        Dim dt As DataTable

        Dim xlTable As ExcelTable
        Dim adr As String
        Dim row As DataRow
        Dim ws As ExcelWorksheet
        Dim r_xlTable, c_xlTable As Integer
        Dim rng As ExcelRange


        mainForm.dts = New DataSet

        ws = mainForm.i_pivot_wsDict(_iDEpartment)(_iCategory)

        For k As Integer = 0 To ws.Tables.Count - 1

            xlTable = ws.Tables(k)
            c_xlTable = xlTable.Address.Columns
            r_xlTable = xlTable.Address.Rows

            adr = xlTable.Address.Address
            rng = ws.Cells(adr)

            Select Case k

                Case = 0

                    dt = New DataTable
                    dt.TableName = xlTable.Name

                    'Adding the Columns
                    For i = 0 To c_xlTable - 1
                        dt.Columns.Add(rng.Value(0, i))
                    Next i

                    dt.Columns(0).DataType = System.Type.GetType("System.Int32")               ' #
                    dt.Columns(1).DataType = System.Type.GetType("System.String")              ' Fixture
                    dt.Columns(2).DataType = System.Type.GetType("System.Int32")               ' Q-ty
                    dt.Columns(3).DataType = System.Type.GetType("System.Int32")               ' BelImlight
                    dt.Columns(4).DataType = System.Type.GetType("System.Int32")               ' PRLightigTouring
                    dt.Columns(5).DataType = System.Type.GetType("System.Int32")               ' BlackOut
                    dt.Columns(6).DataType = System.Type.GetType("System.Int32")               ' Vision
                    dt.Columns(7).DataType = System.Type.GetType("System.Int32")               ' Stage
                    dt.Columns(8).DataType = System.Type.GetType("System.Int32")               ' Weight
                    If mainForm.iDepartment = 3 Then
                        dt.Columns(9).DataType = System.Type.GetType("System.String")          ' Power/length
                    Else
                        dt.Columns(9).DataType = System.Type.GetType("System.Int32")           ' Power/length
                    End If

                    dt.Columns(10).DataType = System.Type.GetType("System.Int32")              ' Price
                    dt.Columns.Add()
                    dt.Columns(11).DataType = System.Type.GetType("System.Int32")              ' Result
                    dt.Columns(11).ColumnName = "Result"


                    For i = 1 To r_xlTable - 1

                        row = dt.Rows.Add()

                        For j = 0 To c_xlTable - 1

                            row.Item(j) = rng.Value(i, j)

                        Next j

                        Dim val, val_bel, val_pr, val_black, val_vis, val_st As Integer

                        val = row.Item(2)
                        val_bel = row.Item(3)
                        val_pr = row.Item(4)
                        val_black = row.Item(5)
                        val_vis = row.Item(6)
                        val_st = row.Item(7)

                        row.Item(c_xlTable) = val - (val_bel + val_pr + val_black + val_vis + val_st)

                    Next i

                Case > 0

                    dt = New DataTable
                    dt.TableName = xlTable.Name

                    'Adding the Columns
                    For i = 0 To c_xlTable - 1
                        dt.Columns.Add(rng.Value(0, i))
                    Next i

                    dt.Columns(0).DataType = System.Type.GetType("System.Int32")
                    dt.Columns(1).DataType = System.Type.GetType("System.String")
                    dt.Columns(2).DataType = System.Type.GetType("System.Int32")
                    dt.Columns(3).DataType = System.Type.GetType("System.String")
                    dt.Columns(4).DataType = System.Type.GetType("System.Int32")
                    dt.Columns(5).DataType = System.Type.GetType("System.String")
                    dt.Columns(6).DataType = System.Type.GetType("System.Int32")
                    dt.Columns(7).DataType = System.Type.GetType("System.String")
                    dt.Columns(8).DataType = System.Type.GetType("System.Int32")


                    'Add Rows from Excel table

                    For i = 1 To r_xlTable - 1
                        row = dt.Rows.Add()

                        For j = 0 To c_xlTable - 1

                            If rng.Value(i, j) = Nothing Then
                                Select Case j
                                    Case 3
                                        row.Item(j) = ""
                                    Case 4
                                        row.Item(j) = 0
                                    Case 5
                                        row.Item(j) = ""
                                    Case 6
                                        row.Item(j) = 0
                                    Case 7
                                        row.Item(j) = ""
                                    Case 8
                                        row.Item(j) = 0
                                End Select
                            Else
                                row.Item(j) = rng.Value(i, j)
                            End If

                        Next j
                    Next i

            End Select

            mainForm.dts.Tables.Add(dt)
        Next k

    End Sub

    '===================================================================================      
    '                === Format DataGridView ===
    '===================================================================================
#Region "Format DGV"
    Sub format_dgv_dataset(_color As Color)

        mainForm.dgv.Columns(0).Width = 40                ' #
        mainForm.dgv.Columns(1).Width = 175               ' Fixture
        mainForm.dgv.Columns(2).Width = 40                ' Q-ty
        mainForm.dgv.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(3).Width = 220               ' BelImlight_1  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(4).Width = 40                ' Q-ty_1
        mainForm.dgv.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(5).Width = 220               ' BelImlight_2  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(6).Width = 40                ' Q-ty_2
        mainForm.dgv.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        mainForm.dgv.Columns(7).Width = 180               ' BelImlight_3  (PRLightigTouring, BlackOut, Vision, Stage)
        mainForm.dgv.Columns(8).Width = 40                ' Q-ty_3
        mainForm.dgv.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For i = 0 To mainForm.dgv.Rows.Count - 2

            'mainForm.DGV_in.Rows(i).Cells(1).Value = Date.FromOADate(mainForm.DGV_in.Rows(i).Cells(1).Value)
            mainForm.dgv.RowsDefaultCellStyle.BackColor = _color
            mainForm.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)

        Next i

    End Sub

    '===================================================================================
    '             === Format sumDGV ===
    '===================================================================================

    Sub format_sumDGV()

        Dim col() As Color

        col = {Color.FromArgb(252, 228, 214), Color.FromArgb(221, 235, 247), Color.FromArgb(237, 237, 237),
            Color.FromArgb(226, 239, 218), Color.FromArgb(237, 226, 246)}

        sumForm.dgv_sum.Columns(0).Width = 55                ' #
        sumForm.dgv_sum.Columns(1).Width = 230               ' Fixture
        sumForm.dgv_sum.Columns(2).Width = 65                ' Q-ty
        sumForm.dgv_sum.Columns(2).DefaultCellStyle.Font = New Font("Tahoma", 10)
        sumForm.dgv_sum.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(3).Width = 62                ' BelImlight
        sumForm.dgv_sum.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(4).Width = 62                ' PRLightigTouring
        sumForm.dgv_sum.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(5).Width = 62                ' BlackOut
        sumForm.dgv_sum.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(6).Width = 62                ' Vision
        sumForm.dgv_sum.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(7).Width = 62                ' Stage
        sumForm.dgv_sum.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        sumForm.dgv_sum.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        sumForm.dgv_sum.Columns(11).Width = 65
        sumForm.dgv_sum.Columns(11).DefaultCellStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

        sumForm.dgv_sum.Columns(3).DefaultCellStyle.BackColor = col(0)
        sumForm.dgv_sum.Columns(4).DefaultCellStyle.BackColor = col(1)
        sumForm.dgv_sum.Columns(5).DefaultCellStyle.BackColor = col(2)
        sumForm.dgv_sum.Columns(6).DefaultCellStyle.BackColor = col(3)
        sumForm.dgv_sum.Columns(7).DefaultCellStyle.BackColor = col(4)

        For i = 0 To sumForm.dgv_sum.Rows.Count - 2

            sumForm.dgv_sum.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)
            If sumForm.dgv_sum.Item(11, i).Value = 0 Then
                sumForm.dgv_sum.Item(0, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(1, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(2, i).Style.BackColor = Color.FromArgb(216, 238, 192)
                sumForm.dgv_sum.Item(11, i).Style.BackColor = Color.FromArgb(216, 238, 192)
            Else
                sumForm.dgv_sum.Item(0, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(1, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(2, i).Style.BackColor = Color.FromArgb(255, 183, 183)
                sumForm.dgv_sum.Item(11, i).Style.BackColor = Color.FromArgb(255, 183, 183)
            End If
        Next i

        sumForm.dgv_sum.Columns(8).Visible = False
        sumForm.dgv_sum.Columns(9).Visible = False
        sumForm.dgv_sum.Columns(10).Visible = False

    End Sub
#End Region

    '===================================================================================
    '             === CellClick on DGV ===
    '===================================================================================
    Sub dgv_clickCell(_sender As Object, _e As DataGridViewCellEventArgs)

        Dim index As Integer
        index = _e.RowIndex
        'Console.WriteLine(_e)
        Dim selectedRow As DataGridViewRow
        selectedRow = _sender.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(1).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(2).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(8).Value.ToString

        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running
        For Each f As Form In Application.OpenForms
            If f.Name = "sumForm" Then
                sumForm.dgv_sum.ClearSelection()
                sumForm.dgv_sum.Rows(index).Selected = True
            End If

            If f.Name = "addForm" Then
                showData(index)
            End If
        Next f
    End Sub
#Region "next/prev buttons"
    '===================================================================================
    '             === Prev record ===
    '===================================================================================
    Sub prevRecord()

        Dim index As Integer
        Dim selectedRow As DataGridViewRow


        index = mainForm.dgv.CurrentRow.Index

        mainForm.dgv.ClearSelection()

        mainForm.dgv.CurrentCell = mainForm.dgv.Item(0, index)
        mainForm.dgv.Rows(index).Selected = True


        If index = 0 Then
            index = mainForm.dgv.Rows.Count - 1
        End If



        index = index - 1
        mainForm.dgv.CurrentCell = mainForm.dgv.Item(0, index)
        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running
        For Each f As Form In Application.OpenForms
            If f.Name = "sumForm" Then
                sumForm.dgv_sum.ClearSelection()
                sumForm.dgv_sum.Rows(index).Selected = True
            End If
            If f.Name = "addForm" Then
                showData(index)
            End If
        Next f

        selectedRow = mainForm.dgv.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(1).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(2).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(8).Value.ToString


        'calcQuantity()

    End Sub

    '===================================================================================
    '             === Next record ===
    '===================================================================================
    Sub nextRecord()
        Dim index As Integer
        Dim selectedRow As DataGridViewRow

        index = mainForm.dgv.CurrentRow.Index

        mainForm.dgv.ClearSelection()


        mainForm.dgv.CurrentCell = mainForm.dgv.Item(0, index)
        mainForm.dgv.Rows(index).Selected = True

        If index = mainForm.dgv.Rows.Count - 2 Then
            index = -1
        End If



        index = index + 1
        mainForm.dgv.CurrentCell = mainForm.dgv.Item(0, index)
        mainForm.dgv.Rows(index).Selected = True
        '   Check is form running
        For Each f As Form In Application.OpenForms
            If f.Name = "sumForm" Then
                sumForm.dgv_sum.ClearSelection()
                sumForm.dgv_sum.Rows(index).Selected = True
            End If
            If f.Name = "addForm" Then
                showData(index)
            End If
        Next f

        selectedRow = mainForm.dgv.Rows(index)

        mainForm.rtb_fixtureName.Text = selectedRow.Cells(1).Value.ToString
        mainForm.txt_qty.Text = selectedRow.Cells(2).Value.ToString
        mainForm.rtb_FirstName.Text = selectedRow.Cells(3).Value.ToString
        mainForm.txt_qty1.Text = selectedRow.Cells(4).Value.ToString
        mainForm.rtb_SecondName.Text = selectedRow.Cells(5).Value.ToString
        mainForm.txt_qty2.Text = selectedRow.Cells(6).Value.ToString
        mainForm.rtb_ThirdName.Text = selectedRow.Cells(7).Value.ToString
        mainForm.txt_qty3.Text = selectedRow.Cells(8).Value.ToString

    End Sub
#End Region

    '===================================================================================
    '             === Calculate quantity ===
    '===================================================================================
    Sub calcQuantity()

        Dim index As Integer
        Dim i, j, qty, sum As Integer
        ' Dim smetaQty, companiesQty As Integer

        'i = mainForm.iCategory + 1

        index = mainForm.dgv.CurrentRow.Index

        For j = 1 To mainForm.dts.Tables.Count - 1
            sum = 0
            qty = mainForm.dts.Tables(j).Rows(index).Item(4)
            sum = sum + qty
            qty = mainForm.dts.Tables(j).Rows(index).Item(6)
            sum = sum + qty
            qty = mainForm.dts.Tables(j).Rows(index).Item(8)
            sum = sum + qty

            mainForm.dgv_result.Rows(0).Cells(j).Value = sum


        Next j

        Dim smetaQty As Integer = mainForm.dts.Tables(0).Rows(index).Item(2)

        Dim companiesQty As Integer = mainForm.dgv_result.Rows(0).Cells(1).Value +
        mainForm.dgv_result.Rows(0).Cells(2).Value +
        mainForm.dgv_result.Rows(0).Cells(3).Value +
        mainForm.dgv_result.Rows(0).Cells(4).Value +
        mainForm.dgv_result.Rows(0).Cells(5).Value

        mainForm.dgv_result.Rows(0).Cells(0).Value = smetaQty
        mainForm.dgv_result.Rows(0).Cells(6).Value = smetaQty - companiesQty

        If (smetaQty - companiesQty = 0) Then
            mainForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightGreen
        Else
            mainForm.dgv_result.Item(6, 0).Style.BackColor = Color.LightPink
        End If
    End Sub

    '===================================================================================
    '             === block CDUDbuttons ===
    '===================================================================================
    Sub blockButtons()

        mainForm.btn_add.Enabled = False
        mainForm.btn_update.Enabled = False
        mainForm.btn_delete.Enabled = False
        mainForm.btn_next.Enabled = False
        mainForm.btn_prev.Enabled = False

        mainForm.menuItem_department.Enabled = False
        mainForm.menuItem_company.Enabled = False

        mainForm.btn_save.FlatStyle = FlatStyle.Flat
        mainForm.btn_cancel.FlatStyle = FlatStyle.Flat
    End Sub
    '===================================================================================
    '             === unblock CDUDbuttons ===
    '===================================================================================
    Sub unBlockButtons()

        mainForm.btn_add.Enabled = True
        mainForm.btn_update.Enabled = True
        mainForm.btn_delete.Enabled = True
        mainForm.btn_next.Enabled = True
        mainForm.btn_prev.Enabled = True

        mainForm.menuItem_department.Enabled = True
        mainForm.menuItem_company.Enabled = True

        mainForm.btn_save.FlatStyle = FlatStyle.Standard
        mainForm.btn_cancel.FlatStyle = FlatStyle.Standard

    End Sub

    Sub showData(_index As Integer)
        'Console.WriteLine(_index)
        'Console.WriteLine(mainForm.dts.Tables(0).TableName)

        Dim sRow(4, 7) As String

        sRow = New String(4, 7) {
            {addForm.fxtName, addForm.fxtQty, addForm.name_belimlight1, addForm.qty_belimlight1, addForm.
            name_belimlight2, addForm.qty_belimlight2, addForm.name_belimlight3, addForm.qty_belimlight3},
            {addForm.fxtName, addForm.fxtQty, addForm.name_PRlighting1, addForm.qty_PRlighting1, addForm.
            name_PRlighting2, addForm.qty_PRlighting2, addForm.name_PRlighting3, addForm.qty_PRlighting3},
            {addForm.fxtName, addForm.fxtQty, addForm.name_blackout1, addForm.qty_blackout1, addForm.
            name_blackout2, addForm.qty_blackout2, addForm.name_blackout3, addForm.qty_blackout3},
            {addForm.fxtName, addForm.fxtQty, addForm.name_vision1, addForm.qty_vision1, addForm.
            name_vision2, addForm.qty_vision2, addForm.name_vision3, addForm.qty_vision3},
            {addForm.fxtName, addForm.fxtQty, addForm.name_stage1, addForm.qty_stage1, addForm.
            name_stage2, addForm.qty_stage2, addForm.name_stage3, addForm.qty_stage3}
        }

        For i As Integer = 0 To mainForm.dts.Tables.Count - 2
            For j As Integer = 0 To 7
                sRow(i, j) = mainForm.dts.Tables(i + 1).Rows(_index).Item(j + 1)
                addForm.writeIntoTxtbxs(sRow(i, j), i, j)
            Next j
        Next i

    End Sub

    Sub updateData()
        mainForm.dgv.DataSource = mainForm.dts
    End Sub

End Module
