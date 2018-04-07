Public Class frmDonorPortal
    Protected db As New db
    Protected DonID As Integer
    Public Sub New(ByVal dID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dID = DonID
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        frmWelcome.Show()
    End Sub

    Private Sub btnDonationHistory_Click(sender As Object, e As EventArgs) Handles btnDonationHistory.Click
        frmDonationHistory.Show()
    End Sub

    Private Sub btnServiceHistory_Click(sender As Object, e As EventArgs) Handles btnServiceHistory.Click
        frmServiceHistory.Show()
    End Sub

    Private Sub btnMakeADifference_Click(sender As Object, e As EventArgs) Handles btnMakeADifference.Click
        frmMakeADiff.Show()
    End Sub


End Class