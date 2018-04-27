Imports System.Data.SqlClient
Public Class frmDonorProfile
    Protected dID As Integer
    Protected db As New db
    Dim fname As String
    Dim lname As String
    Dim email As String
    Dim phone As Integer
    Dim username As String

    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dID = id
    End Sub
    Private Sub frmDonorProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM DonorHeader dh  Join Usernames u on dh.DonorID = u.donorID Join Logins l on u.Username = l.Username WHERE dh.donorID = @user", connection)
        command.Parameters.Add("@user", SqlDbType.Int).Value = dID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        fname = (table.Rows(0).Item(1))
        lname = (table.Rows(0).Item(2))
        email = (table.Rows(0).Item(3))
        phone = (table.Rows(0).Item(4))
        username = (table.Rows(0).Item(5))

        txtEmail.Text = email
        txtFName.Text = fname
        txtLName.Text = lname
        txtPhone.Text = phone

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text <> txtPWConfirm.Text Then
            MsgBox("Password and confirmation does not match")
        Else
            db.sql = "UPDATE DonorHeader set Firstname = @fname, lastname = @last, emailaddress = @email, phone = @phone where donorID = @id"
            db.bind("@fname", txtFName.Text)
            db.bind("@last", txtLName.Text)
            db.bind("@email", txtEmail.Text)
            db.bind("@phone", txtPhone.Text)
            db.bind("@id", dID)
            db.execute()
            If txtPassword.Text.Length > 0 Then
                db.sql = "UPDATE Logins set password = @pass where username = @user"
                db.bind("@pass", txtPassword.Text)
                db.bind("@user", username)
                db.execute()

            End If
            Me.Close()

        End If



    End Sub
End Class