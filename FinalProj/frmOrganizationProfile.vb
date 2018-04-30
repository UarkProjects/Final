Imports System.Data.SqlClient

Public Class frmOrganizationProfile
    Protected oID As Integer
    Protected db As New db
    Dim OrgName As String
    Dim OrgAddress As String
    Dim webpage As String
    Dim phone As Integer
    Dim username As String
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oID = id

    End Sub

    Private Sub frmOrganizationProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT * FROM OrganizationHeader dh  Join Usernames u on dh.OrganizationID = u.OrgID Join Logins l on u.Username = l.Username WHERE dh.OrganizationID = @user", connection)
        'Dim command As New SqlCommand("SELECT * FROM DonorHeader dh  Join Usernames u on dh.DonorID = u.donorID Join Logins l on u.Username = l.Username WHERE dh.donorID = @user", connection)
        command.Parameters.Add("@user", SqlDbType.Int).Value = oID

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        OrgName = (table.Rows(0).Item(1))
        OrgAddress = (table.Rows(0).Item(2))
        webpage = (table.Rows(0).Item(10))
        phone = (table.Rows(0).Item(6))
        username = (table.Rows(0).Item(13))

        txtwebpage.Text = webpage
        txtOrgName.Text = OrgName
        txtOrgAddress.Text = OrgAddress
        txtPhone.Text = phone

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtPassword.Text <> txtPWConfirm.Text Then
            MsgBox("Password and confirmation does not match")
        Else
            db.sql = "UPDATE OrganizationHeader set OrgName = @OrgName, Address = @OrgAddress, Website = @Webpage, Phone = @phone where OrganizationID = @id"
            db.bind("@OrgName", txtOrgName.Text)
            db.bind("@OrgAddress", txtOrgAddress.Text)
            db.bind("@Webpage", txtwebpage.Text)
            db.bind("@phone", txtPhone.Text)
            db.bind("@id", oID)
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