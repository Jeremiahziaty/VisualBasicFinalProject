Imports System.IO
Imports System.Data.SqlClient
Public Class Continuing
    Dim username As StreamReader
    Dim strInputFile As String = "Username.txt"
    Private Sub Continuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        If System.IO.File.Exists(strInputFile) Then
            'Open the file.
            username = File.OpenText(strInputFile)
        Else
            MessageBox.Show("File does not exist.")
        End If
        'Read from File
        txtName.Text = username.ReadLine
        If chkOther.Checked = True Then
            txtOther.Enabled = True
            gbSymptoms.Text = "Other" & txtOther.Text
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim msg As String = ""

        If chcksportphysical.Checked = True Then
            gbSymptoms.Text = "Sport Physical"
        End If
        If chkcheckup.Checked = True Then
                gbSymptoms.Text = "Check Up"
            End If
            If chkHeadach.Checked = True Then
                gbSymptoms.Text = "Headach"

            End If
            If chkjointpain.Checked = True Then
                gbSymptoms.Text = "Joint Pain"

            End If
            If chkMuscularPain.Checked = True Then
                gbSymptoms.Text = "Musculaer Pain"

            End If
            If chkPregnancy.Checked = True Then
                gbSymptoms.Text = "Pregnancy"

            End If
            If chkRespiratory.Checked = True Then
                gbSymptoms.Text = "Repiratory"

            End If
            If chkSkin.Checked = True Then
                gbSymptoms.Text = "Skin"

            End If
            If chkSneezing.Checked = True Then
                gbSymptoms.Text = "Sneezing"
            End If
            If chkUnary.Checked = True Then
            gbSymptoms.Text = "unary"
        End If

        If Registration.RadFemale.Checked = True Then
            Registration.gbSex.Text = "Femaile"
        ElseIf Registration.RadMale.Checked = True Then
            Registration.gbSex.Text = "Male"
        End If

        Try
            PatientBindingSource.EndEdit()
            PatientTableAdapter.Update(LilypadGardensDataSet.Patient)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        Try
            PatientTableAdapter.Insert(Registration.Last_NameTextBox.Text, Registration.First_NameTextBox.Text, Registration.gbSex.Text, Registration.TxtAdress.Text, Registration.TxtCity.Text, Registration.cboState.Text, CDec(Registration.txtZip.Text), Registration.PhoneTextBox.Text, CDate(Registration.dtpBirth.Text), Registration.txtSSN.Text, gbSymptoms.Text, CDate(Registration.dtpVisited.Text),
                                       Registration.txtHistory.Text)
            Me.PatientTableAdapter.Fill(Me.LilypadGardensDataSet.Patient)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
        End Try
        PatientBindingSource.AddNew()
        'Try
        '    PatientBindingSource.EndEdit()
        '    PatientTableAdapter.Update(LilypadGardensDataSet.Patient)
        '    Me.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error")
        'End Try
    End Sub

End Class