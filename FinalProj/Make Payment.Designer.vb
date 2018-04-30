<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMakePayment
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblOrgName = New System.Windows.Forms.Label()
        Me.txtOrgName = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dgvCards = New System.Windows.Forms.DataGridView()
        Me.lblSelectCard = New System.Windows.Forms.Label()
        CType(Me.dgvCards, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(35, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(167, 254)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(109, 23)
        Me.btnPay.TabIndex = 1
        Me.btnPay.Text = "Make Payment"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblOrgName
        '
        Me.lblOrgName.AutoSize = True
        Me.lblOrgName.Location = New System.Drawing.Point(13, 13)
        Me.lblOrgName.Name = "lblOrgName"
        Me.lblOrgName.Size = New System.Drawing.Size(97, 13)
        Me.lblOrgName.TabIndex = 2
        Me.lblOrgName.Text = "Organization Name"
        '
        'txtOrgName
        '
        Me.txtOrgName.Enabled = False
        Me.txtOrgName.Location = New System.Drawing.Point(130, 13)
        Me.txtOrgName.Name = "txtOrgName"
        Me.txtOrgName.Size = New System.Drawing.Size(100, 20)
        Me.txtOrgName.TabIndex = 3
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(13, 46)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(130, 46)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 5
        '
        'dgvCards
        '
        Me.dgvCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCards.Location = New System.Drawing.Point(16, 89)
        Me.dgvCards.Name = "dgvCards"
        Me.dgvCards.Size = New System.Drawing.Size(296, 150)
        Me.dgvCards.TabIndex = 6
        '
        'lblSelectCard
        '
        Me.lblSelectCard.AutoSize = True
        Me.lblSelectCard.Location = New System.Drawing.Point(13, 72)
        Me.lblSelectCard.Name = "lblSelectCard"
        Me.lblSelectCard.Size = New System.Drawing.Size(120, 13)
        Me.lblSelectCard.TabIndex = 7
        Me.lblSelectCard.Text = "Select Card to Pay With"
        '
        'frmMakePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 299)
        Me.Controls.Add(Me.lblSelectCard)
        Me.Controls.Add(Me.dgvCards)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtOrgName)
        Me.Controls.Add(Me.lblOrgName)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnCancel)
        Me.Name = "frmMakePayment"
        Me.Text = "Make_Payment"
        CType(Me.dgvCards, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents lblOrgName As Label
    Friend WithEvents txtOrgName As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents dgvCards As DataGridView
    Friend WithEvents lblSelectCard As Label
End Class
