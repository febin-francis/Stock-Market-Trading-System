Imports System.Data.SqlClient

Public Class visitmarket
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim reader As SqlDataReader

    Dim email As String

    Public Sub New(ByVal mailid As String)
        InitializeComponent()
        email = mailid
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Label4.Text = email
    End Sub

    Private Sub visitmarket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Chart1.Series("NIFTY").Points.AddXY("2019", "11456")
        Me.Chart1.Series("NIFTY").Points.AddXY("2020", "8745")
        Me.Chart1.Series("NIFTY").Points.AddXY("2021", "14507")
        Me.Chart1.Series("NIFTY").Points.AddXY("2022", "17325")

        Me.Chart1.Series("SENSEX").Points.AddXY("2019", "38164")
        Me.Chart1.Series("SENSEX").Points.AddXY("2020", "29815")
        Me.Chart1.Series("SENSEX").Points.AddXY("2021", "50792")
        Me.Chart1.Series("SENSEX").Points.AddXY("2022", "58382")

        Dim DS As New DataSet()
        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Documents\Visual Studio 2012\Projects\SMTS\SMTS\Database1.mdf;Integrated Security=True")
        connection.Open()
        Dim query As String = "select * from Stocks"
        command = New SqlCommand(query, connection)
        Dim dataAdapter As New SqlDataAdapter(query, connection)
        dataAdapter.Fill(DS, "Stocks")
        DataGridView1.DataSource = DS
        DataGridView1.DataMember = "Stocks"
        reader = command.ExecuteReader()
        reader.Close()
        connection.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New profile(Label4.Text)
        With p
            .TopLevel = False
            Panel3.Controls.Add(p)
            p.BringToFront()
            p.Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bs As New buystock(Label4.Text)
        Dim ss As New sellstock(Label4.Text)
        Dim r As New Report(Label4.Text)
        Dim p As New profile("")
        Dim visi As New visitmarket(Label4.Text)
        bs.Hide()
        ss.Hide()
        r.Hide()
        p.Hide()
        visi.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim bs As New buystock(Label4.Text)
        With bs
            .TopLevel = False
            Panel3.Controls.Add(bs)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ss As New sellstock(Label4.Text)
        With ss
            .TopLevel = False
            Panel3.Controls.Add(ss)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim r As New Report(Label4.Text)
        With r
            .TopLevel = False
            Panel3.Controls.Add(r)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

End Class