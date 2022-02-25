Public Class mainmenu
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim obj = New login
        obj.Show()
        Me.Close()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub
    Private Sub itembtn_Click(sender As Object, e As EventArgs) Handles itembtn.Click
        Dim obj = New items
        obj.Show()

    End Sub
End Class