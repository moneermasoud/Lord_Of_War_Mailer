Imports System.Data.OleDb
Public Class Frm_smtp
    Private dt_smtp As New DataTable
    Private da_smtp As OleDbDataAdapter
    Private reader_smtp As OleDbDataReader

    Private Sub Frm_smtp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_smtp()
    End Sub
    Private Sub cls()
        name_smtp.Clear()
        host.Clear()
        username.Clear()
        password.Clear()
        port.Clear()
        smtp_ssl.Checked = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'name_smtp

        If name_smtp.Text = vbNullString Then
            MsgBox("insert Name smtp", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If host.Text = vbNullString Then
            MsgBox("insert host", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If username.Text = vbNullString Then
            MsgBox("insert username", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If password.Text = vbNullString Then
            MsgBox("insert password", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If port.Text = vbNullString Then
            MsgBox("insert port number", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Dim smtp_ssl_val As Boolean

        If smtp_ssl.Checked = True Then
            smtp_ssl_val = True
        Else
            smtp_ssl_val = False
        End If


        Try
            con.Open()

            Dim strI3 As String = "INSERT INTO smtp (name_smtp, host_smpt, username, [password], port, smtp_ssl ) VALUES ('" & name_smtp.Text & "','" & host.Text & "','" & username.Text & "','" & password.Text & "'," & port.Text & "," & smtp_ssl_val & ")"
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Added successfully ", MsgBoxStyle.Information, "Added")
            cls()
            load_smtp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try





    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cls()
        load_smtp()
    End Sub

    Private Sub load_smtp()

        Try
            Dim cmd_device_load As String = "select * from smtp"
            dt_smtp.Clear()
            Dim Da_Holiday As New OleDbDataAdapter(cmd_device_load, con)
            Da_Holiday.Fill(dt_smtp)
            ListBox1.DataSource = dt_smtp
            ListBox1.DisplayMember = "name_smtp"
            ListBox1.ValueMember = "Id_smtp"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub get_smtp()
        Try
            Dim get_id_qu As String
            get_id_qu = "select * from smtp where Id_smtp=" & ListBox1.SelectedValue
            con.Open()
            Dim sqlcmd_q As New OleDbCommand(get_id_qu, con)
            reader_smtp = sqlcmd_q.ExecuteReader
            reader_smtp.Read()
            If reader_smtp.HasRows Then
                Label6.Text = reader_smtp(0)
                name_smtp.Text = reader_smtp(1)
                host.Text = reader_smtp(2)
                username.Text = reader_smtp(3)
                password.Text = reader_smtp(4)
                port.Text = reader_smtp(5)
                smtp_ssl.Checked = reader_smtp(6)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            reader_smtp.Close()
        End Try


    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        get_smtp()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If name_smtp.Text = vbNullString Then
            MsgBox("insert Name smtp", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If host.Text = vbNullString Then
            MsgBox("insert host", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If username.Text = vbNullString Then
            MsgBox("insert username", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If password.Text = vbNullString Then
            MsgBox("insert password", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        If port.Text = vbNullString Then
            MsgBox("insert port number", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Dim smtp_ssl_val As Boolean

        If smtp_ssl.Checked = True Then
            smtp_ssl_val = True
        Else
            smtp_ssl_val = False
        End If


        Try
            con.Open()

            Dim strI3 As String = "UPDATE smtp SET name_smtp='" & name_smtp.Text & "', host_smpt='" & host.Text & "', username='" & username.Text & "',[password]='" & password.Text & "', port=" & port.Text & ", smtp_ssl=" & smtp_ssl_val & " WHERE Id_smtp=" & Label6.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Has been successfully modified ", MsgBoxStyle.Information, "modified")
            cls()
            load_smtp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label6.Text = vbNullString Then
            MsgBox("insert port number", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        Try
            con.Open()

            Dim strI3 As String = "DELETE FROM smtp where Id_smtp=" & Label6.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Successfully deleted ", MsgBoxStyle.Information, "deleted")
            cls()
            load_smtp()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class