Option Strict On
Option Infer Off
Option Explicit On

<Serializable()> Public Class Country

    Private _NumSchools As Integer
    Private _CountryName As String
    Private _Schools() As School 'change it to school array later
    Private _CountryAverageLiteracyRate As Double
    Private Shared _Id As Integer
    Private _CountryId As String

    Public Sub New(numSchools As Integer, countryName As String)
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
        'To be implemented
    End Sub

End Class
