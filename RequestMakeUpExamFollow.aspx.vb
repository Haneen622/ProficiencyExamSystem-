Public Class RequestMakeUpExamFollow
    Inherits System.Web.UI.Page
    Dim obj As New DbOp
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                Dim ds As New DataSet
                ds = obj.BindMakeupExamRequestsForFollow()
                g.DataSource = ds
                g.DataBind()
            Catch ex As Exception
                ' Optionally, log the exception
            End Try
        End If
    End Sub

    Protected Sub g_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g.SelectedIndexChanged

    End Sub
    Protected Sub g_RowCommand(sender As Object, e As GridViewCommandEventArgs)

        If e.CommandName = "Approve" Then
            ' Get UserID from CommandArgument
            Dim UserID As Integer = Convert.ToInt32(e.CommandArgument)

            ' Approve logic

            obj.ApproveFollowRequest(UserID)
            obj.UpdateRequestStatus(UserID)

            ' Update UI
            Dim row As GridViewRow = DirectCast(DirectCast(e.CommandSource, Control).NamingContainer, GridViewRow)
            Dim btnApprove As Button = DirectCast(row.FindControl("btnApprove"), Button)
            btnApprove.Text = "تم الموافقة"
            btnApprove.BackColor = System.Drawing.Color.DarkGreen
            btnApprove.ForeColor = System.Drawing.Color.White
            btnApprove.Enabled = False

            Dim lblStatus As Label = DirectCast(row.FindControl("lblStatus"), Label)
            If lblStatus IsNot Nothing Then
                lblStatus.Text = "تم الموافقة"
                lblStatus.ForeColor = System.Drawing.Color.DarkGreen
            End If
        ElseIf e.CommandName = "Reject" Then
            ' Get UserID from CommandArgument
            Dim userId As Integer = Convert.ToInt32(e.CommandArgument)

            ' Reject logic
            obj.RejectRequestFollow(userId)

            ' Update UI
            Dim row As GridViewRow = DirectCast(DirectCast(e.CommandSource, Control).NamingContainer, GridViewRow)
            Dim btnReject As Button = DirectCast(row.FindControl("btnReject"), Button)
            btnReject.Text = "تم الرفض"
            btnReject.BackColor = System.Drawing.Color.DarkRed
            btnReject.ForeColor = System.Drawing.Color.White
            btnReject.Enabled = False

            Dim lblStatus As Label = DirectCast(row.FindControl("lblStatus"), Label)
            If lblStatus IsNot Nothing Then
                lblStatus.Text = "تم الرفض"
                lblStatus.ForeColor = System.Drawing.Color.DarkRed
            End If
        End If
    End Sub
End Class