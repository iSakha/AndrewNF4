<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrationForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_login_reg = New System.Windows.Forms.TextBox()
        Me.txt_pass_reg = New System.Windows.Forms.TextBox()
        Me.txt_pass_confirm = New System.Windows.Forms.TextBox()
        Me.btn_registr = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm password"
        '
        'txt_login_reg
        '
        Me.txt_login_reg.Location = New System.Drawing.Point(193, 28)
        Me.txt_login_reg.Name = "txt_login_reg"
        Me.txt_login_reg.Size = New System.Drawing.Size(127, 20)
        Me.txt_login_reg.TabIndex = 5
        '
        'txt_pass_reg
        '
        Me.txt_pass_reg.Location = New System.Drawing.Point(193, 74)
        Me.txt_pass_reg.Name = "txt_pass_reg"
        Me.txt_pass_reg.Size = New System.Drawing.Size(127, 20)
        Me.txt_pass_reg.TabIndex = 5
        '
        'txt_pass_confirm
        '
        Me.txt_pass_confirm.Location = New System.Drawing.Point(193, 124)
        Me.txt_pass_confirm.Name = "txt_pass_confirm"
        Me.txt_pass_confirm.Size = New System.Drawing.Size(127, 20)
        Me.txt_pass_confirm.TabIndex = 5
        '
        'btn_registr
        '
        Me.btn_registr.Location = New System.Drawing.Point(13, 174)
        Me.btn_registr.Name = "btn_registr"
        Me.btn_registr.Size = New System.Drawing.Size(307, 23)
        Me.btn_registr.TabIndex = 6
        Me.btn_registr.Text = "Registration"
        Me.btn_registr.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NF4.My.Resources.Resources.registration
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'registrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 229)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_registr)
        Me.Controls.Add(Me.txt_pass_confirm)
        Me.Controls.Add(Me.txt_pass_reg)
        Me.Controls.Add(Me.txt_login_reg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "registrationForm"
        Me.Text = "registrForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_login_reg As TextBox
    Friend WithEvents txt_pass_reg As TextBox
    Friend WithEvents txt_pass_confirm As TextBox
    Friend WithEvents btn_registr As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
