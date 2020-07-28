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
        c_xlTable = 3
        rng_Collection = New Collection

        For i As Integer = 0 To mainForm.i_pivot_wsDict(0).Count - 1

            ws = mainForm.i_pivot_wsDict(0)(i)
            xlTable = ws.Tables(0)

            adr = xlTable.Address.Address
            r_xlTable = xlTable.Address.Rows
            rng = ws.Cells(adr)

            xlTable_Collection.Add(xlTable)
            adr_Collection.Add(adr)
            r_xlTable_Collection.Add(r_xlTable)
            rng_Collection.Add(rng)

        Next i

        'Adding the Columns

        For i = 0 To c_xlTable - 1
            dt.Columns.Add(rng_Collection(1).Value(0, i))
        Next i


        dt.Columns(0).DataType = System.Type.GetType("System.Int32")               ' #
        dt.Columns(1).DataType = System.Type.GetType("System.String")              ' Fixture
        dt.Columns(2).DataType = System.Type.GetType("System.Int32")               ' Qty

        'Add Rows from Excel table

        For i As Integer = 0 To mainForm.i_pivot_wsDict(0).Count - 2

            row = dt.Rows.Add()

            For j = 0 To c_xlTable - 1

                row.Item(j) = rng_Collection(i + 1).Value(i + 1, j)

            Next j

        Next i


        Return (dt)
    End Function
End Module
