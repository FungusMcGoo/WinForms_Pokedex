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
        If dgv_Stats IsNot Nothing Then
            dgv_Stats.Refresh()
        End If
        '
        'Ensure is not null
        If cmb_Search.SelectedValue IsNot Nothing Then
            Dim selectedPokemonID As Integer = CInt(cmb_Search.SelectedValue)
        End If

        'Query to retrieve Pokemon details
        Dim pkmnstatquery As String = "SELECT * FROM pokedex_data WHERE ID = ID"

        'Init SQL connection and datareader
        Using conSQL As New SqlConnection(conStr)
            Dim cmdSQL As New SqlCommand(pkmnstatquery, conSQL)
            conSQL.Open()
            Dim reader As SqlDataReader = cmdSQL.ExecuteReader()

            'Clear DGV
            dgv_Stats.Rows.Clear()
            rtxt_Description.Clear()
            If reader.Read() Then
                dgv_Stats.Rows.Add("Generation", reader("Generation").ToString())
                dgv_Stats.Rows.Add("Classification", reader("Classification").ToString())
                dgv_Stats.Rows.Add("Height", reader("Height").ToString())
                dgv_Stats.Rows.Add("Weight", reader("Weight").ToString())
                dgv_Stats.Rows.Add("Catch Rate", reader("Capture_rate").ToString())
                dgv_Stats.Rows.Add("HP", reader("HP").ToString())
                dgv_Stats.Rows.Add("Attack", reader("Attack").ToString())
                dgv_Stats.Rows.Add("Defence", reader("Defence").ToString())
                dgv_Stats.Rows.Add("Special Attack", reader("SP_Attack").ToString())
                dgv_Stats.Rows.Add("Special Defence", reader("SP_Defence").ToString())
                dgv_Stats.Rows.Add("Speed", reader("Speed").ToString())
                'rtxt_Description.Text = reader("Description").ToString

            End If

        End Using
    End Sub

    Private Sub cmb_search_KeyDown(sender As Object, e As KeyEventArgs) Handles cmb_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            'CLEAR DGV
            dgv_Stats.Refresh()
            btn_Search.PerformClick()
        End If

    End Sub


End Class
