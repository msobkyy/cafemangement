Imports System.Data.SqlClient
Public Class orders
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim productNmae As String
    Dim i = 0, GrdTotal = 0, price, qty, stock
    Dim key = 0
    Private Sub orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'database path
        conn = New SqlConnection("Data Source=SQL8003.site4now.net;Initial Catalog=db_a87432_cafemange;User Id=db_a87432_cafemange_admin;Password=a123123123a")
        'load items table
        fillitemtbl()
        fillcategory()
    End Sub
    Private Sub itemstable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemstable.CellMouseClick
        ' Show item data on input when click it on table
        Dim row As DataGridViewRow = itemstable.Rows(e.RowIndex)
        productNmae = row.Cells(1).Value.ToString
        If productNmae = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString())
        End If
    End Sub
    Private Sub addToBill_Click(sender As Object, e As EventArgs) Handles addToBill.Click
        If key = 0 Then
            MsgBox("Select item")
        ElseIf Val(qtyTb.Text) > stock Then
            MsgBox("No enough stock")
        ElseIf Val(qtyTb.Text) <= 0 Then
            MsgBox("Put valid quantity")
        Else
            Dim rnum As Integer = billstable.Rows.Add()
            Dim total = Convert.ToInt32(Val(qtyTb.Text) * price)
            i = i + 1
            billstable.Rows.Item(rnum).Cells("Column1").Value = i
            billstable.Rows.Item(rnum).Cells("Column2").Value = productNmae
            billstable.Rows.Item(rnum).Cells("Column3").Value = price
            billstable.Rows.Item(rnum).Cells("Column4").Value = Val(qtyTb.Text)
            billstable.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            totalbil.Text = "TOTAL : " + Convert.ToString(GrdTotal) + " EGB"
            updatestock()
            fillitemtbl()
            qtyTb.Text = ""
            key = 0
        End If
    End Sub
    Private Sub updatestock()
        Try
            Dim newqty = stock - Convert.ToInt32(qtyTb.Text)
            conn.Open()
            Dim command_cat As New SqlCommand("update itemTbl set itQty=" & newqty & " where itId = " & key & "  ", conn)
            command_cat.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub catCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles catCb.SelectionChangeCommitted
        filtercategory()
    End Sub
    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        fillitemtbl()
    End Sub
    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        PrintPreviewDialog1.Show()
        Addbill()
    End Sub
    Private Sub Addbill()
        Try
            conn.Open()
            Dim command_cat As New SqlCommand("insert into orderTbl values('" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "'," & GrdTotal & ")", conn)
            command_cat.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub fillitemtbl()
        conn.Open()
        da = New SqlDataAdapter("select * from itemTbl", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "itemTbl")
        itemstable.DataSource = ds.Tables("itemTbl")
        conn.Close()
        'rename datagridview haeder
        itemstable.Columns(0).HeaderText = "ID"
        itemstable.Columns(1).HeaderText = "NAME"
        itemstable.Columns(2).HeaderText = "CATEGORY"
        itemstable.Columns(3).HeaderText = "PRICE"
        itemstable.Columns(4).HeaderText = "QUANTITY"
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'print design
        e.Graphics.DrawString(”Cafe Shop", New Font("Arial", 22), Brushes.BlueViolet, 325, 40)
        e.Graphics.DrawString(”*** YourBill ***", New Font("Arial", 14), Brushes.BlueViolet, 330, 100)
        e.Graphics.DrawString(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), New Font("Arial", 14), Brushes.BlueViolet, 330, 130)

        Dim bm As New Bitmap(Me.billstable.Width, Me.billstable.Height)
        billstable.DrawToBitmap(bm, New Rectangle(0, 0, Me.billstable.Width, Me.billstable.Height))
        e.Graphics.DrawImage(bm, 0, 180)

        e.Graphics.DrawString(”Total Amount : " + GrdTotal.ToString(), New Font("Arial", 20), Brushes.Crimson, 325, 520)
        e.Graphics.DrawString(”**** THANKS FOR BUYING FROM OUR CAFE SHOP ****", New Font("Arial", 15), Brushes.Crimson, 130, 600)
    End Sub
    Private Sub vieworders_Click(sender As Object, e As EventArgs) Handles vieworders.Click
        Dim obj = New ViewOrders
        obj.Show()
    End Sub
    Private Sub filtercategory()
        conn.Open()
        da = New SqlDataAdapter("select * from itemTbl where itCat = '" & catCb.SelectedValue.ToString() & "' ", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "itemTbl")
        itemstable.DataSource = ds.Tables("itemTbl")
        conn.Close()
        'rename datagridview haeder
        itemstable.Columns(0).HeaderText = "ID"
        itemstable.Columns(1).HeaderText = "NAME"
        itemstable.Columns(2).HeaderText = "CATEGORY"
        itemstable.Columns(3).HeaderText = "PRICE"
        itemstable.Columns(4).HeaderText = "QUANTITY"
    End Sub
    Private Sub fillcategory()
        conn.Open()
        da = New SqlDataAdapter("select * from categoryTbl", conn)
        Dim TBL = New DataTable
        da.Fill(TBL)
        catCb.DataSource = TBL
        catCb.DisplayMember = "catName"
        catCb.ValueMember = "catName"
        conn.Close()
    End Sub
    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Dim Pos As Point
    Private Sub Moveform_MouseMove_1(sender As Object, e As MouseEventArgs) Handles Moveform.MouseMove
        ' make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

End Class