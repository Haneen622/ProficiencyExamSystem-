Public Class home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Clear the session data
        Session.Clear() ' Clears all session variables
        Session.Abandon() ' Abandons the session

        ' Sign out from forms authentication
        FormsAuthentication.SignOut()


        ' Redirect to the login page
        Response.Redirect("login.aspx")



    End Sub
End Class