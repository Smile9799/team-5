' *****************************************************************
' Git Repo: https://github.com/Smile9799/team-5
' Team Number: 5
' Team Member 1 Details: Muthanuni, ME (218002694)
' Team Member 2 Details: Qondelani, T (220149140)
' Team Member 3 Details: Surname, Initials (Student #)
' Team Member 4 Details: e.g. Smith, J (202000001)
' Practical: Team Project
' Class name: frmGov
' *****************************************************************

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

    'Save info to file sequentially
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

    'read from file and returns an array of countries
    Private Function ReadFromFile() As Country()
        If File.Exists(FILE_NAME) Then
            FS = New FileStream(FILE_NAME, FileMode.Open, FileAccess.Read)
            BF = New BinaryFormatter()
            Dim counter As Integer = 1
            While FS.Position < FS.Length
                counter += 1
                ReDim Preserve Countries(counter)
                Countries(counter) = DirectCast(BF.Deserialize(FS), Country)
            End While
        End If
        FS.Close()
        Return Countries
    End Function

    'Display country and other information about country
    Private Sub DisplayInfo(Countries() As Country)
        If Countries Is Nothing Then
            MessageBox.Show("Nothing to read")
        Else
            For c As Integer = 1 To Countries.Length - 1
                If Not Countries(c) Is Nothing Then
                    txtDisplay.Text &= Countries(c).Display()
                    txtDisplay.Text &= "============================================"
                    txtDisplay.Text &= Environment.NewLine & Environment.NewLine
                End If
            Next c
        End If
    End Sub

    'captures country data
    Private Sub btnCaptureData_Click(sender As Object, e As EventArgs) Handles btnCaptureData.Click
        Dim numCountries As Integer = CInt(InputBox("Enter number of countries"))
        ReDim Countries(numCountries)

        For c As Integer = 1 To Countries.Length - 1
            Dim countryName As String = InputBox("Please enter country name")
            Dim numSchools As Integer = CInt(InputBox("Please enter number of schools"))
            Dim schoolName As String
            Dim numPeople As Integer
            Countries(c) = New Country(numSchools, countryName, numPeople)

            For s As Integer = 1 To numSchools
                schoolName = InputBox("Please enter school name")
                Dim schoolPersonale As Integer = CInt(InputBox("Please enter number of people in school this includes students and staff"))

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

    'print countries data
    Private Sub btnDisplayInfo_Click(sender As Object, e As EventArgs) Handles btnDisplayInfo.Click

        txtDisplay.Clear()
        Dim countries As Country() = ReadFromFile()
        DisplayInfo(countries)
        MessageBox.Show("Done reading...")
        txtDisplay.Visible = True
    End Sub

    'prints only countries stats
    Private Sub btnCountryStats_Click(sender As Object, e As EventArgs) Handles btnCountryStats.Click
        Dim countries As Country() = ReadFromFile()
        If countries Is Nothing Then
            MessageBox.Show("Storage is empty try saving some information first")
        Else
            txtDisplay.Clear()
            txtDisplay.Visible = True
            For c As Integer = 1 To countries.Length - 1
                If Not countries(c) Is Nothing Then
                    txtDisplay.Text &= "Country Id: " & countries(c).CountryId & Environment.NewLine
                    txtDisplay.Text &= "Country Name: " & countries(c).CountryName & Environment.NewLine
                    txtDisplay.Text &= "Literacy rate: " & countries(c).CalculateLiteracyRate() & CStr("%") & Environment.NewLine
                    txtDisplay.Text &= Environment.NewLine
                End If
            Next
        End If

    End Sub

    'calculates the worst and best country
    Private Sub btnWorstAndBestCountries_Click(sender As Object, e As EventArgs) Handles btnWorstAndBestCountries.Click
        Dim SavedCountries() As Country

        If countries Is Nothing Then
        Else
            Dim numCountries As Integer = 0
            Dim countries() As Country = ReadFromFile()
            For c As Integer = 1 To countries.Length - 1
                Dim country As Country = TryCast(countries(c), Country)
                If Not country Is Nothing Then
                    numCountries += 1
                    ReDim Preserve SavedCountries(numCountries)
                    SavedCountries(numCountries) = country
                End If
            Next

            txtDisplay.Clear()
            txtDisplay.Visible = True
            txtDisplay.Text &= "Best Country : " & Environment.NewLine
            txtDisplay.Text &= BestCountry(SavedCountries).DisplayCountryInfo()
            txtDisplay.Text &= "Worst Country : " & Environment.NewLine
            txtDisplay.Text &= WorstCountry(SavedCountries).DisplayCountryInfo()
        End If
    End Sub

    Private Sub frmGov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.Visible = False
    End Sub

    Private Function WorstCountry(savedCountries As Country()) As Country

        Dim worstLiteracyRate As Double = savedCountries(1).CalculateLiteracyRate()
        Dim worstIndex As Integer = 1

        For c As Integer = 1 To savedCountries.Length - 1
            If savedCountries(c).CalculateLiteracyRate() < worstLiteracyRate Then
                worstLiteracyRate = savedCountries(c).CalculateLiteracyRate()
                worstIndex = c
            End If
        Next
        Return savedCountries(worstIndex)
    End Function

    Private Function BestCountry(savedCountries As Country()) As Country
        Dim bestLiteracyRate As Double = savedCountries(1).CalculateLiteracyRate()
        Dim bestIndex As Integer = 1

        For c As Integer = 1 To savedCountries.Length - 1
            If savedCountries(c).CalculateLiteracyRate() < bestLiteracyRate Then
                bestLiteracyRate = savedCountries(c).CalculateLiteracyRate()
                bestIndex = c
            End If
        Next
        Return savedCountries(bestIndex)
    End Function

End Class
