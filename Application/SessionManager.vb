﻿Public Class SessionManager

    Private Sub New()

    End Sub

    Private Shared _instance As SessionManager


    ' user Info
    Public Property currentUserId As Integer = 1
    Public Property currentUsername As String = "johndoe"
    Public Property currentNumber As String
    Public Property currentPassword As String
    Public Property currentLoginTime As DateTime
    Public Property currentProfileLink As String
    Public Property currentdateJoined As DateTime




    ' expense display management
    Public Property currentDate As DateTime



    Public Shared ReadOnly Property Instance() As SessionManager
        Get
            If _instance Is Nothing Then
                _instance = New SessionManager()
            End If
            Return _instance
        End Get
    End Property



    ' selcted category
    Private Shared _selectedCategoryIds As List(Of Integer)

    Public Shared Property SelectedCategoryIds As List(Of Integer)
        Get
            If _selectedCategoryIds Is Nothing Then
                _selectedCategoryIds = New List(Of Integer)
            End If
            Return _selectedCategoryIds
        End Get
        Set(value As List(Of Integer))
            _selectedCategoryIds = value
        End Set
    End Property



End Class




' to access
' SessionManager.Instance._____ = what we want to assign