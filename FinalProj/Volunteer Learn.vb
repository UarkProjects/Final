Public Class frmVolLearn
    Protected donID As Integer
    Protected orgId As Integer
    Protected eventID As Integer
    Protected db As New db
    Protected url As String

    Public Sub New(ByVal eID As Integer, ByVal oID As Integer, ByVal dID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        donID = dID
        orgId = oID
        eventID = eID


    End Sub


    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub VolunteerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolunteerToolStripMenuItem.Click
        Dim hours As Integer = 0
        hours = InputBox("Enter the amount of hours volunteering", "Volunteer entry")
        If hours = vbNull Then
            Me.Close()
        Else
            If donID = 0 Then
                donID = 9
            End If
            db.sql = "INSERT INTO Donation_ASC(donorID, hrsvol, eventid, orgid) values (@dID, @hrs, @eID, @oID)"
            db.bind("@dID", donID)
            db.bind("@hrs", hours)
            db.bind("@eID", eventID)
            db.bind("@oID", orgId)
            db.execute()
            MsgBox("Thank you for volunteering your time")
            Me.Close()
        End If


    End Sub
End Class