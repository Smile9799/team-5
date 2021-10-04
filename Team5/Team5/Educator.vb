Option Strict On
Option Explicit On
Option Infer Off
Public Class Educator
    Inherits Person
    Private _Remuneration As Double
    Private _Duration As Integer
    Private _Staffid As String
    Private _WorkHourDay As Integer

    Public Sub New(name As String, Dur As Integer, work As Integer)
        MyBase.New(name)
        _Duration = Dur
        _WorkHourDay = work
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
        Return _Remuneration
    End Function


End Class
