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
        Me.DGV_smeta = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_clrSelRow_smeta = New System.Windows.Forms.Button()
        Me.btn_sound_smeta = New System.Windows.Forms.Button()
        Me.btn_construct_smeta = New System.Windows.Forms.Button()
        Me.btn_truss_smeta = New System.Windows.Forms.Button()
        Me.btn_commut_smeta = New System.Windows.Forms.Button()
        Me.btn_screen_smeta = New System.Windows.Forms.Button()
        Me.btn_lighting_smeta = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_smeta
        '
        Me.DGV_smeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_smeta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV_smeta.Location = New System.Drawing.Point(170, 6)
        Me.DGV_smeta.Name = "DGV_smeta"
        Me.DGV_smeta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_smeta.Size = New System.Drawing.Size(888, 603)
        Me.DGV_smeta.TabIndex = 0
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
        Me.TabPage1.Controls.Add(Me.btn_clrSelRow_smeta)
        Me.TabPage1.Controls.Add(Me.btn_sound_smeta)
        Me.TabPage1.Controls.Add(Me.btn_construct_smeta)
        Me.TabPage1.Controls.Add(Me.btn_truss_smeta)
        Me.TabPage1.Controls.Add(Me.btn_commut_smeta)
        Me.TabPage1.Controls.Add(Me.btn_screen_smeta)
        Me.TabPage1.Controls.Add(Me.btn_lighting_smeta)
        Me.TabPage1.Controls.Add(Me.DGV_smeta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1064, 615)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_clrSelRow_smeta
        '
        Me.btn_clrSelRow_smeta.Location = New System.Drawing.Point(19, 261)
        Me.btn_clrSelRow_smeta.Name = "btn_clrSelRow_smeta"
        Me.btn_clrSelRow_smeta.Size = New System.Drawing.Size(145, 23)
        Me.btn_clrSelRow_smeta.TabIndex = 2
        Me.btn_clrSelRow_smeta.Text = "Clear selected row"
        Me.btn_clrSelRow_smeta.UseVisualStyleBackColor = True
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1064, 615)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Smeta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'smetaMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 736)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "smetaMainForm"
        Me.Text = "smetaMainForm"
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_smeta As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_sound_smeta As Button
    Friend WithEvents btn_construct_smeta As Button
    Friend WithEvents btn_truss_smeta As Button
    Friend WithEvents btn_commut_smeta As Button
    Friend WithEvents btn_screen_smeta As Button
    Friend WithEvents btn_lighting_smeta As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_clrSelRow_smeta As Button
End Class
