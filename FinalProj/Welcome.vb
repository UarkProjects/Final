Public Class frmWelcome
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If radDonor.Checked = True Then
            frmDonorLogin.ShowDialog()
        ElseIf radOrganization.Checked = True Then
            frmOrganizationLogin.ShowDialog()
        End If
    End Sub

    Private Sub radOrganization_CheckedChanged(sender As Object, e As EventArgs) Handles radOrganization.CheckedChanged
        btnGuest.Enabled = False
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        frmMakeADiff.Show()
        Me.Close()
    End Sub

    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        If radDonor.Checked = True Then
            frmNewDonor.ShowDialog()
        ElseIf radOrganization.Checked = True Then
            frmNewOrganization.ShowDialog()
        End If
    End Sub
End Class