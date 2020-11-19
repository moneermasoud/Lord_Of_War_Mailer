Imports System.Net
Imports System.Net.Mail
Imports Microsoft.Win32
Imports System.IO
Imports System.Threading
Imports System.Data.OleDb
Public Class Frm_Sender
    'Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal key As Int32) As Int16

    Private crr As Integer
    Private Index As Integer
    Private dt5 As New DataTable
    Private da5 As OleDbDataAdapter
    Private reader_smtp2 As OleDbDataReader
    Private dtgop As New DataTable
    Private dagop As OleDbDataAdapter
    Private smtp_ssl_value As Boolean
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Frm_Sender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        show_smtp()
        show_groups()
    End Sub


    Private Sub show_smtp()
        'values ComboBox 
        Try
            Dim userread As String
            userread = "select * from smtp"
            dt5.Clear()
            da5 = New OleDbDataAdapter(userread, con)
            da5.Fill(dt5)
            CB_SMTP.DataSource = dt5
            CB_SMTP.DisplayMember = "name_smtp"
            CB_SMTP.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub get_smtp()
        Try
            Dim get_id_qu As String
            get_id_qu = "select * from smtp where name_smtp='" & CB_SMTP.Text & "'"

            con.Open()
            Dim sqlcmd_q As New OleDbCommand(get_id_qu, con)
            reader_smtp2 = sqlcmd_q.ExecuteReader
            reader_smtp2.Read()
            If reader_smtp2.HasRows Then
                'Label6.Text = reader_smtp(0)
                'name_smtp.Text = reader_smtp(1)
                Txt_From.Text = reader_smtp2(3)
                Txt_Host.Text = reader_smtp2(2)
                Txt_User.Text = reader_smtp2(3)
                Txt_Pass.Text = reader_smtp2(4)
                Txt_Port.Text = reader_smtp2(5)
                smtp_ssl_value = reader_smtp2(6)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            reader_smtp2.Close()
        End Try


    End Sub



    Private Sub CB_SMTP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_SMTP.SelectedIndexChanged

    End Sub

    Private Sub CB_SMTP_TextChanged(sender As Object, e As EventArgs) Handles CB_SMTP.TextChanged
        get_smtp()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        show_view_emails()
    End Sub

    Private Sub show_groups()
        'values ComboBox 
        Try
            Dim userread As String
            userread = "select * from groups"
            dtgop.Clear()
            dagop = New OleDbDataAdapter(userread, con)
            dagop.Fill(dtgop)
            CB_Group.DataSource = dtgop
            CB_Group.DisplayMember = "name_group"
            CB_Group.SelectedIndex = 0


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub show_view_emails()
        Try
            con.Open()
            Dim sqlq As String = "SELECT * FROM view_emails where name_group='" & CB_Group.Text & "'"
            Dim sqlq_cmd As New OleDbCommand(sqlq, con)
            Dim reader_sql_ve As OleDbDataReader = sqlq_cmd.ExecuteReader
            'clear data listview 
            ListView1.Columns.Clear()
            ListView1.Items.Clear()

            ListView1.Columns.Add("#ID")
            ListView1.Columns.Add("Email")
            ListView1.Columns.Add("Group")


            ListView1.Columns(0).Width = 200
            ListView1.Columns(1).Width = 290
            ListView1.Columns(2).Width = 210

            While reader_sql_ve.Read

                Dim item As New ListViewItem(reader_sql_ve("id_email").ToString())
                item.SubItems.Add(reader_sql_ve("email").ToString())
                item.SubItems.Add(reader_sql_ve("name_group").ToString())


                ListView1.Items.Add(item)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        ''Txt_Subject
        ''Txt_Message
        'If Txt_Subject.Text = vbNullString Then
        '    MsgBox("Please Enter Subject", MsgBoxStyle.Critical, "Error Send")
        '    Exit Sub
        'End If
        'If Txt_Message.Text = vbNullString Then
        '    MsgBox("Please Enter Message", MsgBoxStyle.Critical, "Error Send")
        '    Exit Sub
        'End If
        'Dim cliente As New SmtpClient

        'Try

        '    For i = 0 To ListView1.Items.Count - 1


        '        Dim emailfrom As New MailAddress(Txt_From.Text)
        '        Dim emailto As New MailAddress(ListView1.Items(i).SubItems(1).Text)
        '        Dim mensagem As New MailMessage

        '        If Txt_AttachFile.Text = vbNullString Then

        '        Else
        '            mensagem.Attachments.Add(New Attachment(Txt_AttachFile.Text))
        '        End If


        '        mensagem.To.Add(emailto)
        '        mensagem.From = emailfrom
        '        mensagem.Subject = Txt_Subject.Text
        '        mensagem.Body = Txt_Message.Text
        '        If RB1.Checked = True Then
        '            mensagem.IsBodyHtml = True
        '        End If

        '        If RB2.Checked = True Then
        '            mensagem.IsBodyHtml = False
        '        End If

        '        Txt_Output.AppendText(vbNewLine & ListView1.Items(i).SubItems(1).Text & "...OK " & vbNewLine)

        '        cliente.Host = Txt_Host.Text
        '        cliente.Credentials = New System.Net.NetworkCredential(Txt_User.Text, Txt_Pass.Text)
        '        cliente.Port = Txt_Port.Text

        '        cliente.EnableSsl = smtp_ssl_value
        '        cliente.Send(mensagem)
        '        Thread.sleep(1000)

        '    Next


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally

        'End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Txt_AttachFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Txt_Subject
        'Txt_Message
        'PictureBox1.Visible = True

        If Txt_Subject.Text = vbNullString Then
            MsgBox("Please Enter Subject", MsgBoxStyle.Critical, "Error Send")
            Exit Sub
        End If
        If Txt_Message.Text = vbNullString Then
            MsgBox("Please Enter Message", MsgBoxStyle.Critical, "Error Send")
            Exit Sub
        End If
        Dim cliente As New SmtpClient
        GroupBox1.Enabled = False
        Try

            For i = 0 To ListView1.Items.Count - 1

                'If (GetAsyncKeyState(Keys.F10)) Then
                '    GroupBox1.Enabled = True
                '    Exit For
                '    Exit Sub

                'End If

                Dim emailfrom As New MailAddress(Txt_From.Text)
                Dim emailto As New MailAddress(ListView1.Items(i).SubItems(1).Text)
                Dim mensagem As New MailMessage

                If Txt_AttachFile.Text = vbNullString Then

                Else
                    mensagem.Attachments.Add(New Attachment(Txt_AttachFile.Text))
                End If


                mensagem.To.Add(emailto)
                mensagem.From = emailfrom
                mensagem.Subject = Txt_Subject.Text
                mensagem.Body = Txt_Message.Text
                If RB1.Checked = True Then
                    mensagem.IsBodyHtml = True
                End If

                If RB2.Checked = True Then
                    mensagem.IsBodyHtml = False
                End If


                cliente.Host = Txt_Host.Text
                cliente.Credentials = New System.Net.NetworkCredential(Txt_User.Text, Txt_Pass.Text)
                cliente.Port = Txt_Port.Text

                cliente.EnableSsl = smtp_ssl_value
                cliente.Send(mensagem)
                Txt_Output.AppendText(vbNewLine & ListView1.Items(i).SubItems(1).Text & "...OK " & vbNewLine)
                Thread.Sleep(1000)
                'PictureBox1.Refresh()
            Next

            ' PictureBox1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
            ' PictureBox1.Visible = False
            GroupBox1.Enabled = True
        Finally
            '  PictureBox1.Visible = False
            GroupBox1.Enabled = True
        End Try
    End Sub
End Class