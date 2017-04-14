Public Class AllPatients
    Private Sub AllPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet1.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.LilypadGardensDataSet1.Patient)
        'TODO: This line of code loads data into the 'LilypadGardensDataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.LilypadGardensDataSet.Patient)

    End Sub
End Class