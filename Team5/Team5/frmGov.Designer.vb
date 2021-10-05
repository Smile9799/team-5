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
        Me.btnDisplayInfo = New System.Windows.Forms.Button()
        Me.btnCountryStats = New System.Windows.Forms.Button()
        Me.btnWorstAndBestCountries = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.RichTextBox()
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
        'btnDisplayInfo
        '
        Me.btnDisplayInfo.Location = New System.Drawing.Point(13, 110)
        Me.btnDisplayInfo.Name = "btnDisplayInfo"
        Me.btnDisplayInfo.Size = New System.Drawing.Size(73, 38)
        Me.btnDisplayInfo.TabIndex = 2
        Me.btnDisplayInfo.Text = "Display Info"
        Me.btnDisplayInfo.UseVisualStyleBackColor = True
        '
        'btnCountryStats
        '
        Me.btnCountryStats.Location = New System.Drawing.Point(12, 175)
        Me.btnCountryStats.Name = "btnCountryStats"
        Me.btnCountryStats.Size = New System.Drawing.Size(74, 43)
        Me.btnCountryStats.TabIndex = 3
        Me.btnCountryStats.Text = "Country Stats"
        Me.btnCountryStats.UseVisualStyleBackColor = True
        '
        'btnWorstAndBestCountries
        '
        Me.btnWorstAndBestCountries.Location = New System.Drawing.Point(12, 240)
        Me.btnWorstAndBestCountries.Name = "btnWorstAndBestCountries"
        Me.btnWorstAndBestCountries.Size = New System.Drawing.Size(73, 51)
        Me.btnWorstAndBestCountries.TabIndex = 4
        Me.btnWorstAndBestCountries.Text = "Best and Worst Countries"
        Me.btnWorstAndBestCountries.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(274, 12)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.Size = New System.Drawing.Size(514, 426)
        Me.txtDisplay.TabIndex = 5
        Me.txtDisplay.Text = ""
        '
        'frmGov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnWorstAndBestCountries)
        Me.Controls.Add(Me.btnCountryStats)
        Me.Controls.Add(Me.btnDisplayInfo)
        Me.Controls.Add(Me.btnCaptureData)
        Me.Name = "frmGov"
        Me.Text = "Team 5 Gov"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCaptureData As Button
    Friend WithEvents btnDisplayInfo As Button
    Friend WithEvents btnCountryStats As Button
    Friend WithEvents btnWorstAndBestCountries As Button
    Friend WithEvents txtDisplay As RichTextBox
End Class
