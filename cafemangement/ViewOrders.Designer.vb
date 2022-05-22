<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrders
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ordertable = New System.Windows.Forms.DataGridView()
        CType(Me.ordertable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(221, 674)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(213, 47)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(210, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 44)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "View Ordwes"
        '
        'ordertable
        '
        Me.ordertable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ordertable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ordertable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ordertable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordertable.Location = New System.Drawing.Point(24, 73)
        Me.ordertable.Name = "ordertable"
        Me.ordertable.RowHeadersWidth = 51
        Me.ordertable.RowTemplate.Height = 29
        Me.ordertable.Size = New System.Drawing.Size(632, 579)
        Me.ordertable.TabIndex = 27
        '
        'ViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 733)
        Me.Controls.Add(Me.ordertable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewOrders"
        CType(Me.ordertable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents itemstable As DataGridView
    Friend WithEvents ordertable As DataGridView
End Class
