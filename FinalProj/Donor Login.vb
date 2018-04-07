Imports System.Data.SqlClient
Public Class frmDonorLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM Logins l  where l.username = @user AND l.password = @pass AND donorid is not null", connection)
        command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Dim teachid = (table.Rows(0).Item(2))
            Dim donorport As New frmDonorPortal(teachid)
            Me.Dispose()
            donorport.Show()
            frmWelcome.Close()
        End If


    End Sub
End Class