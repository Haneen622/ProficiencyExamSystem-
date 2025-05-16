Public Class Main
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If Page.User.Identity.IsAuthenticated = False Then
        '    Response.Redirect("login.aspx")
        'End If

    End Sub

    'Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

    '    ' Redirect to a default page if no referrer
    '    Response.Redirect("~/homeAQAC.aspx")


    'End Sub

    Protected Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Get the home page from the session or use a default
        Dim redirectTo As String = Session("RedirectToPage")

        ' Check if the session value exists; if not, redirect to a default page
        If String.IsNullOrEmpty(redirectTo) Then
            Response.Redirect("~/homeAQAC.aspx") ' Default
        Else
            Response.Redirect(redirectTo) ' Redirect to the home page based on session
        End If
    End Sub


End Class