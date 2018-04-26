Imports System.Data.SqlClient
Public Class frmDonationHistory
    Protected donID As Integer
    Protected Datee As Date = Date.Today
    Protected year As Integer = Datee.Year
    Public Sub New(ByVal Did As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        donID = Did
    End Sub
    Private Sub frmDonationHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
        Dim command As New SqlCommand("Select * From donationSummary Where DonorID = @did AND year = @year", connection)
        command.Parameters.Add("@did", SqlDbType.Int).Value = donID
        command.Parameters.Add("@year", SqlDbType.Int).Value = year


        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            MsgBox("Bug test")
            lblCurrentYearDonations.Text = "UserID " & donID & "current year " & year
        Else
            Dim Donoramt = (table.Rows(0).Item(1))
            Dim donorhrs = (table.Rows(0).Item(2))
            'Dim donorport As New frmDonorPortal(Donorid, donorname)
            lblCurrentYearDonations.Text = year & " Donations: " & Donoramt
            Dim connection1 As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283f1759; Trusted_Connection=yes"}
            Dim command1 As New SqlCommand("Select SUM(amount) from donation_asc Where DonorID = @did", connection)
            command1.Parameters.Add("@did", SqlDbType.Int).Value = donID
            Dim adapter1 As New SqlDataAdapter(command1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            Dim totalamt = (table1.Rows(0).Item(0))

            lblTotalDonations.Text = "Total Donations $" & totalamt
        End If
    End Sub
End Class