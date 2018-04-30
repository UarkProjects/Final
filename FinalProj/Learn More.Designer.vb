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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DonateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'webbSite
        '
        Me.webbSite.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webbSite.Location = New System.Drawing.Point(0, 24)
        Me.webbSite.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webbSite.Name = "webbSite"
        Me.webbSite.Size = New System.Drawing.Size(781, 505)
        Me.webbSite.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem, Me.ReturnToListToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DonateToolStripMenuItem
        '
        Me.DonateToolStripMenuItem.Name = "DonateToolStripMenuItem"
        Me.DonateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DonateToolStripMenuItem.Text = "Donate"
        '
        'ReturnToListToolStripMenuItem
        '
        Me.ReturnToListToolStripMenuItem.Name = "ReturnToListToolStripMenuItem"
        Me.ReturnToListToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ReturnToListToolStripMenuItem.Text = "Return to List"
        '
        'frmLearnMore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 529)
        Me.Controls.Add(Me.webbSite)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmLearnMore"
        Me.Text = "Learn_More"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents webbSite As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DonateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToListToolStripMenuItem As ToolStripMenuItem
End Class
