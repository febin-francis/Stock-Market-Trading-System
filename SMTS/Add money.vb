Imports System.Data.SqlClient
Public Class Add_money
    Public email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
        Label3.Text = mailid
    End Sub
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("ERROR")
        ElseIf IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
            Try
                Con.Open()
                Dim query = "update Wallet set Amount=Amount+'" & TextBox1.Text & "' WHERE Email='" & email & "'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Success")
                Con.Close()

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