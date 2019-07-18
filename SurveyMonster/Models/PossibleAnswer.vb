Public Class PossibleAnswer
    Private PossibleAnswerTextValue As String
    Public Property PossibleAnswerText() As String
        Get
            Return PossibleAnswerTextValue
        End Get
        Set(ByVal value As String)
            PossibleAnswerTextValue = value
        End Set
    End Property

    Private IsCorrectAnswerValue As Boolean
    Public Property IsCorrectAnswer() As Boolean
        Get
            Return IsCorrectAnswerValue
        End Get
        Set(ByVal value As Boolean)
            IsCorrectAnswerValue = value
        End Set
    End Property
End Class
