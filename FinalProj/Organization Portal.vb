Public Class frmOrganizationPortal
    Protected db As New db
    Protected orgid As Integer

    Public Sub New(ByVal oID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        orgid = oID
    End Sub
End Class