﻿Public Class CheckStatusFollow
    Inherits System.Web.UI.Page
    Dim obj As New DbOp
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'select status column from table request 
        g.DataSource = obj.getApprovalByfllow()
        g.DataBind()
    End Sub

    Protected Sub g_SelectedIndexChanged(sender As Object, e As EventArgs) Handles g.SelectedIndexChanged

    End Sub
End Class