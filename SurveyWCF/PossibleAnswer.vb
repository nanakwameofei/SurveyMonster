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

    Partial Public Class PossibleAnswer
        Public Property Id As Integer
        Public Property PossibleAnswerText As String
        Public Property QuestionId As Integer
        Public Property DateCreated As Date
        Public Property CreatedBy As String
        Public Property LastModified As Nullable(Of Date)
        Public Property ModifiedBy As String
        Public Property IsCorrectAnswer As Boolean
    
        Public Overridable Property Question As Question
    
    End Class

End Namespace
