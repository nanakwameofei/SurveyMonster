Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class SurveyController
        Inherits ApiController

        Private Countries() As String = {"Ghana", "Togo", "japan", "India", "Germany", "Belgium", "Liberia"}

        Public Function GetCountries() As IEnumerable(Of String)
            Return Countries
        End Function

        Public Function GetCountry(Id As Integer) As String
            Return Countries(Id)
        End Function

        Public Function PostCountry(<FromBody> value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                Countries = Countries.Append(value)
                Return Countries
            Else
                Return "Error occurred"
            End If
        End Function

        'Public Function GetRandomCountry() As String
        '    Dim lst As New List(Of KeyValuePair(Of String, String))
        '    For Each x As String In Countries
        '        Dim c As New KeyValuePair(Of String, String)(Guid.NewGuid.ToString, x)
        '        lst.Add(c)
        '    Next
        '    Return (From i As KeyValuePair(Of String, String) In lst
        '            Order By i.Key
        '            Select i.Value).FirstOrDefault
        'End Function
    End Class
End Namespace