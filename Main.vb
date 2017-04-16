Public Class Main
    Private Sub tlsListAll_Click(sender As Object, e As EventArgs) Handles tlsListAll.Click
        AllPatients.ShowDialog()
    End Sub

    Private Sub tlsFindPatient_Click(sender As Object, e As EventArgs) Handles tlsFindPatient.Click
        FindPatient.ShowDialog()
    End Sub

    Private Sub AddNewPatient_Click(sender As Object, e As EventArgs) Handles AddNewPatient.Click
        Registration.ShowDialog()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RegisterationSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterationSlipToolStripMenuItem.Click
        PatientsLog.ShowDialog()
    End Sub

    Private Sub BillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillToolStripMenuItem.Click
        Billl.ShowDialog()
    End Sub
End Class
