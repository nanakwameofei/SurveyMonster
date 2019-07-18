Public Class Question
    Private QuestionTextValue As String
    Public Property QuestionText() As String
        Get
            Return QuestionTextValue
        End Get
        Set(ByVal value As String)
            QuestionTextValue = value
        End Set
    End Property

    Private PossibleAnswersValue As IEnumerable(Of PossibleAnswer)
    Public Property PossibleAnswers() As IEnumerable(Of PossibleAnswer)
        Get
            Return PossibleAnswersValue
        End Get
        Set(ByVal value As IEnumerable(Of PossibleAnswer))
            PossibleAnswersValue = value
        End Set
    End Property
End Class
