Imports System.Drawing.Color

Public Class RequestCertificate
    Inherits System.Web.UI.Page
    Dim obj As New DbOp
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button1.Visible = False
    End Sub
    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Button1.Visible = True
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If obj.CheckExamSubmission(User.Identity.Name) Then
            ' User passed the exam and can request a certificate
            Label2.Text = "لقد تم تقديم طلبك بنجاح، يمكنك الآن متابعة حالة طلبك "
            Label2.ForeColor = System.Drawing.Color.Green

            obj.InsertCertificateRequest(User.Identity.Name)
        Else
            ' User has NOT taken the exam, so show a message
            Label2.Text = "لا يحق لك طلب شهادة لأنك لم تقم باجتياز الاختبار, يرجى الاتصال بالإدارة إذا كنت تعتقد أن هذا خطأ"
            Label2.ForeColor = System.Drawing.Color.Red
        End If
    End Sub


End Class