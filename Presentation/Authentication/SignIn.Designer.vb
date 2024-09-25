﻿Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SignIn
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
            Me.lbl_forget_password = New System.Windows.Forms.Label()
            Me.PromptL = New System.Windows.Forms.Label()
            Me.SignUpLL = New System.Windows.Forms.LinkLabel()
            Me.SignInBtn = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.label_password = New System.Windows.Forms.Label()
            Me.Email = New System.Windows.Forms.Label()
            Me.txt_password = New System.Windows.Forms.TextBox()
            Me.txt_username = New System.Windows.Forms.TextBox()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button_close = New System.Windows.Forms.Button()
            Me.check_showPassword = New System.Windows.Forms.CheckBox()
            Me.lbl_error = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lbl_forget_password
            '
            Me.lbl_forget_password.AutoSize = True
            Me.lbl_forget_password.BackColor = System.Drawing.Color.Transparent
            Me.lbl_forget_password.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_forget_password.ForeColor = System.Drawing.Color.Blue
            Me.lbl_forget_password.Location = New System.Drawing.Point(644, 503)
            Me.lbl_forget_password.Name = "lbl_forget_password"
            Me.lbl_forget_password.Size = New System.Drawing.Size(119, 15)
            Me.lbl_forget_password.TabIndex = 39
            Me.lbl_forget_password.Text = "Forget Password?"
            '
            'PromptL
            '
            Me.PromptL.AutoSize = True
            Me.PromptL.BackColor = System.Drawing.Color.Transparent
            Me.PromptL.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.PromptL.Location = New System.Drawing.Point(570, 543)
            Me.PromptL.Name = "PromptL"
            Me.PromptL.Size = New System.Drawing.Size(184, 18)
            Me.PromptL.TabIndex = 35
            Me.PromptL.Text = "Don't have an account?"
            '
            'SignUpLL
            '
            Me.SignUpLL.AutoSize = True
            Me.SignUpLL.BackColor = System.Drawing.Color.Transparent
            Me.SignUpLL.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.SignUpLL.Location = New System.Drawing.Point(759, 541)
            Me.SignUpLL.Name = "SignUpLL"
            Me.SignUpLL.Size = New System.Drawing.Size(64, 18)
            Me.SignUpLL.TabIndex = 34
            Me.SignUpLL.TabStop = True
            Me.SignUpLL.Text = "Sign Up"
            '
            'SignInBtn
            '
            Me.SignInBtn.BackColor = System.Drawing.SystemColors.WindowText
            Me.SignInBtn.FlatAppearance.BorderSize = 0
            Me.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SignInBtn.Font = New System.Drawing.Font("IBM Plex Mono", 15.0!, System.Drawing.FontStyle.Bold)
            Me.SignInBtn.ForeColor = System.Drawing.Color.Transparent
            Me.SignInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.SignInBtn.Location = New System.Drawing.Point(573, 441)
            Me.SignInBtn.Name = "SignInBtn"
            Me.SignInBtn.Size = New System.Drawing.Size(248, 48)
            Me.SignInBtn.TabIndex = 33
            Me.SignInBtn.Text = "Sign In"
            Me.SignInBtn.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(565, 106)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(314, 46)
            Me.Label3.TabIndex = 30
            Me.Label3.Text = "Welcome Back !"
            '
            'label_password
            '
            Me.label_password.AutoSize = True
            Me.label_password.BackColor = System.Drawing.Color.Transparent
            Me.label_password.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.label_password.Location = New System.Drawing.Point(568, 305)
            Me.label_password.Name = "label_password"
            Me.label_password.Size = New System.Drawing.Size(81, 19)
            Me.label_password.TabIndex = 29
            Me.label_password.Text = "Password"
            '
            'Email
            '
            Me.Email.AutoSize = True
            Me.Email.BackColor = System.Drawing.Color.Transparent
            Me.Email.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.Email.Location = New System.Drawing.Point(567, 214)
            Me.Email.Name = "Email"
            Me.Email.Size = New System.Drawing.Size(81, 19)
            Me.Email.TabIndex = 28
            Me.Email.Text = "Username"
            Me.Email.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'txt_password
            '
            Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_password.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_password.Location = New System.Drawing.Point(567, 329)
            Me.txt_password.Name = "txt_password"
            Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txt_password.Size = New System.Drawing.Size(248, 28)
            Me.txt_password.TabIndex = 56
            '
            'txt_username
            '
            Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_username.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(568, 241)
            Me.txt_username.MaximumSize = New System.Drawing.Size(3000, 3000)
            Me.txt_username.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(247, 28)
            Me.txt_username.TabIndex = 55
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.lbl_error, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(574, 411)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(247, 24)
            Me.TableLayoutPanel1.TabIndex = 84
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(36, 60)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(484, 529)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 42
            Me.PictureBox1.TabStop = False
            '
            'button_close
            '
            Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_close.BackColor = System.Drawing.Color.Transparent
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(867, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 41
            Me.button_close.UseVisualStyleBackColor = False
            '
            'check_showPassword
            '
            Me.check_showPassword.Appearance = System.Windows.Forms.Appearance.Button
            Me.check_showPassword.BackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.check_showPassword.FlatAppearance.BorderSize = 0
            Me.check_showPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.check_showPassword.Image = Global.expense_Trackie.My.Resources.Resources.showpassword
            Me.check_showPassword.Location = New System.Drawing.Point(815, 332)
            Me.check_showPassword.Name = "check_showPassword"
            Me.check_showPassword.Size = New System.Drawing.Size(26, 22)
            Me.check_showPassword.TabIndex = 86
            Me.check_showPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.check_showPassword.UseVisualStyleBackColor = False
            '
            'lbl_error
            '
            Me.lbl_error.AutoSize = True
            Me.lbl_error.BackColor = System.Drawing.Color.Transparent
            Me.lbl_error.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_error.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_error.ForeColor = System.Drawing.Color.Red
            Me.lbl_error.Location = New System.Drawing.Point(3, 0)
            Me.lbl_error.Name = "lbl_error"
            Me.lbl_error.Size = New System.Drawing.Size(241, 24)
            Me.lbl_error.TabIndex = 82
            Me.lbl_error.Text = "error"
            Me.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'SignIn
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(917, 668)
            Me.Controls.Add(Me.check_showPassword)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.txt_password)
            Me.Controls.Add(Me.txt_username)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.button_close)
            Me.Controls.Add(Me.lbl_forget_password)
            Me.Controls.Add(Me.PromptL)
            Me.Controls.Add(Me.SignUpLL)
            Me.Controls.Add(Me.SignInBtn)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.label_password)
            Me.Controls.Add(Me.Email)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SignIn"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SIgnIn"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lbl_forget_password As Label
        Friend WithEvents PromptL As Label
        Friend WithEvents SignUpLL As LinkLabel
        Friend WithEvents SignInBtn As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents label_password As Label
        Friend WithEvents Email As Label
        Friend WithEvents button_close As Button
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents txt_password As TextBox
        Friend WithEvents txt_username As TextBox
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents check_showPassword As CheckBox
        Friend WithEvents lbl_error As Label
    End Class
End NameSpace