Public Class frmDonorPortal
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