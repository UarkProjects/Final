Public Class frmDonorLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Dispose()
        frmDonorPortal.Show()
        frmWelcome.Close()
    End Sub
End Class