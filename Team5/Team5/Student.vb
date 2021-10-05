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
    Private _AmountForTransport As Double

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
            _DistanceFromSchool = Validate(value)
        End Set
    End Property

    Public Property AmountForTransport As Double
        Get
            Return _AmountForTransport
        End Get
        Set(value As Double)
            _AmountForTransport = value
        End Set
    End Property

    Public Function calcTripFare() As Double

        Return AmountForTransport * DistanceFromSchool
    End Function

    Public Function Validate() As Integer
        If DistanceFromSchool < 0 Then
            _DistanceFromSchool = 0
        Else
            _DistanceFromSchool = value
        End If
    End Function

    Public Overrides Function Display() As String
        Dim Ans As String = environment.newline & MyBase.Display
        Ans &= "Is Attending :" & _IsAttending & Environment.newline
        Ans &= "Has Passed :" & _HasPassed & Environment.newline
        Ans &= "Student ID :" & _StudentID & Environment.newline
        Ans &= "Transport Needed :" & _TransportNeeded & Environment.newline
        Ans &= "Distance From School :" & _DistanceFromSchool & Environment.newline
        Ans &= "Amount for Transport :" & _AmountForTransport & Environment.newline
        Ans &= "Calulation For Trip Fare :" & calcTripFare() & environment.newline

        Return Ans
    End Function
End Class
