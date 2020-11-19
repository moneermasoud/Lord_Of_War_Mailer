<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Sender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Sender))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Port = New System.Windows.Forms.TextBox()
        Me.Txt_AttachFile = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CB_Group = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Host = New System.Windows.Forms.TextBox()
        Me.Txt_Pass = New System.Windows.Forms.TextBox()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Txt_From = New System.Windows.Forms.TextBox()
        Me.CB_SMTP = New System.Windows.Forms.ComboBox()
        Me.lbSMTP = New System.Windows.Forms.Label()
        Me.RB2 = New System.Windows.Forms.RadioButton()
        Me.RB1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Message = New System.Windows.Forms.TextBox()
        Me.Txt_Subject = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_Output = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Txt_Port)
        Me.GroupBox1.Controls.Add(Me.Txt_AttachFile)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CB_Group)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Host)
        Me.GroupBox1.Controls.Add(Me.Txt_Pass)
        Me.GroupBox1.Controls.Add(Me.Txt_User)
        Me.GroupBox1.Controls.Add(Me.Txt_From)
        Me.GroupBox1.Controls.Add(Me.CB_SMTP)
        Me.GroupBox1.Controls.Add(Me.lbSMTP)
        Me.GroupBox1.Controls.Add(Me.RB2)
        Me.GroupBox1.Controls.Add(Me.RB1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_Message)
        Me.GroupBox1.Controls.Add(Me.Txt_Subject)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(815, 410)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control and Tools"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(497, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(253, 32)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Notice : Do not change email Textbox from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you want the send succeeds"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(496, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Port :"
        '
        'Txt_Port
        '
        Me.Txt_Port.Location = New System.Drawing.Point(554, 271)
        Me.Txt_Port.Name = "Txt_Port"
        Me.Txt_Port.ReadOnly = True
        Me.Txt_Port.Size = New System.Drawing.Size(222, 23)
        Me.Txt_Port.TabIndex = 23
        '
        'Txt_AttachFile
        '
        Me.Txt_AttachFile.Location = New System.Drawing.Point(103, 364)
        Me.Txt_AttachFile.Name = "Txt_AttachFile"
        Me.Txt_AttachFile.Size = New System.Drawing.Size(306, 23)
        Me.Txt_AttachFile.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Attach File : "
        '
        'CB_Group
        '
        Me.CB_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Group.FormattingEnabled = True
        Me.CB_Group.Location = New System.Drawing.Point(554, 315)
        Me.CB_Group.Name = "CB_Group"
        Me.CB_Group.Size = New System.Drawing.Size(222, 24)
        Me.CB_Group.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 319)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Group : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(496, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Host :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(496, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pass :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(496, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "User :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "From : "
        '
        'Txt_Host
        '
        Me.Txt_Host.Location = New System.Drawing.Point(554, 141)
        Me.Txt_Host.Name = "Txt_Host"
        Me.Txt_Host.ReadOnly = True
        Me.Txt_Host.Size = New System.Drawing.Size(222, 23)
        Me.Txt_Host.TabIndex = 11
        '
        'Txt_Pass
        '
        Me.Txt_Pass.Location = New System.Drawing.Point(554, 231)
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Pass.ReadOnly = True
        Me.Txt_Pass.Size = New System.Drawing.Size(222, 23)
        Me.Txt_Pass.TabIndex = 10
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(554, 186)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.ReadOnly = True
        Me.Txt_User.Size = New System.Drawing.Size(222, 23)
        Me.Txt_User.TabIndex = 9
        '
        'Txt_From
        '
        Me.Txt_From.Location = New System.Drawing.Point(554, 98)
        Me.Txt_From.Name = "Txt_From"
        Me.Txt_From.Size = New System.Drawing.Size(222, 23)
        Me.Txt_From.TabIndex = 8
        '
        'CB_SMTP
        '
        Me.CB_SMTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_SMTP.FormattingEnabled = True
        Me.CB_SMTP.Location = New System.Drawing.Point(554, 29)
        Me.CB_SMTP.Name = "CB_SMTP"
        Me.CB_SMTP.Size = New System.Drawing.Size(222, 24)
        Me.CB_SMTP.TabIndex = 7
        '
        'lbSMTP
        '
        Me.lbSMTP.AutoSize = True
        Me.lbSMTP.Location = New System.Drawing.Point(496, 33)
        Me.lbSMTP.Name = "lbSMTP"
        Me.lbSMTP.Size = New System.Drawing.Size(54, 16)
        Me.lbSMTP.TabIndex = 6
        Me.lbSMTP.Text = "SMTP : "
        '
        'RB2
        '
        Me.RB2.AutoSize = True
        Me.RB2.Location = New System.Drawing.Point(183, 68)
        Me.RB2.Name = "RB2"
        Me.RB2.Size = New System.Drawing.Size(79, 20)
        Me.RB2.TabIndex = 5
        Me.RB2.Text = "Plain\text"
        Me.RB2.UseVisualStyleBackColor = True
        '
        'RB1
        '
        Me.RB1.AutoSize = True
        Me.RB1.Checked = True
        Me.RB1.Location = New System.Drawing.Point(115, 68)
        Me.RB1.Name = "RB1"
        Me.RB1.Size = New System.Drawing.Size(58, 20)
        Me.RB1.TabIndex = 4
        Me.RB1.TabStop = True
        Me.RB1.Text = "HTML"
        Me.RB1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Message Body :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subject :"
        '
        'Txt_Message
        '
        Me.Txt_Message.Location = New System.Drawing.Point(15, 95)
        Me.Txt_Message.Multiline = True
        Me.Txt_Message.Name = "Txt_Message"
        Me.Txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Message.Size = New System.Drawing.Size(439, 256)
        Me.Txt_Message.TabIndex = 1
        '
        'Txt_Subject
        '
        Me.Txt_Subject.Location = New System.Drawing.Point(84, 28)
        Me.Txt_Subject.Name = "Txt_Subject"
        Me.Txt_Subject.Size = New System.Drawing.Size(370, 23)
        Me.Txt_Subject.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 424)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(815, 151)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_Output)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 580)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(815, 107)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'Txt_Output
        '
        Me.Txt_Output.BackColor = System.Drawing.Color.Black
        Me.Txt_Output.ForeColor = System.Drawing.Color.White
        Me.Txt_Output.Location = New System.Drawing.Point(6, 21)
        Me.Txt_Output.Multiline = True
        Me.Txt_Output.Name = "Txt_Output"
        Me.Txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Output.Size = New System.Drawing.Size(803, 79)
        Me.Txt_Output.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Lord_Of_War_Mailer.My.Resources.Resources.iconfinder_play_alt_118620
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(662, 359)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 28)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Send"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Lord_Of_War_Mailer.My.Resources.Resources._118917___clear_edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(500, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 28)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Clear"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Lord_Of_War_Mailer.My.Resources.Resources._118922___edit_find
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(581, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Show "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Lord_Of_War_Mailer.My.Resources.Resources._118946___attachment_mail
        Me.Button1.Location = New System.Drawing.Point(415, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_Sender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(831, 694)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Sender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sender"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Message As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Subject As System.Windows.Forms.TextBox
    Friend WithEvents RB2 As System.Windows.Forms.RadioButton
    Friend WithEvents RB1 As System.Windows.Forms.RadioButton
    Friend WithEvents CB_SMTP As System.Windows.Forms.ComboBox
    Friend WithEvents lbSMTP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Host As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Txt_User As System.Windows.Forms.TextBox
    Friend WithEvents Txt_From As System.Windows.Forms.TextBox
    Friend WithEvents CB_Group As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_AttachFile As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Output As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_Port As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
