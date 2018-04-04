<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnNewAccount = New System.Windows.Forms.Button()
        Me.radOrganization = New System.Windows.Forms.RadioButton()
        Me.radDonor = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(194, 105)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(154, 23)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnNewAccount
        '
        Me.btnNewAccount.Location = New System.Drawing.Point(374, 105)
        Me.btnNewAccount.Name = "btnNewAccount"
        Me.btnNewAccount.Size = New System.Drawing.Size(154, 23)
        Me.btnNewAccount.TabIndex = 10
        Me.btnNewAccount.Text = "Create New Account"
        Me.btnNewAccount.UseVisualStyleBackColor = True
        '
        'radOrganization
        '
        Me.radOrganization.AutoSize = True
        Me.radOrganization.Location = New System.Drawing.Point(273, 73)
        Me.radOrganization.Name = "radOrganization"
        Me.radOrganization.Size = New System.Drawing.Size(84, 17)
        Me.radOrganization.TabIndex = 9
        Me.radOrganization.TabStop = True
        Me.radOrganization.Text = "Organization"
        Me.radOrganization.UseVisualStyleBackColor = True
        '
        'radDonor
        '
        Me.radDonor.AutoSize = True
        Me.radDonor.Location = New System.Drawing.Point(184, 73)
        Me.radDonor.Name = "radDonor"
        Me.radDonor.Size = New System.Drawing.Size(54, 17)
        Me.radDonor.TabIndex = 8
        Me.radDonor.TabStop = True
        Me.radDonor.Text = "Donor"
        Me.radDonor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "P    •    E    •    A    •    C    •    E"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(501, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Periwinkle Electronic Access for Community Equality"
        '
        'btnGuest
        '
        Me.btnGuest.Location = New System.Drawing.Point(12, 105)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(154, 23)
        Me.btnGuest.TabIndex = 23
        Me.btnGuest.Text = "Continue as Guest"
        Me.btnGuest.UseVisualStyleBackColor = True
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 140)
        Me.Controls.Add(Me.btnGuest)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnNewAccount)
        Me.Controls.Add(Me.radOrganization)
        Me.Controls.Add(Me.radDonor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmWelcome"
        Me.Text = "Welcome!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents btnNewAccount As Button
    Friend WithEvents radOrganization As RadioButton
    Friend WithEvents radDonor As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuest As Button
End Class
