'Public Class MakeupExamDateForStudent
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

'    End Sub

'End Class

'Partial Class MakeupExamDateForStudent
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        ' Check if the session contains the full announcement
'        If Session("FullAnnouncement") IsNot Nothing Then
'            ' Retrieve the announcement
'            Dim fullAnnouncement As String = Session("FullAnnouncement").ToString()
'            ' Display the announcement in the label
'            lblAnnouncement.Text = fullAnnouncement
'        End If
'    End Sub
'End Class

'Partial Class MakeupExamDateForStudent
'    Inherits System.Web.UI.Page

'    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
'        ' Retrieve the full announcement from Application state
'        Dim announcement As String = If(Application("FullAnnouncement"), "لا توجد تحديثات حالياً.", "لا توجد تحديثات حالياً.")

'        ' Set the text of the label to display the announcement
'        lblAnnouncement.Text = announcement
'    End Sub
'End Class

Partial Class MakeupExamDateForStudent
    Inherits System.Web.UI.Page
    Dim obj As New DbOp

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Retrieve the latest announcement as a string
        Dim announcements As String = obj.GetAnnouncements()

        If Not String.IsNullOrEmpty(announcements) Then
            ' Display the announcements in the label
            lblAnnouncement.Text = announcements
        Else
            lblAnnouncement.Text = "لا توجد تحديثات حالياً."
        End If
    End Sub
End Class


