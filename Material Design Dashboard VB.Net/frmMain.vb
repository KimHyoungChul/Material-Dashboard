Public Class frmMain
    Dim PanelWidth As Integer
    Dim isCol As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCol Then
            Panel1.Width = Panel1.Width + 10
            If Panel1.Width >= PanelWidth Then
                Timer1.Stop()
                isCol = False
                Me.Refresh()
            End If
        Else
            Panel1.Width = Panel1.Width - 10
            If Panel1.Width <= 47 Then
                Timer1.Stop()
                isCol = True
                Me.Refresh()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelWidth = Panel1.Width
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackColor = Color.White
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.BackColor = Color.FromArgb(183, 28, 28)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnMinimize_MouseLeave(sender As Object, e As EventArgs) Handles btnMinimize.MouseLeave
        btnMinimize.BackColor = Color.White
    End Sub

    Private Sub btnMinimize_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimize.MouseEnter
        btnMinimize.BackColor = Color.FromArgb(67, 160, 71)
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BackColor = Color.FromArgb(103, 58, 183)
        btnExpense.BackColor = Color.FromArgb(69, 39, 160)
        btnUser.BackColor = Color.FromArgb(69, 39, 160)
        btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160)
        btnSales.BackColor = Color.FromArgb(69, 39, 160)
        btnViewSales.BackColor = Color.FromArgb(69, 39, 160)
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        btnHome.BackColor = Color.FromArgb(69, 39, 160)
        btnExpense.BackColor = Color.FromArgb(103, 58, 183)
        btnUser.BackColor = Color.FromArgb(69, 39, 160)
        btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160)
        btnSales.BackColor = Color.FromArgb(69, 39, 160)
        btnViewSales.BackColor = Color.FromArgb(69, 39, 160)
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        btnHome.BackColor = Color.FromArgb(69, 39, 160)
        btnExpense.BackColor = Color.FromArgb(69, 39, 160)
        btnUser.BackColor = Color.FromArgb(103, 58, 183)
        btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160)
        btnSales.BackColor = Color.FromArgb(69, 39, 160)
        btnViewSales.BackColor = Color.FromArgb(69, 39, 160)
    End Sub

    Private Sub btnPurchaseDetails_Click(sender As Object, e As EventArgs) Handles btnPurchaseDetails.Click
        btnHome.BackColor = Color.FromArgb(69, 39, 160)
        btnExpense.BackColor = Color.FromArgb(69, 39, 160)
        btnUser.BackColor = Color.FromArgb(69, 39, 160)
        btnPurchaseDetails.BackColor = Color.FromArgb(103, 58, 183)
        btnSales.BackColor = Color.FromArgb(69, 39, 160)
        btnViewSales.BackColor = Color.FromArgb(69, 39, 160)
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        btnHome.BackColor = Color.FromArgb(69, 39, 160)
        btnExpense.BackColor = Color.FromArgb(69, 39, 160)
        btnUser.BackColor = Color.FromArgb(69, 39, 160)
        btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160)
        btnSales.BackColor = Color.FromArgb(103, 58, 183)
        btnViewSales.BackColor = Color.FromArgb(69, 39, 160)
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click
        btnHome.BackColor = Color.FromArgb(69, 39, 160)
        btnExpense.BackColor = Color.FromArgb(69, 39, 160)
        btnUser.BackColor = Color.FromArgb(69, 39, 160)
        btnPurchaseDetails.BackColor = Color.FromArgb(69, 39, 160)
        btnSales.BackColor = Color.FromArgb(69, 39, 160)
        btnViewSales.BackColor = Color.FromArgb(103, 58, 183)
    End Sub
End Class
