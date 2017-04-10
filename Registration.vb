Imports System.IO

Public Class Registration
    Dim username As StreamWriter

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        'write to file

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strSaveFile As String

        If Last_NameTextBox.Text = "" = True Then
            MessageBox.Show("please enter a name")
        Else
            strSaveFile = "Username.txt"
        End If
        'write to file
        username = File.CreateText(strSaveFile)
        username.WriteLine(Last_NameTextBox.Text & "," & First_NameTextBox.Text)
        username.Close()
        Continuing.ShowDialog()
    End Sub
End Class