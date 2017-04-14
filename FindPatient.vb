Public Class FindPatient
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        errProvider.Clear()
        If txtLastName.Text.Length = 0 Then
            errProvider.SetError(txtLastName, "Name cannot be blank")
        ElseIf IsNumeric(txtLastName.Text) Then
            errProvider.SetError(txtLastName, "Name cannot be a number")
        ElseIf IsNumeric(txtBirthday.Text) Then
            errProvider.SetError(txtBirthday, "Please enter a Date")
        ElseIf txtBirthday.Text.Length = 0 Then
            errProvider.SetError(txtBirthday, "birthday cannot be blank")
        Else
            PatientTableAdapter.FindPatient(LilypadGardensDataSet.Patient, txtLastName.Text, txtBirthday.Text)
        End If


    End Sub

End Class