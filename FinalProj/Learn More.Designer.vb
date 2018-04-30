<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLearnMore
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
        Me.webbSite = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'webbSite
        '
        Me.webbSite.Location = New System.Drawing.Point(2, 1)
        Me.webbSite.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webbSite.Name = "webbSite"
        Me.webbSite.Size = New System.Drawing.Size(776, 360)
        Me.webbSite.TabIndex = 0
        '
        'frmLearnMore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 529)
        Me.Controls.Add(Me.webbSite)
        Me.Name = "frmLearnMore"
        Me.Text = "Learn_More"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents webbSite As WebBrowser
End Class
