Public Class frmWelcome
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If radDonor.Checked = True Then
            frmDonorLogin.Show()
        ElseIf radOrganization.Checked = True Then
            frmOrganizationLogin.Show()
        End If
    End Sub
End Class