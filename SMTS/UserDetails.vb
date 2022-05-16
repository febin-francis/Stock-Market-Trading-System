Imports System.Data.SqlClient

Public Class UserDetails
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader

    Private Sub UserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DS As New DataSet()
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True")
        connection.Open()
        Dim query As String = "select * from UserDetails"
        command = New SqlCommand(query, connection)
        Dim dataAdapter As New SqlDataAdapter(query, connection)
        dataAdapter.Fill(DS, "UserDetails")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "UserDetails"
        reader = command.ExecuteReader()
        reader.Close()
        connection.Close()
    End Sub
End Class