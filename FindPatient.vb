Public Class FindPatient
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        errProvider.Clear()
        If txtLastName.Text.Length = 0 Then
            errProvider.SetError(txtLastName, "Name cannot be blank")
        ElseIf IsNumeric(txtLastName.Text) Then
            errProvider.SetError(txtLastName, "Name cannot be a number")
        ElseIf IsNumeric(txtBirthday.Text) Then
            errProvider.SetError(txtBirthday, "Please enter numeric quantity")
        ElseIf txtBirthday.Text.Length = 0 Then
            errProvider.SetError(txtBirthday, "birthday cannot be blank")
        Else
            PatientsTableAdapter.FindPatient(LilypadGardensDataSet.Patients, txtLastName.Text, txtBirthday.Text)
        End If



    End Sub

    Private Sub FindPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LilypadGardensDataSet1.Patients' table. You can move, or remove it, as needed.
        ' Me.PatientsTableAdapter.Fill(Me.LilypadGardensDataSet1.Patients)

    End Sub
End Class