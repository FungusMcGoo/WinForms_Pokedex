Imports Microsoft.Data.SqlClient

Public Class Pokedex
    Dim conStr As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=POKEDEX;"

    'Populate search bar with pokedex_data from SQL database
    Private Sub loadPkmnData(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pkmnquery = "SELECT ID, Name FROM pokedex_data"

        Using conSQL As New SqlConnection(conStr)
            Dim cmdSQL As New SqlCommand(pkmnquery, conSQL)
            conSQL.Open()

            Dim reader As SqlDataReader = cmdSQL.ExecuteReader()
            While reader.Read()
                cmb_Search.Items.Add(reader("ID") & " - " & reader("Name"))
            End While
            conSQL.Close()
        End Using
    End Sub
End Class
