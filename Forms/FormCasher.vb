Imports System.Data.SqlClient
Public Class FormCasher
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        logoutBtn.Text = MessageBox.Show("Are you sure you want to logout?", "WARNING: LOGGING OUT.", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If logoutBtn.Text = DialogResult.Yes Then
            logoutBtn.Text = "Logout"
            Me.Close()
            formLogin.Show()
            formLogin.usernameTB.Focus()
        Else
            logoutBtn.Text = "Logout"

        End If
        addEmployeeLoggedIn()
    End Sub

    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        checkBarcode()
    End Sub

    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        If nameofcustomerCB.Text = "" Then
            MsgBox("input the ustomer name!")
        Else
            formPayment.Show()
        End If

    End Sub

    Private Sub FormCasher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        barcodeTB.Focus()
        Me.KeyPreview = True
        retrievecustomerlist()
        Label12.Text = Date.Now.ToString("MMMM dd, yyyy")
        Label13.Text = TimeOfDay.ToString("hh:mm:ss tt")
        Label14.Text = formLogin.usernameTB.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        discountnumshow()
    End Sub

    Private Sub voidtransacBtn_Click(sender As Object, e As EventArgs) Handles voidtransacBtn.Click
        seniordiscount = "No"
        retrievevoidtranactoin()
    End Sub
End Class