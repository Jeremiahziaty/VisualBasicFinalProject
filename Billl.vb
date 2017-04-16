Public Class Billl
    Private Sub Billl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet.Billing' table. You can move, or remove it, as needed.
        Me.BillingTableAdapter.Fill(Me.LilypadGardensDataSet.Billing)

    End Sub
End Class