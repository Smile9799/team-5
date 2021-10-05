Option Strict On
Option Explicit On
Option Infer Off
Public Class Subject
    Inherits Person
    Public _DificultyRating As Integer
    'constructor
    Public Sub New(Name As String, d As Integer, gender As String, age As Integer, country As String, numSubjects As Integer)
        MyBase.New(Name, gender, age, country, numSubjects)
        _DificultyRating = d
    End Sub

    'property
    Public Property DificultyRating As Integer
        Get
            Return _DificultyRating
        End Get
        Set(value As Integer)
            _DificultyRating = value
        End Set
    End Property
End Class
