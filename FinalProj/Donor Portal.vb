Public Class frmDonorPortal
    Protected db As New db
    Protected DonID As Integer
    Protected finame As String
    Public Sub New(ByVal dID As Integer, ByVal fname As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DonID = dID
        finame = fname
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        frmWelcome.Show()
        Me.Dispose()
    End Sub

    Private Sub btnDonationHistory_Click(sender As Object, e As EventArgs) Handles btnDonationHistory.Click
        Dim donateHist As New frmDonationHistory(DonID)
        donateHist.ShowDialog()

    End Sub

    Private Sub btnServiceHistory_Click(sender As Object, e As EventArgs) Handles btnServiceHistory.Click
        Dim servHist As New frmServiceHistory(DonID)
        servHist.ShowDialog()

    End Sub

    Private Sub btnMakeADifference_Click(sender As Object, e As EventArgs) Handles btnMakeADifference.Click
        frmMakeADiff.ShowDialog()
    End Sub

    Private Sub DonorProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DonorProfileToolStripMenuItem.Click
        frmDonorProfile.ShowDialog()
    End Sub

    Private Sub frmDonorPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblGreeting.Text = "Welcome, " & finame

    End Sub
End Class