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
    Private Sub loadDonations()
        db.sql = "SELECT da.amount, oh.OrgName, da.Date FROM Donation_ASC da join OrganizationHeader oh on da.OrgID = oh.OrganizationID WHERE amount is not null AND DonorID = @id"
        db.bind("@id", dID)
        db.fill(dgvDonate)
    End Sub
    Private Sub loadVolunteer()
        db.sql = "select HrsVol, e.EventName, da.date from Donation_ASC da join OrganizationHeader oh on da.OrgID = oh.OrganizationID JOIN Events e on e.EventID = da.EventID where HrsVol is not null AND da.DonorID = @id"
        db.bind("@id", dID)
        db.fill(dgvVolunteer)
    End Sub
    Private Sub frmMakeADiff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dID > 0 Then
            loadDonations()
            loadVolunteer()
        End If



    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Me.Close()
        
    End Sub

    Private Sub chkLocal_CheckedChanged(sender As Object, e As EventArgs) Handles chkLocal.CheckedChanged
        If chkLocal.Checked = True Then
            localcheck = 1
        End If
        If chkLocal.Checked = False Then
            localcheck = 0
        End If
    End Sub

    Private Sub chkNationwide_CheckedChanged(sender As Object, e As EventArgs) Handles chkNationwide.CheckedChanged
        If chkNationwide.Checked = True Then
            onYourSide = 1
        End If
        If chkNationwide.Checked = False Then
            onYourSide = 0

        End If
    End Sub
End Class