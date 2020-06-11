Imports OfficeOpenXml
Imports OfficeOpenXml.Table
Imports System.IO
Imports System.Text.RegularExpressions

Module load_and_close
    '===================================================================================
    '             === check expiration date ===
    '===================================================================================
    Sub checkExpirationDate()

        Dim currentDate As Date = Date.Now
        Dim lastRunDate As Date = My.Settings.lastRun
        Dim daysStayed As Int32 = My.Settings.expireDate.Subtract(currentDate).Days

        mainForm.menuItem_department.Enabled = False
        mainForm.menuItem_company.Enabled = False

        If lastRunDate.Subtract(currentDate).Days > 0 Then
            MsgBox("Check date and time settings!")
            mainForm.Close()
        Else
            My.Settings.lastRun = currentDate
            My.Settings.Save()
        End If

        If daysStayed > 0 Then
            Return
        Else
            MsgBox("This app has expired!")
            mainForm.Close()
        End If
    End Sub
    '===================================================================================
    '             === create backup ===
    '===================================================================================
    Sub createBackup(_folderName As String)

        Dim backUpFile, foundFile As String

        Select Case mainForm.cancelFlag
            Case False
                '   create backup database in BackUp folder
                mainForm.filePath = New Collection
                mainForm.fileNames = New Collection
                Try
                    For Each foundFile In My.Computer.FileSystem.GetFiles _
            (mainForm.sDir, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.omdb")
                        'Console.WriteLine(foundFile)
                        mainForm.filePath.Add(foundFile)
                        Console.WriteLine(foundFile)
                        Dim dIndex = StrReverse(foundFile).IndexOf("\")

                        Dim name As String
                        name = Right(foundFile, dIndex)

                        name = Left(name, Len(name) - 5)
                        mainForm.fileNames.Add(name)
                        Console.WriteLine(name)
                        backUpFile = Directory.GetCurrentDirectory() & "\BackUp\" & _folderName & "\" & name & ".ombckp"
                        My.Computer.FileSystem.CopyFile(foundFile, backUpFile)
                    Next

                    MsgBox("Создаем резервную копию базы данных в папке BackUp", vbOKOnly + vbInformation)

                Catch
                End Try
        End Select
    End Sub

    '===================================================================================
    '             === My Functions ===
    '===================================================================================

    Function timeStampFolder()

        Dim folderName, backUpFolder As String

        Dim format As String = ("yyy MM dd HH':'mm':'ss")
        Dim myDate As DateTime = DateTime.Now

        folderName = myDate.ToString(format)

        folderName = Regex.Replace(folderName, "\D", "")            ' timestamp name
        backUpFolder = Directory.GetCurrentDirectory() & "\BackUp"
        '   Create folder with timestamp name inside backUp folder
        My.Computer.FileSystem.CreateDirectory(backUpFolder & "\" & folderName)

        ' Show the FolderBrowserDialog.
        mainForm.FBD.SelectedPath = Directory.GetCurrentDirectory()
        Dim result As DialogResult = mainForm.FBD.ShowDialog()
        If (result = DialogResult.OK) Then
            mainForm.sDir = mainForm.FBD.SelectedPath
        End If

        Return (folderName)

    End Function
End Module
