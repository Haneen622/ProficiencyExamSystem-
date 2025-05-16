

Public Class DisplayData
    Inherits System.Web.UI.Page

    Dim obj As New DbOp
    Dim queryType As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            queryType = Request.QueryString("type")

            ' Debug: Output queryType value
            PageTitleLabel.Text = "Query Type: " & queryType

            If Not String.IsNullOrEmpty(queryType) Then
                Select Case queryType
                    Case "absent"
                        PageTitleLabel.Text &= "<br />Absentees List"
                        Dim ds As DataSet = obj.BindData("SELECT TOP (1000) [faculty], [full_name], [student_id] FROM [proficiency_exam].[dbo].[students] WHERE [exam_registered] = 'لم يتقدم'")
                        BindGridView(ds)

                    Case "attendees"
                        PageTitleLabel.Text &= "<br />Attendees List"
                        Dim ds As DataSet = obj.BindData("SELECT TOP (1000) [faculty], [full_name], [student_id] FROM [proficiency_exam].[dbo].[students] WHERE [exam_registered] = 'تقدم'")
                        BindGridView(ds)

                    Case "requests"
                        PageTitleLabel.Text &= "<br />Requests List"
                        Dim ds As DataSet = obj.BindData("SELECT TOP (1000) [RequestName], [RequestDate], [UserID] FROM Requests")
                        BindGridView(ds)

                    Case Else
                        PageTitleLabel.Text = "No query type provided."
                End Select
            Else
                PageTitleLabel.Text = "No query type provided."
            End If
        End If
    End Sub

    Public Sub BindGridView(ds As DataSet)
        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            GridView1.DataSource = ds
            GridView1.DataBind()
        Else
            ' Display a message if no records are found
            MsgBox(">No records found.")
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

End Class
