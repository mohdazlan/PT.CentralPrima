Public Class frmLogin
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
End Class
