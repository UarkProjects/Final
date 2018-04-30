<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganizationProfile
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPWConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrgAddress = New System.Windows.Forms.TextBox()
        Me.lblOrgAddress = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtwebpage = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtOrgName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrgName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 184)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(199, 23)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtPWConfirm
        '
        Me.txtPWConfirm.Location = New System.Drawing.Point(131, 152)
        Me.txtPWConfirm.Name = "txtPWConfirm"
        Me.txtPWConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtPWConfirm.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Confirm PW Change"
        '
        'txtOrgAddress
        '
        Me.txtOrgAddress.Location = New System.Drawing.Point(131, 48)
        Me.txtOrgAddress.Name = "txtOrgAddress"
        Me.txtOrgAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtOrgAddress.TabIndex = 40
        '
        'lblOrgAddress
        '
        Me.lblOrgAddress.AutoSize = True
        Me.lblOrgAddress.Location = New System.Drawing.Point(20, 48)
        Me.lblOrgAddress.Name = "lblOrgAddress"
        Me.lblOrgAddress.Size = New System.Drawing.Size(110, 13)
        Me.lblOrgAddress.TabIndex = 39
        Me.lblOrgAddress.Text = "Organization Address:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(131, 126)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Password:"
        '
        'txtwebpage
        '
        Me.txtwebpage.Location = New System.Drawing.Point(131, 100)
        Me.txtwebpage.Name = "txtwebpage"
        Me.txtwebpage.Size = New System.Drawing.Size(100, 20)
        Me.txtwebpage.TabIndex = 36
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(131, 74)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 35
        '
        'txtOrgName
        '
        Me.txtOrgName.Location = New System.Drawing.Point(131, 22)
        Me.txtOrgName.Name = "txtOrgName"
        Me.txtOrgName.Size = New System.Drawing.Size(100, 20)
        Me.txtOrgName.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Webpage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Phone Number:"
        '
        'lblOrgName
        '
        Me.lblOrgName.AutoSize = True
        Me.lblOrgName.Location = New System.Drawing.Point(29, 22)
        Me.lblOrgName.Name = "lblOrgName"
        Me.lblOrgName.Size = New System.Drawing.Size(100, 13)
        Me.lblOrgName.TabIndex = 31
        Me.lblOrgName.Text = "Organization Name:"
        '
        'frmOrganizationProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 228)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtPWConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOrgAddress)
        Me.Controls.Add(Me.lblOrgAddress)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtwebpage)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtOrgName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOrgName)
        Me.Name = "frmOrganizationProfile"
        Me.Text = "Organization Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents txtPWConfirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOrgAddress As TextBox
    Friend WithEvents lblOrgAddress As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtwebpage As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtOrgName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblOrgName As Label
End Class
