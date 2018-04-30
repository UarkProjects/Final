Public Class frmLearnMore
    Protected orgID As Integer
    Protected URL As String
    Public Sub New(ByVal id As Integer, ByVal site As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orgID = id
        URL = site
    End Sub

    Private Sub frmLearnMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myUri As New Uri(URL)
        webbSite.Url = myUri

    End Sub
End Class