Public Class Survey
    Private TitleValue As String
    Public Property Title() As String
        Get
            Return TitleValue
        End Get
        Set(ByVal value As String)
            TitleValue = value
        End Set
    End Property

    Private DescriptionValue As String
    Public Property Description() As String
        Get
            Return DescriptionValue
        End Get
        Set(ByVal value As String)
            DescriptionValue = value
        End Set
    End Property

    Private StartDateValue As Date
    Public Property StartDate() As Date
        Get
            Return StartDateValue
        End Get
        Set(ByVal value As Date)
            StartDateValue = value
        End Set
    End Property

    Private EndDateValue As Date
    Public Property EndDate() As Date
        Get
            Return EndDateValue
        End Get
        Set(ByVal value As Date)
            EndDateValue = value
        End Set
    End Property

    Private QuestionsValue As IEnumerable(Of Question)
    Public Property Questions() As IEnumerable(Of Question)
        Get
            Return QuestionsValue
        End Get
        Set(ByVal value As IEnumerable(Of Question))
            QuestionsValue = value
        End Set
    End Property
End Class
