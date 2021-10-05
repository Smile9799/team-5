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
        MessageBox.Show("Infomation has been saved :)")
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

                    Dim typePerson As Integer = CInt(InputBox("Select the person you wish to save" & Environment.NewLine & "1. Student" & Environment.NewLine & "2. Educator"))

                    Dim personName As String = InputBox("Please enter person name")
                    Dim personAge As Integer = CInt(InputBox("Please enter person age"))
                    Dim personGender As String = InputBox("Please enter person gender")
                    Dim numSubject As Integer = CInt(InputBox("Enter number of subjects"))
                    ' check if the user is the educator or student

                    If typePerson = 1 Then

                        Dim studentAttending As Integer = CInt(InputBox("Is the student still attending? " & Environment.NewLine & "1. Yes" & Environment.NewLine & "2.No"))
                        Dim isAttending As Boolean = False
                        If studentAttending = 1 Then
                            isAttending = True
                        Else
                            isAttending = False
                        End If

                        Dim studentPassed As Integer = CInt(InputBox("Has the student passed? " & Environment.NewLine & "1. Yes" & Environment.NewLine & "2.No"))
                        Dim hasPassed As Boolean = False
                        If studentPassed = 1 Then
                            hasPassed = True
                        Else
                            hasPassed = False
                        End If

                        Dim studentTransport As Integer = CInt(InputBox("Is the student in need of transport? " & Environment.NewLine & "1. Yes" & Environment.NewLine & "2.No"))
                        Dim distanceFromSchool As Integer
                        Dim needTransport As Boolean = False
                        If studentTransport = 1 Then
                            needTransport = True
                            distanceFromSchool = CInt(InputBox("Please enter the distance from school"))
                        Else
                            needTransport = False
                            distanceFromSchool = 0
                        End If

                        Countries(c).School(s).Person(p) = New Student(personName, personAge, personGender, countryName, numSubject, isAttending, hasPassed, needTransport, distanceFromSchool)

                    ElseIf typePerson = 2 Then
                        Dim personCountry As String = InputBox("Please enter person country")
                        Dim duration As Integer = CInt(InputBox("How many months will this person be working"))
                        Dim workPerDay As Integer = CInt(InputBox("How many hours per day will this person work"))
                        Countries(c).School(s).Person(p) = New Educator(personName, personAge, personGender, personCountry, duration, workPerDay, numSubject)
                    End If

                    For subj As Integer = 1 To numSubject
                        Dim subjectName As String = InputBox("Please enter the subject name")
                        Dim subjectRating As Integer = CInt(InputBox("Please enter the subject difficulty rating"))
                        Countries(c).School(s).Person(p).Subject(subj) = New Subject(subjectName, subjectRating)
                    Next subj

                Next p
            Next s
        Next c

        SaveToFile(Countries)
    End Sub

End Class
