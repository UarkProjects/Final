Public Class frmWelcome
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If radDonor.Checked = True Then
            frmDonorLogin.ShowDialog()
        ElseIf radOrganization.Checked = True Then
            frmOrganizationLogin.ShowDialog()
        Else
            MsgBox("Please select either donor or organization")
        End If
    End Sub

    Private Sub radOrganization_CheckedChanged(sender As Object, e As EventArgs) Handles radOrganization.CheckedChanged
        btnGuest.Enabled = False
    End Sub
    Private Sub radDonor_CheckedChanged(sender As Object, e As EventArgs) Handles radDonor.CheckedChanged
        btnGuest.Enabled = True
    End Sub
    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        Dim make As New frmMakeADiff(0)
        make.ShowDialog()

        Me.Close()
    End Sub
    Private Sub btnNewAccount_Click(sender As Object, e As EventArgs) Handles btnNewAccount.Click
        If radDonor.Checked = True Then
            frmNewDonor.ShowDialog()
        ElseIf radOrganization.Checked = True Then
            frmNewOrganization.ShowDialog()
        Else
            MsgBox("Please select either donor or organization")
        End If
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class