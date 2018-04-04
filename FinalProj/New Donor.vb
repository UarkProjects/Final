Public Class frmNewDonor
    Private Sub brnClear_Click(sender As Object, e As EventArgs) Handles brnClear.Click
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub
End Class