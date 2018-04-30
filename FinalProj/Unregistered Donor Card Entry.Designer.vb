<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnreg
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
        Me.lblCardNum = New System.Windows.Forms.Label()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.lblMo = New System.Windows.Forms.Label()
        Me.lblYR = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCardNum
        '
        Me.lblCardNum.AutoSize = True
        Me.lblCardNum.Location = New System.Drawing.Point(13, 13)
        Me.lblCardNum.Name = "lblCardNum"
        Me.lblCardNum.Size = New System.Drawing.Size(69, 13)
        Me.lblCardNum.TabIndex = 0
        Me.lblCardNum.Text = "Card Number"
        '
        'lblExp
        '
        Me.lblExp.AutoSize = True
        Me.lblExp.Location = New System.Drawing.Point(16, 43)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(53, 13)
        Me.lblExp.TabIndex = 1
        Me.lblExp.Text = "Expiration"
        '
        'lblMo
        '
        Me.lblMo.AutoSize = True
        Me.lblMo.Location = New System.Drawing.Point(45, 63)
        Me.lblMo.Name = "lblMo"
        Me.lblMo.Size = New System.Drawing.Size(37, 13)
        Me.lblMo.TabIndex = 2
        Me.lblMo.Text = "Month"
        '
        'lblYR
        '
        Me.lblYR.AutoSize = True
        Me.lblYR.Location = New System.Drawing.Point(45, 89)
        Me.lblYR.Name = "lblYR"
        Me.lblYR.Size = New System.Drawing.Size(29, 13)
        Me.lblYR.TabIndex = 3
        Me.lblYR.Text = "Year"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(88, 63)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(45, 20)
        Me.txtMonth.TabIndex = 4
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(88, 89)
        Me.txtYear.MaxLength = 2
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(45, 20)
        Me.txtYear.TabIndex = 5
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Location = New System.Drawing.Point(19, 122)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(28, 13)
        Me.lblCVV.TabIndex = 6
        Me.lblCVV.Text = "CVV"
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(88, 122)
        Me.txtCVV.MaxLength = 3
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(51, 20)
        Me.txtCVV.TabIndex = 7
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(89, 13)
        Me.txtCardNum.MaxLength = 16
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCardNum.TabIndex = 8
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(22, 180)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(101, 180)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(96, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send Payment"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'frmUnreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(209, 221)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.lblCVV)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.lblYR)
        Me.Controls.Add(Me.lblMo)
        Me.Controls.Add(Me.lblExp)
        Me.Controls.Add(Me.lblCardNum)
        Me.Name = "frmUnreg"
        Me.Text = "Unregistered_Donor_Card_Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardNum As Label
    Friend WithEvents lblExp As Label
    Friend WithEvents lblMo As Label
    Friend WithEvents lblYR As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblCVV As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSend As Button
End Class
