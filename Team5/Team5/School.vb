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
    'Private _People() as Person waiting for others to finish up :)

    Public Sub New(numPeople As Integer, schoolName As String)
        'ReDim _People(numPeople) 
        _Id += 1
        _NumberOfStaffAndStudents = numPeople
        _SchoolName = schoolName
        _SchoolId = "SC_" + CStr(_Id)
    End Sub
    Public Property NumberOfStaffAndStudents As Integer
        Get
            Return _NumberOfStaffAndStudents
        End Get
        Set(value As Integer)
            _NumberOfStaffAndStudents = value
        End Set
    End Property
    Public Property TotalPassRate As Double
        Get
            Return _TotalPassRate
        End Get
        Set(value As Double)
            _TotalPassRate = value
        End Set
    End Property
    Public Property FailRate As Double
        Get
            Return _FailRate
        End Get
        Set(value As Double)
            _FailRate = value
        End Set
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
    Public Function PassRate() As Double
        _TotalPassRate = _FemalePassrate + _MalePassrate
        Return _TotalPassRate
    End Function
    Public Function CalcFailRate() As Double
        Return 100 - _TotalPassRate
    End Function
    Public Function CalcMaleDropOutRate() As String
        Dim MaleDropOut As String

        If MalepassRate < 50 Then
            MaleDropOut = "low"
        Else
            MaleDropOut = "high"
        End If
        Return MaleDropOut
    End Function
    Public Function FemaleDropOutRate() As String
        Dim FemaleDropOut As String

        If FemalePassRate < 50 Then
            FemaleDropOut = "low"
        Else
            FemaleDropOut = "high"
        End If
        Return FemaleDropOut
    End Function
<<<<<<< HEAD
    Public Overridable Function Display() As String
        Dim result As String
        result = "Pass rate: " & PassRate() & Environment.NewLine
        result &= "Fail rate: " & CalcFailRate() & Environment.NewLine
        result &= "Male drop out rate: " & CalcMaleDropOutRate() & Environment.NewLine
        result &= "female drop out rate: " & FemaleDropOutRate() & Environment.NewLine
        Return result
=======

    Public Function Display() As String
        Dim tempStr As String = ""
        tempStr &= "School Name: " & _SchoolName & Environment.NewLine
        tempStr &= "School Id: " + _SchoolId & Environment.NewLine
        tempStr &= "Total Pass Rate: " & CStr(_TotalPassRate) & Environment.NewLine
        tempStr &= "Total Fail Rate: " & CStr(_FailRate) & Environment.NewLine
        tempStr &= "Male Pass Rate: " & CStr(_MalePassrate) & Environment.NewLine
        tempStr &= "Female Pass Rate: " & CStr(_FemalePassrate) & Environment.NewLine
        tempStr &= "School personale: " & Environment.NewLine

        Return tempStr
>>>>>>> e45c5194b2114038600a240e7a3eb4886da3e1e3
    End Function
End Class
