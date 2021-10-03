Option Explicit On
Option Strict On
Option Infer Off
Public Class Student
    Inherits Person
    Private _IsAttending As Boolean
    Private _HasPassed As Boolean
    Private _StudentID As String
    Private _TransportNeeded As Boolean
    Private _DistanceFromSchool As Integer

    Public Sub New(Name As String)
        MyBase.New(Name)
    End Sub

    Public ReadOnly Property IsAttending As Boolean
        Get
            Return _IsAttending
        End Get
    End Property

    Public ReadOnly Property HasPassed As Boolean
        Get
            Return _HasPassed
        End Get
    End Property

    Public Property StudentID As String
        Get
            Return _StudentID
        End Get
        Set(value As String)
            _StudentID = value
        End Set
    End Property

    Public Property TransportNeeded As Boolean
        Get
            Return _TransportNeeded
        End Get
        Set(value As Boolean)
            _TransportNeeded = value
        End Set
    End Property

    Public Property DistanceFromSchool As Integer
        Get
            Return _DistanceFromSchool
        End Get
        Set(value As Integer)
            _DistanceFromSchool = value
        End Set
    End Property

    Public Function calcTripFare() As Double
        Dim Price As Double
        Return Price * DistanceFromSchool
    End Function
End Class
