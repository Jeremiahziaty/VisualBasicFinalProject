Public Class Patients
    Private adapter As New LilypadGardensDataSetTableAdapters.RegistrationTableAdapter

    Public ReadOnly Property items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData
            'table.DefaultView.Sort = "Patient"
            Return table
        End Get
    End Property

    Public Function GetByCustomerId(ByVal custId As Short) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "patientId =" & custId
        Return table
    End Function


End Class
