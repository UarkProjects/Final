﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServiceHistory
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
        Me.lblTotalDonations.Size = New System.Drawing.Size(156, 13)
        Me.lblTotalDonations.TabIndex = 18
        Me.lblTotalDonations.Text = "Total Volunteer Hours: [$xxx.xx]"
        '
        'lblCurrentYearDonations
        '
        Me.lblCurrentYearDonations.AutoSize = True
        Me.lblCurrentYearDonations.Location = New System.Drawing.Point(130, 13)
        Me.lblCurrentYearDonations.Name = "lblCurrentYearDonations"
        Me.lblCurrentYearDonations.Size = New System.Drawing.Size(236, 13)
        Me.lblCurrentYearDonations.TabIndex = 17
        Me.lblCurrentYearDonations.Text = "[Current Year] Total Hours Volunteered: [$xxx.xx]"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 13)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "First Name Last Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(518, 394)
        Me.DataGridView1.TabIndex = 15
        '
        'frmServiceHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 450)
        Me.Controls.Add(Me.lblTotalDonations)
        Me.Controls.Add(Me.lblCurrentYearDonations)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmServiceHistory"
        Me.Text = "Service History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDonations As Label
    Friend WithEvents lblCurrentYearDonations As Label
    Friend WithEvents lblName As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
