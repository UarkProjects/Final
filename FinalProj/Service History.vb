Imports System.Data.SqlClient
Public Class frmServiceHistory
    Protected donID As Integer
    Protected Datee As Date = Date.Today
    Protected year As Integer = Datee.Year
    Protected db As New db
    Public Sub New(ByVal id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        donID = id
    End Sub
    Private Sub frmServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select sum(da.HrsVol), dh.FirstName, dh.LastName From Donation_ASC da join DonorHeader dh on da.DonorID = dh.DonorID Where da.DonorID = @did group by dh.FirstName, dh.LastName ", connection)
        command.Parameters.Add("@did", SqlDbType.Int).Value = donID
        command.Parameters.Add("@year", SqlDbType.Int).Value = year


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            'MsgBox("Bug test")
            lblCurrentYearDonations.Text = "UserID " & donID & "current year " & year
        Else
            Dim Donorhrs = (table.Rows(0).Item(0))
            Dim firstName = (table.Rows(0).Item(1))
            Dim LastName = (table.Rows(0).Item(2))
            lblName.Text = firstName & " " & LastName
            'Dim donorport As New frmDonorPortal(Donorid, donorname)
            lblTotalDonations.Text = " Total Volunteer Hours: " & Donorhrs

            Dim connection1 As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
            Dim command1 As New SqlCommand("select * from DonationSummary Where DonorID = @did AND year = @year", connection1)
            command1.Parameters.Add("@did", SqlDbType.Int).Value = donID
            command1.Parameters.Add("@year", SqlDbType.Int).Value = year


            Dim adapter1 As New SqlDataAdapter(command1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            Dim donorhrsyear = (table1.Rows(0).Item(2))
            lblCurrentYearDonations.Text = year & " Hours Volunteered: " & donorhrsyear
            'lblCurrentYearDonations.Text = "This is the current year total" & donorhrsyear
        End If
        db.sql = "SELECT oh.OrgName, e.EventName, HrsVol FROM Donation_ASC da join OrganizationHeader oh on da.OrgID = oh.OrganizationID join Events e on da.EventID = e.EventID WHERE HrsVol is not null AND da.DonorID = @id"
        db.bind("@id", donID)
        db.fill(DataGridView1)
    End Sub
End Class