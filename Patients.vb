Public Class Patients
    Private adapter As New LilypadGardensDataSetTableAdapters.RegistrationTableAdapter

    Public ReadOnly Property items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData
            'table.DefaultView.Sort = "Patient"
            Return table
        End Get
    End Property


End Class
