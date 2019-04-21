<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPingStatus
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCurrentRec = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblTtlRec = New System.Windows.Forms.Label()
        Me.LblSsName = New System.Windows.Forms.Label()
        Me.LblError = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scaning"
        '
        'LblCurrentRec
        '
        Me.LblCurrentRec.AutoSize = True
        Me.LblCurrentRec.Location = New System.Drawing.Point(84, 13)
        Me.LblCurrentRec.Name = "LblCurrentRec"
        Me.LblCurrentRec.Size = New System.Drawing.Size(35, 18)
        Me.LblCurrentRec.TabIndex = 1
        Me.LblCurrentRec.Text = "###"
        Me.LblCurrentRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Of"
        '
        'LblTtlRec
        '
        Me.LblTtlRec.AutoSize = True
        Me.LblTtlRec.Location = New System.Drawing.Point(155, 13)
        Me.LblTtlRec.Name = "LblTtlRec"
        Me.LblTtlRec.Size = New System.Drawing.Size(35, 18)
        Me.LblTtlRec.TabIndex = 3
        Me.LblTtlRec.Text = "###"
        Me.LblTtlRec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSsName
        '
        Me.LblSsName.AutoSize = True
        Me.LblSsName.Location = New System.Drawing.Point(13, 62)
        Me.LblSsName.Name = "LblSsName"
        Me.LblSsName.Size = New System.Drawing.Size(69, 18)
        Me.LblSsName.TabIndex = 4
        Me.LblSsName.Text = "SsName"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.ForeColor = System.Drawing.Color.Red
        Me.LblError.Location = New System.Drawing.Point(16, 94)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(0, 18)
        Me.LblError.TabIndex = 5
        '
        'FrmPingStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 132)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.LblSsName)
        Me.Controls.Add(Me.LblTtlRec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblCurrentRec)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPingStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ping Status"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblCurrentRec As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblTtlRec As System.Windows.Forms.Label
    Friend WithEvents LblSsName As System.Windows.Forms.Label
    Friend WithEvents LblError As System.Windows.Forms.Label
End Class
