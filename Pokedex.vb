Imports System.IO
Imports System.Threading
Imports Microsoft.Data.SqlClient
Public Class Pokedex
    'Connection string for local db (db: POKEDEX / table: pokedex_data)
    Dim conStr As String = "Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=POKEDEX;"
    'Populate search bar (cmb_Search) with pokedex_data from SQL database
    Private Sub loadPkmnData(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_Search.Focus()
        Dim pkmnquery = "SELECT ID, Name FROM pokedex_data"
        'Connect to SQL database using connection string
        Using conSQL As New SqlConnection(conStr)
            Dim cmdSQL As New SqlCommand(pkmnquery, conSQL)
            conSQL.Open()
            Dim reader As SqlDataReader = cmdSQL.ExecuteReader()

            'Datatable to store pokemon data
            Dim dt As New DataTable()
            dt.Load(reader)

            'Set CB DisplayMember = Name and ValueMember = ID
            cmb_Search.DataSource = dt
            cmb_Search.DisplayMember = "Name"
            cmb_Search.ValueMember = "ID"

            conSQL.Close()
        End Using
    End Sub


    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        If cmb_Search.SelectedValue IsNot Nothing Then
            Dim selectedPokemonID As Integer = CInt(cmb_Search.SelectedValue)
            'Query to retrieve Pokemon details fromn dbo.pokedex_data using the pokemons ID as primary key 
            Dim pkmnstatquery As String = "SELECT * FROM pokedex_data WHERE ID = @ID"

            'Init SQL connection and datareader search parameter
            Using conSQL As New SqlConnection(conStr)
                Dim cmdSQL As New SqlCommand(pkmnstatquery, conSQL)
                cmdSQL.Parameters.AddWithValue("@ID", selectedPokemonID)
                conSQL.Open()
                Dim reader As SqlDataReader = cmdSQL.ExecuteReader()

                'Clear Stats/Description
                dgv_Stats.Rows.Clear()
                rtxt_Description.Clear()

                'Populate stats
                If reader.Read() Then
                    dgv_Stats.Rows.Add("Generation", reader("Generation").ToString())
                    dgv_Stats.Rows.Add("Classification", reader("Classification").ToString())
                    dgv_Stats.Rows.Add("Height (m)", reader("Height").ToString())
                    dgv_Stats.Rows.Add("Weight (kg)", reader("Weight").ToString())
                    dgv_Stats.Rows.Add("Catch Rate", reader("Capture_rate").ToString())
                    dgv_Stats.Rows.Add("HP", reader("HP").ToString())
                    dgv_Stats.Rows.Add("Attack", reader("Attack").ToString())
                    dgv_Stats.Rows.Add("Defence", reader("Defence").ToString())
                    dgv_Stats.Rows.Add("Special Attack", reader("SP_Attack").ToString())
                    dgv_Stats.Rows.Add("Special Defence", reader("SP_Defence").ToString())
                    dgv_Stats.Rows.Add("Speed", reader("Speed").ToString())
                    rtxt_Name.Text = reader("Name").ToString
                    'rtxt_Description.Text = reader("Description").ToString
                End If
            End Using
        End If
    End Sub

    'Enter key functionality for search
    Private Sub cmb_search_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Search.PerformClick()
        End If
    End Sub
End Class
