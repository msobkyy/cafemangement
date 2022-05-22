Imports System.Data.SqlClient
Public Class items
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim key = 0

    Public Sub items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'database path
        conn = New SqlConnection("Data Source=SQL8003.site4now.net;Initial Catalog=db_a87432_cafemange;User Id=db_a87432_cafemange_admin;Password=a123123123a")
        'load items table
        fillitemtbl()
        'load category
        fillcategory()
    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If itNmaeTb.Text = "" Or catCb.SelectedValue = "" Or itPriceTb.Text = "" Or Val(itPriceTb.Text) < 0 Or itQtyTb.Text = "" Or Val(itQtyTb.Text) < 0 Then
            MsgBox("Missing information")
        Else
            Try
                Dim r As DataRow = ds.Tables("itemTbl").NewRow()
                r("itId") = ds.Tables("itemTbl").Rows.Count + 1
                r("itName") = itNmaeTb.Text
                r("itCat") = catCb.SelectedValue.ToString()
                r("itPrice") = Val(itPriceTb.Text)
                r("itQty") = Val(itQtyTb.Text)
                ds.Tables("itemTbl").Rows.Add(r)
                da = New SqlDataAdapter("select * from itemTbl", conn)
                Dim cb As New SqlCommandBuilder(da)
                da.Update(ds, "itemTbl")
                MsgBox("Item Added")
                reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If key = 0 Then
            MsgBox("Missing information")
        Else
            Dim result As DialogResult = MessageBox.Show("Are u sure u want to delete this item forever !?", "Are u sure?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim command_cat As New SqlCommand("delete from itemTbl where itId = " & key & " ", conn)
                    command_cat.ExecuteNonQuery()
                    conn.Close()
                    reset()
                    fillitemtbl()
                    MsgBox("Item deleted")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If key = 0 Then
            MsgBox("Missing information")
        Else
            Dim result As DialogResult = MessageBox.Show("Are u sure u want to edit this item!?", "Are u sure?", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim command_cat As New SqlCommand("update itemTbl set itName='" & itNmaeTb.Text & "', itCat='" & catCb.SelectedValue.ToString() & "', itPrice=" & Val(itPriceTb.Text) & ",itQty=" & Val(itQtyTb.Text) & " where itId = " & key & "  ", conn)
                    command_cat.ExecuteNonQuery()
                    conn.Close()
                    reset()
                    fillitemtbl()
                    MsgBox("Item edited")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        ' Show item data on input when click it on table

        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        itNmaeTb.Text = row.Cells(1).Value.ToString
        catCb.SelectedValue = row.Cells(2).Value.ToString
        itPriceTb.Text = row.Cells(3).Value.ToString
        itQtyTb.Text = row.Cells(4).Value.ToString
        If itNmaeTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Private Sub addCatBtn_Click(sender As Object, e As EventArgs) Handles addCatBtn.Click
        If catTb.Text = "" Then
            MsgBox("Category cant be empty")
        Else
            Try
                conn.Open()
                Dim command_cat As New SqlCommand("insert into categorytbl (catName) values('" & catTb.Text & "')", conn)
                command_cat.ExecuteNonQuery()
                conn.Close()
                MsgBox("Category Added")
                catTb.Text = ""
                'update categorys
                fillcategory()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub reset()
        itNmaeTb.Text = ""
        catCb.SelectedIndex = 0
        itPriceTb.Text = ""
        itQtyTb.Text = ""
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
    Private Sub fillitemtbl()
        conn.Open()
        da = New SqlDataAdapter("select * from itemTbl", conn)
        Dim cb As New SqlCommandBuilder(da)
        ds = New DataSet()
        da.Fill(ds, "itemTbl")
        DataGridView1.DataSource = ds.Tables("itemTbl")
        conn.Close()
        'rename datagridview haeder
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "NAME"
        DataGridView1.Columns(2).HeaderText = "CATEGORY"
        DataGridView1.Columns(3).HeaderText = "PRICE"
        DataGridView1.Columns(4).HeaderText = "QUANTITY"
    End Sub
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        reset()
    End Sub
    Dim Pos As Point
    Private Sub Moveform_MouseMove_1(sender As Object, e As MouseEventArgs) Handles Moveform.MouseMove
        ' make form movable
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim obj = New login
        obj.Show()
        Me.Hide()
    End Sub
End Class