Public Class frmLearnMore
    Protected orgID As Integer
    Protected URL As String
    Protected dID As Integer
    Public Sub New(ByVal id As Integer, ByVal site As String, ByVal donID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orgID = id
        URL = site
        dID = donID
    End Sub

    Private Sub frmLearnMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myUri As New Uri(URL)
        webbSite.Url = myUri

    End Sub

    Private Sub ReturnToListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToListToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub DonateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonateToolStripMenuItem.Click
        Me.Close()
        Dim pay As New frmMakePayment(orgID, dID)
        pay.ShowDialog()


    End Sub
End Class