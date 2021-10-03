<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGov
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCaptureData = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnDisplayInfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCaptureData
        '
        Me.btnCaptureData.Location = New System.Drawing.Point(13, 38)
        Me.btnCaptureData.Name = "btnCaptureData"
        Me.btnCaptureData.Size = New System.Drawing.Size(73, 43)
        Me.btnCaptureData.TabIndex = 0
        Me.btnCaptureData.Text = "Capture data"
        Me.btnCaptureData.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(277, 13)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(511, 425)
        Me.txtDisplay.TabIndex = 1
        '
        'btnDisplayInfo
        '
        Me.btnDisplayInfo.Location = New System.Drawing.Point(13, 110)
        Me.btnDisplayInfo.Name = "btnDisplayInfo"
        Me.btnDisplayInfo.Size = New System.Drawing.Size(73, 38)
        Me.btnDisplayInfo.TabIndex = 2
        Me.btnDisplayInfo.Text = "Display Info"
        Me.btnDisplayInfo.UseVisualStyleBackColor = True
        '
        'frmGov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisplayInfo)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnCaptureData)
        Me.Name = "frmGov"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCaptureData As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnDisplayInfo As Button
End Class
