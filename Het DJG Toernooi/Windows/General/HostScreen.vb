Public Class HostScreen
    Private Sub lblHostMsg_TextChanged(sender As Object, e As EventArgs) Handles lblHostMsg.TextChanged
        Dim l As Integer = lblHostMsg.Text.Length
        lblHostMsg.SelectionStart = l
        lblHostMsg.ScrollToCaret()

        Dim n As Integer = ControlPanel.txtHostMessages.Text.Length
        ControlPanel.txtHostMessages.SelectionStart = n
        ControlPanel.txtHostMessages.ScrollToCaret()
    End Sub

    Private Sub txtWinningStrap_Click(sender As Object, e As EventArgs) Handles txtWinningStrap.Click

    End Sub

    Private Sub picTree_Click(sender As Object, e As EventArgs) Handles picTree.Click

    End Sub

    Private Sub txtA_Click(sender As Object, e As EventArgs) Handles txtA.Click

    End Sub

    Private Sub txtQuestion_Click(sender As Object, e As EventArgs) Handles txtQuestion.Click

    End Sub

    Private Sub txtB_Click(sender As Object, e As EventArgs) Handles txtB.Click

    End Sub

    Private Sub pnlC_Paint(sender As Object, e As PaintEventArgs) Handles pnlC.Paint

    End Sub

    Private Sub pnlA_Paint(sender As Object, e As PaintEventArgs) Handles pnlA.Paint

    End Sub
End Class