﻿Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class SignUp

        Const ImageFilter As String = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        Dim number As String
        Dim username As String
        Dim password As String
        Dim _imageAddress As String
        ReadOnly _dateJoined As DateTime = DateTime.Now.ToString("yyyy-MM-dd")

#Region " load "

        Private Sub onLoad(sender As Object, e As EventArgs) Handles MyBase.Load
            MakePictureBoxCircular(img_profile)
            lbl_info.Text = ""

        End Sub

#End Region



#Region "Signup"


        Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click


            If Not Integer.TryParse(txt_number.Text, number) Then
                lbl_info.Text = "Number cannot contain string characters"
                Return
            End If

            If txt_number.Text.Length > 10 Or txt_number.Text.Length Then
                lbl_info.Text = ("Number should be 10 char long")
                Return
            End If

            If String.IsNullOrEmpty(txt_number.Text) Or String.IsNullOrEmpty(txt_username.Text) Or String.IsNullOrEmpty(txt_password.Text) Then
                lbl_info.Text = "Fill all the fields"
                Return
            End If


            If txt_username.Text.Length < 8 Then
                lbl_info.Text = ("Username must be at least 8 char long")
                Return
            End If



            number = txt_number.Text
            username = txt_username.Text
            password = txt_password.Text



            'password validation ko laagi
            If password.Length < 8 Then
                lbl_info.Text = ("Password must be at least 8 char long")
                Return
            End If

            If Not password.Any(AddressOf Char.IsDigit) Then
                lbl_info.Text = ("Password must contain at least one number.")
                Return
            End If

            If Not password.Any(Function(c) "@#%^".Contains(c)) Then
                lbl_info.Text = ("Password must contain at least one special character (@, #, %, ^).")
                Return
            End If

            If Not password.Any(AddressOf Char.IsUpper) Then
                lbl_info.Text = ("Password must contain at least one uppercase letter.")
                Return
            End If

            If Not password.Any(AddressOf Char.IsLower) Then
                lbl_info.Text = ("Password must contain at least one lowercase letter.")
                Return
            End If





            ' backend handling
            Dim userManager As New UserManager

            Dim userId As Integer = userManager.RegisterUser(username, number, password, _dateJoined, _imageAddress)


            If userId > 0 Then

                lbl_info.Text = ("User registered successfully")

                MsgBox(SessionManager.Instance.CurrentUserId)
                MsgBox(SessionManager.Instance.CurrentUsername)
                MsgBox(SessionManager.Instance.CurrentPassword)
                MsgBox(SessionManager.Instance.CurrentNumber)
                MsgBox(SessionManager.Instance.CurrentDateJoined)
                MsgBox(SessionManager.Instance.CurrentProfileLink)

                Me.Hide()

                mainWindow.Show()

            Else
                lbl_info.Text = "User registration failed"
            End If

        End Sub

#End Region


#Region "fetching image"

        Private Sub profilePicture_Click(sender As Object, e As EventArgs) Handles img_profile.Click

            Dim fileDialog As New OpenFileDialog


            fileDialog.Filter = ImageFilter

            If fileDialog.ShowDialog = DialogResult.OK Then

                _imageAddress = fileDialog.FileName
                img_profile.Image = Image.FromFile(_imageAddress)


            End If

        End Sub



#End Region



#Region "signIn passing"


        ' other kura
        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLL.LinkClicked
            Dim form2 As New SIgnIn
            form2.Show()
            Me.Hide()
        End Sub

#End Region




#Region "other functionality"

        Private Sub PassTxt_Enter(sender As Object, e As EventArgs) Handles txt_password.Enter
            UpdatePasswordVisibility()
        End Sub

        Private Sub PassTxt_Leave(sender As Object, e As EventArgs) Handles txt_password.Leave
            If String.IsNullOrWhiteSpace(txt_password.Text) Then
                txt_password.PasswordChar = ControlChars.NullChar ' Remove PasswordChar to show default text
            End If
        End Sub

        Private Sub ShowPassCB_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCB.CheckedChanged
            UpdatePasswordVisibility()
        End Sub

        Private Sub UpdatePasswordVisibility()
            If ShowPassCB.Checked Then
                ' Show the password
                txt_password.PasswordChar = ControlChars.NullChar
            Else
                ' Hide the password, unless the TextBox is empty and showing default text
                If txt_password.Text <> "Enter Password" Then
                    txt_password.PasswordChar = "*"c
                Else
                    txt_password.PasswordChar = ControlChars.NullChar
                End If
            End If
        End Sub

        Private Sub ShowPassCB_GotFocus(sender As Object, e As EventArgs) Handles ShowPassCB.GotFocus
            UpdatePasswordVisibility()
        End Sub

#End Region



#Region "gradient"
        Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
            ' Get the client area of the form
            Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

            ' Define the start and end colors for the gradient
            Dim startColor As Color = Color.Beige
            Dim endColor As Color = Color.AliceBlue

            ' Create a LinearGradientBrush
            Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
                ' Fill the rectangle with the gradient
                e.Graphics.FillRectangle(brush, rect)
            End Using
        End Sub

        Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            ' Redraw the form when it is resized to update the gradient
            Me.Invalidate()
        End Sub

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub


#End Region



#Region " info board "

        Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles infoTool.MouseHover
            ToolTip1.SetToolTip(infoTool, "Make sure your password is 
        at least 8 characters and contains:

        -> At least 1 Uppercase
        letter and 1 lowercase
        letter
        -> At least 1 number
        -> At least 1 special
        character (like @#%^)

        Avoid common passwords or
        strings like ""password"",
        ""qwerty"" or ""123456789""")

        End Sub

        Private Sub infoTool_MouseEnter(sender As Object, e As EventArgs) Handles infoTool.MouseEnter
            svgInfo.Visible = False
        End Sub

        Private Sub infoTool_MouseLeave(sender As Object, e As EventArgs) Handles infoTool.MouseLeave
            svgInfo.Visible = True

        End Sub
#End Region



#Region " make picturebox circle "

        Public Sub MakePictureBoxCircular(ByVal picBox As PictureBox)
            ' Create a circular path
            Dim path As New GraphicsPath()
            path.AddEllipse(0, 0, picBox.Width, picBox.Height)

            ' Apply the circular region to the PictureBox
            picBox.Region = New Region(path)
        End Sub



#End Region

    End Class
End NameSpace