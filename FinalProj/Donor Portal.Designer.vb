<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonorPortal
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
        Me.btnMakeADifference = New System.Windows.Forms.Button()
        Me.btnServiceHistory = New System.Windows.Forms.Button()
        Me.btnDonationHistory = New System.Windows.Forms.Button()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnMakeADifference
        '
        Me.btnMakeADifference.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeADifference.Location = New System.Drawing.Point(41, 100)
        Me.btnMakeADifference.Name = "btnMakeADifference"
        Me.btnMakeADifference.Size = New System.Drawing.Size(240, 27)
        Me.btnMakeADifference.TabIndex = 14
        Me.btnMakeADifference.Text = "Make a Difference!"
        Me.btnMakeADifference.UseVisualStyleBackColor = True
        '
        'btnServiceHistory
        '
        Me.btnServiceHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServiceHistory.Location = New System.Drawing.Point(177, 67)
        Me.btnServiceHistory.Name = "btnServiceHistory"
        Me.btnServiceHistory.Size = New System.Drawing.Size(139, 27)
        Me.btnServiceHistory.TabIndex = 13
        Me.btnServiceHistory.Text = "Service History"
        Me.btnServiceHistory.UseVisualStyleBackColor = True
        '
        'btnDonationHistory
        '
        Me.btnDonationHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDonationHistory.Location = New System.Drawing.Point(16, 67)
        Me.btnDonationHistory.Name = "btnDonationHistory"
        Me.btnDonationHistory.Size = New System.Drawing.Size(139, 27)
        Me.btnDonationHistory.TabIndex = 12
        Me.btnDonationHistory.Text = "Donation History"
        Me.btnDonationHistory.UseVisualStyleBackColor = True
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(12, 33)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(170, 20)
        Me.lblGreeting.TabIndex = 10
        Me.lblGreeting.Text = "Welcome, [First name]!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.DonorProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'DonorProfileToolStripMenuItem
        '
        Me.DonorProfileToolStripMenuItem.Name = "DonorProfileToolStripMenuItem"
        Me.DonorProfileToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.DonorProfileToolStripMenuItem.Text = "Donor Profile"
        '
        'frmDonorPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 145)
        Me.Controls.Add(Me.btnMakeADifference)
        Me.Controls.Add(Me.btnServiceHistory)
        Me.Controls.Add(Me.btnDonationHistory)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmDonorPortal"
        Me.Text = "Donor Portal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMakeADifference As Button
    Friend WithEvents btnServiceHistory As Button
    Friend WithEvents btnDonationHistory As Button
    Friend WithEvents lblGreeting As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonorProfileToolStripMenuItem As ToolStripMenuItem
End Class
