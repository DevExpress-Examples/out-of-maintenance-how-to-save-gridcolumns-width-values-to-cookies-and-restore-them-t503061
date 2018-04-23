Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

''' <summary>
''' Summary description for Source
''' </summary>
Public Class Source
    Private Const count As Integer = 5
    Public Function PopulateList() As List(Of Category)
        Dim list As New List(Of Category)()
        For i As Integer = 0 To 4
            list.Add(New Category() With {.CategoryID = i, .CategoryName = "Name" & i, .Description = "Description" & i})
        Next i
        Return list
    End Function
End Class