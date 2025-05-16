Public Class homeFollowUp
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogout_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear the session data
        Session.Clear()
        Session.Abandon()

        ' Redirect to the login page
        Response.Redirect("~/Login.aspx") ' Adjust path if necessary
    End Sub


End Class