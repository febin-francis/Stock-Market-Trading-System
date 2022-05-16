Imports System.Data.SqlClient

Public Class profile
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim balance As Integer
    Public Property email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        Label3.Text = mailid
        email = mailid

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New Add_money(email)
        obj.Show()
    End Sub



    Private Sub profile_Load(sender As Object, e As EventArgs) Handles Me.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf")
        connection.Open()
        Dim query As String = "select Amount from Wallet where  email='" & email & "'"
        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader()
        If reader.Read Then
            Label4.Text = reader(0)
            reader.Close()
        End If
        Dim query2 As String = "select Name,Phone,Aadhar from UserDetails where email='" & email & "'"
        command = New SqlCommand(query2, connection)
        reader = command.ExecuteReader()
        If reader.Read Then
            Label5.Text = reader(0)
            Label6.Text = reader(1)
            Label7.Text = reader(2)
            reader.Close()
        End If
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim wm As New Withdraw_Money(email)
        wm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Open()
        Dim query1 As String = "select Amount from Wallet where  email='" & email & "'"
        command = New SqlCommand(query1, connection)
        reader = command.ExecuteReader()
        If reader.Read Then
            Label4.Text = reader(0)
            reader.Close()
        End If
        connection.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim lg As New login
        lg.Show()
    End Sub
End Class