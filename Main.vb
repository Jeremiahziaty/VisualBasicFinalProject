Public Class Main
    Private Sub tlsListAll_Click(sender As Object, e As EventArgs) Handles tlsListAll.Click
        AllPatients.ShowDialog()
    End Sub

    Private Sub tlsFindPatient_Click(sender As Object, e As EventArgs) Handles tlsFindPatient.Click
        FindPatient.ShowDialog()
    End Sub
End Class
