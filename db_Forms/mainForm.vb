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

    '   Allow to get any excel table by number of iDepartment, iCategory, iCompany
    '   for Console.WriteLine(example i_superPivotDict(0)(0)(0).name) - movHeads_tbl
    Public i_superPivotDict As Dictionary(Of Integer, Dictionary(Of Integer, Dictionary(Of Integer, ExcelTable)))

    Public iDepartment, iCategory, iCompany As Integer

    Public dts As DataSet
    Public selIndex As Integer      ' Selercted index

    Public sCompany() As String = {"belimlight", "PRLighting", "blackout", "vision", "stage"}

    Public delta As Integer     ' to increase or decrease table when push Add or Delete 

    Public exportDir As String

    Public cancelFlag As Boolean = False
    Public sumFormFlag As Boolean = False
    Public editFormFlag As Boolean = False

    '===================================================================================
    '             === mainForm_Load ===
    '===================================================================================
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        checkExpirationDate()
    End Sub
    '===================================================================================
    '             === File => Open => Load from backup ===
    '===================================================================================
    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click
        loadFromBackup()
    End Sub
    '===================================================================================
    '             === File => Open => Load database ===
    '===================================================================================
    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem.Click

        createBackup(timeStampFolder())
        load_db()

        iDepartment = 0
        iCategory = 0
        iCompany = 1

        menuItem_department.Enabled = True
        menuItem_company.Enabled = True

        cancelFlag = False

    End Sub
    '===================================================================================
    '             === Export to Excel ===
    '===================================================================================
    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        exportExcel.Show()
    End Sub

#Region "select Lighting"
    Private Sub item_movHeads_Click(sender As Object, e As EventArgs) Handles item_movHeads.Click

        iDepartment = 0
        iCategory = 0
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_strobes_Click(sender As Object, e As EventArgs) Handles item_strobes.Click

        iDepartment = 0
        iCategory = 1
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_blinders_Click(sender As Object, e As EventArgs) Handles item_blinders.Click

        iDepartment = 0
        iCategory = 2
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_arch_Click(sender As Object, e As EventArgs) Handles item_arch.Click

        iDepartment = 0
        iCategory = 3
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_LED_Click(sender As Object, e As EventArgs) Handles item_LED.Click

        iDepartment = 0
        iCategory = 4
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_smoke_Click(sender As Object, e As EventArgs) Handles item_smoke.Click

        iDepartment = 0
        iCategory = 5
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_consoles_Click(sender As Object, e As EventArgs) Handles item_consoles.Click

        iDepartment = 0
        iCategory = 6
        writeToLabel("Lighting", sender)

    End Sub

    Private Sub item_intercom_Click(sender As Object, e As EventArgs) Handles item_intercom.Click

        iDepartment = 0
        iCategory = 7
        writeToLabel("Lighting", sender)

    End Sub
#End Region

#Region "select Screen"
    Private Sub item_modules_Click(sender As Object, e As EventArgs) Handles item_modules.Click
        iDepartment = 1
        iCategory = 0
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_servers_Click(sender As Object, e As EventArgs) Handles item_servers.Click
        iDepartment = 1
        iCategory = 1
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_controllers1_Click(sender As Object, e As EventArgs) Handles item_controllers1.Click
        iDepartment = 1
        iCategory = 2
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_controllers2_Click(sender As Object, e As EventArgs) Handles item_controllers2.Click
        iDepartment = 1
        iCategory = 3
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_projectors_Click(sender As Object, e As EventArgs) Handles item_projectors.Click
        iDepartment = 1
        iCategory = 4
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_scr_construction_Click(sender As Object, e As EventArgs) Handles item_scr_construction.Click
        iDepartment = 1
        iCategory = 5
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_lightDesks_Click(sender As Object, e As EventArgs) Handles item_lightDesks.Click
        iDepartment = 1
        iCategory = 6
        writeToLabel("Screen", sender)
    End Sub

    Private Sub item_cameras_Click(sender As Object, e As EventArgs) Handles item_cameras.Click
        iDepartment = 1
        iCategory = 7
        writeToLabel("Screen", sender)
    End Sub
#End Region

#Region "Select Commutation"
    Private Sub item_pwrdistr_Click(sender As Object, e As EventArgs) Handles item_pwrdistr.Click
        iDepartment = 2
        iCategory = 0
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_comm_Click(sender As Object, e As EventArgs) Handles item_comm.Click
        iDepartment = 2
        iCategory = 1
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_pwrcomm_Click(sender As Object, e As EventArgs) Handles item_pwrcomm.Click
        iDepartment = 2
        iCategory = 2
        writeToLabel("Commutation", sender)
    End Sub

    Private Sub item_rest_Click(sender As Object, e As EventArgs) Handles item_rest.Click
        iDepartment = 2
        iCategory = 3
        writeToLabel("Commutation", sender)
    End Sub
#End Region

#Region "Select Truss and motors"
    Private Sub item_truss30x30_Click(sender As Object, e As EventArgs) Handles item_truss30x30.Click
        iDepartment = 3
        iCategory = 0
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_truss40x40_Click(sender As Object, e As EventArgs) Handles item_truss40x40.Click
        iDepartment = 3
        iCategory = 1
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_truss50x60_Click(sender As Object, e As EventArgs) Handles item_truss50x60.Click
        iDepartment = 3
        iCategory = 2
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_motors_Click(sender As Object, e As EventArgs) Handles item_motors.Click
        iDepartment = 3
        iCategory = 3
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_rigging_Click(sender As Object, e As EventArgs) Handles item_rigging.Click
        iDepartment = 3
        iCategory = 4
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_diff_Click(sender As Object, e As EventArgs) Handles item_diff.Click
        iDepartment = 3
        iCategory = 5
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_completeConstr_Click(sender As Object, e As EventArgs) Handles item_completeConstr.Click
        iDepartment = 3
        iCategory = 6
        writeToLabel("Trusses and motors", sender)
    End Sub

    Private Sub item_stagelifts_Click(sender As Object, e As EventArgs) Handles item_stagelifts.Click
        iDepartment = 3
        iCategory = 7
        writeToLabel("Trusses and motors", sender)
    End Sub
#End Region

#Region "Select Construction"
    Private Sub item_stageModules_Click(sender As Object, e As EventArgs) Handles item_stageModules.Click
        iDepartment = 4
        iCategory = 0
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_J001_Click(sender As Object, e As EventArgs) Handles item_scaffold_J001.Click
        iDepartment = 4
        iCategory = 1
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_J004_Click(sender As Object, e As EventArgs) Handles item_scaffold_J004.Click
        iDepartment = 4
        iCategory = 2
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_scaffold_steps_Click(sender As Object, e As EventArgs) Handles item_scaffold_steps.Click
        iDepartment = 4
        iCategory = 3
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_barricades_Click(sender As Object, e As EventArgs) Handles item_barricades.Click
        iDepartment = 4
        iCategory = 4
        writeToLabel("Construction", sender)
    End Sub

    Private Sub item_details_Click(sender As Object, e As EventArgs) Handles item_details.Click
        iDepartment = 4
        iCategory = 5
        writeToLabel("Construction", sender)
    End Sub
#End Region

#Region "Select Sound"
    Private Sub item_speakers_Click(sender As Object, e As EventArgs) Handles item_speakers.Click
        iDepartment = 5
        iCategory = 0
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_ampracks_Click(sender As Object, e As EventArgs) Handles item_ampracks.Click
        iDepartment = 5
        iCategory = 1
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_monitors_Click(sender As Object, e As EventArgs) Handles item_monitors.Click
        iDepartment = 5
        iCategory = 2
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_mixdesks_Click(sender As Object, e As EventArgs) Handles item_mixdesks.Click
        iDepartment = 5
        iCategory = 3
        writeToLabel("Sound", sender)
    End Sub

    Private Sub item_dj_stage_Click(sender As Object, e As EventArgs) Handles item_dj_stage.Click
        iDepartment = 5
        iCategory = 4
        writeToLabel("Sound", sender)
    End Sub

#End Region

#Region "select Company"
    Private Sub item_belimlight_Click(sender As Object, e As EventArgs) Handles item_belimlight.Click
        iCompany = 1
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_PRLighting_Click(sender As Object, e As EventArgs) Handles item_PRLighting.Click
        iCompany = 2
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_blackout_Click(sender As Object, e As EventArgs) Handles item_blackout.Click
        iCompany = 3
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_vision_Click(sender As Object, e As EventArgs) Handles item_vision.Click
        iCompany = 4
        writeToLabelCompany(sender)
        companyFunction()
    End Sub

    Private Sub item_stage_Click(sender As Object, e As EventArgs) Handles item_stage.Click
        iCompany = 5
        writeToLabelCompany(sender)
        companyFunction()
    End Sub
    Private Sub item_summary_Click(sender As Object, e As EventArgs) Handles item_summary.Click

        sumForm.Show()
        sumFormFlag = True
        sumForm.dgv_sum.DataSource = dts.Tables(0)
        sumForm.dgv_sum.Columns(8).Visible = False
        sumForm.dgv_sum.Columns(9).Visible = False
        sumForm.dgv_sum.Columns(10).Visible = False
        format_sumDGV()

    End Sub

#End Region

    '===================================================================================      
    '                === Up,Down,Select DGV row ===
    '===================================================================================

#Region "select DGV row"
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        dgv_clickCell(sender, e)
        calcQuantity()
    End Sub
    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        prevRecord()
        calcQuantity()
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        nextRecord()
        calcQuantity()
    End Sub
#End Region

#Region "CRUD buttons"
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        delta = 1
        editForm.Show()
        editForm.btn_add_addform.Visible = True
        editForm.btn_update_addform.Visible = False
        blockButtons()
        btn_save.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        delta = 0
        editForm.Show()
        editFormFlag = True
        editForm.btn_add_addform.Visible = False
        editForm.btn_update_addform.Visible = True
        showData(selIndex)
        btn_save.Enabled = True
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        deleteRow()
        delta = -1
        blockButtons()
        btn_save.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        saveButton(delta)
        load_db()
        unBlockButtons()
        btn_save.Enabled = False

    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        companyFunction()
        calcQuantity()
        If editFormFlag Then
            showData(0)
        End If
        Dim c As Color
        Select Case iCompany
            Case 1
                c = Color.FromArgb(252, 228, 214)
            Case 2
                c = Color.FromArgb(221, 235, 247)
            Case 3
                c = Color.FromArgb(237, 237, 237)
            Case 4
                c = Color.FromArgb(226, 239, 218)
            Case 5
                c = Color.FromArgb(237, 226, 246)
        End Select
        dgv.DataSource = dts.Tables(iCompany)

        sumForm.dgv_sum.DataSource = dts.Tables(0)
        format_sumDGV()
        unBlockButtons()
        btn_save.Enabled = False
    End Sub

#End Region

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    '===================================================================================      
    '                === Test button ===
    '===================================================================================
    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        Console.WriteLine(My.Settings.lastRun)
        'Console.WriteLine(My.Settings.testString)
        'My.Settings.testString = "Good bye!"
        'My.Settings.Save()

        'Console.WriteLine(i_pivot_wsDict.Count)
        'Console.WriteLine(i_superPivotDict.Count)
        'Console.WriteLine(i_pivotTableDict.Count)

        'Console.WriteLine(i_superPivotDict(0)(2)(2).Name)

        'extractFiles()

    End Sub
    '=================================================================================== 
    '===================================================================================      
    '                === SMETA SECTION ===
    '===================================================================================
    '=================================================================================== 

    Private Sub CreateSmetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateSmetaToolStripMenuItem.Click
        smetaMainForm.Show()
    End Sub
End Class
