' *****************************************************************
' Git Repo: https://github.com/Smile9799/team-5
' Team Number: 5
' Team Member 1 Details: Muthanuni, ME (218002694)
' Team Member 2 Details: Qondelani, T (220149140)
' Team Member 3 Details: Mkhungeki, PAM (221014733)
' Team Member 4 Details: Qithi, YN (221015600)
' Practical: Team Project
' Class name: Subject
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Subject

    Private _SubjectName As String
    Private _DificultyRating As Integer

    'constructor

    Public Sub New(d As Integer)
        _DificultyRating = d
    End Sub
    Public Sub New(Name As String, rating As Integer)
        _SubjectName = Name
        _DificultyRating = rating

    End Sub

    'property
    Public Property DificultyRating() As Integer
        Get
            Return _DificultyRating
        End Get
        Set(value As Integer)
            _DificultyRating = value
        End Set
    End Property

    Public ReadOnly Property SubjectName() As String
        Get
            Return _SubjectName
        End Get
    End Property
End Class
