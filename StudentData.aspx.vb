Public Class StudentData
    Inherits System.Web.UI.Page
    Dim obj As New DbOp

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If User.Identity.IsAuthenticated Then
            Dim ds As DataSet = obj.getStudentData(User.Identity.Name)
            If ds.Tables(0).Rows.Count > 0 Then
                GridView1.DataSource = ds
                GridView1.DataBind()
            Else
                MsgBox("No records found.")
            End If
        Else
            MsgBox("Please log in to see your data.")
        End If


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class