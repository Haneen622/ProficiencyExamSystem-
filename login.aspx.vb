Public Class login
    Inherits System.Web.UI.Page
    Dim obj As New DbOp


    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    msg.Text = ""
    '    Dim stname As String = obj.Studentsyslogin(usr.Text, pw.Text)
    '    If stname <> "Error" Then
    '        Session("P1") = stname
    '        FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '        Response.Redirect("home.aspx")
    '    Else
    '        msg.Text = "خطأ في رقم المستخدم او كلمة المرور"
    '    End If
    'End Sub
    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    msg.Text = ""

    '    ' Call the login function
    '    Dim result As String = obj.Studentsyslogin(usr.Text, pw.Text)

    '    If result <> "Error" Then
    '        ' Split the result to get role (either "Student" or "AQAC") and username
    '        Dim userInfo As String() = result.Split(":")

    '        ' Store user name in session
    '        Session("P1") = userInfo(1)

    '        If userInfo(0) = "Student" Then
    '            ' Redirect to student home
    '            FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '            Response.Redirect("home.aspx")
    '        ElseIf userInfo(0) = "AQAC" Then
    '            ' Redirect to AQAC home
    '            FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '            Response.Redirect("homeAQAC.aspx") ' Change to AQAC home page
    '        End If
    '    Else
    '        ' Show an error message
    '        msg.Text = "خطأ في رقم المستخدم او كلمة المرور"
    '    End If
    'End Sub


    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    msg.Text = "" ' Clear any previous messages

    '    ' Call the login function
    '    Dim result As String = obj.Studentsyslogin(usr.Text, pw.Text)

    '    If result <> "Error" Then
    '        ' Split the result to get role (e.g., "Student", "AQAC", or "FollowUp") and username
    '        Dim userInfo As String() = result.Split(":"c)

    '        ' Store the user name in session
    '        Session("P1") = userInfo(1)

    '        ' Check the role and redirect accordingly
    '        If userInfo(0) = "Student" Then
    '            ' Redirect to student home
    '            FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '            Response.Redirect("home.aspx")
    '        ElseIf userInfo(0) = "AQAC" Then
    '            ' Redirect to AQAC home
    '            FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '            Response.Redirect("homeAQAC.aspx")
    '        ElseIf userInfo(0) = "FollowUp" Then
    '            ' Redirect to FollowUp home
    '            FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
    '            Response.Redirect("homeFollowUp.aspx") ' Replace with actual FollowUp home page
    '        End If
    '    Else
    '        ' Show an error message if login fails
    '        msg.Text = "خطأ في رقم المستخدم او كلمة المرور"
    '    End If
    'End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        msg.Text = "" ' Clear any previous messages

        ' Call the login function
        Dim result As String = obj.Studentsyslogin(usr.Text, pw.Text)

        If result <> "Error" Then
            ' Split the result to get role (e.g., "Student", "AQAC", or "FollowUp") and username
            Dim userInfo As String() = result.Split(":"c)

            ' Store the user name in session
            Session("P1") = userInfo(1)

            ' Check the role and redirect accordingly
            If userInfo(0) = "Student" Then
                ' Redirect to student home
                Session("RedirectToPage") = "~/home.aspx"
                FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
                Response.Redirect("home.aspx")
            ElseIf userInfo(0) = "AQAC" Then
                ' Redirect to AQAC home
                Session("RedirectToPage") = "~/homeAQAC.aspx"
                FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
                Response.Redirect("homeAQAC.aspx")
            ElseIf userInfo(0) = "FollowUp" Then
                ' Redirect to FollowUp home
                Session("RedirectToPage") = "~/homeFollowUp.aspx"
                FormsAuthentication.RedirectFromLoginPage(usr.Text, False)
                Response.Redirect("homeFollowUp.aspx")
            End If
        Else
            ' Show an error message if login fails
            msg.Text = "خطأ في رقم المستخدم او كلمة المرور"
        End If
    End Sub


End Class