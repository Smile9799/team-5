Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class Country
    Inherits School
    Private _NumSchools As Integer
    Private _CountryName As String
    Private _Schools() As School 'change it to school array later
    Private _CountryAverageLiteracyRate As Double
    Private Shared _Id As Integer
    Private _CountryId As String

    Public Sub New(numSchools As Integer, countryName As String, numPeople As Integer, schoolName As String)
        MyBase.New(numPeople, schoolName)
        ReDim _Schools(numSchools)
        _Id += 1
        _CountryId = "CO_" + CStr(_Id)
        _NumSchools = numSchools
        _CountryName = countryName
    End Sub

    Public Property School(index As Integer) As School
        Get
            Return _Schools(index)
        End Get
        Set(value As School)
            _Schools(index) = value
        End Set
    End Property
    Public Property numSchools As Integer
        Get
            Return _NumSchools
        End Get
        Set(value As Integer)
            _NumSchools = value
        End Set
    End Property

    Public ReadOnly Property CountryName() As String
        Get
            Return _CountryName
        End Get
    End Property

    Public ReadOnly Property CountryId() As String
        Get
            Return _CountryId
        End Get
    End Property

    Public ReadOnly Property CountryAverageLiteracyRate() As Double
        Get
            Return _CountryAverageLiteracyRate
        End Get
    End Property

    Public Sub CalculateLiteracyRate()
        Dim totalPassRate As Double = 0.0

        For s As Integer = 1 To _Schools.Length - 1
            totalPassRate += _Schools(s).PassRate()
        Next

        _CountryAverageLiteracyRate = (totalPassRate / numSchools) * 100
    End Sub
    'Public Overrides Function Display() As String
    '    Dim result As String
    '    result = "Literacy rate: " & CalculateLiteracyRate() & Environment.NewLine
    '    Return result
    'End Function
End Class
