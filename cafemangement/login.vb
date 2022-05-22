Imports System.Data.SqlClient

Public Class login
    Dim conn As SqlConnection


    Public Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'database path
        'Data Source=SOBKY;AttachDbFilename=C:\Users\G3\Documents\CafeDb.mdf;Integrated Security=True;Connect Timeout=30
        Dim strconnetion As String = "Data Source=SQL8003.site4now.net;Initial Catalog=db_a87432_cafemange;User Id=db_a87432_cafemange_admin;Password=a123123123a"
        'connect to server
        conn = New SqlConnection(strconnetion)
        conn.Open()
        Try
            conn.ChangeDatabase("db_a87432_cafemange")
        Catch ex As Exception
            MsgBox(ex.Message)
            Try
                Dim command_create_db As New SqlCommand("create database cafemange", conn)
                command_create_db.ExecuteNonQuery()
                command_create_db.Connection.ChangeDatabase("cafemange")
                Dim command_create_itemtbl As New SqlCommand("CREATE TABLE [dbo].[itemTbl] ([itId] INT IDENTITY (1, 1) NOT NULL,[itName] VARCHAR (50) NOT NULL,[itCat] VARCHAR (50) NOT NULL,[itPrice] INT NOT NULL,[itQty] INT NOT NULL,PRIMARY KEY CLUSTERED ([itId] ASC));", conn)
                command_create_itemtbl.ExecuteNonQuery()
                Dim command_create_ordertbl As New SqlCommand("CREATE TABLE [dbo].[orderTbl] ([ordId] INT  IDENTITY (1, 1) NOT NULL,[ordDate] DATE NOT NULL,[ordAmt] INT  NOT NULL,PRIMARY KEY CLUSTERED ([ordId] ASC));", conn)
                command_create_ordertbl.ExecuteNonQuery()
                Dim command_create_categorytbl As New SqlCommand("CREATE TABLE [dbo].[categoryTbl] ([catId] INT IDENTITY (1, 1) NOT NULL,[catName] VARCHAR (50) NOT NULL, PRIMARY KEY CLUSTERED ([catId] ASC));", conn)
                command_create_categorytbl.ExecuteNonQuery()
            Catch ex2 As Exception
                MsgBox(ex2.Message)
            End Try
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UserName.Text = "" Or Password.Text = "" Then
            MsgBox("Enter Username And Password")
        ElseIf UserName.Text = "admin" And Password.Text = "admin" Then
            Dim obj = New items
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Username Or Password Wrong")
            UserName.Text = ""
            Password.Text = ""
        End If
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim obj = New orders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Dim Pos As Point
    Private Sub Moveform_MouseMove_1(sender As Object, e As MouseEventArgs) Handles Moveform.MouseMove
        ' make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
