Imports System.Data.OleDb
Public Class Form1
    Dim host As String = System.Net.Dns.GetHostName()
    Dim os_n As String = My.Computer.Info.OSFullName.ToString()
    Dim os_v As String = My.Computer.Info.OSVersion.ToString()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Multi SMTP Add
        'Multi Groups list
        '
        'HTML & Plain Text
        '
        count_smtp()
        count_emails()
        count_groubs()
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text = host & " || " & os_n & "  " & os_v & " || " & Now.ToString("yyyy/MM/dd-hh:mm:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Frm_smtp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Frm_Groups.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Emails.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Sender.Show()
    End Sub


    Private Sub count_smtp()
        Try
            con.Open()
            Dim sql_str As String = "SELECT count(*) FROM smtp"
            Dim sql_cmd As New OleDbCommand(sql_str, con)
            Dim sql_reader As OleDbDataReader
            sql_reader = sql_cmd.ExecuteReader
            sql_reader.Read()
            If sql_reader.HasRows Then
                Label6.Text = sql_reader(0)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub count_emails()
        Try
            con.Open()
            Dim sql_str As String = "SELECT count(*) FROM emails"
            Dim sql_cmd As New OleDbCommand(sql_str, con)
            Dim sql_reader As OleDbDataReader
            sql_reader = sql_cmd.ExecuteReader
            sql_reader.Read()
            If sql_reader.HasRows Then
                Label8.Text = sql_reader(0)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub count_groubs()
        Try
            con.Open()
            Dim sql_str As String = "SELECT count(*) FROM groups"
            Dim sql_cmd As New OleDbCommand(sql_str, con)
            Dim sql_reader As OleDbDataReader
            sql_reader = sql_cmd.ExecuteReader
            sql_reader.Read()
            If sql_reader.HasRows Then
                Label7.Text = sql_reader(0)
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Frm_about.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Frm_settings.Show()
    End Sub
End Class
