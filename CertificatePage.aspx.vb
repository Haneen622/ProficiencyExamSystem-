'Public Class CertificatePage
'    Inherits System.Web.UI.Page

'    Public Class CertificatePage
'        Inherits System.Web.UI.Page
'        Dim obj As New DbOp ' Database operation object

'        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
'            '    If Not IsPostBack Then
'            '        ' Fetch user details from the database based on logged-in user
'            '        Dim userName As Integer = User.Identity.Name
'            '        Dim fullName As String = obj.GetUserName(userName) ' Retrieve full name from database

'            '        '    If Not String.IsNullOrEmpty(fullName) Then
'            '        '        lblCertificateName.Text = fullName
'            '        '    Else
'            '        '        lblCertificateName.Text = "اسم غير متوفر"
'            '        '    End If
'            '    End If
'        End Sub
'    End Class





'End Class
Public Class CertificatePage
    Inherits System.Web.UI.Page

    Dim obj As New DbOp


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                ' Fetch the student details using session ID
                Dim sid As Integer = Convert.ToInt32(User.Identity.Name) ' Ensure the User.Identity.Name is convertible
                Dim fullName As String = obj.GetUserName(sid)
                Dim collegeName As String = obj.GetCollegeName(sid)
                Dim majorName As String = obj.GetMajorName(sid)

                ' Populate the certificate labels
                lblStudentName.Text = If(String.IsNullOrEmpty(fullName), "اسم الطالب غير معروف", fullName)
                lblCollege.Text = If(String.IsNullOrEmpty(collegeName), "الكلية غير معروفة", collegeName)
                lblMajor.Text = If(String.IsNullOrEmpty(majorName), "التخصص غير معروف", majorName)
            Catch ex As Exception
                ' Handle exceptions gracefully
                lblStudentName.Text = "خطأ في عرض البيانات"
                lblCollege.Text = ""
                lblMajor.Text = ""
            End Try
        End If
    End Sub

End Class
