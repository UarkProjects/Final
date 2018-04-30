Imports System.Data.SqlClient
Public Class frmNewDonor
    Protected db As New db
    Dim maxID As Integer

    Private Sub brnClear_Click(sender As Object, e As EventArgs) Handles brnClear.Click
        txtFName.Clear()
        txtLName.Clear()

        txtPhone.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFName.Text.Length = 0 Then
            MsgBox("First name cannot be empty")
        ElseIf txtLName.Text.Length = 0 Then
            MsgBox("Last name cannot be empty")
        ElseIf txtEmail.Text.Length = 0 Then
            MsgBox("Email cannot be empty")
        ElseIf txtPhone.Text.Length = 0 Then
            MsgBox("Phone number cannot be empty")
        ElseIf IsNumeric(txtPhone.Text) = False Then
            MsgBox("Phone number must be numeric")
        ElseIf txtPassword.Text.Length = 0 Then
            MsgBox("Please enter a password")
        ElseIf txtPassword.Text <> TextBox1.Text Then
            MsgBox("Password does not match")
        Else
            db.sql = "INSERT INTO DonorHeader(firstname, lastname, emailaddress, phone) values (@fname, @lname, @email, @phone)"
            db.bind("@fname", txtFName.Text)
            db.bind("@lname", txtLName.Text)
            db.bind("@email", txtEmail.Text)
            db.bind("@phone", txtPhone.Text)
            db.execute()
            Dim username As String = txtFName.Text.Substring(0, 2) & txtLName.Text.Substring(0, 2)
            getMaxDonorID()
            db.sql = "INSERT INTO Usernames(username, type, donorid) values (@user, @type, @diD)"
            db.bind("@user", username)
            db.bind("@type", "Don")
            db.bind("@diD", maxID)
            db.execute()
            db.sql = "INSERT INTO Logins(username, password) values (@username, @pw)"
            db.bind("@username", username)
            db.bind("@pw", txtPassword.Text)
            db.execute()
            MsgBox("Your username is " & username)
            Me.Close()
        End If


    End Sub
    Private Sub getMaxDonorID()
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT MAX(DonorID) FROM DonorHeader", connection)


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            maxID = (table.Rows(0).Item(0))
        End If
    End Sub
End Class