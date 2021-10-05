Option Strict On
Option Explicit On
Option Infer Off
Public Class Educator
    Inherits Person
    'declaring variables
    Public _Remuneration As Double
    Public _Duration As Integer
    Public _Staffid As String
    Public _WorkHourDay As Integer

    'constructor
    Public Sub New(Name As String, r As Double, u As Integer, s As String, w As Integer, gender As String, age As Integer, country As String, numSubjects As Integer)
        MyBase.New(Name, gender, age, country, numSubjects)
        _Remuneration = r
        _Duration = u
        _Staffid = s
        _WorkHourDay = w
    End Sub

    'properties
    Public ReadOnly Property Remuneration As Double
        Get
            Return _Remuneration
        End Get
    End Property

    Public Property Duration As Integer
        Get
            Return _Duration
        End Get
        Set(value As Integer)
            _Duration = value
        End Set
    End Property

    'calculating remuneration
    Public Function calcRemuneration() As Double
        _Remuneration = _WorkHourDay * _Duration
        Return _Remuneration
    End Function


End Class
