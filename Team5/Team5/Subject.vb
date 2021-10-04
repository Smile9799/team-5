Option Strict On
Option Explicit On
Option Infer Off
Public Class Subject
    Private _SubjectName As String
    Private _DificultyRating As Integer

    Public Sub New(subName As String, Dif As Integer)
        _SubjectName = subName
        _DificultyRating = Dif
    End Sub

    Public ReadOnly Property SubjectName As String
        Get
            Return _SubjectName
        End Get
    End Property

    Public Property DificultyRating As Integer
        Get
            Return _DificultyRating
        End Get
        Set(value As Integer)
            _DificultyRating = value
        End Set
    End Property
End Class
