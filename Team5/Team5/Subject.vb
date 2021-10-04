Option Strict On
Option Explicit On
Option Infer Off
<<<<<<< HEAD
Public Class Subject
    Private _SubjectName As String
    Private _DificultyRating As Integer

    Public Sub New(subName As String, Dif As Integer)
        _SubjectName = subName
        _DificultyRating = Dif
    End Sub
=======
<Serializable()> Public Class Subject

    Private _SubjectName As String
    Private _DificultyRating As Integer
>>>>>>> 519c84ab084146de9bd7a0c09d214094f900226e

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
