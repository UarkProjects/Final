Imports System.Data.SqlClient
Public Class frmMakePayment
    Protected dID As Integer
    Protected oID As Integer
    Protected db As New db
    Public Sub New(ByVal orgID As Integer, donID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oID = orgID
        dID = donID

    End Sub

    Private Sub loadCards()
        db.sql = "SELECT * FROM PaymentMethods where donorid = @id"
        db.bind("@id", dID)
        db.fill(dgvCards)
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub frmMakePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("SELECT OrgName FROM OrganizationHeader WHERE organizationid = @id", connection)
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = oID


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Wrong password")
        Else
            Dim OrgName = (table.Rows(0).Item(0))
            txtOrgName.Text = OrgName

        End If
        If dID > 0 Then
            loadCards()
        ElseIf dID = 0 Then
            dgvCards.Visible = False
            lblSelectCard.Visible = False
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If dID > 0 Then
            db.sql = "INSERT INTO Donation_ASC(DonorID, amount, orgid) values (@dID, @amt, @orgid)"
            db.bind("@dID", dID)
            db.bind("@amt", txtAmount.Text)
            db.bind("@orgid", oID)
            db.execute()
            Me.Close()
        ElseIf dID = 0 Then
            Dim unreg As New frmUnreg(oID, txtAmount.Text)
            unreg.ShowDialog()

        End If
    End Sub
End Class