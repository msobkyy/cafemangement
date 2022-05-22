Imports System.Data.SqlClient
Public Class ViewOrders

    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'database path
        conn = New SqlConnection("Data Source=SQL8003.site4now.net;Initial Catalog=db_a87432_cafemange;User Id=db_a87432_cafemange_admin;Password=a123123123a")
        'load items table
        fillitemtbl()
    End Sub
    Private Sub fillitemtbl()
        conn.Open()
        da = New SqlDataAdapter("select * from orderTbl", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "itemTbl")
        ordertable.DataSource = ds.Tables("itemTbl")
        conn.Close()
        'rename datagridview haeder

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
    End Sub


End Class