Public Class frmDonorLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Dispose()
        frmDonorPortal.Show()
        'Need to also make the Welcome form close here please
    End Sub
End Class