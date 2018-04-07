Public Class frmOrganizationLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Dispose()
        frmOrganizationPortal.Show()
        frmWelcome.Close()
    End Sub
End Class