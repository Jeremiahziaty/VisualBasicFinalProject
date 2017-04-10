Public Class FindPatient
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Me.PatientsTableAdapter.FindPatient(LilypadGardensDataSet.Patients, txtLastName.Text, txtBirthday.Text)
    End Sub

    Private Sub FindPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet1.Patients' table. You can move, or remove it, as needed.
        ' Me.PatientsTableAdapter.Fill(Me.LilypadGardensDataSet1.Patients)

    End Sub
End Class