Public Class frmOrganizationLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Dispose()
        frmOrganizationPortal.Show()
        'Make the Welcome Form go away here too
    End Sub
End Class