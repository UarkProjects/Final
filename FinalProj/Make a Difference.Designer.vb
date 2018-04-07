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
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.chkNationwide = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDonate = New System.Windows.Forms.TabPage()
        Me.dgvDonate = New System.Windows.Forms.DataGridView()
        Me.tabVolunteer = New System.Windows.Forms.TabPage()
        Me.dgvVolunteer = New System.Windows.Forms.DataGridView()
        Me.btnContinue = New System.Windows.Forms.Button()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(555, 24)
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
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(12, 36)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(119, 17)
        Me.chkLocal.TabIndex = 1
        Me.chkLocal.Text = "Local Organizations"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'chkNationwide
        '
        Me.chkNationwide.AutoSize = True
        Me.chkNationwide.Location = New System.Drawing.Point(12, 69)
        Me.chkNationwide.Name = "chkNationwide"
        Me.chkNationwide.Size = New System.Drawing.Size(79, 17)
        Me.chkNationwide.TabIndex = 2
        Me.chkNationwide.Text = "Nationwide"
        Me.chkNationwide.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Zip Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "City:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "State:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(220, 32)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(82, 20)
        Me.txtZip.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(341, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(220, 66)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(321, 20)
        Me.txtSearch.TabIndex = 9
        '
        'cmbState
        '
        Me.cmbState.FormattingEnabled = True
        Me.cmbState.Items.AddRange(New Object() {"AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"})
        Me.cmbState.Location = New System.Drawing.Point(488, 32)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.Size = New System.Drawing.Size(54, 21)
        Me.cmbState.TabIndex = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDonate)
        Me.TabControl1.Controls.Add(Me.tabVolunteer)
        Me.TabControl1.Location = New System.Drawing.Point(12, 104)
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
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(123, 444)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(318, 23)
        Me.btnContinue.TabIndex = 12
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmMakeADiff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 477)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbState)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkNationwide)
        Me.Controls.Add(Me.chkLocal)
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
    Friend WithEvents chkLocal As CheckBox
    Friend WithEvents chkNationwide As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbState As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDonate As TabPage
    Friend WithEvents tabVolunteer As TabPage
    Friend WithEvents dgvDonate As DataGridView
    Friend WithEvents dgvVolunteer As DataGridView
    Friend WithEvents btnContinue As Button
End Class
