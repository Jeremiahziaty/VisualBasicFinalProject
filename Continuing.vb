﻿Imports System.IO
Public Class Continuing
    Dim username As StreamReader
    Dim strInputFile As String = "Username.txt"
    Private Sub Continuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(strInputFile) Then
            'Open the file.
            username = File.OpenText(strInputFile)
        Else
            MessageBox.Show("File does not exist.")
        End If
        'Read from File
        txtName.Text = username.ReadLine
    End Sub

End Class