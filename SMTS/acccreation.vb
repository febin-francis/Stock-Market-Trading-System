Imports System.Data.SqlClient
Public Class acccreation

    Dim Con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Missing Information")
        ElseIf TextBox2.Text.IndexOf("@") = -1 Then
            MessageBox.Show("Invalid EmailId!")
        ElseIf TextBox2.Text.IndexOf(".") = -1 Then
            MessageBox.Show("Invalid EmailId!")
        ElseIf TextBox3.Text.Length <> 10 Then
            MessageBox.Show("Invalid Phone no")
        ElseIf TextBox4.Text.Length <> 12 Then
            MessageBox.Show("Invalid Aadhar no")
        Else
            Try
                Dim Bal = 0
                Con.Open()
                Dim query = "insert into UserDetails values('" & TextBox2.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                Dim query_w = "insert into Wallet values('" & TextBox2.Text & "','" & 0 & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand(query_w, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Account Added")
                Dim obj = New login
                Me.Hide()
                obj.Show()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New login
        Me.Hide()
        obj.Show()
    End Sub

End Class