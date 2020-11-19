Public Class Frm_settings

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim path As String = My.Application.Info.DirectoryPath
            FileCopy(path & "\LOW_DB.accdb", TextBox1.Text & "\LOW_DB.accdb")
            MsgBox("Backup was successful", MsgBoxStyle.Information, "Backup")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FolderBrowserDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class