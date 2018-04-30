Public Class frmMakeADiff
    Protected dID As Integer
    Protected db As New db
    Protected localcheck As Integer
    Protected onYourSide As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dID = id
    End Sub

    Private Sub loadAllOrgs()
        db.sql = "SELECT OrgName, MainCause, FoundationDate, website, OrganizationID FROM OrganizationHeader"
        db.fill(dgvDonate)

    End Sub
    Private Sub loadEvents()
        db.sql = "SELECT oh.OrgName, e.EventName, e.Address, e.City, e.State, e.Zipcode, e.EventID FROM EVENTS e join OrganizationHeader oh on e.OrgID = oh.OrganizationID"
        db.fill(dgvVolunteer)

    End Sub
    Private Sub frmMakeADiff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadAllOrgs()
        loadEvents()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim learn As New frmLearnMore(getOrgID(), getOrgValue("Website"), dID)
        learn.ShowDialog()

    End Sub
    Public Function getOrgID() As Integer
        Return getOrgValue("OrganizationID")
    End Function
    Public Function getOrgValue(ByVal column As String)
        Return dgvDonate.Item(column, dgvDonate.CurrentRow.Index).Value
    End Function
    Public Function getVolID() As Integer
        Return getVolValue("EventID")
    End Function
    Public Function getVolValue(ByVal column As String)
        Return dgvVolunteer.Item(column, dgvDonate.CurrentRow.Index).Value
    End Function

    Private Sub btnVolunteer_Click(sender As Object, e As EventArgs) Handles btnVolunteer.Click
        Dim vol As New frmVolLearn(getVolID, getOrgID, dID)
        vol.ShowDialog()

    End Sub


End Class