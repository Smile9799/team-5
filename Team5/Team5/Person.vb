Option Explicit On
Option Strict On
Option Infer Off
<Serializable()> Public Class Person

    Private _Name As String
    Private _Gender As String
    Private _Age As Integer
    Private _Country As String
    Private _Subjects() As Subject

    Public Sub New(Name As String, gender As String, age As Integer, country As String, numSubjects As Integer)
        _Name = Name
        _Gender = gender
        _Age = age
        _Country = country
        ReDim _Subjects(numSubjects)
    End Sub

    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public ReadOnly Property Gender As String
        Get
            Return _Gender
        End Get
    End Property

    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            _Age = value
        End Set
    End Property

    Public ReadOnly Property Country As String
        Get
            Return _Country
        End Get
    End Property

    Public Property Subject(index As Integer) As Subject
        Get
            Return _Subjects(index)
        End Get
        Set(value As Subject)
            _Subjects(index) = value
        End Set
    End Property

    Private ReadOnly Property Subjects() As Subject()
        Get
            Return _Subjects
        End Get
    End Property
    Public Overridable Function Display() As String
        Dim Ans As String
        Ans = "Name :" & _Name & Environment.NewLine
        Ans &= "Gender :" & _Gender & Environment.NewLine
        Ans &= "Age :" & _Age & Environment.NewLine
        Ans &= "Country " & _Country & Environment.NewLine
        Return Ans
    End Function
End Class
