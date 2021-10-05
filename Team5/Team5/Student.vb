' *****************************************************************
' Git Repo: https://github.com/Smile9799/team-5
' Team Number: 5
' Team Member 1 Details: Muthanuni, ME (218002694)
' Team Member 2 Details: Qondelani, T (220149140)
' Team Member 3 Details: Mkhungeki, PAM (221014733)
' Team Member 4 Details: Qithi, YN (221015600)
' Practical: Team Project
' Class name: Student
' *****************************************************************

Option Explicit On
Option Strict On
Option Infer Off
<Serializable()> Public Class Student

    Inherits Person

    Private Shared _Id As Integer
    Private _IsAttending As Boolean
    Private _HasPassed As Boolean
    Private _StudentID As String
    Private _TransportNeeded As Boolean
    Private _DistanceFromSchool As Integer

    Public Sub New(studentName As String, age As Integer, gender As String, country As String, numSubjects As Integer, isAttending As Boolean, passed As Boolean, transportNeeded As Boolean, Optional distanceFromSchool As Integer = 0)

        MyBase.New(studentName, gender, age, country, numSubjects)

        _Id += 1
        _StudentID = "ST_" & CStr(_Id)
        _IsAttending = isAttending
        _HasPassed = passed
        _TransportNeeded = transportNeeded
        _DistanceFromSchool = distanceFromSchool
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

    Public ReadOnly Property StudentID As String
        Get
            Return _StudentID
        End Get
    End Property

    Public ReadOnly Property TransportNeeded As Boolean
        Get
            Return _TransportNeeded
        End Get
    End Property

    Public ReadOnly Property DistanceFromSchool As Integer
        Get
            Return _DistanceFromSchool
        End Get
    End Property

    'calculate student trip fare $ 5.2 per km
    Public Function calcTripFare() As Double
        Return 5.2 * _DistanceFromSchool
    End Function

    Private Function isAttendingStr() As String
        If _IsAttending Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function

    Private Function hasPassedStr() As String
        If _HasPassed Then
            Return "Yes"
        Else
            Return "No"
        End If
    End Function
    Public Overrides Function Display() As String
        Dim tempStr As String = ""
        tempStr &= "Student Id: " & _StudentID & Environment.NewLine
        tempStr &= MyBase.Display() & Environment.NewLine
        tempStr &= "Is Attending: " & isAttendingStr() & Environment.NewLine
        tempStr &= "Has Passed: " & hasPassedStr() & Environment.NewLine
        tempStr &= "Transport Fare: " & CStr("$") & CStr(calcTripFare()) & Environment.NewLine
        Return tempStr
    End Function
End Class
