Public Class frmCardEntry
    Protected db As New db
    Protected dID As Integer
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dID = id
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        db.sql = "INSERT INTO PaymentMethods values (@id, @cardnum, @mo, @yr, @cvv)"
        db.bind("@id", dID)
        db.bind("@cardnum", txtCardNum.Text)
        db.bind("@mo", txtMonth.Text)
        db.bind("@yr", txtYear.Text)
        db.bind("@cvv", txtCVV.Text)
        db.execute()
        MsgBox("Card added!")
        Me.Close()

    End Sub
End Class