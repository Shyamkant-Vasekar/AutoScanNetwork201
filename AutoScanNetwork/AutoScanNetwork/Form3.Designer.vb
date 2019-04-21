<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.LblAnlzInf = New System.Windows.Forms.Label()
        Me.DgvAnalyze = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvAnalyze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAnlzInf
        '
        Me.LblAnlzInf.AutoSize = True
        Me.LblAnlzInf.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnlzInf.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LblAnlzInf.Location = New System.Drawing.Point(30, 27)
        Me.LblAnlzInf.Name = "LblAnlzInf"
        Me.LblAnlzInf.Size = New System.Drawing.Size(329, 29)
        Me.LblAnlzInf.TabIndex = 0
        Me.LblAnlzInf.Text = "Average for last 5 days data"
        '
        'DgvAnalyze
        '
        Me.DgvAnalyze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAnalyze.Location = New System.Drawing.Point(33, 82)
        Me.DgvAnalyze.Name = "DgvAnalyze"
        Me.DgvAnalyze.Size = New System.Drawing.Size(955, 567)
        Me.DgvAnalyze.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(877, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvAnalyze)
        Me.Controls.Add(Me.LblAnlzInf)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "ShowLimited / Analyze"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvAnalyze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblAnlzInf As System.Windows.Forms.Label
    Friend WithEvents DgvAnalyze As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
