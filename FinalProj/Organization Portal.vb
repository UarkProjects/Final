Imports System.Data.SqlClient


Public Class frmOrganizationPortal
    Protected db As New db
    Protected orgid As Integer

    Public Sub New(ByVal oID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orgid = oID
    End Sub

    Private Sub frmOrganizationPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT OrgName FROM OrganizationHeader WHERE OrganizationID = @ID", connection)
        command.Parameters.Add("@ID", SqlDbType.VarChar).Value = orgid
        'command.Parameters.Add("@pass", SqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Dim orgname = (table.Rows(0).Item(0))

            lblOrgName.Text = "Welcome, " & orgname

        End If

    End Sub

    Private Sub LogoffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        frmWelcome.Show()
        Me.Dispose()
    End Sub

    Private Sub OrganizationProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizationProfileToolStripMenuItem.Click
        Dim portal As New frmOrganizationProfile(orgid)
        portal.ShowDialog()

    End Sub

    Private Sub btnNewServiceEvent_Click(sender As Object, e As EventArgs) Handles btnNewServiceEvent.Click

    End Sub
End Class