Imports System.Drawing.Color
Public Class RequestMakeUpExam
    Inherits System.Web.UI.Page
    Dim obj As New DbOp
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (obj.CheckExamSubmission(User.Identity.Name) = False) Then   'must add condition where the الطالب لم يقدم الامتحان 
            Label2.ForeColor = System.Drawing.Color.Green
            'foog
            Label2.Text = "لقد تم تقديم طلبك بنجاح،يمكنك الآن متابعة حالة طلبك "
            obj.InsertCompensatoryExamRequest(User.Identity.Name)

        Else
            Label2.ForeColor = System.Drawing.Color.Red
            Label2.Text = "لا يحق لك طلب امتحان تعويضي لأنك قمت باجتياز الاختبار, يرجى الاتصال بالإدارة إذا كنت تعتقد أن هذا خطأ"
        End If



    End Sub
End Class