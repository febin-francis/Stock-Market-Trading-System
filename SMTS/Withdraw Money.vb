Imports System.Data.SqlClient

Public Class Withdraw_Money
    Dim command As SqlCommand
    Dim command1 As SqlCommand
    Dim connection As SqlConnection
    Dim reader As SqlDataReader
    Dim balance As Integer

    Public email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
        Label3.Text = mailid
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf")
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("ERROR")
        ElseIf IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Try
                connection.Open()
                Dim query1 As String = "select Amount from Wallet where email='" & email & "'"
                command1 = New SqlCommand(query1, connection)
                reader = command1.ExecuteReader()
                If reader.Read Then
                    balance = reader(0)
                    reader.Close()
                    If (TextBox1.Text > balance) Then
                        MessageBox.Show("Insufficient Balance")
                    Else
                        Dim query As String = "update Wallet set Amount=Amount-'" & TextBox1.Text & "' WHERE Email='" & email & "'"
                        command = New SqlCommand(query, connection)
                        command.ExecuteNonQuery()
                        MessageBox.Show("Amount Withdrawn")
                        connection.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("ERROR")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class