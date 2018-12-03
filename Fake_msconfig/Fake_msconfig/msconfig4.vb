Public Class msconfig4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub

    Private Sub msconfig4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            If MsgBox("Drive C:\ has been formatted.", MsgBoxStyle.Critical, "Operation Complete") = MsgBoxResult.Ok Then
                End
            End If
            End
        End If
    End Sub
End Class