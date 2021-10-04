Option Strict On
Option Explicit On
Option Infer Off


Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmGov

    Private FS As FileStream
    Private BF As BinaryFormatter

    Private Const FILE_NAME As String = "Phila.ifm"

    Private Countries() As Country

    Private Sub SaveToFile(Countries() As Country)
        FS = New FileStream(FILE_NAME, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()

        If Countries Is Nothing Then
            MessageBox.Show("Nothing to save please gather some information first :)")
        Else
            For c As Integer = 1 To Countries.Length - 1
                BF.Serialize(FS, Countries(c))
            Next
        End If

        FS.Close()
    End Sub
    Private Sub btnCaptureData_Click(sender As Object, e As EventArgs) Handles btnCaptureData.Click
        Dim numCountries As Integer = CInt(InputBox("Enter number of countries"))
        ReDim Countries(numCountries)

        For c As Integer = 1 To Countries.Length - 1
            Dim countryName As String = InputBox("Please enter country name")
            Dim numSchools As Integer = CInt(InputBox("Please enter number of schools"))

            Countries(c) = New Country(numSchools, countryName)

            For s As Integer = 1 To numSchools
                Dim schoolName As String = InputBox("Please enter school name")
                Dim schoolPersonale As Integer = CInt(InputBox("Please enter numbe of people in school this includes students and staff"))

                Countries(c).School(s) = New School(schoolPersonale, schoolName)

                For p As Integer = 1 To schoolPersonale

                Next p
            Next s
        Next c

        SaveToFile(Countries)
    End Sub

    Private Sub frmGov_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
