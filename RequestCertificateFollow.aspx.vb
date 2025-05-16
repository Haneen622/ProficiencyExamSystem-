Public Class RequestCertificateFollow
    Inherits System.Web.UI.Page
    dim obj as New DbOp 
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Ensure this block runs only when the page is loaded for the first time, not on every postback
        If Not IsPostBack Then
            Try
                Dim ds As New DataSet
                ds = obj.BindCertificateRequestsForFollow()
                g.DataSource = ds
                g.DataBind()
            Catch ex As Exception
                ' Optionally, log the exception
            End Try
        End If
    End Sub

    Protected Sub g_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        If e.CommandName = "Approve" Then
            ' Get the UserID from CommandArgument
            Dim userId As Integer = Convert.ToInt32(e.CommandArgument)

            ' Update the database with the approval
            obj.ApproveFollowRequest(userId)
            obj.UpdateRequestStatus(userId)
            ' Find the clicked button in the GridView row
            Dim row As GridViewRow = DirectCast(DirectCast(e.CommandSource, Control).NamingContainer, GridViewRow)
            Dim btnApprove As Button = DirectCast(row.FindControl("btnApprove"), Button)

            ' Update the button properties to indicate approval
            btnApprove.Text = "تم الموافقة"
            btnApprove.BackColor = System.Drawing.Color.DarkGreen
            btnApprove.ForeColor = System.Drawing.Color.White
            btnApprove.Enabled = False

            ' Optionally display an approval status in another column (if needed)
            Dim lblStatus As Label = DirectCast(row.FindControl("lblStatus"), Label)
            If lblStatus IsNot Nothing Then
                lblStatus.Text = "تم الموافقة"
                lblStatus.ForeColor = System.Drawing.Color.DarkGreen
            End If
        ElseIf e.CommandName = "Reject" Then
            ' Get the UserID from CommandArgument
            Dim userId As Integer = Convert.ToInt32(e.CommandArgument)

            ' Update the database with the rejection
            obj.RejectRequestFollow(userId)

            ' Find the clicked button in the GridView row
            Dim row As GridViewRow = DirectCast(DirectCast(e.CommandSource, Control).NamingContainer, GridViewRow)
            Dim btnReject As Button = DirectCast(row.FindControl("btnReject"), Button)

            ' Update the button properties to indicate rejection
            btnReject.Text = "تم الرفض"
            btnReject.BackColor = System.Drawing.Color.DarkRed
            btnReject.ForeColor = System.Drawing.Color.White
            btnReject.Enabled = False

            ' Optionally display a rejection status in another column (if needed)
            Dim lblStatus As Label = DirectCast(row.FindControl("lblStatus"), Label)
            If lblStatus IsNot Nothing Then
                lblStatus.Text = "تم الرفض"
                lblStatus.ForeColor = System.Drawing.Color.DarkRed
            End If
        End If
    End Sub

    Protected Sub g_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g.SelectedIndexChanged

    End Sub
End Class