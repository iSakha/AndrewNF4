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
        c_xlTable = 21
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


        dt.Columns(13).DataType = System.Type.GetType("System.Int32")               ' R1 
        dt.Columns(14).DataType = System.Type.GetType("System.Int32")               ' R2
        dt.Columns(15).DataType = System.Type.GetType("System.Int32")               ' R3
        dt.Columns(16).DataType = System.Type.GetType("System.Int32")               ' R4
        dt.Columns(17).DataType = System.Type.GetType("System.Int32")               ' R5 
        dt.Columns(18).DataType = System.Type.GetType("System.Int32")               ' R6
        dt.Columns(19).DataType = System.Type.GetType("System.Int32")               ' R7
        dt.Columns(20).DataType = System.Type.GetType("System.Int32")               ' R8




        dt.Columns(0).ColumnName = "Dep"
        dt.Columns(1).ColumnName = "Cat"
        dt.Columns(2).ColumnName = "ID"
        dt.Columns(3).ColumnName = "Fixture"
        dt.Columns(4).ColumnName = "Qty"

        dt.Columns(10).ColumnName = "Weight"
        dt.Columns(11).ColumnName = "Power/Length"
        dt.Columns(12).ColumnName = "Price"

        dt.Columns(13).ColumnName = "R1"
        dt.Columns(14).ColumnName = "R2"
        dt.Columns(15).ColumnName = "R3"
        dt.Columns(16).ColumnName = "R4"
        dt.Columns(17).ColumnName = "R5"
        dt.Columns(18).ColumnName = "R6"
        dt.Columns(19).ColumnName = "R7"
        dt.Columns(20).ColumnName = "OrderQty"



        Console.WriteLine(rng_Collection.Count)

        'Add Rows from Excel table

        For k As Integer = 1 To rng_Collection.Count            '   Categories
            Console.WriteLine(k)
            For i = 1 To r_xlTable_Collection(k) - 1

                row = dt.Rows.Add()

                For j = 0 To c_xlTable - 1

                    row.Item(j) = rng_Collection(k).Value(i, j)

                Next j

            Next i

        Next k

        smetaMainForm.DGV_db.DataSource = dt

        Return (dt)

    End Function

    Sub setScroll(_value As Integer)
        Dim index As Integer

        For Each r As DataGridViewRow In smetaMainForm.DGV_db.Rows

            If r.Cells(2).Value = _value Then
                index = r.Index
                smetaMainForm.DGV_db.Rows(index).Selected = True
                smetaMainForm.DGV_db.FirstDisplayedScrollingRowIndex = index
                Exit Sub
            End If
        Next r
    End Sub

    Sub format_DGV_smeta(_DGV)

        _DGV.RowHeadersVisible = False

        _DGV.Columns(0).Width = 30
        _DGV.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For Each r As DataGridViewRow In _DGV.Rows
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


        _DGV.Columns(1).Width = 30
        _DGV.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(2).Width = 80
        _DGV.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(2).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(3).Width = 430
        _DGV.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(242, 245, 245)
        _DGV.Columns(3).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(4).Width = 50
        _DGV.Columns(4).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(5).Visible = False
        _DGV.Columns(6).Visible = False
        _DGV.Columns(7).Visible = False
        _DGV.Columns(8).Visible = False
        _DGV.Columns(9).Visible = False
        _DGV.Columns(10).Width = 60
        _DGV.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(10).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(11).Width = 68
        _DGV.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(11).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(12).Width = 60
        _DGV.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(12).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)
        _DGV.Columns(13).Visible = False
        _DGV.Columns(14).Visible = False
        _DGV.Columns(15).Visible = False
        _DGV.Columns(16).Visible = False
        _DGV.Columns(17).Visible = False
        _DGV.Columns(18).Visible = False
        _DGV.Columns(19).Visible = False
        _DGV.Columns(20).Width = 60
        _DGV.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        _DGV.Columns(20).DefaultCellStyle.Font = New Font("Calibri", 11, FontStyle.Bold, FontStyle.Italic)

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
        enumRows()
    End Sub

    Function enumRows()

        Dim targetRows = New List(Of DataGridViewRow)

        Dim row As DataGridViewRow
        Dim totalPwr As Integer = 0
        Dim totalPrice As Integer = 0
        Dim totalWeight As Integer = 0

        For Each row In smetaMainForm.DGV_db.Rows

            If row.Cells(20).Value > 0 Then

                row.DefaultCellStyle.BackColor = Color.Yellow
                targetRows.Add(row)

                '           Calculate total power for lighting,screen and sound
                If (row.Cells(0).Value = 1) Or (row.Cells(0).Value = 2) Or (row.Cells(0).Value = 6) Then
                    totalPwr = totalPwr + (row.Cells(11).Value) * (row.Cells(20).Value)
                End If

                '           Calculate total price
                totalPrice = totalPrice + (row.Cells(12).Value) * (row.Cells(20).Value)

                '           Calculate total weight

                totalWeight = totalWeight + (row.Cells(10).Value) * (row.Cells(20).Value)

                smetaMainForm.txt_pwr.Text = totalPwr
                smetaMainForm.txt_price.Text = totalPrice
                smetaMainForm.txt_weight.Text = totalWeight
            Else
                row.DefaultCellStyle.BackColor = SystemColors.Window
            End If

        Next row

        Return (targetRows)

    End Function

End Module
