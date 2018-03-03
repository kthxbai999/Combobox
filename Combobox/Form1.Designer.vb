<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cboNames = New System.Windows.Forms.ComboBox()
        Me.btnClickme = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cboNames
        '
        Me.cboNames.FormattingEnabled = True
        Me.cboNames.Location = New System.Drawing.Point(51, 47)
        Me.cboNames.Name = "cboNames"
        Me.cboNames.Size = New System.Drawing.Size(121, 21)
        Me.cboNames.TabIndex = 0
        '
        'btnClickme
        '
        Me.btnClickme.Location = New System.Drawing.Point(51, 111)
        Me.btnClickme.Name = "btnClickme"
        Me.btnClickme.Size = New System.Drawing.Size(111, 25)
        Me.btnClickme.TabIndex = 2
        Me.btnClickme.Text = "click me"
        Me.btnClickme.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(87, 178)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(37, 13)
        Me.lblDisplay.TabIndex = 3
        Me.lblDisplay.Text = "Result"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnClickme)
        Me.Controls.Add(Me.cboNames)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents cboNames As System.Windows.Forms.ComboBox
    Friend WithEvents btnClickme As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
