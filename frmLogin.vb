Public Class frmLogin
    Const adminName = "admin"
    Const adminPass = "password"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnSignUpTwo_Click(sender As Object, e As EventArgs) Handles btnSignUpTwo.Click
        '372
        panelLeft.Left = 42
        panelRight.Left = 372
    End Sub

    Private Sub btnLoginTwo_Click(sender As Object, e As EventArgs) Handles btnLoginTwo.Click
        '42


        panelRight.Left = 42
        panelLeft.Left = 372
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = adminName AndAlso txtPassword.Text = adminPass Then
            Me.Hide()
            frmHome.Show()
        ElseIf txtUserName.Text = adminName Or txtPassword.Text = adminPass Then
            MessageBox.Show("Incorrect User Name or Password!!, Please Try Again", "Credential Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtUserName.Text = "guest" AndAlso txtPassword.Text = "guest" Then
            frmGuest.show
        Else
            MessageBox.Show("Incorrect Credentials!!, Please Try Again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
