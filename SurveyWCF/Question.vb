'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Namespace SurveyWCF

    Partial Public Class Question
        Public Property Id As Integer
        Public Property QuestionText As String
        Public Property SurveyId As Integer
        Public Property CreatedBy As String
        Public Property DateCreated As Date
        Public Property LastModified As Nullable(Of Date)
        Public Property LastModifiedBy As String
    
        Public Overridable Property PossibleAnswers As ICollection(Of PossibleAnswer) = New HashSet(Of PossibleAnswer)
        Public Overridable Property Survey As Survey
        Public Overridable Property Transcripts As ICollection(Of Transcript) = New HashSet(Of Transcript)
        Public Overridable Property TranscriptItems As ICollection(Of TranscriptItem) = New HashSet(Of TranscriptItem)
    
    End Class

End Namespace