Public Class msconfig3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Your computer is trashed.", MsgBoxStyle.Exclamation, "Critical Error")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Would you like to format and delete the contents of drive C:\?", MsgBoxStyle.YesNo, "Question") = MsgBoxResult.Yes Then
            msconfig4.Show()
            Me.Close()
        End If
    End Sub
End Class