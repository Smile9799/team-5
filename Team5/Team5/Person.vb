Option Explicit On
Option Strict On
Option Infer Off
Public Class Person

    Private _Name As String
    Private _Gender As String
    Private _Age As Integer
    Private _Country As String
    Private _Subject() As Subject

    Public Sub New(Name As String)
        _Name = Name
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
            Return _Subject(index)
        End Get
        Set(value As Subject)
            _Subject(index) = value
        End Set
    End Property

    Public Overridable Function Dispaly() As String
        Dim Ans As String
        Ans = "Name :" & _Name & Environment.newline
        Ans &= "Gender :" & _Gender & Environment.newline
        Ans &= "Age :" & _Age & Environmenet.newline
        Ans &= "Country " & _Country & Environmenet.newline
        Return Ans
    End Function
End Class
