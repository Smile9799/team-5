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

    Public Property Subject() As subject
        Get
            Return _Subject()
        End Get
        Set(value As subject)
            _Subject() = value
        End Set
    End Property
End Class
