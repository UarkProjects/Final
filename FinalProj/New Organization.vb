Imports System.Data.SqlClient
Public Class frmNewOrganization
    Protected db As New db
    Protected maxid As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtWebsite.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAddress.Clear()
        txtCause.Clear()
        txtCity.Clear()
        txtDescription.Clear()
        txtFoundingDate.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtState.Clear()
        txtWebsite.Clear()
        txtZip.Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAddress.Text.Length = 0 Then
            MsgBox("Address cannot be empty")
        ElseIf txtCause.Text.Length = 0 Then
            MsgBox("You cannot leave main cause empty")
        ElseIf txtCity.Text.Length = 0 Then
            MsgBox("You must enter a city")
        ElseIf txtDescription.Text.Length = 0 Then
            MsgBox("Please enter a description for your organization")
        ElseIf txtFoundingDate.Text.Length = 0 Then
            MsgBox("Please enter the date of the organizations founding")
        ElseIf txtName.Text.Length = 0 Then
            MsgBox("PLease enter the name of your organiztion")
        ElseIf txtPhone.Text.Length = 0 Then
            MsgBox("Please enter a phone number")
        ElseIf txtState.Text.Length = 0 Then
            MsgBox("Please enter your state abbreviation")
        ElseIf txtWebsite.Text.Length = 0 Then
            MsgBox("Please enter your website")
        ElseIf txtZip.Text.Length = 0 Then
            MsgBox("Please enter your zipcode")
        ElseIf txtPW.Text.Length = 0 Then
            MsgBox("Please enter a password")
        ElseIf txtPW.Text <> TextBox1.Text Then
            MsgBox("Password and confirmation do not match")
        Else
            db.sql = "INSERT INTO OrganizationHeader(orgname, address, city, state, zipcode, phone, maincause, description, foundationdate, website) values (@name, @address, @city, @state, @zip, @phone, @cause, @desc, @found, @site)"
            db.bind("@name", txtName.Text)
            db.bind("@address", txtAddress.Text)
            db.bind("@city", txtCity.Text)
            db.bind("@state", txtState.Text)
            db.bind("@zip", txtZip.Text)
            db.bind("@phone", txtPhone.Text)
            db.bind("@cause", txtCause.Text)
            db.bind("@desc", txtDescription.Text)
            db.bind("@found", txtFoundingDate.Text)
            db.bind("@site", txtWebsite.Text)
            db.execute()
            Dim username As String = txtName.Text
            getMaxOrgID()
            db.sql = "INSERT INTO Usernames(username, type, orgid) values (@username, @type, @orgid)"
            db.bind("@username", username)
            db.bind("@type", "Org")
            db.bind("@orgid", maxid)
            db.execute()


            db.sql = "INSERT INTO logins(username, password) values (@user, @pw)"
            db.bind("@user", username)
            db.bind("@pw", txtPW.Text)
            db.execute()


        End If

    End Sub
    Private Sub getMaxOrgID()
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT MAX(OrganizationID) FROM OrganizationHeader", connection)


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