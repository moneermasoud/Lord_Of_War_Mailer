Imports System.Data.OleDb
Public Class Frm_Groups
    Private dt_group As New DataTable
    Private da_group As OleDbDataAdapter
    Private reader_group As OleDbDataReader
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Frm_Groups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_groups()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Name_group.Text = vbNullString Then
            MsgBox("insert Name Group", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If


        Try
            con.Open()

            Dim strI3 As String = "INSERT INTO groups (name_group ) VALUES ('" & Name_group.Text & "')"
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Added successfully ", MsgBoxStyle.Information, "Added")
            cls()
            load_groups()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub load_groups()
        Try
            Dim cmd_device_load As String = "select * from groups"
            dt_group.Clear()
            Dim Da_Holiday As New OleDbDataAdapter(cmd_device_load, con)
            Da_Holiday.Fill(dt_group)
            ListBox1.DataSource = dt_group
            ListBox1.DisplayMember = "name_group"
            ListBox1.ValueMember = "id_group"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub get_group()

        Try
            Dim get_id_qu As String
            get_id_qu = "select * from groups where id_group=" & ListBox1.SelectedValue
            con.Open()
            Dim sqlcmd_q As New OleDbCommand(get_id_qu, con)
            reader_group = sqlcmd_q.ExecuteReader
            reader_group.Read()
            If reader_group.HasRows Then
                ID_group.Text = reader_group(0)
                Name_group.Text = reader_group(1)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            reader_group.Close()
        End Try

    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click
        get_group()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ID_group.Text = vbNullString Then
            MsgBox("Select From list", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        If Name_group.Text = vbNullString Then
            MsgBox("insert Name Group", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If

        Try
            con.Open()

            Dim strI3 As String = "UPDATE groups SET name_group='" & Name_group.Text & "' WHERE id_group=" & ID_group.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Has been successfully modified ", MsgBoxStyle.Information, "modified")
            cls()
            load_groups()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub cls()
        ID_group.Clear()
        Name_group.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ID_group.Text = vbNullString Then
            MsgBox("Select From list", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        Try
            con.Open()

            Dim strI3 As String = "DELETE FROM groups where id_group=" & ID_group.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Successfully deleted ", MsgBoxStyle.Information, "deleted")
            cls()
            load_groups()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class