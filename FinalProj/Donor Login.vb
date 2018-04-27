Imports System.Data.SqlClient
Public Class frmDonorLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select l.username, l.password, d.DonorID, d.FirstName from Logins l join Usernames u on l.Username = u.Username join DonorHeader d on u.donorID = d.DonorID where l.username = @user AND l.password = @pass AND u.donorid is not null", connection)
        command.Parameters.Add("@user", SqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Dim Donorid = (table.Rows(0).Item(2))
            Dim donorname = (table.Rows(0).Item(3))
            Dim donorport As New frmDonorPortal(Donorid, donorname)

            Me.Dispose()
            donorport.Show()
            frmWelcome.Close()
        End If


    End Sub
End Class