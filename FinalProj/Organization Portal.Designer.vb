<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganizationPortal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizationProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnScheduledServiceEvents = New System.Windows.Forms.Button()
        Me.btnNewServiceEvent = New System.Windows.Forms.Button()
        Me.btnDonorRecords = New System.Windows.Forms.Button()
        Me.btnVolunteerRecords = New System.Windows.Forms.Button()
        Me.lblOrgName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoffToolStripMenuItem, Me.OrganizationProfileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoffToolStripMenuItem
        '
        Me.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem"
        Me.LogoffToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogoffToolStripMenuItem.Text = "Log Out"
        '
        'OrganizationProfileToolStripMenuItem
        '
        Me.OrganizationProfileToolStripMenuItem.Name = "OrganizationProfileToolStripMenuItem"
        Me.OrganizationProfileToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.OrganizationProfileToolStripMenuItem.Text = "Organization Profile"
        '
        'btnScheduledServiceEvents
        '
        Me.btnScheduledServiceEvents.Location = New System.Drawing.Point(225, 182)
        Me.btnScheduledServiceEvents.Name = "btnScheduledServiceEvents"
        Me.btnScheduledServiceEvents.Size = New System.Drawing.Size(141, 23)
        Me.btnScheduledServiceEvents.TabIndex = 10
        Me.btnScheduledServiceEvents.Text = "Scheduled Service Events"
        Me.btnScheduledServiceEvents.UseVisualStyleBackColor = True
        '
        'btnNewServiceEvent
        '
        Me.btnNewServiceEvent.Location = New System.Drawing.Point(401, 182)
        Me.btnNewServiceEvent.Name = "btnNewServiceEvent"
        Me.btnNewServiceEvent.Size = New System.Drawing.Size(113, 23)
        Me.btnNewServiceEvent.TabIndex = 11
        Me.btnNewServiceEvent.Text = "New Service Event"
        Me.btnNewServiceEvent.UseVisualStyleBackColor = True
        '
        'btnDonorRecords
        '
        Me.btnDonorRecords.Location = New System.Drawing.Point(263, 211)
        Me.btnDonorRecords.Name = "btnDonorRecords"
        Me.btnDonorRecords.Size = New System.Drawing.Size(103, 23)
        Me.btnDonorRecords.TabIndex = 12
        Me.btnDonorRecords.Text = "Donor Records"
        Me.btnDonorRecords.UseVisualStyleBackColor = True
        '
        'btnVolunteerRecords
        '
        Me.btnVolunteerRecords.Location = New System.Drawing.Point(401, 211)
        Me.btnVolunteerRecords.Name = "btnVolunteerRecords"
        Me.btnVolunteerRecords.Size = New System.Drawing.Size(113, 23)
        Me.btnVolunteerRecords.TabIndex = 13
        Me.btnVolunteerRecords.Text = "Volunteer Records"
        Me.btnVolunteerRecords.UseVisualStyleBackColor = True
        '
        'lblOrgName
        '
        Me.lblOrgName.AutoSize = True
        Me.lblOrgName.Location = New System.Drawing.Point(102, 95)
        Me.lblOrgName.Name = "lblOrgName"
        Me.lblOrgName.Size = New System.Drawing.Size(55, 13)
        Me.lblOrgName.TabIndex = 14
        Me.lblOrgName.Text = "Org Name"
        '
        'frmOrganizationPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOrgName)
        Me.Controls.Add(Me.btnVolunteerRecords)
        Me.Controls.Add(Me.btnDonorRecords)
        Me.Controls.Add(Me.btnNewServiceEvent)
        Me.Controls.Add(Me.btnScheduledServiceEvents)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmOrganizationPortal"
        Me.Text = "Organization Portal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizationProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnScheduledServiceEvents As Button
    Friend WithEvents btnNewServiceEvent As Button
    Friend WithEvents btnDonorRecords As Button
    Friend WithEvents btnVolunteerRecords As Button
    Friend WithEvents lblOrgName As Label
End Class
