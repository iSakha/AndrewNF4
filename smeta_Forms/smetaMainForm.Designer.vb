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
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_smeta
        '
        Me.DGV_smeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_smeta.Location = New System.Drawing.Point(106, 39)
        Me.DGV_smeta.Name = "DGV_smeta"
        Me.DGV_smeta.Size = New System.Drawing.Size(558, 350)
        Me.DGV_smeta.TabIndex = 0
        '
        'smetaMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DGV_smeta)
        Me.Name = "smetaMainForm"
        Me.Text = "smetaMainForm"
        CType(Me.DGV_smeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGV_smeta As DataGridView
End Class
