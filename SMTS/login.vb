Imports System.Data.SqlClient
Public Class login
    Public cmd As SqlCommand
    Public Reader As SqlDataReader
    Public connection As SqlConnection = New SqlConnection()
    Public Email As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True"
        connection.Open()
        If TextBox2.Text.IndexOf("@") = -1 Then
            MessageBox.Show("Invalid EmailId")
        Else
            Dim query As String = "SELECT * FROM UserDetails WHERE Email = '" & TextBox2.Text & "' AND Password = '" & TextBox3.Text & "' "
            cmd = New SqlCommand(query, connection)
            Reader = cmd.ExecuteReader
            If Reader.Read Then
                Me.Hide()
                Dim vm As New visitmarket(TextBox2.Text)
                vm.Show()
                Reader.Close()
                connection.Close()
            Else
                MessageBox.Show("Unauthorize Access")
                TextBox3.Text = ""
                TextBox2.Text = ""
                Reader.Close()
            End If
            Reader.Close()
            connection.Close()
        End If
        
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ac As New acccreation
        With ac
            .TopLevel = False
            Panel3.Controls.Add(ac)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True"
        connection.Open()
        Dim query As String = "SELECT * FROM Admin WHERE Admin_ID = '" & TextBox2.Text & "' AND Password = '" & TextBox3.Text & "' "
        cmd = New SqlCommand(query, connection)
        Reader = cmd.ExecuteReader
        If Reader.Read Then
            Me.Hide()
            Dim ad As New Admin
            ad.Show()
            Reader.Close()
            connection.Close()
        Else
            MessageBox.Show("Unauthorize Access")
            TextBox3.Text = ""
            TextBox2.Text = ""
            Reader.Close()
        End If
        Reader.Close()
        connection.Close()
    End Sub

End Class
