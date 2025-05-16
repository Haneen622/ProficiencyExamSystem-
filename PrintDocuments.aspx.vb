Imports System ' Make sure this line is at the top
Imports System.Data
Public Class PrintDocuments
    Inherits System.Web.UI.Page


    Dim obj As New DbOp

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim examCompleted As Boolean = obj.CheckExamSubmission(User.Identity.Name)
            Dim followApprove As Boolean = obj.CheckFollowApprove(User.Identity.Name)
            If examCompleted And followApprove Then
                lblMessage.Text = "يمكنك الآن طباعة الشهادة."
                btnPrintCertificate.Enabled = True
            Else
                lblMessage.Text = " يجب ان تكون تقدمت للامتحان أو تمت الموافقة على طلب الحصول على الشهادة"
                btnPrintCertificate.Enabled = False
            End If
        End If
    End Sub
    Dim filePath As String = "C:\Users\CW\OneDrive\Desktop\Universty\Hci\HciProject"

    Protected Sub btnPrintCertificate_Click(sender As Object, e As EventArgs) Handles btnPrintCertificate.Click
        ' Redirect to Certificate Page
        Response.Redirect("CertificatePage.aspx")
    End Sub

End Class