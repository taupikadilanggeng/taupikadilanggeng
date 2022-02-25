Public Class items
    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim obj = New login
        obj.Show()
        Me.Close()

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click
        Application.Exit()

    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click

    End Sub
End Class