<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewOrganization
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblMainCause = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblFoundation = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtCause = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtFoundingDate = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(97, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Organization Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoBackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(234, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoBackToolStripMenuItem.Text = "Go Back"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(64, 67)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(85, 90)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 3
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(77, 115)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 4
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(63, 144)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(46, 13)
        Me.lblZip.TabIndex = 5
        Me.lblZip.Text = "Zipcode"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(31, 168)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Phone Number"
        '
        'lblMainCause
        '
        Me.lblMainCause.AutoSize = True
        Me.lblMainCause.Location = New System.Drawing.Point(46, 198)
        Me.lblMainCause.Name = "lblMainCause"
        Me.lblMainCause.Size = New System.Drawing.Size(63, 13)
        Me.lblMainCause.TabIndex = 7
        Me.lblMainCause.Text = "Main Cause"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(49, 225)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 8
        Me.lblDescription.Text = "Description"
        '
        'lblFoundation
        '
        Me.lblFoundation.AutoSize = True
        Me.lblFoundation.Location = New System.Drawing.Point(23, 252)
        Me.lblFoundation.Name = "lblFoundation"
        Me.lblFoundation.Size = New System.Drawing.Size(86, 13)
        Me.lblFoundation.TabIndex = 9
        Me.lblFoundation.Text = "Foundation Date"
        '
        'lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Location = New System.Drawing.Point(63, 278)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(46, 13)
        Me.lblWebsite.TabIndex = 10
        Me.lblWebsite.Text = "Website"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(115, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 60)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 12
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(115, 87)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 13
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(115, 114)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 14
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(115, 141)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(115, 168)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 16
        '
        'txtCause
        '
        Me.txtCause.Location = New System.Drawing.Point(115, 195)
        Me.txtCause.Name = "txtCause"
        Me.txtCause.Size = New System.Drawing.Size(100, 20)
        Me.txtCause.TabIndex = 17
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(115, 222)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 18
        '
        'txtFoundingDate
        '
        Me.txtFoundingDate.Location = New System.Drawing.Point(115, 249)
        Me.txtFoundingDate.Name = "txtFoundingDate"
        Me.txtFoundingDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFoundingDate.TabIndex = 19
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(115, 275)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(100, 20)
        Me.txtWebsite.TabIndex = 20
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(140, 358)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(26, 358)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Password"
        '
        'txtPW
        '
        Me.txtPW.Location = New System.Drawing.Point(115, 302)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(100, 20)
        Me.txtPW.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(115, 328)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Re-Enter Password"
        '
        'frmNewOrganization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 393)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.txtFoundingDate)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCause)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblWebsite)
        Me.Controls.Add(Me.lblFoundation)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblMainCause)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewOrganization"
        Me.Text = "New Organization"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZip As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblMainCause As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblFoundation As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZip As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtCause As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtFoundingDate As TextBox
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPW As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
