<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formQuantity
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.productIDLbl = New System.Windows.Forms.Label()
        Me.itemdescriptionLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.unitpriceLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quantityTB = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(506, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product ID/Barcode:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Item Description:"
        '
        'productIDLbl
        '
        Me.productIDLbl.AutoSize = True
        Me.productIDLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDLbl.Location = New System.Drawing.Point(23, 165)
        Me.productIDLbl.Name = "productIDLbl"
        Me.productIDLbl.Size = New System.Drawing.Size(23, 28)
        Me.productIDLbl.TabIndex = 4
        Me.productIDLbl.Text = "a"
        '
        'itemdescriptionLbl
        '
        Me.itemdescriptionLbl.AutoSize = True
        Me.itemdescriptionLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemdescriptionLbl.Location = New System.Drawing.Point(23, 245)
        Me.itemdescriptionLbl.Name = "itemdescriptionLbl"
        Me.itemdescriptionLbl.Size = New System.Drawing.Size(23, 28)
        Me.itemdescriptionLbl.TabIndex = 5
        Me.itemdescriptionLbl.Text = "a"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 285)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit Price:"
        '
        'unitpriceLbl
        '
        Me.unitpriceLbl.AutoSize = True
        Me.unitpriceLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitpriceLbl.Location = New System.Drawing.Point(23, 325)
        Me.unitpriceLbl.Name = "unitpriceLbl"
        Me.unitpriceLbl.Size = New System.Drawing.Size(23, 28)
        Me.unitpriceLbl.TabIndex = 7
        Me.unitpriceLbl.Text = "a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(23, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 28)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity:"
        '
        'quantityTB
        '
        Me.quantityTB.BackColor = System.Drawing.Color.Snow
        Me.quantityTB.Location = New System.Drawing.Point(28, 405)
        Me.quantityTB.Name = "quantityTB"
        Me.quantityTB.Size = New System.Drawing.Size(453, 31)
        Me.quantityTB.TabIndex = 9
        Me.quantityTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Maroon
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(372, 442)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(109, 50)
        Me.loginBtn.TabIndex = 19
        Me.loginBtn.Text = "OK"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'formQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 532)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.quantityTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.unitpriceLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.itemdescriptionLbl)
        Me.Controls.Add(Me.productIDLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formQuantity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents productIDLbl As System.Windows.Forms.Label
    Friend WithEvents itemdescriptionLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents unitpriceLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents quantityTB As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
End Class
