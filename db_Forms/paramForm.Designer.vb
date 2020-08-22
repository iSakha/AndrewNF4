<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paramForm
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_subsectionValue = New System.Windows.Forms.Label()
        Me.lbl_subsection = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_dpartmentValue = New System.Windows.Forms.Label()
        Me.lbl_department = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgv.Location = New System.Drawing.Point(-43, 52)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(1056, 625)
        Me.dgv.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1068, 46)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.lbl_subsectionValue)
        Me.GroupBox2.Controls.Add(Me.lbl_subsection)
        Me.GroupBox2.Location = New System.Drawing.Point(391, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 33)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'lbl_subsectionValue
        '
        Me.lbl_subsectionValue.AutoSize = True
        Me.lbl_subsectionValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_subsectionValue.Location = New System.Drawing.Point(73, 12)
        Me.lbl_subsectionValue.Name = "lbl_subsectionValue"
        Me.lbl_subsectionValue.Size = New System.Drawing.Size(108, 16)
        Me.lbl_subsectionValue.TabIndex = 0
        Me.lbl_subsectionValue.Text = "Moving Heads"
        '
        'lbl_subsection
        '
        Me.lbl_subsection.AutoSize = True
        Me.lbl_subsection.Location = New System.Drawing.Point(5, 12)
        Me.lbl_subsection.Name = "lbl_subsection"
        Me.lbl_subsection.Size = New System.Drawing.Size(63, 13)
        Me.lbl_subsection.TabIndex = 0
        Me.lbl_subsection.Text = "Subsection:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lbl_dpartmentValue)
        Me.GroupBox1.Controls.Add(Me.lbl_department)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 33)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lbl_dpartmentValue
        '
        Me.lbl_dpartmentValue.AutoSize = True
        Me.lbl_dpartmentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lbl_dpartmentValue.Location = New System.Drawing.Point(81, 12)
        Me.lbl_dpartmentValue.Name = "lbl_dpartmentValue"
        Me.lbl_dpartmentValue.Size = New System.Drawing.Size(62, 16)
        Me.lbl_dpartmentValue.TabIndex = 0
        Me.lbl_dpartmentValue.Text = "Lighting"
        '
        'lbl_department
        '
        Me.lbl_department.AutoSize = True
        Me.lbl_department.Location = New System.Drawing.Point(13, 12)
        Me.lbl_department.Name = "lbl_department"
        Me.lbl_department.Size = New System.Drawing.Size(65, 13)
        Me.lbl_department.TabIndex = 0
        Me.lbl_department.Text = "Department:"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(434, 701)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 6
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(560, 701)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'paramForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 736)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv)
        Me.Name = "paramForm"
        Me.Text = "paramForm"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_subsectionValue As Label
    Friend WithEvents lbl_subsection As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_dpartmentValue As Label
    Friend WithEvents lbl_department As Label
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_save As Button
End Class
