<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPayment
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
        Me.subtotalLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.chequeTB = New System.Windows.Forms.TextBox()
        Me.cashTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Payment Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subtotal:"
        '
        'subtotalLbl
        '
        Me.subtotalLbl.AutoSize = True
        Me.subtotalLbl.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalLbl.Location = New System.Drawing.Point(103, 120)
        Me.subtotalLbl.Name = "subtotalLbl"
        Me.subtotalLbl.Size = New System.Drawing.Size(29, 35)
        Me.subtotalLbl.TabIndex = 12
        Me.subtotalLbl.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.exitBtn)
        Me.GroupBox1.Controls.Add(Me.loginBtn)
        Me.GroupBox1.Controls.Add(Me.chequeTB)
        Me.GroupBox1.Controls.Add(Me.cashTB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 254)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Mode:"
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.Maroon
        Me.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.exitBtn.ForeColor = System.Drawing.Color.White
        Me.exitBtn.Location = New System.Drawing.Point(121, 141)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(109, 50)
        Me.exitBtn.TabIndex = 19
        Me.exitBtn.Text = "CANCEL"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.Maroon
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(236, 141)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(109, 50)
        Me.loginBtn.TabIndex = 18
        Me.loginBtn.Text = "OK"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'chequeTB
        '
        Me.chequeTB.Location = New System.Drawing.Point(117, 93)
        Me.chequeTB.Name = "chequeTB"
        Me.chequeTB.Size = New System.Drawing.Size(228, 36)
        Me.chequeTB.TabIndex = 17
        '
        'cashTB
        '
        Me.cashTB.Location = New System.Drawing.Point(117, 49)
        Me.cashTB.Name = "cashTB"
        Me.cashTB.Size = New System.Drawing.Size(228, 36)
        Me.cashTB.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(17, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 35)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cheque:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 35)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cash:"
        '
        'formPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 431)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.subtotalLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents subtotalLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chequeTB As System.Windows.Forms.TextBox
    Friend WithEvents cashTB As System.Windows.Forms.TextBox
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents loginBtn As System.Windows.Forms.Button
End Class
