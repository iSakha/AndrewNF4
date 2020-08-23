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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_weight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pwr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_sound_smeta = New System.Windows.Forms.Button()
        Me.btn_construct_smeta = New System.Windows.Forms.Button()
        Me.btn_truss_smeta = New System.Windows.Forms.Button()
        Me.btn_commut_smeta = New System.Windows.Forms.Button()
        Me.btn_screen_smeta = New System.Windows.Forms.Button()
        Me.btn_lighting_smeta = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.btn_clr_filter = New System.Windows.Forms.Button()
        Me.DGV_smeta = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_db
        '
        Me.DGV_db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_db.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_db.Location = New System.Drawing.Point(170, 6)
        Me.DGV_db.Name = "DGV_db"
        Me.DGV_db.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_db.Size = New System.Drawing.Size(888, 603)
        Me.DGV_db.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1072, 641)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_clr_filter)
        Me.TabPage1.Controls.Add(Me.btn_filter)
        Me.TabPage1.Controls.Add(Me.txt_price)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_weight)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_pwr)
        Me.TabPage1.Controls.Add(Me.Label1)
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
        'txt_price
        '
        Me.txt_price.BackColor = System.Drawing.SystemColors.Info
        Me.txt_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_price.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txt_price.Location = New System.Drawing.Point(29, 373)
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
        Me.Label3.Location = New System.Drawing.Point(25, 350)
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
        Me.txt_weight.Location = New System.Drawing.Point(27, 303)
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
        Me.Label2.Location = New System.Drawing.Point(23, 280)
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
        Me.txt_pwr.Location = New System.Drawing.Point(27, 233)
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
        Me.Label1.Location = New System.Drawing.Point(23, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total power"
        '
        'btn_sound_smeta
        '
        Me.btn_sound_smeta.BackColor = System.Drawing.Color.Thistle
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
        Me.TabPage2.Controls.Add(Me.DGV_smeta)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1064, 615)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Smeta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_filter
        '
        Me.btn_filter.Location = New System.Drawing.Point(29, 421)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(75, 23)
        Me.btn_filter.TabIndex = 8
        Me.btn_filter.Text = "Go to smeta"
        Me.btn_filter.UseVisualStyleBackColor = True
        '
        'btn_clr_filter
        '
        Me.btn_clr_filter.Location = New System.Drawing.Point(29, 450)
        Me.btn_clr_filter.Name = "btn_clr_filter"
        Me.btn_clr_filter.Size = New System.Drawing.Size(75, 23)
        Me.btn_clr_filter.TabIndex = 8
        Me.btn_clr_filter.Text = "Back to DB"
        Me.btn_clr_filter.UseVisualStyleBackColor = True
        '
        'DGV_smeta
        '
        Me.DGV_smeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_smeta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_smeta.Location = New System.Drawing.Point(170, 6)
        Me.DGV_smeta.Name = "DGV_smeta"
        Me.DGV_smeta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_smeta.Size = New System.Drawing.Size(888, 603)
        Me.DGV_smeta.TabIndex = 1
        '
        'smetaMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 736)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "smetaMainForm"
        Me.Text = "smetaMainForm"
        CType(Me.DGV_db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_db As DataGridView
    Friend WithEvents TabControl1 As TabControl
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
    Friend WithEvents btn_clr_filter As Button
    Friend WithEvents btn_filter As Button
    Friend WithEvents DGV_smeta As DataGridView
End Class
