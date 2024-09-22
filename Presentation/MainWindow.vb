﻿Imports expense_Trackie.Application

Namespace Presentation

    Public Class MainWindow

        Dim _categoryManager As New CategoryManager()



#Region " predefined instance of userControls "


        ' this makes object defined here available in other forms too
        Dim _dayView As New DayView()
        Dim _monthView As New MonthView(_dayView)
        Dim _calanderView As New CalanderView(_dayView)

#End Region


#Region " form load / calander load "


        Private Sub MybaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load

            ' loading information to form
            LoadInformation()
            LoadUserInformation()

            LoadCalander()

            radio_home.Checked = True
            radio_day_view.Checked = True



        End Sub


        Sub LoadCalander()

            panel_calender.Controls.Add(_calanderView)

        End Sub


#End Region



#Region " loadInformation() "



        Public Sub LoadUserInformation()
            Me.lbl_username.Text = SessionManager.Instance.CurrentUsername


            If Not String.IsNullOrEmpty(SessionManager.Instance.CurrentProfileLink) Then
                btn_profile.Image = Image.FromFile(SessionManager.Instance.CurrentProfileLink)
            End If


        End Sub


        Public Sub LoadInformation()

            'mainwindow category
            _categoryManager.GenerateCategoryCheckButtons(flowPanelCategory, AddressOf Checkbox_CheckChanged)


            ' dayview refresh



        End Sub

#End Region



#Region "calander/day"
        Private Sub radio_month_view_CheckedChanged(sender As Object, e As EventArgs) Handles radio_month_view.CheckedChanged, radio_home.CheckedChanged

            If radio_home.Checked Then

                If radio_month_view.Checked Then

                    DisplayForm(_monthView)
                    radio_month_view.Image = My.Resources.monthDark



                End If

            End If


            'visual ques
            If radio_month_view.Checked Then
                radio_month_view.Image = My.Resources.monthDark
            Else
                radio_month_view.Image = My.Resources.monthLight
            End If

        End Sub



        Private Sub radio_day_view_checkChanged(sender As Object, e As EventArgs) Handles radio_day_view.CheckedChanged, radio_home.CheckedChanged


            'checking day
            If radio_home.Checked Then

                If radio_day_view.Checked Then

                    DisplayForm(_dayView)
                    radio_day_view.Image = My.Resources.dayDark
                End If

            End If


            'visual ques
            'visual ques
            If radio_day_view.Checked Then
                radio_day_view.Image = My.Resources.dayDark
            Else
                radio_day_view.Image = My.Resources.dayLight
            End If



        End Sub


        Private Sub DisplayForm(control As UserControl)

            panel_main.Controls.Clear()

            With control
                .Dock = DockStyle.Fill
                panel_main.Controls.Add(control)
                .BringToFront()
                .Show()
            End With


            'MessageBox.Show("Docking set to: " & form.Dock.ToString())
        End Sub

#End Region



#Region "get selected category"


        Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click

            ' unchecking all the checks
            For Each control As Control In flowPanelCategory.Controls

                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                    checkBox.Checked = False

                End If

            Next



            ' clearning selectedCategoryIds
            Dim selectedCategoryIds As New List(Of Integer)

            ' if all is selected
            selectedCategoryIds.Clear()
            SessionManager.SelectedCategoryIds = selectedCategoryIds


        End Sub



        ' event handling
        Public Sub Checkbox_CheckChanged(sender As Object, e As EventArgs)

            Dim selectedCategoryIds As New List(Of Integer)

            For Each control As Control In flowPanelCategory.Controls

                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                    If checkBox.Checked Then
                        Dim categoryId As Integer = CInt(checkBox.Tag)
                        selectedCategoryIds.Add(categoryId)
                    End If

                End If

            Next

            SessionManager.SelectedCategoryIds = selectedCategoryIds

            _dayView.LoadExpenses()

        End Sub


#End Region


#Region "expense"

        Private Sub AddExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click

            'NewExpense.Show()

            Dim newExpense As New NewExpense(_dayView, _monthView, _calanderView)
            newExpense.Show()

        End Sub



#End Region


#Region "category"
        Private Sub AddCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click

            NewCategory.Show()

            'Presentation.NewCategory.button_create.PerformClick()

        End Sub

        Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

            btn_delete.Image = My.Resources.delete3Red
            'DeleteCategory.Show()

            Dim deleteCategory As New DeleteCategory(_dayView, _monthView, _calanderView)
            deleteCategory.Show()

        End Sub

        Private Sub btn_edit_category_Click(sender As Object, e As EventArgs) Handles btn_edit_category.Click

            Dim editCategory As New UpdateCategory(_dayView, _monthView)
            editCategory.Show()
        End Sub

#End Region


#Region " profile "
        Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click


            Dim displayProfile As New DisplayProfile(_calanderView)
            displayProfile.Show()

        End Sub

#End Region

#Region "check / button visual cues"
        ' checked visual cues
        Private Sub RadioCheckedChanged(sender As Object, e As EventArgs) Handles radio_home.CheckedChanged, radio_analytical.CheckedChanged, radio_export.CheckedChanged

            ' for home button
            If radio_home.Checked Then
                radio_home.Image = My.Resources.homeDark
            Else
                radio_home.Image = My.Resources.homeLight
            End If


            ' for analytical button
            If radio_analytical.Checked Then
                radio_analytical.Image = My.Resources.barDark
            Else
                radio_analytical.Image = My.Resources.barLight
            End If


            ' for export button
            If radio_export.Checked Then
                radio_export.Image = My.Resources.exportDark
            Else
                radio_export.Image = My.Resources.exportLight
            End If

        End Sub


        Private Sub btn_delete_MouseHover(sender As Object, e As EventArgs) Handles btn_delete.MouseHover
            btn_delete.Image = My.Resources.delete3Red
        End Sub


        Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
            btn_delete.Image = My.Resources.delete3
        End Sub


#End Region


#Region "min/max/close"
        Private Sub ButtonMaxClick(sender As Object, e As EventArgs) Handles button_max.Click

            'panel_main.Refresh()

            If Me.Size = New Size(1920, 1200) Then
                'Me.WindowState = FormWindowState.Normal

                Me.Size = New Size(1600, 1000)
                Me.Location = New Point(160, 100)
                button_max.Image = My.Resources.icons8_maximize_button_16

            Else
                Me.Location = New Point(0, 0)
                Me.Size = New Size(1920, 1200)

                'Me.WindowState = FormWindowState.Maximized
                button_max.Image = My.Resources.restore_down
            End If

        End Sub


        ' minimize on button click
        Private Sub ButtonMinClick(sender As Object, e As EventArgs) Handles button_min.Click
            Me.WindowState = FormWindowState.Minimized

            panel_main.Refresh()
        End Sub

        ' close
        Private Sub ButtonCloseClick(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
            EraseSessionInformation()

        End Sub

        Private Sub EraseSessionInformation()

            SessionManager.Instance.CurrentUserId = 0
            SessionManager.Instance.CurrentUsername = ""
            SessionManager.Instance.CurrentPassword = ""
            SessionManager.Instance.CurrentNumber = ""
            SessionManager.Instance.CurrentDateJoined = DateTime.Now
            SessionManager.Instance.CurrentProfileLink = ""

        End Sub


#End Region


#Region " mouse Movement "

        ' MOUSE MOVEMENT


        Dim _mouseMove As System.Drawing.Point


        Private Sub topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
            _mouseMove = New Point(-e.X, -e.Y)
        End Sub


        Private Sub topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove

            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim position As Point
                position = Control.MousePosition
                position.Offset(_mouseMove.X, _mouseMove.Y)
                Me.Location = position
            End If

        End Sub


        Private isMouseDown As Boolean = False


        Private Sub panel_topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
            If e.Button = MouseButtons.Left Then
                isMouseDown = True
            End If
        End Sub


        Private Sub panel_topbar_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseUp
            isMouseDown = False
        End Sub

        ' Handle MouseMove event and check if the mouse is down
        Private Sub panel_topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove
            If isMouseDown Then
                ' Your logic here
                If Me.Size = New Size(1920, 1200) Then

                    Me.Location = New Point(160, 5)
                    Me.Size = New Size(1600, 1000)

                    button_max.Image = My.Resources.icons8_maximize_button_16
                End If
            End If
        End Sub










#End Region


#Region " gradient "

        'Private Sub mainWindow_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        '    ' Get the client area of the form
        '    Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

        '    ' Define the start and end colors for the gradient
        '    Dim startColor As Color = Color.Beige
        '    Dim endColor As Color = Color.AliceBlue

        '    ' Create a LinearGradientBrush
        '    Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
        '        ' Fill the rectangle with the gradient
        '        e.Graphics.FillRectangle(brush, rect)
        '    End Using
        'End Sub

        'Private Sub panel_topbar_Paint(sender As Object, e As PaintEventArgs) Handles panel_topbar.Paint

        '    Dim p As New Pen(Color.DarkGray, 1)
        '    Dim g As Graphics = Me.CreateGraphics

        '    g.DrawLine(p, 0, panel_topbar.Size.Height - 2, panel_topbar.Size.Width, panel_topbar.Size.Height - 2)


        'End Sub










#End Region


#Region "debug"

        'Private Sub btn_debug_Click(sender As Object, e As EventArgs) Handles btn_debug.Click

        '    Dim selectedCategoryIds As New List(Of Integer)

        '    ' if all is selected
        '    If radio_all.Checked() Then

        '        selectedCategoryIds.Clear()

        '    End If


        '    If radio_custom.Checked Then
        '        For Each control As Control In flowPanelCategory.Controls

        '            If TypeOf control Is CheckBox Then
        '                Dim checkBox As CheckBox = DirectCast(control, CheckBox)

        '                If checkBox.Checked Then
        '                    Dim categoryId As Integer = CInt(checkBox.Tag)
        '                    selectedCategoryIds.Add(categoryId)
        '                End If

        '            End If

        '        Next

        '    End If

        '    ' setting session manager ko ma value
        '    SessionManager.SelectedCategoryIds = selectedCategoryIds



        '    ' Display the selected category IDs
        '    If SessionManager.SelectedCategoryIds.Count > 0 Then
        '        ' Convert list of integers to a comma-separated string
        '        Dim categoryIdString As String = String.Join(", ", SessionManager.SelectedCategoryIds)
        '        MessageBox.Show("Selected Categories: " & categoryIdString)
        '    Else
        '        MessageBox.Show("No categories selected.")
        '    End If

        'End Sub



#End Region







    End Class
End NameSpace