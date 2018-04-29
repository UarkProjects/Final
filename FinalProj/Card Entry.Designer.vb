<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCardEntry
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
        Me.txtCardNum = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblMoNum = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.lblMo = New System.Windows.Forms.Label()
        Me.lblCVV = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCardNum
        '
        Me.lblCardNum.AutoSize = True
        Me.lblCardNum.Location = New System.Drawing.Point(13, 25)
        Me.lblCardNum.Name = "lblCardNum"
        Me.lblCardNum.Size = New System.Drawing.Size(69, 13)
        Me.lblCardNum.TabIndex = 0
        Me.lblCardNum.Text = "Card Number"
        '
        'txtCardNum
        '
        Me.txtCardNum.Location = New System.Drawing.Point(89, 25)
        Me.txtCardNum.MaxLength = 16
        Me.txtCardNum.Name = "txtCardNum"
        Me.txtCardNum.Size = New System.Drawing.Size(100, 20)
        Me.txtCardNum.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(149, 68)
        Me.txtYear.MaxLength = 2
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(40, 20)
        Me.txtYear.TabIndex = 3
        '
        'lblMoNum
        '
        Me.lblMoNum.AutoSize = True
        Me.lblMoNum.Location = New System.Drawing.Point(54, 71)
        Me.lblMoNum.Name = "lblMoNum"
        Me.lblMoNum.Size = New System.Drawing.Size(24, 13)
        Me.lblMoNum.TabIndex = 2
        Me.lblMoNum.Text = "MO"
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(89, 91)
        Me.txtCVV.MaxLength = 3
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(51, 20)
        Me.txtCVV.TabIndex = 5
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(121, 71)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(22, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "YR"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(84, 68)
        Me.txtMonth.MaxLength = 2
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(31, 20)
        Me.txtMonth.TabIndex = 7
        '
        'lblMo
        '
        Me.lblMo.AutoSize = True
        Me.lblMo.Location = New System.Drawing.Point(13, 51)
        Me.lblMo.Name = "lblMo"
        Me.lblMo.Size = New System.Drawing.Size(79, 13)
        Me.lblMo.TabIndex = 6
        Me.lblMo.Text = "Expiration Date"
        '
        'lblCVV
        '
        Me.lblCVV.AutoSize = True
        Me.lblCVV.Location = New System.Drawing.Point(38, 98)
        Me.lblCVV.Name = "lblCVV"
        Me.lblCVV.Size = New System.Drawing.Size(28, 13)
        Me.lblCVV.TabIndex = 8
        Me.lblCVV.Text = "CVV"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(25, 133)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(153, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add Card"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmCardEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 168)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCVV)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.lblMo)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblMoNum)
        Me.Controls.Add(Me.txtCardNum)
        Me.Controls.Add(Me.lblCardNum)
        Me.Name = "frmCardEntry"
        Me.Text = "Card_Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCardNum As Label
    Friend WithEvents txtCardNum As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents lblMoNum As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents lblMo As Label
    Friend WithEvents lblCVV As Label
    Friend WithEvents btnAdd As Button
End Class
