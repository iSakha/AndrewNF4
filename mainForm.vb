Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO

Public Class mainForm


    Public sDir As String
    Public sFilePath As String
    Public sFileName As String

    Public fileNames As Collection
    Public filePath As Collection


    ' Dictionaries with Integer key
    Public i_wsDict As Dictionary(Of Integer, ExcelWorksheet)
    Public i_xlTableDict As Dictionary(Of Integer, ExcelTable)
    Public i_pivot_wsDict As Dictionary(Of Integer, Dictionary(Of Integer, ExcelWorksheet))
    Public i_pivotTableDict As Dictionary(Of Integer, Dictionary(Of Integer, ExcelTable))
    Public i_superPivotDict As Dictionary(Of Integer, Dictionary(Of Integer, Dictionary(Of Integer, ExcelTable)))

    Public iDepartment, iCategory, iCompany As Integer

    Public dts As DataSet

    Public sCompany() As String = {"belimlight", "PRLighting", "blackout", "vision", "stage"}

    Public delta As Integer     ' to increase or decrease table when push Add or Delete 

    Public exportDir As String



    Public cancelFlag As Boolean = False
    '===================================================================================
    '             === mainForm_Load ===
    '===================================================================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkExpirationDate()
    End Sub


    '===================================================================================      
    '                === Test button ===
    '===================================================================================
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        'Console.WriteLine(My.Settings.lastRun)
        'Console.WriteLine(My.Settings.testString)
        'My.Settings.testString = "Good bye!"
        'My.Settings.Save()
        createBackup(timeStampFolder())
        Console.WriteLine(sDir)

    End Sub
End Class
