Option Strict On
Option Explicit On
Option Infer Off
Public Class Educator
    Public _Remuneration As Double
    Public _Duration As Integer
    Public _Staffid As String
    Public _WorkHourDay As Integer

    Public Sub New(r As Double, u As Integer, s As String, w As Integer)
        _Remuneration = r
        _Duration = u
        _Staffid = s
        _WorkHourDay = w
    End Sub

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

    Public Function calcRemuneration() As Double
        _Remuneration = _WorkHourDay * _Duration
    End Function


End Class
