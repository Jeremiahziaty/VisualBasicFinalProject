Public Class PatientsLog
    Private mPatient As New Patients
    Private formLoading As Boolean = True
    Private Sub PatientsLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet.Patient' table. You can move, or remove it, as needed.
        ' Me.PatientTableAdapter.Fill(Me.LilypadGardensDataSet.Patient)
        Me.RegistrationTableAdapter.Fill(Me.LilypadGardensDataSet.Registration)

        ' Me.RegistrationBindingSource.DataSource = Me.LilypadGardensDataSet
        ' Me.RegistrationBindingSource.DataMember = "Registration"


        With CboPatient.ComboBox
            .DataSource = mPatient.items
            .DisplayMember = "Patient"
            .ValueMember = "PatientId"
            .DropDownStyle = ComboBoxStyle.DropDownList
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPatient.SelectedIndexChanged
        Me.RegistrationBindingSource.Position = Me.CboPatient.SelectedIndex
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class