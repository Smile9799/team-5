Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class School

    Private Shared _Id As Integer
    Private _SchoolId As String
    Private _SchoolName As String
    Private _WeeklyFoods() As String = {"Samp", "Fish", "Rice", "Porridge", "Samp"}
    Private _TotalPassRate As Double
    Private _FailRate As Double
    Private _FemalePassrate As Double
    Private _MalePassrate As Double
    Private _NumberOfStaffAndStudents As Integer
    Private _People() As Person

    Public Sub New(numPeople As Integer, schoolName As String)
        ReDim _People(numPeople)
        _Id += 1
        _NumberOfStaffAndStudents = numPeople
        _SchoolName = schoolName
        _SchoolId = "SC_" + CStr(_Id)
    End Sub

    Public Property Person(index As Integer) As Person
        Get
            Return _People(index)
        End Get
        Set(value As Person)
            _People(index) = value
        End Set
    End Property

    Public ReadOnly Property People() As Person()
        Get
            Return _People
        End Get
    End Property
    Public Property NumberOfStaffAndStudents As Integer
        Get
            Return _NumberOfStaffAndStudents
        End Get
        Set(value As Integer)
            _NumberOfStaffAndStudents = value
        End Set
    End Property
    Public ReadOnly Property TotalPassRate As Double
        Get
            Return _TotalPassRate
        End Get
    End Property
    Public ReadOnly Property FailRate As Double
        Get
            Return _FailRate
        End Get
    End Property
    Public ReadOnly Property FemalePassRate As Double
        Get
            Return _FemalePassrate
        End Get
    End Property
    Public ReadOnly Property MalepassRate As Double
        Get
            Return _MalePassrate
        End Get
    End Property

    Public Function CalcMalePassRate() As Double
        Dim counterPass As Integer = 0
        Dim counterStudents As Integer = 0
        For s As Integer = 1 To _People.Length - 1
            Dim student As Student = TryCast(_People(s), Student)
            If Not student Is Nothing Then
                counterStudents += 1
                If student.HasPassed And student.Gender = "Male" Then
                    counterPass += 1
                End If
            End If
        Next
        _MalePassrate = (counterPass / counterStudents) * 100
        Return _MalePassrate
    End Function

    Public Function CalcFeMalePassRate() As Double
        Dim counterPass As Integer = 0
        Dim counterStudents As Integer = 0
        For s As Integer = 1 To _People.Length - 1
            Dim student As Student = TryCast(_People(s), Student)
            If Not student Is Nothing Then
                counterStudents += 1
                If student.HasPassed And student.Gender = "Female" Then
                    counterPass += 1
                End If
            End If
        Next
        _FemalePassrate = (counterPass / counterStudents) * 100
        Return _FemalePassrate
    End Function

    Public Function PassRate() As Double
        _TotalPassRate = CalcFeMalePassRate() + CalcMalePassRate()
        Return _TotalPassRate
    End Function
    Public Function CalcFailRate() As Double
        _FailRate = 100 - _TotalPassRate
        Return _FailRate
    End Function
    Public Function CalcMaleDropOutRate() As Double
        Dim counterDropout As Integer = 0
        Dim counterStudents As Integer = 0
        For s As Integer = 1 To _People.Length - 1
            Dim student As Student = TryCast(_People(s), Student)
            If Not student Is Nothing Then
                counterStudents += 1
                If Not student.IsAttending And student.Gender = "Male" Then
                    counterDropout += 1
                End If
            End If
        Next
        Return (counterDropout / counterStudents) * 100
    End Function
    Public Function CalcFemaleDropOutRate() As Double
        Dim counterDropout As Integer = 0
        Dim counterStudents As Integer = 0
        For s As Integer = 1 To _People.Length - 1
            Dim student As Student = TryCast(_People(s), Student)
            If Not student Is Nothing Then
                counterStudents += 1
                If Not student.IsAttending And student.Gender = "Female" Then
                    counterDropout += 1
                End If
            End If
        Next
        Return (counterDropout / counterStudents) * 100
    End Function
    Public Function Display() As String
        Dim tempStr As String = ""
        tempStr &= "School Name: " & _SchoolName & Environment.NewLine
        tempStr &= "School Id: " + _SchoolId & Environment.NewLine
        tempStr &= "Total Pass Rate: " & CStr(_TotalPassRate) & Environment.NewLine
        tempStr &= "Total Fail Rate: " & CStr(_FailRate) & Environment.NewLine
        tempStr &= "Male Pass Rate: " & CStr(_MalePassrate) & Environment.NewLine
        tempStr &= "Female Pass Rate: " & CStr(_FemalePassrate) & Environment.NewLine
        tempStr &= "Female DropOut Rate: " & CStr(CalcFemaleDropOutRate())
        tempStr &= "Male DropOut Rate: " & CStr(CalcMaleDropOutRate())
        tempStr &= "School personale: " & Environment.NewLine

        For p As Integer = 1 To _People.Length - 1
            Dim student As Student = TryCast(_People(p), Student)
            Dim educator As Educator = TryCast(_People(p), Educator)

            If Not student Is Nothing Then
                tempStr &= student.Display()
            End If

            If Not educator Is Nothing Then
                tempStr &= educator.Display()
            End If

        Next p

        Return tempStr
    End Function
End Class
