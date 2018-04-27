<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDonationHistory
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
        Me.lblTotalDonations = New System.Windows.Forms.Label()
        Me.lblCurrentYearDonations = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalDonations
        '
        Me.lblTotalDonations.AutoSize = True
        Me.lblTotalDonations.Location = New System.Drawing.Point(377, 13)
        Me.lblTotalDonations.Name = "lblTotalDonations"
        Me.lblTotalDonations.Size = New System.Drawing.Size(128, 13)
        Me.lblTotalDonations.TabIndex = 14
        Me.lblTotalDonations.Text = "Total Donations: [$xxx.xx]"
        '
        'lblCurrentYearDonations
        '
        Me.lblCurrentYearDonations.AutoSize = True
        Me.lblCurrentYearDonations.Location = New System.Drawing.Point(189, 13)
        Me.lblCurrentYearDonations.Name = "lblCurrentYearDonations"
        Me.lblCurrentYearDonations.Size = New System.Drawing.Size(169, 13)
        Me.lblCurrentYearDonations.TabIndex = 13
        Me.lblCurrentYearDonations.Text = "[Current Year] Donations: [$xxx.xx]"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 13)
        Me.lblName.TabIndex = 12
        Me.lblName.Text = "First Name Last Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(493, 394)
        Me.DataGridView1.TabIndex = 11
        '
        'frmDonationHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 450)
        Me.Controls.Add(Me.lblTotalDonations)
        Me.Controls.Add(Me.lblCurrentYearDonations)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmDonationHistory"
        Me.Text = "Donation History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalDonations As Label
    Friend WithEvents lblCurrentYearDonations As Label
    Friend WithEvents lblName As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
