Public Class frmUnreg
    Protected db As New db
    Protected oID As Integer
    Protected amount As Integer
    Public Sub New(ByVal OrgID As Integer, ByVal amt As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oID = OrgID
        amount = amt
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        db.sql = "INSERT INTO PaymentMethods(donorID, cardnum, expmo, expyr, cvv) values (@dID, @card, @expmo, @expyr, @cvv)"
        db.bind("@dID", 9)
        db.bind("@card", txtCardNum.Text)
        db.bind("@expmo", txtMonth.Text)
        db.bind("@expyr", txtYear.Text)
        db.bind("@cvv", txtCVV.Text)
        db.execute()
        db.sql = "INSERT INTO Donation_ASC(DonorID, amount, orgid) values (@id, @amt, @orgid)"
        db.bind("@id", 9)
        db.bind("@amt", amount)
        db.bind("@orgid", oID)
        db.execute()
        Me.Close()


    End Sub
End Class