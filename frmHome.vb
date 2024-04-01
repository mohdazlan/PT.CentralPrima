Public Class frmHome
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelPromo.Visible = False
    End Sub

    Private Sub btnSalary_Click(sender As Object, e As EventArgs) Handles btnSalary.Click
        panelPromo.Visible = True
        panelEmployee.Visible = False
        'panelPromo.Left = 144
        'panelPromo.Top = 59

    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        panelPromo.Visible = False
        panelEmployee.Visible = True
    End Sub
End Class