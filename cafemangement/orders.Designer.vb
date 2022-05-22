<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(orders))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.totalbil = New System.Windows.Forms.Label()
        Me.billstable = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemstable = New System.Windows.Forms.DataGridView()
        Me.vieworders = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addToBill = New System.Windows.Forms.Button()
        Me.qtyTb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.catCb = New System.Windows.Forms.ComboBox()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Moveform = New System.Windows.Forms.Panel()
        Me.minimize = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.billstable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemstable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Moveform.SuspendLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Panel1.Controls.Add(Me.printBtn)
        Me.Panel1.Controls.Add(Me.totalbil)
        Me.Panel1.Controls.Add(Me.billstable)
        Me.Panel1.Controls.Add(Me.itemstable)
        Me.Panel1.Controls.Add(Me.vieworders)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.addToBill)
        Me.Panel1.Controls.Add(Me.qtyTb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.catCb)
        Me.Panel1.Controls.Add(Me.refreshBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(171, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 665)
        Me.Panel1.TabIndex = 1
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.printBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.printBtn.ForeColor = System.Drawing.Color.White
        Me.printBtn.Location = New System.Drawing.Point(37, 603)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(175, 47)
        Me.printBtn.TabIndex = 30
        Me.printBtn.Text = "Place - Print"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'totalbil
        '
        Me.totalbil.AutoSize = True
        Me.totalbil.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalbil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.totalbil.Location = New System.Drawing.Point(248, 613)
        Me.totalbil.Name = "totalbil"
        Me.totalbil.Size = New System.Drawing.Size(78, 27)
        Me.totalbil.TabIndex = 29
        Me.totalbil.Text = "TOTAL"
        '
        'billstable
        '
        Me.billstable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.billstable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.billstable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.billstable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.billstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.billstable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.billstable.Location = New System.Drawing.Point(37, 430)
        Me.billstable.Name = "billstable"
        Me.billstable.RowHeadersWidth = 51
        Me.billstable.RowTemplate.Height = 29
        Me.billstable.Size = New System.Drawing.Size(987, 156)
        Me.billstable.TabIndex = 28
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PRODUCT"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PRICE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "QUANTITY"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "TOTAL"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'itemstable
        '
        Me.itemstable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemstable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemstable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.itemstable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.itemstable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemstable.Location = New System.Drawing.Point(288, 91)
        Me.itemstable.Name = "itemstable"
        Me.itemstable.RowHeadersWidth = 51
        Me.itemstable.RowTemplate.Height = 29
        Me.itemstable.Size = New System.Drawing.Size(736, 187)
        Me.itemstable.TabIndex = 26
        '
        'vieworders
        '
        Me.vieworders.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.vieworders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vieworders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vieworders.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.vieworders.ForeColor = System.Drawing.Color.White
        Me.vieworders.Location = New System.Drawing.Point(811, 603)
        Me.vieworders.Name = "vieworders"
        Me.vieworders.Size = New System.Drawing.Size(213, 47)
        Me.vieworders.TabIndex = 23
        Me.vieworders.Text = "View All Orders"
        Me.vieworders.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(392, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Your Order"
        '
        'addToBill
        '
        Me.addToBill.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.addToBill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addToBill.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.addToBill.ForeColor = System.Drawing.Color.White
        Me.addToBill.Location = New System.Drawing.Point(582, 301)
        Me.addToBill.Name = "addToBill"
        Me.addToBill.Size = New System.Drawing.Size(168, 46)
        Me.addToBill.TabIndex = 17
        Me.addToBill.Text = "Add To Bill"
        Me.addToBill.UseVisualStyleBackColor = False
        '
        'qtyTb
        '
        Me.qtyTb.BackColor = System.Drawing.Color.White
        Me.qtyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qtyTb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.qtyTb.Location = New System.Drawing.Point(419, 312)
        Me.qtyTb.Name = "qtyTb"
        Me.qtyTb.Size = New System.Drawing.Size(139, 32)
        Me.qtyTb.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 27)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Filter Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(530, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 37)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Place Order"
        '
        'catCb
        '
        Me.catCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.catCb.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.catCb.FormattingEnabled = True
        Me.catCb.Location = New System.Drawing.Point(37, 91)
        Me.catCb.Name = "catCb"
        Me.catCb.Size = New System.Drawing.Size(213, 33)
        Me.catCb.TabIndex = 18
        '
        'refreshBtn
        '
        Me.refreshBtn.AccessibleName = "refreshBtn"
        Me.refreshBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.refreshBtn.ForeColor = System.Drawing.Color.White
        Me.refreshBtn.Location = New System.Drawing.Point(37, 144)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(138, 46)
        Me.refreshBtn.TabIndex = 14
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(287, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 27)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Quantity"
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1168, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(473, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 37)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Manage Orders"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Moveform
        '
        Me.Moveform.BackColor = System.Drawing.Color.Teal
        Me.Moveform.Controls.Add(Me.minimize)
        Me.Moveform.Controls.Add(Me.Label4)
        Me.Moveform.Controls.Add(Me.PictureBox1)
        Me.Moveform.Dock = System.Windows.Forms.DockStyle.Top
        Me.Moveform.Location = New System.Drawing.Point(0, 0)
        Me.Moveform.Name = "Moveform"
        Me.Moveform.Size = New System.Drawing.Size(1234, 55)
        Me.Moveform.TabIndex = 26
        '
        'minimize
        '
        Me.minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize.Image = CType(resources.GetObject("minimize.Image"), System.Drawing.Image)
        Me.minimize.Location = New System.Drawing.Point(1117, 1)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(54, 51)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimize.TabIndex = 25
        Me.minimize.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 153)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(33, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 44)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Seller"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(33, 652)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(94, 74)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 738)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Moveform)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "orders"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.billstable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemstable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Moveform.ResumeLayout(False)
        Me.Moveform.PerformLayout()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents catCb As ComboBox
    Friend WithEvents refreshBtn As Button
    Friend WithEvents addToBill As Button
    Friend WithEvents qtyTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents vieworders As Button
    Friend WithEvents itemstable As DataGridView
    Friend WithEvents billstable As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents totalbil As Label
    Friend WithEvents printBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Moveform As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents minimize As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
