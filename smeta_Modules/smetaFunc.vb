Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO
Module smetaFunc
    Function createGlobal_dt()

        Dim dt As DataTable
        Dim row As DataRow

        Dim xlTable As ExcelTable
        Dim xlTable_Collection As Collection

        Dim adr As String
        Dim adr_Collection As Collection

        Dim ws As ExcelWorksheet

        Dim r_xlTable As Integer
        Dim r_xlTable_Collection As Collection

        Dim c_xlTable As Integer

        Dim rng As ExcelRange
        Dim rng_Collection As Collection

        dt = New DataTable
        dt.TableName = "Lighting"

        xlTable_Collection = New Collection
        adr_Collection = New Collection
        r_xlTable_Collection = New Collection
        c_xlTable = 13
        rng_Collection = New Collection



        For l As Integer = 0 To 5
            For i As Integer = 0 To mainForm.i_pivot_wsDict(l).Count - 1

                ws = mainForm.i_pivot_wsDict(l)(i)


                xlTable = ws.Tables(0)

                Console.WriteLine(xlTable.Name)

                adr = xlTable.Address.Address
                r_xlTable = xlTable.Address.Rows
                rng = ws.Cells(adr)

                xlTable_Collection.Add(xlTable)
                adr_Collection.Add(adr)
                r_xlTable_Collection.Add(r_xlTable)
                rng_Collection.Add(rng)

            Next i
        Next l
        'Adding the Columns

        For i = 0 To c_xlTable - 1
            dt.Columns.Add(rng_Collection(1).Value(0, i))
        Next i


        dt.Columns(0).DataType = System.Type.GetType("System.Int32")               ' Department
        dt.Columns(1).DataType = System.Type.GetType("System.Int32")               ' Category
        dt.Columns(2).DataType = System.Type.GetType("System.Int32")               ' ID
        dt.Columns(3).DataType = System.Type.GetType("System.String")              ' Fixture
        dt.Columns(4).DataType = System.Type.GetType("System.Int32")               ' Qty

        dt.Columns(5).DataType = System.Type.GetType("System.Int32")               ' Qty BelImlight 
        dt.Columns(6).DataType = System.Type.GetType("System.Int32")               ' Qty PRLightigTouring
        dt.Columns(7).DataType = System.Type.GetType("System.Int32")               ' Qty BlackOut
        dt.Columns(8).DataType = System.Type.GetType("System.Int32")               ' Qty Vision
        dt.Columns(9).DataType = System.Type.GetType("System.Int32")               ' Qty Stage

        dt.Columns(10).DataType = System.Type.GetType("System.Int32")               ' Weight
        dt.Columns(11).DataType = System.Type.GetType("System.Int32")               ' Power/Length
        dt.Columns(12).DataType = System.Type.GetType("System.Int32")               ' Price


        dt.Columns(0).ColumnName = "Dep"
        dt.Columns(1).ColumnName = "Cat"
        dt.Columns(2).ColumnName = "ID"
        dt.Columns(3).ColumnName = "Fixture"
        dt.Columns(4).ColumnName = "Qty"

        dt.Columns(10).ColumnName = "Weight"
        dt.Columns(11).ColumnName = "Power/Length"
        dt.Columns(12).ColumnName = "Price"

        Console.WriteLine(rng_Collection.Count)

        'Add Rows from Excel table

        For k As Integer = 1 To rng_Collection.Count            '   Categories

            For i = 1 To r_xlTable_Collection(k) - 1

                row = dt.Rows.Add()

                For j = 0 To c_xlTable - 1

                    row.Item(j) = rng_Collection(k).Value(i, j)

                Next j

            Next i

        Next k

        smetaMainForm.DGV_smeta.DataSource = dt

        Return (dt)

    End Function

    Sub setScroll(_value As Integer)
        Dim index As Integer

        For Each r As DataGridViewRow In smetaMainForm.DGV_smeta.Rows

            If r.Cells(2).Value = _value Then
                index = r.Index
                smetaMainForm.DGV_smeta.Rows(index).Selected = True
                smetaMainForm.DGV_smeta.FirstDisplayedScrollingRowIndex = index
                Exit Sub
            End If
        Next r
    End Sub

    Sub format_DGV_smeta()

        smetaMainForm.DGV_smeta.RowHeadersVisible = False

        smetaMainForm.DGV_smeta.Columns(0).Width = 30
        smetaMainForm.DGV_smeta.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For Each r As DataGridViewRow In smetaMainForm.DGV_smeta.Rows
            Select Case r.Cells(0).Value
                Case 1
                    r.Cells(0).Style.BackColor = Color.LemonChiffon
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LemonChiffon
                        r.Cells(2).Style.BackColor = Color.LemonChiffon
                    End If
                Case 2
                    r.Cells(0).Style.BackColor = Color.LightSteelBlue
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LightSteelBlue
                        r.Cells(2).Style.BackColor = Color.LightSteelBlue
                    End If
                Case 3
                    r.Cells(0).Style.BackColor = Color.MistyRose
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.MistyRose
                        r.Cells(2).Style.BackColor = Color.MistyRose
                    End If
                Case 4
                    r.Cells(0).Style.BackColor = Color.Honeydew
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.Honeydew
                        r.Cells(2).Style.BackColor = Color.Honeydew
                    End If
                Case 5
                    r.Cells(0).Style.BackColor = Color.LightCyan
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.LightCyan
                        r.Cells(2).Style.BackColor = Color.LightCyan
                    End If
                Case 6
                    r.Cells(0).Style.BackColor = Color.Thistle
                    If odd_even(r.Cells(1).Value) Then
                        r.Cells(1).Style.BackColor = Color.Thistle
                        r.Cells(2).Style.BackColor = Color.Thistle
                    End If
            End Select
        Next r


        smetaMainForm.DGV_smeta.Columns(1).Width = 30
        smetaMainForm.DGV_smeta.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(2).Width = 80
        smetaMainForm.DGV_smeta.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(2).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        smetaMainForm.DGV_smeta.Columns(3).Width = 490
        smetaMainForm.DGV_smeta.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(242, 245, 245)
        smetaMainForm.DGV_smeta.Columns(3).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        smetaMainForm.DGV_smeta.Columns(4).Width = 50
        smetaMainForm.DGV_smeta.Columns(4).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        smetaMainForm.DGV_smeta.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(5).Visible = False
        smetaMainForm.DGV_smeta.Columns(6).Visible = False
        smetaMainForm.DGV_smeta.Columns(7).Visible = False
        smetaMainForm.DGV_smeta.Columns(8).Visible = False
        smetaMainForm.DGV_smeta.Columns(9).Visible = False
        smetaMainForm.DGV_smeta.Columns(10).Width = 60
        smetaMainForm.DGV_smeta.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(10).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        smetaMainForm.DGV_smeta.Columns(11).Width = 68
        smetaMainForm.DGV_smeta.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(11).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        smetaMainForm.DGV_smeta.Columns(12).Width = 60
        smetaMainForm.DGV_smeta.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        smetaMainForm.DGV_smeta.Columns(12).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)

    End Sub

    Function odd_even(_value)
        Dim result As Boolean

        If _value Mod 2 = 0 Then
            result = False
        Else
            result = True
        End If
        Return result
    End Function

    Sub DGV_smeta_clickCell(_sender As Object, _e As DataGridViewCellEventArgs)
        Dim index As Integer
        index = _e.RowIndex
        Console.WriteLine(index)
        Dim selectedRow As DataGridViewRow
        selectedRow = _sender.Rows(index)
        selectedRow.DefaultCellStyle.BackColor = Color.Yellow
        smetaMainForm.DGV_smeta.Rows(index).Selected = True
    End Sub
End Module
