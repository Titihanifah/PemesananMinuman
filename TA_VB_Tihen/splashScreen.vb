Public Class splashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 150 Then
            Timer1.Stop()
            Me.Visible = False
            LoginForm1.Show()
        End If
    End Sub
End Class