Public Class frmHome
    Private employees As New List(Of String())
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelPromo.Visible = False

        dgvEmployee.Columns.Add("NameColumn", "Name")
        dgvEmployee.Columns.Add("DOBColumn", "Date of Birth")
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

    Private Sub pbExit_Click(sender As Object, e As EventArgs) Handles pbExit.Click
        Application.Exit()
    End Sub

    Private Sub panelEmployee_Paint(sender As Object, e As PaintEventArgs) Handles panelEmployee.Paint

    End Sub
End Class