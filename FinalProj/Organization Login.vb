Imports System.Data.SqlClient
Public Class frmOrganizationLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM Logins l join usernames u on l.username = u.username where l.username = @user AND l.password = @pass AND u.orgid is not null", connection)
        command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Dim orgid = (table.Rows(0).Item(5))
            Dim orgport As New frmOrganizationPortal(orgid)
            Me.Dispose()
            orgport.Show()

            frmWelcome.Close()
            Me.Close()

        End If
    End Sub

    Private Sub frmOrganizationLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class