Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class School

    Private Shared _Id As Integer
    Private _SchoolId As String
    Private _SchoolName As String
    Private _WeeklyFoods() As String = {"Samp", "Fish", "Rice", "Porridge", "Samp"}
    Private _PassRate As Double
    Private _FailRate As Double
    Private _FemaleDropOut As Double
    Private _MaleDroupOut As Double
    Private _NumberOfStaffAndStudents As Integer
    'Private _People() as Person waiting for others to finish up :)

    Public Sub New(numPeople As Integer, schoolName As String)
        'ReDim _People(numPeople) 
        _Id += 1
        _NumberOfStaffAndStudents = numPeople
        _SchoolName = schoolName
        _SchoolId = "SC_" + CStr(_Id)
    End Sub
End Class
