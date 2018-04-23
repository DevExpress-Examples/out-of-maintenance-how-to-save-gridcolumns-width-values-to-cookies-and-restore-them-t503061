Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            ASPxGridView1.DataBind()
            Me.AssignColumnWidths()
        End If
    End Sub

    Public ReadOnly Property ListOfCategories() As List(Of Category)
        Get
            If Session("ListOfCategories") Is Nothing Then
                Session("ListOfCategories") = (New Source()).PopulateList()
            End If
            Return TryCast(Session("ListOfCategories"), List(Of Category))
        End Get
    End Property
    Public Sub AssignColumnWidths()
        Dim cookie As HttpCookie = Request.Cookies("ASPxGridViewColumnWidths")
        If cookie IsNot Nothing Then
            Dim value As String = Server.UrlDecode(cookie.Value)
            Dim indexWidthPairs() As String = value.Split("|"c).Where(Function(x) (Not String.IsNullOrEmpty(x))).ToArray()
            For Each s As String In indexWidthPairs
                Dim indexWidth() As String = s.Split("="c)
                ASPxGridView1.Columns(Integer.Parse(indexWidth(0))).Width = Integer.Parse(indexWidth(1))
            Next s
        End If
    End Sub


    Protected Sub ASPxGridView1_ClientLayout(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClientLayoutArgs)
        If e.LayoutMode = DevExpress.Web.ClientLayoutMode.Saving Then
            Session("GridLayout") = ASPxGridView1.SaveClientLayout()
        Else
            If Session("GridLayout") IsNot Nothing Then
                e.LayoutData = DirectCast(Session("GridLayout"), String)
                Me.AssignColumnWidths()
            End If
        End If
    End Sub

    Protected Sub ASPxGridView1_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
        ASPxGridView1.DataSource = ListOfCategories
    End Sub
End Class