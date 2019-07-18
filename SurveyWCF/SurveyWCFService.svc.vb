' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Imports System.IO
Imports SurveyWCF.SurveyWCF

Public Class SurveyWCFService
    Implements ISurveyWCFService

    Public Sub New()
    End Sub

    Private Countries() As String = {"Ghana", "Togo", "japan", "India", "Germany", "Belgium", "Liberia"}
    Public Function GetData(ByVal value As Integer) As String Implements ISurveyWCFService.GetData
        'Return String.Format("You entered: {0}", value)

        Return Countries(value)

    End Function

    Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements ISurveyWCFService.GetDataUsingDataContract
        If composite Is Nothing Then
            Throw New ArgumentNullException("composite")
        End If
        If composite.BoolValue Then
            composite.StringValue &= "Suffix"
        End If
        Return composite
    End Function

    Public Function GetAllActiveSurveys() As List(Of SurveyWCF.Survey) Implements ISurveyWCFService.GetAllActiveSurveys
        Dim AllActiveSurveys As New List(Of SurveyWCF.Survey)
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                AllActiveSurveys = (From i As SurveyWCF.Survey In entities.Surveys
                                    Where i.IsActive = True
                                    Order By i.SurveyTitle
                                    Select i).ToList

                Return AllActiveSurveys
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetAllSurveys() As List(Of SurveyWCF.Survey) Implements ISurveyWCFService.GetAllSurveys
        Dim AllSurveys As New List(Of SurveyWCF.Survey)
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                AllSurveys = (From i As SurveyWCF.Survey In entities.Surveys
                              Order By i.SurveyTitle
                              Select i).ToList

                Return AllSurveys
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSurvey(SurveyId As Integer) As SurveyWCF.Survey Implements ISurveyWCFService.GetSurvey
        Dim SelectedSurvey As SurveyWCF.Survey
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                SelectedSurvey = (From i As SurveyWCF.Survey In entities.Surveys
                                  Where i.Id = SurveyId
                                  Order By i.SurveyTitle
                                  Select i).FirstOrDefault

                Return SelectedSurvey
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetSurveyQuestions(SurveyId As Integer) Implements ISurveyWCFService.GetSurveyQuestions
        Dim SurveyQuestions As New List(Of SurveyWCF.Question)
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                SurveyQuestions = (From i As SurveyWCF.Question In entities.Questions
                                   Where i.SurveyId = SurveyId
                                   Select i).ToList

                Return SurveyQuestions
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetQuestionPossibleAnswers(QuestionId As Integer) Implements ISurveyWCFService.GetQuestionPossibleAnswers
        Dim PossibleAnswers As New List(Of SurveyWCF.PossibleAnswer)
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                PossibleAnswers = (From i As SurveyWCF.PossibleAnswer In entities.PossibleAnswers
                                   Where i.QuestionId = QuestionId
                                   Select i).ToList

                Return PossibleAnswers
            End Using
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function GetQuestionAnswer(QuestionId As Integer) As SurveyWCF.PossibleAnswer Implements ISurveyWCFService.GetQuestionAnswer
        Dim CorrectAnswer As SurveyWCF.PossibleAnswer
        Try
            Using entities As New SurveyWCF.SurveyMonsterEntities
                CorrectAnswer = (From i As SurveyWCF.PossibleAnswer In entities.PossibleAnswers
                                 Where i.IsCorrectAnswer = True
                                 Select i).FirstOrDefault

                Return CorrectAnswer
            End Using
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function SaveTranscript(NewTranscript As Transcript) As Transcript Implements ISurveyWCFService.SaveTranscript
        Try
            Using entities As New SurveyMonsterEntities
                With NewTranscript
                    .DateCreated = Now

                End With

                entities.Transcripts.Add(NewTranscript)
                entities.SaveChanges()
            End Using

            Return NewTranscript
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CreateSurvey(S As Survey) As Survey Implements ISurveyWCFService.CreateSurvey
        Try
            Using entities As New SurveyMonsterEntities
                With S
                    .DateCreated = Now
                End With

                entities.Surveys.Add(S)
                entities.SaveChanges()

            End Using

            Return S
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function AddQuestion(SurveyId As Integer, Q As Question) As Boolean Implements ISurveyWCFService.AddQuestion
        Try
            Using entities As New SurveyMonsterEntities
                With Q
                    .DateCreated = Now
                    .SurveyId = SurveyId
                End With

                entities.Questions.Add(Q)
                entities.SaveChanges()

                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
