<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCasher
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cashierLbl = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.systemTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.discountLbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.changeLbl = New System.Windows.Forms.Label()
        Me.cashtenderedLbl = New System.Windows.Forms.Label()
        Me.subtotalLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.vatLbl = New System.Windows.Forms.Label()
        Me.totalamountLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.enterBtn = New System.Windows.Forms.Button()
        Me.barcodeTB = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nameofcustomerCB = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.voidtransacBtn = New System.Windows.Forms.Button()
        Me.voidBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.logoutBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1247, 100)
        Me.Panel1.TabIndex = 3
        '
        'logoutBtn
        '
        Me.logoutBtn.AutoSize = True
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.logoutBtn.ForeColor = System.Drawing.Color.White
        Me.logoutBtn.Location = New System.Drawing.Point(1155, 35)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(88, 35)
        Me.logoutBtn.TabIndex = 1
        Me.logoutBtn.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "POS Terminal System"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cashierLbl)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dateLbl)
        Me.GroupBox1.Controls.Add(Me.timeLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(974, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date and Time:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(95, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 23)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(95, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 23)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Label12"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 35)
        Me.Label9.TabIndex = 12
        '
        'cashierLbl
        '
        Me.cashierLbl.AutoSize = True
        Me.cashierLbl.Font = New System.Drawing.Font("Segoe UI Light", 9.0!)
        Me.cashierLbl.Location = New System.Drawing.Point(80, 73)
        Me.cashierLbl.Name = "cashierLbl"
        Me.cashierLbl.Size = New System.Drawing.Size(0, 20)
        Me.cashierLbl.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 23)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cashier:"
        '
        'dateLbl
        '
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Location = New System.Drawing.Point(62, 46)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(0, 23)
        Me.dateLbl.TabIndex = 3
        '
        'timeLbl
        '
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Location = New System.Drawing.Point(62, 21)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(0, 23)
        Me.timeLbl.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Time:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.discountLbl)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.confirmBtn)
        Me.GroupBox2.Controls.Add(Me.changeLbl)
        Me.GroupBox2.Controls.Add(Me.cashtenderedLbl)
        Me.GroupBox2.Controls.Add(Me.subtotalLbl)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.vatLbl)
        Me.GroupBox2.Controls.Add(Me.totalamountLbl)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(974, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 433)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cash Details:"
        '
        'discountLbl
        '
        Me.discountLbl.AutoSize = True
        Me.discountLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountLbl.Location = New System.Drawing.Point(145, 196)
        Me.discountLbl.Name = "discountLbl"
        Me.discountLbl.Size = New System.Drawing.Size(29, 35)
        Me.discountLbl.TabIndex = 26
        Me.discountLbl.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 23)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "DISCOUNT:"
        '
        'confirmBtn
        '
        Me.confirmBtn.BackColor = System.Drawing.Color.Maroon
        Me.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.confirmBtn.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.Location = New System.Drawing.Point(13, 328)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(227, 50)
        Me.confirmBtn.TabIndex = 10
        Me.confirmBtn.Text = "CONFIRM AMOUNT"
        Me.confirmBtn.UseVisualStyleBackColor = False
        '
        'changeLbl
        '
        Me.changeLbl.AutoSize = True
        Me.changeLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeLbl.Location = New System.Drawing.Point(145, 266)
        Me.changeLbl.Name = "changeLbl"
        Me.changeLbl.Size = New System.Drawing.Size(29, 35)
        Me.changeLbl.TabIndex = 24
        Me.changeLbl.Text = "0"
        '
        'cashtenderedLbl
        '
        Me.cashtenderedLbl.AutoSize = True
        Me.cashtenderedLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashtenderedLbl.Location = New System.Drawing.Point(145, 231)
        Me.cashtenderedLbl.Name = "cashtenderedLbl"
        Me.cashtenderedLbl.Size = New System.Drawing.Size(29, 35)
        Me.cashtenderedLbl.TabIndex = 23
        Me.cashtenderedLbl.Text = "0"
        '
        'subtotalLbl
        '
        Me.subtotalLbl.AutoSize = True
        Me.subtotalLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLbl.Location = New System.Drawing.Point(145, 161)
        Me.subtotalLbl.Name = "subtotalLbl"
        Me.subtotalLbl.Size = New System.Drawing.Size(29, 35)
        Me.subtotalLbl.TabIndex = 22
        Me.subtotalLbl.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "CHANGE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CASH TENDERED:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SUBTOTAL:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(71, 121)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(175, 35)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "________________"
        '
        'vatLbl
        '
        Me.vatLbl.AutoSize = True
        Me.vatLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vatLbl.Location = New System.Drawing.Point(145, 94)
        Me.vatLbl.Name = "vatLbl"
        Me.vatLbl.Size = New System.Drawing.Size(29, 35)
        Me.vatLbl.TabIndex = 12
        Me.vatLbl.Text = "0"
        '
        'totalamountLbl
        '
        Me.totalamountLbl.AutoSize = True
        Me.totalamountLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamountLbl.Location = New System.Drawing.Point(145, 55)
        Me.totalamountLbl.Name = "totalamountLbl"
        Me.totalamountLbl.Size = New System.Drawing.Size(29, 35)
        Me.totalamountLbl.TabIndex = 11
        Me.totalamountLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "VAT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "TOTAL AMOUNT:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.enterBtn)
        Me.GroupBox3.Controls.Add(Me.barcodeTB)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(951, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Product ID/Barcode:"
        '
        'enterBtn
        '
        Me.enterBtn.BackColor = System.Drawing.Color.Maroon
        Me.enterBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enterBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.enterBtn.ForeColor = System.Drawing.Color.White
        Me.enterBtn.Location = New System.Drawing.Point(827, 28)
        Me.enterBtn.Name = "enterBtn"
        Me.enterBtn.Size = New System.Drawing.Size(109, 50)
        Me.enterBtn.TabIndex = 7
        Me.enterBtn.Text = "ENTER"
        Me.enterBtn.UseVisualStyleBackColor = False
        '
        'barcodeTB
        '
        Me.barcodeTB.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.barcodeTB.Location = New System.Drawing.Point(16, 38)
        Me.barcodeTB.Name = "barcodeTB"
        Me.barcodeTB.Size = New System.Drawing.Size(796, 41)
        Me.barcodeTB.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 223)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(951, 339)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Product List:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(945, 310)
        Me.DataGridView1.TabIndex = 1
        '
        'Column5
        '
        Me.Column5.FillWeight = 116.6914!
        Me.Column5.HeaderText = "Product Code"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 187.4015!
        Me.Column1.HeaderText = "Item Description"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 68.31253!
        Me.Column2.HeaderText = "Unit Price"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 51.45244!
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 76.14213!
        Me.Column4.HeaderText = "Total"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nameofcustomerCB)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.voidtransacBtn)
        Me.GroupBox5.Controls.Add(Me.voidBtn)
        Me.GroupBox5.Location = New System.Drawing.Point(17, 568)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(951, 88)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Hotkeys:"
        '
        'nameofcustomerCB
        '
        Me.nameofcustomerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.nameofcustomerCB.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.nameofcustomerCB.FormattingEnabled = True
        Me.nameofcustomerCB.Location = New System.Drawing.Point(164, 35)
        Me.nameofcustomerCB.Name = "nameofcustomerCB"
        Me.nameofcustomerCB.Size = New System.Drawing.Size(171, 31)
        Me.nameofcustomerCB.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 23)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Name of Customer:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(729, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "F3 APPLY DISCOUNT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'voidtransacBtn
        '
        Me.voidtransacBtn.BackColor = System.Drawing.Color.Maroon
        Me.voidtransacBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voidtransacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voidtransacBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.voidtransacBtn.ForeColor = System.Drawing.Color.White
        Me.voidtransacBtn.Location = New System.Drawing.Point(500, 29)
        Me.voidtransacBtn.Name = "voidtransacBtn"
        Me.voidtransacBtn.Size = New System.Drawing.Size(223, 50)
        Me.voidtransacBtn.TabIndex = 11
        Me.voidtransacBtn.Text = "F2 VOID TRANSACTION"
        Me.voidtransacBtn.UseVisualStyleBackColor = False
        '
        'voidBtn
        '
        Me.voidBtn.BackColor = System.Drawing.Color.Maroon
        Me.voidBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.voidBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.voidBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.voidBtn.ForeColor = System.Drawing.Color.White
        Me.voidBtn.Location = New System.Drawing.Point(341, 29)
        Me.voidBtn.Name = "voidBtn"
        Me.voidBtn.Size = New System.Drawing.Size(153, 50)
        Me.voidBtn.TabIndex = 8
        Me.voidBtn.Text = "F1 DELETE ITEM"
        Me.voidBtn.UseVisualStyleBackColor = False
        '
        'FormCasher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 668)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCasher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents logoutBtn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents systemTimer As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents barcodeTB As System.Windows.Forms.TextBox
    Friend WithEvents changeLbl As System.Windows.Forms.Label
    Friend WithEvents cashtenderedLbl As System.Windows.Forms.Label
    Friend WithEvents subtotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents vatLbl As System.Windows.Forms.Label
    Friend WithEvents totalamountLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents enterBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents voidBtn As System.Windows.Forms.Button
    Friend WithEvents confirmBtn As System.Windows.Forms.Button
    Friend WithEvents discountLbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cashierLbl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents voidtransacBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nameofcustomerCB As ComboBox
    Friend WithEvents Label15 As Label
End Class

