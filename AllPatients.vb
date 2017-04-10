Public Class AllPatients
    Private Sub AllPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet1.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.LilypadGardensDataSet1.Patients)
        'TODO: This line of code loads data into the 'LilypadGardensDataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter.Fill(Me.LilypadGardensDataSet.Patients)

    End Sub


End Class