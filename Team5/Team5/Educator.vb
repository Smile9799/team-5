Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Educator

    Inherits Person

    'declaring variables
    Private Shared _Id As Integer
    Private _Remuneration As Double
    Private _Duration As Integer
    Private _StaffId As String
    Private _WorkHourDay As Integer

    'constructor
    Public Sub New(Name As String, age As Integer, gender As String, country As String, duration As Integer, hours As Integer, Optional numSubjects As Integer = 1)
        MyBase.New(Name, gender, age, country, numSubjects)
        _Id += 1
        _StaffId = "STFF_" + CStr(_Id)
        _Duration = duration
        _WorkHourDay = hours
    End Sub

    'properties
    Public ReadOnly Property Remuneration() As Double
        Get
            Return _Remuneration
        End Get
    End Property

    Public ReadOnly Property StaffId() As String
        Get
            Return _StaffId
        End Get
    End Property

    Public Property Duration() As Integer
        Get
            Return _Duration
        End Get
        Set(value As Integer)
            _Duration = value
        End Set
    End Property

    'calculating remuneration
    Public Function calcRemuneration() As Double
        _Remuneration = _WorkHourDay * _Duration * 12
        Return _Remuneration
    End Function

    Public Overrides Function Display() As String
        Dim Ans As String = ""
        Ans &= "StaffId :" & _StaffId & Environment.NewLine
        Ans &= MyBase.Display() & Environment.NewLine
        Ans &= "Duration :" & CStr(_Duration) & Environment.NewLine
        Ans &= "Work Hours/ Day :" & CStr(_WorkHourDay) & Environment.NewLine
        Ans &= "Salary " & CStr(_Remuneration) & Environment.NewLine
        Return Ans
    End Function
End Class
