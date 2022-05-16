Imports System.Data.SqlClient
Imports System.IO

Public Class sellstock
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim ex_quantity As Integer

    Public email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
    End Sub
    Private Sub sellstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf")
        connection.Open()
        Dim query As String = "select Amount from Wallet where  email='" & email & "'"
        Dim query1 As String = "select Stock_Name from Holdings where Quantity > 0 and email='" & email & "'"
        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader()
        If reader.Read Then
            Label1.Text = reader(0)
            reader.Close()
        End If
        command = New SqlCommand(query1, connection)
        Dim reader1 As SqlDataReader
        reader1 = command.ExecuteReader()

        While reader1.Read
            ListBox1.Items.Add(reader1("Stock_Name"))

        End While
        reader1.Close()
        connection.Close()


    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Chart1.Series(0).Points.Clear()
        Catch ex As Exception

        End Try
        connection.Open()
        Dim query = "select * from Stocks where Stock_Name='" & ListBox1.SelectedItem & "'"
        Dim query2 = "select Quantity from Holdings where Stock_Name='" & ListBox1.SelectedItem & "' and email='" & email & "'"

        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader()
        While reader.Read
            Me.Chart1.Series("Sell Price").Points.AddXY("week1", reader("Old_Price"))
            Me.Chart1.Series("Sell Price").Points.AddXY("week2", reader("Buy_Price"))
            Me.Chart1.Series("Sell Price").Points.AddXY("week3", reader("Sell_Price"))
            Label3.Text = reader("Sell_Price")
        End While
        reader.Close()
        command = New SqlCommand(query2, connection)
        reader = command.ExecuteReader()
        If reader.Read Then
            Label8.Text = reader(0)
        End If
        Try
            Label6.Text = Label3.Text * TextBox1.Text
        Catch ex As Exception

        End Try
        reader.Close()
        connection.Close()


    End Sub

    Private Sub Textbox1_change(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Label6.Text = Label3.Text * TextBox1.Text
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Enter Quantity")
            ElseIf Convert.ToInt32(TextBox1.Text) > Convert.ToInt32(Label8.Text) Then
                MessageBox.Show("Quantity Exceeded!")
            Else
                connection.Open()
                Dim query6 As String = "select Quantity , Buy_Price from Holdings where Stock_Name='" & ListBox1.SelectedItem & "' and Email='" & email & "'"
                Dim query5 As String = "update Wallet set Amount='" & Convert.ToInt32(Label1.Text) + Convert.ToInt32(Label6.Text) & "' where Email='" & email & "'"
                command = New SqlCommand(query5, connection)
                command.ExecuteNonQuery()
                command = New SqlCommand(query6, connection)
                reader = command.ExecuteReader()
                Dim bprice As New Integer
                If reader.Read Then
                    ex_quantity = reader(0)
                    bprice = reader(1)
                    reader.Close()
                End If
                ex_quantity = ex_quantity - TextBox1.Text
                Dim cvalue As Integer
                Dim ivalue As Integer
                cvalue = ex_quantity * Convert.ToInt32(Label3.Text)
                ivalue = ex_quantity * bprice
                Dim query7 As String = "update Holdings set Quantity='" & ex_quantity & "',C_Value='" & cvalue & "' ,pl='" & cvalue - ivalue & "' where Stock_Name='" & ListBox1.SelectedItem & "' and Email='" & email & "'"
                command = New SqlCommand(query7, connection)
                command.ExecuteNonQuery()
                Label1.Text = Convert.ToInt32(Label1.Text) + Convert.ToInt32(Label6.Text)

                Dim totqty As Integer
                Dim query9 = "select Total_qty from Stocks where Stock_Name='" & ListBox1.SelectedItem & "'"
                command = New SqlCommand(query9, connection)
                reader = command.ExecuteReader()
                If reader.Read Then
                    totqty = reader(0)
                    reader.Close()
                End If
                Dim query10 As String = "update Stocks set Total_qty='" & totqty + Convert.ToInt32(TextBox1.Text) & "' where Stock_Name='" & ListBox1.SelectedItem & "'"
                command = New SqlCommand(query10, connection)
                command.ExecuteNonQuery()
                MessageBox.Show("Stocks Sold!")
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub text_change(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub
End Class