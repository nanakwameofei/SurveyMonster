' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
Imports SurveyWCF.SurveyWCF

<ServiceContract()>
Public Interface ISurveyWCFService

    <OperationContract()>
    Function GetData(ByVal value As Integer) As String

    <OperationContract()>
    Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType

    ' TODO: Add your service operations here
    <OperationContract()>
    Function GetAllActiveSurveys() As List(Of SurveyWCF.Survey)

    <OperationContract>
    Function AddQuestion(SurveyId As Integer, Q As Question) As Boolean

    <OperationContract>
    Function CreateSurvey(S As Survey) As Survey

    <OperationContract>
    Function SaveTranscript(NewTranscript As Transcript) As Transcript

    <OperationContract>
    Function GetQuestionAnswer(QuestionId As Integer) As SurveyWCF.PossibleAnswer

    <OperationContract>
    Function GetQuestionPossibleAnswers(QuestionId As Integer)

    <OperationContract>
    Function GetSurveyQuestions(SurveyId As Integer)

    <OperationContract>
    Function GetSurvey(SurveyId As Integer) As SurveyWCF.Survey

    <OperationContract>
    Function GetAllSurveys() As List(Of SurveyWCF.Survey)



End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class CompositeType

    <DataMember()>
    Public Property BoolValue() As Boolean

    <DataMember()>
    Public Property StringValue() As String

End Class
