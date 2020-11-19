Imports System.Data.OleDb
Public Class Frm_Emails
    Dim reader_FP As OleDbDataReader
    Private dt4 As New DataTable
    Private da4 As OleDbDataAdapter
    Private crr As Integer
    Private Index As Integer
    Private dt_4 As New DataTable
    Private da_4 As OleDbDataAdapter
    Private dtgop As New DataTable
    Private dagop As OleDbDataAdapter

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Frm_Emails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'show_grp()
        show_groups()
        show_emails()
    End Sub


    Private Sub show_grp()
        Try
            Dim get_id_qu As String
            get_id_qu = "select * from groups WHERE name_group='" & ComboBox1.Text & "'"
            con.Open()
            Dim sqlcmd_q As New OleDbCommand(get_id_qu, con)
            reader_FP = sqlcmd_q.ExecuteReader
            reader_FP.Read()
            If reader_FP.HasRows Then
                Label3.Text = reader_FP(0)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "رسالة خطأ")
        Finally
            con.Close()
            reader_FP.Close()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        show_emails()
        'show_groups()
        cls()
    End Sub
    Private Sub show_groups()
        'values ComboBox 
        Try
            Dim userread As String
            userread = "select * from groups"
            dt4.Clear()
            da4 = New OleDbDataAdapter(userread, con)
            da4.Fill(dt4)
            ComboBox1.DataSource = dt4
            ComboBox1.DisplayMember = "name_group"
            ComboBox1.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        show_grp()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxT_Email.Text = vbNullString Then
            MsgBox("insert Email", MsgBoxStyle.Exclamation, "Error Add")
            Exit Sub
        End If
        Try
            con.Open()

            Dim strI3 As String = "INSERT INTO emails (email,num_groups ) VALUES ('" & TxT_Email.Text & "'," & Label3.Text & ")"
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Added successfully ", MsgBoxStyle.Information, "Added")
            cls()
            show_emails()
            'show_groups()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub show_emails()
        Try
            Dim SQLQuery As String
            SQLQuery = "SELECT * FROM view_emails"

            dt_4.Clear()

            da_4 = New OleDbDataAdapter(SQLQuery, con)
            da_4.Fill(dt_4)
            DataGridView1.DataSource = dt_4

        Catch ex As Exception
            MsgBox("خطأإتصال بقواعد البيانات", MsgBoxStyle.Critical)

        End Try
        With DataGridView1

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Email"
            .Columns(1).HeaderText = "Group Name"

        End With


    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        '.........................................................................................
        ' ..........................................................................................
        If DataGridView1.CurrentRow.Index = dt_4.Rows.Count Or DataGridView1.Item(0, 0).Value = Nothing Then
            Exit Sub
        End If

        'TabControl1.SelectTab(0)
        crr = DataGridView1.CurrentRow.Index

        Label4.Text = DataGridView1.Item(0, crr).Value.ToString
        TxT_Email.Text = DataGridView1.Item(1, crr).Value.ToString
        ComboBox1.Text = DataGridView1.Item(2, crr).Value.ToString

        '   ==============================================================================================================================================

        'منع أي خطأ في الداتا قريد فيو عند عمل كلك على سطر فارغ أو حقل فارغ أو كلك يمين أو الفراغ 

        Try
            crr = DataGridView1.CurrentRow.Index
            Index = crr
            If DataGridView1.CurrentRow.Index = dt_4.Rows.Count Or DataGridView1.Item(0, 0).Value = Nothing Or DataGridView1.Item(0, crr).Value.ToString = vbNullString Then
                Exit Sub
            End If
        Catch When Err.Number = 91
            Exit Sub
        End Try
    End Sub
    Private Sub cls()
        TxT_Email.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxT_Email.Text = vbNullString Then
            MsgBox("insert Email", MsgBoxStyle.Exclamation, "Error Add")
            Exit Sub
        End If


        Try
            con.Open()

            Dim strI3 As String = "UPDATE emails SET email='" & TxT_Email.Text & "', num_groups=" & Label3.Text & "  WHERE id_email=" & Label4.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Has been successfully modified ", MsgBoxStyle.Information, "modified")
            cls()
            show_emails()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxT_Email.Text = vbNullString Then
            MsgBox("insert Email", MsgBoxStyle.Exclamation, "Error Add")
            Exit Sub
        End If

        Try
            con.Open()

            Dim strI3 As String = "DELETE FROM emails where id_email=" & Label4.Text
            Dim cmd3 As New OleDbCommand(strI3, con)
            cmd3.ExecuteNonQuery()
            MsgBox("Successfully deleted ", MsgBoxStyle.Information, "deleted")
            cls()
            show_emails()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try



    End Sub


End Class