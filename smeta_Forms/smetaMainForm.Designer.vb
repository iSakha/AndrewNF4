<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class smetaMainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_db = New System.Windows.Forms.DataGridView()
        Me.tbCtrl_smeta = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_depart_value = New System.Windows.Forms.Label()
        Me.lbl_cat_value = New System.Windows.Forms.Label()
        Me.lbl_cat_smeta = New System.Windows.Forms.Label()
        Me.lbl_depart_smeta = New System.Windows.Forms.Label()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_sound_smeta = New System.Windows.Forms.Button()
        Me.btn_construct_smeta = New System.Windows.Forms.Button()
        Me.btn_truss_smeta = New System.Windows.Forms.Button()
        Me.btn_commut_smeta = New System.Windows.Forms.Button()
        Me.btn_screen_smeta = New System.Windows.Forms.Button()
        Me.btn_lighting_smeta = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_eventCity = New System.Windows.Forms.ComboBox()
        Me.txt_daysQty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTP_end = New System.Windows.Forms.DateTimePicker()
        Me.DTP_start = New System.Windows.Forms.DateTimePicker()
        Me.btn_clr_filter = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGV_smeta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_eventLocation = New System.Windows.Forms.ComboBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pwr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_event = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbCtrl_smeta.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_db
        '
        Me.DGV_db.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_db.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_db.Location = New System.Drawing.Point(170, 6)
        Me.DGV_db.Name = "DGV_db"
        Me.DGV_db.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_db.Size = New System.Drawing.Size(888, 603)
        Me.DGV_db.TabIndex = 0
        '
        'tbCtrl_smeta
        '
        Me.tbCtrl_smeta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCtrl_smeta.Controls.Add(Me.TabPage1)
        Me.tbCtrl_smeta.Controls.Add(Me.TabPage2)
        Me.tbCtrl_smeta.Location = New System.Drawing.Point(0, 0)
        Me.tbCtrl_smeta.Name = "tbCtrl_smeta"
        Me.tbCtrl_smeta.SelectedIndex = 0
        Me.tbCtrl_smeta.Size = New System.Drawing.Size(1072, 641)
        Me.tbCtrl_smeta.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lbl_depart_value)
        Me.TabPage1.Controls.Add(Me.lbl_cat_value)
        Me.TabPage1.Controls.Add(Me.lbl_cat_smeta)
        Me.TabPage1.Controls.Add(Me.lbl_depart_smeta)
        Me.TabPage1.Controls.Add(Me.btn_filter)
        Me.TabPage1.Controls.Add(Me.btn_sound_smeta)
        Me.TabPage1.Controls.Add(Me.btn_construct_smeta)
        Me.TabPage1.Controls.Add(Me.btn_truss_smeta)
        Me.TabPage1.Controls.Add(Me.btn_commut_smeta)
        Me.TabPage1.Controls.Add(Me.btn_screen_smeta)
        Me.TabPage1.Controls.Add(Me.btn_lighting_smeta)
        Me.TabPage1.Controls.Add(Me.DGV_db)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1064, 615)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lbl_depart_value
        '
        Me.lbl_depart_value.AutoSize = True
        Me.lbl_depart_value.BackColor = System.Drawing.Color.OldLace
        Me.lbl_depart_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_depart_value.ForeColor = System.Drawing.Color.Black
        Me.lbl_depart_value.Location = New System.Drawing.Point(10, 245)
        Me.lbl_depart_value.Name = "lbl_depart_value"
        Me.lbl_depart_value.Size = New System.Drawing.Size(66, 20)
        Me.lbl_depart_value.TabIndex = 9
        Me.lbl_depart_value.Text = "Label10"
        '
        'lbl_cat_value
        '
        Me.lbl_cat_value.AutoSize = True
        Me.lbl_cat_value.BackColor = System.Drawing.Color.OldLace
        Me.lbl_cat_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_cat_value.ForeColor = System.Drawing.Color.Black
        Me.lbl_cat_value.Location = New System.Drawing.Point(10, 305)
        Me.lbl_cat_value.Name = "lbl_cat_value"
        Me.lbl_cat_value.Size = New System.Drawing.Size(66, 20)
        Me.lbl_cat_value.TabIndex = 9
        Me.lbl_cat_value.Text = "Label10"
        '
        'lbl_cat_smeta
        '
        Me.lbl_cat_smeta.AutoSize = True
        Me.lbl_cat_smeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_cat_smeta.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_cat_smeta.Location = New System.Drawing.Point(10, 283)
        Me.lbl_cat_smeta.Name = "lbl_cat_smeta"
        Me.lbl_cat_smeta.Size = New System.Drawing.Size(71, 16)
        Me.lbl_cat_smeta.TabIndex = 9
        Me.lbl_cat_smeta.Text = "Category"
        '
        'lbl_depart_smeta
        '
        Me.lbl_depart_smeta.AutoSize = True
        Me.lbl_depart_smeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_depart_smeta.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lbl_depart_smeta.Location = New System.Drawing.Point(10, 223)
        Me.lbl_depart_smeta.Name = "lbl_depart_smeta"
        Me.lbl_depart_smeta.Size = New System.Drawing.Size(88, 16)
        Me.lbl_depart_smeta.TabIndex = 9
        Me.lbl_depart_smeta.Text = "Department"
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(8, 579)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(156, 30)
        Me.btn_filter.TabIndex = 8
        Me.btn_filter.Text = "Go to smeta"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_sound_smeta
        '
        Me.btn_sound_smeta.BackColor = System.Drawing.Color.Thistle
        Me.btn_sound_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_sound_smeta.FlatAppearance.BorderSize = 2
        Me.btn_sound_smeta.Location = New System.Drawing.Point(19, 151)
        Me.btn_sound_smeta.Name = "btn_sound_smeta"
        Me.btn_sound_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_sound_smeta.TabIndex = 1
        Me.btn_sound_smeta.Text = "06 Sound"
        Me.btn_sound_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sound_smeta.UseVisualStyleBackColor = False
        '
        'btn_construct_smeta
        '
        Me.btn_construct_smeta.BackColor = System.Drawing.Color.LightCyan
        Me.btn_construct_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_construct_smeta.FlatAppearance.BorderSize = 2
        Me.btn_construct_smeta.Location = New System.Drawing.Point(19, 122)
        Me.btn_construct_smeta.Name = "btn_construct_smeta"
        Me.btn_construct_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_construct_smeta.TabIndex = 1
        Me.btn_construct_smeta.Text = "05 Construction"
        Me.btn_construct_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_construct_smeta.UseVisualStyleBackColor = False
        '
        'btn_truss_smeta
        '
        Me.btn_truss_smeta.BackColor = System.Drawing.Color.Honeydew
        Me.btn_truss_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_truss_smeta.FlatAppearance.BorderSize = 2
        Me.btn_truss_smeta.Location = New System.Drawing.Point(19, 93)
        Me.btn_truss_smeta.Name = "btn_truss_smeta"
        Me.btn_truss_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_truss_smeta.TabIndex = 1
        Me.btn_truss_smeta.Text = "04 Truss and motors"
        Me.btn_truss_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_truss_smeta.UseVisualStyleBackColor = False
        '
        'btn_commut_smeta
        '
        Me.btn_commut_smeta.BackColor = System.Drawing.Color.MistyRose
        Me.btn_commut_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_commut_smeta.FlatAppearance.BorderSize = 2
        Me.btn_commut_smeta.Location = New System.Drawing.Point(19, 64)
        Me.btn_commut_smeta.Name = "btn_commut_smeta"
        Me.btn_commut_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_commut_smeta.TabIndex = 1
        Me.btn_commut_smeta.Text = "03 Commutation"
        Me.btn_commut_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_commut_smeta.UseVisualStyleBackColor = False
        '
        'btn_screen_smeta
        '
        Me.btn_screen_smeta.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_screen_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_screen_smeta.FlatAppearance.BorderSize = 2
        Me.btn_screen_smeta.Location = New System.Drawing.Point(19, 35)
        Me.btn_screen_smeta.Name = "btn_screen_smeta"
        Me.btn_screen_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_screen_smeta.TabIndex = 1
        Me.btn_screen_smeta.Text = "02 Screen"
        Me.btn_screen_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_screen_smeta.UseVisualStyleBackColor = False
        '
        'btn_lighting_smeta
        '
        Me.btn_lighting_smeta.BackColor = System.Drawing.Color.LemonChiffon
        Me.btn_lighting_smeta.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_lighting_smeta.FlatAppearance.BorderSize = 2
        Me.btn_lighting_smeta.Location = New System.Drawing.Point(19, 6)
        Me.btn_lighting_smeta.Name = "btn_lighting_smeta"
        Me.btn_lighting_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_lighting_smeta.TabIndex = 1
        Me.btn_lighting_smeta.Text = "01 Lighting"
        Me.btn_lighting_smeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_lighting_smeta.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.cmb_eventCity)
        Me.TabPage2.Controls.Add(Me.txt_daysQty)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.DTP_end)
        Me.TabPage2.Controls.Add(Me.DTP_start)
        Me.TabPage2.Controls.Add(Me.btn_clr_filter)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DGV_smeta)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cmb_eventLocation)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1064, 615)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Smeta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label9.Location = New System.Drawing.Point(-1, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Город"
        '
        'cmb_eventCity
        '
        Me.cmb_eventCity.FormattingEnabled = True
        Me.cmb_eventCity.Location = New System.Drawing.Point(3, 35)
        Me.cmb_eventCity.Name = "cmb_eventCity"
        Me.cmb_eventCity.Size = New System.Drawing.Size(165, 21)
        Me.cmb_eventCity.TabIndex = 15
        '
        'txt_daysQty
        '
        Me.txt_daysQty.Location = New System.Drawing.Point(8, 236)
        Me.txt_daysQty.Name = "txt_daysQty"
        Me.txt_daysQty.Size = New System.Drawing.Size(44, 20)
        Me.txt_daysQty.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label8.Location = New System.Drawing.Point(-1, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Количество дней"
        '
        'DTP_end
        '
        Me.DTP_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_end.Location = New System.Drawing.Point(3, 179)
        Me.DTP_end.Name = "DTP_end"
        Me.DTP_end.Size = New System.Drawing.Size(159, 20)
        Me.DTP_end.TabIndex = 11
        Me.DTP_end.Visible = False
        '
        'DTP_start
        '
        Me.DTP_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_start.Location = New System.Drawing.Point(3, 127)
        Me.DTP_start.Name = "DTP_start"
        Me.DTP_start.Size = New System.Drawing.Size(159, 20)
        Me.DTP_start.TabIndex = 10
        '
        'btn_clr_filter
        '
        Me.btn_clr_filter.Location = New System.Drawing.Point(8, 579)
        Me.btn_clr_filter.Name = "btn_clr_filter"
        Me.btn_clr_filter.Size = New System.Drawing.Size(156, 30)
        Me.btn_clr_filter.TabIndex = 9
        Me.btn_clr_filter.Text = "Back to DB"
        Me.btn_clr_filter.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(-1, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Дата окончания"
        '
        'DGV_smeta
        '
        Me.DGV_smeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_smeta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column21, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        Me.DGV_smeta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_smeta.Location = New System.Drawing.Point(170, 6)
        Me.DGV_smeta.Name = "DGV_smeta"
        Me.DGV_smeta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_smeta.Size = New System.Drawing.Size(888, 603)
        Me.DGV_smeta.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Dep"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cat"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Fixture"
        Me.Column4.Name = "Column4"
        '
        'Column21
        '
        Me.Column21.HeaderText = "Qty"
        Me.Column21.Name = "Column21"
        '
        'Column5
        '
        Me.Column5.HeaderText = "BelImlight"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "PRLightigTouring"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "BlackOut"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "Vision"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'Column9
        '
        Me.Column9.HeaderText = "Stage"
        Me.Column9.Name = "Column9"
        Me.Column9.Visible = False
        '
        'Column10
        '
        Me.Column10.HeaderText = "Weight"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "Power/Length"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Price"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Result"
        Me.Column13.Name = "Column13"
        Me.Column13.Visible = False
        '
        'Column14
        '
        Me.Column14.HeaderText = "R2"
        Me.Column14.Name = "Column14"
        Me.Column14.Visible = False
        '
        'Column15
        '
        Me.Column15.HeaderText = "R3"
        Me.Column15.Name = "Column15"
        Me.Column15.Visible = False
        '
        'Column16
        '
        Me.Column16.HeaderText = "R4"
        Me.Column16.Name = "Column16"
        Me.Column16.Visible = False
        '
        'Column17
        '
        Me.Column17.HeaderText = "R5"
        Me.Column17.Name = "Column17"
        Me.Column17.Visible = False
        '
        'Column18
        '
        Me.Column18.HeaderText = "R6"
        Me.Column18.Name = "Column18"
        Me.Column18.Visible = False
        '
        'Column19
        '
        Me.Column19.HeaderText = "R7"
        Me.Column19.Name = "Column19"
        Me.Column19.Visible = False
        '
        'Column20
        '
        Me.Column20.HeaderText = "OrderQty"
        Me.Column20.Name = "Column20"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(-1, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Площадка"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(-1, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Дата начала"
        '
        'cmb_eventLocation
        '
        Me.cmb_eventLocation.FormattingEnabled = True
        Me.cmb_eventLocation.Location = New System.Drawing.Point(3, 80)
        Me.cmb_eventLocation.Name = "cmb_eventLocation"
        Me.cmb_eventLocation.Size = New System.Drawing.Size(165, 21)
        Me.cmb_eventLocation.TabIndex = 8
        '
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Info
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_price.Location = New System.Drawing.Point(533, 667)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(100, 29)
        Me.txt_price.TabIndex = 7
        Me.txt_price.Text = "123"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(529, 644)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total price"
        '
        'txt_weight
        '
        Me.txt_weight.BackColor = System.Drawing.SystemColors.Info
        Me.txt_weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_weight.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_weight.Location = New System.Drawing.Point(415, 667)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Size = New System.Drawing.Size(100, 29)
        Me.txt_weight.TabIndex = 5
        Me.txt_weight.Text = "123"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(411, 644)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total weight"
        '
        'txt_pwr
        '
        Me.txt_pwr.BackColor = System.Drawing.SystemColors.Info
        Me.txt_pwr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_pwr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_pwr.Location = New System.Drawing.Point(297, 667)
        Me.txt_pwr.Name = "txt_pwr"
        Me.txt_pwr.Size = New System.Drawing.Size(100, 29)
        Me.txt_pwr.TabIndex = 3
        Me.txt_pwr.Text = "123"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(293, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total power"
        '
        'txt_event
        '
        Me.txt_event.Location = New System.Drawing.Point(16, 667)
        Me.txt_event.Name = "txt_event"
        Me.txt_event.Size = New System.Drawing.Size(265, 20)
        Me.txt_event.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(12, 644)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Мероприятие"
        '
        'smetaMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 736)
        Me.Controls.Add(Me.txt_event)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbCtrl_smeta)
        Me.Controls.Add(Me.txt_weight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pwr)
        Me.Controls.Add(Me.Label1)
        Me.Name = "smetaMainForm"
        Me.Text = "smetaMainForm"
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbCtrl_smeta.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_db As DataGridView
    Friend WithEvents tbCtrl_smeta As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_sound_smeta As Button
    Friend WithEvents btn_construct_smeta As Button
    Friend WithEvents btn_truss_smeta As Button
    Friend WithEvents btn_commut_smeta As Button
    Friend WithEvents btn_screen_smeta As Button
    Friend WithEvents btn_lighting_smeta As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_pwr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_filter As Button
    Friend WithEvents DGV_smeta As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column21 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents btn_clr_filter As Button
    Friend WithEvents txt_event As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_eventLocation As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DTP_end As DateTimePicker
    Friend WithEvents DTP_start As DateTimePicker
    Friend WithEvents txt_daysQty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_eventCity As ComboBox
    Friend WithEvents lbl_depart_value As Label
    Friend WithEvents lbl_cat_value As Label
    Friend WithEvents lbl_cat_smeta As Label
    Friend WithEvents lbl_depart_smeta As Label
End Class
