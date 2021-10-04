Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Subject

    Private _SubjectName As String
    Private _DificultyRating As Integer

    'constructor
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
