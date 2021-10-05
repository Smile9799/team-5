Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Subject

    Private _SubjectName As String
    Private _DificultyRating As Integer

    'constructor
<<<<<<< HEAD
    Public Sub New(Name As String, d As Integer, gender As String, age As Integer, country As String, numSubjects As Integer)
        MyBase.New(Name, gender, age, country, numSubjects)
        _DificultyRating = d
=======
    Public Sub New(Name As String, rating As Integer)
        _SubjectName = Name
        _DificultyRating = rating
>>>>>>> e45c5194b2114038600a240e7a3eb4886da3e1e3
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
