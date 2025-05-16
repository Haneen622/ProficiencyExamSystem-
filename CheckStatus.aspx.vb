Public Class CheckStatus
    Inherits System.Web.UI.Page
    Dim obj As New DbOp
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            g.DataSource = obj.getstudentstatus(User.Identity.Name) ' make table for status
            g.DataBind()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub g_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g.SelectedIndexChanged

    End Sub
End Class