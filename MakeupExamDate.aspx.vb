
Imports System.Data.SqlClient
Imports System.Web.UI

Partial Class MakeupExamDate
    Inherits System.Web.UI.Page

    Dim obj As New DbOp

    ' Button click event for updating the announcement
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Collect input values from the form
            Dim examDate As String = txtExamDate.Value
            Dim examDay As String = txtExamDay.Value
            Dim session1 As String = txtSession1.Value
            Dim session2 As String = txtSession2.Value
            Dim location As String = txtLocation.Value

            ' Build the full announcement text
            Dim announcementText As String = String.Format("تحية طيبة وبعد،<br />" &
            "ستقوم هيئة اعتماد مؤسسات التعليم العالي وضمان جودتها بعقد امتحان كفاءة تكميلي للطلبة المتوقع تخرجهم على الفصل الدراسي الأول من العام الجامعي 2024-2025 والذين تغيبوا عن الامتحان الأخير.<br />" &
            "وذلك يوم {0} الموافق {1}.<br />" &
            "الجلسة الأولى: {2}<br />" &
            "الجلسة الثانية: {3}<br />" &
            "مكان عقد الامتحان: {4}", examDay, examDate, session1, session2, location)

            ' Call the InsertAnnouncement method with all required values
            obj.InsertAnnouncement(examDate, examDay, session1, session2, location, announcementText)

            ' Show success message on the page
            lblMessage.Text = "تم تحديث الإعلان بنجاح!"
            lblMessage.ForeColor = System.Drawing.Color.Green
        Catch ex As Exception
            ' Log error to debug the issue
            Debug.WriteLine("Error: " & ex.Message)
            lblMessage.Text = "حدث خطأ أثناء تحديث الإعلان: " & ex.Message
            lblMessage.ForeColor = System.Drawing.Color.Red
        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
