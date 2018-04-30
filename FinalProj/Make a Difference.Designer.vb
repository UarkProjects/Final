<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakeADiff
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
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDonate = New System.Windows.Forms.TabPage()
        Me.dgvDonate = New System.Windows.Forms.DataGridView()
        Me.tabVolunteer = New System.Windows.Forms.TabPage()
        Me.dgvVolunteer = New System.Windows.Forms.DataGridView()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.btnVolunteer = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabDonate.SuspendLayout()
        CType(Me.dgvDonate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVolunteer.SuspendLayout()
        CType(Me.dgvVolunteer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ReturnToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(545, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDonate)
        Me.TabControl1.Controls.Add(Me.tabVolunteer)
        Me.TabControl1.Location = New System.Drawing.Point(12, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(529, 334)
        Me.TabControl1.TabIndex = 11
        '
        'tabDonate
        '
        Me.tabDonate.Controls.Add(Me.dgvDonate)
        Me.tabDonate.Location = New System.Drawing.Point(4, 22)
        Me.tabDonate.Name = "tabDonate"
        Me.tabDonate.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDonate.Size = New System.Drawing.Size(521, 308)
        Me.tabDonate.TabIndex = 0
        Me.tabDonate.Text = "Donate"
        Me.tabDonate.UseVisualStyleBackColor = True
        '
        'dgvDonate
        '
        Me.dgvDonate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDonate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDonate.Location = New System.Drawing.Point(3, 3)
        Me.dgvDonate.Name = "dgvDonate"
        Me.dgvDonate.Size = New System.Drawing.Size(515, 302)
        Me.dgvDonate.TabIndex = 0
        '
        'tabVolunteer
        '
        Me.tabVolunteer.Controls.Add(Me.dgvVolunteer)
        Me.tabVolunteer.Location = New System.Drawing.Point(4, 22)
        Me.tabVolunteer.Name = "tabVolunteer"
        Me.tabVolunteer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVolunteer.Size = New System.Drawing.Size(521, 308)
        Me.tabVolunteer.TabIndex = 1
        Me.tabVolunteer.Text = "Volunteer"
        Me.tabVolunteer.UseVisualStyleBackColor = True
        '
        'dgvVolunteer
        '
        Me.dgvVolunteer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVolunteer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVolunteer.Location = New System.Drawing.Point(3, 3)
        Me.dgvVolunteer.Name = "dgvVolunteer"
        Me.dgvVolunteer.Size = New System.Drawing.Size(515, 302)
        Me.dgvVolunteer.TabIndex = 0
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(57, 367)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(188, 23)
        Me.btnDonate.TabIndex = 12
        Me.btnDonate.Text = "Donate"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'btnVolunteer
        '
        Me.btnVolunteer.Location = New System.Drawing.Point(285, 367)
        Me.btnVolunteer.Name = "btnVolunteer"
        Me.btnVolunteer.Size = New System.Drawing.Size(188, 23)
        Me.btnVolunteer.TabIndex = 13
        Me.btnVolunteer.Text = "Volunteer"
        Me.btnVolunteer.UseVisualStyleBackColor = True
        '
        'frmMakeADiff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 397)
        Me.Controls.Add(Me.btnVolunteer)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMakeADiff"
        Me.Text = "Make a Difference!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabDonate.ResumeLayout(False)
        CType(Me.dgvDonate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVolunteer.ResumeLayout(False)
        CType(Me.dgvVolunteer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDonate As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents dgvDonate As DataGridView
    Friend WithEvents dgvVolunteer As DataGridView
    Friend WithEvents btnDonate As Button
    Friend WithEvents btnVolunteer As Button
End Class
