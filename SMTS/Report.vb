Imports System.Data.SqlClient


Public Class Report
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader

    Public email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
    End Sub


    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DS As New DataSet()
            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True")
            connection.Open()
            Dim query As String = "select * from Holdings where email='" & email & "' and Quantity>0"
            command = New SqlCommand(query, connection)
            Dim dataAdapter As New SqlDataAdapter(query, connection)
            dataAdapter.Fill(DS, "Holdings")
            DataGridView1.DataSource = DS
            DataGridView1.DataMember = "Holdings"
            Dim query1 As String = "select sum(pl) from Holdings where email='" & email & "'"
            command = New SqlCommand(query1, connection)
            reader = command.ExecuteReader()
            If reader.Read Then
                Label2.Text = reader(0)
            End If
            reader.Close()
            connection.Close()
        Catch
        End Try

    End Sub

End Class