Imports System.Data.SqlClient
Imports System.IO


Public Class buystock
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader
    Dim balance As Integer
    Dim namee As String
    Dim quantity As Integer
    Dim sell_price As Integer
    Public email As String
    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
    End Sub

    Private Sub buystock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf")
        connection.Open()
        Dim query As String = "select Amount from Wallet where  email='" & email & "'"
        Dim query1 As String = "select Stock_Name from stocks"
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

    Private Sub Textbox1_change(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Label6.Text = Label3.Text * TextBox1.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Chart1.Series(0).Points.Clear()
        Catch ex As Exception

        End Try
        connection.Open()
        Dim query = "select * from Stocks where Stock_Name='" & ListBox1.SelectedItem & "'"
        command = New SqlCommand(query, connection)
        reader = command.ExecuteReader()
        While reader.Read
            Me.Chart1.Series("Buy Price").Points.AddXY("week1", reader("Old_Price"))
            Me.Chart1.Series("Buy Price").Points.AddXY("week2", reader("Sell_Price"))
            Me.Chart1.Series("Buy Price").Points.AddXY("week3", reader("Buy_Price"))
            Label3.Text = reader("Buy_Price")
            sell_price = reader("Sell_Price")
        End While
        Try
            Label6.Text = TextBox1.Text * Label3.Text
        Catch ex As Exception

        End Try
        reader.Close()
        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label6.Text = 0 Then
            MessageBox.Show("Enter quantity")
        ElseIf Convert.ToInt32(Label6.Text) > Convert.ToInt32(Label1.Text) Then
            MessageBox.Show("Insufficient Balance")
        Else
            connection.Open()
            Dim walletAmt As Integer = Label1.Text - Label6.Text
            Dim query3 As String = "update Wallet set Amount='" & walletAmt & "' where email='" & email & "'"
            Dim query4 As String = "select Quantity from Holdings where Stock_Name='" & ListBox1.SelectedItem & "' and Email='" & email & "'"
            Dim cvalue As Integer
            Dim ivalue As Integer
            command = New SqlCommand(query3, connection)
            command.ExecuteNonQuery()
            command = New SqlCommand(query4, connection)
            reader = command.ExecuteReader()
            Try
                If reader.Read Then
                    quantity = reader(0)
                    reader.Close()
                    quantity = quantity + Convert.ToInt32(TextBox1.Text)
                    cvalue = quantity * sell_price
                    ivalue = quantity * Convert.ToInt32(Label3.Text)

                    Dim query6 As String = "update Holdings set Quantity='" & quantity & "', Buy_Price= '" & Label3.Text & "',I_Value='" & ivalue & "', C_Value='" & cvalue & "' ,pl='" & cvalue - ivalue & "' where Stock_Name='" & ListBox1.SelectedItem & "' and Email='" & email & "'"
                    command = New SqlCommand(query6, connection)
                    command.ExecuteNonQuery()
                Else
                    reader.Close()
                    cvalue = Convert.ToInt32(TextBox1.Text) * sell_price
                    ivalue = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(Label3.Text)
                    Dim quer5 As String = "insert into Holdings values('" & email & "','" & ListBox1.SelectedItem & "','" & TextBox1.Text & "','" & Label3.Text & "','" & cvalue & "','" & ivalue & "','" & cvalue - ivalue & "')"
                    command = New SqlCommand(quer5, connection)
                    command.ExecuteNonQuery()
                End If
            Catch
            End Try
            Dim totqty As Integer
            Dim query7 = "select Total_qty from Stocks where Stock_Name='" & ListBox1.SelectedItem & "'"
            command = New SqlCommand(query7, connection)
            reader = command.ExecuteReader()
            If reader.Read Then
                totqty = reader(0)
                reader.Close()
            End If
            Try
            Dim query8 As String = "update Stocks set Total_qty='" & totqty - Convert.ToInt32(TextBox1.Text) & "' where Stock_Name='" & ListBox1.SelectedItem & "'"
            command = New SqlCommand(query8, connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Stock Purchased")
                Label1.Text = walletAmt
            Catch
            End Try
            connection.Close()
        End If
    End Sub
End Class