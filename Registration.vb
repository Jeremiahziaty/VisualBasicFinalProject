Imports System.IO
Imports System.IO.File
Public Class Registration
    Dim username As StreamWriter


    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        'write to file

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strSaveFile As String

        errProvider.Clear()
        If dtpVisited.Value.Date <> Today Then
            errProvider.SetError(dtpVisited, "select birthday")
        ElseIf Last_NameTextBox.Text.Length = 0 Then
            errProvider.SetError(Last_NameTextBox, "Name cannot be blank")
        ElseIf First_NameTextBox.Text.Length = 0 Then
            errProvider.SetError(First_NameTextBox, "Name cannot be blank")
            For Each b As RadioButton In gbSex.Controls.OfType(Of RadioButton)()
                If RadFemale.Checked = True Then
                    gbSex.Text = "Femaile"
                ElseIf RadMale.Checked = True Then
                    gbSex.Text = "Male"
                Else
                    errProvider.SetError(gbSex, " blank")
                End If
            Next

        ElseIf dtpBirth.Value.Date >= Today Then
            errProvider.SetError(dtpBirth, "select birthday")
        ElseIf TxtAdress.Text.Length = 0 Then
            errProvider.SetError(TxtAdress, " be blank")
        ElseIf TxtCity.Text.Length = 0 Then
            errProvider.SetError(TxtCity, "be blank")
        ElseIf cboState.SelectedIndex = -1 Then
            errProvider.SetError(cboState, " selected")
        ElseIf txtZip.Text.Length = 0 Then
            errProvider.SetError(txtZip, " be blank")
        ElseIf txtHistory.Text.Length = 0 Then
            errProvider.SetError(txtHistory, " be blank")
        Else
            strSaveFile = "Username.txt"

            'write to file
            username = File.CreateText(strSaveFile)
            username.WriteLine(Last_NameTextBox.Text & "," & First_NameTextBox.Text)
            username.Close()
            Continuing.ShowDialog()
        End If

        ' Try
        '   PatientBindingSource.EndEdit()
        '  PatientTableAdapter.Update(LilypadGardensDataSet.Patient)
        '  Catch ex As Exception
        '  MessageBox.Show(ex.Message, "Error")
        'End Try
    End Sub


    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim states As StreamReader
        states = OpenText("State.txt")
        While Not states.EndOfStream
            Dim statesread As String = states.ReadLine()
            cboState.Items.Add(statesread)
        End While
        states.Close()
        dtpVisited.Value = Today
    End Sub

End Class