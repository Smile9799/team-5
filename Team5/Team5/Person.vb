' *****************************************************************
' Git Repo: https://github.com/Smile9799/team-5
' Team Number: 5
' Team Member 1 Details: Muthanuni, ME (218002694)
' Team Member 2 Details: Qondelani, T (220149140)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: Person
' *****************************************************************

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
        Dim Ans As String = ""
        Ans = "Name :" & _Name & Environment.NewLine
        Ans &= "Gender :" & _Gender & Environment.NewLine
        Ans &= "Age :" & _Age & Environment.NewLine
        Ans &= "Country " & _Country & Environment.NewLine
        Ans &= "Subject Info: " & Environment.NewLine

        For s As Integer = 1 To _Subjects.Length - 1
            Ans &= "Subject Name: " & _Subjects(s).SubjectName & Environment.NewLine
            Ans &= "Subject Difficulty rating: " & CStr(_Subjects(s).DificultyRating) & Environment.NewLine
        Next s

        Return Ans
    End Function
End Class
