Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Web
Imports System.Security.AccessControl
Imports iTextSharp.text.html.simpleparser

Public Class DbOp
    Dim con As New SqlConnection("Server=DESKTOP-1GEIFM3\TESTINSTANCE;Database=proficiency_exam;User Id=sa;Password=0226320;")


    Sub OpenDB()
        Try
            If con.State = 0 Then
                con.Open()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Function CheckExamSubmission(sid As Integer) As Boolean

        Dim query As String = "SELECT exam_registered FROM students WHERE student_id = @sid"
        Try
            Dim command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@sid", sid)
            OpenDB()
            Dim result As Object = command.ExecuteScalar() ' Executes and retrieves the value

            ' Check if the result is valid and equals "took the exam"
            If result IsNot Nothing AndAlso result.ToString() = "تقدم" Then
                Return True ' Student has taken the exam
            Else
                Return False ' Student has not taken the exam or no valid result
            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function
    Function CheckFollowApprove(sid As Integer) As Boolean

        Dim query As String = "SELECT [followApprove] FROM [Requests] WHERE UserID = @sid"
        Try
            Dim command As New SqlCommand(query, con)
            command.Parameters.AddWithValue("@sid", sid)
            OpenDB()
            Dim result As Object = command.ExecuteScalar() ' Executes and retrieves the value

            ' Check if the result is valid and equals "took the exam"
            If result IsNot Nothing AndAlso result.ToString() = "مقبول" Then
                Return True ' Student has taken the exam
            Else
                Return False ' Student has not taken the exam or no valid result
            End If
            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function
    Sub InsertCertificateRequest(sid As Integer)
        Try
            ' Replace this with your database insertion logic
            ' Example using ADO.NET
            OpenDB()
            Dim cmd As New SqlCommand(" INSERT INTO [Requests] ([UserID] ,[RequestDate] ,[Status] ,[RequestName]) VALUES (@sid,@RequestDate,'قيد الانتظار','طلب شهادة اتمام امتحان الكفاءة')", con)
            cmd.Parameters.AddWithValue("@sid", sid)
            cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
        End Try
    End Sub

    Sub InsertCompensatoryExamRequest(sid As Integer)
        Try
            ' Replace this with your database insertion logic
            ' Example using ADO.NET
            OpenDB()
            Dim cmd As New SqlCommand("  INSERT INTO [Requests] ([UserID] ,[RequestDate] ,[Status] ,[RequestName]) VALUES (@sid,@RequestDate,'قيد الانتظار','طلب تقديم امتحان تعويضي')", con)
            cmd.Parameters.AddWithValue("@sid", sid)
            cmd.Parameters.AddWithValue("@RequestDate", DateTime.Now)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
        End Try
    End Sub

    Function getstudentstatus(sid As Integer) As Object
        Try
            OpenDB()  ' Make sure the database connection is open
            Dim Text As String = "SELECT TOP (1000) [Status] as 'حالة الطلب'
	  ,[RequestDate]as 'تاريخ الطلب'
	   ,[RequestName]as 'اسم الطلب' FROM Requests WHERE UserID = @sid"
            Dim adapter As New SqlDataAdapter(Text, con)
            Dim ds As New DataSet

            ' Adding the parameter for id
            adapter.SelectCommand.Parameters.AddWithValue("@sid", sid)

            ' Debugging: log the SQL query being executed
            Console.WriteLine("Executing query: " & Text)
            Console.WriteLine("Using Parameter: @sid = " & sid)

            ' Execute the query and fill the dataset
            adapter.Fill(ds)

            ' Check if the dataset contains any rows
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds
            Else
                MsgBox("No records found for the given ID.")
                Return Nothing
            End If

        Catch ex As Exception
            ' Detailed error information with inner exception and stack trace
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)

            If ex.InnerException IsNot Nothing Then
                MsgBox("Inner Exception: " & ex.InnerException.Message)
            End If

            ' You can also write the error to a log file for deeper investigation
            ' Example: LogError(ex)
            Return Nothing
        Finally
            closeDB()  ' Ensure connection is always closed
        End Try
    End Function


    Function getStudentData(sid As Integer) As DataSet
        Try
            OpenDB()  ' Make sure the database connection is open
            Dim Text As String = "SELECT [exam_registered] as 'تقدم للامتحان',
       [phone_number] as 'رقم الهاتف',
       [national_number] as 'الرقم الوطني',
       [nationality] as 'الجنسية',
       [semester] as 'الفصل',
       [academic_year] as 'السنة الدراسية',
       [student_status] as 'وضع الطالب',
       [gpa] as 'المعدل التراكمي',
       [faculty] as 'الكلية',
       [major] as 'التخصص',
       [full_name] as 'اسم الطالب',
       [student_id] as 'الرقم الجامعي'
FROM students
WHERE student_id = @sid"
            Dim adapter As New SqlDataAdapter(Text, con)
            Dim ds As New DataSet

            ' Adding the parameter for id
            adapter.SelectCommand.Parameters.AddWithValue("@sid", sid)

            ' Debugging: log the SQL query being executed
            Console.WriteLine("Executing query: " & Text)
            Console.WriteLine("Using Parameter: @sid = " & sid)

            ' Execute the query and fill the dataset
            adapter.Fill(ds)

            ' Check if the dataset contains any rows
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds
            Else
                MsgBox("No records found for the given ID.")
                Return Nothing
            End If

        Catch ex As Exception
            ' Detailed error information with inner exception and stack trace
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)

            If ex.InnerException IsNot Nothing Then
                MsgBox("Inner Exception: " & ex.InnerException.Message)
            End If

            ' You can also write the error to a log file for deeper investigation
            ' Example: LogError(ex)
            Return Nothing
        Finally
            closeDB()  ' Ensure connection is always closed
        End Try
    End Function

  Public Function GetUserName(sid As Integer) As String
    Try
        OpenDB() ' Ensure the database connection is open
        Dim query As String = "
            SELECT [full_name] AS 'اسم الطالب'
            FROM students
            WHERE student_id = @sid"
        Dim adapter As New SqlDataAdapter(query, con)
        Dim ds As New DataSet

        ' Add the parameter for student_id
        adapter.SelectCommand.Parameters.AddWithValue("@sid", sid)

        ' Debugging: Log the SQL query being executed
        Console.WriteLine("Executing query: " & query)
        Console.WriteLine("Using Parameter: @sid = " & sid)

        ' Execute the query and fill the dataset
        adapter.Fill(ds)

        ' Check if the dataset contains any rows
        If ds.Tables(0).Rows.Count > 0 Then
            ' Retrieve the value of the "full_name" column from the first row
            Dim fullName As String = ds.Tables(0).Rows(0)("اسم الطالب").ToString()
            Return fullName
        Else
            MsgBox("No records found for the given ID.")
            Return String.Empty
        End If
    Catch ex As Exception
        MsgBox("Error fetching user name: " & ex.Message)
        Return String.Empty
    Finally
        CloseDB() ' Ensure the database connection is closed
    End Try
End Function

    Public Function GetCollegeName(sid As Integer) As String
        Try
            OpenDB() ' Ensure the database connection is open
            Dim query As String = "SELECT [faculty] FROM students WHERE student_id = @sid"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim ds As New DataSet

            ' Add the parameter for student_id
            adapter.SelectCommand.Parameters.AddWithValue("@sid", sid)

            ' Debugging: Log the SQL query being executed
            Debug.WriteLine("Executing query: " & query)
            Debug.WriteLine("Using Parameter: @sid = " & sid)

            ' Execute the query and fill the dataset
            adapter.Fill(ds)

            ' Check if the dataset contains any rows
            If ds.Tables(0).Rows.Count > 0 Then
                ' Retrieve the value of the "faculty" column from the first row
                Dim faculty As String = ds.Tables(0).Rows(0)("faculty").ToString()
                Return faculty
            Else
                Debug.WriteLine("No records found for the given ID.")
                Return String.Empty
            End If
        Catch ex As Exception
            ' Log the error
            Debug.WriteLine("Error fetching college name: " & ex.Message)
            Return String.Empty
        Finally
            closeDB() ' Ensure the database connection is closed
        End Try
    End Function


    Public Function GetMajorName(sid As Integer) As String
        Try
            OpenDB() ' Ensure the database connection is open
            Dim query As String = "SELECT [major] FROM students WHERE student_id = @sid"
            Dim adapter As New SqlDataAdapter(query, con)
            Dim ds As New DataSet

            ' Add the parameter for student_id
            adapter.SelectCommand.Parameters.AddWithValue("@sid", sid)

            ' Debugging: Log the SQL query and parameter value
            Debug.WriteLine("Executing query: " & query)
            Debug.WriteLine("Using Parameter: @sid = " & sid)

            ' Execute the query and fill the dataset
            adapter.Fill(ds)

            ' Check if the dataset contains any rows
            If ds.Tables(0).Rows.Count > 0 Then
                ' Retrieve the value of the "major" column from the first row
                Dim majorName As String = ds.Tables(0).Rows(0)("major").ToString()
                Return majorName
            Else
                Debug.WriteLine("No records found for the given ID: " & sid)
                Return String.Empty
            End If
        Catch ex As Exception
            ' Log the error and rethrow if necessary
            Debug.WriteLine("Error fetching major name: " & ex.Message)
            Return String.Empty
        Finally
            closeDB() ' Ensure the database connection is closed
        End Try
    End Function



    Sub closeDB()
        Try
            If con.State = 1 Then
                con.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub




    Function Studentsyslogin(usr As String, pw As String) As String
        Try
            ' Checking student login
            Dim adStudent As New SqlDataAdapter("SELECT b.full_name FROM [proficiency_exam].[dbo].[students] a, [dbo].[Students] b WHERE a.Student_id = b.Student_id AND a.Student_id = @us AND a.password = @pw", con)
            adStudent.SelectCommand.Parameters.Add("@us", SqlDbType.NVarChar, 100).Value = usr
            adStudent.SelectCommand.Parameters.Add("@pw", SqlDbType.NVarChar, 100).Value = pw
            Dim dsStudent As New DataSet()
            OpenDB()
            adStudent.SelectCommand.Prepare()
            adStudent.Fill(dsStudent)

            If dsStudent.Tables(0).Rows.Count > 0 Then
                ' If student found
                Return "Student:" & dsStudent.Tables(0).Rows(0).Item(0).ToString()
            End If


            ' Check if the user is AQAC
            Dim adAQAC As New SqlDataAdapter("SELECT b.name FROM [proficiency_exam].[dbo].[AqacDirectors] a, [dbo].[AqacDirectors] b WHERE a.id = b.id AND a.id = @us AND a.password = @pw", con)

            adAQAC.SelectCommand.Parameters.Add("@us", SqlDbType.NVarChar, 100).Value = usr
            adAQAC.SelectCommand.Parameters.Add("@pw", SqlDbType.NVarChar, 100).Value = pw
            Dim dsAQAC As New DataSet()
            adAQAC.SelectCommand.Prepare()
            adAQAC.Fill(dsAQAC)

            If dsAQAC.Tables(0).Rows.Count > 0 Then
                ' If AQAC user found
                Return "AQAC:" & dsAQAC.Tables(0).Rows(0).Item(0).ToString()
            End If



            ' Check if the user is from FollowUpDirectors
            Dim adFollowUp As New SqlDataAdapter("SELECT b.name FROM [proficiency_exam].[dbo].[FollowUpDirectors] a, [dbo].[FollowUpDirectors] b WHERE a.id = b.id AND a.id = @us AND a.password = @pw", con)

            adFollowUp.SelectCommand.Parameters.Add("@us", SqlDbType.NVarChar, 100).Value = usr
            adFollowUp.SelectCommand.Parameters.Add("@pw", SqlDbType.NVarChar, 100).Value = pw
            Dim dsFollowUp As New DataSet()
            adFollowUp.SelectCommand.Prepare()
            adFollowUp.Fill(dsFollowUp)

            If dsFollowUp.Tables(0).Rows.Count > 0 Then
                ' If FollowUpDirector user found
                Return "FollowUp:" & dsFollowUp.Tables(0).Rows(0).Item(0).ToString()
            End If

            ' If not found in any table
            Return "Error"
        Catch ex As Exception
            ' Handle exceptions
            Return "Error"
        Finally
            closeDB()
        End Try
    End Function



    Public Function getRequestCertificateAQAC(requestname As String) As DataSet
        Dim ds As New DataSet()
        Try
            OpenDB() ' Ensure the database connection is open

            ' SQL query to fetch the relevant data
            Dim query As String = "SELECT [RequestDate] as 'تاريخ الطلب', 
                                          [RequestName] as 'اسم الطلب', 
                                          [UserID] as 'رقم الطالب' 
                                   FROM Requests WHERE requestname = @requestName"

            Using adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@requestName", requestname)
                adapter.Fill(ds)
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)
        Finally
            closeDB()
        End Try
        Return ds
    End Function

    Public Function getRequestCertificateThatApprovedByAQAC(requestname As String) As DataSet
        Dim ds As New DataSet()
        Try
            OpenDB() ' Ensure the database connection is open

            ' SQL query to fetch the relevant data
            Dim query As String = "SELECT [RequestDate] as 'تاريخ الطلب', 
[RequestName] as 'اسم الطلب', 
[UserID] as 'رقم الطالب' 
FROM Requests where [aqacApprove]='مقبول' and requestname = @requestName"

            Using adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@requestName", requestname)
                adapter.Fill(ds)
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)
        Finally
            closeDB()
        End Try
        Return ds
    End Function

    Public Function getRequestMAkeupExamThatApprovedByAQAC(requestname As String) As DataSet
        Dim ds As New DataSet()
        Try
            OpenDB() ' Ensure the database connection is open

            ' SQL query to fetch the relevant data
            Dim query As String = "SELECT [RequestDate] as 'تاريخ الطلب', 
[RequestName] as 'اسم الطلب', 
[UserID] as 'رقم الطالب' 
FROM Requests where [aqacApprove]='مقبول' and requestname = @requestName"

            Using adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@requestName", requestname)
                adapter.Fill(ds)
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)
        Finally
            closeDB()
        End Try
        Return ds
    End Function

    Public Function BindCertificateRequestsForFollow() As DataSet
        Return getRequestCertificateThatApprovedByAQAC("طلب شهادة اتمام امتحان الكفاءة")
    End Function
    Public Function BindMakeupExamRequestsForFollow() As DataSet
        Return getRequestMAkeupExamThatApprovedByAQAC("طلب تقديم امتحان تعويضي")

    End Function
    Public Function BindCertificateRequests() As DataSet
        Return getRequestCertificateAQAC("طلب شهادة اتمام امتحان الكفاءة")
    End Function

    Public Sub ApproveRequest(userId As Integer)
        Try
            OpenDB()

            ' SQL query to update request approval status
            Dim query As String = "UPDATE Requests SET aqacApprove = 'مقبول' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub ApproveFollowRequest(userId As Integer)
        Try
            OpenDB()

            ' SQL query to update request approval status
            Dim query As String = "UPDATE Requests SET [followApprove] = 'مقبول' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub UpdateRequestStatus(userId As Integer)
        Try
            OpenDB()

            Dim query As String = "UPDATE Requests SET [status] = 'مقبول' WHERE UserID = @UserID"

            ' Use a SqlCommand to execute the query
            Using cmd As New SqlCommand(query, con)
                ' Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery() ' Execute the query
            End Using


        Catch ex As Exception
            ' Handle any errors
            MsgBox("Error: " & ex.Message)
        Finally
            ' Ensure the connection is properly closed
            closeDB()
        End Try
    End Sub


    Public Sub RejectRequest(userId As Integer)
        Try
            OpenDB()

            ' SQL query to update request rejection status
            Dim query As String = "UPDATE Requests SET aqacApprove = 'مرفوض' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub ApproveMakeUpExamRequest(UserID As Integer)
        Try
            OpenDB()

            ' SQL query to approve makeup exam
            Dim query As String = "UPDATE  Requests SET [aqacApprove] = 'مقبول' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", UserID)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub RejectMakeUpExamRequest(userId As Integer)
        Try
            OpenDB()

            ' SQL query to reject makeup exam
            Dim query As String = "UPDATE Requests SET [aqacApprove] = 'مرفوض' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Sub RejectRequestFollow(userId As Integer)
        Try
            OpenDB()

            ' SQL query to reject makeup exam
            Dim query As String = "UPDATE Requests SET [followApprove] = 'مرفوض' WHERE UserID = @UserID"

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserID", userId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            closeDB()
        End Try
    End Sub

    Public Function getMakeUpExamRequests(requestname As String) As DataSet
        Dim ds As New DataSet()
        Try
            OpenDB() ' Ensure the database connection is open

            ' SQL query to fetch relevant data
            Dim query As String = "SELECT [RequestDate] AS 'تاريخ الطلب', 
                                      [RequestName] AS 'اسم الطلب', 
                                      [UserID] AS 'رقم الطالب' 
                               FROM Requests 
                               WHERE RequestName = @requestName"

            Using adapter As New SqlDataAdapter(query, con)
                adapter.SelectCommand.Parameters.AddWithValue("@requestName", requestname)
                adapter.Fill(ds)
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)
        Finally
            closeDB()
        End Try
        Return ds
    End Function



    Public Function getApprovalByfllow() As DataSet
        Dim query As String = "select [followApprove] as 'حالة الطلب'
,RequestName as 'اسم الطلب'
,UserId as 'رقم الطالب'
from [approvedRequests] "
        Dim ds As New DataSet()

        Using cmd As New SqlCommand(query, con)
            con.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(ds)
        End Using

        Return ds
    End Function





    Public Sub InsertAnnouncement(examDate As String, examDay As String, session1 As String, session2 As String, location As String, announcementText As String)
        Try
            If con.State = 0 Then
                con.Open()
            End If

            Dim cmd As New SqlCommand("INSERT INTO Announcements (ExamDate, ExamDay, Session1, Session2, Location, AnnouncementText) 
                               VALUES (@ExamDate, @ExamDay, @Session1, @Session2, @Location, @AnnouncementText)", con)

            ' Add parameters
            cmd.Parameters.AddWithValue("@ExamDate", examDate)
            cmd.Parameters.AddWithValue("@ExamDay", examDay)
            cmd.Parameters.AddWithValue("@Session1", session1)
            cmd.Parameters.AddWithValue("@Session2", session2)
            cmd.Parameters.AddWithValue("@Location", location)
            cmd.Parameters.AddWithValue("@AnnouncementText", announcementText)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error inserting announcement: " & ex.Message)
        Finally
            If con.State = 1 Then
                con.Close()
            End If
        End Try
    End Sub

    Function GetAnnouncements() As String
        Try
            OpenDB()
            ' Order by AnnouncementDate DESC if needed to get the most recent announcements
            Dim query As String = "SELECT [AnnouncementText] FROM Announcements"
            Dim command As New SqlCommand(query, con)
            Dim reader As SqlDataReader = command.ExecuteReader()

            Dim announcements As New Text.StringBuilder()

            ' Read the data and append to the string builder
            While reader.Read()
                announcements.AppendLine(reader("AnnouncementText").ToString())
            End While

            reader.Close()
            Return announcements.ToString().Trim()

        Catch ex As Exception
            MsgBox("Error retrieving announcements: " & ex.Message)
            Return String.Empty
        Finally
            closeDB()
        End Try
    End Function


    Public Function BindData(query As String) As DataSet
        Dim ds As New DataSet()

        Try
            ' Use the existing connection object 'con' to open the connection
            Using cmd As New SqlCommand(query, con)
                con.Open()

                ' Create a DataAdapter to fill the dataset with the query results
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds) ' Fill the dataset with the result of the query
                con.Close()
            End Using
        Catch ex As Exception
            ' Handle exceptions or log errors
            Throw New Exception("Error in executing query: " & ex.Message)
        End Try

        Return ds
    End Function



End Class



