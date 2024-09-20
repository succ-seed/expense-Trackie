﻿Imports expense_Trackie.Application

Namespace Presentation

    Public Class MonthView

        Dim _currentDate As DateTime = DateTime.Now


#Region " load form "



        Private Sub monthView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' setting display date
            UpdateDisplayInformation()



        End Sub

#End Region


#Region " update displayed information "



        ' reflecting changes in information
        Private Sub UpdateDisplayInformation()

            lbl_year.Text = _currentDate.ToString("yyyy")
            lbl_month.Text = _currentDate.ToString("MMM")
            lbl_amount.Text = GetTotal()

        End Sub

#End Region



#Region " get total "



        ' db ko kam
        Private Function GetTotal() As Decimal

            Dim expenseManager As New ExpenseManager()
            Return expenseManager.GetTotalOfMonth(_currentDate)

        End Function
#End Region



#Region " navigation "


        Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

            _currentDate = _currentDate.AddMonths(-1)

            'updating the date and total
            UpdateDisplayInformation()

        End Sub

        Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

            _currentDate = _currentDate.AddMonths(1)

            'updating the date and total
            UpdateDisplayInformation()

        End Sub
#End Region



    End Class
End NameSpace